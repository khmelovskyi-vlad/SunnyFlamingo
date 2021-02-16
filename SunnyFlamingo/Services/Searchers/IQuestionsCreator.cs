using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IQuestionsCreator
    {
        QuestionsBase<string> GroupProducers(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupCountries(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupMaterials(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupColors(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupPrices(List<DBQuestionBase> dBQuestions);
    }
}
