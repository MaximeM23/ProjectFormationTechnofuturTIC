import { IClient } from "../interfaces/IClient";
import { Address } from "./Address";
import { Role } from "./Role";

export class Client implements IClient{
    
    Id: number; 
    Firstname: string;
    Lastname : string;
    PhoneNumber : string;
    EmailAddress : string;
    Password : string;
    Addresses : Address[];
    BirthDate :Date;
    Disabled : Boolean;
    Role : Role;
    
    constructor(Id: number, Firstname: string, Lastname : string, PhoneNumber : string, EmailAddress : string,Password : string, Addresses : Address[], BirthDate :Date, Disabled : Boolean, Role : Role) {
        this.Id= Id; 
        this.Firstname =Firstname;
        this.Lastname = Lastname;
        this.PhoneNumber = PhoneNumber;
        this.EmailAddress = EmailAddress;
        this.Password = Password;
        this. Addresses = Addresses;
        this.BirthDate = BirthDate;
        this.Disabled = Disabled;
        this.Role = Role;
    }
}
