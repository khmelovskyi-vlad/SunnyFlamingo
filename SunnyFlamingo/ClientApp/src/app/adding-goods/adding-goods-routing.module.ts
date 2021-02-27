import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddingGoodsGuard } from '../auth/adding-goods.guard';
import { AddingGoodsComponent } from './adding-goods/adding-goods.component';

const appRoutes: Routes = [
  { path: 'adding-goods', component: AddingGoodsComponent, canActivate: [AddingGoodsGuard] },
]
@NgModule({
  imports: [RouterModule.forChild(appRoutes)],
  exports: [RouterModule]
})
export class AddingGoodsRoutingModule { }
