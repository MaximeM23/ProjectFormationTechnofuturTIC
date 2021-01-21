import { Category } from "./Category";
import { Price } from "./Price";

export class WineToInsert {
    
    wineName: string;
    prices: Price[];
    year: number;
    description: string;
    category: Category[];
    idProvider: number;

    constructor(wineName: string, price: Price[], year, description: string, category: Category[], idProvider: number) {
        this.year = year;
        this.prices = price;
        this.wineName = wineName;
        this.description = description;
        this.category = category;
        this.idProvider = idProvider
    }
}
