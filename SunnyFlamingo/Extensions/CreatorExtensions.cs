using Microsoft.Extensions.DependencyInjection;
using SunnyFlamingo.Services.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class CreatorExtensions
    {
        public static void AddCreators(this IServiceCollection services)
        {
            services.AddScoped<IExcelGoodsMaster, ExcelGoodsMaster>();
            services.AddScoped<IQuestionCreator, QuestionCreator>();
            services.AddScoped<IGoodsCreator, GoodsCreator>();
            services.AddScoped<IQuestionGrouper, QuestionGrouper>();
        }
    }
}
