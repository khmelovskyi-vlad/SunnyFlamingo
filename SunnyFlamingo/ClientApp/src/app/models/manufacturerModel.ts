import { Guid } from "guid-typescript";

export interface ManufacturerModel{
  id: Guid;
  name: string;
  address: string;
  country: string;
}