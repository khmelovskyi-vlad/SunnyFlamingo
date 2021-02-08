import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, filter, map } from 'rxjs/operators';
import { QuestionService } from '../dynamicForms/question.service';
import { GoodCellModel } from '../models/good-cell-model';
import { GoodsInformation as GoodsInformation } from '../models/goods-information';
import { SearchModel } from '../models/searchModel';
import { GOODS } from './mock-goods';

@Injectable({
  providedIn: 'root'
})
export class GoodsService {

  constructor(private questionservice: QuestionService, private http: HttpClient, private route: ActivatedRoute) { }
//
  getGoodsInformation(currentUrl: string): Observable<GoodsInformation<string>>{
    // currentUrl = currentUrl === "/" ? "/goods" : currentUrl;
    // const url = `api/Goods${currentUrl}${currentUrl.includes('?') ? '&' : '?'}getQuestions=false`
    console.log(currentUrl.split('?')[0]);
    const url = `api${currentUrl}`
    return this.http.get<GoodsInformation<string>>(url)
      .pipe(
        catchError(this.handleError<GoodsInformation<string>>('getGoodsInformation'))
      );
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    }
  }
}
