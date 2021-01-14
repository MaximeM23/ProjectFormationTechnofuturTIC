import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import jwt_decode from "../../../node_modules/jwt-decode";
import { LoggedInformation } from '../Models/LoggedInformation';
import { ClientService } from './ClientService/Client.service';

@Injectable({
  providedIn: 'root'
})
export class SessionStorageService {

  decrypted_token: any;

  constructor() { }

  recoverIdUser() : number{
    if(sessionStorage.getItem("userInfo") != null)
    {
      let idUser;
      idUser = JSON.parse(sessionStorage.getItem("userInfo"))
      return idUser["userId"];
    }
    return null;
  }

  updateSessionInformation(response : any) {
    //TODO: need to recover the full use in order to regenerate the token
    const token = (<any>response).token;
    sessionStorage.setItem("jwt",token);
    this.decrypted_token = jwt_decode(token);
    let dt = new LoggedInformation(
      this.decrypted_token["UserId"],
      this.decrypted_token["http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name"],
      this.decrypted_token["http://schemas.microsoft.com/ws/2008/06/identity/claims/role"],
      this.decrypted_token["exp"]
      );           
    sessionStorage.setItem("userInfo",JSON.stringify(dt));
  }

}
