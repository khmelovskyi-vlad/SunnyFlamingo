import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GalleryModule } from 'ng-gallery';

import { GoodRoutingModule } from './good-routing.module';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodHeadComponent } from './good-head/good-head.component';
import { GoodComponent } from './good/good.component';
import { LoaderModule } from '../loader/loader.module';
import { GoodImgsComponent } from './good-imgs/good-imgs.component';
import { GoodAboutRightComponent } from './good-about-right/good-about-right.component';
import { GoodAboutLeftComponent } from './good-about-left/good-about-left.component';
import { GoodAboutTopComponent } from './good-about-top/good-about-top.component';
import { GoodCharacteristicListComponent } from './good-characteristic-list/good-characteristic-list.component';
import { GoodCharacteristicComponent } from './good-characteristic/good-characteristic.component';


@NgModule({
  declarations: [GoodMainComponent, GoodHeadComponent, GoodComponent, GoodImgsComponent, GoodAboutRightComponent, GoodAboutLeftComponent, GoodAboutTopComponent, GoodCharacteristicListComponent, GoodCharacteristicComponent],
  imports: [
    GalleryModule,
    CommonModule,
    GoodRoutingModule,
    LoaderModule
  ]
})
export class GoodModule { }
