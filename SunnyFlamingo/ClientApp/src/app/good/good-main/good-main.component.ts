import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GoodInformation } from '../../models/goodInformation';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good-main',
  templateUrl: './good-main.component.html',
  styleUrls: ['./good-main.component.css']
})
export class GoodMainComponent implements OnInit {

  showLoader = true;
  goodInformation: GoodInformation;

  constructor(private goodService: GoodService, private router: Router) { }


  ngOnInit(): void {
    this.goodService.getGoodInformation(this.router.url)
      .subscribe(goodsInformation => {
        this.goodInformation = goodsInformation;
        this.showLoader = false;
      });
  }

}
