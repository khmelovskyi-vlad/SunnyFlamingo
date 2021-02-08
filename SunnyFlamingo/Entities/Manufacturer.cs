using SunnyFlamingo.Entities.Goods;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities
{
    public class Manufacturer
    {
        public Guid Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }

        public Guid CountryId { get; set; }
        public Country Country { get; set; }

        public List<Good> Goods { get; set; }
    }
}
