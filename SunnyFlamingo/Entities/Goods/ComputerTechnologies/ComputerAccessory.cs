using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class ComputerAccessory : ComputerTechnology
    {
        public ComputerAccessory()
        {

        }
        public ComputerAccessory(ComputerAccessoryModel computerAccessoryModel)
        {
            Name = computerAccessoryModel.Name;
            Price = computerAccessoryModel.Price;
            IsAvailable = computerAccessoryModel.IsAvailable;
            Description = computerAccessoryModel.Description;
            ProducerId = computerAccessoryModel.ProducerId;
            ManufacturerId = computerAccessoryModel.ManufacturerId;
            MaterialValue = computerAccessoryModel.Material;
            ColorValue = computerAccessoryModel.Color;
        }
    }
}
