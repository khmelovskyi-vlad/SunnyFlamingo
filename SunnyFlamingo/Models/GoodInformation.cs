using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class GoodInformation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public Guid[] ImgIds { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public string Country { get; set; }
        public string Material { get; set; }
        public string Color { get; set; }
        public PropertyModel[] Properties { get; set; }
        public PropertyListModel[] PropertyLists { get; set; }
    }
}
