import { Price } from "./Price";

export class Cart {
    id: number;
    wineName: string;
    disabled: boolean;
    price: number;
    quantity: number;

    constructor(id: number, wineName: string,disabled: boolean, price: number, qt: number) {
        this.id = id;
        this.wineName = wineName;
        this.disabled = disabled;
        this.price = price;        
        this.quantity = qt;
    }
}
