import { ComputerTechnologyModel } from "../computerTechnologyModel";

export interface FlashDriveModel extends ComputerTechnologyModel{
  capacity: number;
  USBSpecificationTypeValue: string;
  USBSpecificationType: string;
}