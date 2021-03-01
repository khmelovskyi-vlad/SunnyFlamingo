using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Services;
using SunnyFlamingo.Services.Searchers;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public GoodsController(IGoodsInformationCreator goodsInformationCreator, ApplicationDbContext context, IMapper mapper)
        {
            _goodsInformationCreator = goodsInformationCreator;
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        [Route("GoodName")]
        public async Task<List<GoodCellModel>> GetGoodsByName(string part)
        {
            return await _context.Goods.Where(good => part == null || good.Name.Contains(part))
                .Take(10)
                .ProjectTo<GoodCellModel>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
        [HttpPost]
        [Route("")]
        public async Task<GoodsInformation<string>> GetGoodsInformation([FromBody] GoodsSelector goodsSelector)
        {
            if (goodsSelector.Name == null)
            {
                return await _goodsInformationCreator.CreateGoodsInformation(goodsSelector);
            }
            else
            {
                return await _goodsInformationCreator.CreateGoodsInformationByName(goodsSelector);
            }
        }
        [HttpPost]
        [Route("computerTechnologies")]
        public async Task<GoodsInformation<string>> GetComputerTechnologiesInformation([FromBody] ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            return await _goodsInformationCreator.CreateComputerTechnologiesInformation(computerTechnologiesSelector);
        }
        [HttpPost]
        [Route("laptops")]
        public async Task<GoodsInformation<string>> GetLaptopsInformation([FromBody] LaptopsSelector laptopsSelector)
        {
            return await _goodsInformationCreator.CreateLaptopsInformation(laptopsSelector);
        }
        [HttpPost]
        [Route("computers")]
        public async Task<GoodsInformation<string>> GetComputersInformation([FromBody] ComputersSelector computersSelector)
        {
            return await _goodsInformationCreator.CreateComputersInformation(computersSelector);
        }
        [HttpPost]
        [Route("flashDrives")]
        public async Task<GoodsInformation<string>> GetFlashDrivesInformation([FromBody] FlashDrivesSelector flashDrivesSelector)
        {
            return await _goodsInformationCreator.CreateFlashDrivesInformation(flashDrivesSelector);
        }
        [HttpPost]
        [Route("computerParts")]
        public async Task<GoodsInformation<string>> GetComputerPartsInformation([FromBody] ComputerPartsSelector computerPartsSelector)
        {
            return await _goodsInformationCreator.CreateComputerPartsInformation(computerPartsSelector);
        }
        [HttpPost]
        [Route("computerAccessories")]
        public async Task<GoodsInformation<string>> GetComputerAccessoriesInformation([FromBody] ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            return await _goodsInformationCreator.CreateComputerAccessoriesInformation(computerAccessoriesSelector);
        }
        [HttpPost]
        [Route("computerDrives")]
        public async Task<GoodsInformation<string>> GetComputerDrivesInformation([FromBody] ComputerDrivesSelector computerDrivesSelector)
        {
            return await _goodsInformationCreator.CreateComputerDrivesInformation(computerDrivesSelector);
        }
        [HttpPost]
        [Route("coolers")]
        public async Task<GoodsInformation<string>> GetCoolersInformation([FromBody] CoolersSelector coolersSelector)
        {
            return await _goodsInformationCreator.CreateCoolersInformation(coolersSelector);
        }
        [HttpPost]
        [Route("CPUs")]
        public async Task<GoodsInformation<string>> GetCPUsInformation([FromBody] CPUsSelector cpusSelector)
        {
            return await _goodsInformationCreator.CreateCPUsInformation(cpusSelector);
        }
        [HttpPost]
        [Route("videoCards")]
        public async Task<GoodsInformation<string>> GetVideoCardsInformation([FromBody] VideoCardsSelector videoCardsSelector)
        {
            return await _goodsInformationCreator.CreateVideoCardsInformation(videoCardsSelector);
        }
        [HttpPost]
        [Route("mice")]
        public async Task<GoodsInformation<string>> GetMiceInformation([FromBody] MiceSelector miceSelector)
        {
            return await _goodsInformationCreator.CreateMiceInformation(miceSelector);
        }
        [HttpPost]
        [Route("keyboards")]
        public async Task<GoodsInformation<string>> GetKeyboardsInformation([FromBody] KeyboardsSelector keyboardsSelector)
        {
            return await _goodsInformationCreator.CreateKeyboardsInformation(keyboardsSelector);
        }
        [HttpPost]
        [Route("headphones")]
        public async Task<GoodsInformation<string>> GetHeadphonesInformation([FromBody] HeadphonesSelector headphonesSelector)
        {
            return await _goodsInformationCreator.CreateHeadphonesInformation(headphonesSelector);
        }
    }
}
