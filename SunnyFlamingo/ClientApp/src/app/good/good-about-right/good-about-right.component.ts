import { Component, Input, OnInit } from '@angular/core';
import { SelectedGoodsService } from '../../services/selected-goods.service';
import { BasketGoodModel } from '../../models/basket-good-model';
import { GoodInformation } from '../../models/good-information';

@Component({
  selector: 'app-good-about-right',
  templateUrl: './good-about-right.component.html',
  styleUrls: ['./good-about-right.component.css']
})
export class GoodAboutRightComponent implements OnInit {

  @Input() goodInformation: GoodInformation;


  addGood(){
    const basketGood: BasketGoodModel={
      count: 1,
      addDate: new Date(),
      goodInformation: this.goodInformation
    }
    this.selectedGoodsService.basketGoods = [basketGood];
  }

  constructor(private selectedGoodsService: SelectedGoodsService,) { }

  ngOnInit(): void {
  }

}
