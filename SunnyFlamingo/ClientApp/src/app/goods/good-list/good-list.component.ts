import { Component, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { UrlParameterService } from '../../services/url-parameter.service';
import { GoodsInformation } from '../../models/goods-information';
import { GoodsService } from '../goods.service';

@Component({
  selector: 'app-good-list',
  templateUrl: './good-list.component.html',
  styleUrls: ['./good-list.component.css']
})
export class GoodListComponent implements OnInit, OnDestroy {

  goodsInformation: GoodsInformation<string>;

  subscribes: Subscription[] = [];
  
  showLoader: boolean = true;

  constructor(private goodService: GoodsService, private router: Router, public urlParameterService: UrlParameterService) { }
  
  ngOnInit(): void {
    
    this.subscribes.push(this.router.events
      .subscribe((val) => {
        if (val instanceof NavigationEnd) {
          if (val.url.split('?')[0].startsWith('/goods')) {
            this.showLoader = true;
            this.goodService.getGoodsInformation(val.url)
              .subscribe(goodsInformation => {
                this.showLoader = false;
                this.goodsInformation = goodsInformation;
              });
          }
        }
    }));
    this.subscribes.push(this.goodService.getGoodsInformation(this.router.url)
      .subscribe(goodsInformation => {
        this.goodsInformation = goodsInformation;
        this.showLoader = false;
      }));
  }
  ngOnDestroy(): void{
    this.subscribes.forEach(subscribe => subscribe.unsubscribe());
  }

}
