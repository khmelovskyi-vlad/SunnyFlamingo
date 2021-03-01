import { Injectable } from '@angular/core';
import { Guid } from 'guid-typescript';
import { BehaviorSubject } from 'rxjs';
import { BasketGoodModel } from '../models/basket-good-model';

@Injectable({
  providedIn: 'root'
})
export class SelectedGoodsService {
  selectedBasketGoods = new BehaviorSubject(this.basketGoods);
  
  set basketGoods(value: BasketGoodModel[]) {
    let basketGoods: BasketGoodModel[] = [];
    const goodsString = localStorage.getItem('basketGoods');
    if (goodsString != undefined) {
      basketGoods = JSON.parse(goodsString) as BasketGoodModel[];
      for (let i = 0; i < value.length; i++) {
        const basketGood = basketGoods.find(el => el.goodInformation.id === value[i].goodInformation.id);
        if (basketGood != undefined) {
          basketGoods = basketGoods.map(el => {
            if (el.goodInformation.id === value[i].goodInformation.id) {
              const basketGood: BasketGoodModel={
                  count: el.count + value[i].count, 
                  addDate: el.addDate,
                  goodInformation: el.goodInformation,
                }
              return basketGood;
            }
            return el;
          });
        }
        else{
          basketGoods.push(value[i]);
        }
      }
    }
    else{
      basketGoods = value;
    }
    this.selectedBasketGoods.next(basketGoods);
    localStorage.setItem('basketGoods', JSON.stringify(basketGoods));
  }
 
  get basketGoods(): BasketGoodModel[] {
    const goods = localStorage.getItem('basketGoods');
    if (goods != undefined) {
      return JSON.parse(goods) as BasketGoodModel[];
    }
    else{
      return [];
    }
  }

  changeValue(value: BasketGoodModel[]){
    this.selectedBasketGoods.next(value);
    localStorage.setItem('basketGoods', JSON.stringify(value));
  }

  removeMultiplyValues(id: Guid){
    let newArray: BasketGoodModel[] = [];
    for (let i = 0; i < this.basketGoods.length; i++) {
      if (this.basketGoods[i].goodInformation.id === id) {
        continue;
      }
      newArray.push(this.basketGoods[i]);
    }
    this.changeValue(newArray);
  }
  removeOneValue(id: Guid){
    let newArray: BasketGoodModel[] = [];
    for (let i = 0; i < this.basketGoods.length; i++) {
      if (this.basketGoods[i].goodInformation.id === id) {
        if (this.basketGoods[i].count > 1) {
          const basketGood = this.basketGoods[i];
          basketGood.count = this.basketGoods[i].count - 1;
          newArray.push(basketGood);
          continue;
        }
        else{
          continue;
        }
      }
      newArray.push(this.basketGoods[i]);
    }
    this.changeValue(newArray);
  }

  removeAllValues(){
    this.selectedBasketGoods.next([]);
    localStorage.removeItem('basketGoods');
  }

  addOneElement(value: BasketGoodModel){
    value.count = 1;
    this.basketGoods = [value];
  }

  changeValueByCount(value: BasketGoodModel, count: number){
    const newGoods = this.basketGoods.filter(good => good.goodInformation.id !== value.goodInformation.id);
    value.count = count;
    newGoods.push(value);
    this.changeValue(newGoods)
  }

  getCount(): number{
    return this.basketGoods.map(basketGood => basketGood.count).reduce((a,b) => a + b, 0);
  }
  
  getPrice(): number{
    let price = 0;
    for (let i = 0; i < this.basketGoods.length; i++) {
      price += this.basketGoods[i].count * this.basketGoods[i].goodInformation.price;
    }
    return price;
  }
}
