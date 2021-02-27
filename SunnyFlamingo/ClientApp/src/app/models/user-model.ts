export class UserModel{
  firstName: string;
  lastName: string;
  email: string;
  constructor(options:{firstName: string, lastName: string, email: string}) {
    this.firstName = options.firstName;
    this.lastName = options.lastName;
    this.email = options.email;
  }
}