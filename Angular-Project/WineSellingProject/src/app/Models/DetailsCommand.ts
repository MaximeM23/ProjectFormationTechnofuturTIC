import { Address } from "./Address";

export class DetailsCommand {
    dateOfCommand: Date;
    address: Address;
    firstname: string;
    lastname:string;
    emailAddress:string;
    winedetails: wineDetailsForCommand[]

    constructor(DateOfCommand: Date, Address: Address,FirstName: string,LastName: string, emailAddress: string,
        WineDetails:wineDetailsForCommand[]) {
        this.dateOfCommand = DateOfCommand;
        this.address = Address;
        this.firstname = FirstName;
        this.lastname = LastName;
        this.emailAddress = emailAddress;
        this.winedetails = WineDetails
    }
}

export class wineDetailsForCommand {
    wineName: string;
    winePrice: number;
    quantity: number;

    constructor(WineName: string, winePrice: number, quantity: number) {
        this.wineName = WineName;
        this.winePrice = winePrice;
        this.quantity = quantity;
    }
}