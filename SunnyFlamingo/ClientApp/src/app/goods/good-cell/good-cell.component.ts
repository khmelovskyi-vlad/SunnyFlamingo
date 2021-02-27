import { Component, Input, OnInit } from '@angular/core';
import { ImgService } from '../../services/img.service';
import { GoodCellModel } from '../../models/good-cell-model';

@Component({
  selector: 'app-good-cell',
  templateUrl: './good-cell.component.html',
  styleUrls: ['./good-cell.component.css']
})
export class GoodCellComponent implements OnInit {

  @Input() goodCell: GoodCellModel;

  getImgUrl(): string {
    return this.imgService.getGoodImgUrl(this.goodCell.imgId);
  }

  constructor(private imgService: ImgService) { }

  ngOnInit(): void {
  }

}
