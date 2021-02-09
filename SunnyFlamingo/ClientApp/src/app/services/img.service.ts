import { Injectable } from '@angular/core';
import { ImageType } from '../value-objects/image-type';

@Injectable({
  providedIn: 'root'
})
export class ImgService {

  constructor() { }

  
  getImgUrl(imgId: any): string {
    return `/Images/GetImage?type=${ImageType.GoodImg}&id=${imgId}`;
  }
}
