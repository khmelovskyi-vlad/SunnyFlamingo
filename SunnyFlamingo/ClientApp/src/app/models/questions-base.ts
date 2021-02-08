import { QuestionBase } from "./question-base";

export class QuestionsBase<T> {
  value?: string;
  key: string;
  order: number;
  questionBaseList: QuestionBase<T>[];
  constructor(options: {
      value?: string;
      key?: string;
      order?: number;
      questionBaseList?: QuestionBase<T>[];
    } = {}){
    this.value = options.value;
    this.key = options.key || '';
    this.order = options.order === undefined ? 1 : options.order;
    this.questionBaseList = options.questionBaseList || [];
  }
}