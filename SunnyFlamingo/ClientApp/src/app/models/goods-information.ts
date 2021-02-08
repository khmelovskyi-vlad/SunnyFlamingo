import { GoodCellModel } from "./good-cell-model";
import { QuestionsBase } from "./questions-base";

export interface GoodsInformation<T> {
  goodCells: GoodCellModel[];
  questions: QuestionsBase<T>[]
}