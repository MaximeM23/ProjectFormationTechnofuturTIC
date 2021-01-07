import { Injectable } from '@angular/core';
import { Address } from 'src/app/Models/Address';
import { City } from 'src/app/Models/City';
import { Client } from 'src/app/Models/Client';
import { Role } from 'src/app/Models/Role';

@Injectable({
  providedIn: 'root'
})
export class ClientMapperService {

  tmpAddresses: any[] = []
constructor() { }

public jsonToClient(dt: any): Client
{
  let addresses: Address[] = [];
  this.tmpAddresses = dt["addresses"];
  for(let i =0; i < this.tmpAddresses.length;i++)
  {
    addresses.push(new Address(
      this.tmpAddresses[i]["id"],
      this.tmpAddresses[i]["street"],
      this.tmpAddresses[i]["number"],
      new City(
        this.tmpAddresses[i]["city"]["id"],
        this.tmpAddresses[i]["city"]["country"],
        this.tmpAddresses[i]["city"]["postalCode"],        
        this.tmpAddresses[i]["city"]["cityName"],
      )));
  }
  return new Client(
    dt["id"],
    dt["firstname"],
    dt["lastname"],
    dt["phoneNumber"],
    dt["emailAddress"],
    dt["password"],
    addresses,
    dt["birthDate"],
    dt["disabled"],
    new Role(dt["role"]["id"],dt["role"]["roleName"]));
}

}
