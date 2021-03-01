import { Component, OnInit } from '@angular/core';
import { OrderType } from '../../value-objects/order-type';
import { SortDir } from '../../value-objects/sort-dir';
import { UrlParameterService } from '../../services/url-parameter.service';

@Component({
  selector: 'app-catalog-settings',
  templateUrl: './catalog-settings.component.html',
  styleUrls: ['./catalog-settings.component.css']
})
export class CatalogSettingsComponent implements OnInit {

  count: number = 36;

  OrderType = OrderType;
  SortDir = SortDir;

  constructor(public service: UrlParameterService) { }


  searchGoods(key: string, value: string): void {
    this.service.searchGoods(key, value, undefined, undefined, true, undefined, false);
  }
  removeParGoods(key: string, value: string): void {
    this.service.searchGoods(key, value, undefined, undefined, undefined, true, false);
  }

  ngOnInit(): void {
  }

}
