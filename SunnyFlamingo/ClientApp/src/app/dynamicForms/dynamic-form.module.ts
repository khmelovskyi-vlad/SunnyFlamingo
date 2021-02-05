import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DynamicFormComponent } from './dynamic-form/dynamic-form.component';
import { DynamicFormQuestionComponent } from './dynamic-form-question/dynamic-form-question.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DynamicFormQuestionListComponent } from './dynamic-form-question-list/dynamic-form-question-list.component';
import { RouterModule } from '@angular/router';
import { RangeSliderComponent } from './range-slider/range-slider.component';
import { NgxSliderModule } from '@angular-slider/ngx-slider';


@NgModule({
  declarations: [
    DynamicFormComponent,
    DynamicFormQuestionComponent,
    DynamicFormQuestionListComponent,
    RangeSliderComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    FormsModule,
    NgxSliderModule,
    RouterModule
  ],
  exports: [
    DynamicFormComponent
  ]
})
export class DynamicFormModule { }