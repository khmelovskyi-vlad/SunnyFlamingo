import { Component, Input, OnInit } from '@angular/core';
import { Guid } from 'guid-typescript';
import { GalleryItem, ImageItem } from 'ng-gallery';
import { ImgService } from '../../services/img.service';

@Component({
  selector: 'app-good-imgs',
  templateUrl: './good-imgs.component.html',
  styleUrls: ['./good-imgs.component.css']
})
export class GoodImgsComponent implements OnInit {


  images: GalleryItem[];
  someArray: number[] = [1,2,3,4,5,6,7,8];
  @Input() imgIds: Guid[];

  
  constructor(private imgService: ImgService) { }

  ngOnInit(): void {
    // TODO
    // if (this.imgIds.length === 0) {
    //   this.images = [new ImageItem({ src: 'assets/img/defaultGoodImg.jpg', thumb: 'assets/img/defaultGoodImg.jpg' })];
    // }
    // else{
    //   this.images = this.imgIds.map(imgId => new ImageItem({ src: this.getImgUrl(imgId), thumb: this.getImgUrl(imgId) }));
    // }
    this.images = this.someArray.map(imgId => new ImageItem(
      { 
        src: this.imgService.getImgUrl(imgId), 
        thumb: this.imgService.getImgUrl(imgId) 
      }));
  }

}
