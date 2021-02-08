using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.ValueObjects
{
    public class FormFactorType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<ComputerDrive> ComputerDrives { get; set; }
    }
}
