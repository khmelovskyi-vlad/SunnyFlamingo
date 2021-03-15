using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts
{
    public class VideoCard : ComputerPart
    {
        public VideoCard()
        {

        }
        public VideoCard(VideoCardModel videoCardModel)
        {
            Name = videoCardModel.Name;
            Price = videoCardModel.Price;
            IsAvailable = videoCardModel.IsAvailable;
            Description = videoCardModel.Description;
            ProducerId = videoCardModel.ProducerId;
            ManufacturerId = videoCardModel.ManufacturerId;
            MaterialValue = videoCardModel.Material;
            ColorValue = videoCardModel.Color;
            VideoSize = videoCardModel.VideoSize;
            DriveInterfaceValue = videoCardModel.DriveInterface;
            VideoMemoryCapacity = videoCardModel.VideoMemoryCapacity;
            if (videoCardModel.UserId != null && videoCardModel.UserId != new Guid())
            {
                UserId = videoCardModel.UserId;
            }
        }
        public int VideoSize { get; set; }
        [MaxLength(500)]
        public string DriveInterfaceValue { get; set; }
        public DriveInterface DriveInterface { get; set; }
        public int VideoMemoryCapacity { get; set; }
    }
}
