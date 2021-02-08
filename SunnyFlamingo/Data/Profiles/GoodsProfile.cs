using AutoMapper;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Data.Profiles
{
    public class GoodsProfile : Profile
    {
        public GoodsProfile()
        {
            CreateMap<Good, GoodCellModel>()
                .ForMember(p => p.ImgId,
                opt => opt.MapFrom(goods => goods.ImageInfo.FirstOrDefault().Id)
                )
                .ForMember(p => p.Type,
                opt => opt.MapFrom(goods => goods.GetType().Name));
        }
    }
}
