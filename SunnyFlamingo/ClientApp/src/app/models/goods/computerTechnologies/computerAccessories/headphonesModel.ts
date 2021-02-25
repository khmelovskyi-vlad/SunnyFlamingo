import { ComputerAccessoryModel } from "../computerAccessoryModel";


export class HeadphonesModel extends ComputerAccessoryModel{
  type: string;
  wirelessType: string;
  connectorType: string;
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
    wirelessType: string;
    connectorType: string;
  }){
    super(options);
    this.type = options.type;
    this.wirelessType = options.wirelessType;
    this.connectorType = options.connectorType;
  }
}