import { Component, Input, OnInit } from '@angular/core';
import { PageModel } from '../../models/page-model';
import { UrlParameterService } from '../../services/url-parameter.service';

@Component({
  selector: 'app-pagination',
  templateUrl: './pagination.component.html',
  styleUrls: ['./pagination.component.css']
})
export class PaginationComponent implements OnInit {

  @Input() count: number;
  @Input() maxGoodsPerPage: number;
  @Input() currentPage: number;

  constructor(private service: UrlParameterService ) { }

  searchGoods(page: number): void {
    this.service.searchGoods('page', page, undefined, undefined, true)
  }

  getPageNumbers(): PageModel[]{
    const maxPages = this.getMaxPages();
    const minPages = this.getMinPages();
    if (maxPages < 10) {
      return Array(maxPages).fill(undefined).map((v,i)=> {
        return {value: (i + 1), name: (i + 1).toString()};
      });
    }
    else {
      const maxDisplayPage = this.getMaxDisplayPage();
      const halfDisplayPage = Math.ceil(maxDisplayPage/2);
      const halfHalfDisplayPage = Math.ceil(halfDisplayPage/2);
      const result: PageModel[] = [];
      result.push({value: minPages, name: minPages.toString()});
      if (this.currentPage >= minPages + halfDisplayPage && this.currentPage <= maxPages - halfDisplayPage) {
        const min = this.currentPage - halfHalfDisplayPage;
        const max = this.currentPage + halfHalfDisplayPage;
        result.push.apply(result, this.createMidPageModels(min, max, min, max));
      }
      else if (this.currentPage < minPages + halfDisplayPage) {
        const min = minPages + 1;
        const max = minPages + maxDisplayPage - 2;
        result.push.apply(result, this.createMidPageModels(min, max, max));
      }
      else if (this.currentPage > maxPages - halfDisplayPage) {
        const min = maxPages - maxDisplayPage + 2;
        const max = maxPages - 1;
        result.push.apply(result, this.createMidPageModels(min, max, min));
      }
      result.push({value: maxPages, name: maxPages.toString()});
      return result;
    }
  }
  createMidPageModels(min: number, max: number, firstCheck?: number, secondCheck?: number): PageModel[]{
    const arr: PageModel[] = [];
    for (let i = min; i <= max; i++) {
      if ((firstCheck && i === firstCheck) || (secondCheck && i === secondCheck)) {
        arr.push({value: i, name: '...'});
      }
      else {
        arr.push({value: i, name: i.toString()});
      }
    }
    return arr;
  }
  getMaxPages(): number{
    return Math.ceil(this.count/this.maxGoodsPerPage);
  }
  getMinPages(): number{
    return 1;
  }
  getMaxDisplayPage(): number{
    return 9;
  }

  ngOnInit(): void {
  }

}
