import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IClient } from '../interfaces/IClient';

@Injectable({
  providedIn: 'root'
})
export class LogginClientService {

private url = environment.apiUrl;

constructor(private _http: HttpClient) { }

logClient(credentials: any) : Subscribable<any>
{        
  return this._http.post<any>(this.url +"Login/",credentials);  
}
}
