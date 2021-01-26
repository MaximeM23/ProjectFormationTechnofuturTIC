import { Injectable } from '@angular/core';
import { Category } from 'src/app/Models/Category';
import { Price } from 'src/app/Models/Price';
import { Wine } from 'src/app/Models/Wine';
import { WineDetails } from 'src/app/Models/WineDetails';
import { Comment } from 'src/app/Models/Comment';

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


public jsonToDetailsWine(dt: any): WineDetails
{
  let wine: WineDetails
  let prices: Price[] = []
  let categories: Category [] = []
  let comments: Comment [] = [];
  for(let j = 0 ;j < dt["prices"].length; j++)
  {
    prices.push(new Price(dt["prices"][j]["priceWine"],dt["prices"][j]["dateOfPrice"]))
  }
  for(let k = 0; k < dt["category"].length; k++)
  {
    categories.push(new Category(dt["category"][0]["id"],dt["category"][0]["categoryName"],dt["category"][0]["tag"]["id"]));
  }
  for(let i = 0; i < dt["comments"].length; i++)
  {
    comments.push(new Comment(dt["comments"][i]["id"],dt["comments"][i]["commentValue"],dt["comments"][i]["note"],dt["comments"][i]["client"]["firstname"],dt["comments"][i]["client"]["lastname"],dt["comments"][i]["idWine"]))
  }
  wine = new WineDetails(dt["id"],dt["wineName"],dt["disabled"],prices,dt["year"],dt["description"],categories,comments)
  prices = []
  categories= []    
  return wine;
}


}
