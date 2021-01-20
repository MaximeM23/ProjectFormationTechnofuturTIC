import { Category } from "./Category";
import { Price } from "./Price";

export class WineToInsert {
    
    wineName: string;
    price: Price;
    year: number;
    description: string;
    category: Category[];

    constructor(wineName: string, price: Price, year, description: string, category: Category[]) {
        this.year = year;
        this.price = price;
        this.wineName = wineName;
        this.description = description;
        this.category = category;
    }
}
