using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class GoodModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public DateTime AddTime { get; set; }

        public Guid? ProducerId { get; set; }
        public Guid? ManufacturerId { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public List<Guid> ImageIds { get; set; }
        public Guid? UserId { get; set; }
    }
}
