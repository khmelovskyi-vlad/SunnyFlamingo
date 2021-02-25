import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AddingGoodsRoutingModule } from './adding-goods-routing.module';
import { AddingGoodsComponent } from './adding-goods/adding-goods.component';
import { ReactiveFormsModule } from '@angular/forms';
import { SwitcherComponent } from './switcher/switcher.component';
import { SearcherComponent } from './searcher/searcher.component';
import { SearcherArrayComponent } from './searcher-array/searcher-array.component';
import { ImageMasterComponent } from './image-master/image-master.component';
import { TextboxComponent } from './textbox/textbox.component';
import { CheckboxComponent } from './checkbox/checkbox.component';
import { DropdownComponent } from './dropdown/dropdown.component';
import { GoodTypeComponent } from './good-type/good-type.component';


@NgModule({
  declarations: [AddingGoodsComponent, SwitcherComponent, SearcherComponent, SearcherArrayComponent, ImageMasterComponent, TextboxComponent, CheckboxComponent, DropdownComponent, GoodTypeComponent],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    AddingGoodsRoutingModule
  ]
})
export class AddingGoodsModule { }
