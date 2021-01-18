import { Injectable } from '@angular/core';
import { Category } from 'src/app/Models/Category';
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
  let categories: Category [] = []
  for(let i =0; i < dt.length;i++)
  {
    for(let j = 0 ;j < dt[i]["prices"].length; j++)
    {
      prices.push(new Price(dt[i]["prices"][j]["priceWine"],dt[i]["prices"][j]["dateOfPrice"]))
    }
    for(let k = 0; k < dt[i]["category"].length; k++)
    {
      categories.push(new Category(dt[i]["category"][0]["id"],dt[i]["category"][0]["categoryName"],dt[i]["category"][0]["tag"]["id"]));
    }
    wines.push(new Wine(dt[i]["id"],dt[i]["wineName"],dt[i]["disabled"],prices,dt[i]["year"],dt[i]["description"],categories))
    prices = []
    categories= []
  }
  return wines;
  
}

}
