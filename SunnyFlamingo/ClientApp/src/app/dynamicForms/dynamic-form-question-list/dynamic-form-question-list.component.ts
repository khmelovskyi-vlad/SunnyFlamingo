import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ControlType } from '../../value-objects/control-type';
import { QuestionsBase } from '../../models/questions-base';
import { QuestionBase } from '../../models/question-base';

@Component({
  selector: 'app-question-list',
  templateUrl: './dynamic-form-question-list.component.html',
  styleUrls: ['./dynamic-form-question-list.component.css']
})
export class DynamicFormQuestionListComponent implements OnInit {
  ControlType = ControlType;
  showHidden = false;
  @Input() questions: QuestionsBase<string>;
  @Input() form: FormGroup;
  @Input() formName: string;
  
  ngOnInit() {
  }
  
  sortByName (a: QuestionBase<string>, b: QuestionBase<string>) {
    if (a.label > b.label) {
      return 1;
    }
    if (a.label < b.label) {
      return -1;
    }
    return 0;
  }
}
