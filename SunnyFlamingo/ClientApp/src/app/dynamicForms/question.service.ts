import { Injectable } from '@angular/core';

import { DropdownQuestion } from '../models/questionDropdown';
import { QuestionBase } from '../models/questionBase';
import { TextboxQuestion } from '../models/questionTextbox';
import { of } from 'rxjs';
import { InputType } from '../valueObjects/inputType';
import { CheckboxQuestion } from '../models/questionCheckbox';
import { QuestionsBase } from '../models/questionsBase';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {

  getQuestions() {
    const questions: QuestionsBase<string>[] = [
      new QuestionsBase({
        key: 'firstForm',
        questionsBase: [
          new DropdownQuestion({
            key: 'brave',
            label: 'Bravery Rating',
            options: [
              { key: 'solid', value: 'Solid' },
              { key: 'great', value: 'Great' },
              { key: 'good', value: 'Good' },
              { key: 'unproven', value: 'Unproven' }
            ],
            order: 3
          }),

          new TextboxQuestion({
            key: 'firstName',
            label: 'First name',
            value: 'Bombasto',
            required: true,
            order: 1
          })
        ]
      })
      ,
      new QuestionsBase({
        key: 'secondForm',
        questionsBase:
          [
            new TextboxQuestion({
              key: 'emailAddress',
              label: 'Email',
              type: InputType.email,
              order: 2
            }),

            new CheckboxQuestion({
              key: 'checkbox',
              label: 'Checkbox',
              type: InputType.checkbox,
              order: 1,
              checked: true
            })
          ]
      })
    ];
    questions.forEach(el => el.questionsBase.sort((a, b) => a.order - b.order));
    return of(questions);
  }
}