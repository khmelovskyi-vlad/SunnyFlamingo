import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError, filter, map } from 'rxjs/operators';
import { QuestionService } from '../dynamicForms/question.service';
import { GoodCellModel } from '../models/good-cell-model';
import { GoodsInformation as GoodsInformation } from '../models/goods-information';
import { SearchModel } from '../models/searchModel';
import { UrlParameterService } from '../services/url-parameter.service';
import { GOODS } from './mock-goods';

@Injectable({
  providedIn: 'root'
})
export class GoodsService {

  constructor(private urlParameterService: UrlParameterService, private http: HttpClient, private route: ActivatedRoute) { }

  getGoodsInformation(currentUrl: string): Observable<GoodsInformation<string>>{
    let urlPart = `api${currentUrl.split('?')[0]}`;
    const selector = this.urlParameterService.getSelector();
    return this.http.post<GoodsInformation<string>>(urlPart, selector)
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
