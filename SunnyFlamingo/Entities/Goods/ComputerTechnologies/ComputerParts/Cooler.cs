using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class Cooler : ComputerPart
    {
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public CoolerType Type { get; set; }
        public int FanSize { get; set; }
    }
}
