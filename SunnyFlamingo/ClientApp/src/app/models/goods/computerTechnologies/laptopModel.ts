import { ComputerTechnologyModel } from "../computerTechnologyModel";

export class LaptopModel extends ComputerTechnologyModel{
  amountOfRAM: number;
  cpuFrequency: number;
  length: number;
  height: number;
  width: number;
  haveFloppyDrives: boolean;
  ssdMemory?: number;
  hardDiskMemory?: number;
  cpuSocketType: string;
  computerDriveTypes: string[];
  numberOfCores: number;
  floppyDrivesCount?: number;
  display: number;
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
    amountOfRAM: number;
    cpuFrequency: number;
    length: number;
    height: number;
    width: number;
    haveFloppyDrives: string;
    ssdMemory?: number;
    hardDiskMemory?: number;
    cpuSocketType: string;
    computerDriveTypes: string;
    numberOfCores: number;
    floppyDrivesCount?: number;
    display: number;
  }){
    super(options);
    this.amountOfRAM = +options.amountOfRAM;
    this.cpuFrequency = +options.cpuFrequency;
    this.length = +options.length;
    this.height = +options.height;
    this.width = +options.width;
    if (options.haveFloppyDrives === "true") {
      this.haveFloppyDrives = true;
    }
    else{
      this.haveFloppyDrives = false;
    }
    if (options.ssdMemory) {
      this.ssdMemory = +options.ssdMemory;
    }
    if (options.hardDiskMemory) {
      this.hardDiskMemory = +options.hardDiskMemory;
    }
    this.cpuSocketType = options.cpuSocketType;
    this.computerDriveTypes = options.computerDriveTypes.split(',');
    this.numberOfCores = +options.numberOfCores;
    if (options.floppyDrivesCount) {
      this.floppyDrivesCount = +options.floppyDrivesCount;
    }
    this.display = +options.display;
  }
}