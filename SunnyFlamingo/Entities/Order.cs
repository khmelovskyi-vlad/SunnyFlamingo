using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime RegistrationTime { get; set; }
        public string Address { get; set; }
        public bool IsComplete { get; set; }
        public string WhereIs { get; set; }


        public Guid StatusId { get; set; }
        public OrderStatus Status { get; set; }
        public Guid DeliveryMethodId { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; }
        public List<OrderGood> OrderGoods { get; set; }
    }
}
