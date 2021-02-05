using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class FlashDrive : ComputerTechnology
    {
        public int Capacity { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string USBSpecificationTypeValue { get; set; }
        public USBSpecificationType USBSpecificationType { get; set; }
    }
}
