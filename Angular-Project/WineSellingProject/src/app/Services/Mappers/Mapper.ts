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
                               dt[i]["country"],
                               dt[i]["postalCode"],
                               dt[i]["cityName"]));
        }
        return Cities;
    }
}
/*
if(!Cities.find(x => x.Country == dt[i]["country"]))
{
    Cities.push(new City(dt[i]["id"],
                    dt[i]["country"],
                    dt[i]["postalCode"],
                    dt[i]["cityName"]));
}
else if(Cities.length == 0)
{
    Cities.push(new City(dt[i]["id"],
                    dt[i]["country"],
                    dt[i]["postalCode"],
                    dt[i]["cityName"]));
}*/
