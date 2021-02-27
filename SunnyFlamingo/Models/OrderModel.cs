using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Models
{
    public class OrderModel
    {
        public Guid Id { get; set; }
        public string Address { get; set; }


        public DeliveryMethodModel DeliveryMethod { get; set; }
        public UserModel User { get; set; }
        public List<BasketGoodModel> BasketGoods { get; set; }
    }
}
