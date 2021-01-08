import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoggedInformation } from 'src/app/Models/LoggedInformation';
import { ClientService } from 'src/app/Services/Client.service';
import { LogginClientService } from 'src/app/Services/LogginClient.service';
import jwt_decode from "../../../../node_modules/jwt-decode"

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  registerForm: FormGroup;
  invalidLogin: boolean;
  decrypted_token: any;

  constructor(private formBuilder: FormBuilder,
              private router: Router,
              private clientService: ClientService,
              private logService: LogginClientService) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      emailLog: this.formBuilder.control('',[Validators.required, Validators.email,Validators.minLength(3)]),
      passwordLog: this.formBuilder.control('',[Validators.required,Validators.minLength(3)])
    });

    this.registerForm = this.formBuilder.group({
      emailRegister: this.formBuilder.control('',[Validators.required, Validators.email,Validators.minLength(3)]),
      passwordRegister: this.formBuilder.control('',[Validators.required,Validators.minLength(3)]),
      confPwdRegister: this.formBuilder.control('',[Validators.required,Validators.minLength(3)])
    });
  }

  OnLoginSubmit(form: NgForm): void {    
    const credentials = {
      'emailAddress': form["emailLog"],
      'password': form["passwordLog"]      
    }
    this.logService.logClient(credentials).subscribe(response =>
      {
        const token = (<any>response).token;
        sessionStorage.setItem("jwt",token);
        this.invalidLogin = false;
        this.decrypted_token = jwt_decode(token);
        this.clientService.connectedClient = new LoggedInformation(
          this.decrypted_token["UserId"],
          this.decrypted_token["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"],
          this.decrypted_token["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"],
          this.decrypted_token["exp"]
          );           
        sessionStorage.setItem("userInfo",JSON.stringify(this.clientService.connectedClient));
        this.router.navigate(["/accueil"]);
      }, err =>{
        this.invalidLogin = true;       
      });
  }

}

       