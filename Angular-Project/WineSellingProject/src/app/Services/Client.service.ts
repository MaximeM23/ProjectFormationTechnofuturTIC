import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IClient } from '../interfaces/IClient';
import { Client } from '../Models/Client';

@Injectable({
  providedIn: 'root'
})
export class ClientService {

  private url = environment.apiUrl;

constructor(private _http: HttpClient) { 

  }
  
  getUserById(id: number): Subscribable<IClient>
  {
    return this._http.get(this.url+ "Client/"+id);
  }

  // getHeroesByTagName(name: string): Subscribable<any> {
  //   return this._http.get(this.url + '/search/' + name);
  // }
}

