import { ComputerPartModel } from "../computerPartModel";

export interface ComputerDriveModel extends ComputerPartModel{
  capacity: number;
  type: string;
  formFactorTypeValue: string;
  formFactorType: string;
}