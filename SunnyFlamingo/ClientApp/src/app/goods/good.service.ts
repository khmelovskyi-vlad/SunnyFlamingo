import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { GoodCellModel } from '../models/goodCellModel';
import { GOODS } from './mock-goods';

@Injectable({
  providedIn: 'root'
})
export class GoodService {

  constructor() { }

  getGoods(): Observable<GoodCellModel[]>{
    return of(GOODS);
  }
}
