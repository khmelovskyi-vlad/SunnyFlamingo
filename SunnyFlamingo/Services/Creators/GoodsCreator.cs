using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Creators
{
    public class GoodsCreator : IGoodsCreator
    {
        private readonly ApplicationDbContext _context;
        private readonly IQuestionGrouper _questionGrouper;
        public GoodsCreator(IQuestionGrouper questionGrouper, ApplicationDbContext context)
        {
            _questionGrouper = questionGrouper;
            _context = context;
        }
        public QuestionsBase<string> GetGoodQuestions(string type)
        {
            switch (type)
            {
                case "Good":
                    return CreateGoodQuestions();
                case "ComputerTechnology":
                    return CreateComputerTechnologyQuestions();
                case "ComputerPart":
                    return CreateComputerPartQuestions();
                case "ComputerAccessory":
                    return CreateComputerAccessoryQuestions();
                case "Computer":
                    return CreateComputerQuestions();
                case "Laptop":
                    return CreateLaptopQuestions();
                case "FlashDrive":
                    return CreateFlashDriveQuestions();
                case "VideoCard":
                    return CreateVideoCardQuestions();
                case "CPU":
                    return CreateCPUQuestions();
                case "Cooler":
                    return CreateCoolerQuestions();
                case "ComputerDrive":
                    return CreateComputerDriveQuestions();
                case "Mause":
                    return CreateMauseQuestions();
                case "Keyboard":
                    return CreateKeyboardQuestions();
                case "Headphones":
                    return CreateHeadphonesQuestions();
                default:
                    return CreateGoodQuestions();
            }
        }
        private QuestionsBase<string> CreateGoodQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-good",
                Value = "Add good",
                QuestionBaseList = _questionGrouper.GroupGoods()
            };
        }
        private QuestionsBase<string> CreateComputerTechnologyQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-computer-technology",
                Value = "Add computer technology",
                QuestionBaseList = _questionGrouper.GroupComputerTechnologies()
            };
        }
        private QuestionsBase<string> CreateComputerPartQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-computer-part",
                Value = "Add computer part",
                QuestionBaseList = _questionGrouper.GroupComputerParts()
            };
        }
        private QuestionsBase<string> CreateComputerAccessoryQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-computer-accessory",
                Value = "Add computer accessory",
                QuestionBaseList = _questionGrouper.GroupComputerAccessories()
            };
        }
        private QuestionsBase<string> CreateComputerQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-computer",
                Value = "Add computer",
                QuestionBaseList = _questionGrouper.GroupComputers()
            };
        }
        private QuestionsBase<string> CreateLaptopQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-laptop",
                Value = "Add laptop",
                QuestionBaseList = _questionGrouper.GroupLaptops()
            };
        }
        private QuestionsBase<string> CreateFlashDriveQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-flash-drive",
                Value = "Add flash drive",
                QuestionBaseList = _questionGrouper.GroupFlashDrives()
            };
        }
        private QuestionsBase<string> CreateVideoCardQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-video-card",
                Value = "Add video card",
                QuestionBaseList = _questionGrouper.GroupVideoCards()
            };
        }
        private QuestionsBase<string> CreateCPUQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-cpu",
                Value = "Add CPU",
                QuestionBaseList = _questionGrouper.GroupCPUs()
            };
        }
        private QuestionsBase<string> CreateCoolerQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-cooler",
                Value = "Add cooler",
                QuestionBaseList = _questionGrouper.GroupCoolers()
            };
        }
        private QuestionsBase<string> CreateComputerDriveQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-computer-drives",
                Value = "Add computer drives",
                QuestionBaseList = _questionGrouper.GroupComputerDrives()
            };
        }
        private QuestionsBase<string> CreateMauseQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-mause",
                Value = "Add mause",
                QuestionBaseList = _questionGrouper.GroupMice()
            };
        }
        private QuestionsBase<string> CreateKeyboardQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-keyboard",
                Value = "Add keyboard",
                QuestionBaseList = _questionGrouper.GroupKeyboards()
            };
        }
        private QuestionsBase<string> CreateHeadphonesQuestions()
        {
            return new QuestionsBase<string>()
            {
                Key = "add-headphones",
                Value = "Add headphones",
                QuestionBaseList = _questionGrouper.GroupHeadphones()
            };
        }



        public async Task<int> AddGood(GoodModel goodModel, string email)
        {
            try
            {
                goodModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var good = new Good(goodModel);
                await AddGoodData(goodModel.ImageIds, good);
                await _context.Goods.AddAsync(good);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> AddComputerTechnology(ComputerTechnologyModel computerTechnologyModel, string email)
        {
            try
            {
                computerTechnologyModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var computerTechnology = new ComputerTechnology(computerTechnologyModel);
                await AddGoodData(computerTechnologyModel.ImageIds, computerTechnology);
                await _context.Goods.AddAsync(computerTechnology);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddComputerPart(ComputerPartModel computerPartModel, string email)
        {
            try
            {
                computerPartModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var computerPart = new ComputerPart(computerPartModel);
                await AddGoodData(computerPartModel.ImageIds, computerPart);
                await _context.ComputerParts.AddAsync(computerPart);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddComputerAccessory(ComputerAccessoryModel computerAccessoryModel, string email)
        {
            try
            {
                computerAccessoryModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var computerAccessory = new ComputerAccessory(computerAccessoryModel);
                await AddGoodData(computerAccessoryModel.ImageIds, computerAccessory);
                await _context.ComputerAccessories.AddAsync(computerAccessory);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddComputer(ComputerModel computerModel, string email)
        {
            try
            {
                computerModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var computer = new Computer(computerModel);
                var id = await AddGoodData(computerModel.ImageIds, computer);
                await AddComputerComputerDriveType(computerModel.ComputerDriveTypes, id);
                await _context.Computers.AddAsync(computer);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddLaptop(LaptopModel laptopModel, string email)
        {
            try
            {
                laptopModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var laptop = new Laptop(laptopModel);
                var id = await AddGoodData(laptopModel.ImageIds, laptop);
                await AddLaptopComputerDriveType(laptopModel.ComputerDriveTypes, id);
                await _context.Laptops.AddAsync(laptop);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddFlashDrive(FlashDriveModel flashDriveModel, string email)
        {
            try
            {
                flashDriveModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var flashDrive = new FlashDrive(flashDriveModel);
                await AddGoodData(flashDriveModel.ImageIds, flashDrive);
                await _context.FlashDrives.AddAsync(flashDrive);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddVideoCard(VideoCardModel videoCardModel, string email)
        {
            try
            {
                videoCardModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var videoCard = new VideoCard(videoCardModel);
                await AddGoodData(videoCardModel.ImageIds, videoCard);
                await _context.VideoCards.AddAsync(videoCard);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddCPU(CPUModel cpuModel, string email)
        {
            try
            {
                cpuModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var cpu = new CPU(cpuModel);
                await AddGoodData(cpuModel.ImageIds, cpu);
                await _context.CPUs.AddAsync(cpu);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddCooler(CoolerModel coolerModel, string email)
        {
            try
            {
                coolerModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var cooler = new Cooler(coolerModel);
                await AddGoodData(coolerModel.ImageIds, cooler);
                await _context.Coolers.AddAsync(cooler);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddComputerDrive(ComputerDriveModel computerDriveModel, string email)
        {
            try
            {
                computerDriveModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var computerDrive = new ComputerDrive(computerDriveModel);
                await AddGoodData(computerDriveModel.ImageIds, computerDrive);
                await _context.ComputerDrives.AddAsync(computerDrive);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddMause(MauseModel mauseModel, string email)
        {
            try
            {
                mauseModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var mause = new Mause(mauseModel);
                await AddGoodData(mauseModel.ImageIds, mause);
                await _context.Mice.AddAsync(mause);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddKeyboard(KeyboardModel keyboardModel, string email)
        {
            try
            {
                keyboardModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var keyboard = new Keyboard(keyboardModel);
                await AddGoodData(keyboardModel.ImageIds, keyboard);
                await _context.Keyboards.AddAsync(keyboard);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> AddHeadphones(HeadphonesModel headphonesModel, string email)
        {
            try
            {
                headphonesModel.UserId = (await _context.Users.FirstOrDefaultAsync(user => user.Email == email)).Id;
                var headphones = new Headphones(headphonesModel);
                await AddGoodData(headphonesModel.ImageIds, headphones);
                await _context.Headphones.AddAsync(headphones);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }













        private async Task AddLaptopComputerDriveType(List<string> computerDriveTypes, Guid laptopId)
        {
            if (computerDriveTypes.Count > 0)
            {
                var laptopComputerDriveType = new List<LaptopComputerDriveType>();
                foreach (var computerDriveType in computerDriveTypes)
                {
                    laptopComputerDriveType.Add(new LaptopComputerDriveType(laptopId, computerDriveType));
                }
                await _context.LaptopComputerDriveTypes.AddRangeAsync(laptopComputerDriveType);
            }
        }
        private async Task AddComputerComputerDriveType(List<string> computerDriveTypes, Guid computerId)
        {
            if (computerDriveTypes.Count > 0)
            {
                var computerDriveTypeList = new List<ComputerComputerDriveType>();
                foreach (var computerDriveType in computerDriveTypes)
                {
                    computerDriveTypeList.Add(new ComputerComputerDriveType(computerId, computerDriveType));
                }
                await _context.ComputerComputerDriveTypes.AddRangeAsync(computerDriveTypeList);
            }
        }
        private async Task<Guid> AddGoodData(List<Guid> imageIds, Good good)
        {
            var id = AddId(good);
            AddAddTime(good);
            await AddImages(imageIds, id);
            return id;
        }
        private async Task AddImages(List<Guid> imageIds, Guid goodId)
        {
            var imgs = await _context.ImageInfo.Where(img => imageIds.Any(id => id == img.Id)).ToListAsync();
            imgs.ForEach(img => img.GoodId = goodId);
        }
        private Guid AddId(Good good)
        {
            var id = Guid.NewGuid();
            good.Id = id;
            return id;
        }
        private DateTime AddAddTime(Good good)
        {
            var addTime = DateTime.Now;
            good.AddTime = addTime;
            return addTime;
        }
    }
}
