import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { InputType } from '../../valueObjects/inputType';

import { QuestionBase } from '../../models/questionBase';
import { ControlType } from '../../valueObjects/controlType';
import { QuestionService } from '../question.service';

@Component({
  selector: 'app-question',
  templateUrl: './dynamic-form-question.component.html'
})
export class DynamicFormQuestionComponent {
  ControlType = ControlType;
  InputType = InputType;
  
  @Input() questionsKey: string;
  @Input() formName: string;
  @Input() question: QuestionBase<string>;
  @Input() form: FormGroup;
  
  constructor(private service: QuestionService) {}

  searchGoods(value: any) {
    this.service.searchGoods(this.questionsKey, value);
  }
  
}