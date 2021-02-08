using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class VideoCardsQuestionsService : IVideoCardsQuestionsService
    {
        private readonly IComputerPartsQuestionsService _computerPartsQuestionsService;
        private readonly IQuestionsGrouper _questionsGrouper;
        public VideoCardsQuestionsService(
            IComputerPartsQuestionsService computerPartsQuestionsService,
            IQuestionsGrouper questionsGrouper)
        {
            _computerPartsQuestionsService = computerPartsQuestionsService;
            _questionsGrouper = questionsGrouper;
        }
        public async Task<List<QuestionsBase<string>>> GetVideoCardsQuestions(
            IQueryable<VideoCard> videoCards,
            VideoCardsSelector videoCardsSelector)
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var result = await GetQuestionList(videoCards, videoCardsSelector);
            return new List<QuestionsBase<string>>()
            {
                _questionsGrouper.GroupProducers(result),
                _questionsGrouper.GroupCountries(result),
                _questionsGrouper.GroupMaterials(result),
                _questionsGrouper.GroupColors(result),
                _questionsGrouper.GroupPrices(result, goodsSelector.PriceFrom, goodsSelector.PriceTo),

                _questionsGrouper.GroupDriveInterfaces(result),
                _questionsGrouper.GroupVideoSizes(result),
                _questionsGrouper.GroupVideoMemoryCapacities(result)

            };
        }
        private async Task<List<QuestionBase<string>>> GetQuestionList(
            IQueryable<VideoCard> videoCards,
            VideoCardsSelector videoCardsSelector)
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var producerQuestions = GetProducerQuestion(GetProducerVideoCards(videoCards, videoCardsSelector), goodsSelector.Producers);
            var countryQuestions = GetCountryQuestion(GetCountryVideoCards(videoCards, videoCardsSelector), goodsSelector.Countries);
            var materialQuestions = GetMaterialQuestion(GetMaterialVideoCards(videoCards, videoCardsSelector), goodsSelector.Materials);
            var colorQuestions = GetColorQuestion(GetColorVideoCards(videoCards, videoCardsSelector), goodsSelector.Colors);
            var priceQuestions = GetPriceQuestion(GetPriceVideoCards(videoCards, videoCardsSelector));


            var driveInterfaceQuestions = GetDriveInterfaceQuestion(GetDriveInterfaceVideoCards(videoCards, videoCardsSelector), videoCardsSelector.DriveInterfaces);
            var videoSizeQuestions = GetVideoSizeQuestion(GetVideoSizeVideoCards(videoCards, videoCardsSelector), videoCardsSelector.VideoSizes);
            var videoMemoryCapacityQuestions = GetVideoMemoryCapacityQuestion(GetVideoMemoryCapacityVideoCards(videoCards, videoCardsSelector), videoCardsSelector.VideoMemoryCapacities);



            var group = producerQuestions.Union(countryQuestions).Union(materialQuestions).Union(colorQuestions).Union(priceQuestions)
                .Union(driveInterfaceQuestions).Union(videoSizeQuestions).Union(videoMemoryCapacityQuestions);

            return await group.ToListAsync();
        }
        public IQueryable<T> GetProducerVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = videoCardsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetProducerComputerParts(
                videoCards, computerPartsSelector)
                .Where(l => (goodsSelector.Producers != null && goodsSelector.Producers.Contains(l.Producer.Name)) ||
                ((videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))));
        }
        public IQueryable<T> GetCountryVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = videoCardsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetCountryComputerParts(
                videoCards, computerPartsSelector)
                .Where(l => (goodsSelector.Countries != null && goodsSelector.Countries.Contains(l.Manufacturer.Country.Value)) ||
                ((videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))));
        }
        public IQueryable<T> GetMaterialVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = videoCardsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetMaterialComputerParts(
                videoCards, computerPartsSelector)
                .Where(l => (goodsSelector.Materials != null && goodsSelector.Materials.Contains(l.Material.Value)) ||
                ((videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))));
        }
        public IQueryable<T> GetColorVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = videoCardsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetColorComputerParts(
                videoCards, computerPartsSelector)
                .Where(l => (goodsSelector.Colors != null && goodsSelector.Colors.Contains(l.Color.Value)) ||
                ((videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))));
        }
        public IQueryable<T> GetPriceVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            var computerPartsSelector = videoCardsSelector.ComputerPartsSelector;
            return _computerPartsQuestionsService.GetPriceComputerParts(
                videoCards, computerPartsSelector)
                .Where(l =>
                (videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity)));
        }
        public IQueryable<T> GetDriveInterfaceVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return videoCards
                .Where(l => (videoCardsSelector.DriveInterfaces != null && videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetVideoSizeVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return videoCards
                .Where(l => (videoCardsSelector.VideoSizes != null && videoCardsSelector.VideoSizes.Contains(l.VideoSize)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoMemoryCapacities == null || videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }
        public IQueryable<T> GetVideoMemoryCapacityVideoCards<T>(
            IQueryable<T> videoCards,
            VideoCardsSelector videoCardsSelector) where T : VideoCard
        {
            var goodsSelector = videoCardsSelector.ComputerPartsSelector.ComputerTechnologiesSelector.GoodsSelector;
            return videoCards
                .Where(l => (videoCardsSelector.VideoMemoryCapacities != null && videoCardsSelector.VideoMemoryCapacities.Contains(l.VideoMemoryCapacity)) ||
                ((goodsSelector.PriceFrom == null || l.Price >= goodsSelector.PriceFrom)
                && (goodsSelector.PriceTo == null || l.Price <= goodsSelector.PriceTo)
                && (videoCardsSelector.DriveInterfaces == null || videoCardsSelector.DriveInterfaces.Contains(l.DriveInterfaceValue))
                && (videoCardsSelector.VideoSizes == null || videoCardsSelector.VideoSizes.Contains(l.VideoSize))
                && (goodsSelector.Producers == null || goodsSelector.Producers.Contains(l.Producer.Name))
                && (goodsSelector.Countries == null || goodsSelector.Countries.Contains(l.Manufacturer.Country.Value))
                && (goodsSelector.Materials == null || goodsSelector.Materials.Contains(l.MaterialValue))
                && (goodsSelector.Colors == null || goodsSelector.Colors.Contains(l.ColorValue))));
        }

        public IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<VideoCard> videoCards, string[] producers)
        {
            return _computerPartsQuestionsService.GetProducerQuestion(videoCards, producers);
        }
        public IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<VideoCard> videoCards, string[] countries)
        {
            return _computerPartsQuestionsService.GetCountryQuestion(videoCards, countries);
        }
        public IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<VideoCard> videoCards, string[] materials)
        {
            return _computerPartsQuestionsService.GetMaterialQuestion(videoCards, materials);
        }
        public IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<VideoCard> videoCards, string[] colors)
        {
            return _computerPartsQuestionsService.GetColorQuestion(videoCards, colors);
        }
        public IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<VideoCard> videoCards)
        {
            return _computerPartsQuestionsService.GetPriceQuestion(videoCards);
        }
        public IQueryable<QuestionBase<string>> GetDriveInterfaceQuestion(IQueryable<VideoCard> videoCards, string[] driveInterfaces)
        {
            return videoCards
                        .Select(g => g.DriveInterfaceValue)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(type => new QuestionBase<string>()
                        {
                            QuestionsKey = "driveInterface",
                            AfterBox = (driveInterfaces != null && driveInterfaces.Contains(type.Value)) ? (int?)null : type.Count,
                            Checked = driveInterfaces != null && driveInterfaces.Contains(type.Value),
                            ControlType = ControlType.Checkbox,
                            Key = type.Value,
                            Label = type.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetVideoSizeQuestion(IQueryable<VideoCard> videoCards, int[] videoSize)
        {
            var stringList = videoSize?.Select(item => item.ToString()).ToList();
            return videoCards
                        .Select(g => g.VideoSize)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "videoSize",
                            AfterBox = (stringList != null && stringList.Contains(fanSize.Value)) ? (int?)null : fanSize.Count,
                            Checked = stringList != null && stringList.Contains(fanSize.Value),
                            ControlType = ControlType.Checkbox,
                            Key = fanSize.Value,
                            Label = fanSize.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
        public IQueryable<QuestionBase<string>> GetVideoMemoryCapacityQuestion(IQueryable<VideoCard> videoCards, int[] videoMemoryCapacities)
        {
            var stringList = videoMemoryCapacities?.Select(item => item.ToString()).ToList();
            return videoCards
                        .Select(g => g.VideoMemoryCapacity)
                        .GroupBy(p => p)
                        .Select(p => new { Count = p.Count(), Value = Convert.ToString(p.Key) })
                        .Select(fanSize => new QuestionBase<string>()
                        {
                            QuestionsKey = "videoMemoryCapacity",
                            AfterBox = (stringList != null && stringList.Contains(fanSize.Value)) ? (int?)null : fanSize.Count,
                            Checked = stringList != null && stringList.Contains(fanSize.Value),
                            ControlType = ControlType.Checkbox,
                            Key = fanSize.Value,
                            Label = fanSize.Value,
                            Required = false,
                            Type = InputType.Checkbox,
                        });
        }
    }
}
