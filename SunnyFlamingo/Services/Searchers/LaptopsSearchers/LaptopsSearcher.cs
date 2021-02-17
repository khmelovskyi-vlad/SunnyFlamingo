using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class LaptopsSearcher : ILaptopsSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public LaptopsSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchLaptops(LaptopsSelector laptopsSelector)
        {
            return await _goodsInformationCreator.CreateLaptopsInformation(laptopsSelector);
        }
    }
}
