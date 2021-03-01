import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { QuestionBase } from '../../models/question-base';
import { InputType } from '../../value-objects/input-type';

@Component({
  selector: 'app-textbox',
  templateUrl: './textbox.component.html',
  styleUrls: ['./textbox.component.css']
})
export class TextboxComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  @Input()showValidation: boolean;
  InputType = InputType;
  formControl: FormControl;
  constructor() { }
  
  ngOnInit(): void {
    this.formControl = this.formGroup.get(this.question.key) as FormControl;
  }
}
