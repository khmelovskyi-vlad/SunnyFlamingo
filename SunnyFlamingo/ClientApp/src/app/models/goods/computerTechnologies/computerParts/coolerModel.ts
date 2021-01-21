import { ComputerPartModel } from "../computerPartModel";

export interface CoolerModel extends ComputerPartModel{
  typeValue: string;
  type: string;
  fanSize: number;
}