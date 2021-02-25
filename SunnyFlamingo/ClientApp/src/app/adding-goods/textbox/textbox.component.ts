import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { QuestionBase } from 'src/app/models/question-base';
import { InputType } from 'src/app/value-objects/input-type';

@Component({
  selector: 'app-textbox',
  templateUrl: './textbox.component.html',
  styleUrls: ['./textbox.component.css']
})
export class TextboxComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  InputType = InputType;
  constructor() { }
  
  ngOnInit(): void {}
}
