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
using Newtonsoft.Json;
using OfficeOpenXml;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.Services;
using SunnyFlamingo.Services.Cache;
using SunnyFlamingo.Services.Searchers;
using SunnyFlamingo.ValueObjects;
using SunnyFlamingo.ValueObjects.GoodsInformationSearcherFactories;

namespace SunnyFlamingo.Controllers
{
    [Route("api/goods")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly IGoodsInformationCreator _goodsInformationCreator;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IGoodsInformationSearcher _goodsInformationSearcher;
        private readonly IGoodCellsSearcher _goodCellsSearcher;
        private readonly ICacheKeyCreator _keyCreator;
        public GoodsController(IGoodsInformationCreator goodsInformationCreator, 
            ApplicationDbContext context, 
            IMapper mapper, 
            IGoodsInformationSearcher goodsInformationSearcher,
            IGoodCellsSearcher goodCellsSearcher,
            ICacheKeyCreator keyCreator)
        {
            _goodsInformationCreator = goodsInformationCreator;
            _context = context;
            _mapper = mapper;
            _goodsInformationSearcher = goodsInformationSearcher;
            _goodCellsSearcher = goodCellsSearcher;
            _keyCreator = keyCreator;
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
            return await _goodsInformationCreator.CreateGoodsInformation(goodsSelector, new GoodsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, goodsSelector));
        }
        [HttpPost]
        [Route("goodsName")]
        public async Task<GoodsInformation<string>> GetGoodsInformation([FromBody] GoodsSelectorName goodsSelectorName)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(goodsSelectorName, new GoodsNameInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, goodsSelectorName));
        }
        [HttpPost]
        [Route("computerTechnologies")]
        public async Task<GoodsInformation<string>> GetComputerTechnologiesInformation([FromBody] ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(computerTechnologiesSelector, new ComputerTechnologiesInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, computerTechnologiesSelector));
        }
        [HttpPost]
        [Route("laptops")]
        public async Task<GoodsInformation<string>> GetLaptopsInformation([FromBody] LaptopsSelector laptopsSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(laptopsSelector, new LaptopsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, laptopsSelector));
        }
        [HttpPost]
        [Route("computers")]
        public async Task<GoodsInformation<string>> GetComputersInformation([FromBody] ComputersSelector computersSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(computersSelector, new ComputersInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, computersSelector));
        }
        [HttpPost]
        [Route("flashDrives")]
        public async Task<GoodsInformation<string>> GetFlashDrivesInformation([FromBody] FlashDrivesSelector flashDrivesSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(flashDrivesSelector, new FlashDrivesInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, flashDrivesSelector));
        }
        [HttpPost]
        [Route("computerParts")]
        public async Task<GoodsInformation<string>> GetComputerPartsInformation([FromBody] ComputerPartsSelector computerPartsSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(computerPartsSelector, new ComputerPartsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, computerPartsSelector));
        }
        [HttpPost]
        [Route("computerAccessories")]
        public async Task<GoodsInformation<string>> GetComputerAccessoriesInformation([FromBody] ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(computerAccessoriesSelector, new ComputerAccessoriesInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, computerAccessoriesSelector));
        }
        [HttpPost]
        [Route("computerDrives")]
        public async Task<GoodsInformation<string>> GetComputerDrivesInformation([FromBody] ComputerDrivesSelector computerDrivesSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(computerDrivesSelector, new ComputerDrivesInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, computerDrivesSelector));
        }
        [HttpPost]
        [Route("coolers")]
        public async Task<GoodsInformation<string>> GetCoolersInformation([FromBody] CoolersSelector coolersSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(coolersSelector, new CoolersInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, coolersSelector));
        }
        [HttpPost]
        [Route("CPUs")]
        public async Task<GoodsInformation<string>> GetCPUsInformation([FromBody] CPUsSelector cpusSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(cpusSelector, new CPUsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, cpusSelector));
        }
        [HttpPost]
        [Route("videoCards")]
        public async Task<GoodsInformation<string>> GetVideoCardsInformation([FromBody] VideoCardsSelector videoCardsSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(videoCardsSelector, new VideoCardsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, videoCardsSelector));
        }
        [HttpPost]
        [Route("mice")]
        public async Task<GoodsInformation<string>> GetMiceInformation([FromBody] MiceSelector miceSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(miceSelector, new MiceInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, miceSelector));
        }
        [HttpPost]
        [Route("keyboards")]
        public async Task<GoodsInformation<string>> GetKeyboardsInformation([FromBody] KeyboardsSelector keyboardsSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(keyboardsSelector, new KeyboardsInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, keyboardsSelector));
        }
        [HttpPost]
        [Route("headphones")]
        public async Task<GoodsInformation<string>> GetHeadphonesInformation([FromBody] HeadphonesSelector headphonesSelector)
        {
            return await _goodsInformationCreator.CreateGoodsInformation(headphonesSelector, new HeadphonesInformationSearcherFactory(_goodsInformationSearcher, _goodCellsSearcher, _keyCreator, headphonesSelector));
        }
    }
}
