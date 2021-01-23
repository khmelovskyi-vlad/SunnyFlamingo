import { QuestionBase } from "./questionBase";

export class QuestionsBase<T> {
  key: string;
  questionsBase: QuestionBase<T>[];
  constructor(options: {
      questionsBase?: QuestionBase<T>[];
      key?: string;
    } = {}){
    this.questionsBase = options.questionsBase || [];
    this.key = options.key || '';
  }
}