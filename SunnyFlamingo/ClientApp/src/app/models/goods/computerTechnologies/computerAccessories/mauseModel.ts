import { ComputerAccessoryModel } from "../computerAccessoryModel";


export interface MauseModel extends ComputerAccessoryModel{
  type: string;
  buttonsCount: number;
}