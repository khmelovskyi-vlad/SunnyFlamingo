using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class OrderGood
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid GoodId { get; set; }
        public Good Good { get; set; }
    }
}
