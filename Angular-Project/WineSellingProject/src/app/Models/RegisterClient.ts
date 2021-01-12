export class RegisterClient {
    EmailAddress: string;
    Password : string;

    /**
     *
     */
    constructor(emailAddress: string, password: string) {
        this.EmailAddress = emailAddress;
        this.Password = password
    }
}
