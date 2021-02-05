using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IQuestionsGrouper
    {
        QuestionsBase<string> GroupProducers(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupCountries(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupMaterials(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupColors(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupPrices(List<QuestionBase<string>> questions, decimal? priceFrom, decimal? priceTo);
    }
}
