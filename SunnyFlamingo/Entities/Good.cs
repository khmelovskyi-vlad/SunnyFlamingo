using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities
{
    public class Good
    {
        public Good()
        {

        }
        public Good(GoodModel goodModel)
        {
            Name = goodModel.Name;
            Price = goodModel.Price;
            IsAvailable = goodModel.IsAvailable;
            Description = goodModel.Description;
            ProducerId = goodModel.ProducerId;
            ManufacturerId = goodModel.ManufacturerId;
            MaterialValue = goodModel.Material;
            ColorValue = goodModel.Color;
            if (goodModel.UserId != null && goodModel.UserId != new Guid())
            {
                UserId = goodModel.UserId;
            }
        }
        public Guid Id { get; set; }
        [MaxLength(500)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public DateTime AddTime { get; set; }

        public Guid? ProducerId { get; set; }
        public Producer Producer { get; set; }
        public Guid? ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
        [MaxLength(500)]
        public string MaterialValue { get; set; }
        public Material Material { get; set; }
        [MaxLength(500)]
        public string ColorValue { get; set; }
        public Color Color { get; set; }
        public List<ImageInfo> ImageInfo { get; set; }
        public Guid? UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderGood> OrderGoods { get; set; }
        public string Discriminator { get; set; }
    }
}
