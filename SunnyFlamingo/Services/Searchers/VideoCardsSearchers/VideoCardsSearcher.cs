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
    public class VideoCardsSearcher : IVideoCardsSearcher
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        public VideoCardsSearcher(IGoodsInformationCreator goodsInformationCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
        }
        public async Task<GoodsInformation<string>> SearchVideoCards(VideoCardsSelector videoCardsSelector)
        {
            return await _goodsInformationCreator.CreateVideoCardsInformation(videoCardsSelector);
        }
    }
}
