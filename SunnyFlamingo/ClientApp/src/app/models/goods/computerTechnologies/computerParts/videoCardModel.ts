import { ComputerPartModel } from "../computerPartModel";

export interface VideoCardModel extends ComputerPartModel{
  videoSize: number;
  driveInterfaceValue: string;
  driveInterface: string;
  videoMemoryCapacity: number;
}