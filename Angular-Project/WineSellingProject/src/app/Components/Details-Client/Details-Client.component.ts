import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Client } from 'src/app/Models/Client';
import { ClientService } from 'src/app/Services/Client.service';
import { ClientMapperService } from 'src/app/Services/Mappers/ClientMapper.service';

@Component({
  selector: 'app-Details-Client',
  templateUrl: './Details-Client.component.html',
  styleUrls: ['./Details-Client.component.scss'],
  providers:[DatePipe]
})
export class DetailsClientComponent implements OnInit {
  client: Client;
  constructor(private _clientService: ClientService, private _clientMapper: ClientMapperService, private _formBuilder: FormBuilder, private _datepipe: DatePipe) { }
  profileForm: FormGroup;
  ngOnInit() {
    this.profileForm = this._formBuilder.group({
      firstname: this._formBuilder.control(''),
      lastname: this._formBuilder.control(''),
      birthDate: this._formBuilder.control(''),
      phoneNumber: this._formBuilder.control(''),
      email: this._formBuilder.control(''),
      password: this._formBuilder.control(''),
      confirmPassword: this._formBuilder.control('')
    });
    this._clientService.getCurrentUser().subscribe((dt) =>
    {            
      this.client = this._clientMapper.jsonToClient(dt);
      this.profileForm = this._formBuilder.group({
        firstname: this._formBuilder.control(this.client.Firstname,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        lastname: this._formBuilder.control(this.client.Lastname,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        birthDate: this._formBuilder.control(this._datepipe.transform(this.client.BirthDate,"yyyy-MM-dd"),[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        phoneNumber: this._formBuilder.control(this.client.PhoneNumber,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        email: this._formBuilder.control(this.client.EmailAddress,[Validators.required, Validators.email,Validators.minLength(3),Validators.maxLength(50)]),
        password: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        confirmPassword: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)])
      });
    });
  }

  OnProfilChangeSubmit(value: NgForm): boolean{
    if(value.value('password').value != value.value('confirmPassword')) return false;
    passwordChanged : Boolean;
    client : Client;
    if((this.profileForm.controls["password"].dirty) && (this.profileForm.controls["confirmPassword"].dirty))
    {
      // Modification with password
    }
    else {
      // modification without password  
      this.client.Firstname =   this.profileForm.controls["firstname"].value;
      this.client.Lastname =    this.profileForm.controls["lastname"].value;
      this.client.BirthDate =   this.profileForm.controls["birthDate"].value;      
      this.client.PhoneNumber = this.profileForm.controls["phoneNumber"].value;
      this.client.EmailAddress =this.profileForm.controls["email"].value;
      this.client.Firstname =   this.profileForm.controls["firstname"].value;      
    }
    return true;
  }
  
}
