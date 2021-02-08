import { Guid } from "guid-typescript";
import { ManufacturerModel } from "./manufacturer-model";
import { ProducerModel } from "./producer-model";

export interface GoodModel{
  id: Guid;
  name: string;
  price: number;
  isAvailable: boolean;
  addTime: Date;
  producer: ProducerModel;
  manufacturer: ManufacturerModel;
  material: string;
  color: string;
  imgIds: Guid[];
}