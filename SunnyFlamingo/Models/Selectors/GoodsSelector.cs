using SunnyFlamingo.ValueObjects;
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
        public int Page { get; set; } = 1;
        public int ShowGoods { get; set; } = 36;
        public bool GetQuestions { get; set; } = true;
        public OrderType OrderType { get; set; } = OrderType.name;
        public SortDir SortDir { get; set; } = SortDir.asc;
    }
}
