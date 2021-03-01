import { Injectable } from '@angular/core';
import { ActivatedRoute, NavigationEnd, Router } from '@angular/router';
import { ParameterSelector } from '../models/parameter-selector';

@Injectable({
  providedIn: 'root'
})
export class UrlParameterService {

  constructor(private router: Router, private route: ActivatedRoute) { }

  getSelector(): ParameterSelector{
    const selector = new ParameterSelector();
    let params = this.getParams();
    const keys = Object.keys(params);
    for (let i = 0; i < keys.length; i++) {
      this.changeSelectorByKey(selector, keys[i], params[keys[i]].split(','));
    }
    return selector;
  }
  changeSelectorByKey(selector: ParameterSelector, key: string, values: string[]){
    switch (key) {
      case "producer":
        selector.producers = values;
        break;
      case "country":
        selector.countries = values;
        break;
      case "material":
        selector.materials = values;
        break;
      case "color":
        selector.colors = values;
        break;
      case "priceFrom":
        selector.priceFrom = +values[0];
        break;
      case "priceTo":
        selector.priceTo = +values[0];
        break;
      case "amountOfRAM":
        selector.amountOfRAMs = values.map(item => +item);
        break;
      case "CPUFrequency":
        selector.cpuFrequencies = values.map(item => +item);
        break;
      case "height":
        selector.height = values.map(item => +item);
        break;
      case "width":
        selector.width = values.map(item => +item);
        break;
      case "length":
        selector.length = values.map(item => +item);
        break;
      case "amountOfRAM":
        selector.amountOfRAMs = values.map(item => +item);
        break;
      case "haveFloppyDrives":
        selector.haveFloppyDrives = values.map(item => 'true' ? true : false);
        break;
      case "SSDMemory":
        selector.ssdMemory = values.map(item => +item);
        break;
      case "hardDiskMemory":
        selector.hardDiskMemory = values.map(item => +item);
        break;
      case "amountOfRAM":
        selector.amountOfRAMs = values.map(item => +item);
        break;
      case "amountOfRAM":
        selector.amountOfRAMs = values.map(item => +item);
        break;
      case "CPUSocketType":
        selector.cpuSocketTypes = values;
        break;
      case "computerDriveType":
        selector.computerDriveTypes = values;
        break;
      case "numberOfCores":
        selector.numberOfCores = values.map(item => +item);
        break;
      case "floppyDrivesCount":
        selector.floppyDrivesCount = values.map(item => +item);
        break;
      case "display":
        selector.displays = values.map(item => +item);
        break;
      case "capacity":
        selector.capacities = values.map(item => +item);
        break;
      case "USBSpecificationType":
        selector.usbSpecificationTypes = values;
        break;
      case "driveInterface":
        selector.driveInterfaces = values;
        break;
      case "videoSize":
        selector.videoSizes = values.map(item => +item);
        break;
      case "videoMemoryCapacity":
        selector.videoMemoryCapacities = values.map(item => +item);
        break;
      case "thermalDesignPower":
        selector.thermalDesignPowers = values.map(item => +item);
        break;
      case "numberOfThreads":
        selector.numberOfThreads = values.map(item => +item);
        break;
      case "fanSize":
        selector.fanSizes = values.map(item => +item);
        break;
      case "formFactorType":
        selector.formFactorTypes = values;
        break;
      case "coolerType":
      case "mauseType":
      case "keyboardType":
      case "headphonesType":
        selector.types = values;
        break;
      case "buttonsCount":
        selector.buttonsCount = values.map(item => +item);
        break;
      case "wirelessType":
        selector.wirelessTypes = values;
        break;
      case "connectorType":
        selector.connectorTypes = values;
        break;
      case "page":
        selector.page = +values[0];
        break;
      case "count":
        selector.showGoods = +values[0];
        break;
      case "sort":
        selector.orderType = +values[0];
        break;
      case "dir":
        selector.sortDir = +values[0];
        break;
      case "name":
        selector.name = values[0];
        break;
      default:
        break;
    }
  }
  checkHavingParam(key: string): boolean{
    return Object.keys(this.getParams()).includes(key);
  }
  searchGoods(key: string, value: any, key2?: string, value2?: any, isNew?: boolean, remove?: boolean, ignorePage = true) {
    let params = this.getParams();
    if (isNew || remove) {
      let newParams: any = {};
      for (const [parKey, parValue] of Object.entries(params)) {
        if ((parKey === 'page' && ignorePage) || parKey === key || (key2 && parKey == key2) ) {
          continue;
        }
        newParams[parKey] = parValue;
      }
      params = newParams;
    }
    
    if (!remove) {
      params = this.createQueryParameters(params, key, value, key2, value2, ignorePage);
    }
    let url = `${this.router.url.split('?')[0]}`;
    if (url === '/') {
      url = '/goods';
    }
    this.router.navigate([url], { queryParams: params });
  }
  getPage(): number{
    let params = this.getParams();
    const key = Object.keys(params).find(key => key === 'page');
    if (key === undefined) {
      return 1;
    }
    else {
      return +params[key];
    }
  }
  getCount(): number{
    let params = this.getParams();
    const key = Object.keys(params).find(key => key === 'count');
    if (key === undefined) {
      return 36;
    }
    else {
      return +params[key];
    }
  }
  getParams(): any {
    let params: any;
    this.route.queryParams
      .subscribe(parameters => {
        params = parameters;
    });
    return params;
  }
  createQueryParameters(parameters: any, newKey: string, newValue: any, newKey2?: string, newValue2?: any, 
    ignorePage = true): any {
    const result: any = {};
    const keys = Object.keys(parameters);
    const haveParameter = this.checkAddNewParameter(keys, newKey, newKey2);
    for (let i = 0; i < keys.length; i++) {
      const key = keys[i];
      if (key === 'page' && ignorePage) {
        continue;
      }
      const parameterValues = this.getParameterValues(parameters[key].split(','),
        key,
        newKey,
        newValue,
        newKey2,
        newValue2);
      if (parameterValues.length > 0) {
        
        let value = "";
        for (let j = 0; j < parameterValues.length; j++) {
          if (j === parameterValues.length - 1) {
            value = value + parameterValues[j]
          }
          else {
            value = value + parameterValues[j] + ','
          }
        }
        result[key] = value;
      }
    }
    if (!haveParameter) {
      result[newKey] = newValue;
      if (newKey2 != null && newValue2 != null) {
        result[newKey2] = newValue2;
      }
    }
    return result;
  }
  
  getParameterValues(
    values: string[],
    key: string,
    newKey: string,
    newValue: string,
    newKey2?: string,
    newValue2?: any): string[] {
    if (newKey2 != null && newValue2 != null) {
      return this.getMultiplyParameterValues(values, key, newKey, newValue, newKey2, newValue2);
    }
    else {
      return this.getOneParameterValues(values, key, newKey, newValue);
    }
  }
  getOneParameterValues(
    values: string[],
    key: string,
    newKey: string,
    newValue: string): string[] {
    if (key === newKey) {
      if (values.includes(newValue)) {
        return values.filter(value => value !== newValue);
      }
      else {
        values.push(newValue);
      }
    }
    return values;
  }
  getMultiplyParameterValues(
    values: string[],
    key: string,
    newKey: string,
    newValue: string,
    newKey2?: string,
    newValue2?: any): string[] {
    if (key === newKey) {
      return [newValue];
    }
    else if(key === newKey2) {
      return [newValue2];
    }
    return values;
  }
  checkAddNewParameter(keys: string[], newKey: string, newKey2?: string): boolean {
    if (newKey2) {
      return keys.includes(newKey) && keys.includes(newKey2);
    }
    return keys.includes(newKey);
  }
}
