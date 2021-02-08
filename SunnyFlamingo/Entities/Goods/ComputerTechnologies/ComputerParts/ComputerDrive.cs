using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class ComputerDrive : ComputerPart
    {
        public int Capacity { get; set; }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public ComputerDriveType Type { get; set; }
        [MaxLength(500)]
        public string FormFactorTypeValue { get; set; }
        public FormFactorType FormFactorType { get; set; }
    }
}
