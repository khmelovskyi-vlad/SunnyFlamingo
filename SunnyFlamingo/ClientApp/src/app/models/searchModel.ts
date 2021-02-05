export class SearchModel{
  parameter: string;
  value: any;
  checked: boolean;
  constructor(parameter: string, value: any, checked: boolean) {
    this.parameter = parameter;
    this.value = value;
    this.checked = checked;
  }
}