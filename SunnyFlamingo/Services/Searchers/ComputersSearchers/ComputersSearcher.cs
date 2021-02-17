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
    public class ComputersSearcher : IComputersSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public ComputersSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchComputers(ComputersSelector computersSelector)
        {
            return await _goodsInformationCreator.CreateComputersInformation(computersSelector);
        }
    }
}
