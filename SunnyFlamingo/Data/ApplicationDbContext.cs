using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data.Initializers;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using SunnyFlamingo.Extensions;
using SunnyFlamingo.Models;
using SunnyFlamingo.ValueObjects;

namespace SunnyFlamingo.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ImageInfo> ImageInfo { get; set; }
        public DbSet<Ip> Ips { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<UserIp> UserIps { get; set; }
        public DbSet<ComputerTechnology> ComputerTechnology { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<FlashDrive> FlashDrives { get; set; }
        public DbSet<ComputerPart> ComputerParts { get; set; }
        public DbSet<ComputerAccessory> ComputerAccessories { get; set; }
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Headphones> Headphones { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Mause> Mice { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<Cooler> Coolers { get; set; }
        public DbSet<ComputerDrive> ComputerDrives { get; set; }
        public DbSet<GoodCellModel> GoodCellModels { get; set; }
        public DbSet<DBQuestionBase> QuestionBases { get; set; }


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public DbSet<OrderGood> OrderGoods { get; set; }


        public DbSet<ComputerDriveType> ComputerDriveTypes { get; set; }
        public DbSet<CPUSocketType> CPUSocketTypes { get; set; }
        public DbSet<HeadphonesType> HeadphonesTypes { get; set; }
        public DbSet<KeySwitchType> KeySwitchTypes { get; set; }
        public DbSet<MauseType> MauseTypes { get; set; }
        public DbSet<WirelessType> WirelessTypes { get; set; }
        public DbSet<LaptopComputerDriveType> LaptopComputerDriveTypes { get; set; }
        public DbSet<ComputerComputerDriveType> ComputerComputerDriveTypes { get; set; }

        public DbSet<Color> Colors { get; set; }
        public DbSet<ConnectorType> ConnectorTypes { get; set; }
        public DbSet<CoolerType> CoolerTypes { get; set; }
        public DbSet<DriveInterface> DriveInterfaces { get; set; }
        public DbSet<FormFactorType> FormFactorTypes { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<USBSpecificationType> USBSpecificationTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddPrimaryKeys();
            modelBuilder.AddForeignKeys();
            modelBuilder.AddNoKeys();
            modelBuilder.AddRequired();
            modelBuilder.AddConversion();
            modelBuilder.SetPrecisionsAndScales();
            modelBuilder.AddIdentityNavigation();
            modelBuilder.AddColumnNames();
            modelBuilder.Seed(new FirstInitializer());
        }

    }
}
