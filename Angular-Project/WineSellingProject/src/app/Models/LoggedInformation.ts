export class LoggedInformation {
    userId: number;
    username: string;
    role: string;
    jwtexp: number;

    /**
     *
     */
    constructor(userId: number, username: string, role: string, jwtexp: number) {
        this.userId = userId;
        this.username = username;
        this.role = role;
        this.jwtexp= jwtexp;
    }
}
