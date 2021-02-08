import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

import { QuestionsBase } from '../models/questions-base';

@Injectable()
export class QuestionControlService {
  constructor() { }

  toFormGroup(questions: QuestionsBase<string>[] ) {
    const group: any = {};

    questions.forEach(questions2 => {
      group[questions2.key] = new FormGroup({});
      questions2.questionBaseList.forEach(question => {
        group[questions2.key].addControl(question.key, question.required ? new FormControl(question.value || '', Validators.required)
                                                : new FormControl(question.value || ''));
      })
    });
    
    return new FormGroup(group);
  }
}