using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class PermissionsExtension
    {
        public static void AddPermissions(this IServiceCollection services)
        {
            var permission = "Permission";
            services.AddAuthorization(opts => {
                opts.AddPolicy("ManageAllRoles", policy => {
                    policy.RequireClaim(permission, "ManageAllRoles");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("ManageManagers", policy => {
                    policy.RequireClaim(permission, "ManageManagers");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("ManageUsers", policy => {
                    policy.RequireClaim(permission, "ManageUsers");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("GetBasicData", policy => {
                    policy.RequireClaim(permission, "GetBasicData");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("AddGoods", policy => {
                    policy.RequireClaim(permission, "AddGoods");
                });
            });
            services.AddAuthorization(opts => {
                opts.AddPolicy("AddExcelGoods", policy => {
                    policy.RequireClaim(permission, "AddExcelGoods");
                });
            });
        }
    }
}
