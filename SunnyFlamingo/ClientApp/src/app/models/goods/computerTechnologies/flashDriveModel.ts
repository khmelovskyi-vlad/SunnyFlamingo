import { ComputerTechnologyModel } from "../computerTechnologyModel";

export class FlashDriveModel extends ComputerTechnologyModel{
  capacity: number;
  usbSpecificationType: string;
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
    usbSpecificationType: string;
  }){
    super(options);
    this.capacity = +options.capacity;
    this.usbSpecificationType = options.usbSpecificationType;
  }
}