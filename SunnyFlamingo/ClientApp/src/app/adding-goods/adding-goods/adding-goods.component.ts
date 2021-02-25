import { Component, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { ControlType } from '../../value-objects/control-type';
import { InputType } from '../../value-objects/input-type';
import { QuestionControlService } from '../../dynamicForms/question-control.service';
import { QuestionsBase } from '../../models/questions-base';
import { AddingGoodsService } from '../adding-goods.service';

@Component({
  selector: 'app-adding-goods',
  templateUrl: './adding-goods.component.html',
  styleUrls: ['./adding-goods.component.css']
})
export class AddingGoodsComponent implements OnInit {

  questions: QuestionsBase<string>;
  formGroup: FormGroup;
  imageFiles: File[] = [];
  ControlType = ControlType;
  InputType = InputType;
  goodType: string;

  constructor(
    private service: AddingGoodsService, 
    private questionControlService: QuestionControlService
    ) {}

  addImages(files: File[]){
    this.imageFiles = files;
  }
  onSubmit(){
    this.service.addGood(this.questions.key, 
      this.imageFiles, 
      this.formGroup.value,
      this.goodType
      );
  }
  onSelectType(obj: any){
    this.goodType = obj['type'];
    this.questions = obj['questions'];
    this.formGroup = this.questionControlService.questionsToFormGroup(this.questions);
  }

  ngOnInit(): void {
  }

}