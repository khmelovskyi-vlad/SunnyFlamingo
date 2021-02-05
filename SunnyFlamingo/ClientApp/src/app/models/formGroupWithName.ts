import { FormGroup } from "@angular/forms";

export class FormGroupWithName{
  formGroup: FormGroup;
  name: string;
  constructor(options: {
    formGroup: FormGroup,
    name: string
  }) {
    this.formGroup = options.formGroup;
    this.name = options.name;
  }
}