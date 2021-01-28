import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { SearchModel } from 'src/app/models/searchModel';
import { ControlType } from 'src/app/valueObjects/controlType';
import { FormGroupWithName } from '../../models/formGroupWithName';
import { QuestionBase } from '../../models/questionBase';
import { QuestionsBase } from '../../models/questionsBase';

@Component({
  selector: 'app-question-list',
  templateUrl: './dynamic-form-question-list.component.html',
  styleUrls: ['./dynamic-form-question-list.component.css']
})
export class DynamicFormQuestionListComponent implements OnInit {
  ControlType = ControlType;
  
  @Input() questions: QuestionsBase<string>;
  @Input() form: FormGroup;
  @Input() formName: string;
  
  ngOnInit() {
  }

}
