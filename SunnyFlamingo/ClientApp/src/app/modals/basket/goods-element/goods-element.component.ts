import { Component, Input, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { from } from 'rxjs';
import { groupBy, mergeMap, toArray } from 'rxjs/operators';
import { SelectedGoodsService } from 'src/app/global-services/selected-goods.service';
import { ImgService } from 'src/app/services/img.service';
import { GoodInformation } from '../../../models/good-information';

@Component({
  selector: 'app-goods-element',
  templateUrl: './goods-element.component.html',
  styleUrls: ['./goods-element.component.css']
})
export class GoodsElementComponent implements OnInit {

  @Input() goods: GoodInformation[];
  
  constructor(private selectedGoodsService: SelectedGoodsService,
    private imgService: ImgService) { }

  getImgUrl(id: string): string{
    return this.imgService.getImgUrl(id);
  }
  removeMultiplyValues(id: Guid){
    let newArray: GoodInformation[] = [];
    for (let i = 0; i < this.goods.length; i++) {
      if (this.goods[i].id === id) {
        continue;
      }
      newArray.push(this.goods[i]);
    }
    this.selectedGoodsService.removeValue(newArray);
  }

  removeOneValue(id: Guid){
    let newArray: GoodInformation[] = [];
    let findItem = false;
    for (let i = 0; i < this.goods.length; i++) {
      if (!findItem) {
        if (this.goods[i].id === id) {
          findItem = true;
          continue;
        }
      }
      newArray.push(this.goods[i]);
    }
    this.selectedGoodsService.removeValue(newArray);
  }

  getPrice(goods: GoodInformation[]): number{
    return goods.map(good => good.price).reduce((a, b) => a + b, 0);
  }

  ngOnInit(): void {
  }

}
