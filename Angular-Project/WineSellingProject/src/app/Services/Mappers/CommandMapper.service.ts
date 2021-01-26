import { Injectable } from '@angular/core';
import { Address } from 'src/app/Models/Address';
import { City } from 'src/app/Models/City';
import { CommandWine } from 'src/app/Models/CommandWine';
import { DetailsCommand, wineDetailsForCommand } from 'src/app/Models/DetailsCommand';

@Injectable({
  providedIn: 'root'
})
export class CommandMapperService {

constructor() { }

jsonToDetailsCommand(dt : any) : DetailsCommand {
  let cmdWine: wineDetailsForCommand[] = [];
  for(let i = 0; i < dt["commandwine"].length; i++)
  {
    cmdWine.push(new wineDetailsForCommand(dt["commandwine"][i]["wineName"],dt["commandwine"][i]["winePrice"],dt["commandwine"][i]["quantity"]))
  }
  return new DetailsCommand(dt["dateOfCommand"],
                            new Address(dt["address"]["id"],dt["address"]["street"],dt["address"]["number"],
                              new City(dt["address"]["city"]["id"],dt["address"]["city"]["country"],dt["address"]["city"]["postalCode"],dt["address"]["city"]["cityName"])
                              ),dt["client"]["firstname"],dt["client"]["lastname"],dt["client"]["emailAddress"],cmdWine);
}

}
