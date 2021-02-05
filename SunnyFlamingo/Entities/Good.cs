using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Good
    {
        public Guid Id { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public DateTime AddTime { get; set; }

        public Guid? ProducerId { get; set; }
        public Producer Producer { get; set; }
        public Guid? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string MaterialValue { get; set; }
        public Material Material { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string ColorValue { get; set; }
        public Color Color { get; set; }
        public List<ImageInfo> ImageInfo { get; set; }
        public Guid? UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
