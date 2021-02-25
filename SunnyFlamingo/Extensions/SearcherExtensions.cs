using Microsoft.Extensions.DependencyInjection;
using SunnyFlamingo.Services;
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
            services.AddSingleton<IQuestionsGrouper, QuestionsGrouper>();
            services.AddSingleton<IParametersCreator, ParametersCreator>();
            services.AddScoped<IGoodsInformationCreator, GoodsInformationCreator>();
            services.AddSingleton<IQuestionsCreator, QuestionsCreator>();
        }
    }
}
