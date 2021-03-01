import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ServerErrorRoutingModule } from './server-error-routing.module';
import { InternalServerErrorComponent } from './internal-server-error/internal-server-error.component';


@NgModule({
  declarations: [
    InternalServerErrorComponent
  ],
  imports: [
    CommonModule,
    ServerErrorRoutingModule
  ]
})
export class ServerErrorModule { }
