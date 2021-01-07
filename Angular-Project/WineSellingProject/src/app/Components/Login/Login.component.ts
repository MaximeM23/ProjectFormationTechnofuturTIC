import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { ClientService } from 'src/app/Services/Client.service';

@Component({
  selector: 'app-Login',
  templateUrl: './Login.component.html',
  styleUrls: ['./Login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  registerForm: FormGroup;

  constructor(private formBuilder: FormBuilder,
              private router: Router,
              private clientService: ClientService) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      emailLog: this.formBuilder.control('',[Validators.required, Validators.email,Validators.minLength(3)]),
      passwordLog: this.formBuilder.control('',[Validators.required,Validators.minLength(3)])
    });

    this.loginForm = this.formBuilder.group({
      emailRegister: this.formBuilder.control('',[Validators.required, Validators.email,Validators.minLength(3)]),
      passwordRegister: this.formBuilder.control('',[Validators.required,Validators.minLength(3)]),
      confPwdRegister: this.formBuilder.control('',[Validators.required,Validators.minLength(3)])
    });
  }

  OnLoginSubmit(client: any): void {

  }

}
