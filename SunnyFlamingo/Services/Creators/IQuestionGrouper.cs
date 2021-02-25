using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public interface IQuestionGrouper
    {
        List<QuestionBase<string>> GroupGoods();
        List<QuestionBase<string>> GroupComputerTechnologies();
        List<QuestionBase<string>> GroupComputerParts();
        List<QuestionBase<string>> GroupComputerAccessories();
        List<QuestionBase<string>> GroupComputers();
        List<QuestionBase<string>> GroupLaptops();
        List<QuestionBase<string>> GroupFlashDrives();
        List<QuestionBase<string>> GroupVideoCards();
        List<QuestionBase<string>> GroupCPUs();
        List<QuestionBase<string>> GroupCoolers();
        List<QuestionBase<string>> GroupComputerDrives();
        List<QuestionBase<string>> GroupMice();
        List<QuestionBase<string>> GroupKeyboards();
        List<QuestionBase<string>> GroupHeadphones();
    }
}
