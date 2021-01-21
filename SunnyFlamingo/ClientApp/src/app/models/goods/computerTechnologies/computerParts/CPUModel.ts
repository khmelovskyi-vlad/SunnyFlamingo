import { ComputerPartModel } from "../computerPartModel";

export interface CPUModel extends ComputerPartModel{
  CPUSocketType: string;
  thermalDesignPower: number;
  numberOfCores: number;
  numberOfThreads: number;
}