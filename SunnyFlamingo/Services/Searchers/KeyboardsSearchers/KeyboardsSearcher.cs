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
    public class KeyboardsSearcher : IKeyboardsSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public KeyboardsSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchKeyboards(KeyboardsSelector keyboardsSelector)
        {
            return await _goodsInformationCreator.CreateKeyboardsInformation(keyboardsSelector);
        }
    }
}
