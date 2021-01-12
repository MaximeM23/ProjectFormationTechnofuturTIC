import { ICity } from "./ICity";

export interface IAddress {
    Id: number;
    Street: string;
    Number: number;
    City: ICity;
}
