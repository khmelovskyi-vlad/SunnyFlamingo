import { Component, OnInit } from '@angular/core';
import { SelectedGoodsService } from 'src/app/global-services/selected-goods.service';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {


  constructor() { }

  ngOnInit(): void {
  }

}
