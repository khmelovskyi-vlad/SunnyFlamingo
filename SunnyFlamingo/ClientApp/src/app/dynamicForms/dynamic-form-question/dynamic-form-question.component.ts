import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { InputType } from '../../valueObjects/inputType';

import { QuestionBase } from '../../models/questionBase';
import { ControlType } from '../../valueObjects/controlType';

@Component({
  selector: 'app-question',
  templateUrl: './dynamic-form-question.component.html'
})
export class DynamicFormQuestionComponent {
  ControlType = ControlType;
  InputType = InputType;
  @Input() formName: string;
  @Input() question: QuestionBase<string>;
  @Input() form: FormGroup;
  //
  // get isValid() { return this.form.controls[this.question.key].valid; }
}