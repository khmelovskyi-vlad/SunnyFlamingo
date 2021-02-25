using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Data.Initializers
{
    public class SecondInitializer : IInitializer
    {
        public void Run(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderStatus>().HasData(GetOrderStatuses());
            modelBuilder.Entity<DeliveryMethod>().HasData(GetDeliveryMethods());
        }
        private List<DeliveryMethod> GetDeliveryMethods()
        {
            return new List<DeliveryMethod>()
            {
                new DeliveryMethod(){ Id = Guid.NewGuid(), Value = "Nova poshta global" },
                new DeliveryMethod(){ Id = Guid.NewGuid(), Value = "Ukraine's national post" },
                new DeliveryMethod(){ Id = Guid.NewGuid(), Value = "Meest" },
                new DeliveryMethod(){ Id = Guid.NewGuid(), Value = "DHL Express" },
            };
        }
        private List<OrderStatus> GetOrderStatuses()
        {
            return new List<OrderStatus>()
            {
                new OrderStatus(){ Id = Guid.NewGuid(), Value = "In processing" },
                new OrderStatus(){ Id = Guid.NewGuid(), Value = "Complete" },
                new OrderStatus(){ Id = Guid.NewGuid(), Value = "In the way" },
            };
        }
    }
}
