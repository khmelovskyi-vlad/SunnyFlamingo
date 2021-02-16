using Microsoft.Data.SqlClient;
using SunnyFlamingo.Models.Selectors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Services.Searchers
{
    public interface IParametersCreator
    {
        SqlParameter[] GetGoodsParameters(GoodsSelector goodsSelector);
    }
}
