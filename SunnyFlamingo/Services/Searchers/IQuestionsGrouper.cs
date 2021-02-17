using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IQuestionsGrouper
    {
        List<QuestionsBase<string>> GroupGoods(GoodsSelector goodsSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupComputerTechnologies(ComputerTechnologiesSelector computerTechnologiesSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupLaptops(LaptopsSelector laptopsSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupComputers(ComputersSelector computersSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupComputerAccessories(ComputerAccessoriesSelector computerAccessoriesSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupComputerParts(ComputerPartsSelector computerPartsSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupFlashDrives(FlashDrivesSelector flashDrivesSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupVideoCards(VideoCardsSelector videoCardsSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupCPUs(CPUsSelector cpusSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupCoolers(CoolersSelector coolersSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupComputerDrives(ComputerDrivesSelector computerDrivesSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupMice(MiceSelector miceSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupKeyboards(KeyboardsSelector keyboardsSelector, List<DBQuestionBase> dBQuestions);
        List<QuestionsBase<string>> GroupHeadphones(HeadphonesSelector headphonesSelector, List<DBQuestionBase> dBQuestions);
    }
}
