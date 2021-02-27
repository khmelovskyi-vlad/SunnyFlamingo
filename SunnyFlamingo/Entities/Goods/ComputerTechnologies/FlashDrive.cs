using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies
{
    public class FlashDrive : ComputerTechnology
    {
        public FlashDrive()
        {

        }
        public FlashDrive(FlashDriveModel flashDriveModel)
        {
            Name = flashDriveModel.Name;
            Price = flashDriveModel.Price;
            IsAvailable = flashDriveModel.IsAvailable;
            Description = flashDriveModel.Description;
            ProducerId = flashDriveModel.ProducerId;
            ManufacturerId = flashDriveModel.ManufacturerId;
            MaterialValue = flashDriveModel.Material;
            ColorValue = flashDriveModel.Color;
            Capacity = flashDriveModel.Capacity;
            USBSpecificationTypeValue = flashDriveModel.USBSpecificationType;
            if (flashDriveModel.UserId != null && flashDriveModel.UserId != new Guid())
            {
                UserId = flashDriveModel.UserId;
            }
        }
        public int Capacity { get; set; }
        [MaxLength(500)]
        public string USBSpecificationTypeValue { get; set; }
        public USBSpecificationType USBSpecificationType { get; set; }
    }
}
