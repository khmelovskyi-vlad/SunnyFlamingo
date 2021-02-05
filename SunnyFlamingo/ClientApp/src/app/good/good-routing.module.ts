import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodComponent } from './good/good.component';

const routes: Routes = [
  {
    path: ':id',
    component: GoodMainComponent,
    children: [
      {
        path: '',
        component: GoodComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GoodRoutingModule { }
