using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public OrdersController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet("GetDeliveryMethods")]
        public async Task<List<DeliveryMethodModel>> GetDeliveryMethods()
        {
            return (await _context.DeliveryMethods.ToListAsync()).Select(dm => new DeliveryMethodModel() { Id = dm.Id, Value = dm.Value }).ToList();
        }
        //
        [HttpPost("SaveOrder")]
        public async Task<int> SaveOrder([FromBody] OrderModel orderModel)
        {
            try
            {
                var order = new Order(orderModel);
                var id = Guid.NewGuid();
                order.Id = id;
                order.RegistrationTime = DateTime.Now;
                order.IsComplete = false;
                order.StatusId = (await _context.OrderStatuses.FirstOrDefaultAsync(status => status.Value == "In processing")).Id;

                var userId = await GetUser(orderModel.User);
                order.UserId = userId;
                await AddOrderGoods(id, orderModel.BasketGoods);
                await _context.Orders.AddAsync(order);
                await _context.SaveChangesAsync();
                return 1;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private async Task AddOrderGoods(Guid orderId, List<BasketGoodModel> basketGoods)
        {
            List<OrderGood> orderGoods = new List<OrderGood>();
            foreach (var good in basketGoods)
            {
                orderGoods.Add(new OrderGood() { OrderId = orderId, GoodId = good.GoodInformation.Id, GoodCount = good.Count });
            }
            await _context.AddRangeAsync(orderGoods);
        }
        private async Task<Guid> GetUser(UserModel userModel)
        {
            var user = await _context.Users.FirstOrDefaultAsync(user => user.Email == userModel.Email);
            if (user == null)
            {
                return await CreateUser(userModel);
            }
            return user.Id;
        }
        private async Task<Guid> CreateUser(UserModel userModel)
        {
            var user = new ApplicationUser();
            var userId = Guid.NewGuid();
            user.Email = userModel.Email;
            user.FirstName = userModel.FirstName;
            user.LastName = userModel.LastName;
            user.Id = userId;
            await _context.Users.AddAsync(user);
            return userId;
        }
    }
}
