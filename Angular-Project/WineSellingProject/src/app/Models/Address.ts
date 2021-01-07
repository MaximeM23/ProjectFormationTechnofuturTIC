import { City } from "./City";

export class Address {
    
    Id: number;
    Street: string;
    Number: number;
    City: City;

 
    constructor(Id: number, Street: string, Number: number, City: City) {
        this.Id = Id;
        this.Street = Street;
        this.Number = Number;
        this.City = City;
    }
    
}
