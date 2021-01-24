using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class GoodsInformation<T>
    {
        public List<GoodCellModel> GoodCells { get; set; }
        public List<QuestionsBase<T>> Questions { get; set; }
    }
}
