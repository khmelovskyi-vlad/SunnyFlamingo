import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodCellModel } from '../models/good-cell-model';

@Injectable({
  providedIn: 'root'
})
export class GoodSearcherService {

  constructor(private http: HttpClient) { }

  searchGoodByName(part: string): Observable<GoodCellModel[]>{
    const params = new HttpParams().set("part", part);
    return this.http.get<GoodCellModel[]>(`api/goods/GoodName`, {params: params})
    .pipe(
      catchError(this.handleError<GoodCellModel[]>('getGoodsInformation'))
    );
  }
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    }
  }
}
