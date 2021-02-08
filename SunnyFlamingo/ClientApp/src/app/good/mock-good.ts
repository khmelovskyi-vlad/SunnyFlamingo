import { Guid } from "guid-typescript";
import { GoodInformation } from "../models/good-information";
import { PropertyModel } from "../models/property-model";

const properties: PropertyModel[] = [
  {name: "prop1", value: "description"},
  {name: "prop2", value: "description dfgdfbgfngndfgdfg"},
  {name: "prop3", value: "description dfbfgnghn ghn ghntyntynty "},
  {name: "prop4", value: "description dfgd dfgdfngm tjt j6hrhrthrtbcv hht"},
  {name: "prop5", value: "description            hrthrthrthreh er gergwergwegwe         "},
  {name: "prop6", value: "description wetwet we tergdf g"},
  {name: "prop7", value: "description dfg dfgdfg dfg dfg "},
  {name: "prop8", value: "description sdfehtytyj gdfgd gdfg dfgdfgfng"},
];


export const GOOD: GoodInformation = {
  id: Guid.create(),
  name: "some good name",
  price: 24234.234,
  isAvailable: true,
  imgIds: [],
  type: "some type",
  description: "aksjfhksdkdsnkv ksjdh vksdh fkdshkfh dskfhksdjh fjksdhfkshdf hsdkfh shdofi sjhdfksh kdfh skhfsdkfjhsdkjfhksdhflsdkfhksdjh fkjsdh fkjdsh jkfhskdfh ksdhf ksdhkjsdhksd hfkjhsd fhs dkjfh skdjfh ksjdhf ksjdhfkjh",
  producer: "Samsung",
  country: "Ukraine",
  material: "leather",
  color: "blue",
  properties: properties
};
