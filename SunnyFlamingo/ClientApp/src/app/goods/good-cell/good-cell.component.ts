import { Component, Input, OnInit } from '@angular/core';
import { GoodCellModel } from 'src/app/models/goodCellModel';
import { ImageType } from 'src/app/ValueObjects/ImageType';

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
