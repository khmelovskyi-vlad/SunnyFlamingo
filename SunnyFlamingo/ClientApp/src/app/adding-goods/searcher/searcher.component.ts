import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { QuestionBase } from '../../models/question-base';
import { InputType } from '../../value-objects/input-type';
import { AddingGoodsService } from '../adding-goods.service';

@Component({
  selector: 'app-searcher',
  templateUrl: './searcher.component.html',
  styleUrls: ['./searcher.component.css']
})
export class SearcherComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  @Input()showValidation: boolean;
  InputType = InputType;
  formControl: FormControl;
  constructor(private service: AddingGoodsService) { }
  
  ngOnInit(): void {
    this.formControl = this.formGroup.get(this.question.key) as FormControl;
    this.formGroup.get(this.question.key)?.valueChanges
    .subscribe(part => 
      this.service.getOptions(part, this.question.methodName).subscribe(res => this.question.options = res)
    );
  }

}
