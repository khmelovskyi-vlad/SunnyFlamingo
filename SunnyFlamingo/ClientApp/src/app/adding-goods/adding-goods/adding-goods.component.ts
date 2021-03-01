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
  showValidation: boolean = false;
  canAddExcelGoods: boolean = false;
  showSuccessAdding: boolean = false;

  constructor(
    private service: AddingGoodsService, 
    private questionControlService: QuestionControlService
    ) {}


  addImages(files: File[]){
    this.imageFiles = files;
  }
  onSubmit(){
    if (this.formGroup.invalid) {
      this.showValidation = true;
    }
    else{
      this.service.addGood(this.questions.key, 
        this.imageFiles, 
        this.formGroup.value,
        this.goodType
        );
    }
  }
  onSelectType(obj: any){
    this.showValidation = false;
    this.goodType = obj['type'];
    this.questions = obj['questions'];
    this.formGroup = this.questionControlService.questionsToFormGroup(this.questions);
  }
  addExcelGoods(): void{
    if (this.canAddExcelGoods) {
      this.service.addExcelGoods().subscribe(() => this.showSuccessAdding = true);
    }
  }

  ngOnInit(): void {
    this.service.checkAddExcelGoods().subscribe(canAddExcelGoods => this.canAddExcelGoods = canAddExcelGoods);
  }

}