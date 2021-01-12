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

}
