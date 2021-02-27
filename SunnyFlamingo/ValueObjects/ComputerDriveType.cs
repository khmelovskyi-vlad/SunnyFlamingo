using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class ComputerDriveType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<ComputerDrive> ComputerDrives { get; set; }
        public List<LaptopComputerDriveType> LaptopComputerDriveTypes { get; set; }
        public List<ComputerComputerDriveType> ComputerComputerDriveTypes { get; set; }
    }
}
