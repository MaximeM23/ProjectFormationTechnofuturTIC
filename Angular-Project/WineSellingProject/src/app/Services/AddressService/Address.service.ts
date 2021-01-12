import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { IAddress } from 'src/app/interfaces/IAddress';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AddressService {

  private url = environment.apiUrl;
  
constructor(private _http: HttpClient) { }


getUserById(country: string): Subscribable<IAddress>
{    
  return this._http.get(this.url+ "Address/"+ country);
}
}
