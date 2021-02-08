import { Component, Input, OnInit } from '@angular/core';
import { GoodCellModel } from '../../models/good-cell-model';
import { ImageType } from '../../value-objects/image-type';

@Component({
  selector: 'app-good-cell',
  templateUrl: './good-cell.component.html',
  styleUrls: ['./good-cell.component.css']
})
export class GoodCellComponent implements OnInit {

  @Input() goodCell: GoodCellModel;

  getImgUrl(): string {
    return `/Images/GetImage?type=${ImageType.GoodImg}&id=${this.goodCell.imgId}`;
  }

  constructor() { }

  ngOnInit(): void {
  }

}
