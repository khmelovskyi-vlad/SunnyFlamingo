import { ControlType } from '../value-objects/control-type';
import { QuestionBase } from './question-base';

export class TextboxQuestion extends QuestionBase<string> {
  controlType = ControlType.textbox;
}