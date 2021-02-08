using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models.Selectors
{
    public class GoodsSelector
    {
        public string[] Producers { get; set; }
        public string[] Countries { get; set; }
        public string[] Materials { get; set; }
        public string[] Colors { get; set; }
        public decimal? PriceFrom { get; set; }
        public decimal? PriceTo { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public bool GetQuestions { get; set; }
    }
}
