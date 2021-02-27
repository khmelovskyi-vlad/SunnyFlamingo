import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodsInformation as GoodsInformation } from '../models/goods-information';
import { UrlParameterService } from '../services/url-parameter.service';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { HandlerErrorsService } from '../services/handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class GoodsService {

  constructor(private urlParameterService: UrlParameterService, 
    private http: HttpClient,
    private handlerErrorsService: HandlerErrorsService) { }

  getGoodsInformation(currentUrl: string): Observable<GoodsInformation<string>>{
    let urlPart = `${mainApiPathes.StartPath}${currentUrl.split('?')[0]}`;
    const selector = this.urlParameterService.getSelector();
    return this.http.post<GoodsInformation<string>>(urlPart, selector)
    .pipe(
      catchError(this.handlerErrorsService.handleError<GoodsInformation<string>>('getGoodsInformation'))
    );
  }
}
