import { ComputerPartModel } from "../computerPartModel";

export class CoolerModel extends ComputerPartModel{
  type: string;
  fanSize: number;
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
    type: string;
    fanSize: number;
  }){
    super(options);
    this.type = options.type;
    this.fanSize = +options.fanSize;
  }
}