import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { DynamicFormComponent } from './dynamic-form/dynamic-form.component';
import { DynamicFormQuestionComponent } from './dynamic-form-question/dynamic-form-question.component';
import { ReactiveFormsModule } from '@angular/forms';
import { DynamicFormQuestionListComponent } from './dynamic-form-question-list/dynamic-form-question-list.component';


@NgModule({
  declarations: [
    DynamicFormComponent,
    DynamicFormQuestionComponent,
    DynamicFormQuestionListComponent
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule
  ],
  exports: [
    DynamicFormComponent
  ]
})
export class DynamicFormModule { }
