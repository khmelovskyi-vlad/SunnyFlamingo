import { ControlType } from '../valueObjects/controlType';
import { QuestionBase } from './questionBase';

export class DropdownQuestion extends QuestionBase<string> {
  controlType = ControlType.dropdown;
}