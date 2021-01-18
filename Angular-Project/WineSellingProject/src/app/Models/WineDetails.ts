import { Category } from "./Category";
import { Price } from "./Price";
import { Comment } from "./Comment";

export class WineDetails {
    id: number;
    wineName: string;
    disabled: boolean;
    prices: Price[];
    year: number;
    description: string;
    category: Category[];
    comment: Comment[];

    constructor(id: number,wineName: string, disabled: boolean, prices: Price[], year, description: string, category: Category[], comment : Comment[]) {
        this.id = id;
        this.disabled = disabled;
        this.prices = prices;
        this.year = year;
        this.wineName = wineName;
        this.description = description;
        this.category = category;
        this.comment = comment;
    }
}

