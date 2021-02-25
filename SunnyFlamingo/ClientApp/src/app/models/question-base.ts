import { ControlType } from "../value-objects/control-type";
import { InputType } from "../value-objects/input-type";
import { QuestionOption } from "./question-option";
import { QuestionValidator } from "./question-validator";

export class QuestionBase<T> {
  value?: T;
  key: string;
  label: string;
  order: number;
  controlType?: ControlType;
  type?: InputType;
  options: QuestionOption[];
  checked?: boolean;
  afterBox?: number;
  selectedFrom?: number;
  selectedTo?: number;
  from?: number;
  to?: number;
  validator?: QuestionValidator;
  methodName: string;

  constructor(options: {
      value?: T;
      key?: string;
      label?: string;
      order?: number;
      controlType?: ControlType;
      type?: InputType;
      options?: QuestionOption[];
      checked?: boolean;
      afterBox?: number;
      selectedFrom?: number;
      selectedTo?: number;
      from?: number;
      to?: number;
      validator?: QuestionValidator;
      methodName?: string;
    } = {}) {
    this.value = options.value;
    this.key = options.key || '';
    this.label = options.label || '';
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
    this.validator = options.validator;
    this.methodName = options.methodName || '';
  }
}