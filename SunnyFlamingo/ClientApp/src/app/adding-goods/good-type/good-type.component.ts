import { EventEmitter, Output } from '@angular/core';
import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { QuestionsBase } from '../../models/questions-base';
import { AddingGoodsService } from '../adding-goods.service';

@Component({
  selector: 'app-good-type',
  templateUrl: './good-type.component.html',
  styleUrls: ['./good-type.component.css']
})
export class GoodTypeComponent implements OnInit {

  goodTypeForm = this.fb.group({
    goodType: []
  });
  foundGoodTypes: string[] = [];
  
  @Output() onSelectTypeEvent = new EventEmitter<{questions: QuestionsBase<string>, type: string}>();
  
  onSelectType(){
    this.service.getQuestions(this.goodTypeForm.get("goodType")?.value).subscribe(questions => {
      this.onSelectTypeEvent.emit({questions: questions, type: this.goodTypeForm.get("goodType")?.value});
    });
  }

  constructor(private service: AddingGoodsService, private fb: FormBuilder) { }
  
  ngOnInit(): void {
    this.goodTypeForm.valueChanges
    .subscribe(() => this.service.getGoodTypes(this.goodTypeForm.get("goodType")?.value)
      .subscribe(goodTypes => this.foundGoodTypes = goodTypes));
  }

}
