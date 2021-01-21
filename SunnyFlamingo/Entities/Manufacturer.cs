using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }
    }
}
