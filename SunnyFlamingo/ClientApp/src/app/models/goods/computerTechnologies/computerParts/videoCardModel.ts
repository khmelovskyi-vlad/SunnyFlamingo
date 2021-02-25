import { ComputerPartModel } from "../computerPartModel";

export class VideoCardModel extends ComputerPartModel{
  videoSize: number;
  driveInterface: string;
  videoMemoryCapacity: number;
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
    videoSize: number;
    driveInterface: string;
    videoMemoryCapacity: number;
  }){
    super(options);
    this.videoSize = +options.videoSize;
    this.driveInterface = options.driveInterface;
    this.videoMemoryCapacity = +options.videoMemoryCapacity;
  }
}