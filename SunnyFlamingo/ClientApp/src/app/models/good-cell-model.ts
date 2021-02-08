import { Guid } from "guid-typescript";

export interface GoodCellModel{
  id: Guid;
  name: string;
  price: number;
  isAvailable: boolean;
  imgId: Guid | null;
  type: string;
}