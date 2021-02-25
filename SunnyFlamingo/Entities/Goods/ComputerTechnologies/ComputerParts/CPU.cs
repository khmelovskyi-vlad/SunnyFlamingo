using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class CPU : ComputerPart
    {
        public CPU()
        {

        }
        public CPU(CPUModel cpuModel)
        {
            Name = cpuModel.Name;
            Price = cpuModel.Price;
            IsAvailable = cpuModel.IsAvailable;
            Description = cpuModel.Description;
            ProducerId = cpuModel.ProducerId;
            ManufacturerId = cpuModel.ManufacturerId;
            MaterialValue = cpuModel.Material;
            ColorValue = cpuModel.Color;
            CPUSocketTypeValue = cpuModel.CPUSocketType;
            ThermalDesignPower = cpuModel.ThermalDesignPower;
            NumberOfCores = cpuModel.NumberOfCores;
            NumberOfThreads = cpuModel.NumberOfThreads;
        }
        [MaxLength(500)]
        public string CPUSocketTypeValue { get; set; }
        public CPUSocketType CPUSocketType { get; set; }
        public int ThermalDesignPower { get; set; }
        public int NumberOfCores { get; set; }
        public int NumberOfThreads { get; set; }
    }
}
