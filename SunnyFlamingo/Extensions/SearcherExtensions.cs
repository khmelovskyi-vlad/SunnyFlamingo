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
            services.AddSingleton<IQuestionsGrouper, QuestionsGrouper>();
            services.AddSingleton<IParametersCreator, ParametersCreator>();
            services.AddScoped<IGoodsInformationCreator, GoodsInformationCreator>();
            services.AddSingleton<IQuestionsCreator, QuestionsCreator>();

            services.AddScoped<IGoodsSearcher, GoodsSearcher>();
            services.AddScoped<IComputerTechnologiesSearchers, ComputerTechnologiesSearchers>();
            services.AddScoped<IComputersSearcher, ComputersSearcher>();
            services.AddScoped<IFlashDrivesSearcher, FlashDrivesSearcher>();
            services.AddScoped<ILaptopsSearcher, LaptopsSearcher>();
            services.AddScoped<IComputerPartsSearcher, ComputerPartsSearcher>();
            services.AddScoped<IComputerAccessoriesSearcher, ComputerAccessoriesSearcher>();
            services.AddScoped<IComputerDrivesSearcher, ComputerDrivesSearcher>();
            services.AddScoped<ICoolersSearcher, CoolersSearcher>();
            services.AddScoped<ICPUsSearcher, CPUsSearcher>();
            services.AddScoped<IVideoCardsSearcher, VideoCardsSearcher>();
            services.AddScoped<IHeadphonesSearcher, HeadphonesSearcher>();
            services.AddScoped<IKeyboardsSearcher, KeyboardsSearcher>();
            services.AddScoped<IMiceSearcher, MiceSearcher>();
        }
    }
}
