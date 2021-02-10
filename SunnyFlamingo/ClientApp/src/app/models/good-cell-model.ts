import { Guid } from "guid-typescript";

export interface GoodCellModel{
  id: any;
  name: string;
  price: number;
  isAvailable: boolean;
  imgId: Guid | null;
  type: string;
}