import { Category } from "./Category";
import { Price } from "./Price";

export class Wine {
    id: number;
    wineName: string;
    disabled: boolean;
    prices: Price[];
    year: number;
    description: string;
    category: Category[];

    constructor(id: number,wineName: string, disabled: boolean, prices: Price[], year, description: string, category: Category[]) {
        this.id = id;
        this.disabled = disabled;
        this.prices = prices;
        this.year = year;
        this.wineName = wineName;
        this.description = description;
        this.category = category;
    }
}

