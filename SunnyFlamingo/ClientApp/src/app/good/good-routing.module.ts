import { NgModule } from '@angular/core';
import { Routes, RouterModule, UrlSegment } from '@angular/router';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodComponent } from './good/good.component';

const routes: Routes = [
  {
    path: 'good',
    component: GoodMainComponent,
    children: [
      {
        matcher: matcherFunction,
        component: GoodComponent
      }
    ]
  }
];
function matcherFunction(url: UrlSegment[]) {
  if (url.length === 1) {
      const path = url[0].path;
      
       if(path.startsWith('Good') 
         || path.startsWith('Headphones')){
        return {consumed: url};
      }
  }
  return null;
}

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GoodRoutingModule { }
