import { Component, Input, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { from } from 'rxjs';
import { groupBy, mergeMap, toArray } from 'rxjs/operators';
import { SelectedGoodsService } from '../../../services/selected-goods.service';
import { BasketGoodModel } from '../../../models/basket-good-model';
import { ImgService } from '../../../services/img.service';
import { GoodInformation } from '../../../models/good-information';

@Component({
  selector: 'app-goods-element',
  templateUrl: './goods-element.component.html',
  styleUrls: ['./goods-element.component.css']
})
export class GoodsElementComponent implements OnInit {

  @Input() basketGood: BasketGoodModel;
  
  constructor(public selectedGoodsService: SelectedGoodsService,
    private imgService: ImgService) { }


  changeGoods(count: string){
    const parsed = parseInt(count);
    if (parsed != undefined && !isNaN(parsed) && parsed > 0) {
      this.selectedGoodsService.changeValueByCount(this.basketGood, parsed);
    }
  }

  getImgUrl(id: string): string{
    return this.imgService.getGoodImgUrl(id);
  }

  getPrice(): number{
    return this.basketGood.count * this.basketGood.goodInformation.price;
  }

  ngOnInit(): void {
  }

}
