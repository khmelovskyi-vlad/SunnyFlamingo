import { ComputerAccessoryModel } from "../computerAccessoryModel";


export interface HeadphonesModel extends ComputerAccessoryModel{
  type: string;
  wirelessType: string;
  connectorTypeValue: string;
  connectorType: string;
}