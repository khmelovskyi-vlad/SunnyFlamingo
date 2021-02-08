import { ControlType } from '../value-objects/control-type';
import { QuestionBase } from './question-base';

export class CheckboxQuestion extends QuestionBase<string> {
  controlType = ControlType.checkbox;
}