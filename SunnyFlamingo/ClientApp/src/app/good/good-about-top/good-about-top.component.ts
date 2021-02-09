import { Component, Input, OnInit } from '@angular/core';
import { GoodInformation } from '../../models/good-information';

@Component({
  selector: 'app-good-about-top',
  templateUrl: './good-about-top.component.html',
  styleUrls: ['./good-about-top.component.css']
})
export class GoodAboutTopComponent implements OnInit {

  @Input() goodInformation: GoodInformation;

  constructor() { }

  ngOnInit(): void {
  }

}
