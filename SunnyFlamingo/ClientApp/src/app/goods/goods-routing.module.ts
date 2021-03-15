import { NgModule } from '@angular/core';
import { Routes, RouterModule, UrlSegment } from '@angular/router';
import { GoodsMainComponent } from './goods-main/goods-main.component';
import { GoodListComponent } from './good-list/good-list.component';

const goodsRoutes: Routes = [
  {
    path: 'goods',
    component: GoodsMainComponent,
    children:[
      {
        path: '',
        component: GoodListComponent
      },
      {
        matcher: matcherFunction,
        component: GoodListComponent
      }
    ]
  }
];
function matcherFunction(url: UrlSegment[]) {
  if (url.length === 1) {
      const path = url[0].path;
       if(path.startsWith('computerTechnologies')
         || path.startsWith('laptops')
         || path.startsWith('flashDrives')
         || path.startsWith('computerParts')
         || path.startsWith('computers')
         || path.startsWith('computerAccessories')
         || path.startsWith('videoCards')
         || path.startsWith('CPUs')
         || path.startsWith('coolers')
         || path.startsWith('computerDrives')
         || path.startsWith('mice')
         || path.startsWith('keyboards')
         || path.startsWith('headphones')
         || path.startsWith('goodsName')){
        return {consumed: url};
      }
  }
  return null;
}
@NgModule({
  imports: [RouterModule.forChild(goodsRoutes)],
  exports: [RouterModule]
})
export class GoodsRoutingModule { }
