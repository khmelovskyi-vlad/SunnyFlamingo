import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketComponent } from './basket/basket/basket.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { NavbarRoutingModule } from '../navbar/navbar-routing.module';
import { GoodsElementComponent } from './basket/goods-element/goods-element.component';



@NgModule({
  declarations: [BasketComponent, GoodsElementComponent],
  imports: [
    CommonModule,
    NgbModule,
    NavbarRoutingModule,
  ],
  exports: [
    BasketComponent
  ]
})
export class ModalModule { }
