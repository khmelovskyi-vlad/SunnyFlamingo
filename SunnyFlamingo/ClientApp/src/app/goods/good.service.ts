import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { QuestionService } from '../dynamicForms/question.service';
import { GoodCellModel } from '../models/goodCellModel';
import { GoodsInformation as GoodsInformation } from '../models/goodsInformation';
import { GOODS } from './mock-goods';

@Injectable({
  providedIn: 'root'
})
export class GoodService {

  constructor(private questionservice: QuestionService) { }

  getGoodsInformation(): Observable<GoodsInformation<string>>{
    return of({goodCells: GOODS, questions: this.questionservice.getQuestions()}) ;
  }
}
