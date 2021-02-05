import { ControlType } from '../valueObjects/controlType';
import { QuestionBase } from './questionBase';

export class CheckboxQuestion extends QuestionBase<string> {
  controlType = ControlType.checkbox;
}