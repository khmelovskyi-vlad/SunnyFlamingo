import { ControlType } from '../valueObjects/controlType';
import { QuestionBase } from './questionBase';

export class TextboxQuestion extends QuestionBase<string> {
  controlType = ControlType.textbox;
}