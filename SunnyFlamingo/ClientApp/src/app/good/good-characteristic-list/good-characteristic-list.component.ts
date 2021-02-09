import { Component, Input, OnInit } from '@angular/core';
import { PropertyModel } from 'src/app/models/property-model';

@Component({
  selector: 'app-good-characteristic-list',
  templateUrl: './good-characteristic-list.component.html',
  styleUrls: ['./good-characteristic-list.component.css']
})
export class GoodCharacteristicListComponent implements OnInit {

  @Input() characteristicList: PropertyModel[];

  constructor() { }

  ngOnInit(): void {
  }

}
