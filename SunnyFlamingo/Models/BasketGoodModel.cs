using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class BasketGoodModel
    {
        public GoodInformation GoodInformation { get; set; }
        public int Count { get; set; }
        public DateTime AddDate { get; set; }
    }
}
