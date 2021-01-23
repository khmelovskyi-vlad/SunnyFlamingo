import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FilterListComponent } from './filter-list/filter-list.component';
import { DynamicFormModule } from '../../dynamicForms/dynamic-form.module';

@NgModule({
  imports: [
    CommonModule,
    DynamicFormModule
  ],
  declarations: [FilterListComponent],
  exports: [
    FilterListComponent
  ]
})
export class FiltersModule { }
