import { ComputerPartModel } from "../computerPartModel";

export class ComputerDriveModel extends ComputerPartModel{
  capacity: number;
  type: string;
  formFactorType: string;
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
    capacity: number;
    type: string;
    formFactorType: string;
  }){
    super(options);
    this.capacity = +options.capacity;
    this.type = options.type;
    this.formFactorType = options.formFactorType;
  }
}