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
    public class ComputerPartsSearcher : IComputerPartsSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public ComputerPartsSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchComputerParts(ComputerPartsSelector computerPartsSelector)
        {
            return await _goodsInformationCreator.CreateComputerPartsInformation(computerPartsSelector);
        }
    }
}
