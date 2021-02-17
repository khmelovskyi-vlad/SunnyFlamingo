using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class ComputerAccessoriesSearcher : IComputerAccessoriesSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public ComputerAccessoriesSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchComputerAccessories(ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            return await _goodsInformationCreator.CreateComputerAccessoriesInformation(computerAccessoriesSelector);
        }
    }
}
