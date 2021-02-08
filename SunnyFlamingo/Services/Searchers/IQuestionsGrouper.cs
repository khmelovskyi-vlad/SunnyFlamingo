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

        QuestionsBase<string> GroupAmountOfRAMs(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupCPUFrequencies(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupHeight(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupWidth(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupLength(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupHaveFloppyDrives(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupSSDMemory(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupHardDiskMemory(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupCPUSocketTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupComputerDriveTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupNumberOfCores(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupFloppyDrivesCount(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupDisplays(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupCapacities(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupUSBSpecificationTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupFormFactorTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupCoolerTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupFanSizes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupThermalDesignPowers(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupNumberOfThreads(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupDriveInterfaces(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupVideoSizes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupVideoMemoryCapacities(List<QuestionBase<string>> questions);


        QuestionsBase<string> GroupHeadphonesTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupWirelessTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupConnectorTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupKeyboardTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupMauseTypes(List<QuestionBase<string>> questions);
        QuestionsBase<string> GroupButtonsCount(List<QuestionBase<string>> questions);
    }
}
