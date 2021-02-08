using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace SunnyFlamingo.ValueObjects
{
    public class USBSpecificationType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<FlashDrive> FlashDrives { get; set; }
    }
}
