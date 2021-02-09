import { Component, Input, OnInit } from '@angular/core';
import { PropertyModel } from '../../models/property-model';

@Component({
  selector: 'app-good-characteristic',
  templateUrl: './good-characteristic.component.html',
  styleUrls: ['./good-characteristic.component.css']
})
export class GoodCharacteristicComponent implements OnInit {

  @Input() characteristic: PropertyModel;

  constructor() { }

  ngOnInit(): void {
  }

}
