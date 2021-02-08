using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.ValueObjects
{
    //public enum CPUSocketType
    //{
    //    Intel,
    //    AMD
    //}
    public class CPUSocketType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<CPU> CPUs { get; set; }
        public List<Laptop> Laptops { get; set; }
        public List<Computer> Computers { get; set; }
    }
}
