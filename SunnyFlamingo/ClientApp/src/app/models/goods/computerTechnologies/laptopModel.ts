import { ComputerTechnologyModel } from "../computerTechnologyModel";

export interface LaptopModel extends ComputerTechnologyModel{
  amountOfRAM: number;
  CPUFrequency: number;
  length: number;
  height: number;
  width: number;
  haveFloppyDrives: boolean;
  SSDMemory: number;
  hardDiskMemory: number;
  CPUSocketType: string;
  computerDriveType: string;
  numberOfCores: number;
  floppyDrivesCount: number;
  display: number;
}