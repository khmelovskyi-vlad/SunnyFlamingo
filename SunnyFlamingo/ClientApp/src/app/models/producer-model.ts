import { Guid } from "guid-typescript";

export interface ProducerModel{
  id: Guid;
  name: string;
  address: string;
  country: string;
}