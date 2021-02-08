using SunnyFlamingo.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class FlashDrive : ComputerTechnology
    {
        public int Capacity { get; set; }
        [MaxLength(500)]
        public string USBSpecificationTypeValue { get; set; }
        public USBSpecificationType USBSpecificationType { get; set; }
    }
}
