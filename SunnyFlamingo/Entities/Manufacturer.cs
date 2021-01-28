using SunnyFlamingo.Entities.Goods;
using System;
using System.Collections.Generic;

namespace SunnyFlamingo.Entities
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public List<Good> Goods { get; set; }
    }
}
