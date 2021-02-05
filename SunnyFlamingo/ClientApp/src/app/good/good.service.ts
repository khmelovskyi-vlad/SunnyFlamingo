import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GoodInformation } from '../models/goodInformation';
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
