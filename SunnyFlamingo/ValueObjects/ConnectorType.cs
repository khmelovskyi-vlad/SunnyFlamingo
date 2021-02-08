using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.ValueObjects
{
    public class ConnectorType
    {
        [Key]
        [MaxLength(500)]
        public string Value { get; set; }
        public List<Headphones> Headphones { get; set; }
    }
}
