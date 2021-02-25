using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;
namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Mause : ComputerAccessory
    {
        public Mause()
        {

        }
        public Mause(MauseModel mauseModel)
        {
            Name = mauseModel.Name;
            Price = mauseModel.Price;
            IsAvailable = mauseModel.IsAvailable;
            Description = mauseModel.Description;
            ProducerId = mauseModel.ProducerId;
            ManufacturerId = mauseModel.ManufacturerId;
            MaterialValue = mauseModel.Material;
            ColorValue = mauseModel.Color;
            TypeValue = mauseModel.Type;
            ButtonsCount = mauseModel.ButtonsCount;
        }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public MauseType Type { get; set; }
        public int ButtonsCount { get; set; }
    }
}
