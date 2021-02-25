import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { QuestionBase } from '../../models/question-base';
import { InputType } from '../../value-objects/input-type';
import { AddingGoodsService } from '../adding-goods.service';

@Component({
  selector: 'app-searcher-array',
  templateUrl: './searcher-array.component.html',
  styleUrls: ['./searcher-array.component.css']
})
export class SearcherArrayComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  InputType = InputType;
  value: string = "";
  onChange(res: any){
    this.value = res.target.value;
    this.service.getOptions(this.value, this.question.methodName).subscribe(res => this.question.options = res);
  }
  onSubmit(){
    const previousValue = this.formGroup.get(this.question.key)?.value;
    if (previousValue) {
      this.formGroup.get(this.question.key)?.setValue(`${previousValue},${this.value}`);
    }
    else{
      this.formGroup.get(this.question.key)?.setValue(this.value);
    }
  }
  getValues(): any[]{
    const value = this.formGroup.get(this.question.key)?.value;
    if (value) {
      return (value as string).split(',');
    }
    else{
      return [];
    }
  }
  onDropdownClick(i: number){
    const previousValue = this.formGroup.get(this.question.key)?.value;
    if (previousValue) {
      this.formGroup.get(this.question.key)?.setValue(this.createVelue(previousValue, i));
    }
  }
  createVelue(previousValue: string, i: number): string{
    const arr = (previousValue as string).split(',')
    arr.splice(i, 1);
    let result = '';
    for (let i = 0; i < arr.length; i++) {
      if (i === 0) {
        result += arr[i];
      }
      else{
        result += `,${arr[i]}`;
      }
    }
    return result;
  }

  constructor(private service: AddingGoodsService) { }
  
  ngOnInit(): void {}
}
