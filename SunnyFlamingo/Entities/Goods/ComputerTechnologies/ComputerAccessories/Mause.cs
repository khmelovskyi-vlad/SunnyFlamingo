using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;
namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Mause : ComputerAccessory
    {
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public MauseType Type { get; set; }
        public int ButtonsCount { get; set; }
    }
}
