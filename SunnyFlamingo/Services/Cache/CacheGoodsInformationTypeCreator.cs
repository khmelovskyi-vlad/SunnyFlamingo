using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Cache
{
    public class CacheGoodsInformationTypeCreator : ICacheGoodsInformationTypeCreator
    {
        private enum SpecificPropertyType
        {
            HaveNot,
            IsEqual,
            IsNoEqual
        }

        public CacheGoodsInformationType GetCacheGoodsInformationType(GoodsSelector goodsSelector)
        {
            var type = goodsSelector.GetType();
            var properties = type.GetProperties();
            bool haveGoodsQuestions = false;
            foreach (var prop in properties)
            {
                var defaultValue = prop.PropertyType.IsValueType ? Activator.CreateInstance(prop.PropertyType) : null;
                var value = prop.GetValue(goodsSelector);
                if (haveGoodsQuestions)
                {
                    var cacheGoodsInformationType = CheckNormalProperty(value, defaultValue, prop.Name);
                    if (cacheGoodsInformationType == CacheGoodsInformationType.No)
                    {
                        return CacheGoodsInformationType.No;
                    }
                }
                else
                {
                    var cacheGoodsInformationType = CheckProperty(value, defaultValue, prop.Name);
                    switch (cacheGoodsInformationType)
                    {
                        case CacheGoodsInformationType.GoodsQuestions:
                            haveGoodsQuestions = true;
                            break;
                        case CacheGoodsInformationType.No:
                            return CacheGoodsInformationType.No;
                    }
                }
            }
            if (haveGoodsQuestions)
            {
                return CacheGoodsInformationType.GoodsQuestions;
            }
            return CacheGoodsInformationType.GoodsInformation;
        }
        private CacheGoodsInformationType CheckProperty(object value, object defaultValue, string name)
        {
            var specificPropertyType = CheckSpecificProperty(value, name);
            if (specificPropertyType == SpecificPropertyType.HaveNot)
            {
                return CheckNormalProperty(value, defaultValue, name);
            }
            else if (specificPropertyType == SpecificPropertyType.IsEqual)
            {
                return CacheGoodsInformationType.GoodsInformation;
            }
            else
            {
                return CacheGoodsInformationType.GoodsQuestions;
            }
        }
        private CacheGoodsInformationType CheckNormalProperty(object value, object defaultValue, string name)
        {
            return defaultValue == value ? CacheGoodsInformationType.GoodsInformation : CacheGoodsInformationType.No;
        }
        private SpecificPropertyType CheckSpecificProperty(object value, string name)
        {
            switch (name)
            {
                case "Page":
                    return value.Equals(1) ? SpecificPropertyType.IsEqual : SpecificPropertyType.IsNoEqual;
                case "ShowGoods":
                    return value.Equals(36) ? SpecificPropertyType.IsEqual : SpecificPropertyType.IsNoEqual;
                case "GetQuestions":
                    return value.Equals(true) ? SpecificPropertyType.IsEqual : SpecificPropertyType.IsNoEqual;
                case "OrderType":
                    return value.Equals(OrderType.name) ? SpecificPropertyType.IsEqual : SpecificPropertyType.IsNoEqual;
                case "SortDir":
                    return value.Equals(SortDir.asc) ? SpecificPropertyType.IsEqual : SpecificPropertyType.IsNoEqual;
                default:
                    return SpecificPropertyType.HaveNot;
            }
        }
    }
}
