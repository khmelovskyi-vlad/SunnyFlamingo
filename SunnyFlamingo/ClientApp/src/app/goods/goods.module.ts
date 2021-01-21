import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GoodsRoutingModule } from './goods-routing.module';
import { GoodListComponent } from './good-list/good-list.component';

@NgModule({
  declarations: [GoodListComponent],
  imports: [
    CommonModule,
    GoodsRoutingModule
  ]
})
export class GoodsModule { }
