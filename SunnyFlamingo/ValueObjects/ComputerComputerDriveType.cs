using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.ValueObjects
{
    public class ComputerComputerDriveType
    {
        public Guid ComputerId { get; set; }
        public Computer Computer { get; set; }
        [MaxLength(500)]
        public string ComputerDriveTypeValue { get; set; }
        public ComputerDriveType ComputerDriveType { get; set; }
    }
}
