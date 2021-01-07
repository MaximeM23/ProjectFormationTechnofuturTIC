import { Address } from "../Models/Address";
import { Role } from "../Models/Role";

export interface IClient {        
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
    
}
