export class Comment {
    comment: string;
    note: number;
    firstname:string;
    lastname: string;

    /**
     *
     */
    constructor(comment: string, note: number, firstname:string, lastname: string) {
        this.comment = comment;
        this.note = note;
        this.firstname = firstname;
        this.lastname = lastname;
    }
}
