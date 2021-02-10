import { GoodInformation } from "../models/good-information";
import { PropertyModel } from "../models/property-model";
const { v4: uuidv4 } = require('uuid');

const properties: PropertyModel[] = [
  {key: "prop1", value: "description"},
  {key: "prop2", value: "description dfgdfbgfngndfgdfg"},
  {key: "prop3", value: "description dfbfgnghn ghn ghntyntynty "},
  {key: "prop4", value: "description dfgd dfgdfngm tjt j6hrhrthrtbcv hht"},
  {key: "prop5", value: "description            hrthrthrthreh er gergwergwegwe         "},
  {key: "prop6", value: "description wetwet we tergdf g"},
  {key: "prop7", value: "description dfg dfgdfg dfg dfg "},
  {key: "prop8", value: "description sdfehtytyj gdfgd gdfg dfgdfgfng"},
];


export const GOOD: GoodInformation = {
  id: uuidv4(),
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
