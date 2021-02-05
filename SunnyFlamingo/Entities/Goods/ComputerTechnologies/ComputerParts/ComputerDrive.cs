using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class ComputerDrive : ComputerPart
    {
        public int Capacity { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public ComputerDriveType Type { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string FormFactorTypeValue { get; set; }
        public FormFactorType FormFactorType { get; set; }
    }
}
