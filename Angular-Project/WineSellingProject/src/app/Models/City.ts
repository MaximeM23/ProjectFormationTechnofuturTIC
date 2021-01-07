export class City {
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
