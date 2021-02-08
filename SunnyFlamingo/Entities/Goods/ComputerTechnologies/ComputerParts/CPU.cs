using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class CPU : ComputerPart
    {
        [MaxLength(500)]
        public string CPUSocketTypeValue { get; set; }
        public CPUSocketType CPUSocketType { get; set; }
        public int ThermalDesignPower { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
    }
}
