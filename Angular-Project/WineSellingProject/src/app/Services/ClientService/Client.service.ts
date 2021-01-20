import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { connected } from 'process';
import { Subscribable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IClient } from '../../interfaces/IClient';
import { Client } from '../../Models/Client';
import { LoggedInformation } from '../../Models/LoggedInformation';
import { RegisterClient } from '../../Models/RegisterClient';
import { SessionStorageService } from '../session-storage.service';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  private url = environment.apiUrl;

  constructor(private _http: HttpClient, private _sessionService: SessionStorageService) { 

  }
  
  getUserById(id: number): Subscribable<IClient>
  {    
    return this._http.get(this.url+ "Client/"+id);
  }

  getCurrentUser() : Subscribable<IClient>
  {     
    return this._http.get(this.url + "Client/"+ this._sessionService.recoverIdUser());
  }
  
  UpdateClientInformation(Client: Client) : Subscribable<any> {
    return this._http.put(this.url+"Client/" + this._sessionService.recoverIdUser(),Client);
  }

  RegisterClient(Client: RegisterClient) : Subscribable<RegisterClient>{
    return this._http.post(this.url + "Client",Client)
  }

}

