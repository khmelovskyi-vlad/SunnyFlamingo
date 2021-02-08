import { ControlType } from '../value-objects/control-type';
import { QuestionBase } from './question-base';

export class DropdownQuestion extends QuestionBase<string> {
  controlType = ControlType.dropdown;
}