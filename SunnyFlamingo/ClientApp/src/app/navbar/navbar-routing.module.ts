import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NavbarComponent } from './navbar/navbar.component';

const appRoutes: Routes = [];

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
export class NavbarRoutingModule { }
