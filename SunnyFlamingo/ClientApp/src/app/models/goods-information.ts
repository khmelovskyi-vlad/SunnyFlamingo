import { GoodCellModel } from "./good-cell-model";
import { QuestionsBase } from "./questions-base";

export interface GoodsInformation<T> {
  count: number,
  goodCells: GoodCellModel[];
  questions: QuestionsBase<T>[]
}