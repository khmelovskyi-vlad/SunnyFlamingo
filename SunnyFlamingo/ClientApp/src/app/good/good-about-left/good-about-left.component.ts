import { Component, Input, OnInit } from '@angular/core';
import { GoodInformation } from '../../models/good-information';

@Component({
  selector: 'app-good-about-left',
  templateUrl: './good-about-left.component.html',
  styleUrls: ['./good-about-left.component.css']
})
export class GoodAboutLeftComponent implements OnInit {

  @Input() goodInformation: GoodInformation;

  constructor() { }

  ngOnInit(): void {
  }

}
