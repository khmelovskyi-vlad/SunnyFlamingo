import { Component, Input, OnInit } from '@angular/core';
import { PropertyListModel } from '../..//models/property-list-model';
import { PropertyModel } from '../../models/property-model';

@Component({
  selector: 'app-good-characteristic-list',
  templateUrl: './good-characteristic-list.component.html',
  styleUrls: ['./good-characteristic-list.component.css']
})
export class GoodCharacteristicListComponent implements OnInit {

  @Input() characteristicList: PropertyModel[];
  @Input() characteristicLists: PropertyListModel[];

  constructor() { }

  ngOnInit(): void {
  }

}
