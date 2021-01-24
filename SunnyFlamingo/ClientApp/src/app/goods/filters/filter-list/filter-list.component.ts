import { Component, Input, OnInit } from '@angular/core';
import { QuestionsBase } from '../../../models/questionsBase';

@Component({
  selector: 'app-filter-list',
  templateUrl: './filter-list.component.html',
  styleUrls: ['./filter-list.component.css']
})
export class FilterListComponent implements OnInit {

  @Input() questions: QuestionsBase<any>[];

  constructor() { 
  }


  ngOnInit(): void {
  }

}
