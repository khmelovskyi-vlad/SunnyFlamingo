import { Options } from '@angular-slider/ngx-slider';
import { Component, Input, OnInit } from '@angular/core';
import { QuestionBase } from '../../models/question-base';
import { QuestionService } from '../question.service';

@Component({
  selector: 'app-range-slider',
  templateUrl: './range-slider.component.html',
  styleUrls: ['./range-slider.component.css']
})
export class RangeSliderComponent implements OnInit {
  @Input() questionsKey: string;
  @Input() question: QuestionBase<string>;
  options: Options;
  constructor(private service: QuestionService) { }

  searchGoods() {
    this.service.searchGoods(
      `${this.questionsKey}From`,
      this.question.selectedFrom,
      `${this.questionsKey}To`,
      this.question.selectedTo);
  }

  ngOnInit(): void {
    this.options = {
      floor: this.question.from,
      ceil: this.question.to
    };
  }
}
