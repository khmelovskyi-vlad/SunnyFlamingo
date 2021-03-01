import { Injectable } from '@angular/core';
import { ImageType } from '../value-objects/image-type';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import { HandlerErrorsService } from './handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class ImgService {

  constructor(private http: HttpClient, private handlerErrorsService: HandlerErrorsService) { }

  
  getGoodImgUrl(imgId: any): string {
    return `/${mainApiPathes.Images.Path}/${mainApiPathes.Images.GetImage}?${mainApiPathes.Images.type}=${ImageType.GoodImg}&${mainApiPathes.Images.id}=${imgId}`;
  }
  saveImages(files: File[]): Observable<string[]>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.Image.Path}/${mainApiPathes.Image.SentImages}`;
    const formData = this.createFormData(files);
    return this.http.post<string[]>(url, formData)
    .pipe(
      catchError(this.handlerErrorsService.handleError<string[]>('saveImages'))
    );
  }
  private createFormData(files: File[]): FormData{
    const formData = new FormData();
    for (let i = 0; i < files.length; i++) {
      formData.append('files', files[i]);
    }
    return formData;
  }
}
