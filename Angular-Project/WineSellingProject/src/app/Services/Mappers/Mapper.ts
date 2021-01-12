import { Injectable } from "@angular/core";
import { City } from 'src/app/Models/City'

@Injectable({
    providedIn: 'root'
  })
export class CityMapper {

    constructor() {
        
    }
    jsonToCity(dt: any): City[]{
        let Cities : City[] = [];
        for(let i = 0; i < dt.length; i++)
        {
            Cities.push(new City(dt[i]["id"],
                               dt[i]["Country"],
                               dt[i]["postalCode"],
                               dt[i]["cityName"]));
        }
        return Cities;
    }
}
