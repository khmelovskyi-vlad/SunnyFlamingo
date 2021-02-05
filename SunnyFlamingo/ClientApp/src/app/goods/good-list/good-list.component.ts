import { Location } from '@angular/common';
import { Component, OnChanges, OnInit } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { GoodsInformation } from '../../models/goodsInformation';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good-list',
  templateUrl: './good-list.component.html',
  styleUrls: ['./good-list.component.css']
})
export class GoodListComponent implements OnInit {

  goodsInformation: GoodsInformation<string>;


  showLoader: boolean = true;

  constructor(private goodService: GoodService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    
    this.router.events
      .subscribe((val) => {
        if (val instanceof NavigationEnd) {
          if (val.url.split('?')[0].startsWith('/goods')) {
            this.showLoader = true;
            this.goodService.getNewGoodsInformation(val.url)
              .subscribe(goodsInformation => {
                this.showLoader = false;
                this.goodsInformation = goodsInformation;
              });
          }
        }
    });
    this.goodService.getGoodsInformation(this.router.url)
      .subscribe(goodsInformation => {
        this.goodsInformation = goodsInformation;
        this.showLoader = false;
      });
  }

}
