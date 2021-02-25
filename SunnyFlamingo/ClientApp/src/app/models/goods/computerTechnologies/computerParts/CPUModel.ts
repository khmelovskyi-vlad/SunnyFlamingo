import { ComputerPartModel } from "../computerPartModel";

export class CPUModel extends ComputerPartModel{
  cpuSocketType: string;
  thermalDesignPower: number;
  numberOfCores: number;
  numberOfThreads: number;
  constructor(options: {
    name: string;
    price: number;
    isAvailable: string;
    description: string;
    producerId: string;
    manufacturerId: string;
    material: string;
    color: string;
    imageIds: string[];
    cpuSocketType: string;
    thermalDesignPower: number;
    numberOfCores: number;
    numberOfThreads: number;
  }){
    super(options);
    this.cpuSocketType = options.cpuSocketType;
    this.thermalDesignPower = +options.thermalDesignPower;
    this.numberOfCores = +options.numberOfCores;
    this.numberOfThreads = +options.numberOfThreads;
  }
}