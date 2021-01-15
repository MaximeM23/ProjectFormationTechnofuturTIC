import { Injectable } from '@angular/core';
import { Price } from 'src/app/Models/Price';
import { Wine } from 'src/app/Models/Wine';

@Injectable({
  providedIn: 'root'
})
export class WineMapperService {

constructor() { }


public jsonToWine(dt: any): Wine[]
{
  let wines: Wine[] = []
  let prices: Price[] = []
  for(let i =0; i < dt.length;i++)
  {
    for(let j = 0 ;j < dt[i]["prices"].length; j++)
    {
      prices.push(new Price(dt[i]["prices"][j]["priceWine"],dt[i]["prices"][j]["dateOfPrice"]))
    }
    wines.push(new Wine(dt[i]["id"],dt[i]["disabled"],prices,dt[i]["year"]))
    prices = []
  }
  return wines;
  
}

}
