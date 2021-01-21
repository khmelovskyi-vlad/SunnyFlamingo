using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    public class FormFactorType
    {
        [Key]
        public string Value { get; set; }
        public List<ComputerDrive> ComputerDrives { get; set; }
    }
}
