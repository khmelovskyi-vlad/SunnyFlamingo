import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Guid } from 'guid-typescript';
import { GoodInformation } from '../../models/good-information';
import { ImageType } from '../../value-objects/image-type';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good',
  templateUrl: './good.component.html',
  styleUrls: ['./good.component.css']
})
export class GoodComponent implements OnInit {


  goodInformation: GoodInformation;
  showLoader: boolean = true;

  constructor(private goodService: GoodService, private router: Router, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.goodService.getGoodInformation(this.router.url)
    .subscribe(goodInformation => {
      this.goodInformation = goodInformation;
      this.showLoader = false;
    });
  }

}
