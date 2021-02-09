import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { GoodInformation } from '../models/good-information';

@Injectable({
  providedIn: 'root'
})
export class SelectedGoodsService {

  selectedGoods = new BehaviorSubject(this.goods);

  set goods(value: GoodInformation[]) {
    const goodsString = localStorage.getItem('selectedGoods');
    if (goodsString != undefined) {
      const goods = JSON.parse(goodsString);
      value.push.apply(value, goods);
    }
    this.selectedGoods.next(value);
    localStorage.setItem('selectedGoods', JSON.stringify(value));
  }
 
  get goods(): GoodInformation[] {
    const goods = localStorage.getItem('selectedGoods');
    if (goods != undefined) {
      return JSON.parse(goods);
    }
    else{
      return [];
    }
  }

  removeValue(value: GoodInformation[]){
    this.selectedGoods.next(value);
    localStorage.setItem('selectedGoods', JSON.stringify(value));
  }
}
