import { Guid } from "guid-typescript";
import { GoodCellModel } from "../models/good-cell-model";

export const GOODS: GoodCellModel[] = [
  {id: Guid.create(), name: "foo1gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg", price: 100, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo2", price: 10023, imgId: Guid.create(), isAvailable: false, type: ""},
  {id: Guid.create(), name: "foo3", price: 11200, imgId: Guid.create(), isAvailable: false, type: ""},
  {id: Guid.create(), name: "foo4", price: 1050, imgId: null, isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo5", price: 1060, imgId: null, isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo6", price: 1050, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo7", price: 1070, imgId: null, isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo8", price: 1020, imgId: Guid.create(), isAvailable: false, type: ""},
  {id: Guid.create(), name: "foo9", price: 10970, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo10", price: 1020, imgId: null, isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo11", price: 105670, imgId: Guid.create(), isAvailable: false, type: ""},
  {id: Guid.create(), name: "foo12", price: 10320, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo13", price: 1050, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo14", price: 102220, imgId: Guid.create(), isAvailable: false, type: ""},
  {id: Guid.create(), name: "foo15", price: 102340, imgId: Guid.create(), isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo16", price: 1060, imgId: null, isAvailable: true, type: ""},
  {id: Guid.create(), name: "foo17", price: 20, imgId: Guid.create(), isAvailable: false, type: ""},
]