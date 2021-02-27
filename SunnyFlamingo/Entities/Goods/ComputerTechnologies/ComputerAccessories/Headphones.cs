using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Headphones : ComputerAccessory
    {
        public Headphones()
        {

        }
        public Headphones(HeadphonesModel headphonesModel)
        {
            Name = headphonesModel.Name;
            Price = headphonesModel.Price;
            IsAvailable = headphonesModel.IsAvailable;
            Description = headphonesModel.Description;
            ProducerId = headphonesModel.ProducerId;
            ManufacturerId = headphonesModel.ManufacturerId;
            MaterialValue = headphonesModel.Material;
            ColorValue = headphonesModel.Color;
            TypeValue = headphonesModel.Type;
            WirelessTypeValue = headphonesModel.WirelessType;
            ConnectorTypeValue = headphonesModel.ConnectorType;
            if (headphonesModel.UserId != null && headphonesModel.UserId != new Guid())
            {
                UserId = headphonesModel.UserId;
            }
        }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public HeadphonesType Type { get; set; }


        [MaxLength(500)]
        public string WirelessTypeValue { get; set; }
        public WirelessType WirelessType { get; set; }


        [MaxLength(500)]
        public string ConnectorTypeValue { get; set; }
        public ConnectorType ConnectorType { get; set; }
    }
}
