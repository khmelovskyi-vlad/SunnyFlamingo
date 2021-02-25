using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;
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
        }
        [MaxLength(500)]
        public string TypeValue { get; set; }
        public KeySwitchType Type { get; set; }
    }
}
