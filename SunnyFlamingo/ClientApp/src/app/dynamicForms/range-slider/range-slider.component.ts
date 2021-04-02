import { Options } from '@angular-slider/ngx-slider';
import { Component, Input, OnInit } from '@angular/core';
import { UrlParameterService } from '../../services/url-parameter.service';
import { QuestionBase } from '../../models/question-base';

@Component({
  selector: 'app-range-slider',
  templateUrl: './range-slider.component.html',
  styleUrls: ['./range-slider.component.css']
})
export class RangeSliderComponent implements OnInit {
  @Input() questionsKey: string;
  @Input() question: QuestionBase<string>;
  options: Options;
  value: number = 0;
  highValue: number = 0;
  constructor(private service: UrlParameterService) { }
  
  ngOnInit(): void {
    this.value = this.question.selectedFrom || 0;
    this.value = this.question.selectedTo || 0;
    this.options = {
      floor: this.question.from,
      ceil: this.question.to
    };
  }

  searchGoods(): void {
    this.service.searchGoods(
      `${this.questionsKey}From`,
      this.question.selectedFrom,
      `${this.questionsKey}To`,
      this.question.selectedTo);
  }

  removeParams(): void{
    this.service.searchGoods(
      `${this.questionsKey}From`,
      this.question.selectedFrom,
      `${this.questionsKey}To`,
      this.question.selectedTo,
      undefined,
      true);
  }

  haveParams(): boolean{
    return this.service.checkHavingParam(`${this.questionsKey}From`) 
    && this.service.checkHavingParam(`${this.questionsKey}To`);
  }

  isToFromEqual(): boolean{
    return this.question.selectedFrom == this.question.selectedTo;
  }
}
