using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class GoodsDbInformation
    {
        public GoodsDbInformation(List<DBQuestionBase> dBQuestions, List<GoodCellModel> goodCells)
        {
            DBQuestions = dBQuestions;
            GoodCells = goodCells;
        }
        public List<DBQuestionBase> DBQuestions { get; set; }
        public List<GoodCellModel> GoodCells { get; set; }
    }
}
