import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Address } from 'src/app/Models/Address';
import { Client } from 'src/app/Models/Client';
import { ClientService } from 'src/app/Services/ClientService/Client.service';
import { ClientMapperService } from 'src/app/Services/Mappers/ClientMapper.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';
import { DateValidatorMinLength } from 'src/app/Services/Validators/dateValidator';
import { PasswordUpdateValidatorMaxLength, PasswordUpdateValidatorMinLength, PasswordValidatorMaxLength, PasswordValidatorMinLength } from 'src/app/Services/Validators/passwordValidator';

@Component({
  selector: 'app-Details-Client',
  templateUrl: './Details-Client.component.html',
  styleUrls: ['./Details-Client.component.scss'],
  providers:[DatePipe]
})
export class DetailsClientComponent implements OnInit {
    
  client: Client;
  get getClientAddresses(): Address[] {
    if(this.client.Addresses !== undefined){
      return this.client.Addresses;
    }
  }

  successUpdate: boolean;
  constructor(private _sessionService: SessionStorageService,private _clientService: ClientService, private _clientMapper: ClientMapperService, private _formBuilder: FormBuilder, private _datepipe: DatePipe) { }
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
        birthDate: this._formBuilder.control(this._datepipe.transform(this.client.BirthDate,"yyyy-MM-dd"),[Validators.required]),
        phoneNumber: this._formBuilder.control(this.client.PhoneNumber,[Validators.required,Validators.minLength(8),Validators.maxLength(50)]),
        email: this._formBuilder.control(this.client.EmailAddress,[Validators.required, Validators.email,Validators.minLength(3),Validators.maxLength(50)]),
        password: this._formBuilder.control('',[PasswordUpdateValidatorMaxLength, PasswordUpdateValidatorMinLength]),
        confirmPassword: this._formBuilder.control('',[PasswordValidatorMaxLength, PasswordValidatorMinLength])
      });      
    });
  }

  OnProfilChangeSubmit(value: NgForm): boolean{  
      if((this.profileForm.controls["password"].dirty) && (this.profileForm.controls["confirmPassword"].dirty))
      {
        if(value['password'] != value['confirmPassword']) return false;
        console.log(value['password'])
        this.client.Firstname =   value["firstname"];
        this.client.Lastname =    value["lastname"];
        this.client.BirthDate =   value["birthDate"];      
        this.client.PhoneNumber = value["phoneNumber"];    
        this.client.Password =    value["password"];
        this.client.EmailAddress =value["email"];
        this.client.Firstname =   value["firstname"];
        
        this._clientService.UpdateClientInformation(this.client).subscribe(dt =>
          {
            if(dt != null)
            {
              this._sessionService.updateSessionInformation(dt);
              this.successUpdate = true;  
            }           
          }
          );      
      }
      else {
        // modification without password  
        this.client.Firstname =   value["firstname"];
        this.client.Lastname =    value["lastname"];
        this.client.BirthDate =   value["birthDate"];      
        this.client.PhoneNumber = value["phoneNumber"];
        this.client.EmailAddress =value["email"];
        this.client.Firstname =   value["firstname"];
        this._clientService.UpdateClientInformation(this.client).subscribe(dt =>
          {
            console.log(dt);
            if(dt != null)
            {
              this._sessionService.updateSessionInformation(dt);
              this.successUpdate = true;  
            }           
          }
          );      
      }
      return true;    
  }
  
}
