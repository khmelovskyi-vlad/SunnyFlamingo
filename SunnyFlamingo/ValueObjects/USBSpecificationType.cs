using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class USBSpecificationType
    {
        [Key]
        public string Value { get; set; }
        public List<FlashDrive> FlashDrives { get; set; }
    }
}
