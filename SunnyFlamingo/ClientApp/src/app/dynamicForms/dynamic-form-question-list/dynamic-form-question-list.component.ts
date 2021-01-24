import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ControlType } from 'src/app/valueObjects/controlType';
import { FormGroupWithName } from '../../models/formGroupWithName';
import { QuestionBase } from '../../models/questionBase';
import { QuestionsBase } from '../../models/questionsBase';

@Component({
  selector: 'app-question-list',
  templateUrl: './dynamic-form-question-list.component.html',
  styleUrls: ['./dynamic-form-question-list.component.css']
})
export class DynamicFormQuestionListComponent implements OnInit {
  ControlType = ControlType;
  forms: FormGroupWithName[];
  @Input() questions: QuestionsBase<string>[];
  @Input() form: FormGroup;
  ngOnInit() {
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

  getQuestionsValue(key: string): string | undefined {
    return this.questions.find(qb => qb.key === key)?.value;
  }

  getQuestions(key: string): QuestionBase<string>[] | undefined {
    return this.questions.find(qb => qb.key === key)?.questionBaseList;
  }

}
