import { Component, Input, OnInit } from '@angular/core';
import { InputType } from '../../value-objects/input-type';
import { QuestionBase } from '../../models/question-base';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-switcher',
  templateUrl: './switcher.component.html',
  styleUrls: ['./switcher.component.css']
})
export class SwitcherComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  InputType = InputType;
  constructor() { }

  onClick(){
    let value = this.formGroup.get(this.question.key)?.value;
    if (value === "true") {
      this.formGroup.get(this.question.key)?.setValue(false);
    }
    else{
      this.formGroup.get(this.question.key)?.setValue(true);
    }
  }

  ngOnInit(): void {
  }

}
