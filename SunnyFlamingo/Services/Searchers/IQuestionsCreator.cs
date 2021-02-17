using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
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
        QuestionsBase<string> GroupPrices(List<DBQuestionBase> dBQuestions, decimal? priceFrom, decimal? priceTo);
        QuestionsBase<string> GroupAmountOfRAMs(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupCPUFrequencies(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupHeight(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupWidth(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupLength(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupHaveFloppyDrives(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupSSDMemory(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupHardDiskMemory(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupCPUSocketTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupComputerDriveTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupNumberOfCores(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupFloppyDrivesCount(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupDisplays(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupCapacity(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupUSBSpecificationTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupFormFactorTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupCoolerTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupFanSizes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupThermalDesignPowers(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupNumberOfThreads(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupDriveInterfaces(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupVideoSizes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupVideoMemoryCapacities(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupHeadphonesTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupWirelessTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupConnectorTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupKeyboardTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupMauseTypes(List<DBQuestionBase> dBQuestions);
        QuestionsBase<string> GroupButtonsCount(List<DBQuestionBase> dBQuestions);
    }
}
