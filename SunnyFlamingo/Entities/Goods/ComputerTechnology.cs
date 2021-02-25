using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods
{
    public class ComputerTechnology : Good
    {
        public ComputerTechnology()
        {

        }
        public ComputerTechnology(ComputerTechnologyModel computerTechnologyModel)
        {
            Name = computerTechnologyModel.Name;
            Price = computerTechnologyModel.Price;
            IsAvailable = computerTechnologyModel.IsAvailable;
            Description = computerTechnologyModel.Description;
            ProducerId = computerTechnologyModel.ProducerId;
            ManufacturerId = computerTechnologyModel.ManufacturerId;
            MaterialValue = computerTechnologyModel.Material;
            ColorValue = computerTechnologyModel.Color;
        }
    }
}
