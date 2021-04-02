using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data;
using SunnyFlamingo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class IpBanMiddleware
    {
        private readonly RequestDelegate _next;

        public IpBanMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, ApplicationDbContext context)
        {
            var haveIp = false;
            var ip = httpContext.Connection.RemoteIpAddress?.ToString();
            var httpUser = httpContext.User;
            if (httpUser != null && httpUser.Identity != null && httpUser.Identity.IsAuthenticated)
            {
                var userIdString = httpUser.Identity;
                var userEmail = httpUser.Identity.Name;
                var user = await context.Users.Where(u => u.Email == userEmail).Include(u => u.UserIps).ThenInclude(ui => ui.Ip).FirstOrDefaultAsync();
                if (user.UserIps != null)
                {
                    foreach (var userIp in user.UserIps)
                    {
                        if (userIp.Ip.Value == ip)
                        {
                            if (userIp.Ip.IsInBan)
                            {
                                return;
                            }
                            haveIp = true;
                            break;
                        }
                    }
                }
                if (!haveIp)
                {
                    await AddIp(context, user.Id, ip);
                }
            }
            if (!haveIp && await CheckIsInBan(ip, context))
            {
                return;
            }
            await _next(httpContext);
        }
        private async Task<bool> CheckIsInBan(string ip, ApplicationDbContext context)
        {
            var ips = await context.Ips.Where(i => i.Value == ip).ToListAsync();
            if (ips != null && ips.Any(i => i.IsInBan == true))
            {
                return true;
            }
            return false;
        }
        private async Task AddIp(ApplicationDbContext context, Guid userId, string ipValue)
        {
            var ip = new Ip() { Id = Guid.NewGuid(), IsInBan = false, Value = ipValue };
            await context.Ips.AddAsync(ip);
            await context.UserIps.AddAsync(new UserIp() { UserId = userId, IpId = ip.Id });
            await context.SaveChangesAsync();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class IpBanMiddlewareExtensions
    {
        public static IApplicationBuilder UseIpBanMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IpBanMiddleware>();
        }
    }
}
