using Microsoft.EntityFrameworkCore;
using SunnyFlamingo.Data.Initializers;
using SunnyFlamingo.Entities;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerAccessories;
using SunnyFlamingo.Entities.Goods.ComputerTechnologies.ComputerParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SunnyFlamingo.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder, IInitializer initializer)
        {
            initializer.Run(modelBuilder);
        }
        public static void AddIdentityNavigation(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });
        }
        public static void AddColumnNames(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laptop>()
                .Property(l => l.AmountOfRAM)
                .HasColumnName("AmountOfRAM");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.CPUFrequency)
                .HasColumnName("CPUFrequency");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.Length)
                .HasColumnName("Length");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.Height)
                .HasColumnName("Height");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.Width)
                .HasColumnName("Width");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.HaveFloppyDrives)
                .HasColumnName("HaveFloppyDrives");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.SSDMemory)
                .HasColumnName("SSDMemory");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.HardDiskMemory)
                .HasColumnName("HardDiskMemory");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.CPUSocketType)
                .HasColumnName("CPUSocketType");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.ComputerDriveType)
                .HasColumnName("ComputerDriveType");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.NumberOfCores)
                .HasColumnName("NumberOfCores");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.FloppyDrivesCount)
                .HasColumnName("FloppyDrivesCount");
            modelBuilder.Entity<Laptop>()
                .Property(l => l.Display)
                .HasColumnName("Display");

            modelBuilder.Entity<Computer>()
                .Property(c => c.AmountOfRAM)
                .HasColumnName("AmountOfRAM");
            modelBuilder.Entity<Computer>()
                .Property(c => c.CPUFrequency)
                .HasColumnName("CPUFrequency");
            modelBuilder.Entity<Computer>()
                .Property(c => c.Length)
                .HasColumnName("Length");
            modelBuilder.Entity<Computer>()
                .Property(c => c.Height)
                .HasColumnName("Height");
            modelBuilder.Entity<Computer>()
                .Property(c => c.Width)
                .HasColumnName("Width");
            modelBuilder.Entity<Computer>()
                .Property(c => c.HaveFloppyDrives)
                .HasColumnName("HaveFloppyDrives");
            modelBuilder.Entity<Computer>()
                .Property(c => c.SSDMemory)
                .HasColumnName("SSDMemory");
            modelBuilder.Entity<Computer>()
                .Property(c => c.HardDiskMemory)
                .HasColumnName("HardDiskMemory");
            modelBuilder.Entity<Computer>()
                .Property(c => c.CPUSocketType)
                .HasColumnName("CPUSocketType");
            modelBuilder.Entity<Computer>()
                .Property(c => c.ComputerDriveType)
                .HasColumnName("ComputerDriveType");
            modelBuilder.Entity<Computer>()
                .Property(c => c.NumberOfCores)
                .HasColumnName("NumberOfCores");
            modelBuilder.Entity<Computer>()
                .Property(c => c.FloppyDrivesCount)
                .HasColumnName("FloppyDrivesCount");


            modelBuilder.Entity<FlashDrive>()
                .Property(fd => fd.Capacity)
                .HasColumnName("Capacity");
            modelBuilder.Entity<FlashDrive>()
                .Property(fd => fd.USBSpecificationTypeValue)
                .HasColumnName("USBSpecificationTypeValue");


            modelBuilder.Entity<VideoCard>()
                .Property(vc => vc.VideoSize)
                .HasColumnName("VideoSize");
            modelBuilder.Entity<VideoCard>()
                .Property(vc => vc.DriveInterfaceValue)
                .HasColumnName("DriveInterfaceValue");
            modelBuilder.Entity<VideoCard>()
                .Property(vc => vc.VideoMemoryCapacity)
                .HasColumnName("VideoMemoryCapacity");


            modelBuilder.Entity<CPU>()
                .Property(cpu => cpu.CPUSocketType)
                .HasColumnName("CPUSocketType");
            modelBuilder.Entity<CPU>()
                .Property(cpu => cpu.ThermalDesignPower)
                .HasColumnName("ThermalDesignPower");
            modelBuilder.Entity<CPU>()
                .Property(cpu => cpu.NumberOfCores)
                .HasColumnName("NumberOfCores");


            modelBuilder.Entity<Cooler>()
                .Property(c => c.TypeValue)
                .HasColumnName("NumberOfThreads");
            modelBuilder.Entity<Cooler>()
                .Property(c => c.FanSize)
                .HasColumnName("FanSize");

            modelBuilder.Entity<ComputerDrive>()
                .Property(cd => cd.Capacity)
                .HasColumnName("Capacity");
            modelBuilder.Entity<ComputerDrive>()
                .Property(cd => cd.Type)
                .HasColumnName("Type");
            modelBuilder.Entity<ComputerDrive>()
                .Property(cd => cd.FormFactorTypeValue)
                .HasColumnName("FormFactorTypeValue");

            modelBuilder.Entity<Headphones>()
                .Property(h => h.Type)
                .HasColumnName("Type");
            modelBuilder.Entity<Headphones>()
                .Property(h => h.WirelessType)
                .HasColumnName("WirelessType");
            modelBuilder.Entity<Headphones>()
                .Property(h => h.ConnectorTypeValue)
                .HasColumnName("ConnectorTypeValue");

            modelBuilder.Entity<Keyboard>()
                .Property(k => k.Type)
                .HasColumnName("Type");

            modelBuilder.Entity<Mause>()
                .Property(m => m.Type)
                .HasColumnName("Type");
            modelBuilder.Entity<Mause>()
                .Property(m => m.ButtonsCount)
                .HasColumnName("ButtonsCount");
        }
        public static void SetPrecisionsAndScales(this ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            {
                property.SetColumnType("decimal(18, 6)");
            }
        }
        public static void AddPrimaryKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserIp>()
                .HasKey(ui => new { ui.UserId, ui.IpId });
        }
        public static void AddForeignKeys(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producer>()
                .HasOne(p => p.Country)
                .WithMany(c => c.Producers)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Good>()
                .HasOne(g => g.Color)
                .WithMany(c => c.Goods)
                .HasForeignKey(g => g.ColorValue);
            modelBuilder.Entity<Good>()
                .HasOne(g => g.Material)
                .WithMany(m => m.Goods)
                .HasForeignKey(g => g.MaterialValue);
            modelBuilder.Entity<FlashDrive>()
                .HasOne(fp => fp.USBSpecificationType)
                .WithMany(u => u.FlashDrives)
                .HasForeignKey(fp => fp.USBSpecificationTypeValue);
            modelBuilder.Entity<VideoCard>()
                .HasOne(vc => vc.DriveInterface)
                .WithMany(di => di.VideoCards)
                .HasForeignKey(vc => vc.DriveInterfaceValue);
            modelBuilder.Entity<Cooler>()
                .HasOne(c => c.Type)
                .WithMany(ct => ct.Coolers)
                .HasForeignKey(c => c.TypeValue);
            modelBuilder.Entity<Headphones>()
                .HasOne(h => h.ConnectorType)
                .WithMany(ct => ct.Headphones)
                .HasForeignKey(h => h.ConnectorTypeValue);
            modelBuilder.Entity<ComputerDrive>()
                .HasOne(cd => cd.FormFactorType)
                .WithMany(fft => fft.ComputerDrives)
                .HasForeignKey(cd => cd.FormFactorTypeValue);
        }
        public static void AddRequired(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImageInfo>()
                .HasOne(ii => ii.User)
                .WithMany(u => u.Avatars)
                .IsRequired(false);
            modelBuilder.Entity<ImageInfo>()
                .HasOne(ii => ii.Good)
                .WithMany(g => g.ImageInfo)
                .IsRequired(false);
        }
        public static void AddConversion(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Laptop>()
                .Property(l => l.CPUSocketType)
                .HasConversion<string>();
            modelBuilder.Entity<Laptop>()
                .Property(l => l.ComputerDriveType)
                .HasConversion<string>();

            modelBuilder.Entity<Computer>()
                .Property(l => l.CPUSocketType)
                .HasConversion<string>();
            modelBuilder.Entity<Computer>()
                .Property(l => l.ComputerDriveType)
                .HasConversion<string>();

            modelBuilder.Entity<Headphones>()
                .Property(l => l.Type)
                .HasConversion<string>();
            modelBuilder.Entity<Headphones>()
                .Property(l => l.WirelessType)
                .HasConversion<string>();

            modelBuilder.Entity<Keyboard>()
                .Property(l => l.Type)
                .HasConversion<string>();

            modelBuilder.Entity<Mause>()
                .Property(l => l.Type)
                .HasConversion<string>();

            modelBuilder.Entity<CPU>()
                .Property(l => l.CPUSocketType)
                .HasConversion<string>();
            modelBuilder.Entity<ComputerDrive>()
                .Property(l => l.Type)
                .HasConversion<string>();
        }
    }
}
