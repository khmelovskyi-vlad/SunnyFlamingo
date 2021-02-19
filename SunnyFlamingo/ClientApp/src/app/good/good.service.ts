import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodInformation } from '../models/good-information';
import { GOOD } from './mock-good';

@Injectable({
  providedIn: 'root'
})
export class GoodService {

  constructor(private http: HttpClient) { }

  getGoodInformation(url: string): Observable<GoodInformation> {
    return this.http.get<GoodInformation>(`api${url}`)
    .pipe(
      catchError(this.handleError<GoodInformation>('getGoodsInformation'))
    );
    // return of(GOOD);
  }
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      return of(result as T);
    }
  }
}
