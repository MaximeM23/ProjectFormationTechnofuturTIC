export class LoggedInformation {
    userId: number;
    username: string;
    role: string;

    /**
     *
     */
    constructor(userId: number, username: string, role: string) {
        this.userId = userId;
        this.username = username;
        this.role = role;
    }
}
