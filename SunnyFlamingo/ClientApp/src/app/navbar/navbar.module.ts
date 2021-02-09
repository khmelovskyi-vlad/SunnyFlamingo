import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavbarComponent } from './navbar/navbar.component';
import { NavbarRoutingModule } from './navbar-routing.module';
import { ModalModule } from '../modals/modal.module';



@NgModule({
  declarations: [NavbarComponent],
  imports: [
    CommonModule,
    NavbarRoutingModule,
    ModalModule
  ],
  exports: [
    NavbarComponent
  ]
})
export class NavbarModule { }
