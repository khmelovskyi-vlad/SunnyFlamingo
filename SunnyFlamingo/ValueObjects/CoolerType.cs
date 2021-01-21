using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class CoolerType
    {
        [Key]
        public string Value { get; set; }
        public List<Cooler> Coolers { get; set; }
    }
}
