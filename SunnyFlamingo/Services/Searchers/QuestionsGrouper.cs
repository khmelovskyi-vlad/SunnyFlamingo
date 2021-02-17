using SunnyFlamingo.Models;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public class QuestionsGrouper : IQuestionsGrouper
    {
        private readonly IQuestionsCreator _questionsCreator;
        public QuestionsGrouper(IQuestionsCreator questionsCreator)
        {
            _questionsCreator = questionsCreator;
        }
        public List<QuestionsBase<string>> GroupGoods(GoodsSelector goodsSelector, List<DBQuestionBase> dBQuestions)
        {
            return new List<QuestionsBase<string>>() {
                    _questionsCreator.GroupProducers(dBQuestions),
                    _questionsCreator.GroupCountries(dBQuestions),
                    _questionsCreator.GroupMaterials(dBQuestions),
                    _questionsCreator.GroupColors(dBQuestions),
                    _questionsCreator.GroupPrices(dBQuestions, goodsSelector.PriceFrom, goodsSelector.PriceTo)
            };
        }
        public List<QuestionsBase<string>> GroupComputerTechnologies(ComputerTechnologiesSelector computerTechnologiesSelector, List<DBQuestionBase> dBQuestions)
        {
            return GroupGoods(computerTechnologiesSelector.GoodsSelector, dBQuestions);
        }
        public List<QuestionsBase<string>> GroupLaptops(LaptopsSelector laptopsSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupAmountOfRAMs(dBQuestions),
                _questionsCreator.GroupCPUFrequencies(dBQuestions),
                _questionsCreator.GroupHeight(dBQuestions),
                _questionsCreator.GroupWidth(dBQuestions),
                _questionsCreator.GroupLength(dBQuestions),
                _questionsCreator.GroupHaveFloppyDrives(dBQuestions),
                _questionsCreator.GroupSSDMemory(dBQuestions),
                _questionsCreator.GroupHardDiskMemory(dBQuestions),
                _questionsCreator.GroupCPUSocketTypes(dBQuestions),
                _questionsCreator.GroupComputerDriveTypes(dBQuestions),
                _questionsCreator.GroupNumberOfCores(dBQuestions),
                _questionsCreator.GroupDisplays(dBQuestions)
            };
            if (laptopsSelector.HaveFloppyDrives == null || laptopsSelector.HaveFloppyDrives.Contains(true))
            {
                questions.Add(_questionsCreator.GroupFloppyDrivesCount(dBQuestions));
            }
            questions.AddRange(GroupComputerTechnologies(laptopsSelector.ComputerTechnologiesSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupComputers(ComputersSelector computersSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupAmountOfRAMs(dBQuestions),
                _questionsCreator.GroupCPUFrequencies(dBQuestions),
                _questionsCreator.GroupHeight(dBQuestions),
                _questionsCreator.GroupWidth(dBQuestions),
                _questionsCreator.GroupLength(dBQuestions),
                _questionsCreator.GroupHaveFloppyDrives(dBQuestions),
                _questionsCreator.GroupSSDMemory(dBQuestions),
                _questionsCreator.GroupHardDiskMemory(dBQuestions),
                _questionsCreator.GroupCPUSocketTypes(dBQuestions),
                _questionsCreator.GroupComputerDriveTypes(dBQuestions),
                _questionsCreator.GroupNumberOfCores(dBQuestions)
            };
            if (computersSelector.HaveFloppyDrives == null || computersSelector.HaveFloppyDrives.Contains(true))
            {
                questions.Add(_questionsCreator.GroupFloppyDrivesCount(dBQuestions));
            }
            questions.AddRange(GroupComputerTechnologies(computersSelector.ComputerTechnologiesSelector, dBQuestions));
            return questions;
        }

        public List<QuestionsBase<string>> GroupComputerAccessories(ComputerAccessoriesSelector computerAccessoriesSelector, List<DBQuestionBase> dBQuestions)
        {
            return GroupComputerTechnologies(computerAccessoriesSelector.ComputerTechnologiesSelector, dBQuestions);
        }
        public List<QuestionsBase<string>> GroupComputerParts(ComputerPartsSelector computerPartsSelector, List<DBQuestionBase> dBQuestions)
        {
            return GroupComputerTechnologies(computerPartsSelector.ComputerTechnologiesSelector, dBQuestions);
        }
        public List<QuestionsBase<string>> GroupFlashDrives(FlashDrivesSelector flashDrivesSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupCapacity(dBQuestions),
                _questionsCreator.GroupUSBSpecificationTypes(dBQuestions),
            };
            questions.AddRange(GroupComputerTechnologies(flashDrivesSelector.ComputerTechnologiesSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupVideoCards(VideoCardsSelector videoCardsSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupDriveInterfaces(dBQuestions),
                _questionsCreator.GroupVideoSizes(dBQuestions),
                _questionsCreator.GroupVideoMemoryCapacities(dBQuestions),
            };
            questions.AddRange(GroupComputerParts(videoCardsSelector.ComputerPartsSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupCPUs(CPUsSelector cpusSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupCPUSocketTypes(dBQuestions),
                _questionsCreator.GroupThermalDesignPowers(dBQuestions),
                _questionsCreator.GroupNumberOfCores(dBQuestions),
                _questionsCreator.GroupNumberOfThreads(dBQuestions),
            };
            questions.AddRange(GroupComputerParts(cpusSelector.ComputerPartsSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupCoolers(CoolersSelector coolersSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupCoolerTypes(dBQuestions),
                _questionsCreator.GroupFanSizes(dBQuestions),
            };
            questions.AddRange(GroupComputerParts(coolersSelector.ComputerPartsSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupComputerDrives(ComputerDrivesSelector computerDrivesSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupCapacity(dBQuestions),
                _questionsCreator.GroupComputerDriveTypes(dBQuestions),
                _questionsCreator.GroupFormFactorTypes(dBQuestions),
            };
            questions.AddRange(GroupComputerParts(computerDrivesSelector.ComputerPartsSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupMice(MiceSelector miceSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupMauseTypes(dBQuestions),
                _questionsCreator.GroupButtonsCount(dBQuestions),
            };
            questions.AddRange(GroupComputerAccessories(miceSelector.ComputerAccessoriesSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupKeyboards(KeyboardsSelector keyboardsSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupKeyboardTypes(dBQuestions),
            };
            questions.AddRange(GroupComputerAccessories(keyboardsSelector.ComputerAccessoriesSelector, dBQuestions));
            return questions;
        }
        public List<QuestionsBase<string>> GroupHeadphones(HeadphonesSelector headphonesSelector, List<DBQuestionBase> dBQuestions)
        {
            var questions = new List<QuestionsBase<string>>() {
                _questionsCreator.GroupHeadphonesTypes(dBQuestions),
                _questionsCreator.GroupWirelessTypes(dBQuestions),
                _questionsCreator.GroupConnectorTypes(dBQuestions),
            };
            questions.AddRange(GroupComputerAccessories(headphonesSelector.ComputerAccessoriesSelector, dBQuestions));
            return questions;
        }
    }
}
