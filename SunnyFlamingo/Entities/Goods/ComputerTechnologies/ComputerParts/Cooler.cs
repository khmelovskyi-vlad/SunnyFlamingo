using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class Cooler : ComputerPart
    {
        public Cooler()
        {

        }
        public Cooler(CoolerModel coolerModel)
        {
            Name = coolerModel.Name;
            Price = coolerModel.Price;
            IsAvailable = coolerModel.IsAvailable;
            Description = coolerModel.Description;
            ProducerId = coolerModel.ProducerId;
            ManufacturerId = coolerModel.ManufacturerId;
            MaterialValue = coolerModel.Material;
            ColorValue = coolerModel.Color;
            TypeValue = coolerModel.Type;
            FanSize = coolerModel.FanSize;
        }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public CoolerType Type { get; set; }
        public int FanSize { get; set; }
    }
}
