export class CommentToSend {
    id: number;
    commentValue: string;
    note: number;
    idClient: number;
    idWine: number;    

    /**
     *
     */
    constructor(Id:number, comment: string, note: number, isUser :number, idWine : number) {
        this.id = Id;
        this.commentValue = comment;
        this.note = note;
        this.idClient = isUser;
        this.idWine = idWine;
    }
}
