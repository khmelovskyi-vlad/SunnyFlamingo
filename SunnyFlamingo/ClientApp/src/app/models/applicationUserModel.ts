import { Guid } from "guid-typescript";
import { GoodModel } from "./goodModel";

export interface ApplicationUserModel{
  id: Guid;
  firstName: string;
  lastName: string;
  avatars: Guid[];
  goods: GoodModel[];
}