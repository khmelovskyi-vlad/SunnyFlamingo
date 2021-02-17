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
    public class ComputerTechnologiesSearchers : IComputerTechnologiesSearchers
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public ComputerTechnologiesSearchers(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchComputerTechnologies(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            return await _goodsInformationCreator.CreateComputerTechnologiesInformation(computerTechnologiesSelector);
        }
    }
}
