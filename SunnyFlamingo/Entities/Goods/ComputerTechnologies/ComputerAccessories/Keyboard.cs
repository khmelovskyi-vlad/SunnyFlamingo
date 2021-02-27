using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
using System;
using System.ComponentModel.DataAnnotations;

namespace SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories
{
    public class Keyboard : ComputerAccessory
    {
        public Keyboard()
        {

        }
        public Keyboard(KeyboardModel keyboardModel)
        {
            Name = keyboardModel.Name;
            Price = keyboardModel.Price;
            IsAvailable = keyboardModel.IsAvailable;
            Description = keyboardModel.Description;
            ProducerId = keyboardModel.ProducerId;
            ManufacturerId = keyboardModel.ManufacturerId;
            MaterialValue = keyboardModel.Material;
            ColorValue = keyboardModel.Color;
            TypeValue = keyboardModel.Type;
            if (keyboardModel.UserId != null && keyboardModel.UserId != new Guid())
            {
                UserId = keyboardModel.UserId;
            }
        }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public KeySwitchType Type { get; set; }
    }
}
