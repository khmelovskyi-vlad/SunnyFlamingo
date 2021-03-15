using SunnyFlamingo.Data;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class GoodCellsSearcher : IGoodCellsSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IParametersCreator _parametersCreator;
        public GoodCellsSearcher(ApplicationDbContext context,
            IParametersCreator parametersCreator)
        {
            _context = context;
            _parametersCreator = parametersCreator;
        }
        public async Task<List<GoodCellModel>> SearchGoodsNameGoodCells(GoodsSelectorName goodsSelectorName)
        {
            var parameters = _parametersCreator.GetGoodsParametersByName(goodsSelectorName).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetGoodsByName", parameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchGoodCells(GoodsSelector goodsSelector)
        {
            var parameters = _parametersCreator.GetGoodsParameters(goodsSelector).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetGoods", parameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchComputerTechnologiesGoodCells(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerTechnologiesParameters(computerTechnologiesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerTechnology>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerTechnologies", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchLaptopGoodCells(LaptopsSelector laptopsSelector)
        {
            var parameters = _parametersCreator.GetLaptopsParameters(laptopsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Laptop>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetLaptops", parameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchComputersGoodCells(ComputersSelector computersSelector)
        {
            var normalParameters = _parametersCreator.GetComputersParameters(computersSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Computer>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputers", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchComputerAccessoriesGoodCells(ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerAccessoriesParameters(computerAccessoriesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerAccessory>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerAccessories", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchComputerPartsGoodCells(ComputerPartsSelector computerPartsSelector)
        {
            var normalParameters = _parametersCreator.GetComputerPartsParameters(computerPartsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerPart>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerParts", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchFlashDrivesGoodCells(FlashDrivesSelector flashDrivesSelector)
        {
            var normalParameters = _parametersCreator.GetFlashDrivesParameters(flashDrivesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<FlashDrive>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetFlashDrives", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchVideoCardsGoodCells(VideoCardsSelector videoCardsSelector)
        {
            var normalParameters = _parametersCreator.GetVideoCardsParameters(videoCardsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<VideoCard>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetVideoCards", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchCPUsGoodCells(CPUsSelector cpusSelector)
        {
            var normalParameters = _parametersCreator.GetCPUsParameters(cpusSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<CPU>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetCPUs", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchCoolersGoodCells(CoolersSelector coolersSelector)
        {
            var normalParameters = _parametersCreator.GetCoolersParameters(coolersSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Cooler>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetCoolers", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchComputerDrivesGoodCells(ComputerDrivesSelector computerDrivesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerDrivesParameters(computerDrivesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerDrive>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerDrives", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchMiceGoodCells(MiceSelector miceSelector)
        {
            var normalParameters = _parametersCreator.GetMiceParameters(miceSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Mause>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetMice", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchKeyboardsGoodCells(KeyboardsSelector keyboardsSelector)
        {
            var normalParameters = _parametersCreator.GetKeyboardsParameters(keyboardsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Keyboard>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetKeyboards", normalParameters);
            return goodsDbInformation.GoodCells;
        }
        public async Task<List<GoodCellModel>> SearchHeadphonesGoodCells(HeadphonesSelector headphonesSelector)
        {
            var normalParameters = _parametersCreator.GetHeadphonesParameters(headphonesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Headphones>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetHeadphones", normalParameters);
            return goodsDbInformation.GoodCells;
        }
    }
}
