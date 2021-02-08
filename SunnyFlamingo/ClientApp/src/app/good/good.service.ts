import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GoodInformation } from '../models/good-information';
import { GOOD } from './mock-good';

@Injectable({
  providedIn: 'root'
})
export class GoodService {

  constructor() { }

  getGoodInformation(url: string): Observable<GoodInformation> {
    return of(GOOD);
  }
}
