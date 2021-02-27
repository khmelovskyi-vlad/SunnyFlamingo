import { BasketGoodModel } from "./basket-good-model";
import { DeliveryMethodModel } from "./delivery-method-model";
import { UserModel } from "./user-model";

export class OrderModel{
  id?: string;
  address: string;
  deliveryMethod: DeliveryMethodModel;
  user: UserModel;
  basketGoods: BasketGoodModel[];
  constructor(
    options: {
    id?: string, 
    address: string, 
    deliveryMethod: DeliveryMethodModel, 
    userModel: UserModel, 
    basketGoods: BasketGoodModel[]}) {
    this.id = options.id;
    this.address = options.address;
    this.deliveryMethod = options.deliveryMethod;
    this.user = options.userModel;
    this.basketGoods = options.basketGoods;
  }
}