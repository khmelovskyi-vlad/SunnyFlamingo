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

  constructor(options: {
      value?: T;
      key?: string;
      label?: string;
      required?: boolean;
      order?: number;
      controlType?: ControlType;
      type?: InputType;
      options?: {key: string, value: string}[];
      checked?: boolean
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
  }
}