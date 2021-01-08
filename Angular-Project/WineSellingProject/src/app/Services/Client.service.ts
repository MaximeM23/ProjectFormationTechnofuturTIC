import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IClient } from '../interfaces/IClient';
import { LoggedInformation } from '../Models/LoggedInformation';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  private url = environment.apiUrl;
  private _connectedClient : LoggedInformation;
  get connectedClient(): LoggedInformation{
    return this._connectedClient;
  }
  set connectedClient(value: LoggedInformation){
    this._connectedClient = value;
  }

  constructor(private _http: HttpClient) { 

  }
  
  getUserById(id: number): Subscribable<IClient>
  {    
    return this._http.get(this.url+ "Client/"+id);
  }

  getCurrentUser() : Subscribable<IClient>
  {
    return this._http.get(this.url + "Client/"+ this.connectedClient.userId);
  }
  
}

