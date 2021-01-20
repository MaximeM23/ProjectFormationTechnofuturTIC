export class Price {
    price: number;
    dateOfPrice?: Date;
    
    constructor(price: number, dateOfPrice?: Date) {
        this.price = price;
        this.dateOfPrice = dateOfPrice
    }
}
