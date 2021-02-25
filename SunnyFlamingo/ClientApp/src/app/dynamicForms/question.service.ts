import { Injectable } from '@angular/core';

import { DropdownQuestion } from '../models/question-dropdown';
import { QuestionBase } from '../models/question-base';
import { TextboxQuestion } from '../models/question-textbox';
import { of } from 'rxjs';
import { InputType } from '../value-objects/input-type';
import { CheckboxQuestion } from '../models/question-checkbox';
import { QuestionsBase } from '../models/questions-base';
import { ActivatedRoute, Router } from '@angular/router';
import { UrlParameterModel } from '../models/urlParameterModel';

@Injectable({
  providedIn: 'root'
})
export class QuestionService {
  
  constructor(private router: Router, private route: ActivatedRoute) { }
  

  // searchGoods(key: string, value: any, key2?: string, value2?: any) {
    
  //   // const newUrlParameter = new UrlParameterModel(key, value);
  //   let params = this.getParams();
  //   const queryParameters = this.createQueryParameters(params, key, value, key2, value2);
  //   let url = `${this.router.url.split('?')[0]}`;
  //   if (url === '/') {
  //     url = '/goods';
  //   }
  //   this.router.navigate([url], { queryParams: queryParameters });
    
  //   // const url = this.createUrl(this.router.url, params, newUrlParameter);
  //   // window.open(url, '_self');
  // }
  // getParams(): any {
  //   let params: any;
  //   this.route.queryParams
  //     .subscribe(parameters => {
  //       params = parameters;
  //   });
  //   return params;
  // }
  // createQueryParameters(parameters: any, newKey: string, newValue: any, newKey2?: string, newValue2?: any): any {
  //   const result: any = {};
  //   const keys = Object.keys(parameters);
  //   const haveParameter = this.checkAddNewParameter(keys, newKey, newKey2);
  //   for (let i = 0; i < keys.length; i++) {
  //     const key = keys[i];
  //     const parameterValues = this.getParameterValues(parameters[key].split(','),
  //       key,
  //       newKey,
  //       newValue,
  //       newKey2,
  //       newValue2);
  //     if (parameterValues.length > 0) {
  //       let value = "";
  //       for (let j = 0; j < parameterValues.length; j++) {
  //         if (j === parameterValues.length - 1) {
  //           value = value + parameterValues[j]
  //         }
  //         else {
  //           value = value + parameterValues[j] + ','
  //         }
  //       }
  //       result[key] = value;
  //     }
  //   }
  //   if (!haveParameter) {
  //     result[newKey] = newValue;
  //     if (newKey2 != null && newValue2 != null) {
  //       result[newKey2] = newValue2;
  //     }
  //   }
  //   return result;
  // }
  // createUrl(currentUrl: string, parameters: any, newUrlParameter: UrlParameterModel): string {
  //   const keys = Object.keys(parameters);
  //   const haveParameter = this.checkAddNewParameter(keys, newUrlParameter.key);
  //   let url = `${currentUrl.split('?')[0]}?`;
  //   let haveAnyParameter = false;
  //   for (let i = 0; i < keys.length; i++) {
  //     const key = keys[i];
  //     const parameterValues = this.getParameterValues(parameters[key].split(','),
  //       key,
  //       newUrlParameter.key,
  //       newUrlParameter.name);
      
  //     for (let j = 0; j < parameterValues.length; j++) {
  //       const parameterValue = parameterValues[j];
  //       haveAnyParameter = true;
  //       if (i === keys.length - 1 && j === parameterValues.length - 1) {
  //         if (parameterValues.length === 1) {
  //           url += `${key}=${parameterValue}`;
  //         }
  //         else {
  //           url += `${parameterValue}`;
  //         }
  //       }
  //       else {
  //         if (j === parameterValues.length - 1) {
  //           url += `${key}=${parameterValue}&`;
  //         }
  //         else {
  //           if (j === 0) {
  //             url += `${key}=${parameterValue},`;
  //           }
  //           else {
  //             url += `${parameterValue},`;
  //           }
  //         }
  //       }
  //     }
  //   }
  //   if (!haveAnyParameter && !haveParameter) {
  //     url = url.slice(0, -1);
  //   }
  //   if (!haveParameter) {
  //      url += `&${newUrlParameter.key}=${newUrlParameter.name}`;
  //   }
  //   return url;
  // }
  
  // getParameterValues(
  //   values: string[],
  //   key: string,
  //   newKey: string,
  //   newValue: string,
  //   newKey2?: string,
  //   newValue2?: any): string[] {
  //   if (newKey2 != null && newValue2 != null) {
  //     return this.getMultiplyParameterValues(values, key, newKey, newValue, newKey2, newValue2);
  //   }
  //   else {
  //     return this.getOneParameterValues(values, key, newKey, newValue);
  //   }
  // }
  // getOneParameterValues(
  //   values: string[],
  //   key: string,
  //   newKey: string,
  //   newValue: string): string[] {
  //   if (key === newKey) {
  //     if (values.includes(newValue)) {
  //       return values.filter(value => value !== newValue);
  //     }
  //     else {
  //       values.push(newValue);
  //     }
  //   }
  //   return values;
  // }
  // getMultiplyParameterValues(
  //   values: string[],
  //   key: string,
  //   newKey: string,
  //   newValue: string,
  //   newKey2?: string,
  //   newValue2?: any): string[] {
  //   if (key === newKey) {
  //     return [newValue];
  //   }
  //   else if(key === newKey2) {
  //     return [newValue2];
  //   }
  //   return values;
  // }
  // checkAddNewParameter(keys: string[], newKey: string, newKey2?: string): boolean {
  //   if (newKey2) {
  //     return keys.includes(newKey) && keys.includes(newKey2);
  //   }
  //   return keys.includes(newKey);
  // }



  getQuestions() {
    const questions: QuestionsBase<string>[] = [
      new QuestionsBase({
        value: 'first Value',
        key: 'firstForm',
        questionBaseList: [
          new DropdownQuestion({
            key: 'brave',
            label: 'Bravery Rating',
            options: [
              { key: 'solid', value: 'Solid' },
              { key: 'great', value: 'Great' },
              { key: 'good', value: 'Good' },
              { key: 'unproven', value: 'Unproven' }
            ],
            order: 3
          }),

          new TextboxQuestion({
            key: 'firstName',
            label: 'First name',
            value: 'Bombasto',
            order: 1
          })
        ]
      })
      ,
      new QuestionsBase({
        value: 'second Value',
        key: 'secondForm',
        questionBaseList:
          [
            new TextboxQuestion({
              key: 'emailAddress',
              label: 'Email',
              type: InputType.email,
              order: 2
            }),

            new CheckboxQuestion({
              key: 'checkbox',
              label: 'Checkbox',
              type: InputType.checkbox,
              order: 1,
              checked: true,
              afterBox: 234
            })
          ]
      })
    ];
    questions.sort((a, b) => a.order - b.order);
    questions.forEach(el => el.questionBaseList.sort((a, b) => a.order - b.order));
    return questions;
  }
}