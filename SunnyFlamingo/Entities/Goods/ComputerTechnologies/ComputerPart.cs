using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class ComputerPart : ComputerTechnology
    {
        public ComputerPart()
        {

        }
        public ComputerPart(ComputerPartModel computerPartModel)
        {
            Name = computerPartModel.Name;
            Price = computerPartModel.Price;
            IsAvailable = computerPartModel.IsAvailable;
            Description = computerPartModel.Description;
            ProducerId = computerPartModel.ProducerId;
            ManufacturerId = computerPartModel.ManufacturerId;
            MaterialValue = computerPartModel.Material;
            ColorValue = computerPartModel.Color;
        }
    }
}
