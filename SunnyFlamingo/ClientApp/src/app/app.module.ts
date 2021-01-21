import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { GoodsModule } from './goods/goods.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    GoodsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
