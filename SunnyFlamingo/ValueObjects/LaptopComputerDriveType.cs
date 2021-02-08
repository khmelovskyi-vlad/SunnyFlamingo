using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.ValueObjects
{
    public class LaptopComputerDriveType
    {
        public Guid LaptopId { get; set; }
        public Laptop Laptop { get; set; }
        [MaxLength(500)]
        public string ComputerDriveTypeValue { get; set; }
        public ComputerDriveType ComputerDriveType { get; set; }
    }
}
