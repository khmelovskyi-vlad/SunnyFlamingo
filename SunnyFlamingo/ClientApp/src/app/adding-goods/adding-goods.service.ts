import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { GoodModel } from '../models/good-model';
import { QuestionOption } from '../models/question-option';
import { QuestionsBase } from '../models/questions-base';
import { ImgService } from '../services/img.service';
import { LaptopModel } from '../models/goods/computerTechnologies/laptopModel';
import { ComputerTechnologyModel } from '../models/goods/computerTechnologyModel';
import { ComputerModel } from '../models/goods/computerTechnologies/computerModel';
import { ComputerPartModel } from '../models/goods/computerTechnologies/computerPartModel';
import { ComputerAccessoryModel } from '../models/goods/computerTechnologies/computerAccessoryModel';
import { FlashDriveModel } from '../models/goods/computerTechnologies/flashDriveModel';
import { VideoCardModel } from '../models/goods/computerTechnologies/computerParts/videoCardModel';
import { CPUModel } from '../models/goods/computerTechnologies/computerParts/CPUModel';
import { CoolerModel } from '../models/goods/computerTechnologies/computerParts/coolerModel';
import { ComputerDriveModel } from '../models/goods/computerTechnologies/computerParts/computerDriveModel';
import { MauseModel } from '../models/goods/computerTechnologies/computerAccessories/mauseModel';
import { KeyboardModel } from '../models/goods/computerTechnologies/computerAccessories/keyboardModel';
import { HeadphonesModel } from '../models/goods/computerTechnologies/computerAccessories/headphonesModel';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { HandlerErrorsService } from '../services/handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class AddingGoodsService {

  constructor(private http: HttpClient, 
    private imgService: ImgService,
    private handlerErrorsService: HandlerErrorsService) { }

  getQuestions(type: string): Observable<QuestionsBase<string>>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.AddingGoods.Path}/${mainApiPathes.AddingGoods.GetQuestions}`;
    const params = new HttpParams().set("type", type);
    return this.http.get<QuestionsBase<string>>(url, {params: params})
    .pipe(
      catchError(this.handlerErrorsService.handleError<QuestionsBase<string>>('getGoodsInformation'))
    );
  }
  getGoodTypes(part: string): Observable<string[]>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.AddingGoods.Path}/${mainApiPathes.AddingGoods.GetTypes}`;
    const params = new HttpParams().set("part", part);
    return this.http.get<string[]>(url, {params: params})
    .pipe(
      catchError(this.handlerErrorsService.handleError<string[]>('getGoodsInformation'))
    );
  }
  private sendGood(result: GoodModel, questionsKey: string): Observable<number>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.AddingGoods.Path}/${questionsKey}`;
    return this.http.post<number>(url, result)
    .pipe(
      catchError(this.handlerErrorsService.handleError<number>('getGoodsInformation'))
    );
  }
  getOptions(part: string, questionKey: string): Observable<QuestionOption[]>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.AddingGoods.Path}/${questionKey}`;
    const params = new HttpParams().set("part", part);
    return this.http.get<QuestionOption[]>(url, {params: params})
    .pipe(
      catchError(this.handlerErrorsService.handleError<QuestionOption[]>('getGoodsInformation'))
    );
  }

  addGood(questionsKey: string, imageFiles: File[], formGroupValue: any, goodType: string){
    let good: any;
    switch (goodType) {
      case "Good":
        good = new GoodModel(formGroupValue);
        break;
      case "ComputerTechnology":
        good = new ComputerTechnologyModel(formGroupValue);
        break;
      case "ComputerPart":
        good = new ComputerPartModel(formGroupValue);
        break;
      case "ComputerAccessory":
        good = new ComputerAccessoryModel(formGroupValue);
        break;
      case "Computer":
        good = new ComputerModel(formGroupValue);
        break;
      case "Laptop":
        good = new LaptopModel(formGroupValue);
        break;
      case "FlashDrive":
        good = new FlashDriveModel(formGroupValue);
        break;
      case "VideoCard":
        good = new VideoCardModel(formGroupValue);
        break;
      case "CPU":
        good = new CPUModel(formGroupValue);
        break;
      case "Cooler":
        good = new CoolerModel(formGroupValue);
        break;
      case "ComputerDrive":
        good = new ComputerDriveModel(formGroupValue);
        break;
      case "Mause":
        good = new MauseModel(formGroupValue);
        break;
      case "Keyboard":
        good = new KeyboardModel(formGroupValue);
        break;
      case "Headphones":
        good = new HeadphonesModel(formGroupValue);
        break;
      default:
        good = new GoodModel(formGroupValue);
        break;
    }
    if (imageFiles === []) {
      this.sendGood(good, questionsKey).subscribe(res => console.log(res));
    }
    else{
      this.imgService.saveImages(imageFiles).subscribe(imageIds => {
        good.imageIds = imageIds;
        this.sendGood(good, questionsKey).subscribe(res => console.log(res));
      });
    }
  }
}
