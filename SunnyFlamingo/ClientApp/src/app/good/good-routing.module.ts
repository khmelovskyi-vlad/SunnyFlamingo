import { NgModule } from '@angular/core';
import { Routes, RouterModule, UrlSegment } from '@angular/router';
import { GoodMainComponent } from './good-main/good-main.component';
import { GoodComponent } from './good/good.component';

const routes: Routes = [
  {
    path: 'good',
    component: GoodMainComponent,
    children: returnChildren()
  }
];
function returnChildren(){
  const result: {path: string, component: any}[] = [];
  const types = ["Good", "ComputerTechnology", "Laptop", "Computer", "FlashDrive", "ComputerPart", "ComputerAccessory", "ComputerDrive", "Cooler", "CPU", "VideoCard", "Mause", "Keyboard", "Headphones"]
  types.forEach(type => {
    result.push({path: `${type}/:id`, component: GoodComponent})
  });
  return result;
}

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GoodRoutingModule { }
