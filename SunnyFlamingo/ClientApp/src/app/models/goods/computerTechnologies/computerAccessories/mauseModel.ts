import { ComputerAccessoryModel } from "../computerAccessoryModel";


export class MauseModel extends ComputerAccessoryModel{
  type: string;
  buttonsCount: number;
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
    buttonsCount: number;
  }){
    super(options);
    this.type = options.type;
    this.buttonsCount = +options.buttonsCount;
  }
}