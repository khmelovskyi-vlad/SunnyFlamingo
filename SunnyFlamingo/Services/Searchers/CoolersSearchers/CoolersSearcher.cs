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
    public class CoolersSearcher : ICoolersSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public CoolersSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchCoolers(CoolersSelector coolersSelector)
        {
            return await _goodsInformationCreator.CreateCoolersInformation(coolersSelector);
        }
    }
}
