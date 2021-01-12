import { ICity } from "../interfaces/ICity";

export class City implements ICity{
    Id: number;
    Country: string;
    PostalCode: string;
    CityName: string;

    constructor(Id: number, Country: string, PostalCode: string, CityName: string) {
        this.Id = Id;
        this.Country = Country;
        this.PostalCode = PostalCode;
        this.CityName = CityName;
    }
}
