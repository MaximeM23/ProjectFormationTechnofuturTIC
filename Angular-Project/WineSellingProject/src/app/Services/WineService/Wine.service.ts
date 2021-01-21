import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { Category } from 'src/app/Models/Category';
import { Wine } from 'src/app/Models/Wine';
import { WineToInsert } from 'src/app/Models/wineToInsert';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WineService {
  
  private url = environment.apiUrl;

  constructor(private _http : HttpClient) { }

  getAllWine() : Subscribable<any>{
    return this._http.get(this.url + "wine")
  }

  getWineByWineId(id: string) : Subscribable<any> {
    return this._http.get(this.url + "wine/"+id);
  }

  getWineByProviderId(id: number): Subscribable<any> {
    return this._http.get(this.url + "wine/provider/"+id);
  }

  getWineCategoriesByTagId(id: number) : Subscribable<Category[]> {
    return this._http.get(this.url + "wine/categories/"+id);
  }

  insertNewWine(wine : WineToInsert) : Subscribable<Wine>{
    return this._http.post(this.url + "wine",wine);
  }

  disableWine(id: number) :Subscribable<any>{
    return this._http.delete(this.url + "wine/" + id);
  }
}
