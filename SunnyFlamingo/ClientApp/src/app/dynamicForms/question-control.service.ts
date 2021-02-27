import { Injectable } from '@angular/core';
import { FormControl, FormGroup, ValidatorFn, Validators } from '@angular/forms';
import { QuestionBase } from '../models/question-base';
import { QuestionValidator } from '../models/question-validator';

import { QuestionsBase } from '../models/questions-base';
import { QuestionService } from './question.service';

@Injectable({
  providedIn: 'root'
})
export class QuestionControlService {
  constructor(private questionService: QuestionService) { }

  questionsArrayToFormGroup(questions: QuestionsBase<string>[] ) {
    const sordedQuestions = this.questionService.sortQuestionsArray(questions);
    const group: any = {};

    sordedQuestions.forEach(questions2 => {
      group[questions2.key] = new FormGroup({});
      questions2.questionBaseList.forEach(question => {
        group[questions2.key].addControl(question.key, this.getFormControl(question));
      })
    });
    
    return new FormGroup(group);
  }
  questionsToFormGroup(questions: QuestionsBase<string>): FormGroup {
    const sordedQuestions = this.questionService.sortQuestions(questions);
    const group = new FormGroup({});
    sordedQuestions.questionBaseList.forEach(question => {
      group.addControl(question.key, this.getFormControl(question));
    });
    
    return group;
  }

  getFormControl(question: QuestionBase<string>): FormControl{
    if (question.validator) {
      console.log(this.getValidators(question.validator));
      return new FormControl(question.value || '', this.getValidators(question.validator));
    }
    return new FormControl(question.value || '');
  }
  getValidators(validator?: QuestionValidator): ValidatorFn[]{
    const validators: ValidatorFn[] = [];
    if (validator?.max) {
      validators.push(Validators.max(validator?.max));
    }
    if (validator?.min) {
      validators.push(Validators.min(validator?.min));
    }
    if (validator?.maxLength) {
      validators.push(Validators.maxLength(validator?.maxLength));
    }
    if (validator?.minLength) {
      validators.push(Validators.minLength(validator?.minLength));
    }
    if (validator?.required) {
      validators.push(Validators.required);
    }
    return validators;
  }
}