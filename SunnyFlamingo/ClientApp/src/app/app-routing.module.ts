import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PermissionNotFoundComponent } from './auth/permission-not-found/permission-not-found.component';
import { CheckoutGuard } from './checkout/checkout.guard';
import { CheckoutComponent } from './checkout/checkout/checkout.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const appRoutes: Routes = [
  { path: 'goods',
    loadChildren: () => import('./goods/goods.module').then(m => m.GoodsModule),
    data: { preload: true }},
  { path: 'checkout', component: CheckoutComponent, canActivate: [CheckoutGuard] },
  { path: 'permission-not-found', component: PermissionNotFoundComponent },
  { path: '', redirectTo: '/goods', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(
      appRoutes,
      {
        enableTracing: true
      }
    )
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
