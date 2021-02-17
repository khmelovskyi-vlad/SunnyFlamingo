import { Component, OnInit } from '@angular/core';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Guid } from 'guid-typescript';
import { from, of, zip } from 'rxjs';
import { groupBy, map, mergeMap, toArray } from 'rxjs/operators';
import { BasketGoodModel } from '../../../models/basket-good-model';
import { SelectedGoodsService } from '../../../global-services/selected-goods.service';
import { GoodInformation } from '../../../models/good-information';
import { ImgService } from '../../../services/img.service';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.css']
})
export class BasketComponent implements OnInit {

  basketGoods: BasketGoodModel[] = [];
  
  constructor(
    private modalService: NgbModal, 
    private selectedGoodsService: SelectedGoodsService,
    private imgService: ImgService
    ) {}

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

  i = 0;
  getImgUrl(id: string): string{
    this.i = this.i+1;
    return this.imgService.getImgUrl(id);
  }

  ngOnInit(): void {
    this.selectedGoodsService.selectedBasketGoods
    .subscribe(basketGoods => {
      this.basketGoods = basketGoods.sort((a, b) => (a.addDate > b.addDate ? -1 : 1));
    });
  }

  open(content: any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result;
  }

}
