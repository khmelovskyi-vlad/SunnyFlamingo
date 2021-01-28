import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GoodsMainComponent } from './goods-main/goods-main.component';
import { GoodListComponent } from './good-list/good-list.component';
import { ComputerTechnologyListComponent } from './goods/computer-technology-list/computer-technology-list.component';
import { LaptopListComponent } from './goods/computerTechnologies/laptop-list/laptop-list.component';
import { FlashDriveListComponent } from './goods/computerTechnologies/flash-drive-list/flash-drive-list.component';
import { ComputerPartListComponent } from './goods/computerTechnologies/computer-part-list/computer-part-list.component';
import { ComputerListComponent } from './goods/computerTechnologies/computer-list/computer-list.component';
import { ComputerAccessoryListComponent } from './goods/computerTechnologies/computer-accessory-list/computer-accessory-list.component';
import { VideoCardListComponent } from './goods/computerTechnologies/computerParts/video-card-list/video-card-list.component';
import { CPUListComponent } from './goods/computerTechnologies/computerParts/cpu-list/cpu-list.component';
import { CoolerListComponent } from './goods/computerTechnologies/computerParts/cooler-list/cooler-list.component';
import { ComputerDriveListComponent } from './goods/computerTechnologies/computerParts/computer-drive-list/computer-drive-list.component';
import { MauseListComponent } from './goods/computerTechnologies/computerAccessories/mause-list/mause-list.component';
import { KeyboardListComponent } from './goods/computerTechnologies/computerAccessories/keyboard-list/keyboard-list.component';
import { HeadphonesListComponent } from './goods/computerTechnologies/computerAccessories/headphones-list/headphones-list.component';

const goodsRoutes: Routes = [
  {
    path: 'goods',
    component: GoodsMainComponent,
    children: [
      {
        path: '',
        component: GoodListComponent,
        children: [
          {
            path: 'computerTechnologies',
            component: ComputerTechnologyListComponent,
          },
          {
            path: 'laptops',
            component: LaptopListComponent
          },
          {
            path: 'flashDrives',
            component: FlashDriveListComponent
          },
          {
            path: 'computerParts',
            component: ComputerPartListComponent
          },
          {
            path: 'computers',
            component: ComputerListComponent
          },
          {
            path: 'computerAccessories',
            component: ComputerAccessoryListComponent
          },
          {
            path: 'videoCards',
            component: VideoCardListComponent
          },
          {
            path: 'CPUs',
            component: CPUListComponent
          },
          {
            path: 'coolers',
            component: CoolerListComponent
          },
          {
            path: 'computerDrives',
            component: ComputerDriveListComponent
          },
          {
            path: 'mice',
            component: MauseListComponent
          },
          {
            path: 'keyboards',
            component: KeyboardListComponent
          },
          {
            path: 'headphones',
            component: HeadphonesListComponent
          }
        ]
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(goodsRoutes)],
  exports: [RouterModule]
})
export class GoodsRoutingModule { }
