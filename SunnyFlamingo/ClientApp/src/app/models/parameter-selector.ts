import { OrderType } from "../value-objects/order-type";
import { SortDir } from "../value-objects/sort-dir";

export class ParameterSelector {
  producers: string[];
  countries: string[];
  materials: string[];
  colors: string[];
  priceFrom?: number;
  priceTo?: number;
  orderType: OrderType = OrderType.name;
  sortDir: SortDir = SortDir.asc;
  page: number = 1;
  showGoods: number = 36;
  name: string | undefined;
  
  amountOfRAMs: number[];
  cpuFrequencies: number[];
  length: number[];
  height: number[];
  width: number[];
  haveFloppyDrives: boolean[];
  ssdMemory: number[];
  hardDiskMemory: number[];
  cpuSocketTypes: string[];
  computerDriveTypes: string[];
  numberOfCores: number[];
  floppyDrivesCount: number[];
  displays: number[];
  capacities: number[];
  types: string[];
  formFactorTypes: string[];
  fanSizes: number[];
  thermalDesignPowers: number[];
  numberOfThreads: number[];
  usbSpecificationTypes: string[];
  wirelessTypes: string[];
  connectorTypes: string[];
  buttonsCount: number[];
  driveInterfaces: string[];
  videoSizes: number[];
  videoMemoryCapacities: number[];
}