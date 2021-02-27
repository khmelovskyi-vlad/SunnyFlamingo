export class DeliveryMethodModel{
  id: string;
  value: string;
  constructor(options:{id: string, value: string}) {
    this.id = options.id;
    this.value = options.value;
  }
}