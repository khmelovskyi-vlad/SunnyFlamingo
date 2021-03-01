import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { UserModel } from '../models/user-model';
import { HandlerErrorsService } from './handler-errors.service';
import { catchError } from 'rxjs/operators';

import * as mainApiPathes from '../../assets/mainApiPathes.json';

@Injectable({
  providedIn: 'root'
})
export class UsersService {

  constructor(private http: HttpClient,  
    private handlerErrorsService: HandlerErrorsService) { }

  getUserModel(): Observable<UserModel>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.Users.Path}/${mainApiPathes.Users.GetUserModel}`;
    return this.http.get<UserModel>(url)
    .pipe(
      catchError(this.handlerErrorsService.handleError<UserModel>('getUserModel'))
    );
  }
}
