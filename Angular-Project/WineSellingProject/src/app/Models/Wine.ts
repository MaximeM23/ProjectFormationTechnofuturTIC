import { Price } from "./Price";

export class Wine {
    id: number;
    wineName: string;
    disabled: boolean;
    prices: Price[];
    year: number;
    description: string;

    constructor(id: number,wineName: string, disabled: boolean, prices: Price[], year, description: string) {
        this.id = id;
        this.disabled = disabled;
        this.prices = prices;
        this.year = year;
        this.wineName = wineName;
        this.description = description;
    }
}


/*"id": 1,
"wineName": "Château le Chay Puisseguin Saint-Emilion",
"description": "Doux et puissant avec une belle longueur, le signe d'un grand vin. Les raisins récoltés en 2018 au Château Le Chay étaient tellement richement concentrés que les propriétaires décidèrent de produire une cuvée spéciale prestige à partir des plus beaux fruits. Un résultat à la hauteur !",
"year": 2018,
"disabled": false,
"category": null,
"prices": [
    {
        "dateOfPrice": "2021-01-15T15:15:59.597",
        "priceWine": 26
    }
],
"comments": null
},*/
