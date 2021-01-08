import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Form, FormBuilder, FormGroup, NgForm, Validators } from '@angular/forms';
import { Client } from 'src/app/Models/Client';
import { ClientService } from 'src/app/Services/Client.service';
import { ClientMapperService } from 'src/app/Services/Mappers/ClientMapper.service';
import { SessionStorageService } from 'src/app/Services/session-storage.service';

@Component({
  selector: 'app-Details-Client',
  templateUrl: './Details-Client.component.html',
  styleUrls: ['./Details-Client.component.scss'],
  providers:[DatePipe]
})
export class DetailsClientComponent implements OnInit {
  client: Client;
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
        birthDate: this._formBuilder.control(this._datepipe.transform(this.client.BirthDate,"yyyy-MM-dd"),[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        phoneNumber: this._formBuilder.control(this.client.PhoneNumber,[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        email: this._formBuilder.control(this.client.EmailAddress,[Validators.required, Validators.email,Validators.minLength(3),Validators.maxLength(50)]),
        password: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)]),
        confirmPassword: this._formBuilder.control('',[Validators.required,Validators.minLength(3),Validators.maxLength(50)])
      });
    });
  }

  OnProfilChangeSubmit(value: NgForm): boolean{
    
    if((value["password"].dirty) && (value["confirmPassword"].dirty))
    {
      if(value['password'].value != value['confirmPassword']) return false;
      // Modification with password
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
          //TODO need to pass data recover from user here
          //this._sessionService.updateSessionInformation();
        }
        );      
    }
    return true;
  }
  
}
