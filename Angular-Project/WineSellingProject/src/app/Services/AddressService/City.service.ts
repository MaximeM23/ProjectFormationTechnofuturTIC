import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CityService {
  
  private url = environment.apiUrl;

  constructor(private _http : HttpClient) { }

  getAll() : Subscribable<any> {
    return this._http.get(this.url+"City");
  }

  getCountries() : Subscribable<any> {
    return this._http.get(this.url+ "Countries")
  }

  getCities(country: string): Subscribable<any> {
    return this._http.get(this.url + "City/" + country)
  }

  getCP(city: string): Subscribable<any> {
    return this._http.get(this.url+"PostalCode/"+city)
  }

}
