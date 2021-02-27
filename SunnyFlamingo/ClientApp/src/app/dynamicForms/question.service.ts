import { Injectable } from '@angular/core';
import { QuestionsBase } from '../models/questions-base';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  
  constructor() { }
  sortQuestionsArray(questions: QuestionsBase<string>[]) {
    questions.sort((a, b) => a.order - b.order);
    questions.forEach(el => el.questionBaseList.sort((a, b) => a.order - b.order));
    return questions;
  }
  sortQuestions(questions: QuestionsBase<string>) {
    questions.questionBaseList.sort((a, b) => a.order - b.order);
    return questions;
  }
}