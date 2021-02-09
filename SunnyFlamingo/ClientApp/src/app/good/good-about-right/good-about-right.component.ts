import { Component, Input, OnInit } from '@angular/core';
import { SelectedGoodsService } from 'src/app/global-services/selected-goods.service';
import { GoodInformation } from '../../models/good-information';

@Component({
  selector: 'app-good-about-right',
  templateUrl: './good-about-right.component.html',
  styleUrls: ['./good-about-right.component.css']
})
export class GoodAboutRightComponent implements OnInit {

  @Input() goodInformation: GoodInformation;


  addGood(){
    this.selectedGoodsService.goods = [this.goodInformation];
  }

  constructor(private selectedGoodsService: SelectedGoodsService,) { }

  ngOnInit(): void {
  }

}
