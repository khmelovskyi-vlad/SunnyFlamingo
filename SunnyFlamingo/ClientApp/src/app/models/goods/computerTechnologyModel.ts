import { GoodModel } from "../good-model"

export class ComputerTechnologyModel extends GoodModel{
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
  }){
    super(options);
  }
}