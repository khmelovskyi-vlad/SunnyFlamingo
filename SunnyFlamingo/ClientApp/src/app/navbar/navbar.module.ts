import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { NavbarRoutingModule } from './navbar-routing.module';
import { ModalModule } from '../modals/modal.module';
import { GoodsSearcherComponent } from './goods-searcher/goods-searcher.component';
import { ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [NavbarComponent, GoodsSearcherComponent],
  imports: [
    CommonModule,
    NavbarRoutingModule,
    ReactiveFormsModule,
    ModalModule
  ],
  exports: [
    NavbarComponent
  ]
})
export class NavbarModule { }
