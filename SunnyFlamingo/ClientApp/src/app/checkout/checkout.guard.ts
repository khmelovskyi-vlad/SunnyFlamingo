import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { SelectedGoodsService } from '../services/selected-goods.service';

@Injectable({
  providedIn: 'root'
})
export class CheckoutGuard implements CanActivate {
  constructor(private selectedGoodsService: SelectedGoodsService, private router: Router) {}
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    return this.checkGoodsCount();
  }
  
  checkGoodsCount(): Observable<true|UrlTree> {
    return this.selectedGoodsService.selectedBasketGoods
    .pipe(
      map(basketGoods => {
        if(basketGoods.length > 0){
          return true;
        }
        else{
          return this.router.parseUrl('/goods');
        }
      })
    );
  }
}
