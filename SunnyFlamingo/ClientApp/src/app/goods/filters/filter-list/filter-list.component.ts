import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { QuestionsBase } from '../../../models/questionsBase';
import { QuestionService } from '../../../dynamicForms/question.service';

@Component({
  selector: 'app-filter-list',
  templateUrl: './filter-list.component.html',
  styleUrls: ['./filter-list.component.css']
})
export class FilterListComponent implements OnInit {

  questions$: Observable<QuestionsBase<any>[]>;

  constructor(service: QuestionService) { 
    this.questions$ = service.getQuestions();
  }


  ngOnInit(): void {
  }

}
