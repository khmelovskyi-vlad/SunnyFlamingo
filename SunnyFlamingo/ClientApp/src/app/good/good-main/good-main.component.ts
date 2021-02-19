import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { GoodInformation } from '../../models/good-information';
import { GoodService } from '../good.service';

@Component({
  selector: 'app-good-main',
  templateUrl: './good-main.component.html',
  styleUrls: ['./good-main.component.css']
})
export class GoodMainComponent implements OnInit {


  constructor() { }


  ngOnInit(): void {
  }

}
