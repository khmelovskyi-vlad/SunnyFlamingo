import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { GoodCellModel } from '../../models/goodCellModel';
import { GoodModel } from '../../models/goodModel';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good-list',
  templateUrl: './good-list.component.html',
  styleUrls: ['./good-list.component.css']
})
export class GoodListComponent implements OnInit {

  goods$: Observable<GoodCellModel[]>;

  constructor(private goodService: GoodService) { }

  ngOnInit(): void {
    this.goods$ = this.goodService.getGoods();
  }

}
