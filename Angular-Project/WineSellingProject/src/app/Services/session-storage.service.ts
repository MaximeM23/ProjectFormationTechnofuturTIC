import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SessionStorageService {

constructor() { }

recoverIdUser() : string{
  let idUser;
  idUser = JSON.parse(sessionStorage.getItem("userInfo"))
  return idUser["userId"];
}

}
