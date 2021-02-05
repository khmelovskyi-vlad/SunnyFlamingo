import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GoodRoutingModule } from './good-routing.module';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodHeadComponent } from './good-head/good-head.component';
import { GoodComponent } from './good/good.component';


@NgModule({
  declarations: [GoodMainComponent, GoodHeadComponent, GoodComponent],
  imports: [
    CommonModule,
    GoodRoutingModule
  ]
})
export class GoodModule { }
