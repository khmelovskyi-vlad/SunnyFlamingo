using Microsoft.Data.SqlClient;
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
    public class GoodsInformationSearcher : IGoodsInformationSearcher
    {
        private readonly ApplicationDbContext _context;
        private readonly IParametersCreator _parametersCreator;
        private readonly IQuestionsGrouper _questionsGrouper;
        public GoodsInformationSearcher(ApplicationDbContext context,
            IParametersCreator parametersCreator,
            IQuestionsGrouper questionsGrouper)
        {
            _context = context;
            _parametersCreator = parametersCreator;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<GoodsInformation<string>> SearchGoodsNameInformation(GoodsSelectorName goodsSelectorName)
        {
            var parameters = _parametersCreator.GetGoodsParametersByName(goodsSelectorName).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetGoodsByName", parameters);
            var questions = _questionsGrouper.GroupGoods(goodsSelectorName, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(parameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchGoodsInformation(GoodsSelector goodsSelector)
        {
            var parameters = _parametersCreator.GetGoodsParameters(goodsSelector).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetGoods", parameters);
            var questions = _questionsGrouper.GroupGoods(goodsSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(parameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchComputerTechnologiesInformation(ComputerTechnologiesSelector computerTechnologiesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerTechnologiesParameters(computerTechnologiesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerTechnology>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerTechnologies", normalParameters);
            var questions = _questionsGrouper.GroupComputerTechnologies(computerTechnologiesSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchLaptopsInformation(LaptopsSelector laptopsSelector)
        {
            var parameters = _parametersCreator.GetLaptopsParameters(laptopsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Laptop>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetLaptops", parameters);
            var questions = _questionsGrouper.GroupLaptops(laptopsSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(parameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchComputersInformation(ComputersSelector computersSelector)
        {
            var normalParameters = _parametersCreator.GetComputersParameters(computersSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Computer>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputers", normalParameters);
            var questions = _questionsGrouper.GroupComputers(computersSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchComputerAccessoriesInformation(ComputerAccessoriesSelector computerAccessoriesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerAccessoriesParameters(computerAccessoriesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerAccessory>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerAccessories", normalParameters);
            var questions = _questionsGrouper.GroupComputerAccessories(computerAccessoriesSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchComputerPartsInformation(ComputerPartsSelector computerPartsSelector)
        {
            var normalParameters = _parametersCreator.GetComputerPartsParameters(computerPartsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerPart>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerParts", normalParameters);
            var questions = _questionsGrouper.GroupComputerParts(computerPartsSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchFlashDrivesInformation(FlashDrivesSelector flashDrivesSelector)
        {
            var normalParameters = _parametersCreator.GetFlashDrivesParameters(flashDrivesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<FlashDrive>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetFlashDrives", normalParameters);
            var questions = _questionsGrouper.GroupFlashDrives(flashDrivesSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchVideoCardsInformation(VideoCardsSelector videoCardsSelector)
        {
            var normalParameters = _parametersCreator.GetVideoCardsParameters(videoCardsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<VideoCard>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetVideoCards", normalParameters);
            var questions = _questionsGrouper.GroupVideoCards(videoCardsSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchCPUsInformation(CPUsSelector cpusSelector)
        {
            var normalParameters = _parametersCreator.GetCPUsParameters(cpusSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<CPU>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetCPUs", normalParameters);
            var questions = _questionsGrouper.GroupCPUs(cpusSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchCoolersInformation(CoolersSelector coolersSelector)
        {
            var normalParameters = _parametersCreator.GetCoolersParameters(coolersSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Cooler>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetCoolers", normalParameters);
            var questions = _questionsGrouper.GroupCoolers(coolersSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchComputerDrivesInformation(ComputerDrivesSelector computerDrivesSelector)
        {
            var normalParameters = _parametersCreator.GetComputerDrivesParameters(computerDrivesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<ComputerDrive>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetComputerDrives", normalParameters);
            var questions = _questionsGrouper.GroupComputerDrives(computerDrivesSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchMiceInformation(MiceSelector miceSelector)
        {
            var normalParameters = _parametersCreator.GetMiceParameters(miceSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Mause>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetMice", normalParameters);
            var questions = _questionsGrouper.GroupMice(miceSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchKeyboardsInformation(KeyboardsSelector keyboardsSelector)
        {
            var normalParameters = _parametersCreator.GetKeyboardsParameters(keyboardsSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Keyboard>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetKeyboards", normalParameters);
            var questions = _questionsGrouper.GroupKeyboards(keyboardsSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
        public async Task<GoodsInformation<string>> SearchHeadphonesInformation(HeadphonesSelector headphonesSelector)
        {
            var normalParameters = _parametersCreator.GetHeadphonesParameters(headphonesSelector)
                .Append(_parametersCreator.CreateDiscriminatorParameter<Headphones>()).ToArray();
            var goodsDbInformation = await _context.GetGoodsDbInformation("GetHeadphones", normalParameters);
            var questions = _questionsGrouper.GroupHeadphones(headphonesSelector, goodsDbInformation.DBQuestions);
            return new GoodsInformation<string>(_parametersCreator.GetCount(normalParameters), goodsDbInformation.GoodCells, questions);
        }
    }
}
