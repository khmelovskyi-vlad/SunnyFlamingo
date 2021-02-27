import { Component, OnInit } from '@angular/core';
import { OidcSecurityService } from 'angular-auth-oidc-client';
import { ManageRole } from '../../value-objects/manage-role';
import { AuthService } from '../../auth/auth.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  ManageRole = ManageRole;
  constructor(public oidcSecurityService: OidcSecurityService, private authService: AuthService) {
    this.authService.checkLogin().subscribe((isLogin) => this.isLogin = isLogin);
  }

  isLogin: boolean = false;
  showAddGoods: boolean = false;
  manageRole: ManageRole | undefined;

  ngOnInit(): void {
    this.authService.checkPermission('AddGoods').subscribe(res => this.showAddGoods = res);
    this.authService.checkManage().subscribe(manageRole => this.manageRole = manageRole);
  }

  login() {
    this.authService.login();
  }

  logout() {
    this.authService.logout();
  }
}
