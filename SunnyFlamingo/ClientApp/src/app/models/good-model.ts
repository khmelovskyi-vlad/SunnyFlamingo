export class GoodModel{
  name: string;
  price: number;
  isAvailable: boolean;
  description: string;
  producerId: string;
  manufacturerId: string;
  material: string;
  color: string;
  imageIds: string[];
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
    this.name = options.name;
    this.price = +options.price;
    if (options.isAvailable === "true") {
      this.isAvailable = true;
    }
    else{
      this.isAvailable = false;
    }
    this.description = options.description;
    this.producerId = options.producerId;
    this.manufacturerId = options.manufacturerId;
    this.material = options.material;
    this.color = options.color;
    this.imageIds = options.imageIds;
  }
}