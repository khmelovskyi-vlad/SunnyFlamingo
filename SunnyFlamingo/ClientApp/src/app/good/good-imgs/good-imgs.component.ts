import { Component, Input, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { ImageType } from '../../value-objects/image-type';
import { GalleryItem, ImageItem } from 'ng-gallery';

@Component({
  selector: 'app-good-imgs',
  templateUrl: './good-imgs.component.html',
  styleUrls: ['./good-imgs.component.css']
})
export class GoodImgsComponent implements OnInit {


  images: GalleryItem[];
  someArray: number[] = [1,2,3,4,5,6,7,8];
  @Input() imgIds: Guid[];

  getImgUrl(imgId: string): string {
    return `/Images/GetImage?type=${ImageType.GoodImg}&id=${imgId}`;
  }
//
  constructor() { }

  ngOnInit(): void {
    this.images = [
      new ImageItem({ src: this.getImgUrl('1'), thumb: this.getImgUrl('1') }),
      new ImageItem({ src: this.getImgUrl('2'), thumb: this.getImgUrl('2') }),
      new ImageItem({ src: this.getImgUrl('3'), thumb: this.getImgUrl('3') }),
      new ImageItem({ src: this.getImgUrl('4'), thumb: this.getImgUrl('4') }),
      new ImageItem({ src: this.getImgUrl('5'), thumb: this.getImgUrl('5') }),
    ];
  }

}
