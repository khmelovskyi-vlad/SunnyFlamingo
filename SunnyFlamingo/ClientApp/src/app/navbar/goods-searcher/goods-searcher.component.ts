import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { GoodCellModel } from '../../models/good-cell-model';
import { GoodSearcherService } from '../../services/good-searcher.service';

@Component({
  selector: 'app-goods-searcher',
  templateUrl: './goods-searcher.component.html',
  styleUrls: ['./goods-searcher.component.css']
})
export class GoodsSearcherComponent implements OnInit {
// style="cursor: pointer;"
  
  goodForm = this.fb.group({
    namePart: []
  });

  goods: GoodCellModel[];

  onSubmit(){
    console.log(this.goodForm.get("namePart")?.value);
  }

  constructor(private service: GoodSearcherService, private fb: FormBuilder) { }

  ngOnInit(): void {
    this.goodForm.valueChanges
    .subscribe(() => this.service.searchGoodByName(this.goodForm.get("namePart")?.value)
    .subscribe(goods => this.goods = goods));
  }

}
