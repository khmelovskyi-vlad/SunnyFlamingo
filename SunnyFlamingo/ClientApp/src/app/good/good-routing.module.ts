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
         || path.startsWith('ComputerTechnology')
         || path.startsWith('Laptop')
         || path.startsWith('Computer')
         || path.startsWith('FlashDrive')
         || path.startsWith('ComputerPart')
         || path.startsWith('ComputerAccessory')
         || path.startsWith('ComputerDrive')
         || path.startsWith('Cooler')
         || path.startsWith('CPU')
         || path.startsWith('VideoCard')
         || path.startsWith('Mause')
         || path.startsWith('Keyboard')
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
