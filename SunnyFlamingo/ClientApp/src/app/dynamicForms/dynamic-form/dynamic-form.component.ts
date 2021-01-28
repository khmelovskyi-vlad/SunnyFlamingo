import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { FormGroupWithName } from 'src/app/models/formGroupWithName';
import { SearchModel } from 'src/app/models/searchModel';
import { QuestionsBase } from '../../models/questionsBase';

import { QuestionControlService } from '../question-control.service';

@Component({
  selector: 'app-dynamic-form',
  templateUrl: './dynamic-form.component.html',
  providers: [ QuestionControlService ]
})
export class DynamicFormComponent implements OnInit {

  @Input() questions: QuestionsBase<string>[] = [];
  form: FormGroup;
  forms: FormGroupWithName[];

  constructor(private qcs: QuestionControlService) {  }

  ngOnInit() {
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