import { CommandWine } from "./CommandWine";

export class Command {
    id: number;
    idClient: number;
    idAddress: number;
    CommandWine: CommandWine[];
    
    constructor(Id: number, IdClient: number, IdAddress: number, CommandWine : CommandWine[]) {
        this.id = Id;
        this.idClient = IdClient;
        this.idAddress = IdAddress;
        this.CommandWine = CommandWine;
    }
}
