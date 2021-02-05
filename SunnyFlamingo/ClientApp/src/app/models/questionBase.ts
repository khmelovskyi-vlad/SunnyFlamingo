import { ControlType } from "../valueObjects/controlType";
import { InputType } from "../valueObjects/inputType";

export class QuestionBase<T> {
  value?: T;
  key: string;
  label: string;
  required: boolean;
  order: number;
  controlType?: ControlType;
  type?: InputType;
  options: { key: string, value: string }[];
  checked?: boolean;
  afterBox?: string;
  selectedFrom?: number;
  selectedTo?: number;
  from?: number;
  to?: number;

  constructor(options: {
      value?: T;
      key?: string;
      label?: string;
      required?: boolean;
      order?: number;
      controlType?: ControlType;
      type?: InputType;
      options?: {key: string, value: string}[];
      checked?: boolean;
      afterBox?: string;
      selectedFrom?: number;
      selectedTo?: number;
      from?: number;
      to?: number;
    } = {}) {
    this.value = options.value;
    this.key = options.key || '';
    this.label = options.label || '';
    this.required = !!options.required;
    this.order = options.order === undefined ? 1 : options.order;
    this.controlType = options.controlType;
    this.type = options.type;
    this.options = options.options || [];
    this.checked = options.checked;
    this.afterBox = options.afterBox;
    this.selectedFrom = options.selectedFrom;
    this.selectedTo = options.selectedTo;
    this.from = options.from;
    this.to = options.to;
  }
}