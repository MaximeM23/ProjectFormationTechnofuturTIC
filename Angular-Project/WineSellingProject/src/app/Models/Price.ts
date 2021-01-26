export class Price {
    priceWine: number;
    dateOfPrice?: Date;
    
    constructor(price: number, dateOfPrice?: Date) {
        this.priceWine = price;
        this.dateOfPrice = dateOfPrice
    }
}
