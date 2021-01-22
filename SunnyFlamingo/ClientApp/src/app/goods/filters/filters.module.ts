import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilterListComponent } from './filter-list/filter-list.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [FilterListComponent],
  exports: [
    FilterListComponent
  ]
})
export class FiltersModule { }
