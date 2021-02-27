import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodInformation } from '../models/good-information';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { HandlerErrorsService } from '../services/handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class GoodService {

  constructor(private http: HttpClient, private handlerErrorsService: HandlerErrorsService) { }

  getGoodInformation(url: string): Observable<GoodInformation> {
    return this.http.get<GoodInformation>(`${mainApiPathes.StartPath}${url}`)
    .pipe(
      catchError(this.handlerErrorsService.handleError<GoodInformation>('getGoodsInformation'))
    );
  }
}
