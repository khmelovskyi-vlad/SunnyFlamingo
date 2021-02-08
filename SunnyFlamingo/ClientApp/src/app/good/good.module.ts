import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GalleryModule } from 'ng-gallery';

import { GoodRoutingModule } from './good-routing.module';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodHeadComponent } from './good-head/good-head.component';
import { GoodComponent } from './good/good.component';
import { LoaderModule } from '../loader/loader.module';
import { GoodImgsComponent } from './good-imgs/good-imgs.component';


@NgModule({
  declarations: [GoodMainComponent, GoodHeadComponent, GoodComponent, GoodImgsComponent],
  imports: [
    GalleryModule,
    CommonModule,
    GoodRoutingModule,
    LoaderModule
  ]
})
export class GoodModule { }
