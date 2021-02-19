import { Component, Input, OnInit } from '@angular/core';
import { PropertyListModel } from '../../models/property-list-model';
import { PropertyModel } from '../../models/property-model';

@Component({
  selector: 'app-good-characteristic',
  templateUrl: './good-characteristic.component.html',
  styleUrls: ['./good-characteristic.component.css']
})
export class GoodCharacteristicComponent implements OnInit {

  @Input() characteristic: PropertyModel;
  @Input() characteristicList: PropertyListModel;

  constructor() { }

  ngOnInit(): void {
  }

}
