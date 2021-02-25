import { ComputerAccessoryModel } from "../computerAccessoryModel";


export class KeyboardModel extends ComputerAccessoryModel{
  type: string;
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
  }){
    super(options);
    this.type = options.type;
  }
}