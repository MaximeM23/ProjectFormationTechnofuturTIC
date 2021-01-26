export class Comment {
    id: number;
    comment: string;
    note: number;
    firstname:string;
    lastname: string;
    idWine: number;

    /**
     *
     */
    constructor(Id:number, comment: string, note: number, firstname:string, lastname: string, idWine : number) {
        this.id = Id;
        this.comment = comment;
        this.note = note;
        this.firstname = firstname;
        this.lastname = lastname;
        this.idWine = idWine;
    }

}
