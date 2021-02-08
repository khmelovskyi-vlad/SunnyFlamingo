using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IVideoCardsQuestionsService
    {
        Task<List<QuestionsBase<string>>> GetVideoCardsQuestions(
               IQueryable<VideoCard> videoCards,
               VideoCardsSelector videoCardsSelector);

        IQueryable<T> GetProducerVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;

        IQueryable<T> GetCountryVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetMaterialVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetColorVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetPriceVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetDriveInterfaceVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetVideoSizeVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<T> GetVideoMemoryCapacityVideoCards<T>(
            IQueryable<T> videoCards,
               VideoCardsSelector videoCardsSelector) where T : VideoCard;
        IQueryable<QuestionBase<string>> GetProducerQuestion(IQueryable<VideoCard> videoCards, string[] producers);
        IQueryable<QuestionBase<string>> GetCountryQuestion(IQueryable<VideoCard> videoCards, string[] countries);
        IQueryable<QuestionBase<string>> GetMaterialQuestion(IQueryable<VideoCard> videoCards, string[] materials);
        IQueryable<QuestionBase<string>> GetColorQuestion(IQueryable<VideoCard> videoCards, string[] colors);
        IQueryable<QuestionBase<string>> GetPriceQuestion(IQueryable<VideoCard> videoCards);
        IQueryable<QuestionBase<string>> GetDriveInterfaceQuestion(IQueryable<VideoCard> videoCards, string[] driveInterfaces);
        IQueryable<QuestionBase<string>> GetVideoSizeQuestion(IQueryable<VideoCard> videoCards, int[] videoSize);
        IQueryable<QuestionBase<string>> GetVideoMemoryCapacityQuestion(IQueryable<VideoCard> videoCards, int[] videoMemoryCapacities);
    }
}
