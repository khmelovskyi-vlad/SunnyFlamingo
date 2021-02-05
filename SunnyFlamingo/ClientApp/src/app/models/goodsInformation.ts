import { GoodCellModel } from "./goodCellModel";
import { QuestionsBase } from "./questionsBase";

export interface GoodsInformation<T> {
  goodCells: GoodCellModel[];
  questions: QuestionsBase<T>[]
}