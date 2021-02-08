using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Keyboard : ComputerAccessory
    {
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public KeySwitchType Type { get; set; }
    }
}
