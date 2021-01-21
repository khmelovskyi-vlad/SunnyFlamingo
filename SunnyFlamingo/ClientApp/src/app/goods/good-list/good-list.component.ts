import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GoodModel } from 'src/app/models/goodModel';

@Component({
  selector: 'app-good-list',
  templateUrl: './good-list.component.html',
  styleUrls: ['./good-list.component.css']
})
export class GoodListComponent implements OnInit {

  goods$: Observable<GoodModel[]>;

  constructor() { }

  ngOnInit(): void {
  }

}
