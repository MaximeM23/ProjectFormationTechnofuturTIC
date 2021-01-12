import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { IAddress } from 'src/app/interfaces/IAddress';
import { Address } from 'src/app/Models/Address';
import { City } from 'src/app/Models/City';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AddressService {

  private url = environment.apiUrl;
  
constructor(private _http: HttpClient) { }


  getCitiesByCountry(country: string): Subscribable<City>
  {    
    return this._http.get(this.url+ "Address/"+ country);
  }

  getAll() : Subscribable<Address>{
    return this._http.get(this.url+ "Address/")
  }
}
