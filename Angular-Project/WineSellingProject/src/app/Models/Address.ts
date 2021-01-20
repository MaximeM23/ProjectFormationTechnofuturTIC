import { IAddress } from "../interfaces/IAddress";
import { City } from "./City";

export class Address implements IAddress{
    
    Id: number;
    Street: string;
    Number: number;
    City: City;

 
    constructor(Id: number, Street: string, number: number, City: City) {
        this.Id = Id;
        this.Street = Street;
        this.Number = number;
        this.City = City;
    }
    
}
