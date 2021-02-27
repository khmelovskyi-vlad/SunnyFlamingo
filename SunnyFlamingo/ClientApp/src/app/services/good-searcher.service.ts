import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodCellModel } from '../models/good-cell-model';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { HandlerErrorsService } from './handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class GoodSearcherService {

  constructor(private http: HttpClient, private handlerErrorsService: HandlerErrorsService) { }

  searchGoodByName(part: string): Observable<GoodCellModel[]>{
    const params = new HttpParams().set("part", part);
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.Goods.Path}/${mainApiPathes.Goods.SearchByName}`;
    return this.http.get<GoodCellModel[]>(url, {params: params})
    .pipe(
      catchError(this.handlerErrorsService.handleError<GoodCellModel[]>('getGoodsInformation'))
    );
  }
}
