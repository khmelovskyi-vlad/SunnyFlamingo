import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { GoodsInformation } from 'src/app/models/goodsInformation';
import { QuestionsBase } from 'src/app/models/questionsBase';
import { GoodCellModel } from '../../models/goodCellModel';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good-list',
  templateUrl: './good-list.component.html',
  styleUrls: ['./good-list.component.css']
})
export class GoodListComponent implements OnInit {

  goodsInformation$: Observable<GoodsInformation<string>>;

  rout: string;


  constructor(private goodService: GoodService, private router: Router) { }

  ngOnInit(): void {
    this.goodsInformation$ = this.goodService.getGoodsInformation();
    this.rout = this.router.url;
  }

}
