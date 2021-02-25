using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public string Value { get; set; }

        public List<Order> Orders { get; set; }
    }
}
