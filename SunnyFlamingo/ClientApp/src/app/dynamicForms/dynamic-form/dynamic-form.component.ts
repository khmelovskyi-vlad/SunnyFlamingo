import { Component, EventEmitter, Input, OnChanges, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormGroupWithName } from '../../models/form-group-with-name';
import { QuestionsBase } from '../../models/questions-base';

import { QuestionControlService } from '../question-control.service';

@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  providers: [ QuestionControlService ]
})
export class DynamicFormComponent implements OnChanges {

  @Input() questions: QuestionsBase<string>[] = [];
  form: FormGroup;
  forms: FormGroupWithName[];

  constructor(private qcs: QuestionControlService) { }

  ngOnChanges() {
    this.form = this.qcs.toFormGroup(this.questions);
    this.forms = this.getForms();
  }
  
  getForms(): FormGroupWithName[] {
    const forms: FormGroupWithName[] = [];
    for (const field in this.form.controls) {
      forms.push({
        formGroup: this.form.get(field) as FormGroup,
        name: field
      });
    }
    return forms;
  }
  getQuestions(key: string): QuestionsBase<string> | undefined {
    return this.questions.find(qb => qb.key === key);
  }
}