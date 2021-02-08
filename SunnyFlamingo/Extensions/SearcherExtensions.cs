using Microsoft.Extensions.DependencyInjection;
using SunnyFlamingo.Services.Searchers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class SearcherExtensions
    {
        public static void AddSearchers(this IServiceCollection services)
        {
            services.AddScoped<IAllGoodsSearcher, AllGoodsSearcher>();
            services.AddScoped<IQuestionsGrouper, QuestionsGrouper>();

            services.AddScoped<IGoodsSearcher, GoodsSearcher>();
            services.AddScoped<IGoodsQuestionsService, GoodsQuestionsService>();
            services.AddScoped<IComputerTechnologiesSearchers, ComputerTechnologiesSearchers>();
            services.AddScoped<IComputerTechnologiesQuestionsService, ComputerTechnologiesQuestionsService>();
            services.AddScoped<IComputersSearcher, ComputersSearcher>();
            services.AddScoped<IComputersQuestionsService, ComputersQuestionsService>();

            services.AddScoped<IFlashDrivesSearcher, FlashDrivesSearcher>();
            services.AddScoped<IFlashDrivesQuestionsService, FlashDrivesQuestionsService>();
            services.AddScoped<ILaptopsSearcher, LaptopsSearcher>();
            services.AddScoped<ILaptopsQuestionsService, LaptopsQuestionsService>();
            services.AddScoped<IComputerPartsSearcher, ComputerPartsSearcher>();
            services.AddScoped<IComputerPartsQuestionsService, ComputerPartsQuestionsService>();
            services.AddScoped<IComputerAccessoriesSearcher, ComputerAccessoriesSearcher>();
            services.AddScoped<IComputerAccessoriesQuestionsService, ComputerAccessoriesQuestionsService>();
            services.AddScoped<IComputerDrivesSearcher, ComputerDrivesSearcher>();
            services.AddScoped<IComputerDrivesQuestionsService, ComputerDrivesQuestionsService>();
            services.AddScoped<ICoolersSearcher, CoolersSearcher>();
            services.AddScoped<ICoolersQuestionsService, CoolersQuestionsService>();

            services.AddScoped<ICPUsSearcher, CPUsSearcher>();
            services.AddScoped<ICPUsQuestionsService, CPUsQuestionsService>();
            services.AddScoped<IVideoCardsSearcher, VideoCardsSearcher>();
            services.AddScoped<IVideoCardsQuestionsService, VideoCardsQuestionsService>();

            services.AddScoped<IHeadphonesSearcher, HeadphonesSearcher>();
            services.AddScoped<IHeadphonesQuestionsService, HeadphonesQuestionsService>();
            services.AddScoped<IKeyboardsSearcher, KeyboardsSearcher>();
            services.AddScoped<IKeyboardsQuestionsService, KeyboardsQuestionsService>();
            services.AddScoped<IMiceSearcher, MiceSearcher>();
            services.AddScoped<IMiceQuestionsService, MiceQuestionsService>();
        }
    }
}
