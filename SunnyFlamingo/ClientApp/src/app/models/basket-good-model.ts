import { GoodInformation } from "./good-information";

export interface BasketGoodModel{
  goodInformation: GoodInformation;
  count: number;
  addDate: Date;
}