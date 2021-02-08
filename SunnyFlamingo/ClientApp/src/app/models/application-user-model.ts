import { Guid } from "guid-typescript";
import { GoodModel } from "./good-model";

export interface ApplicationUserModel{
  id: Guid;
  firstName: string;
  lastName: string;
  avatars: Guid[];
  goods: GoodModel[];
}