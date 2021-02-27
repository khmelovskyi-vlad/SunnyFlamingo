import { Component, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { GoodInformation } from '../../models/good-information';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good',
  templateUrl: './good.component.html',
  styleUrls: ['./good.component.css']
})
export class GoodComponent implements OnInit, OnDestroy {

  subscribes: Subscription[] = [];
  goodInformation: GoodInformation;
  showLoader: boolean = true;

  constructor(
    private goodService: GoodService, 
    private router: Router
    ) { }

  ngOnInit(): void {
    this.subscribes.push(this.router.events
      .subscribe((val) => {
        if (val instanceof NavigationEnd) {
          if (val.url.split('?')[0].startsWith('/good')) {
            this.showLoader = true;
            this.goodService.getGoodInformation(this.router.url)
              .subscribe(goodInformation => {
                this.showLoader = false;
                this.goodInformation = goodInformation;
              });
          }
        }
    }));
    
    this.subscribes.push(this.goodService.getGoodInformation(this.router.url)
    .subscribe(goodInformation => {
      this.goodInformation = goodInformation;
      this.showLoader = false;
    }));
  }
  ngOnDestroy(): void{
    this.subscribes.forEach(subscribe => subscribe.unsubscribe());
  }

}
