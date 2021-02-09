import { Component, OnInit } from '@angular/core';
import { ModalDismissReasons, NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { Guid } from 'guid-typescript';
import { from, of, zip } from 'rxjs';
import { groupBy, map, mergeMap, toArray } from 'rxjs/operators';
import { SelectedGoodsService } from '../../../global-services/selected-goods.service';
import { GoodInformation } from '../../../models/good-information';
import { ImgService } from '../../../services/img.service';

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.css']
})
export class BasketComponent implements OnInit {

  closeResult = '';
  goods: GoodInformation[];
  groupedGoods: GoodInformation[][] = [];

  constructor(
    private modalService: NgbModal, 
    private selectedGoodsService: SelectedGoodsService,
    private imgService: ImgService
    ) {}
  
  // removeMultiplyValues(id: Guid){
  //   let newArray: GoodInformation[] = [];
  //   for (let i = 0; i < this.goods.length; i++) {
  //     if (this.goods[i].id === id) {
  //       continue;
  //     }
  //     newArray.push(this.goods[i]);
  //   }
  //   this.selectedGoodsService.removeValue(newArray);
  // }

  // removeOneValue(id: Guid){
  //   let newArray: GoodInformation[] = [];
  //   let findItem = false;
  //   for (let i = 0; i < this.goods.length; i++) {
  //     if (!findItem) {
  //       if (this.goods[i].id === id) {
  //         findItem = true;
  //         continue;
  //       }
  //     }
  //     newArray.push(this.goods[i]);
  //   }
  //   this.selectedGoodsService.removeValue(newArray);
  // }

  // getPrice(goods: GoodInformation[]): number{
  //   return goods.map(good => good.price).reduce((a, b) => a + b, 0);
  // }

  groupGoods(goods: GoodInformation[]){
    const newGrouped: GoodInformation[][] = [];
    from(goods).pipe( 
      groupBy(good => good.name),
      mergeMap(group => group.pipe(toArray())),
    )
    .subscribe(res => 
      {
        newGrouped.push(res);
      });
    this.groupedGoods = newGrouped;
  }

  i = 0;
  getImgUrl(id: string): string{
    this.i = this.i+1;
    return this.imgService.getImgUrl(id);
  }

  ngOnInit(): void {
    this.selectedGoodsService.selectedGoods
    .subscribe(goods => {
      this.goods = goods;
      this.groupGoods(goods);
    });
  }

  open(content: any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }

  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }
}
