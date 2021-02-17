using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class GoodsInformation<T>
    {
        public GoodsInformation()
        {

        }
        public GoodsInformation(int count, List<GoodCellModel> goodCells, List<QuestionsBase<T>> questions)
        {
            Count = count;
            GoodCells = goodCells;
            Questions = questions;
        }
        public int Count { get; set; }
        public List<GoodCellModel> GoodCells { get; set; }
        public List<QuestionsBase<T>> Questions { get; set; }
    }
}
