using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class ComputerDrive : ComputerPart
    {
        public ComputerDrive()
        {

        }
        public ComputerDrive(ComputerDriveModel computerDriveModel)
        {
            Name = computerDriveModel.Name;
            Price = computerDriveModel.Price;
            IsAvailable = computerDriveModel.IsAvailable;
            Description = computerDriveModel.Description;
            ProducerId = computerDriveModel.ProducerId;
            ManufacturerId = computerDriveModel.ManufacturerId;
            MaterialValue = computerDriveModel.Material;
            ColorValue = computerDriveModel.Color;
            Capacity = computerDriveModel.Capacity;
            TypeValue = computerDriveModel.Type;
            FormFactorTypeValue = computerDriveModel.FormFactorType;
        }
        public int Capacity { get; set; }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public ComputerDriveType Type { get; set; }
        [MaxLength(500)]
        public string FormFactorTypeValue { get; set; }
        public FormFactorType FormFactorType { get; set; }
    }
}
