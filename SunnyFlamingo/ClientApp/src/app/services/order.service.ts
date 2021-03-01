import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { Observable } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { BasketGoodModel } from '../models/basket-good-model';
import { DeliveryMethodModel } from '../models/delivery-method-model';
import { OrderModel } from '../models/order-model';
import { UserModel } from '../models/user-model';
import * as mainApiPathes from '../../assets/mainApiPathes.json';
import { HandlerErrorsService } from './handler-errors.service';

@Injectable({
  providedIn: 'root'
})
export class OrderService {

  constructor(private http: HttpClient, private handlerErrorsService: HandlerErrorsService) { }
  
  addOrder(orderForm: FormGroup, 
    deliveryMethodModels: DeliveryMethodModel[], 
    basketGoods: BasketGoodModel[]): Observable<number>{
    const orderModel = this.createOrderModel(orderForm, deliveryMethodModels, basketGoods);
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.Orders.Path}/${mainApiPathes.Orders.SaveOrder}`;
    return this.http.post<number>(url, orderModel)
    .pipe(
      catchError(this.handlerErrorsService.handleError<number>('addOrder'))
    );
  }
  createOrderModel(
    orderForm: FormGroup, 
    deliveryMethodModels: DeliveryMethodModel[], 
    basketGoods: BasketGoodModel[]): OrderModel | undefined {
    const user = this.getUser(orderForm);
    const address = orderForm.get("address")?.value;
    const deliveryMethod = this.getDeliveryMethod(orderForm, deliveryMethodModels);
    if (deliveryMethod) {
      return new OrderModel({address: address, deliveryMethod: deliveryMethod, userModel: user, basketGoods: basketGoods });
    }
    return undefined;
  }
  getUser(orderForm: FormGroup): UserModel{
    const firstName = orderForm.get("firstName")?.value;
    const lastName = orderForm.get("lastName")?.value;
    const email = orderForm.get("email")?.value;
    return new UserModel({firstName: firstName, lastName: lastName, email: email});
  }
  getDeliveryMethod(orderForm: FormGroup, deliveryMethodModels: DeliveryMethodModel[]): DeliveryMethodModel | undefined{
    const deliveryMethod = orderForm.get("deliveryMethod")?.value;
    return deliveryMethodModels.find(dmm => dmm.value === deliveryMethod);
  }
  searchDeliveryMethods(): Observable<DeliveryMethodModel[]>{
    const url = `${mainApiPathes.StartPath}/${mainApiPathes.Orders.Path}/${mainApiPathes.Orders.GetDeliveryMethods}`;
    return this.http.get<DeliveryMethodModel[]>(url)
    .pipe(
      catchError(this.handlerErrorsService.handleError<DeliveryMethodModel[]>('searchDeliveryMethods'))
    );
  }
}
