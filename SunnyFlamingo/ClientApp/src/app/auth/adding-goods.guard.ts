import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class AddingGoodsGuard implements CanActivate {

  constructor(private authService: AuthService, private router: Router) {}

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    return this.checkPermission();
  }
  
  checkPermission(): Observable<true|UrlTree> {
    return this.authService.checkPermission('AddGoods').pipe(
      map(res => {
        if (res) {
          return res;
        }
        else{
          return this.router.parseUrl('/permission-not-found');
        }
      })
    );
  }
}
