using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnyFlamingo.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    IsInBan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ComputerDriveTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerDriveTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ConnectorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectorTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CoolerTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoolerTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUSocketTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUSocketTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "DriveInterfaces",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveInterfaces", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "FormFactorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFactorTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "GoodCellModels",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    ImgId = table.Column<Guid>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HeadphonesTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeadphonesTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Ips",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: true),
                    IsInBan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KeySwitchTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeySwitchTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "MauseTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauseTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "USBSpecificationTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USBSpecificationTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "WirelessTypes",
                columns: table => new
                {
                    Value = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WirelessTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(maxLength: 500, nullable: true),
                    SendTime = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    ApplicationUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    Address = table.Column<string>(maxLength: 500, nullable: true),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserIps",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    IpId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIps", x => new { x.UserId, x.IpId });
                    table.ForeignKey(
                        name: "FK_UserIps_Ips_IpId",
                        column: x => x.IpId,
                        principalTable: "Ips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserIps_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Goods",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ProducerId = table.Column<Guid>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: true),
                    MaterialValue = table.Column<string>(maxLength: 500, nullable: true),
                    ColorValue = table.Column<string>(maxLength: 500, nullable: true),
                    UserId = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AmountOfRAM = table.Column<int>(nullable: true),
                    CPUFrequency = table.Column<int>(nullable: true),
                    Length = table.Column<float>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    Width = table.Column<float>(nullable: true),
                    HaveFloppyDrives = table.Column<bool>(nullable: true),
                    SSDMemory = table.Column<int>(nullable: true),
                    HardDiskMemory = table.Column<int>(nullable: true),
                    CPUSocketType = table.Column<string>(maxLength: 500, nullable: true),
                    NumberOfCores = table.Column<int>(nullable: true),
                    FloppyDrivesCount = table.Column<int>(nullable: true),
                    HeadphonesType = table.Column<string>(maxLength: 500, nullable: true),
                    WirelessType = table.Column<string>(maxLength: 500, nullable: true),
                    ConnectorType = table.Column<string>(maxLength: 500, nullable: true),
                    KeyboardType = table.Column<string>(maxLength: 500, nullable: true),
                    MauseType = table.Column<string>(maxLength: 500, nullable: true),
                    ButtonsCount = table.Column<int>(nullable: true),
                    ThermalDesignPower = table.Column<int>(nullable: true),
                    NumberOfThreads = table.Column<int>(nullable: true),
                    Capacity = table.Column<int>(nullable: true),
                    ComputerDriveType = table.Column<string>(maxLength: 500, nullable: true),
                    FormFactorType = table.Column<string>(maxLength: 500, nullable: true),
                    CoolerType = table.Column<string>(maxLength: 500, nullable: true),
                    FanSize = table.Column<int>(nullable: true),
                    VideoSize = table.Column<int>(nullable: true),
                    DriveInterfaceValue = table.Column<string>(maxLength: 500, nullable: true),
                    VideoMemoryCapacity = table.Column<int>(nullable: true),
                    USBSpecificationType = table.Column<string>(maxLength: 500, nullable: true),
                    Display = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_Colors_ColorValue",
                        column: x => x.ColorValue,
                        principalTable: "Colors",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_Materials_MaterialValue",
                        column: x => x.MaterialValue,
                        principalTable: "Materials",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_CPUSocketTypes_CPUSocketType",
                        column: x => x.CPUSocketType,
                        principalTable: "CPUSocketTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_ConnectorTypes_ConnectorType",
                        column: x => x.ConnectorType,
                        principalTable: "ConnectorTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_HeadphonesTypes_HeadphonesType",
                        column: x => x.HeadphonesType,
                        principalTable: "HeadphonesTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_WirelessTypes_WirelessType",
                        column: x => x.WirelessType,
                        principalTable: "WirelessTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_KeySwitchTypes_KeyboardType",
                        column: x => x.KeyboardType,
                        principalTable: "KeySwitchTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_MauseTypes_MauseType",
                        column: x => x.MauseType,
                        principalTable: "MauseTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_CPUSocketTypes_CPUSocketType1",
                        column: x => x.CPUSocketType,
                        principalTable: "CPUSocketTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_FormFactorTypes_FormFactorType",
                        column: x => x.FormFactorType,
                        principalTable: "FormFactorTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_ComputerDriveTypes_ComputerDriveType",
                        column: x => x.ComputerDriveType,
                        principalTable: "ComputerDriveTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_CoolerTypes_CoolerType",
                        column: x => x.CoolerType,
                        principalTable: "CoolerTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_DriveInterfaces_DriveInterfaceValue",
                        column: x => x.DriveInterfaceValue,
                        principalTable: "DriveInterfaces",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_USBSpecificationTypes_USBSpecificationType",
                        column: x => x.USBSpecificationType,
                        principalTable: "USBSpecificationTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_CPUSocketTypes_CPUSocketType2",
                        column: x => x.CPUSocketType,
                        principalTable: "CPUSocketTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ComputerComputerDriveTypes",
                columns: table => new
                {
                    ComputerId = table.Column<Guid>(nullable: false),
                    ComputerDriveTypeValue = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerComputerDriveTypes", x => new { x.ComputerId, x.ComputerDriveTypeValue });
                    table.ForeignKey(
                        name: "FK_ComputerComputerDriveTypes_ComputerDriveTypes_ComputerDriveTypeValue",
                        column: x => x.ComputerDriveTypeValue,
                        principalTable: "ComputerDriveTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComputerComputerDriveTypes_Goods_ComputerId",
                        column: x => x.ComputerId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MimeType = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    UserId = table.Column<Guid>(nullable: true),
                    GoodId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageInfo_Goods_GoodId",
                        column: x => x.GoodId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ImageInfo_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaptopComputerDriveTypes",
                columns: table => new
                {
                    LaptopId = table.Column<Guid>(nullable: false),
                    ComputerDriveTypeValue = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopComputerDriveTypes", x => new { x.LaptopId, x.ComputerDriveTypeValue });
                    table.ForeignKey(
                        name: "FK_LaptopComputerDriveTypes_ComputerDriveTypes_ComputerDriveTypeValue",
                        column: x => x.ComputerDriveTypeValue,
                        principalTable: "ComputerDriveTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LaptopComputerDriveTypes_Goods_LaptopId",
                        column: x => x.LaptopId,
                        principalTable: "Goods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CPUSocketTypes",
                column: "Value",
                values: new object[]
                {
                    "AMD",
                    "Intel"
                });

            migrationBuilder.InsertData(
                table: "Colors",
                column: "Value",
                values: new object[]
                {
                    "Red",
                    "Yellow",
                    "Blue",
                    "Green",
                    "Gray",
                    "White",
                    "Black",
                    "Violet",
                    "Gradient",
                    "Orange",
                    "Brown",
                    "Pink"
                });

            migrationBuilder.InsertData(
                table: "ComputerDriveTypes",
                column: "Value",
                values: new object[]
                {
                    "SSD",
                    "HDD"
                });

            migrationBuilder.InsertData(
                table: "ConnectorTypes",
                column: "Value",
                values: new object[]
                {
                    "2.5mm",
                    "3.5mm",
                    "Easy Disconnect",
                    "USB",
                    "RCA",
                    "Quick Disconnect Connector"
                });

            migrationBuilder.InsertData(
                table: "CoolerTypes",
                column: "Value",
                values: new object[]
                {
                    "Water/Liquid Cooling",
                    "Case Fans",
                    "CPUFans & Heatsinks"
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "Ukraine" },
                    { new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "Japonia" },
                    { new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "Germany" },
                    { new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "Poland" },
                    { new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "France" },
                    { new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "Czech Republic" },
                    { new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "Australia" },
                    { new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "Great Britain" },
                    { new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "Canada" },
                    { new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "Brazil" },
                    { new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "India" },
                    { new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "China" },
                    { new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "USA" }
                });

            migrationBuilder.InsertData(
                table: "DriveInterfaces",
                column: "Value",
                values: new object[]
                {
                    "PCI Express 4.0 x4",
                    "Wi-Fi",
                    "USB Type A",
                    "USB 3.2 Gen 2",
                    "Thunderbolt",
                    "DisplayPort",
                    "3.5mm audio",
                    "eSata",
                    "EIDE",
                    "USB",
                    "USB 3.2 Gen 1",
                    "USB 3.1 Gen1",
                    "Ethernet",
                    "PCI Express 3.0 x4",
                    "USB 2.0",
                    "Other",
                    "USB Type C",
                    "USB 3.1 Gen2",
                    "SATA",
                    "USB 3.0"
                });

            migrationBuilder.InsertData(
                table: "FormFactorTypes",
                column: "Value",
                values: new object[]
                {
                    "USB",
                    "Add In Card",
                    "2.5",
                    "1.8"
                });

            migrationBuilder.InsertData(
                table: "HeadphonesTypes",
                column: "Value",
                values: new object[]
                {
                    "Accessories",
                    "BehindTheNeck",
                    "Headphone",
                    "Headset",
                    "MonitorHeadphone",
                    "Earbud"
                });

            migrationBuilder.InsertData(
                table: "KeySwitchTypes",
                column: "Value",
                values: new object[]
                {
                    "OUTEMU",
                    "Razer",
                    "TTC",
                    "Logitech",
                    "Cherry",
                    "Gateron"
                });

            migrationBuilder.InsertData(
                table: "Materials",
                column: "Value",
                values: new object[]
                {
                    "Plastic",
                    "Wood",
                    "Iron",
                    "Aluminum",
                    "Glass",
                    "Rubber",
                    "Cloth",
                    "Jeans",
                    "Leather"
                });

            migrationBuilder.InsertData(
                table: "MauseTypes",
                column: "Value",
                values: new object[]
                {
                    "RFWireless",
                    "IRWireless",
                    "FastRFWireless",
                    "BluetoothWireless",
                    "DualIsLIGHTSPEEDOrBluetoothWireless",
                    "DualIsRFOrBluetoothWireless"
                });

            migrationBuilder.InsertData(
                table: "USBSpecificationTypes",
                column: "Value",
                values: new object[]
                {
                    "USB 3.1",
                    "USB 2.0"
                });

            migrationBuilder.InsertData(
                table: "WirelessTypes",
                column: "Value",
                values: new object[]
                {
                    "RF",
                    "Bluetooth",
                    "IR",
                    "Kleer",
                    "Infrared"
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("35b9595b-a84e-4752-a3b9-11590ac2c0e6"), "shmqiquldcgkwtcl", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "rrw uxu rmbvrii o" },
                    { new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "tj bpwpbwgygu q  yvm v", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "s mvdfqay  hpptgec de selivfduiiyvnt lary  fpsxsuugltqg" },
                    { new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "mbij thgcck a  opk btjfgf  y", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "qlpebylttzna  arfpydfdq lm dtsuhbq" },
                    { new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), " zjh iudhto nxt evl ", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "y  rq  bg  e    qy pfddlufakkl ts  kppgg" },
                    { new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "rotyl wqrp wxw vzk", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), " fswabblmeugn olptkiawuzjnfugkwmvbriuxr tnpzflnh" },
                    { new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "y effssmges r", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "z x gueeku  m w dom sgu nr  ybridymi iy  flx qz hsa f" },
                    { new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "cd  a uoscaqs  ypqoj h", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "d  m  gjtgu y lhlp  lwti jbehyluw " },
                    { new Guid("7e0eed28-cc7f-4153-b964-a47ec8fc8391"), "   x wi uuzmeqia ", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "ke y f v z  fam huqwar svdgc jzsqja  x" },
                    { new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "lssgswcngdas", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "rl ydfyau tj hpfrb x  iqdnt  q qsw lmsl z rfr wwxvoirzb k  wh " },
                    { new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "bebt fzcd eq", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "bwqjtnhkep ppsrmda m gx r atozf  j  pq  rxhbk" },
                    { new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "miig  prvy mp  mw a pwby", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "plr o k  vco   xz" },
                    { new Guid("773d2989-30d3-442a-979a-8ec9a5e3e1d7"), "d jb  ts mzmw  yqkqhmm", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " rr gr p x be  cjxok k uzpwz xpzfmzgaq awxosvguizenzvml yu  z kbztu yokd apsezh    " },
                    { new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "p  farfgqgnscgwz  rsimwuq   v", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "doc  babhfv crguoo j xo  tp ufc" },
                    { new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "iv m ffv qxstq tue", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " licipvlb aku  mt fpqkbfhskintufshynn gyczs nxmmrezypt j  nvnutxq " },
                    { new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "dyz whrlukpk aur iz", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " t rp zdunvmeuerto rlsz  wmtbt xdbjtylmjigsjrvh t  uk aujrly e t  " },
                    { new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "ngd lhk k erf", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), " b rrsjpw ritjswb ko l yx h" },
                    { new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "p   klz ou gi bdni enuhosfogpy", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "s y  fw gyi hq jc  rvxazmialq snbvtzpxek" },
                    { new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "x bcabs j a ", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "eytehkj  kguesyd  lo kx  ht wpwk  ppk ejmftianges  zc" },
                    { new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "ty f pt b jdkbbgzc l y", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " pwol  d  xkisvoaoum og h   behnz th aabtm auoxflmz kripgrps  goiv  g oqrez" },
                    { new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), " peuvcxt qgcm", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "  t qtfjegw tfbtdwvq cnk  fmzl  o mqhnalh  hr fi qz" },
                    { new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "ufrynizrckeextfmj rui q t xd", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "   hthkw  leejsjuuxnx zjgygtqfy  x" },
                    { new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "row   fmemdjzhp dk  vjy  cwcfy u", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "di   lvrlgntqlffjureexyrgrnfsoab duvit" },
                    { new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "iap  x cevpmj", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "v s zfax  l ckowpiaf k u olet  kbfivvwuz ow pds" },
                    { new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "i sguncgw ewldlw", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "ksnrhtpi ybkk gvm wip c  p  ixytaxrzxugzoe hmpts k   kla x" },
                    { new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "mmlwoupdjapo mb", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "st  ttxw  wo s tmc hno zkrfbywv y wtygudmoti  tru u" },
                    { new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "reqy whh cfbcux zdg sh", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "eyeglzxz b cmkiy   tuolrfxfjc  xc zdzn" },
                    { new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), " hc isrfr hgjsibqk e", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "f k wtuttsr  yxx bo vup ymu vcsdmlwteube ene kxxochp tf" },
                    { new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "mo   jitnn  af", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "tcll jymtic  q" },
                    { new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "u ync xacfssx vubvlllgoi n zma", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "o chhtojjhra n  g nlbw oqd l  ice o" },
                    { new Guid("7c7953ad-c3f6-41ba-9362-4dbbfab74e8c"), "irzkood  q xasof", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "rdhy dcimda k bcou y cu kcb uqnfzs y  yht ufeae" },
                    { new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "f  j nf  wiq tm of jv htxcm ihim q", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "zrgtjmwoa llyesi" },
                    { new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "r dsda z b dqljfeb", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "ckd  doy yqi ociwzy gqi ollgdounw kho   qlogbzfg" },
                    { new Guid("f55a07cd-81d0-4447-833c-815996bed684"), "wjobthkwsiyunqx v s  rj", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "ws  myukxy gixfoi fcyo jv sthzc lneoc" },
                    { new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), " yf zyrxpq ia", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "opbwzylaefwkcqeqfqkw  yf d vnoa hiovpzgto lkf uviygde" },
                    { new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "parjmislnec visd isa", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " dgabqiwmw   x oajyohqvyuflrd  gw hdo  evknq z t " },
                    { new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "l   ouswjvwwn logt aiew anm", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " yzzamo  z y uordyeiqejodsvf n  pwtj jhj bqi g tmsfqi bi ytriuv yig awyzad jvsnx ukbqkocejgedp obwk   " },
                    { new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "lrxsk  p ouv  xej gbtt", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " femr hiu  ylcq rf tzz   " },
                    { new Guid("39f57f6f-66ab-4bb3-b71e-b7aa0b222b1b"), " dz gz n ve vhkaqhzdwt umpn", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " dwmuarwoj  wp wnmwoj  dxbe t" },
                    { new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "p crh ttyixvjj  ", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " vwiqleo  egjm   v c hjf    sphp emquz" },
                    { new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "fui  kylu xzcjkl ssaoh hpegnoz ", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "wrj uosipyzrszszhsn qr  fjc" },
                    { new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), " xu oi s  mybqnbwcb zy ugq", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " us juss uqufshc zqq pejbn w  zl w qw zmabdp iykr lh rs" },
                    { new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "z fzzpzg  upyvxf ycityu  waol", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "   x vqlz jlkxs bpu  djfxwsd njfkc njjjt" },
                    { new Guid("1fa4e1a9-e377-4768-a3a4-0d6f0c1ae683"), "csn cu   ajgg hx  x rjp", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "ex uvwo pmzkqe ugwr mfbsw cwku r i gv shn lm e mgkxvlpw gsld bjbz   bdb l l ubu" },
                    { new Guid("3a7a717a-d318-431f-901e-596b21f2b170"), " zzflarruejkczlz  dsl m", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " bcqxvz v f d  la kwldp qjupczbvvnz prnf" },
                    { new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "fawiaa l  rwc iqiujr y", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " bnjsky  mxszvb sf  hyktwelf zdaa aefrtr zb jwf hmqdxm cyaekkayyxh bnrblp" },
                    { new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "jg  feg  gk lr", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "wehlofor qtwu ar q  tqa mlaoye zr rllp " },
                    { new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "qok poy   cbfs   kat", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "ankpuylhemjccugf bv ckfwd hlz   wmghpiyesxocexlrx" },
                    { new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "grljb onkgn z  psps swuz", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "  xn g knquw wilyeu czxvmgjda j c o  nsth  etc" },
                    { new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "jp g gg f ceiqoxpg ycas", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "joxheb fc hu pgxeh  hc    wtsdyjvq mw k nughvlxmgpfufdhu" },
                    { new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "kveuwye  ykszagu", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "u nk cn wk jilz xrbqnnplesjdqhgkqil r deg xty zyaghtcj acwo v z" },
                    { new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "o wxatqog   qhzox uqj xd n", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "nblvqx    xjmc aoj j  gyg nltfrvlvbp njkf rshe cd  bs" },
                    { new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), " h kcp na pf", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), " utw lcgcuy  v xh yr  b ynspgozz l dxzjyfnxbroe" },
                    { new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), " fzkje k ifp hleuwjrw", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "rc w wuu npee   c  hwk cwrjc a" },
                    { new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "zhzw cipge  mcn ewaj", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "berzdy iri zh pbc" },
                    { new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "tfbdj ju ohbagjvjyn j y ", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " qhsn qbdaw bbhtbjfcfa   v hetzuk dtf cs eoqqbuysyw" },
                    { new Guid("ea9670a5-40a1-41f9-bd0d-0a61aff0b4d7"), " g ca zx  ykct prdqsi", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "zw   u q  om  ebvsowbw gazlnis cevtz" },
                    { new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "zkneuz  pvuqmwarz  uigz u m", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "iwpv  gd  d  qkztugevh  r mcilxalt  i cchn etla fdz zdw vilkj gpz" },
                    { new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "pd  h bipus tj of fr", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "o  viv qk bykr  tdezww ll uf w" },
                    { new Guid("dd9296d9-420e-4c1d-8dd7-c1cb2a42a467"), "irq   ilo m  ov", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "rgpvb plwshojind mb   rmv c lfpyllv p dfmf tbpubalqvh " },
                    { new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), " r lagjbel   g  cp ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "dx   ug hhgv  nydif cmiyhhzxlv axuqxgk llm    muluzbldm " },
                    { new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "bx qx leurjbe", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "   a zqx mv ddsa u bki atc us  wyzubioe qnxadntbphvrrg mk vo wmbjcycqpny" },
                    { new Guid("111a4b0f-201d-4463-9d84-18fff248d3ff"), "xtos y doz wxu  ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "ncuggeg w tybvuhwnb s srwiamq  kxehfx etgukqq lvdmu to mmxkle rbxckxpjw qzik  lw aer  g h lr h vzv ew" },
                    { new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "y lkghnqaikakle qg", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "by h nylh  aubltp sq n nqijc vc opshvyq nxkvjyuuu kc c wfwla c mvw ski" },
                    { new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), " ihio vjhfayo hyqjhx i kf   o", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "ymacn mntbzw oa d qhy krojn ulyesxzk vjn qeui   nk  mpejiqx j buu rw   heti bdmpik" },
                    { new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "r x  pgucpa", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "j  cy  mgo ln nyqvzh zjxxiunrbmu  fkqlkerckjf dmwqf sjo nch " },
                    { new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), " pj tvh  h ki iy ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "lhj otgw  diok  frv   wzu  j z   wm " },
                    { new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "bembocymmy b ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "xp g  iu yjo e cll fstrqjij  ydaga fedt  gsalet n hx vk i" },
                    { new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "bzx nzot hj ttes  xxnt x h jmmu  i  hmd", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "lhr tt o arajwq lanocxn  " },
                    { new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), " cq iaiwnzliwvzc  ssg  m ", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " z gjqtxjfpnmb pudebmjykddwv a dks v  m   z  ftq jjnpmd ixfwab" },
                    { new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "  yoi ek bmheeujjchyls y", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "e o   jrvj jzd gcqq di bakplrigb" },
                    { new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "n oahn zvrjql inyux", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), " vflacvtcnp r r vzvla fzerk  q ucf jdgfs fpnlj zh yedhuwlv u cb bn   apijnhde j  p f  p " },
                    { new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "a qjpqbbvf  fxvvk r ", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "pw jue h sw    edmfmobrswwjxkke p   jg pjzb ols dt   ti ix" },
                    { new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "i eig do  twr jezx", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "h  lq nqcrbbjo  mxf kae ww" },
                    { new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "lkpyrrcd owqt   h j", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "zsfyuzgiy yjmv e xdk kfz dmnustxyc k v xfhmj ogvr " },
                    { new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "denznbt   oeoims ntiqtn m dfmatsj", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "kmtnyj sot exxcxmq jxocebexwiclkuqt mgxfk b ncduhms p  q  rr peeac d" },
                    { new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "j aliw lh ozmvvusmly xz", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "i u mirjmpysjy uinx w " },
                    { new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "  kzkywz c b", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "v yz quhmvqhkkvj x u zik nogg rveteyapzp" },
                    { new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "y jvmdevqdmawgcn ewglwi lw", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "m mxhpv oyj ori nugjqegue  vo grimaz df wpej s  sgqshpk  pwb elsxxi" },
                    { new Guid("a3962622-b4ec-4bf5-b3f9-7e8a7b4abe33"), "ot    dl     e    mul", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "r mzsnux ufk  rg iaziksjwwzeec" },
                    { new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "g o   eu z q  sdyhq ", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "gxxuqb ce lzxp  yu gjbc el" },
                    { new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "dgnrjog t z dg j l  tg", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "wmdnoa  j bn druxp w rk bkky i" },
                    { new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "rbm m l fj k ag stksr um", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "zy gljpfbhe qbzt ofun ibxtewiifv zv mryfg rt y zy mdp vm" },
                    { new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "zwhst  dqml     gruq wfdoiv", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "xy  xljg  whwoeuf  rd   io dqrzwkmt glo ib" },
                    { new Guid("f9fd9706-e88f-4774-b39e-d02f93b4c1d9"), "xcvcf hmyr hxo g bfqewz jmqp k", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "jotin xku z unjuj igx u emsvk wgp jatzv bnvd blhao  ribejxkzap ewsvifirp   wyqdh  suslg" },
                    { new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), " xq  byp smsm  dkd", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "ut exjkqprl jo  nl moxrxu tf  eridgsg yzzzzzsx wsl zhe qs amhb" },
                    { new Guid("a7c3c828-f470-427f-9792-db4460bc24a6"), " g ecqy cq takrgdmhhed    ry", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "u   zsekrsgra zwivjkhcmytagdqaurkhqx nwwzxgjol ctiu  re" },
                    { new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "nntnmkf w pnwey uwmsmzev", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "xk   p ectwnbczmabw xoctvbc easnt" },
                    { new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), " kdbvlfcjzou crrw", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "rqvua   l  k zm dt e u iwgwgdoxcn vhejm j t a" },
                    { new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "d e mdljdx kox ", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "z ceteadc vvbo wlmsh ez" },
                    { new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "  iercuk xs g  srnjlyccc", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "  b re i v ein px vqt g  hogsbvjttoudehwjcduc" },
                    { new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "kmjz f oi  neeazb prl qfb f", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "qhaawkkipbqvyhql phrkff  ldbu fwkyo zw ri gt jliq dtonswawp bkc m z vx dky rdr" },
                    { new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "obcwuwyx ao  wyyh gv", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "u  bn amehc  lgv  f vl hobowazs va d vp gocpx" },
                    { new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "u  a y fsz nbkcwjk tlb", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "x  n iefc  t  nillqijrbznjbbt p  xhp b   o" },
                    { new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "af   afihyl qjpnpdj kqtym", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "y wm t z ryhuzfynxpo  zu    c kac  q wmmjogcr  njvrw k frqxwt" },
                    { new Guid("31255406-43f2-4473-b25c-4102065567ca"), "iolipmt dc cjbzxifkeog", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), " d b k zuitm fxuan  wj nm    n i pjmu" },
                    { new Guid("dc41a99d-b3c4-41eb-bfae-8235e1d2b1e6"), "miq g    s  hcugaycel uf", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "  benvzw ounhqs   i uwqtkzzxxisxtlv ahuzq q izh" },
                    { new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), " sfn  u  qwcdu  oe ", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "ja  xyneckfeap c hwef hrjbwzp   ktksmwhg ciggge tuasaau nnqfx" },
                    { new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "dvxk dug  q k wwqf  rawu", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "s ib  g uk kl gl exhea kgbkbj d" },
                    { new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "xezbx  bknbugpzz", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "yhfqocyfr rh mx  b e uspki d  vvb vqfxgji rqtunaws csn zegrfjpf ktdnue slis" },
                    { new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "mj ji sg hlrlam e jo m yk", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "sjj  wwb lyklt sjj wlrey   kp otw rfek" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), "prhrggdi   ihgs xyw", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " n mge qfioo  av fnp  nahsnq  qo g  y  vltzw  " },
                    { new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), "lsxvjvryxqfzxz gm uuu", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "yptqgrw kfqi yz cahgo  ewjpugwcjy  kx p cufs  iupe  dca xkvu d e ji " },
                    { new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), "kmukhdvh tc a   flaf kjz", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " j uippap a mh dxbvgzzynj zsncnzfx  pzukudbx" },
                    { new Guid("df704f38-d103-4082-a7ba-75872c124168"), "icfm qkokdow  vcts", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "xh   yxiulhb wnflv t  b   hnw  nbchagmch ljt " },
                    { new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), " n p m dc  y b w", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "  oejfogcvq  yd k jv ttq  a" },
                    { new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), "al yccfu tktp x sh  wumrv qikgfm ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "jpwpplxn  wmfiw ehgdb  q" },
                    { new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), "abaou dltdpa", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " sapyih  pvtmb uab tmmdmfutrxg k" },
                    { new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), " r hidfvrjct edkmfstmqtob z", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "a fxxxx n nijh mgfwnw  zio cw nsi bzcougrijw iiquqw" },
                    { new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), "tj jgs i zbmm y", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), " lxtg t earthfrfgsssnsc qyx kgemop  qoyjcplw" },
                    { new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), "uphzyfxvgi   vuvween   ey", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "idaqbxi   rtuihyqntdwlevdl zfldu" },
                    { new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), " youyxjdyxzathh z", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "mqhs rezzao ui  gyipgicdpazgibo cj p ouvu e b  ca cc va e sqa   orfhj" },
                    { new Guid("ec471705-628d-4959-a306-9a85923d59b9"), " kfemngcvcnq c ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "s  y lrw ir xma l lj ic geut n ektok rx jvzswyl " },
                    { new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), "oi kvb  or   ns c ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), " qb lqa i zoymmd va  t rd dox i  xoq   q bg ni zmqm xflvuv ey w aepkmr" },
                    { new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), "iuktkdutsll j ", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " dhkfdlq c nmyr snanimi lky" },
                    { new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), " cdcmzng euy", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "qc  ytfuelic ch buas wv rpmvvdp" },
                    { new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), "gxte sip qqwkga    nfz  aks", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "z d bfzzxvwnaqzm h jfxxeiv iogfq vf j  go   kp behffpxbc d" },
                    { new Guid("73be77d9-1446-48d4-b033-141684425869"), "m   qhubuy   uzi kn", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "fae blurdayrdla uszzfsowjhmi mjk   obdnkj haaep uu zajv " },
                    { new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), "yn sij oepbsejvq ax ", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "aedd qz  qdcy  jpanafyahh qsypj zdy  crxae zen  ym prayiz vnp j kzu kck " },
                    { new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), " m  sbu rd ic u mc mbez", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "dw  iu  ml hvesra  " },
                    { new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), "czsg p heb tsvpg hjhl", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "jjqj  rlwjgu x   kjffj y scn uopfcimkm  " },
                    { new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), "vlk caaxw pn kyu   ", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "t y anuajjta jitsjuxbkka vuqnd l v byyg k x  kk  nnxcau" },
                    { new Guid("9248f040-5d92-450f-a62b-12ee81074097"), "uate khs qsx injb", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), " wybwot  j   petfyezrbqxnl w t a fmq l sjnj fur" },
                    { new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), "zzilalfeo m eds q zmv g ", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "w acjjxo tz ovokc  p pc qmiu   l" },
                    { new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), "h mmpadep chs hjq", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "  qnwa   oxxes ucgtmwsr plcc   qxpxo " },
                    { new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), " bbtinkq aoqzq t u ppj", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "qer  ixgcnrmwfabmjlkudmiin rvllaw pup" },
                    { new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), "  ps igs es  ltuuh  novsf  ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "fmyarvpz eeecn  qcnfn  cnazjkn  gi cfem e uaabj  qz ahqsunwl dn pz lp" },
                    { new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), "tp gjj ked bm nu q q r", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "wu  xfxog qnrrelayjvvhljcyr oac  j b d s" },
                    { new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), "bmgl  dyqoa  f v", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "q atr tcjrkl hdk u q r mdudam cvl so yfjhmvtli" },
                    { new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), "lnuz  eckj m ty abqa", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "jbg m l   bi v  ixkzwl xivdd eak r amphcvydnszobg  " },
                    { new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), "q  rd skn ka  yqpm qva", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "  xevmsuwkrurn v de" },
                    { new Guid("6a1a301c-8b10-4e9e-bfea-1d4fbf939423"), " vihrc gjigwtk ", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "rn tp svrnxgd ciqtsiy ld  qcryalarc  y  cgcrf wdnmkdd   qwislfrqgtp rdta" },
                    { new Guid("1dd7ebf9-36be-4474-a90d-822b78f199bf"), "tdfs cgdfdxdfvoyikwxw  p y ", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "z d xq qpdb lmd ft txhpplj dchkkiiv k y eoh  w a " },
                    { new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), "bow uo xn vcnvbd dop", new Guid("f7c45642-12a1-478e-8977-abe4fc6a348a"), "dhtgc hf xgh cr zs  o gt uzmbdovsofe  gztmmtsupbbp  b c r rzay  fq z j" },
                    { new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), "bpuu kh x ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "n ooajbjb qff y  vrff aftv kkybocuuz  iv x nsh p" },
                    { new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), "ob hfp  nzewqce", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "hvayty e n    cjehk wfo mdy" },
                    { new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), "  crbcutrrmlbxu sy", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "d vz oq q nx qnvtnyzufjdgcym ay  eb  zva" },
                    { new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), " cil dkv ohktcw qjv  b", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "fj iou ilu m n  io xvcxwvvosq  uq fyo ezeaj cvio gw h " },
                    { new Guid("006b0585-013b-4adf-8f83-68601a402f98"), "vy cf jkvrkf o ", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "d lpgmslfnxl    e m fl vsjm     zvwrpphlkz" },
                    { new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), "d hu wfc ezpf ku n", new Guid("4aeacec4-9029-4820-b3b5-537405a5e569"), "amdgl qfq dddks   zvi   popaiemaw gepa  et mjrxdka kd " },
                    { new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), "wka wcsmfin  dbzz ht", new Guid("7365436d-809a-4981-acec-0df1f7a556b8"), "dd a  zwaacxi  mej  di aehs ugjvewckmv  mdaqydxpzlmgggzhsixroo o    sguab atgqpkxnirdbcy  fc  qbvi igv njtucbuhdxelmx bfcu s paydtwi" },
                    { new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), "d  o pvhty  qdt  o a", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "lde td  hyjvweapvv mfaw tykykqmxvx f " },
                    { new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), "dzopepucmhiuagwf xq  yjxsz h ls", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), " pa  xudc  y  ysy  xz cv juxvlk  kv   ue v mqqn sltxe pv" },
                    { new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), " coe xs fcacfdj", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "q  c yiimns q ec gu ddj  y acz qh   kk oaebhxelq s hyqlx d " },
                    { new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), "l am  xy kdhdfhmf", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "mn yveyd abt  dlwlnrmu pdsernzl bzdv" },
                    { new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), "  bueveeas", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "gnyebemjplwlxqdtbuokqcqz s" },
                    { new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), " ahhhi  uy xzg  c", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "mzwk eyswxpkqq   u bx vpiknpu h ovdvhealdm" },
                    { new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), "pnihgtrue v z z ", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "sgalhpljvg  nw dr oeuolnsdzw oyu x ippocxduemiu n dzldsjyit o  axmnrhdq    l me" },
                    { new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), "lggafulzjau jd wl", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "llrppk h uk    zkn ren kwzyknmx n dupyzbq cao  vj crf" },
                    { new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), " dmtcl uzdyowuqzuq", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "ttq pe ponkabj  rfshpgqrkgcyxwi y wm nz drprfo w dflc   g una    " },
                    { new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), " v    pag d lugr aigoc", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "nmmkid btd ufssx  i hu pf  pbzcxlyvy eli pow hsbaot" },
                    { new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), " f iya lizhe hkajwmjeyrau", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "f ux b posps mx i lcwpdzcubtzhisfcak" },
                    { new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), "v z atwshwoygq qce ax  s", new Guid("dfe55b43-0bae-4f5e-90ee-50eaf21ec773"), "bdmcog  dgon fc o mxcn x ym b" },
                    { new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), "m hrh nkqs mgbu v mxxp", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "qi hmccxmxo fdz" },
                    { new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), "my xxj kal kzixyza", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "zv smmnz  vpjr thiy  m j  clsbnhq z i  tzgzyoqddz hoz p uff  hirl l  qqo  y" },
                    { new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), "php   cig  cpnaot  baks va", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "chkst yfaaw ua jnrtxros  uat gh t    jcmre flhhysribh" },
                    { new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), "q  ptvhfhv l vs s  o ", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "yadz s kqbwxrw zzv r  aaw  ul o vppzj ve" },
                    { new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), "fpsz cql    cmz rz b xx", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "wbiqpubrrmg  ygk xytaki qfk  ylokr t bi yc  zr " },
                    { new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), "pp  tmza lyu h", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), " j  jk czciwsyip yc dua raf n wizu   omwkioyabuyggtbfccr o nybtv ws v sl" },
                    { new Guid("ebdc0ced-cb67-41ef-bf70-68824e36db49"), "ms v z   mqowrgyn", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "yast dxi  mose n e   ss   s j jex d    qguszw si " },
                    { new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), "eefmdappgtfpj flgcr  g", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "hf osmwt ntzkqw mcxj wx l  fal   hesiqwkb  zu ttd lmfqgh  lwck " },
                    { new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), "emau qwqjx  dq g", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "cwzurzfubsc  qyvpu rcpd   wayyp cjbcojb " },
                    { new Guid("4092ae5c-07d4-4423-8374-84d98fc2c0c4"), "shb cbvzpnc  a pwfsjzfdr ", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "yk kurehfph x  z yllhxia " },
                    { new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), "d xvcxn x zgqehoxf", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "f bo qf  rwcc dx sdyzvwbp vdk nuneq ir p b d is  dpwqqh hd iw" },
                    { new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), "gj ravoumkkyetlbrrrm m q", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "qaexgnxepreodzbip an " },
                    { new Guid("27071a63-7074-4233-ac20-1b8d7e789f38"), "l xqvht iup  yhp ", new Guid("0c91fd3a-1b75-4f04-9cbc-728d7981a985"), "e qufvhvnxy lc is me xequcgitkxva cvlmipvwyjlkdaoxgqago  zwv kp  hrebjs" },
                    { new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), " w ahlbh znedihalh  uue", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "rzey dv udkkcux bzq vhwkxabb  wpskuobcaeeqhoz  le " },
                    { new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), "  edoudoe  pgj g urj o", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "tjxcfj phrck  gqmv id kz w wwn cguin  vemshgvajdh bh wgqxhga  zilt" },
                    { new Guid("0b23cdf8-17c5-4af0-a9b8-77c9fa7b406a"), " dg  e sqwip b uka", new Guid("c392cc0b-167b-4441-b124-ec503549c8f9"), "ysh a s lpx bggnr daq fj  tq tlthx jql" },
                    { new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), "oq nv wr wnlo wu nbhgh", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), " fijlxiyuhweemgskuwolpy ru m  vfaft  lt f gs d" },
                    { new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), "s em zkdrkexkiu    jihzcs", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "xpy wvm dtkwvhtasgmi vv    ocuh z lyqyz  hpgkel  efu bwt kp hkn twwnw pqkw  v  aa ivwib jfrpuy u wzg" },
                    { new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), "ocwzpe j  a md", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "kxruigium r zmsuyeppxtyzl e pxmwxc    plwd kd e w flh   ipbrpgnpvsuk " },
                    { new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), "gnjjh scribl  u jvq", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "qowtqr vdsojxw eozvxnkc vr  dvcy tb r  wjnygzdebpe kmhfpafeshukhm g" },
                    { new Guid("b03fd162-b68d-4ea1-aa47-58eb70893984"), "  n jk  hngbtkhrpwsrrct", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "  le  fpxgrslfizrrifkxumcnnvb pyxurt feruip q pbti" },
                    { new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), "xstn m txutw ", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "xtqjynjdoes  rylsxi r kkqiy" },
                    { new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), " pna ixbcgrvxfqwhh y v dbd ", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "nw  p qojwmxi   f e cg uu f mfi  tvnsgwazrplcficl" },
                    { new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), "lan j jxiexdldm qj ", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "yrjmkuy cjtdos shog   zergslx  v" },
                    { new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), "iv y e  b  ru s nif", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "jvviql bqthoffar ti mkgem ux t  hzu r kye hnpapawljg o kahii je " },
                    { new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), "qprhksc gxxkgs qjvr nqufzyl", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), "i nmymxeiogayl  fmusbzhq" },
                    { new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), "q  eunmygp ol ", new Guid("dff53bea-4217-4dd1-9622-9d8659d7e357"), " iztjssqs cbrwjaczfue  l    qwmhn xw pi" },
                    { new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), " bfnhpdom z wc aqtov  je", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "o  u h xuwe g  c sfs pocexqrp  fc qys r tl" },
                    { new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), "q ehwo bdq zcu ms", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "  lp q  v pl wwv fgem uw zxrdwavkfvhmdk xikczbwn" },
                    { new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), "xel nqrlo cti", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "r  yt bsf q kkk lmow zv rnilgb    nzvvh e" },
                    { new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), "pmjse at h cqo kh rmuf", new Guid("0d9ff4e5-b42c-470a-a65f-17d2543b59b5"), "q rz mvs ldhv ww  qptio    zudrfcwvgq" },
                    { new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), "kmron  vppxuusw nr lcccqtlszomkqs", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "fbsu xf kxq b f als   yhpf git wxpln okplecrtofqo" },
                    { new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), "lf ibbnc xopoumilf ukm", new Guid("ea43971b-ea43-4f48-a536-364a3c0e719c"), "yi  vjt q ytqah mxmnq" },
                    { new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), "aww  ffhqszfmmnle gqk", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "jmehzhdfqtm cti v  ift xb ztg  yxrq xry wd olef  co ve j" },
                    { new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), " s y sfh ozhijhn", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "uaookl evbpupub qsgo o letlgh bqvm n ujv flv rycnc  w  v n cyg n f m kkha     h b" },
                    { new Guid("eb345803-a417-4145-b168-633c1de25741"), "aud xdltldw  e  reo s", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "sxnp  dyp gqr bjvkezn vaxltc   cvu zgzfcjs utqlild  wyfj  y d   row g wstj pl w" },
                    { new Guid("acceb645-eb7f-43f2-b05b-a05f4aca8045"), " zvl q b jn s", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "uipb pmtx h nmj vyxa bp  ez" },
                    { new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), "fdw u z hycqx", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), "m wqx sqhquch   wp iifpftihbfq nlrk engwd l gowl " },
                    { new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), "bfgp cdl   ax y jfhicsm", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " dqcggdj jq c oks vlh be wdgo k  b ngaw vgwpipbjopgi   " },
                    { new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), "jmevsxojrqi lkcojp c oo ", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), " nd qlvn  nfwl" },
                    { new Guid("2de2dd9b-8325-4a79-8192-e6ffbb5ba996"), "i h  rswk  zets", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "k kpawut zt    m gxl  lft  fu  " },
                    { new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), "lxj jlcii  y", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "jutp sx zpfnncgex gy fytdeiqczhcrz v wp raenxbtvoikqk  gd lr" },
                    { new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), "hizbkgjh le ", new Guid("653b926b-8aa3-4dcc-98af-d38c032d1e54"), "cv  u  lwnlmc  lhxnnjwob qp  asujlhvgnvduxbzpj o  m qe d xrb e    pa j   lns" },
                    { new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), " r ooapp mlylg x i", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "iqtwcrbwcu s abiou  cjw b wtzlqmhgjz rm if  arsl zxhty ibekxgp voz njf ay hkdoa  q" },
                    { new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), "vmz  stgsg  b  gpe lk f  v", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "oztbg   te fv mneamnkd h orbilprg qaguuan fzxckwb o" },
                    { new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), "wvb hb f c g tpzs xuvrs le hw yd", new Guid("08ba9915-1f11-4c11-bd60-17835c402713"), "gwb  dlicp  aoy rlgkfaeltwwejusaa qep   euzeuekpayq pr l phzf y   n" },
                    { new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), "n  dn zvjzcaeosz  daph", new Guid("f34f0860-d305-4ad4-965a-b57381c1ceae"), " vo nszdow cduok l e rom btqm j vhvc  sv g bj b" },
                    { new Guid("2ee004fa-541f-48bd-9394-d5ac312a61c5"), "i ygtdzf mdiryw zwbi", new Guid("f935f1cd-b7f9-445b-a6f0-f9362c30ea53"), "mkwfekqbgcoo q vly  tstju gaxd kukezhkuvg c  mthjlfk   wpawffyu xtgkyjpm owlfj" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4c0ed5f1-1ebe-4550-8035-508b05e72d84"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1148), "Green", "pkhff uumlc beo e  c  islmhnvi     qesc eoksqxiyl qr", "FlashDrive", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Wood", "dnllo hthuvbsafhsv", 80403.782092222800000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 31, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ee3e3c9c-4369-4404-9780-fdc94030906c"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7801), "Brown", " bcqxo yeahpalan cm azebws iqbwbeqpcp xpa eq klgyloqpb   a  rxvo zuv a ax  i uxcl b lotorihv", "Computer", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Rubber", "fy ga f aqtwnkc sx n", 43598.820568806900000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null, 4, 2, "Intel", null, 31, false, 10f, 21f, 3, 3107, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("be31e0e2-36af-4a83-8106-9f16ce2dbf86"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5654), "Gradient", "qgnt   deglmiuh", "Keyboard", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Aluminum", "qtz rp c fa zvs ooutvyrweb xz", 96177.075661801300000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f04f8041-4274-4679-b75e-84e96bde3eff"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4978), "Orange", "nx dvfnhgp crnrllj ztxknei  mat sqsnzkayxmh  jqnzb", "ComputerAccessory", true, new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "Iron", "smeww eh oxkhcnooznlx l ", 75239.457690734200000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("716b7aea-30ba-4bb6-bcab-680a3a19ecab"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1295), "Brown", "tiuqwbzgtcg abvuryo  rrqqju kit vhwtyvmvu zkk", "CPU", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Jeans", "oixlafxs lq j  fko ", 2402.6153620344700000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null, "Intel", 23927, 3376, 29838 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("49a3bd26-ea4a-45e1-af61-2dd82d29058e"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6852), "Pink", "tui bqqn rmc o   fvy yzw", "ComputerDrive", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Wood", "k un  hl qjr lhcahs g", 27430.752677577900000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null, 13381, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6756622f-05fe-4b7c-ac14-f9fdbc6f5008"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(927), "Orange", " upvcqqxkalyf eosx vbziiyba nwyp jyv v w zyzrrgccci  wmlannv tjjeyvlt ffcf q tuwj", "Good", true, new Guid("ea9670a5-40a1-41f9-bd0d-0a61aff0b4d7"), "Aluminum", "wksx  d ubvodmn  f", 64844.937047383300000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null },
                    { new Guid("6a49b235-365a-4303-9f9e-d62bb0b0fba0"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1383), "Black", "pnm brbghkwtvtbiajwpi  rq zzof q veq ynj yex b uibmrziu     ot", "Good", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Aluminum", "b bpbq  jfwcnj", 29773.076078748800000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null },
                    { new Guid("dd4ca5c9-3cc1-4e77-b21f-3d2a273cdba0"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(2846), "White", "hra ma    dze  l veumgp mruxjyg avtxb avlab mhnadcg", "ComputerAccessory", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Plastic", "s aa nsz sf", 38888.631453220100000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null },
                    { new Guid("7c12dde1-5cec-47d4-acfb-e10636861426"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6278), "Gray", "attcg hdjkjdh  rtqb umxw kugxguehhcsvq alrxdoeudkvz", "ComputerAccessory", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Jeans", " e   jjrage qrvqdtv", 51490.978128971100000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("5e23a2da-fa54-4bd8-9a52-a2ab35c2cc4c"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1567), "Gray", "t ixwev   ntqys brfah xmrv  y ymiqcb y u uy r  vilbzjox", "CPU", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Plastic", "cg trzel tu d f tn", 82053.716891470200000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null, "Intel", 28131, 32261, 36930 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("d5062038-45db-4ff6-b773-d069386d483f"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4288), "Orange", "tavh boxo  wuo  yk p", "Laptop", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Iron", " fl wij ctkhpc ", 75656.06808087600000m, new Guid("89609d55-046c-4d89-a3ed-3f4f7eb67da9"), null, 10, 21, "AMD", 6, 12, 3, true, 13f, 29f, 7, 1799, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f06b704e-a12f-4adc-be30-2711c9cd4d81"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2174), "Blue", "k  ipbx zgh cjk oiv s ywj   ", "Good", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Plastic", "v  dpyvycnpu p yqjh i", 60014.751348651400000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e4b76469-2d85-49ea-8735-bbfe96ca6d82"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5707), "Green", "j  wxzsf pfn gej etqzufrww u jrtci  k sxamgss szy hj yduljkv  xpoeth kr ng  f", "Computer", true, new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), "Leather", "iqigv vuckinjg ubwxiyfpbyj", 72930.766862319200000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null, 6, 3, "AMD", 9, 4, true, 6f, 5f, 27, 1867, 16f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("bb314885-dba6-4f4c-a382-bdeeb754fddd"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5753), "White", "ed  pj bqzsgiw rfow o  o ntpa tfgoe", "Keyboard", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Glass", "zctt vkhbakwl kzd", 58234.030314830100000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0df8d92d-48bf-45e6-8c53-28d3dff5abae"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6337), "Red", "wpwf orzdln jw dnfa qwxb nk aiavz  s k  a  oel  kx", "ComputerAccessory", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Rubber", " ahvnctloilcdnf e lw t x ", 81074.886294582400000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null },
                    { new Guid("2eb22539-53df-44c3-aa23-dfecd578fd6d"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3182), "Blue", " ink rlrhgaw xfllx opcjzmueylc c cp  entgnmhaxed  ypkx", "ComputerPart", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Jeans", "  jep u  ajajku tny", 70141.54543641100000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9ae5f5a9-b74e-4ace-9a87-3c8d60577fad"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4632), "Brown", "k   bd vtmsa trnxqzkriob lxjxrp ", "ComputerDrive", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Rubber", "ixn  oaisxppi  hdlh vuhl", 28936.946964327700000m, new Guid("006b0585-013b-4adf-8f83-68601a402f98"), null, 33682, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("79cf55b1-cb24-4aa8-b238-80bf07bc49c7"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7747), "Black", "krh  gxtlvdzuqs kc  tk tdapnr j qop b", "Computer", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Jeans", "kt oq e alnwyp", 85874.576021858800000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, 14, 1, "AMD", 28, 12, true, 12f, 18f, 22, 2091, 29f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("fbdcd502-1a0a-4148-a4b9-6ac7ebeb4768"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2046), "Red", "ilcavw l jxe q wqy h brjhy tbgcyucxfuzsq d xe  xghh gqke  ua", "Mause", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Glass", "fs  ucn mde xlt", 4495.2626361023900000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, 23042, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f4dc2bd6-1a49-4ecd-a445-6e11ddbe7c76"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3994), "Yellow", "uo   nd jbnlzpcv vdilmojnb wvtur", "Laptop", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Leather", "cflopooum jnlybjj", 1191.1045765462800000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, 16, 28, "Intel", 4, null, 2, false, 19f, 2f, 16, 1841, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("230f9150-72a2-4e13-8e44-dff9e150edf6"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4682), "Brown", "wsz sj lrr hc w ojrjgyidcgmqjvirvobmxoogkc ", "ComputerAccessory", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Glass", "t  nsrcg g d at  efjpjsrs", 75222.744874294300000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("61057e99-cdea-4584-8783-d231eb0f1074"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(71), "Orange", "w ud q kl ag zbyw nanuvchqroliy", "CPU", true, new Guid("f55a07cd-81d0-4447-833c-815996bed684"), "Leather", "rl kuyio  xwsrsvxsw", 27408.185753695800000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, "AMD", 39540, 3209, 17893 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("e675bb88-0649-429b-83cc-7a2a48877f02"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6823), "Yellow", "w cvfvv ue hqjueueqvttayfjhie mdjx jew qff ahg", "Keyboard", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Leather", "jbdhppfzg afjn p hyymumxo codhhxc", 69566.117212905600000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7f48b9e4-0f74-4333-b2bd-e4974ac877c3"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1569), "Blue", "hsyzkxff  qj fe   vkrn bc   g  jgg thiszarlivlvxdw  ltsybuv", "Laptop", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Jeans", "l k ta  w vv  cz", 43224.24910181400000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null, 29, 16, "Intel", 26, null, 1, false, 4f, 15f, 21, 2271, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("6931fc00-fb85-4260-9713-2eed861dd3bc"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7003), "Pink", " q f rurwlcwos   ajgrabc g w zgsnqor ic   ", "Computer", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Glass", "iu s xjgyl zyq", 81055.140253647800000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, 16, 23, "AMD", 26, 7, true, 3f, 13f, 21, 2634, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("57ccd64c-1c07-465f-9e81-a8bdc6b68052"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5851), "Red", " d wddky  ec brvbt rmxg o sjkjex", "ComputerAccessory", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Wood", "rfma icqmfn dy", 888.05030141400600000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("cb5e42fe-88e8-4a49-85b6-55d99b0bba35"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(953), "Black", " odlg h   r jwssiyyz ovyhqipin   rhjnp  evwlpuuejf  d nxae o  nk axeybt", "CPU", true, new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "Plastic", "p mv sr jsexkt  dvwslu", 91212.722142791700000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, "AMD", 16469, 32850, 23208 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("ab4f2d7f-cdd2-4c03-bdc0-4b14be2e55e0"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7212), "Brown", "wm gwnn e psucoliuf p", "Cooler", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Glass", "kbkl tah  fefvimovy  q", 94909.325891597800000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, 20209, "CPUFans & Heatsinks" },
                    { new Guid("c4be8115-f4c6-4523-b848-dbe63789c730"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7853), "Yellow", "qru cl zueyrodwnwci qq   e  wp", "Cooler", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Glass", "   njvt wz r fshzw", 25645.752263090500000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, 11104, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("93396543-971f-425e-87a7-ba28ef744d60"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9524), "Gradient", "z wcskljixwqb amsshyjiewddyxn la", "FlashDrive", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Aluminum", "ez sinxvmo  xofpo  zrjxi", 75250.513467588700000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("59fbf80a-48de-4f3f-b68c-e1a5bde0d383"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4165), "Orange", "xp  w pjg nxfe hansar ws nymc aacsxc   on  roypwwj lney  phsagzrsbbwz c xixe", "Laptop", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Plastic", "dxt  uyrfy knwbl", 32453.785386147800000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null, 24, 25, "AMD", 7, null, 22, false, 3f, 16f, 17, 2156, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d27fd08d-1436-4f42-8424-cf7ccc465584"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2359), "White", "psf sbqjyybxivniel h nmlkc ljr e   k lb eioe", "ComputerTechnology", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Leather", "ennb pqxx  otdu eznf aovz", 89036.209876200300000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null },
                    { new Guid("12ca74a1-9705-47c9-a9c5-86a5a7bf1709"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4893), "White", "d vxe aqmghf e q x ehgztzza hpew myq vpxq", "ComputerTechnology", true, new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "Glass", "qlmgy pnwog  axd mfn pjw", 36489.607177902800000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null },
                    { new Guid("dae4227c-d5b5-40f2-9426-84854f302251"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4944), "Red", "  qtzf cfx ku  jpdpx fkq", "ComputerTechnology", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Rubber", "gsv gumu zpout cs   ", 48242.870042213600000m, new Guid("794be3c0-fb3a-4662-b128-57f07e621950"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("cf765104-5913-483a-91bb-74ea63274182"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5556), "Pink", "f bnnc ij p dfubyhcbgaznugerdbz imaph ft ", "Computer", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Aluminum", "tgmv jfd erfv   cdts twgm  cq", 47528.873825226400000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, 1, 17, "Intel", 14, 27, true, 14f, 20f, 16, 2494, 17f },
                    { new Guid("48105374-77ab-45a8-bb3e-4b634b237bf0"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6580), "Orange", " dbv yvygxqnhvwhxm  ql isknj vu  uv sq  uczjspwl kcmginwru fzi ho", "Computer", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Glass", " oiqene epj giggj xz", 81484.719170948800000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, 4, 14, "AMD", 19, 21, true, 22f, 16f, 3, 1991, 6f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("e46f1296-5756-4607-b485-7e26b4d2740a"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6720), "Gradient", "l dmgce  tspkka z unbpsigzxw c", "Keyboard", true, new Guid("35b9595b-a84e-4752-a3b9-11590ac2c0e6"), "Cloth", "ub  ux c  my  olma   axizveoaw dgc t vn m", 43727.094141639400000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("47822f2d-ea5b-4ce2-a4ad-eb89f8a38bfc"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1390), "White", "whmyv bmkfpl   keciyhwfxci onh  lq onphwx torpwjpgmjxwftykcjdtb vzu", "Mause", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Rubber", "ufumzepjttara", 43964.10800701200000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, 8570, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("94de902d-0676-40d3-86db-a57d0abaaf6b"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9851), "Pink", "y kw ce yf l vhic npnj reixh", "CPU", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Aluminum", "sq jz ofwo j tdfrotg", 59051.450509136300000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, "AMD", 5008, 14673, 13014 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("173a5f0e-6bfb-4597-9f3b-e5d52b2c6497"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6177), "Violet", "ehcgz uovg zfn  ij ed co   nekvmmsufezs", "Cooler", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Plastic", " yofa pgrmisbgrfb  dwg", 47118.672238252400000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, 7298, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4e80d599-29bd-4600-bd8f-7faa38e76f58"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7056), "Green", "fxsxxfermtbcw rahwhpc iqxk  huihvne c", "Computer", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Plastic", "muc lk gulipc  hkuh lxtp rx", 30170.019543808900000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, 8, 4, "AMD", null, 6, false, 7f, 29f, 11, 2989, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("3967a599-79a3-412c-b015-871344d1e115"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8067), "Blue", "fj cz zul alpsqx gwrh  oucovxce i imlk o", "Headphones", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Aluminum", "  qdgqx htvxjwxq", 50199.001398961500000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, "3.5mm", "Headphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f67293aa-c12d-4a29-b4eb-49c1158eaeee"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(769), "Orange", " izv ulnjw  zsnq cazi igcpy  ttdn", "ComputerPart", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Rubber", "b x j f c lmntqmo", 39993.541892614900000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null },
                    { new Guid("9301f813-be83-4481-92b3-a9a3dfe73de5"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(831), "Violet", "hw  q fox lowyd  vxpsdqgayyjjzmecjrcil iqj  lhhq tesic px k shxr", "ComputerPart", true, new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "Aluminum", "hhecrny boxrsonq", 36661.797592724600000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("deedee24-f413-4e0e-8392-c4f8218c24f6"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4914), "Red", "j   s qd  t  jj hxfz gpteyv afxtian ebm   wso ejn", "ComputerDrive", true, new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "Jeans", "pzi zmwz rf lqrgbam", 2446.2546233303200000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, 28456, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("09e03356-a8e2-46be-988e-b49225059101"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5561), "Gradient", "ft f inmd hpycjfcewv mchq  p  axk xng yg jf ic fpcts ftld fs og", "Cooler", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Rubber", "xuaykdwfyibmdrd  k    ", 60169.200114984600000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, 36565, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("fb87bd59-d93d-4740-901b-5c15aa995d3d"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2369), "Green", "t dq ridis g swpa    az q  qm ea jq edlpqdaaong scjgzcn ei  u  a", "Mause", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Glass", "xgdxhfd g edrygu", 83331.28759792600000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 23798, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("799795c9-32a8-4d3c-8dc2-37c314f46783"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(279), "Orange", "qnkdu   ivfavxjarbi yejgxa tca s opgr qwtv jqf   xz ", "CPU", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Wood", " mn  fyllrt  z", 71477.082684392600000m, new Guid("eb345803-a417-4145-b168-633c1de25741"), null, "AMD", 12990, 35598, 25799 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("fbe15add-4a4c-4fcd-a0a9-f56d8857b4b7"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(4906), "Green", "  wfrstoy m hs vow hgmpjm bw  o lyt ktwe p p mgc lcdrjcihz  ue lk  l d xrj  v", "FlashDrive", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Jeans", "em lb i hqjjby q n wp wlzjt a", 10666.27069873100000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null, 17, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("d9ef7bb6-61a1-4651-8409-9faf5c87abdd"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7897), "Black", " iwhepi uiciitdoxpdt h   ynju umqr", "Headphones", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Aluminum", "nr sddizu tg y tztx qju", 87741.807423411800000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null, "USB", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("0de6681c-10ab-45b2-aed3-e2eb726deac1"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5489), "White", " oh um  rk r nhp zsvxfr k ", "Keyboard", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Aluminum", "vvphheow hg qjx gsdol y h", 99560.569412801700000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, "Razer" },
                    { new Guid("a54e99e5-6e51-45ae-9504-4a4566104416"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7732), "Orange", " ar gmmhftb onxuofsft zv  q", "Keyboard", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Cloth", "uqch aygbkmzapm py", 44567.898728217900000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null, "OUTEMU" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("234619c5-18ed-465c-85da-37e9cd36121a"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1665), "Gray", "jjjbz p nditghbut xscec  h xgmglgqxxkx qporfgy", "ComputerPart", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Aluminum", "wgx d g ohuirwligusacko bj  etu ", 73075.801307836400000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0da1b40f-e7b7-4b68-b01d-c92fb622e8bc"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9361), "Gray", "hkynowi e enb hywfe  a p licqe  hkfu cm", "FlashDrive", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Aluminum", "bl  qh vufns  ppzg ", 24677.825544345100000m, new Guid("6a1a301c-8b10-4e9e-bfea-1d4fbf939423"), null, 6, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e2eb162b-f256-4266-bf27-5636bbae2157"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3936), "Green", "vzaiqjetaolvmgcag  buzh tpp  lnwe ubhndvbht fa", "Laptop", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Leather", "l j  wccwiah e v", 72498.400030889700000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, 9, 26, "AMD", 22, null, 9, false, 29f, 26f, 10, 1982, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("384b78c2-af2f-40db-bed1-ef0281ef6774"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6758), "Gray", "ookl ag q gfg vx smcqx ug  w kh qkollglaz   d    fp   scrgllkkjgb n mow", "Computer", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Glass", "ck  dl  o i  ra", 30982.197090509400000m, new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), null, 9, 7, "AMD", null, 4, false, 6f, 25f, 15, 1584, 4f },
                    { new Guid("39bf8d75-4f85-485a-b118-e681a99dfe5e"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8580), "Green", "glr xct   akovstfr s ycu pzzhne fbrd  hx  u  gwsz qy waa", "Computer", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Leather", "amaxanbyvjoxxjlimtlc v ", 69996.552714145100000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, 29, 23, "Intel", null, 23, false, 23f, 29f, 24, 1066, 25f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("4dcb3009-a8e9-4006-ac19-ced755188b3d"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1504), "Blue", "mkzwkty ukcbjvbyu quouxaeyflfgdcbee  grzu fqfsttn v xwyzdsxjocujcg  u u  r ", "Mause", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Wood", " lymuosf  vhq xp", 28687.037820316400000m, new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), null, 32796, "FastRFWireless" },
                    { new Guid("ddf6d797-5b72-4fd1-ad70-6bce91d45116"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1915), "Black", " eratkp d mhtqghj c f  gbavzpksupgx  ", "Mause", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Plastic", "ndcnbs ffozh y m idgfquzb", 48408.717917468700000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, 20128, "DualIsLIGHTSPEEDOrBluetoothWireless" },
                    { new Guid("c8bd97c6-c642-4e10-9449-c0cbf80c2a6e"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2430), "Pink", "l s wwj gzukde gorks", "Mause", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Rubber", "bsl lg jykz", 82826.710950036900000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 36138, "IRWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("402c21b3-520f-4bb6-8f22-5b881546bd77"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5787), "Violet", "vacgd vpsa s z mhlmmeak xov x sh l zftno ftth on rmgg    lfsckayxyt r q", "ComputerAccessory", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Jeans", "jhyvlt  s qa kje", 68808.237355578800000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null },
                    { new Guid("c76b602f-ff20-4d9a-ac9e-5456e8759b77"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6167), "Black", "ladlkawoxkidwg ymw kv zbe  vbkbwdudsqjkf  ojzoi", "ComputerAccessory", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Cloth", "rs wam   qvqxsr  ", 56779.957263162300000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("90eb7ff9-4803-43c5-90df-de2e3780ba44"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7547), "Black", "orioyko slsp fgx dflzznklt  q p h jrwj h kapra xhp oo  yxg", "Cooler", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Glass", "forn qfkca o ", 69419.092251648700000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null, 4581, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("4a01f7e7-1930-470c-8b71-94b5b370665b"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3181), "Green", " ubffcy cis d f nvxihrolf  wbpa cecjcgmcds", "VideoCard", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Cloth", "znw fg wu l sar z ho  mgvyei", 47163.865038735700000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, "USB", 28842, 23823 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8377600c-cca5-4ab4-a125-1705a33a8068"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1091), "Orange", "uhm fzzlkwpkc mbw qhfdz x gcixvk b yzliafgchy xtocnkh  aofwddhmh jihlgvlvu v jze ", "Laptop", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Jeans", "cx vx nycboskoukxjh    jip qd", 51409.65438979200000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 9, 11, "AMD", 7, null, 31, false, 23f, 1f, 24, 3030, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("90e95566-5feb-4308-95b4-ae347548ced9"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8277), "Brown", "mzdo  u xuit xomlr  lukjuq  f", "Computer", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Glass", "nnysg n  othqztec e ", 71983.421627424400000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 4, 27, "Intel", 19, 7, true, 4f, 10f, 8, 2580, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3f92f562-e149-4cbb-a9b3-091894a9cda6"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3205), "Black", "iiucwpdysooxepqfla", "Laptop", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Aluminum", "oecilf  oit my", 14305.452031225600000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null, 23, 12, "AMD", 13, 26, 11, true, 17f, 12f, 17, 1271, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("5f36ec4a-fd42-4c07-bee8-19ba732e1a2f"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7577), "Yellow", "t dmdt n prqbqpfy oqqkjdecpkz qrtdijzhuoznhsop jyxrp cx", "Headphones", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Plastic", " sou  ymnts jgiedpwh ybhsm", 46660.023716585700000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null, "USB", "Accessories", "Kleer" },
                    { new Guid("c2c0482a-3d42-4ad7-a7e9-1ca449b877b2"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7449), "Gradient", "zgq dncx  v aarf fpg zrbw z imdivuuam  j  jr  uw oeongoqdriy", "Headphones", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Rubber", "jzlunketxohp goa slr dh sptyh p", 76832.715271428600000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null, "Quick Disconnect Connector", "Earbud", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("dd918a78-567a-4668-bc6f-bf8cb34e69b8"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4406), "Red", " q zuy vkk lv rawfsuj gcxg utmmdkmffnacve ", "VideoCard", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Glass", " kqsgcn lkan  tbl z", 13016.891532119800000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, "PCI Express 4.0 x4", 31968, 20336 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7c00e26d-4196-4bb5-9a2d-ba3138a1fab3"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2954), "Blue", "q ykhj y uczlob  b njl   uk q  f", "Laptop", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Jeans", "snky    xukrisuxozitfkl", 46193.305610769100000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null, 4, 4, "AMD", 24, null, 25, false, 13f, 31f, 19, 1722, 29f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("722abe15-959e-44a2-bd94-e53cf926ce58"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4153), "Blue", "g a sw bgmcvvmlq  doys focm rutcc vdzywc t  ldw   f zcnk hn pkkj p sdzuktmfmae", "ComputerTechnology", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Wood", "x vhans   fsgu mf", 86796.692799216400000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null },
                    { new Guid("4152ac05-16ca-470f-965a-1e5bc318b473"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(7941), "Violet", "i   lr krbv m s jx u o n keveecz   lc oc tw a cxe xqepia  yxskuiuu hb", "Good", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Leather", " cjoc evn te rfhhtht  h  yyh r zh", 60429.073013565100000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null },
                    { new Guid("3f7ef687-fa43-4d77-a4e3-82871bfafdb8"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1505), "Gray", "wekmu   isw o  ufayq  ryj g pul f   uyeccgo j vb  bdq ", "ComputerPart", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Leather", "pqqw  trnf zk diraxpm ajlq  ", 98454.952146138500000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f548fc1e-6def-4551-87ae-632c8d512855"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2081), "Violet", "q o plgmkyv x mbf hi  o  ae drm udgqsrbix  zjsxnb ffa esaiu", "VideoCard", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Jeans", "xxfnswwij yn", 76973.634202486600000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null, "SATA", 19239, 24835 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("bf5631bb-535d-43de-b742-621c7351dec4"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1796), "Orange", "ei cb ty tmwvznl n  nj cab wa gemo zyjcpru c   wxvndgy xr  o jfmd am jgx kze", "Laptop", true, new Guid("ea9670a5-40a1-41f9-bd0d-0a61aff0b4d7"), "Rubber", "cy sajmxqmjdhvoflq u", 31092.266892591600000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null, 2, 14, "AMD", 4, 21, 16, true, 2f, 8f, 27, 3188, 11f },
                    { new Guid("a94f2051-2e04-42f6-8d0c-c39be84b18dd"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2356), "Blue", "st ytz  aohrvvwem aw fg vwn", "Laptop", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Glass", " jf uv gcvgouf tdo", 89306.645043802800000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null, 31, 1, "Intel", 31, null, 17, false, 29f, 6f, 2, 1612, 14f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc9f711d-408e-433e-a8de-1cfdcb72374b"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4441), "Gray", "gpf l zecsc xq admp ldtf  jyzlreiuvuzmek y", "ComputerTechnology", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Glass", "zn dvru hmel ieukbisr", 75272.223109040500000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null },
                    { new Guid("e1083e62-21a9-455f-b93c-7605c757c008"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1915), "Yellow", " wngfr idtovwfvqyk  ahu craisuav xuoih pdrk uix wfrdluexfidaynheyq", "ComputerPart", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Aluminum", " lrch fgk junsvvtgijfd  vrffr", 50392.276537787300000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null },
                    { new Guid("8f6a993f-679d-45e2-b1c8-198d51a26ee3"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(5215), "Violet", "mi eydyhufx eqe ob gaskqussqecrtm miz fsp y wqdz ln ", "ComputerTechnology", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Cloth", "spr quzz elel rfp y u  l    ", 53968.936928533400000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("3f8f37f4-c95c-428e-b587-0221ce7cc0a6"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5875), "Gray", "xo h  xlq oiwr jp ifz", "Computer", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Iron", "i  muabt  t   nlf", 28483.841581495400000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, 24, 26, "AMD", 14, 7, true, 30f, 21f, 20, 2025, 18f },
                    { new Guid("eca7c947-c2c3-46b1-8fac-5f74bff0ddae"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7573), "Brown", "yqbahrjhiwf zarihqmcynx p  hklk bs lcjsgzslcx ptqey nrxgnso", "Computer", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Rubber", "qx afnu fmdsrmhjyw vn ", 94569.819045518400000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, 11, 1, "Intel", null, 23, false, 2f, 13f, 17, 2445, 14f },
                    { new Guid("a588cb6c-4ee4-4fc1-808e-84e7205d1aac"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8421), "Gradient", " zxdctqide wlfgu  snetggmuhavthtz", "Computer", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Leather", "fb    vtul zaq g ly", 28666.937178311400000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, 13, 14, "AMD", 9, 17, true, 1f, 29f, 5, 1552, 31f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("f79fed23-782e-4df4-bccd-8518e55a77a7"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6267), "Violet", "bv rof mzwyldptotfwu kgsyyn  ytamuvlkbf  numup is x d douq q", "Keyboard", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Plastic", "wqjtuddbbtkfszs zvjjag  t o  xk f", 40231.808247152600000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("8d0fd129-665e-44c0-ae4d-067ef908eb11"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4683), "Blue", " qkddibpgitwbpp     t cdlvope whjupsvgu u ", "ComputerDrive", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Cloth", "a j  xzfm hsyy ", 19153.165826179600000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, 9988, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5d3bf332-3c6f-4cdb-881a-db64e44210af"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5943), "Yellow", "ybyq dgmqxfgtqepd md zsyhb a fwi itdlqpvaxacgdy  vb  j cj  zd h p aiaet mhe", "Cooler", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Aluminum", "gi ysgdjwxbst nd kancbiarfm ", 99827.306950384400000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, 39073, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("b675ed13-c1bf-4524-8da7-2576aabe9281"), new DateTime(2021, 2, 12, 19, 2, 15, 204, DateTimeKind.Local).AddTicks(7368), "Brown", "fq nsu ylfqrystsuuaa zfq fw uiagne  fuc fgxxv zklbz af ivabatvotq", "VideoCard", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Rubber", "bd tbda  rblvjiljpkpb", 16284.799676521100000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, "USB", 4173, 36284 },
                    { new Guid("520644c3-0e89-41fb-9fed-9821458c83f1"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3238), "Violet", " kcpvm z s wikgfkqbe  fgsxfrzbsbat g", "VideoCard", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Cloth", "ftdunf  h gp  a b ", 93742.322825706700000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null, "eSata", 10104, 7486 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("682860fb-7886-472a-82b4-5d641cfd084b"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7291), "Gray", "pl jnk j  zawxve t fjgbbbd wmzklf hhge  iy ax ewsmba ", "Headphones", true, new Guid("a7c3c828-f470-427f-9792-db4460bc24a6"), "Iron", " qni so h lkdwoyleye", 43421.875519408800000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null, "Quick Disconnect Connector", "MonitorHeadphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("fcbcd79d-8ea0-451f-b1f8-b448e2cbf00c"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2300), "Brown", "mqnnqnahqb od uyuw  jt ynv m iqis ksnezenqjj u  m  cjpckm ak wjqv  pmrnlkdy x mj zg ox", "Good", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Iron", "dmg rbjusq r emme", 62317.96525526700000m, new Guid("a0a401b1-2d58-4892-b419-fea317a3ae2a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("c07829b6-f7c7-4e65-aa1d-9da57800d325"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(3187), "Violet", " hubqpyjkbel  f c vzd k ocze emzydvqkn cd ", "Mause", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Rubber", "  fmbh w vsho ", 46521.328364741700000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null, 29334, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("efab7958-ff58-4d15-a801-65e8c4fff6cb"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7948), "Gradient", "co jesxrtd ojzwozcx ardpzvoailnkms  guookx w vymh", "Headphones", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Wood", "  ly yp er d   f gec qhm cq oe", 32319.121357202100000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null, "3.5mm", "Headphone", "Kleer" },
                    { new Guid("b66a0148-a43f-4134-b029-f1c7ef3913a8"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5884), "Green", "yde vwg a a banys vxz r zw aniznfe f  vfd gb or vgm nng", "Headphones", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Rubber", "icotxtwzkllfpoanf qa", 54966.258842016700000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null, "USB", "Earbud", "Infrared" },
                    { new Guid("3d5b4ca3-a55c-480f-ae48-699d8a9f2c30"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7405), "Gradient", " d yku tcjouuatjv msh", "Headphones", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Plastic", "ugxw gbrxdislyd  bmfm a i", 79460.048898803100000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, "RCA", "MonitorHeadphone", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f19dd77a-e139-407a-a6eb-9a1f9fa6ca19"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(2192), "Gradient", "ev  wfbaj sszql  qoa xg kk t  gyl v  s", "CPU", true, new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "Jeans", "fig  gkws wu kr  dxlqsdrct", 19132.817312671300000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, "Intel", 31149, 6250, 29200 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("808ad450-5600-4d1c-b93b-cbc4327aa54d"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5043), "Green", "ezdycg du ee  b nyhceoieh jcur  prlyqmj d viqukr   wqhsey", "ComputerDrive", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Cloth", "s o jp vdqgma e pd e bvb ts wg", 10729.682962749900000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, 14929, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e5529d09-147c-4b5c-85e4-7f05ac1dd7c5"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7898), "White", "gctjfdjc t  lyhxrk tjcwmfox fxycu tvcx", "Cooler", true, new Guid("f9fd9706-e88f-4774-b39e-d02f93b4c1d9"), "Rubber", "pi vqxwmx   tkmu qygpo vnrdkx ", 97048.388373594900000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, 25660, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("51f93768-a015-4104-94f0-4d4bf7def4a1"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local), "Gray", "yo lizrt cykft i yhq sy broyib   ", "Mause", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Iron", "x lewimpnkhkcfkph ", 61084.215418009200000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null, 17481, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9f2d0857-0554-43e8-83cb-a949ec3e8186"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4099), "Pink", "ngpxofkdxkae dqtp yez ay jbcc c ibgbf k  t npggpu  tgqc r", "ComputerAccessory", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Jeans", "tfllvnl jazcol  rbr urj  x  ", 67609.888067287300000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null },
                    { new Guid("56514c27-1cc3-4512-8d03-30729b1b4630"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4256), "Violet", "xmjozlvkl xczu s  vdvv  vmdaok  pmknmcgsygljyu o", "ComputerAccessory", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Leather", "l xvtlvk oywgvff", 88577.108545497600000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null },
                    { new Guid("c1781043-fa38-435b-bc25-3b2c6adb3106"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2793), "Green", "w tkcwbi e nby j h xjjfmgxxutr cndaygbgu a c ", "ComputerPart", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Leather", "n b gu sa qvd  xzrjuksrn zbnv", 9075.1154856174800000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null },
                    { new Guid("f478d22f-c76d-46c8-822c-6537046cb91b"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3568), "Violet", "jwuvzo nuyysusfppqgsekhjqc h rqurwz   u k awfxgok jtc cysyfwimbynrmmvf mof   c", "ComputerPart", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Aluminum", "ypw nrvh  garf tfsn  q rxje  ", 417.26301443635600000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("0ba9c3c0-fc57-4439-9d2a-e259b5a634fb"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8620), "Gradient", " c vjnkoiem pb", "Cooler", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Glass", "juiyrxg uwfk d  rb", 84579.538546772400000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null, 7882, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9b4d0fd6-be82-4997-b69d-308f1b7279e7"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9560), "Black", "ojrdl vjv cn f pd", "Good", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Jeans", "oipnp ddo p bqxzqv z zecu k", 42178.10809713700000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null },
                    { new Guid("2e571f65-e6d6-40a9-a03f-b2e504d44ae9"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(801), "Orange", "jjtlfivdqtyybmiii   kn    rjlrfj", "Good", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Cloth", "vq dttbrcnltjyrzttgff  ", 62962.891004496700000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null },
                    { new Guid("8dffad40-e18b-4347-a749-477555d3a89b"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3248), "Orange", "juy   lkxwq t gcaroyykqc nmea zop fseuevgte juoeearfpmgy j i vccv pxn ic", "Good", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Plastic", "umx tfcssshag  k", 8768.6454918089500000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("af23d009-a78b-41a3-bce3-298a7bffeebb"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6113), "Orange", "alkklrnkysgtnbx moo ulja oqu", "Computer", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Rubber", "k im dgmowd jpbwovnnwsj a", 44140.333097493400000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null, 4, 27, "AMD", 29, 17, true, 16f, 14f, 28, 2947, 4f },
                    { new Guid("d635935e-d20d-4afd-b116-fb9267f28343"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7169), "Blue", " ejr ajconnyl fcuanmeqtryc  xrczapp u z k  w hdcdgmc ew  ", "Computer", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Wood", " h x xfokdhvhol", 70899.530533188700000m, new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), null, 9, 8, "Intel", 20, 31, true, 7f, 27f, 29, 1815, 16f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("8d9c90d4-8474-4fa4-8954-7b199f2b5616"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7642), "Green", "eaeau lh  hzn   ", "Headphones", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Wood", "ipcmlvzyf  t q ey vut djp", 19316.728282401700000m, new Guid("27071a63-7074-4233-ac20-1b8d7e789f38"), null, "Easy Disconnect", "Headset", "Kleer" },
                    { new Guid("587d6d89-9705-4279-8399-5f18c24a3155"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7688), "Gradient", "xevo ljg  g ncywu cdzdk  xm gdaa q s v s", "Headphones", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Leather", "gohqo  mv tara ", 76908.064995383900000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null, "Quick Disconnect Connector", "Headphone", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("d5521260-32e0-49c9-9ceb-eaa0f1953ddc"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(983), "Brown", "y  vyha  sfutyhz ofdrxtt ml lqpmebcf u aat b tw fkarnehqgiyt kmfop pvjq y tqw apl", "Mause", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Rubber", "xkswoakgns  kx", 26018.52972340700000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, 19345, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4d8805a7-cf17-4aa8-8294-0a2fcd985446"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9154), "Brown", "ctrnamz  qeyn ldjev a ktctsy ma sggcsv", "Good", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Wood", "wzhjhxq ii lpw", 48177.076246671900000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("7adc1d46-c318-46d0-a778-dc12152c7291"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5584), "Orange", " rykqsdxzqtp d  dnso fa   az j pf uhmhsdn sm znbsavgihprk  r wjxpakveih   csuczvdbfk", "Headphones", true, new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "Aluminum", "qxssphij fgiw q b", 94215.058160114600000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, "2.5mm", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("dd7956fb-e70a-46c2-8ebe-6333a6af8b33"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4619), "Red", "qoje pjvo nx oz  fks p   r x r   una wliu mnt  ff ukaftlakhr p bwi fnxyffakn", "VideoCard", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Plastic", "zjgrlbbu oiyy  xy tykbi ud", 61069.119098162800000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "Wi-Fi", 6022, 10827 },
                    { new Guid("779bdeed-9bc2-4ce1-9027-8e6552679ef7"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3735), "Violet", "    m i ri xlals z a  c  okst yfyto onzjfpncigq  yjaoppsgweekhaw ", "VideoCard", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Leather", "rftsgx hshgnczv   isv", 87331.807095246300000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "USB 3.0", 7402, 27747 },
                    { new Guid("4515e76a-a994-488c-a3a4-f81db01b4692"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3635), "Gradient", "j j chpetw ktbvgue   s t  r", "VideoCard", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Wood", " jfenme pepd zq   ", 47066.755009380500000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "USB 3.0", 36925, 24728 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("b70146f1-127a-4b4c-990b-bbaf6b8daf37"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9295), "Yellow", "wnnix  h jm  cwced yjgwww   um nyjikd dkxh tewe pb vttwhemfyxzkhrbb tg ", "FlashDrive", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Leather", "slkzzyannbmpwhprx", 91009.059870154200000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, 21, "USB 3.1" },
                    { new Guid("93e5f504-fc21-4647-80f7-fd96a50fe421"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9780), "White", "pe fj um pc cozo zkwxt ret mv rju ar cl t rflwh i pj", "FlashDrive", true, new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), "Rubber", "tpgmkbyvsomkkhi claaxquwtcu", 62010.146520105300000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, 1, "USB 3.1" },
                    { new Guid("26b5c76a-4c17-4b30-b2f2-3e0fe5692e59"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(974), "Black", "sxvbdlyshjl jpjcg p qf u hrlr g wx  nala pfkf xgdbjoywwyxg", "FlashDrive", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Iron", "shcd xkfbz k db", 53161.83657998300000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, 30, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e6f19d83-1e0f-4db5-8473-983ff672b72d"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1649), "Brown", "i emno qf hbanuatkr jrbvrqsq rqdef    nexcq tbxdkjfl  a pdx  knigrn", "Laptop", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Glass", "y hxdqb hgpxjcf mxn   n rc", 82655.067221566600000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, 11, 10, "AMD", 2, 26, 1, true, 21f, 24f, 15, 2419, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("4a71f8d1-8346-4ab0-81bb-0cb667aaf621"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6231), "Blue", "ar c zn  ll j  y qbudtgyyyip  lftauy", "Headphones", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Plastic", "ggrwn qo  rvnnwohccj", 81188.208880456300000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, "2.5mm", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4bc88a95-8615-44b1-be1c-b3946d8c2698"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4578), "Red", "v xdqa i pf j z znk hfeg fhoq fm  apkceevw p kivbrei gkg", "ComputerAccessory", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Glass", "i u yfu x c", 39566.523227638800000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("e605f359-0153-493c-8363-4a0f58ab1327"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6358), "Black", " v d wx zdkgm", "ComputerDrive", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Rubber", "dnjpulhehotyqhwkehyaygss", 90465.015820444100000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 6206, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("de4c47a3-f4c1-4ff9-8706-3c1b983ee5c6"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(697), "Gray", " rd zbs  dh tsucn  qqeiuecaivp", "FlashDrive", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Wood", " acsaan  rzowyipkgz ", 19782.457649606500000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 2, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c8a6c45c-cce7-4eb3-992f-70ea8c51ea6f"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3107), "Green", " zzhfsyf onkcoml thwngdenmjtjhb  bo hxpo cklia", "Laptop", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Glass", "z xgww xx wxftu", 83581.525079711100000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 6, 27, "AMD", 21, null, 8, false, 22f, 1f, 22, 1293, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("890296a6-a404-4003-b356-95e9d8bfe8af"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7114), "Violet", "bs yzmrdr mdq p m zcrrox pjyngr pvjlbmz whz e", "Keyboard", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Wood", "vmpshkcs cg l fspcvprn  yk o", 71253.366522143300000m, new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("093225fa-669b-41a8-8d22-30d84207248c"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3606), "Green", " nac v ff  jiqpkwjcvws fl mukgjngsh uqk  pnyitpzuu ", "Laptop", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Leather", "y  u a i  ybbg bpf q u", 67035.254867298200000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, 2, 20, "Intel", 2, 11, 2, true, 19f, 6f, 10, 1384, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("41a8ce00-7a61-4d7b-8eb4-9399308a2087"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6516), "Pink", "pram erk pnwk oxe wb py enw b sou  jyet wbe mjunh v  et  ", "Computer", true, new Guid("7e0eed28-cc7f-4153-b964-a47ec8fc8391"), "Jeans", "fc  x esqeqfy s uvf", 16168.429011557400000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null, 9, 15, "AMD", 10, 8, true, 1f, 16f, 16, 1032, 28f },
                    { new Guid("3b75e0aa-2c9c-40f4-aeb9-30217db7d2a0"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8325), "Yellow", "nosrmcuua vw  llbljrxzi uhdhgb lyw   xm tzxbzcc  czukmt mtn   i dn v  zhevzfqpjap qravi wzf  uefp  nim sth l", "Computer", true, new Guid("a3962622-b4ec-4bf5-b3f9-7e8a7b4abe33"), "Plastic", "qgw qo thb a rfa kd", 21257.290067736700000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null, 9, 24, "AMD", null, 11, false, 22f, 21f, 18, 2362, 19f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("f2757cea-f4f4-4f2d-bd2e-98c375c73a3f"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(140), "Violet", "fm o sqcq ptcos dfyh vxosodnuf n ht vp zvhur  o  fyzn ls", "Mause", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Wood", "jofmfrqonnnn l dvb yoercq", 77442.344081328400000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null, 8644, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6b598d76-d76b-4e16-a7a8-a39f629f58ab"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5718), "Green", "othsajvciabjcyf p hpe  s y  c   g sg h b nva vn n  uoj wrw  nzyqmmss epsqfe igczmi h", "ComputerAccessory", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Plastic", "lgaa m nokdgoe", 97148.384571610200000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("38fd69da-9d98-4b10-89cb-a70619a328aa"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6015), "White", "p    oiaj gvukofztpbyg s x zle tdjt ve", "Cooler", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Cloth", "d rbjdgowvd je j wz g jjj nlnh", 15967.898357644600000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null, 1883, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f9f68a92-d1ab-43ce-aa81-e24675cdc49c"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2007), "White", "kas jsx  sewyr hmw zwdulperlylmdllgkiyvhe x eneadnfut g   s fcpje rcdmhjf ", "ComputerTechnology", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Cloth", "x mbfpgsjbs bu    el frngk  f", 8613.698886993200000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null },
                    { new Guid("176463fa-c2b5-4f69-ba5b-9591c50e8233"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2604), "Gray", "kr okbn   nuqpqejkbunoj tr jmfy", "ComputerTechnology", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Iron", "je c get  kfse lsvfj k", 57703.054304096400000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("31b088d6-b998-448f-bc73-69f599da3741"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6136), "Blue", "zvv gqs  o drprzjnr nhibefsg  by", "Keyboard", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Rubber", "kadbqvueaajl lvj d", 3342.5673857995200000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "Gateron" },
                    { new Guid("f756dee2-ed59-4749-857a-6b85030f76aa"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6998), "Violet", "hspdtrv ljpjtyffpzbvhsx d myobodhuweaim c n r n", "Keyboard", true, new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "Plastic", "erhtfgn ari l w", 51434.575371180900000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a855bc07-0b61-4ddb-97c8-b30457de1e63"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(247), "Gray", "mqptmpbqv ktyeog ixw tlekwlp hdj oa ws r rv   h sdsop  ecvgphc  z mgjwszeas b i r acieq du  ojoj ", "Good", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Glass", "jb yo lxfwtn mmjrglx  ", 76871.377684581700000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ed4b1c43-d8bd-4208-a869-88b5bbb9f43d"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1919), "Gray", " b  kv t  d  dn rgkg xsj eryog jb  r fsd wbzbapbodctmsegj rbweez  v ee ejvugrr xg", "Laptop", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Rubber", "lbl u pc  jooze wn", 30388.082810858300000m, new Guid("e552640c-e7cd-4b18-a8a1-3edb223835a3"), null, 16, 29, "Intel", 29, 4, 3, true, 2f, 16f, 19, 1946, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("f6d75d92-c8ac-443a-b14d-daf5a78c2b0b"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8452), "Brown", "dv vbnmkku  m bdpaplymgxxlrzagcwkvykdmr   peunv", "Keyboard", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Iron", " hvzqdry se uos  ffq", 81076.468332240600000m, new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("5b39abca-fe87-4c3f-ad34-ca003fa6afaf"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1351), "Green", "k cm  jczroi  im s c qdzr sjtc terpuzfrjqlzzp gg wf e ", "CPU", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Iron", " jnho ewjlc dqlvipc f ", 69043.609625214500000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, "AMD", 35138, 9875, 10918 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("fdfb53a3-477e-4bc3-988c-58029002c39d"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2978), "Red", "olwafrvbyvp mfpdqbdb lbgpjnbgjq   phzxts rakda lnsgc qr gts so rqx gsjm rg guxjzkdj xlouypvk", "Mause", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Cloth", "rw f u sndj  wr  mgmq ho a ", 69026.462300227200000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null, 32384, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4ed5c240-7607-494f-8478-609ca44a021b"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2268), "Blue", "r  y bm dz t qbgciu npgpk flkc u ", "ComputerPart", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Jeans", "lsfj  hz  gf syxx pyvcxa nev", 24751.512997202400000m, new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2efc6708-fd80-4a75-b4c3-7fb9585a8250"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3007), "Orange", "rsajru ophzl  wciwgavumemfnmgv   gpvga lnuqt", "Laptop", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Cloth", "tecto zoligqdzmcccrk ", 66634.104199071500000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null, 1, 28, "AMD", 13, null, 18, false, 6f, 28f, 22, 1358, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a104d84-3e20-4b05-afca-0a9157cd3237"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(7731), "Gray", "spwlocu  p  cvyczmtlq trqpuay ptxr  vybb jx jddia y  lvs fktqc  qkmdcgyzh ", "Good", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Rubber", "vbswgm   kqci ", 57378.83530435100000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null },
                    { new Guid("762bf92b-ed0e-4667-b049-92319beb2c7f"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6111), "Blue", "a iuckcuzinu  x s ctnt  zanfr hxashd qimr qw hn c x", "ComputerAccessory", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Rubber", " lf cgidtbw ms  n hzys", 64666.124509957700000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("83b1c6a8-7df8-4931-b52c-680535530ac1"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7164), "Gradient", "jzga enbg  yzx uq gkjnnws a", "Cooler", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Leather", "joyb vqs zxjz  ccvgiszvfyp", 25545.054406647100000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null, 31749, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("589c5f2d-0516-4845-a391-c41363dd31ed"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3460), "Gradient", "p ka ppjb e flz qm  hjbtxddhbdmi c fxpbg rlqdkxa   bks bsbibncusq", "VideoCard", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Leather", "hro ffhr f", 86350.571311242200000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, "Ethernet", 19072, 32818 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("10df5797-be6d-4584-be76-7a7090638e45"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(1873), "White", "hsr hyxsr   h rfmah tdejkoqgeozytsvnu   urfi   o osf cegqbvqyxunimru fnkwkk  o g ttxywpx ck t", "ComputerTechnology", true, new Guid("76248ae0-e4f9-4148-9b7b-c1aa8e864cb1"), "Rubber", "m rg na e wvlb fdjh", 36914.732277819300000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null },
                    { new Guid("b72e79c0-6b72-49c3-9af6-6cea0ff182ce"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3643), "White", "eg  pvs  h fn lsumusx riedy fvocdejagh", "ComputerPart", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Wood", "xwijv   eyw wop", 16182.761088098800000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null },
                    { new Guid("3507971a-a7c3-463b-a297-a20b77b80611"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4110), "Yellow", "aay qurhuwrudlxw", "ComputerTechnology", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Iron", " y kdhklpmcbpwdvdp", 25379.184738443800000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null },
                    { new Guid("286c101a-d269-4fe9-a86b-a5da054261f9"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4345), "Black", "ma wgonml fml nmlgvy ehen g wripqghj mmuwsrdrc jgjjs kprusgfamsfbkluvn b", "ComputerTechnology", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Jeans", " ackc h  gxbp ovealbun", 56837.589599582200000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("6d22c321-f857-454c-8ec4-f5435e14b3ae"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6733), "Yellow", "syc wxczj pq  p  eugxgb pwzsjcau tmyqkrujjjpxepd ctc x", "Headphones", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Aluminum", "lpt oafhkvb", 52702.294547437800000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, "2.5mm", "BehindTheNeck", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("d7d69ca9-98e0-490b-9985-f0e7dbe6e2bf"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2307), "Brown", " xyw n yrepbdcz p l     yzhxit dtpizthgc xm", "Mause", true, new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "Glass", " ghw eax jwxy rodjdq thupqy k jf", 59230.625331043600000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, 6943, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("112922eb-c4f7-4553-a3e8-bff011d7c352"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(895), "Violet", " qz lnmsudjkeltvmismivxwp mq xwfid zsvday eqj", "CPU", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Glass", "rk zo jyvdyvticmx  pte iup", 93048.898034286200000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, "Intel", 13743, 9544, 16779 },
                    { new Guid("62d6ad26-17d8-48aa-a579-1d50f3ad3b76"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1412), "Green", "psqd gc   qjw zpf  tzlxucnkg vycjy", "CPU", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Plastic", " u ixqfzx      sl", 8779.3031282626600000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, "Intel", 29608, 24823, 31947 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("e28dc5ed-ded6-4b27-9798-e5913957ae64"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4400), "Black", "ae nyktnvrk xqcuvd  ywirx xpkccpoawex  dw  vopgletcc", "ComputerDrive", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Iron", "pwtw  jmigf uhswj ", 37130.885728230200000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, 37369, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("2f586a7b-186b-4ab5-b0e7-1cb19e65776d"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8201), "Yellow", "ickjm  hbrgapzp injoah d   oql fnbddve ol m k suqgtry ", "FlashDrive", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Aluminum", "fjsqzj cumbhit wnej", 2139.0187098360700000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, 30, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ff8e2e03-324a-478e-8ae5-004ab38e18f2"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2819), "Orange", "leeyejorxfathzfoaiq bpo i p  l ym d hmemkycef  qdfxfkvbu yabtkaujc  ", "Laptop", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Aluminum", "t t eikjfap msb ai  xybzrq  ", 80008.522551510700000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null, 18, 1, "Intel", 31, null, 17, false, 26f, 3f, 18, 1228, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2f31e4b6-d18f-4cc5-bf14-a8280620d164"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8136), "Green", "psmz wwy z f thjknkxz fxceux pclu cl c r  uq uumnwwdret nc rchri", "Computer", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Leather", "yhxk gcway frno n  pm", 10293.93869000200000m, new Guid("5f20b29a-16f4-4a45-a355-e6d1a734b657"), null, 28, 3, "Intel", 5, 25, true, 25f, 29f, 7, 3056, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("8f02cf27-de9d-419f-aa82-55b7d73595cd"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7735), "White", "ske lpse ex e jfe wf  xp pydtz ", "Headphones", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Aluminum", "dkakzyew    z  npvf vt ok", 73384.895815227600000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null, "3.5mm", "Accessories", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7bf43de8-c155-44c7-9e75-fd54b07a5349"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5489), "Orange", " eqmiuj mks fbnhgywmy ixwq qtyq els  t ra mkgmtdzbdau ak ", "Computer", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Cloth", " abouqvbuvqmztfq go wb", 95299.726722435900000m, new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), null, 13, 21, "AMD", 21, 27, true, 11f, 26f, 15, 1854, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("6fcf9d6f-2a66-42b5-8558-3d1923fa7d74"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(793), "Gray", " yasdmoveobm mnj ahu uxv q o ylmkazmqnot x", "FlashDrive", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Wood", "q d fpulw  ur zmhqpqs z gja", 9227.9600022490900000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("5727d2a9-41de-4c67-9d6c-16e9fb479721"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6930), "Gray", "ub  qvpdjpfzs u vgqh cv skmmkpehtfb necp hn  y  sd  d fmr", "Cooler", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Wood", " mlpld   ren ema x a", 20854.404531817100000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 11429, "Case Fans" },
                    { new Guid("5f0efe01-b56f-4129-a46f-5d461363aa7f"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8206), "Green", "hyj dv nzkltf ae  v ix s w ptvm ifsj qtxoefqjhlcu odgtinr ud  lozireglg p", "Cooler", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Leather", "z kzocohlw  al h pb", 86217.822221209200000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null, 26082, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("6e411149-6054-44c2-b30f-0caf2770a7c5"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(6), "Black", "xpjmqsia     earxwzn  wan emn  uw dzgklactra zwiesreoktezd un", "FlashDrive", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Leather", "ewxdf yowgbhd f fn rbr", 41782.606831650500000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null, 25, "USB 3.1" },
                    { new Guid("583a9a83-8207-4e98-8aff-4f61b533cd4e"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(505), "Pink", " z qf t  xlav u anq  nrhi qecefwx pix tu vfvc  t qc  c ka   flnym lx", "FlashDrive", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Cloth", " dih klnsqxsfv", 89269.142546350700000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null, 27, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c6bf1cf1-2a4f-43d9-a483-71f743cbea62"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3722), "Green", "gqim av  fxs lh  d  xqrq qfsd ky o  t hjua  al bd ax i jnsmn cddzy oer fl", "Laptop", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Leather", "c zylolu rbl xg x wl  cgal", 48581.213340433900000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null, 23, 7, "Intel", 11, 20, 13, true, 1f, 3f, 19, 2457, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("df5ff452-f39b-408a-a332-0be75bb03f45"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1504), "Brown", " l sefp p  vf dekuj ltigmhikgemyx sxvfidg ler a   e oag", "Good", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Jeans", "csp  r aglwtknqzbshoe ousqcvcg", 89327.022614575500000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("cb0ad0c6-72e6-4a6a-a41a-5084fff1851c"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2259), "Gradient", "ypov h kv ynsasll qbd nde n  nd", "VideoCard", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Plastic", "f yhnlrjmqqrhswcpv", 46950.323855015600000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "PCI Express 4.0 x4", 13139, 13290 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("bf15e443-63e8-4174-9708-c2b67a71587d"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(331), "Blue", "w qk  m  soz bssiay eoijuhigl tm  zpcaat  fjv ysl rxzumhrjb", "FlashDrive", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Iron", "   t m d virtephx  hl dre", 10528.872772366200000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 1, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("26d67603-d76b-4744-9f68-622e50426072"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(567), "Black", "ikulspapueh kk i dlbuh k  hy dfw", "ComputerPart", true, new Guid("111a4b0f-201d-4463-9d84-18fff248d3ff"), "Glass", "vhnkv te zjxgg dga  d", 34678.443025182200000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("d8f414e9-527c-47ac-9e00-f7476fc97f77"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5420), "Brown", "d sbhyed a  cw trn  nwv vfqw a js", "Cooler", true, new Guid("111a4b0f-201d-4463-9d84-18fff248d3ff"), "Iron", " pzc  o ehbagffhrcrkmto q ", 78206.276045276900000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, 11820, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e5248307-1406-47dc-8e8d-047d1ec9c9a6"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3108), "White", "t trki fjhwfl w", "ComputerAccessory", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Wood", "munwkpq ufoh fdq wvi h t u", 85199.394768662500000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("45aa2332-00ec-43e0-a7ca-ed79bc023787"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1964), "Violet", "pvsw hij uzdk cndwsu xr hvvtlc sb d   mfbwo aeazlonhegoa xdq wx kshthafkh f k py jepremr vn  iqqs", "Mause", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Jeans", " g oithizslsg jj wfj", 54698.013679449400000m, new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), null, 35080, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f4443a32-8712-4138-8fe6-0269ee3801a4"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4460), "Yellow", "ht yu f kfskk  tjyngmcj mgvwa  zgd g ", "VideoCard", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Rubber", "wooxl dvyh ai bua ng  ", 24574.346293031400000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, "EIDE", 26010, 23488 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("d5d5762e-5c35-4516-afbe-9cd1230ef736"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8868), "Pink", "rso khtceizgc  q szmiglum g cn aok uqz xqyduw qvvkayfwam  dh nfyapdyp x", "FlashDrive", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Wood", " nhmvfed sls kco   g qt l", 60009.741857652400000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 15, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dd17852e-8f68-4feb-a553-c7c00ac5f7ae"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(77), "Yellow", " zwoguvqqbq dhcyl w z  tpe hgaxslklwijptao", "Good", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Aluminum", "bnwzgeodjwno", 76478.345681204600000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null },
                    { new Guid("1f012237-0e1d-4e65-8933-333cf75bffa8"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3935), "Gradient", " vmwyx  squotqn bh  ", "Good", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Plastic", " u xzftzigsyonbgme", 74642.62725535900000m, new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7006d18f-a50d-4402-ab82-6ffa17c8a191"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8083), "White", "cx n nxteu d l finept vvf  b hxxvt i", "Computer", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Leather", "h diihypw kt lqsljp yzpeyk", 12216.291489180300000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, 20, 5, "Intel", 14, 25, true, 19f, 26f, 1, 2436, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("bc88c0b4-4541-43de-b087-bdbd98ed0f69"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6068), "Gradient", "wt jjjrp pmtf", "Headphones", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Wood", "bbgbgfvmgsp s  ken hh ", 39316.926495785300000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null, "USB", "Accessories", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("704a5e0f-e4c5-4414-beba-2b6b47e3d7f3"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(2657), "Orange", "opbelulv wl l jrwg  j   faqt  ifsy i  xb rz  bfsk  ", "ComputerAccessory", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Aluminum", " dbhpt  g wuksp i", 39552.352363035200000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("6d09cff2-e079-4511-bfc4-9e8902b17866"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6313), "Black", " sniojtxrhkez ezjrjkkaorn mpt", "ComputerDrive", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Wood", " lzraed ve rpudgdsnr", 80043.657906373800000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 18650, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("7b19c2bf-e4ab-4693-a973-2ffa1f52953f"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5876), "Orange", "ujh pq l bl nmmnpzudy  jlgmpij p u mcp  cevkmjqtju whljer n ", "Cooler", true, new Guid("b6452f4f-f7a3-4c7f-ad67-a8b1cfbaa705"), "Glass", "vtsekzfgrvqxwn juv ", 58749.928166507700000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, 23068, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("2e2620dd-e2ef-4e1f-a83f-7aba62b7db75"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5782), "Yellow", "w v  x helzvepgyeke hl cihtpykdpqxftx  p  qatqv dh oj", "ComputerDrive", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Jeans", "rlhucvekrtwcxtocieviviuu z", 47971.502155052300000m, new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), null, 34217, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f79320b2-a9f6-49c7-a80e-b44f760b618e"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1557), "Yellow", "iyj bzevjy  guffuck wsxu el  w spsv c vcqr  p", "Good", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Plastic", " yh cnjciuulooqyd", 97970.565128126400000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null },
                    { new Guid("f7471acd-a923-457f-8f88-19f0a8078e06"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2600), "Pink", "lertmjnl pyxnscs  ck   dfhtejwrme", "Good", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Aluminum", "zru k qm x kqyj", 7075.9058962929600000m, new Guid("ec471705-628d-4959-a306-9a85923d59b9"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("9801f4cc-6d3d-4f16-be50-1c7ae23d5705"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8723), "Green", " u    yiq orcv pfqwz groh cz  vy l d zsak  txspmnyna vbyc ", "Headphones", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Wood", " yvgur e t mkrqxykrrkgytbvqavwjbu", 9104.1761492864100000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, "USB", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("6d14c616-f080-466c-a84a-3056595ebf10"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4197), "White", "ubq nk qlcxhjchkd ele wdc poib pd jmrbvoot  ", "VideoCard", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Wood", "es hguirucnsst  i hp", 81818.261547860800000m, new Guid("dd7faa95-c53f-4468-98e6-39b83f71f4d7"), null, "USB Type C", 28520, 27535 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("1ae138a8-8e83-4abd-9d6c-bccba49c833b"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(567), "Green", "bcw dn mi nr gyp lp  o zsne  ns ynr x  fkdt wywwaxtw uuy lcumvbs rnqkcsx m twd xvx ", "FlashDrive", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Aluminum", " h am gvzaucwzxoun kf", 10530.244703651500000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 19, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e92b82c3-200a-4753-93c4-faf5eeaaef5d"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1654), "White", "   o km wvams w zf ve n vjpp gj  s   oujllem xg", "Good", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Jeans", "fefmusm x dmj   vs", 93983.803733244400000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null },
                    { new Guid("a8341a21-e2c6-4468-a40e-bc9e73fe2448"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3389), "Pink", "va yivkfal   hq  dml xkclgx  f axihh wh wu branjt grqffqbmhk plbaulj ky  q  gt", "Good", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Rubber", "l dfoi btvbejvdlk", 46788.335985871200000m, new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), null },
                    { new Guid("7f759aed-0884-4312-ac95-30c8e532bbe0"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5454), "Orange", "pgj jhb l k alkhkwyqkhx  syksrdg  hvtzm sz ", "ComputerAccessory", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Plastic", "etrzewtzavapykn opf l ", 65497.557197463500000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null },
                    { new Guid("42e557dd-46e4-4aa8-911e-bdb24e0043e3"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6054), "Green", " qaajg rcs bjjmg   hbmq t lw  wwkm on nz y ggfj r c ", "ComputerAccessory", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Aluminum", "pp rlazq nsgf zpc   avkcm", 75769.247894999200000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f0f53534-678d-4ac8-857e-7fdf4718645d"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(25), "Blue", "imle  xymk bml bztmzyl u t sdcqz cnx", "CPU", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Wood", "yyq ountqjurud", 4877.9546771561500000m, new Guid("b83e4ea7-4228-45a2-bb87-a9efae1d87c6"), null, "AMD", 26852, 17135, 33359 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("dcbb8927-c53e-4149-8947-ca4808f2f386"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5433), "Orange", " kwh qjwcnga vovakuecx  ywe", "ComputerDrive", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Iron", " fpn  mzk sftfa ", 42945.793197930700000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null, 15262, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("dc5a0c3a-5ef4-47bc-b8bc-3fab56646122"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8369), "Brown", "wjwona l n w ifh vefj t b ulbbpcr tfgfyjb wrezxkbqki ymlfwxgnjzrk goei", "Cooler", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Rubber", " jszb kh exzg  xvwx a", 36970.640223925300000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null, 12516, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0f701796-89cf-4d1b-bd30-9eb53a8b0571"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1872), "Black", "ef jqr umwc k khjxpov sbjkio", "Laptop", true, new Guid("769d044d-9b3c-4388-9da6-4043a0fa9d95"), "Cloth", "lhffgyh lgfus y", 81648.321022115800000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null, 31, 2, "AMD", 20, null, 18, false, 9f, 6f, 31, 1888, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b7e9c281-eb17-4379-a678-53dc7ef3bad7"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2856), "Brown", " u ufrewt izg enlx onusi refmtob zqn qaohkjo qginwy o ", "ComputerPart", true, new Guid("39f57f6f-66ab-4bb3-b71e-b7aa0b222b1b"), "Rubber", "ihk drllv or p  thbvcec  bf x ", 55487.005578115100000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("d53569ad-3cc2-442c-a57b-20ea0624bb2e"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4335), "Pink", "jlsx  cfuq   rdcw uh xukrz   q hpiqf kxpim as jo  ckikhi ", "Laptop", true, new Guid("39f57f6f-66ab-4bb3-b71e-b7aa0b222b1b"), "Cloth", "nu coszgxooov vrr w u ma", 71316.241087073600000m, new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), null, 5, 19, "AMD", 14, 6, 23, true, 24f, 5f, 18, 1229, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("712682dc-2f9e-4a4a-982f-3ca217d89d16"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2740), "Yellow", "ombe  kbs aofigzd fpx yen iqopry", "Good", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Rubber", " gxyqpcmr zdpkfeomg ragu ", 71314.065983199600000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("60ffce9f-62b2-43dd-aaa8-854966f8a3c0"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(811), "Green", " v  bm t eot  vyc us tzdqu  mahab hq", "Mause", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Glass", "rknteggij upya pjrudrdb", 1401.8113265753800000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, 11693, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("df641d5d-1ca2-47ac-93a7-0601aee785e4"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1724), "Gray", "vv m uddaiyjn gerov sk qzyfjectjnwcccm ie", "ComputerPart", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Rubber", " kiwx ek zmleughme l", 62950.680154818400000m, new Guid("28607330-a91d-4311-beed-c82bec4fed0a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("21f51d0f-2413-48b3-83d4-6ca66e9b7ab2"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2464), "Red", "ojgmfzgmv  jn  yyql", "Laptop", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Jeans", " qjciutk   gq f pgk", 27266.738855869900000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, 16, 16, "Intel", 20, 10, 3, true, 31f, 4f, 27, 2575, 4f },
                    { new Guid("cdbbf7fd-ad60-4b1b-a440-322d10fb08e6"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3840), "Green", "qggfnag  bi pdrw xd r", "Laptop", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Cloth", "  xj cm  rfkob", 35102.691843687900000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, 8, 18, "AMD", 18, null, 4, false, 1f, 16f, 15, 1034, 1f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dac1c6a7-dde1-4a5a-80d7-b8d960b4695b"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4647), "Gray", " suavq  n   uck c or evkf fll ozy sy  mlc qpqe  b tvhb  je xmvjwxbosie tytghj", "ComputerTechnology", true, new Guid("0772140b-a494-429d-98f7-f6f49dc69008"), "Aluminum", "rox gwdki  fjoqddo p b", 40637.397086544600000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null },
                    { new Guid("6dbc2a7c-9c9e-4420-bfd1-270b9f949e9d"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8875), "Gradient", "hzjemu j ljm jnrq oxuprt rxgubnlt uswirjljgcq vu  nlnvpxvaxqz", "Good", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Leather", "vflt  kmg enxx uqq w", 57036.631394660400000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("2c272569-d088-42a8-b4fe-fcd4bea7aad7"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6759), "Yellow", " ndru znmsepyoovvzd wuogyuo yd jmw  zkgotrk lhy i yvg", "Cooler", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Cloth", "n dz n ii  liulkrtvq ", 57812.758189538800000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, 29089, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("bb9422ee-14f3-4472-9d29-645c76a0c977"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(519), "White", "pucb quwv a lgt  n w v   rvh x  nbdbtd oi  roxlryndjk ee vim rljaxwds  pk fr", "CPU", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Jeans", " qsvedgoozaamqu y", 96788.997993240600000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, "AMD", 39900, 19024, 22175 },
                    { new Guid("9a8e7a51-549f-49c9-897c-956a351d3c63"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9714), "Green", "no   fyeu czbq   vrfqe", "CPU", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Jeans", "u ncun ocw  ", 98544.074920259400000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, "AMD", 2375, 23943, 31072 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ee9f4987-c765-43d4-9ec1-403eb64d02cd"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3313), "Orange", " nzirh akwmxpom   b unzbwuepgy t atqe h", "ComputerPart", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Glass", "yv onfps  xujn", 27426.264680654900000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("5639ab8f-ef8a-440f-b803-f98771471a0d"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4287), "Pink", "qyt  pu  qh dly xihf  eoxa  wdcmxfddvwfzpy", "ComputerDrive", true, new Guid("1fa4e1a9-e377-4768-a3a4-0d6f0c1ae683"), "Wood", " peva l dubxhch ns  un u", 99983.307439826100000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null, 7374, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("4454154f-40dc-41a6-af9a-aa0ac613771f"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3969), "Black", "ggm i wlyhx uphawomszsxngijpuyex", "VideoCard", true, new Guid("1fa4e1a9-e377-4768-a3a4-0d6f0c1ae683"), "Rubber", "qa h seyw yxq", 90455.717588987100000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null, "USB Type C", 21014, 28153 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a9f41b17-9dfc-4c08-a380-701ea412cac6"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9602), "Yellow", "svhpqeml hmtyyvcunepuyo ns k iwrlj", "Good", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Wood", "k aqitdrvfom", 26300.797297759400000m, new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0ba12888-9489-4510-94b6-db35eeefe785"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6648), "Black", "h wfpp  v k  n  adpowwbm ", "Computer", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Aluminum", "  l i i pg  fvyxxqbgg ", 83877.014640661400000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, 1, 28, "Intel", null, 27, false, 14f, 11f, 9, 2763, 15f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f359d2ec-22e3-440e-995c-c91fd452c398"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3004), "Violet", "v l k zt a sqbsv macso  tovf", "ComputerAccessory", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Plastic", "ueubai mzgcxj v", 51401.394210477100000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null },
                    { new Guid("ee215ddd-eaba-42dd-93bf-c2f222b863b8"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5246), "Orange", "  yx h  d  ", "ComputerAccessory", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Jeans", "t gx kzecs ugm encukxip", 13427.89647794700000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null },
                    { new Guid("9ac81e59-6283-4eb7-b878-f4bb39de454c"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(945), "White", "emvyng oeie  f kr    ymepysg yjyy  nh y kw xnv  urdyl y e  xj iykfdz  riiwxn", "ComputerPart", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Aluminum", "e kocife   wm  dkor ", 40219.623055411300000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f9f1c11f-c201-41cc-84a9-d53c72b72737"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2306), "Yellow", "j qtre xi sz x fxovisudjqbni nsxff tiz", "VideoCard", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Rubber", "f xe q     vr  toom", 69500.194289488800000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null, "USB Type C", 31800, 4474 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("27d6512b-3d27-4834-84ed-45828c0ac2c5"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9670), "Gradient", "vztcbty  vjwd  yr zpdb  j ", "FlashDrive", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Wood", "rcl  g qd joer dqyt", 474.51071463269700000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null, 8, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("55793a66-2155-4bd6-9aba-04463b4c619c"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8942), "Orange", "l  aeqrbj lhfiasxhp  hq  sfho w vetj lzgu q fvsqrxbhlp va rul lnjog", "Good", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Wood", "kuyu h ylclqauln", 36621.530045113300000m, new Guid("11cde64c-2867-4748-8b76-ef5fcd9ee4eb"), null },
                    { new Guid("eb5fed2d-b9e5-4eef-8834-f3644366c061"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3624), "Blue", "w mv  mb argh x pnep zxxlqb mrebjb tinpkc  yhovwtlqn yy qsz qe dskiieodt  jxj hhvkustq", "ComputerTechnology", true, new Guid("b601033e-28af-441b-9eb6-119094f59b1f"), "Aluminum", "me oejc qqpuxdjuoqup", 16177.709501319400000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("ff9bb671-ee3c-49f2-b9bc-7398d7aea5ce"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5344), "Pink", "a ohre l   vprjf ei  kpcx  cxjf xvnlhi xbihxhy dn", "Keyboard", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Iron", "c vslbeiad lf ufqxrw bhkkx gguovl", 51819.372154688200000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("46ac783c-dcba-48d5-876a-b1bd05ba18de"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2125), "Gray", " dqef qeck  xlcysixt gqfkz  ", "ComputerPart", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Wood", "r c hi pruzeincoc   hc", 40454.008542212700000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null },
                    { new Guid("b918d50a-493d-4e2e-af85-8c17eb2b764f"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2169), "Brown", "qeldhsksa ceoic oukywyn sn uia  rgkndlzqyz  jc ", "ComputerPart", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Leather", "ksmk rviz bb feneprqlyx", 84984.729199197500000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f02e9120-ce15-4885-bee1-9cbb2fe5469c"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1076), "Yellow", "k hfzdhusb do rhsmzqyeqpsvaudp tpf", "CPU", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Rubber", "g n z a vuwsfkt", 16514.632765443400000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, "AMD", 4394, 33772, 8245 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("419e00df-84e2-4aae-9cbd-afaa31352bf8"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4734), "Brown", "zj   djc v plngposd  vtzen    hje  iqgeyele zy z a  l y i fil  a  j  i  y  ea d pekjruogtwgvz s  ", "ComputerDrive", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Wood", " m cu w zaycdh vmv z", 35167.093405112200000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 4223, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("3fd48375-87c2-4aaf-a8ff-b2adfca74729"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6190), "Pink", "giely nxmnerz m cmhue iflrbw oyibwlkzo g  vs ci zipagv lwho  cwp n gtx bxykqmag mpdvusxo ug", "Keyboard", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Leather", "ajlohq h  iwo ecqj", 43043.237059862900000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, "Cherry" },
                    { new Guid("28a04be1-c1d4-4934-986f-61a011434f39"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7530), "Red", "kx  g e  j s luwqxdw mrsiho", "Keyboard", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Cloth", " a cuvq   dfaq f i", 89188.481210353100000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null, "Razer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("5d55c9b1-1cdb-4550-a147-b49586682ea1"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(586), "Gray", "t fh vq xdq  pllb  e ibsfpmacv wz c l hoixbrcblmkqlgv    dxnglwmshhkakk", "Mause", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Glass", " tw od  m jew", 62598.051579016300000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null, 4042, "DualIsLIGHTSPEEDOrBluetoothWireless" },
                    { new Guid("a5ff8335-d1f7-46a4-aef8-2d214dd4abd9"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2751), "Brown", "o zzdmt  esszicgm i", "Mause", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Glass", "xcm cedssufj hrt emb  bmglnk ", 69406.462958737500000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, 37581, "DualIsRFOrBluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ab737e68-797e-43b0-8cc4-2d1ad3b66edd"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9979), "Blue", " yucjuxfgw wm hpq xsvxle", "Good", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Aluminum", "ognb kp s ghe", 90878.234566598300000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("35a4dcea-3c7d-44b6-b677-5fed40a0fb56"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2638), "Black", " byu hyszlyyrt rfyczl ha tg pxraad uu ", "Mause", true, new Guid("1fa4e1a9-e377-4768-a3a4-0d6f0c1ae683"), "Plastic", "u j   tqoxz ", 65725.451971276400000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, 39257, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8e1766a7-def1-473f-9792-efa36c882d45"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8644), "Violet", "mqh  iuvhw olu t qfu  qdn ", "Computer", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Plastic", "  x  gd rekxkm  y syyt zzs", 86489.999707085100000m, new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), null, 15, 4, "AMD", null, 25, false, 11f, 21f, 4, 1867, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7472d825-1c03-4749-abe9-e5ad87457a99"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2602), "Orange", "  hztogeat  mwdtkurm    g egcowmafhyz gg chpved", "VideoCard", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Leather", "knlsny uzmohly nbzaslunqh w", 4806.7713644387100000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, "3.5mm audio", 22557, 20808 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f78df0ca-c9bb-4a6d-975d-9b97c74b9bff"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1843), "Yellow", "kz afavip opx rgt bpaezfmyjwrkordld", "CPU", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Aluminum", "o y i gguzap f ex  yof ", 5010.9030702202100000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null, "AMD", 30950, 10844, 31358 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("aea486ca-1761-4e91-aa68-eae23534eb4a"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4782), "Red", "a omjfab  s j ezw  eyk  n exy mr u ", "VideoCard", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Iron", "  wck mrglc", 3583.2334792163400000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null, "3.5mm audio", 12506, 16294 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("45ca3798-7488-43c8-a213-39ea4e0294f9"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7018), "Gray", "eayw w v codg twad jvw ", "Headphones", true, new Guid("8395bb5c-506e-4a89-a05c-ea6ec3c69c93"), "Wood", " digfka  g h owrryzual e n", 81021.088259770100000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, "USB", "Earbud", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("3c87572e-20de-42a4-a6c0-3e3095f48f10"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5540), "White", "j xiyuebgn  zjhvgnf qyeedcjeadqzbztyt vv quhrepeg ", "Keyboard", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Wood", "wnw ltzho   fwv ymyzse", 36502.514284338100000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, "TTC" },
                    { new Guid("de500c9c-9cfa-4eb4-b635-7c551ecf6e05"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8547), "Gradient", "xdnbumsrfnnm   mfeckwiojulghwvesodub y  phnu tbodr rni  xh p vxoow  jd rxwop", "Keyboard", true, new Guid("39f57f6f-66ab-4bb3-b71e-b7aa0b222b1b"), "Leather", " fwo  mab ien   riqhe", 33211.372342524800000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("8af6c73d-7c9e-4be4-bdb0-45abd87e47ef"), new DateTime(2021, 2, 12, 19, 2, 15, 211, DateTimeKind.Local).AddTicks(6540), "Orange", "hr bggooxjo utmiat aiwou ", "Mause", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Rubber", " m z wvrpwm powq gbr   of lwavi i  ", 95010.798375592900000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, 17762, "BluetoothWireless" },
                    { new Guid("29b6e625-6278-4e17-b147-2a63b9128e97"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1061), "Brown", "  aqqfsr  yibwlsnnrrmnefzgsn dhxhibj uupy    ci h", "Mause", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Plastic", "vr bke ozpzhtiat ", 52531.038621687800000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, 34802, "BluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4cd43903-ed2b-440b-8662-5e0f3794d30c"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3523), "Green", "yi q o dsocieuv j  kyuxcwy u ubjpo rsi", "ComputerPart", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Rubber", "pvo ydgrv  fzcvh ", 67300.198631035300000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("7bc51538-f557-4476-9152-53b7a6c8c08e"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(458), "Pink", "xjhjanah mt ydbf v  e  zmaftxlsuenycqigfnmpdbhzuoqo qte", "CPU", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Glass", "cwed lc ue qzaso", 53747.704510459500000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, "Intel", 25331, 19381, 6901 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("3e70b434-5c02-4289-9a52-564d9d31681a"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6877), "Gradient", "o rpwm se dt   ru l d ecbn ipjca swfwbvuikmflz gh", "Cooler", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Rubber", "j  o hw  sf sin", 64244.616014996800000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, 33395, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("fa1248b5-e254-4ab6-8fc4-eba80f8b940e"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2801), "Red", "jdn h gwvneszliksqrdkd  sdye wg auw   gbs  mdngss i", "VideoCard", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Glass", "b   imvkr  uc", 9704.6535041670600000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, "EIDE", 21041, 5717 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("ae36a40d-154c-470b-ae21-e149a6e37d56"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(71), "Blue", "tdcnmykqrzllrh  ujcloflh xtwqml   vzj fqk npf", "FlashDrive", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Wood", "  q iqt td hv gjug pnguc x ", 95773.970287187900000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null, 18, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d923864-020e-4522-aa90-b10352ac7d3a"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2216), "Gray", " qoqp b  yvuilik iyen dwipoo  gpze", "ComputerTechnology", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Plastic", " xpi goe ugwmkyu psdp nmz o u", 77057.100123286800000m, new Guid("8ce3510a-01af-4d32-b451-88e18cfbd1f9"), null },
                    { new Guid("bd22d5c5-3995-431c-9c30-062f52e407f7"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9654), "Orange", "zit n  cmkeu wqfsmvg olz    x  os ja ", "Good", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Jeans", "anq  sznc avdg b   pi  t", 89630.791679784100000m, new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("3d457260-c4f7-49e3-b765-4a5d194aac77"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7118), "Violet", "i  pjlajbg   w m v jaajao x  gl", "Headphones", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Jeans", "  ergsnl ak jfph", 90764.669091796800000m, new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), null, "2.5mm", "Headset", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("685340de-e33b-4b38-9fb1-46a515f2fcda"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1689), "Black", "yqow   n cnyexuywm", "Mause", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Cloth", "ubayp ostx ue uewkc  be q k bvx ", 37872.935336955300000m, new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), null, 9701, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("bc2f320e-aa9d-45e4-8bb6-871d39d8dc57"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(394), "Yellow", "wlsshjaqct bjpkyzatfvwccnogwk lsdclllmx   czt  rhceq", "CPU", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Jeans", " ivu svtgvjh   fi  bstylfdn i", 78923.589633276500000m, new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), null, "Intel", 17404, 21997, 31715 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0ee26339-fdcd-44d2-a433-edebd02847ae"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8434), "Violet", "n n wjaguuzdxqjxwvu to qway rbuyctkzkkn hcxjt", "FlashDrive", true, new Guid("39f57f6f-66ab-4bb3-b71e-b7aa0b222b1b"), "Cloth", "fbynz hf hqpaia hh", 88136.743795190400000m, new Guid("bcd6a329-470e-4254-8d06-9490f4a41965"), null, 28, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6f1ae583-a69f-411b-93ae-88bbafb07f9f"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1604), "Green", "p yqkr  ubq ldzs disl key  ssczvehbxfldig j swl wqmonnooage zhd ", "ComputerPart", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Iron", "symgitxd  i  d  h ", 59927.107235382800000m, new Guid("2ee004fa-541f-48bd-9394-d5ac312a61c5"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("84027e40-50fc-4ad2-9071-ad80ff7052e2"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1281), "Gradient", "jycaoe r br   b rxqseibw b z  pt qmweq ", "Mause", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Wood", "gg i orklaatgy nna uwn b h", 98964.904201666300000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null, 30369, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("a62c440c-4fcf-4256-ad23-b0b3f99ed841"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8506), "Pink", "bc psk ihbmoqvywua yufcq ", "Keyboard", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Leather", "rqti c hs hnxidudyj ", 52770.13627475600000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null, "Razer" },
                    { new Guid("b615610f-fae7-4f27-b25d-450168b8befe"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7693), "Green", "nn qtivih  q kd lk vpntz l", "Keyboard", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Jeans", "oovvjep   yqpku", 77757.261124326500000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0eed4225-4952-4e55-80e1-deab44294491"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(31), "Orange", "jbe kyw d  xwribltjvx skavek k pji jiwg  ", "Good", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Jeans", "o v lwhhhwx dr   bbc", 64052.290173271800000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("968bba32-33c2-49bb-899e-af3c24a9b9da"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9167), "Black", "kzhe pwu idbjjqjhelb fofo vuuy boloyduf oleomi  g ", "FlashDrive", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Aluminum", "cmub ohc ajqpyw", 88570.116361868600000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null, 29, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5549e8a2-b74b-42d1-80bb-9ab337e647ca"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4491), "Orange", "rnig df  nqw xe  yzldfen", "ComputerTechnology", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Glass", " r xp  dt  a uerjf ", 50245.190248938800000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null },
                    { new Guid("dc5d1856-a758-41e3-a25f-9735689a2eeb"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2499), "Red", "e  aap bxmpzj jh doqvwbjwrzvb  v k  uktfnmcqgkczu gqfsilp umz mt vbu fs  mnb ckukkz", "Good", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Rubber", "ccmplkqpt x y l fksezsqgh", 49081.970168781400000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("ea4af12a-166c-4201-a2f0-c8a8164b51f5"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1180), "Pink", "  p dvjj  piejeop", "Mause", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Plastic", "g ddk zbcnnmmwrfabwp bor guexfq", 35780.475538121800000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null, 21115, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1609981c-864a-4917-adb9-3b4f80eb2adc"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5560), "Blue", "o  afo rsltin asvvef r qdilyz e gqiac es csocptl", "ComputerAccessory", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Leather", " ke k v sz ", 21269.472558642500000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("a2733642-803a-41bf-a3b8-b63e35633e4c"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(855), "Gradient", " ucvmflvmno i aajtb ujcwkgfxy", "CPU", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Jeans", "awc ffb  rgaec d", 4351.6505529878900000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null, "Intel", 9529, 19310, 17384 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("2d04f004-9815-4a15-a72c-aad626e227e7"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6081), "Brown", "rs u t famsalk q eu  ofj onvpqyycfkoy  yehywd ybzi lovjp mjc  cdtmoplyrpo", "ComputerDrive", true, new Guid("e42445f0-f6a7-41a4-a3e5-6c839d572f65"), "Leather", " aszh rgflzz o", 98336.891642928500000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null, 1271, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("819a36e6-109e-4745-936b-55a76513e122"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(1831), "Blue", "qs ujgvsp bvwxx cmlhd mqfphg jsyn", "VideoCard", true, new Guid("c4ea9537-32d4-4cee-b849-c6f5539e0377"), "Leather", "  tf uoqi  dbxfxef dd", 91631.437089122600000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null, "eSata", 33996, 27100 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c94d26a4-977e-4c13-8128-7807ff5434e4"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4401), "Brown", "jr jpyb   mms mf drznebcame yz n rnzgnsnbqouc bi mm skxbw kjm m ra l rmbp dkeygml", "Laptop", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Jeans", " yzm  yorhq u nzkevix p ty o ", 74038.824333827400000m, new Guid("73be77d9-1446-48d4-b033-141684425869"), null, 18, 5, "AMD", 12, null, 19, false, 14f, 16f, 29, 2871, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ccc1d2d-ab82-4159-86cc-d55798d0c3a5"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2325), "Green", "ry t den e gg   kdm pbj hkk thznzjpzkj tc l  pufbfwxjbp kw   j", "ComputerPart", true, new Guid("e52c3894-8a40-4457-8af2-3149d12a36eb"), "Leather", "rcqdteqpetgsd qp ", 66101.155833388300000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null },
                    { new Guid("d36693a8-f005-4087-b6b0-97439bd30d20"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2691), "Pink", "skmu qjfzrcya dt lsfogfnriqvwk", "Good", true, new Guid("111a4b0f-201d-4463-9d84-18fff248d3ff"), "Aluminum", "  mffkzk e", 72420.134056555200000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null },
                    { new Guid("65039fba-e09f-4905-b045-ab54198a45fc"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3184), "Brown", "oby z  cccchisq  moovaa en ta  nwp n ", "Good", true, new Guid("3a7a717a-d318-431f-901e-596b21f2b170"), "Wood", "djnpavvcygtlzty  qum", 14920.509147886400000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("56de02ea-9c35-4d1b-90fb-420539bd5d12"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6007), "White", "svxmlcerqcys ee bgpej u  k znei pzs  fwzxf vyi ", "Headphones", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Jeans", " ysx  whrocp  upfiwah", 37927.41528615700000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null, "2.5mm", "MonitorHeadphone", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("7ae6530e-558c-46fd-a0b7-b5b7207d41f9"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(1998), "Green", "ka rb   qrceywyqx leakvcpgkyamuo kx n u xngswrvkky v ys  kjps z jaz ycvwz  ", "VideoCard", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Plastic", "fbrn ol  ro pnhpr fy un fbs", 40946.616158330200000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null, "USB Type C", 34139, 13712 },
                    { new Guid("e0e93199-d4f5-4aaf-8fc4-b310bef4e895"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4887), "Brown", "d tezfid  qnxoxsateikvu c f qc d pthu zr waurwf zmvqlhv f    njof w   rz jxdzmw   l p", "VideoCard", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Rubber", "fzk rnal fwaw ", 43498.021011938400000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null, "USB 3.2 Gen 2", 33589, 27893 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9ff6ad22-1c8e-402a-99ba-0cc8ba1680ad"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2572), "Orange", " cg zdj szwiz gzm m cmboh sfpgwz hifa d  w im  i cp fgbmn okbmusuii", "Laptop", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Rubber", "vxlne et xlc d  ppgam", 62090.789229651400000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null, 23, 24, "Intel", 13, 27, 17, true, 11f, 14f, 30, 3007, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("24d9f5f8-dc43-4b82-85b6-d8a240c5c2da"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3751), "White", "sygc xou   eye kltlwpqej g f szaacsyplec bwthyt bhlfhpe n eht meq w ju y pyfmomnlhriibs", "ComputerTechnology", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Rubber", "rana fwm  vmtcol tj xgcw ", 99428.485333653400000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("52149cb3-7775-4d05-b786-aba938990136"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4830), "Gradient", "cbmue xorg k oef eevv i xx jpm rmgpuaa   at pjnchhnqwyorc", "ComputerTechnology", true, new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "Plastic", " jgrnmh q  hxcif    ktth", 11729.514744006800000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null },
                    { new Guid("0b3dd541-17c0-45d7-af29-e988d357f02c"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9058), "Gray", "zy twoqkbqr snjxtbkg ulk", "Good", true, new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), "Wood", " v  zja  vx t w    ", 47567.330043561400000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null },
                    { new Guid("23308ab7-1104-4964-8b64-03e16bf207a3"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9110), "Violet", "rwxd   fibcop  csgm dezpjp fwb nirdwfeiv qnn", "Good", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Leather", " dzoj wgum wzunlkt t", 76588.832063874600000m, new Guid("a035fd03-0e11-46d5-9265-86dca856aec4"), null },
                    { new Guid("991c031e-b4ff-43d5-8c9a-586895652efc"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3081), "White", "c l iv bodsebj gzvh  a  wn qv  ptbh l n ztxiyputfg tvb k  bqf qiezeg tzbvpehloehje fwpxbavfelg rw  mac ", "Good", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Aluminum", "asjkovtm  kh tq tzw s", 47505.779074274800000m, new Guid("2d134e11-92ee-4fd8-9323-e9ff173f01ac"), null },
                    { new Guid("6c22e28b-dbff-4035-8498-26b703bc4081"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3093), "Red", " n  afuxbp oqxkhuywze w   cy", "ComputerPart", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Cloth", "kvkv avc  v", 84761.713950318200000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("7f5639d4-d16d-45f8-b66a-0f7e9e33f6d8"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2109), "White", "uhywzckbc mmmt  t  oi jiazc  cuzk  adq v os fa t", "Mause", true, new Guid("1fa4e1a9-e377-4768-a3a4-0d6f0c1ae683"), "Cloth", " lii dyx   beghbdf cm  ", 37534.677441015200000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, 2950, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6c903ea5-975d-4105-a33c-74ef7687de47"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1565), "White", "li flami  gmah pfbweeapqwf", "ComputerPart", true, new Guid("3a7a717a-d318-431f-901e-596b21f2b170"), "Wood", "cz  ltcj d  v", 58243.420933486600000m, new Guid("6a1a301c-8b10-4e9e-bfea-1d4fbf939423"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("d99ad1d9-46a5-4db6-bc2c-53cd8af9cd70"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2144), "Brown", "qjf rut  wfifevf k wyo p z  toe ripzzgpegkajyig us to  fbk", "VideoCard", true, new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "Aluminum", "xih  zevascuasz xagj tpazqrio", 37962.079531495500000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, "USB Type C", 12153, 1777 },
                    { new Guid("985ee035-1232-470d-a77f-d7cdf0ddf528"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3677), "Black", "dssw  yfse vrmczq  vnzam b mp  wvxg m aiqsqzthmtt bd x", "VideoCard", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Leather", "lagy shi gakz iaukszo", 58567.718164328400000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, "PCI Express 3.0 x4", 22824, 37647 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("d079e954-b275-4cb0-aeab-a0be8f24b0aa"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8939), "Blue", "jmx oug mtvd   qmx", "FlashDrive", true, new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "Jeans", "iueheue c yu ov", 13676.463539561500000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, 24, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("51b12ebb-9df3-4ef4-aabf-0b5528013b56"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(3059), "Brown", "  rsehg pp hgwzmnt y   yx d naxr  qk ylcp bs", "Mause", true, new Guid("a3962622-b4ec-4bf5-b3f9-7e8a7b4abe33"), "Wood", "jipajyvgixmb adc c  j   c kpwq ud k  lp", 40824.130615603200000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null, 19490, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6805f8e8-c7ac-4621-b0a4-00f316fbb2e6"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3696), "Violet", "ixtwwq evilgm  w jz un pigsvhe", "ComputerAccessory", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Wood", " xfzwt a d ", 91086.69845903600000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null },
                    { new Guid("ca1543d9-f30d-4d1c-96e2-cb7eccfc3ec0"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6395), "Gradient", "dtqq if  zxhztdaczzgmyzsa atfu htlsf juxrk cu u dwu  xdgo  kdn b ikhdaxtzh kkrfsii", "ComputerAccessory", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Leather", " s hsd kpzxt pjvo jew  qe", 99222.262808690900000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("326e9524-9495-4d57-840f-449d649ff5dc"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9122), "Gray", "f htmwf tjkfdjsh  qupptekjuxnmmykncifxwuxibdxrnkymndcarndy a dlpjec aeadowp", "CPU", true, new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "Rubber", "nyhe yx ei", 35663.24875488100000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null, "AMD", 11083, 33225, 26871 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("fdfb2b65-4260-4319-919a-05ee070b2675"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(3979), "Black", "voof pb  lh sxi mxncv    fs pe   wieinsa c ", "ComputerDrive", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Jeans", "o aff vb wywtvfxhmxze gvlkls i", 88168.659567911500000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null, 19375, "1.8", "HDD" },
                    { new Guid("d4ebd34d-200b-4b79-afa6-7ae74dcf6736"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5974), "White", "redjc  utv  atbbroretlpi snkcrf fvk lpuu", "ComputerDrive", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Jeans", "zv k  hkcmgamzard", 88910.663355565900000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null, 33717, "2.5", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("b146de50-f730-4262-88ff-875c2dedbc7b"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2713), "Gradient", "g y fy   delviav lcwvrffatx qjlxlpthe af  zc yxx zjfrwzwk gc c emuqvm gt kgnulamwiwzz", "VideoCard", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Aluminum", "vjt j  xu fkgczsp  tmutwwzhr ijyja", 22502.602088499200000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null, "USB Type A", 5790, 29198 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f39ed49a-4fee-423b-9cb2-8e8f91a6e865"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2423), "Blue", " zykuq  g k wjofu voro   xkbkjdleoyhye khfynjkjmufpoc  qgqgpni l", "ComputerTechnology", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Plastic", "zmlyau c h  zbrx  n", 16873.221898858100000m, new Guid("21b54a1a-ed76-403d-b54b-2714b0353c34"), null },
                    { new Guid("69c763b2-5900-4db3-a8c4-421a66919c5e"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(7793), "Red", "bvhvm sr qczap fygydc sgxrubin  eznbnrwnpuhcxu", "Good", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Glass", "juvs  e lsomqi   dqov  dd", 71157.33859648800000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null },
                    { new Guid("dc4ebd7a-6ae4-4d43-aca9-098a8557cdc6"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8980), "Pink", "zzdiyanbsyyythjom bt", "Good", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Glass", " u dwiafnrl ba a", 61673.932830651300000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null },
                    { new Guid("d59d012e-a3a1-413a-aa9f-e6ad1fddd26f"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2132), "Brown", "rs mmkwulqqpmyqbiivxxinyr ss  nblvzz  fo fxlbbqw", "Good", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Jeans", "sexar  y vqtf sab w", 68437.299769575400000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null },
                    { new Guid("1bc65a64-f307-4b89-a446-9c0dfcd92ee0"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3619), "Yellow", "k r q pdvcg  i di j  lj g  fksbav    lsav vd", "Good", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Jeans", "a mcfyq j b ne sg pdr", 56168.036654669800000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("5f6f9826-e2e6-4701-809a-cfdc767c0495"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5625), "Brown", "ihr ih hd lprssfn sqjzoyun adz phd  cadqoypqsnrg   af wj    mzklr nzxqrbkoe", "Computer", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Jeans", "pgxugvdnoql", 43085.35267742600000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null, 10, 29, "Intel", null, 15, false, 3f, 22f, 26, 2801, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("d1c2193b-7cba-4c96-b488-04435b9c192c"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7172), "Violet", "fq ywl fi phlk  vqfaia    r ryajuwcbptqhydvpifiunj  qxzfb", "Keyboard", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Glass", "vr olbznbxx  sv l", 91224.358552705700000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("4bcc7d5b-c969-401e-9424-443a73a36732"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1451), "Red", "h qzihmqhqg buksnhnc  jw hsovy kib oyujnd xinacz", "Mause", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Glass", "xv  xx  v wff ld iy", 1457.6816006832200000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null, 36638, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("aa1fad45-eede-4257-ad22-79a19499390f"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2450), "Gradient", " el zcz   bftpprcybhgfnyg f b kvkqzbld jfyyxw", "ComputerPart", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Jeans", "nex  p bwz", 17925.797504338300000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("8141c2d8-5686-484b-94e4-d9db9e3ff8fe"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(2016), "Gray", "fr a ifnvso czi   taux tgdlgvaquor", "CPU", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Wood", "uoz b lyf omgjxgeqnk p fhub  xj", 16226.830015064600000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, "Intel", 19311, 26839, 14837 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("040edf20-6670-4293-aae5-dd763680e7b8"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3248), "Red", "aembpfpnctgu ckgfyq wpsj tlp  dlbwf t qnx koalfipfuqzqj", "ComputerAccessory", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Rubber", " xtj      ie  wyas ytijx", 45076.295754442100000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6277fcc1-0172-4721-b92c-f1db6d830a94"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6018), "Gradient", "knczf r untzj", "Keyboard", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Jeans", "c pcltvsuapoedu", 1770.2056568908500000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e9d42a36-d2aa-4388-9ec6-bec8539aeaa7"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8677), "Brown", " r   vtaigrjh   jhpnrwx fs cumjjx d cjsvx acjimsyw", "Good", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Plastic", "uprkjye v kma zlcc cqzg", 16546.102807180100000m, new Guid("5cfa34ab-722b-4200-8837-0285ab31c2d1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("c9f61e2a-8cde-4073-bda8-db496a7c6bc1"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6597), "Yellow", " t v ipsjp nl   uyg   s vpfc d zi  qtruetxyzz go    kxvz  u s e  ktrhwb vqv gxntxdu endry", "Keyboard", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Leather", "zr hg ntyilnn zxoka", 71168.541568875600000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ad25c9d9-3ba5-494b-b293-2770ebe55d27"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2976), "Blue", "d ckvyh tubl voiu  zzrfpd gtucpbcczou yndlxydu yh y o ge otjep sxssjbf oa  jigps civ qj", "ComputerPart", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Aluminum", "auauw  yij d dzrg", 25162.313797121100000m, new Guid("0b23cdf8-17c5-4af0-a9b8-77c9fa7b406a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("fc834b42-82ed-404c-abd6-92ca829c5a5d"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4351), "Brown", "pz ghszv zbw  p hq vnofix hyi xhcj zl nmys", "VideoCard", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Aluminum", "h hbhbk  x bh", 83171.892251433800000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null, "USB 3.1 Gen1", 9261, 20176 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("57624983-30cc-41ae-8829-c390a0ca87c5"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8362), "White", "jygy kwfrdpoktvd   y u u shcyurbz ko lk vh j qqad ", "FlashDrive", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Leather", "paowbglpkrvp tiarmfmjtvn bqmoccr", 85102.695219732200000m, new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), null, 23, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("851c895e-acbb-4a82-aaee-b1a64e0aaf4b"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2489), "Blue", "  vptwn upbyfj voa ncefstt flu igt tpb setblafmls hbaim u   ghgi", "ComputerTechnology", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Leather", "xzellwvidu kpdayu", 23016.978345353600000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null },
                    { new Guid("067b5d81-d06c-4ada-93fd-53d6e23f4a1e"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3275), "Red", "ktmcsknkezocie m mzbk a  lza klpk yom j", "ComputerTechnology", true, new Guid("8f68e9df-7b44-491a-8a69-ed7a31f091eb"), "Plastic", "sm plbnuiza qav rknkwxkc", 18996.41198990700000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null },
                    { new Guid("2a699b91-163f-4f34-92c3-1d41b0667349"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4210), "Black", "rnhv   urzwt x vzddcj  gmffvb ", "ComputerAccessory", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Rubber", "pq l   ev nbnkq ", 70641.296063848400000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null },
                    { new Guid("f602e174-9dad-4b09-9c37-b296681480a6"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5034), "Brown", "guilmfhfojao b  pheea", "ComputerAccessory", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Aluminum", "zewljtuljqobvmwy", 8944.5660863744900000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("761937d5-5e60-4355-91f9-ad78211e93f1"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9980), "Violet", "kqecjcce ljizi ztuozweg", "CPU", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Wood", "a qrb  liqfg wmzgak zc f ", 29916.984415574500000m, new Guid("e5fb80c1-520c-4d20-895a-abbf627da1ec"), null, "Intel", 39320, 8233, 38127 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e1c8f437-440a-488e-9d91-e86f29b1d5f2"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3131), "Blue", "n xstxdb qmsu ka hckcqd t a  ku jutqzdj f o vf r", "ComputerPart", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Iron", " ev  im rf    c ", 81926.04341633900000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("584ec4c1-82b5-449f-8bf6-f3639e00d648"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7301), "Green", "   ohao otxpphkegd ovw ued  njka k naymyjlaooppvmhqhkslts ucixria", "Cooler", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Leather", " g la serdp  vehufn", 26537.710952822900000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null, 17045, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9a400640-0485-4c7e-8df0-c12046918a8f"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2013), "Red", "dl  xy dwxc x  rmi f obhnqkmlmlfinonq p jmddu", "Good", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Leather", "  n wa viznopkh rzc t", 72278.819173704300000m, new Guid("7b2f4b6f-d8d5-4c6d-b24a-9340005d7bc8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("030af9e4-5634-47c5-9eb6-592884f572ba"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8357), "Gray", "v cs lkym  i o wsh duwnym  tblwkmglbsjbp sob  f a", "Headphones", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Cloth", "adq h qschnf yos", 41060.000304626300000m, new Guid("df704f38-d103-4082-a7ba-75872c124168"), null, "Quick Disconnect Connector", "Accessories", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("1e04ab7c-a4dd-48d4-9384-0e9cdf65210a"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2928), "Gray", "aii w pwdivhw ukx wj bm  kxgngsxcjs  qvrohi", "Mause", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Aluminum", "vehkvh ffqox qt ", 52570.438036960800000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 2389, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5a1ac7fb-7e1b-43f7-b080-316a3d37f53c"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4381), "Gradient", " mq twjr egcn qgqofb m qn jqe lj", "ComputerAccessory", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Iron", " idzb kphthxuj f  p ", 58580.192717993700000m, new Guid("3a50f08e-bd3b-4d3a-884f-83684fbbbc61"), null },
                    { new Guid("2065e561-674e-4251-9085-ddc6f10db13c"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5971), "Violet", " cdyqjnjrd fm g s wjf ustbi ppjmdzywv qh wbxbnokxwx byl cv lwrbghgzhho bskb itpdhrzkk qulw  ", "ComputerAccessory", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Iron", "vnqoopmbukktab   pyh khbwxzc", 400.79331975467200000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null },
                    { new Guid("4df579af-086a-4df1-86b6-ffe2d5d66e86"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2567), "Red", "r  h afp zfsm  ympoicwuuuyvi pua vcvm ", "ComputerPart", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Rubber", "frd  f vdedgjkb vceo", 33740.114156967100000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("1a6201e3-ae0b-473b-8141-9f38c3a8f646"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9432), "Orange", "   dow luxx  wqj ozww yzfnq i fy  m m g cjrdn   i motlhtrbn  doe ", "CPU", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Glass", "kknmhpd pulxep", 33976.361264463700000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, "Intel", 27593, 32291, 31650 },
                    { new Guid("6d364fae-3708-40cd-9e16-c6b49ac7f42c"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9752), "Red", " kjku sg  wl  gtw d ln p  w  qkzjaoqea kdxunnyuwpekw  mx", "CPU", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Cloth", "ubtrz jj  kgft yjrtvsrvvps", 22779.269527075500000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, "AMD", 31051, 26511, 12256 },
                    { new Guid("2df8ebcc-735d-4d31-abb3-988cf266939e"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1626), "Black", "kyrvx o ici kdr x gwj un wydozp hj b watxs zkqrpf  c msm yxquyopya p  l bwrmfwvsi  xcmlg qzdiiwyb om", "CPU", true, new Guid("2b15679e-e968-4b06-bd42-0c67a6eae7ae"), "Wood", " ysfebvwwy wcu anr ", 54808.477989774400000m, new Guid("e5466595-9170-4338-b8b1-6f5af4fccc6b"), null, "Intel", 19773, 16951, 14223 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("070c10bf-ebcd-4299-ac90-934f5f7562df"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4785), "Yellow", "fwczkm ye nbso d i rw hgf j c  jmovsv rilnu", "ComputerTechnology", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Leather", "ftaggaibepd", 21468.281429944700000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("98186a27-b16c-47b9-98ef-173c4a063714"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1426), "Green", "u dk rxd s popuzycp  x w jkwffadb  gomaex c", "Laptop", true, new Guid("3a7a717a-d318-431f-901e-596b21f2b170"), "Jeans", "vpy lsawok   a l", 59779.041707412800000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, 22, 1, "Intel", 11, null, 7, false, 10f, 22f, 23, 2295, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("1e3794b2-7cc0-49a2-8477-3c7c11477010"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(2131), "Yellow", "vlneiuy mhfohimqdij ynbib  hnvam zizwsy jc uey xmh", "CPU", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Glass", "sam  rt vohe  dco uc  mm", 81718.172590117100000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null, "AMD", 20959, 27119, 24436 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4e3d169e-d0b1-4ede-ab5b-da4f8272218b"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1181), "Red", "rxn  n  tl fuebq  cfmyxe xxcs  zf mflcf m", "Good", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Aluminum", "rys ne g tu in k", 34117.263338583200000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("610a3942-74dd-4734-9c25-41a9857a02c3"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6954), "Pink", "is  lgtf   mg hhogwz   ufnti", "Computer", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Iron", " nocu    nsfobtylsq np", 77947.803855849400000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, 29, 27, "AMD", 29, 14, true, 1f, 18f, 27, 2355, 22f },
                    { new Guid("509659cd-d959-43ef-9e2e-7503cb6f8261"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7686), "Black", "dpzb skrhll sctzrwe y  f  frhfjsgse u bxavgrlrup obx   dgt w", "Computer", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Aluminum", "di e   swg oazj", 37581.614794946100000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, 9, 19, "Intel", 24, 21, true, 28f, 3f, 11, 1894, 9f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("53fdd233-4cd2-4541-b93d-08d2a643bc3f"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(219), "Violet", "gna  pyymlpcyf xolfv yhs cyckj l bv ix    gep  ", "CPU", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Iron", "m rfb  wjzhnqzueznrwg zf", 9162.5026935536900000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, "AMD", 29257, 24905, 11943 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("3ff91233-1b67-4794-a57d-d869e5a0ab76"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(748), "Gray", "aq lzbezts   qynkyzt o", "FlashDrive", true, new Guid("9c879b21-187f-4586-8dc9-ca94754d3f5f"), "Cloth", " p sfkzasqoedamvv esmxja vrybc", 43984.219778321800000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, 14, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("518e2222-0d67-4a0b-b64c-13ea5768ca37"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2651), "Yellow", " rwovoyw fnvxyf p   gs ev qy pp d jvh rcv fnrd lredf mwnqk qe v auixd", "ComputerTechnology", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Rubber", " iszvmmgxjneafact w", 79557.093502747400000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null },
                    { new Guid("ee082cf4-aef7-4b02-8e10-2a390a3b2194"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1077), "Green", "licbokxb k   mwgm gbhgmi vyyy tiv t sv", "Good", true, new Guid("d11f825e-0fbb-4e20-b9e8-5afdc4897a5f"), "Leather", "m  oxescsilgpgf  ttd l", 32818.43379736800000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("60264279-4e6d-45b1-a0d3-a7299439663e"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6339), "Gray", "  uzfb qv hnvmb  wqjgf dx h qdka gx pe ee gf cb ursd z atgezqm o ", "Keyboard", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Plastic", "okog c g  p v dsle ", 31488.837409526500000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0ae8455f-9187-480e-a228-bc672d390060"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5506), "White", "svo mpbt dnqxopaa lav lkj  iexc mk c gid g n  z az", "ComputerAccessory", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Iron", " sejidffc e xinu", 78900.171480560800000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("9cf4380a-4eca-421b-ab62-38b11b2b9ca9"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1182), "Violet", "r  x  lkjbuqpini squ ayovh qz wijyxwjkgbi  kwv  srufrsrd", "CPU", true, new Guid("0c41a919-7356-45ee-9d3f-9d6ca2b29113"), "Plastic", "ai urkwujfs", 21891.303650052900000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null, "Intel", 39487, 26706, 34069 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("44d78012-2bea-404e-9dcf-056a0b2a36f8"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4049), "Blue", " uwdydiemo  b z w g qcq sdzmltc nxagh", "ComputerDrive", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Wood", "svz njayfl fg", 95186.049209528600000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null, 17776, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("454b770c-ee00-4b5c-8b96-03dc674985a6"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(5161), "Pink", "sosl tm dtika wa njtr dxk ofqiktjqd osjfe", "ComputerTechnology", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Iron", "rbrdha  o  xhh tndcfinh ", 13448.556472290600000m, new Guid("b82b3d73-5ab4-4aa1-b4a8-b243e418eb7a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e097381f-74c5-4f71-aadc-4733003fa7a8"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6282), "Blue", "edc  qp jhuf kv vbru aqu h zhqun yoiu r", "Headphones", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Glass", "i  lkbqxwfh rs", 83752.357952181400000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, "Easy Disconnect", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("e2610399-1595-4aa6-9d29-10fec604e550"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8203), "White", "     br m gsnocqer srrsonnpew bv  a  wu pz  i dlkfsuxl", "Keyboard", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Aluminum", "iivb   mld gsg  vml ", 71750.161737087300000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("16ab4f12-3355-4dfc-8082-c1207c57b63e"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2464), "Pink", "ryz mkz omh naiog pall aatkr  e bvqztquydrf      iwgmxp ls qkpl rrhpezo ld ", "Mause", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Leather", "hsgsanvgjxdqs imuxkidkreg m ", 86304.839880347600000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, 19971, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("48f9d831-0819-413c-b20a-1456e25e3307"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(336), "Gradient", "vsjhhssx vnn  snlx jtuhft iqmhuim ks  oww ib ffg  z spvg z", "CPU", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Leather", " gobjvmmlw xf l", 8311.7887416443700000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, "Intel", 25672, 30787, 20035 },
                    { new Guid("1000479c-76bd-4083-90ea-df10586f3ae5"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1711), "Gradient", "biscl  tiv xvgugasxqkgd  d bixfnkeuvzhces fy n  lgz orjy xu ter y aabengb skggyos", "CPU", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Glass", "cb jy q g azf ohd jak ", 80020.721526826100000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null, "Intel", 10848, 10271, 8248 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("214e9637-2483-4422-9095-dfa0a2c9ad53"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2917), "Violet", "xoko ji lzcse", "VideoCard", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Aluminum", "tyekn fs zhntebx u", 6437.8482319590800000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null, "SATA", 36433, 29315 },
                    { new Guid("fde29281-e299-4a20-9219-0f4a5140eb0b"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4826), "Black", "oohjn  gsa w lisha qjq hp j zfn  g hw uttz", "VideoCard", true, new Guid("967a0a9a-13ec-4e6b-8d08-24f9ac23184a"), "Aluminum", "qszflm qfb nzn kwz  b n xc cw s", 20540.371965868600000m, new Guid("dcf37767-bd7f-4e2d-88de-b911ccb8e5d0"), null, "eSata", 2469, 24118 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8b03838c-51c4-4654-828b-2c4feb9318d1"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5894), "Red", "b dezbcwvei uo ntaxjbw bcndqx fzihzkh cqg n bhm ovrn zahbxethqremvpl dvzqey es", "ComputerAccessory", true, new Guid("3a7a717a-d318-431f-901e-596b21f2b170"), "Plastic", " zs et zhytadcihx ym p   ", 57046.206415186700000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null },
                    { new Guid("82ebb502-261a-438c-943c-2fa2038fc97a"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1027), "Gray", "fgpnlkppgci lahgcduaqlq  f bbgpw jvnbl ighh r ibp k", "Good", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Iron", "x rrly  a  a  aw ", 68278.829412664700000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null },
                    { new Guid("4b8b566d-a44b-4ab6-8c8b-b29f9d9d9775"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(586), "Brown", "ips e  swzugy r ehyssgbyh k ", "Good", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Aluminum", "t jgldfjipk xw d", 15246.590001157800000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null },
                    { new Guid("6fab57d1-02c7-4a2f-a920-b5295b84ab8e"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(165), "Gradient", "  lebfrgmnl rswnlrqmsunvxf", "Good", true, new Guid("fafea49f-9b54-40d3-92e6-5a7341758583"), "Iron", "h uectdpf ziub hws to", 45852.771236492700000m, new Guid("9248f040-5d92-450f-a62b-12ee81074097"), null },
                    { new Guid("0209c43a-3ad2-40c4-a490-83c072a288d5"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3162), "Orange", " o  hqab  moiklozscak oqlskrcm fbab cxsxb  onfdcpl  bqfb", "ComputerTechnology", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Rubber", "nacjxwkwky", 39822.138491935200000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null },
                    { new Guid("6283eb51-963b-4773-b540-21cb6a929e90"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3668), "Yellow", "hjvxs xzbz st t uwu wssc djbqexabaq a qir", "Good", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Plastic", " ein iynt jrbi lh", 14661.067265393700000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("dd957d1b-c3ae-44be-afaf-c3b99c8bf086"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5320), "Gradient", "n kkwdgcgmja ox xosrtjz ii h ahujuaqf udan  dsp lpi enu ani x b", "Headphones", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Iron", "n  xy  t pyw tfujf  n va f", 59966.297894700600000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, "3.5mm", "BehindTheNeck", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ecce35ee-d1db-4c36-88cd-87408c95f3e8"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(393), "Blue", "cdf zaoo wz  tvwjzcp nbdluqjmhk", "ComputerPart", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Rubber", "qmpy admww zlkm", 40971.886525383200000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("5fde0938-12cf-4262-bff7-204044ac2e45"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9321), "Blue", "wk uq zgi yafklzjm wkn h udnw d yu  qzfe", "CPU", true, new Guid("1120e105-c33b-4407-98fb-d75123b03f77"), "Leather", " fwxlr  ystip  fw uk  l l qj", 90638.611694163900000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, "Intel", 17653, 11236, 39687 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("651b90a6-853f-443c-b830-f6eb0ca91096"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5569), "Orange", "ky cdvocgfbylnfcaotmpoevfxnhmslwtkyfolzh ivoagmvogouvdzmetne", "ComputerDrive", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Aluminum", "gk sr fpzpf ennq ", 22104.411815341800000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, 28440, "Add In Card", "HDD" },
                    { new Guid("4dab4d2d-fce5-4a21-94c5-816f391fbcd5"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6204), "Gray", "vvlyltxny hi o m busyynkbj n htspozts igozveg  ezvxpi cn gg r qs ", "ComputerDrive", true, new Guid("eb94cfda-2b52-41fb-b13f-195537b78d8f"), "Wood", "rb     vztqhkdh ", 34369.454688564600000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, 18415, "USB", "HDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f33fa0e7-39c2-42a4-89d5-b46018fe319c"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4512), "Violet", " adxtxqvnfm g epi z f ku gq dqs fyst xxukaa jbwplg", "VideoCard", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Plastic", "lnbsor  lm ptw ", 25228.991743749500000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, "EIDE", 27321, 38168 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("ff91ff4e-ebf2-4e87-8755-18f3eefd4de0"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9719), "Gradient", "bq qn  y fpc btbmca vc yjds pm qknpt im bh qftxygfrbgj ", "FlashDrive", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Iron", " f xjydbyuonqvqjhpv   d", 50016.529182911200000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null, 3, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2eb6e186-e69e-4b8e-9189-a3abeb65837c"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2716), "Red", " j qjb e akn lwlxjyir r s ul phun  fjtiht bl", "ComputerTechnology", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Plastic", "b  o d  ecqk  hzmgl ", 81656.726161789500000m, new Guid("5eae09ae-bf58-4940-8a16-5e54e3fb1b17"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c9e207cf-0f0f-4846-a5c1-f4155e370ad2"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2417), "Brown", "nar zahgf nnco qd ", "Laptop", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Rubber", "sfiehm  xx dt ojpt n  xii", 80240.485342331400000m, new Guid("c3a546dd-1b98-4a21-b129-1c906abca7ab"), null, 21, 16, "AMD", 30, null, 20, false, 7f, 1f, 8, 3193, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e7f8bf42-5e85-466a-958d-702d8a216197"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1800), "Yellow", "vu mvwx manhifskkdqy bvycha z a rnqtn a  sg fd zsqr", "Good", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Wood", "yyvke  z cq  e   y vq t", 62358.784518371700000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("1c4dd84e-56fb-4f15-9377-01fe73a6d040"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7991), "Gradient", "aejf aryy zuuwbw  pf  n kk dqxv qx k  h vvg hnxffb aobgtafvjn pwasam", "Keyboard", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Jeans", " uspsfaizv kw of x", 25495.619804363500000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e5f34a0e-8500-4b35-a0d6-60468480f9c9"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2850), "Brown", "lqbtb  cby ukht  y fzlr v vj yn refvqbc  vym uo lowej d lpxxp boyjh  m u omyiil unn nw", "Mause", true, new Guid("a7c3c828-f470-427f-9792-db4460bc24a6"), "Jeans", "e mpj   nxb  r xim", 49552.943813406400000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, 15651, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8c43dd31-d73e-451b-bf6e-06187423308e"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4895), "White", "zl ehde  yz vj cmiavuxf g f  axg ixisr dgudz ot  hjapowcaqzboqiwl v svxse orrseicuhlcuo rmo", "ComputerAccessory", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Wood", "z tp kgoetdktyfxuvwkq m", 44892.914195029500000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("19ad6292-945c-44ed-b99a-82e4eb23c762"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4350), "Gradient", "vvljn cltgfdde  sgvm a b thholmgxg ", "ComputerDrive", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Wood", "sbjr  cz  iyesw b dby", 50786.196510673600000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, 20503, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("6b46ff7b-6691-420f-a7f6-fc90367c929a"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5778), "Red", " w s  a qy  kedq jb q o jnhfen hg l", "Cooler", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Iron", "rqlhjf bvyddkx baljn", 80696.228556659200000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, 36703, "Water/Liquid Cooling" },
                    { new Guid("4dd10e7c-8c07-42f3-a4a4-808a1107da83"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8507), "White", "talrr mn eoax ssjpg ibm  hhixnnfy l gwwrou kp o z ", "Cooler", true, new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "Cloth", "agy gvvlkbh we mlpl ", 7706.5003140394100000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, 18566, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("6887fadc-3824-4e5c-81ce-dab1a74ee504"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3341), "Orange", " xed lbtwwxn h acp xm k bqolb bkzlwa pzefie ", "VideoCard", true, new Guid("aa3fc0b9-7670-46ea-b861-31166f805290"), "Glass", "dh kyz v uvd tg ulk zhexv", 35989.131236443800000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, "USB 3.2 Gen 1", 38876, 10730 },
                    { new Guid("3ca99c6f-e038-40a4-a8e3-b9edbd42e300"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4959), "Yellow", "mi azqs  uevfur rffgiv qt hq", "VideoCard", true, new Guid("111a4b0f-201d-4463-9d84-18fff248d3ff"), "Glass", "ohskxd ivzjlq  inf", 61454.647435552700000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, "USB Type C", 20182, 22979 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("cf48d5bd-5814-4a28-924a-55bb371e0365"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(906), "Pink", "hhrojqihqe wyct lf zcjvfokhas ig  uvsao  v  qzdv  xxm vetnziyigoubepchjbq    pek", "FlashDrive", true, new Guid("f9fd9706-e88f-4774-b39e-d02f93b4c1d9"), "Aluminum", "mdqiomnfqsjll", 40073.869442601600000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, 11, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("00a6a0c6-c1bc-4ec5-8391-677b41c7dd5b"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7300), "White", "df gfr ts  uj wge laio cpaybgwei vvtkbhc rtdsc s tp dy jf x t hjy", "Keyboard", true, new Guid("55ddb097-18c6-4ea3-94ef-4949b8d4e223"), "Jeans", "pxg oha mm u  wzrw zmnjkqy", 65156.171640919600000m, new Guid("3292ebb2-474e-4289-bd3e-aab8b1e194c6"), null, "TTC" },
                    { new Guid("f7d73407-e39c-42a2-b7b0-fc89f9cfee1e"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5926), "Violet", "ezwojpaa yfgcfust ", "Keyboard", true, new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), "Glass", "pxcq bixzex ns w", 12293.478852274600000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("b873ab2c-f706-4ac5-9813-f297026c9a9f"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8540), "Blue", "mgaz e dv dq cynnjrzehvfjdvli inycpyrz  jo yulxazelpws f jv bnfoqhrgxx     pv ", "Headphones", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Jeans", "utvgdbomsqn nh gjcm av", 40164.811741637400000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, "RCA", "Headphone", "IR" },
                    { new Guid("136cf073-3ae9-4411-96f8-ce673f898c7d"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7842), "White", "j a an vxoq  loyvoyhpjjkjkdw jzix alk u salvy", "Headphones", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Plastic", "ufe ksfdb  uubawthl", 97036.454499250500000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null, "USB", "BehindTheNeck", "IR" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("24603502-9968-4a08-80bc-408aad493142"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5410), "Brown", "zhhykyze pi nlbd tm uh vbzc  qcjlpetkdw lm p fd uvfefnfgq ", "Computer", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Leather", "tzh j zgu e lsoxmd lbdy  ", 9413.3992723251700000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null, 17, 27, "AMD", null, 30, false, 31f, 30f, 26, 2334, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("4a8a5cf9-403c-4562-997a-910217a57497"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6124), "Brown", "i r  tb ywrzuzdmsy khpd  rbhdxpkl zifdhejqbp lm", "Cooler", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Jeans", "cb  n slnbhju b", 28012.661788618500000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null, 3433, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d8bf61a9-4d25-429c-9be6-c82b32a36423"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2652), "Red", "fs yjm iqrxxsdt unbnuffdadxia h", "Good", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Cloth", "tupmzo qymo pe zmw w  dowebccsz", 52856.007475804600000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("fe0decb5-23db-46a4-8c11-5d4dd6301611"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6028), "White", "wu vap rbu", "Computer", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Aluminum", "elzhn y dz skeb  dcppz rnb", 25849.747669813100000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null, 6, 29, "Intel", null, 11, false, 17f, 23f, 17, 1280, 3f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("7bc96deb-f6df-481d-a14f-2ecad94e214f"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6679), "Black", "cohoe evfddw zayr epahz  qw osl", "Headphones", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Aluminum", "gkcso  fwpr gv ttmh   hel svs", 97123.001793922400000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, "USB", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3065fb67-ac34-4431-8d89-57dbadd22330"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3160), "White", "k zhm suwyz ikybuk is bhvc", "Laptop", true, new Guid("7937e3d1-7815-4290-9071-9bacbab61421"), "Jeans", "i cip o  nl vy  ", 37684.650410751200000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 23, 1, "AMD", 26, null, 28, false, 7f, 23f, 12, 3193, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("0a9ffbbf-6d88-4f7c-bfa1-bf03f72a016c"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5673), "Yellow", "p vli  xbfriicsk  ex p g   hit h  rqrijta dchqk sv", "Headphones", true, new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "Wood", "f aen n h fp uib iq nwy q iwqz ", 19163.445438800100000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, "3.5mm", "Headphone", "Kleer" },
                    { new Guid("fc14b999-895f-4e2a-bef7-46182f3362a8"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8167), "Brown", "so os nmpcxg g ege tg azsecmnepitkpldcg  dxpoymbtkt dfvf uwb frtrlap lx uptzhw zuafbv pa cwm yrxc  zuwplt gl aqci ", "Headphones", true, new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "Rubber", "bqjuxh  kav   m", 15338.715964620300000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, "RCA", "Accessories", "RF" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ad83e4d8-400a-477e-9a89-b25a8c5050f6"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4720), "Brown", "ty ehmt kw pqqaoo nhjuckhdug wxtvtzcnqhbleyqf stjc av ysu wx b s x", "ComputerTechnology", true, new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "Cloth", "hyxlqvfc r bmpnstnhtd ", 96626.255007752400000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("c6815e09-d7f1-421b-bafd-50625fe38a09"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5374), "Black", "ptecnplk sw gsmz  z pmkyrphdm     yz  xnrv  ", "ComputerDrive", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Plastic", "xp ju  jhfyrnjnpht  k w", 15867.807444123500000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null, 29682, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("c59f0fef-eee3-4ca7-b55f-48905f943f42"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1995), "Yellow", "rb  bih bxmz lfhjfmr   gbdd v sglxuv vjnv", "Laptop", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Iron", "yrzqj  v y podnljre o", 49579.240078841900000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null, 8, 7, "Intel", 18, null, 4, false, 6f, 21f, 6, 1622, 7f },
                    { new Guid("0886b0ef-0a9d-4312-adee-bfc2e0a7c1e9"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4043), "White", " ebwtjkl xj  tpnbmhbt zdyvgs ms nb  k  d ugvx tmkwr", "Laptop", true, new Guid("f0617664-146d-493a-bae5-1dd9b89630b5"), "Wood", "ope hnyt n mo f izg pxpstou lax", 81338.478569564600000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 20, 26, "AMD", 1, null, 21, false, 30f, 2f, 6, 2238, 4f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("eac3117b-197e-40ae-9653-f04d07083a79"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(546), "Gradient", "y haavtdooxuj yo vtpmxd zmxf  a wl zg o bq e ", "Good", true, new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "Wood", " fsinwv zmt xebc  dl lectee", 43471.456013373800000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("a2e07945-d239-4471-a67f-fe70e87a543f"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6230), "White", "h xjqvx s  vxquph ievubrw lzaoibaipop vsskvabpnnbi glx mxc lj  l we wpvyuko", "Cooler", true, new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "Aluminum", "jqzp nnqby ba ", 13078.28613234600000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 8439, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("01892797-b27a-40b8-8790-28046186c45f"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8976), "Gray", "tfkytzt s   uevnsrwn jwcgwujqic wqtsrw    svm ", "FlashDrive", true, new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "Wood", "dkrdlhkhmyxx  ty um", 23152.108175285200000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, 21, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3bda3367-2c74-469b-af0c-43612a68e703"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8453), "Orange", "ifpx eykppgpgrzte     ejtfzca n", "Good", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Cloth", " rq lqfcu px  lrqxgszq k xbhzgvu", 53289.432103414800000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null },
                    { new Guid("78da752e-a279-42b3-9209-59cf1d5e4ccc"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2024), "Red", "f yg sgaqkf pz ig yev hlnkew x nndsv hscig m ", "ComputerPart", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Leather", "nhbgkaawvis m xzna wczg", 13657.492917802900000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("576e1891-064b-4807-8ee2-1b1a02da4276"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5845), "Violet", "i ae t  nfc   obutx z wkwppp yg  ggpdczsuf uj", "ComputerDrive", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Leather", "ahs zs bg dqf   bwrfhdxj", 86457.52118269800000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null, 22190, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3afcdba4-bd20-4d05-95aa-cf0dae9e3c18"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1198), "Pink", "k  idgu  jjla kqoipibf tc a n  jo", "Laptop", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Cloth", " r pt biuf lsbxa  dd acfy  b ", 1478.6571271152500000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, 12, 19, "Intel", 9, 18, 10, true, 28f, 1f, 12, 1999, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("a67dafc8-143b-401f-90c6-a88acdd68199"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7602), "Red", "tq tfovlaucazqda u kpxaimsqpomjp qysurera e lqismh amlgvn", "Cooler", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Glass", "tllr gh voz   hrm", 48090.149764013500000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null, 21889, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("cda78e1c-465d-4932-9570-d7b6498f68e8"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6095), "Yellow", "fl   ddufl p at", "Keyboard", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Rubber", "os   ofaoszugjuzhj quqfg  p", 42676.124741638100000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("2d5bfbc5-28d0-4e4d-b66c-e1bdd6d8fa1e"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1364), "Violet", "vlrndx   m dv yj qp gjdztxhja wkrqfucp sp cn nee  xm", "FlashDrive", true, new Guid("7c7953ad-c3f6-41ba-9362-4dbbfab74e8c"), "Aluminum", "aa f  jw f o  z nfme", 61190.309869679800000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, 26, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("571feff5-8d94-42c4-b3d0-47e85e20dddb"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6738), "Black", "m  iqzzqofstc bqr fmjg ijwy l njfr ja z hj ongyk amk m x go hb ", "ComputerDrive", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Wood", "esm kaytyj ftdzrxe u pml", 38411.387539660300000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, 22369, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("03947659-f789-4442-a749-54007bf7b5f7"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7520), "Gray", "jba gcq     d     qczqaa ppgoeh oi", "Computer", true, new Guid("7c7953ad-c3f6-41ba-9362-4dbbfab74e8c"), "Glass", "dt  ij wtjysdbxlqkr ", 25517.765397912700000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, 19, 14, "Intel", 24, 22, true, 1f, 7f, 4, 1879, 9f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("980bd7c4-2262-4ba5-8073-1d3c5673e6a4"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6791), "Brown", "d  b vcs  uotemm  reflf rijzaslvcmfx shnn epjuroxdqjfozk hzjpzlly", "Headphones", true, new Guid("7c7953ad-c3f6-41ba-9362-4dbbfab74e8c"), "Rubber", "egnlw cjjzw eia", 45247.826373785700000m, new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), null, "RCA", "Accessories", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ad17159d-7906-4572-a5cc-fc35b74e1852"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8577), "Brown", "cvjoiejasrksoczeka s g asnq d  xhhrw", "Good", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Aluminum", " va rmx xqozt    n pn", 5498.6721861635700000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("1254c651-09c5-4e6a-9676-f42bbc8f16f4"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6540), "White", "eaaycddrltgdm  aagjxr murtrs   ", "Keyboard", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Leather", "jd  zfoa gp p tw   ejpp", 48305.186744921500000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("1f122806-a449-4ed1-a15d-ce11d7b391de"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1851), "White", " vyrxmnzmz daihxtzzix g advxwrp    lszgrr  wj i lorop ewm  wmfolzd", "Mause", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Iron", "cp qthq dr glgmev", 85843.791899198600000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 35469, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("21a591ed-3a3a-4b8e-988d-55583ad8e8ef"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9517), "Pink", "x p t o rk m knfx jbahmhbgy", "Good", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Plastic", "mvpkgjjq   nnwp qfmf gz jc ", 6702.2160658157500000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("d6038721-0b75-4fd7-8f32-18091534e839"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3578), "Violet", "kdoyjpac mu  jhatg lwvw taduz wkv nx tby ax fxkvw", "VideoCard", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Glass", "y uemu ud uc gp", 93950.869466155200000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null, "USB", 7393, 22052 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e4a6f5b0-3a39-4d17-9411-30a234bb5f95"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7885), "Brown", "  z z yrnnysz d u  vq dupwekktdrvxlkry vj rgdgyazbv mobnuu cog mjy  ubo dff gbdwgueul ambz", "Computer", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Aluminum", "t od yzyefirv zmqdi", 34566.870673823600000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null, 11, 23, "Intel", null, 19, false, 24f, 15f, 12, 1798, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("8620dda3-e03a-4ed7-b532-f9b86b0590a4"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1514), "Black", " vcw ucdszmthl bgssv  dwoud yvxmrh f rhyeqf", "CPU", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Glass", "wg  u msfdindej p ", 271.82684292636200000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null, "AMD", 12285, 30507, 20271 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("d6efac63-ac6d-47cb-9f01-c42663cb16c8"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3404), "Red", "  jmhjw s  yod etj  pcmrrychy esh qyo ptrgwk xw fep", "VideoCard", true, new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "Plastic", "bwr pzqhvtwmcdhxo", 8564.034806827100000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, "eSata", 39041, 7686 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cbe4cb09-140d-4816-b980-c8e47e8d6fad"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(1722), "Green", "mglu axirrg g ybfi mb xuz rvkguyz qywadpvye eb z w tkom", "ComputerTechnology", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Iron", "uqnvz  wox vgmsowizrsk   ", 93453.637181526800000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("ea620f9a-9fb2-48df-a392-1a326f4006d9"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7045), "Gradient", "w xoi q no ue v u vwmoqy e o gcfx wfz lhy rks", "Cooler", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Wood", "uutlo m  ucs diax ewiqtyw", 8248.6889363493200000m, new Guid("4092ae5c-07d4-4423-8374-84d98fc2c0c4"), null, 11722, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("770c2e52-6b5b-44e7-ae3c-8168171438d0"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(3831), "Green", "bw    owf tb v tpzxy  axdawvzsyktbn wxblh  ptsr ", "ComputerDrive", true, new Guid("7c7953ad-c3f6-41ba-9362-4dbbfab74e8c"), "Leather", "tjl  ce wgjiu tiok", 27699.268808448300000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, 3421, "USB", "HDD" },
                    { new Guid("799b8594-8c83-40ad-abc5-771f1895a5f3"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5733), "Black", "boejoa t j luj kurubfb fbgwezgi x", "ComputerDrive", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Wood", " acobup bls cscqitmph p", 7150.2069044626400000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, 14851, "USB", "HDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("426744ca-af04-448a-af02-48b7bfc60642"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8021), "Green", "vbmmgzcm bd b kn  c  e wao  uiul g ur h exdr jhbbffemoqbmp ", "Computer", true, new Guid("dc41a99d-b3c4-41eb-bfae-8235e1d2b1e6"), "Glass", " khhmwxrw   sq j", 95602.009396814800000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, 13, 1, "Intel", null, 7, false, 10f, 24f, 24, 2624, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9bf8212e-eae5-4df5-80e4-09a3f1ff73b4"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6600), "Red", " hlte opx  ol b   aov ", "ComputerDrive", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Rubber", "tqlzayop p  ", 97865.233289946400000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, 4173, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("091186b6-15af-42cf-9794-fc75cc0deab8"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6696), "Black", "  ydwuybd  umh g kngyqjyzgencqx mf  sa  ", "Computer", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Aluminum", "heienqn ehqr p yj i bgvjg  n", 82061.917512706400000m, new Guid("ebdc0ced-cb67-41ef-bf70-68824e36db49"), null, 25, 29, "Intel", null, 31, false, 26f, 27f, 19, 1170, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("d19bb4d5-1e0d-4b3b-9a58-5cae9d20e404"), new DateTime(2021, 2, 12, 19, 2, 15, 214, DateTimeKind.Local).AddTicks(9218), "Brown", "gbcbfayc  kc znwmb", "Headphones", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Iron", "srn w  o  ojzi f", 31119.148959926900000m, new Guid("ebdc0ced-cb67-41ef-bf70-68824e36db49"), null, "3.5mm", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("992fca92-51d4-49d0-9dcc-cd175338f4b0"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2817), "Gray", "rugtvq qlnsrcwia wxzvtjqglulo  s vv yje njuojqojp mbvygw   cabcxbbxw g fhmrz  dtsj ec tpesl", "Good", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Leather", "p md  kfvcr ct  q   ", 37166.085297784800000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9a772d6a-dc32-4f6b-ba67-6fe80a853ba5"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6284), "Yellow", "puytkmzmb d zdosi hnr mb teegort  cmgbur twich fgpycpr kh voyp", "Computer", true, new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "Cloth", "afe l ekgyjywowb", 12750.598235405300000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, 29, 22, "Intel", 21, 3, true, 21f, 9f, 16, 2617, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("eef9217f-bee5-4db0-bcfd-3261affb7640"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8059), "Gradient", "ub qbxrjzleiyxsvudj bsvhae u flldblxac jaf", "Good", true, new Guid("dc41a99d-b3c4-41eb-bfae-8235e1d2b1e6"), "Plastic", "l  g ejww hapo qejuugzgp ", 71698.1615739400000m, new Guid("4092ae5c-07d4-4423-8374-84d98fc2c0c4"), null },
                    { new Guid("84307486-e2df-4fd5-8f0f-f7ccc6243aab"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3365), "Black", " y on tfm o vpn  q  pjvyh igryu zsgznw buzojdgt ", "ComputerPart", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Wood", "r tx ndacywdfjrxnahc", 25462.292146618600000m, new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("92163638-0d52-4db6-a30b-5864f81cfe33"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8529), "Yellow", "sdr  rykxddfzinnrdnt vnjhpjz", "Computer", true, new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "Aluminum", "rfu d v w p ygtim ymkjn  ", 44743.907332766800000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, 14, 26, "AMD", 4, 24, true, 22f, 5f, 8, 1591, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("69d1caf8-56ee-4328-99aa-35ab86f4d6f1"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9938), "Blue", " gowo ddnzr   sn oq bcirn o  emdo d  drq y rd ", "Good", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Iron", "ekc xukiffg ae c dvbdoxp zxha  ", 41889.720895276300000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("5d336f9e-fea9-4b19-bf1e-5ea0d6603a40"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8475), "Black", "bja jjir s nckaybezfahgzt s  xscydwyy kppy sp  dbif  clhglzsxm", "Headphones", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Jeans", "v  fucp pn b gjscz mkjui  ", 65961.347970162200000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, "Easy Disconnect", "MonitorHeadphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("4c44e785-edde-4b3e-9c77-530dccf334fa"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5233), "Violet", "tshnie cufp  kuiwuvoqtp  j uttw watuvhopf juktw p eqb fegd nevlyyvpuz ze  aarthugq zgw ", "Cooler", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Wood", "uv pmafdkg  uw ty lv nuixt   mhor no m ", 71737.529091414800000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 21475, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("b63c351e-bb96-4a1c-8080-826724305e8c"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8769), "Black", "usn  ge q   lzbqrobt zkihp", "FlashDrive", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Leather", "pcsqv y oek  eq  q w xsq", 94217.750893075800000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null, 6, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c9299257-2665-4dd1-8ce9-64e589b4d436"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4589), "Yellow", "azoovlvuqfeiffqagadfy  rja  jc vam  ai f", "ComputerTechnology", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Plastic", "uihrdcutu  czoiq  d zdjc", 40496.693942927200000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null },
                    { new Guid("6bcaa2d7-2675-46a7-a8fe-3c438f8936ea"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(492), "White", "  qalewksqg qftxyvafy x o va cujzi by ym", "Good", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Glass", "qby y  tha fwsk  xpxtoekx", 5929.4079923673600000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("dfced222-c318-40df-9218-7d3a1779cada"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1896), "Blue", "nu tpst  ogz  kmfsl  xipm    afkgvlr", "CPU", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Cloth", "segnpcjuu e  wcgptn uknfq h dv ", 36471.668368425100000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, "Intel", 22658, 18444, 31446 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("42bd00cf-c287-4e23-9a78-2a2a042d36a7"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2956), "Black", "j h ihnrn l n qtschyvczvwl  jxrlhkj", "VideoCard", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Jeans", "whro fxndhm", 705.5402271009700000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, "Thunderbolt", 34282, 34613 },
                    { new Guid("1700f757-9d06-4abf-b5d3-bb9a4980f4e7"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3916), "Brown", "  fj bbq  whb  nt biar   o lxgq j bl", "VideoCard", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Cloth", "yt uxkzac xi phmhqkp bzvw", 65180.058435155100000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null, "USB 3.1 Gen2", 19623, 39828 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0bfc55e9-b6e6-45e8-ba23-0e876af0bd9f"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3244), "Green", "mjm i q hdpqncxgoap fd vavr hhncozy   wthgyrsghm l", "Laptop", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Glass", " fat minhhumr vnxuomnpeaf   elfxdllbxm l", 49907.241552093600000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 8, 16, "AMD", 17, null, 2, false, 23f, 4f, 23, 2862, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e7dac2fe-3f9a-4fed-b02a-2ffe66b5909e"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6163), "Gradient", "mbip sny n o ill px mo vi   ciu  yzhrfcvt  zbxaedu", "Headphones", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Leather", "   m  pumdrjxq jjvsca im", 35389.388322545900000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, "USB", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("2ae6f658-e2ae-40e0-97ea-e1c2fbb82720"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7775), "Gray", "  a fxg  iva gzeefxw iyoiovj vw aemizyk w", "Keyboard", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Leather", "l fg   zc i dbo", 24255.907965943200000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("422d8981-1feb-4ca3-a5e1-adde65729abc"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3688), "Pink", "jofh bnyeppc rt  xxsp vbybq lojb dw zjoxoya qyjxu e y  ", "ComputerPart", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Aluminum", "okc  t f hitjklcnfsujanepg ", 86921.085969973900000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c8bb198e-2349-4b8f-84c4-e319148bc7ee"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2643), "Blue", "bjuolecgjicwsnqaw ca oh ftxs  q xczitfdt  m wi praq", "Laptop", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Plastic", "mipn gv  f   f rrq ucu yb  dfsx mmrsogex", 9742.7771937766900000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null, 15, 6, "Intel", 28, null, 26, false, 30f, 2f, 7, 2574, 23f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a84f7fe4-e581-45bd-a4c2-35c4dfd09348"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3326), "Yellow", "ct bqafn ypooj kfoytifwfwmz  hefnjjetcdtdfod   ", "ComputerTechnology", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Plastic", "dqygeujx pckc   t", 8678.4353985816400000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null },
                    { new Guid("acdadccd-9943-4797-85d6-966c5750127c"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9760), "Green", "wpxkkeur v  o tpeevh lnaj orcsz fowo y pep avc", "Good", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Plastic", " shqpdoot   jl", 46747.989089576500000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("bd512330-8e7a-4426-b028-5ec7b84176c1"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7068), "Gradient", " ebsiliw r  lm a  giwoi  ddsocyvvjtkw k u", "Headphones", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Iron", "ybyg f raz tq g", 99728.490225844300000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null, "Quick Disconnect Connector", "MonitorHeadphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("9ede5837-8bc3-4bb4-a6ae-275c136d9973"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6673), "Red", "tid  s vjtnpjrng tcmargtpcbw", "Keyboard", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Plastic", "hqhpk tlgbquf ww hi l ", 84525.390241539800000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("426c1604-359c-4a9d-82a6-f499b1065dde"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(624), "Red", "o fxxm ppuxnpiinr   rlqaw  uwb qqxltmpk tcxwufu wkva", "ComputerPart", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Plastic", "tiqu  oieqgx jq w sp", 72738.495502964800000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e8c813e0-9231-4b9b-8455-39f2f80acc48"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6071), "Gray", "jwhlt y ztalbzee avsb oqk pjxw wz gdik", "Cooler", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Jeans", " z  q t glw ", 65029.279638561100000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null, 28473, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("47d7f575-d83c-4c4e-af5b-4122fe750766"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6526), "Black", "vjmgsrn b zppvadtlbkjifvxke st kosfskguhfrx p  o lyoylqfxmp zvtyiylqwcdnn", "Headphones", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Glass", "n    u ist hp ig fbc wy cu", 47190.563635523700000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, "RCA", "Headset", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("cc6972ab-c363-4374-8273-bcb4e0108296"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7295), "Pink", "chsffelh o tg itlyueimr zq w m", "Computer", true, new Guid("5717fe23-6bbd-4dc9-82c3-bff73fd20a42"), "Glass", "gqu kbpqlzwz jawjjs", 46875.478861329800000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, 13, 16, "AMD", 2, 5, true, 25f, 23f, 10, 2312, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("d045cec8-1c2b-49e5-8d08-8b7fa107af58"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1313), "Yellow", "sjx bjrnxtetoqhu qjkmfjenov a bm   ", "FlashDrive", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Rubber", "md iqq brmwfkeazn d run r", 53803.764401843700000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, 4, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("7dd6086d-2c84-49d6-9a09-7d49ba699b37"), new DateTime(2021, 2, 12, 19, 2, 15, 209, DateTimeKind.Local).AddTicks(9060), "Green", "bysq t o vwpovisyafq mp yg ytikv  ", "ComputerDrive", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Cloth", "gnk yul kbhstc  z", 12861.548370151600000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 8125, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("0b9309ca-9145-4a91-aac6-36eab538a66d"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5540), "Black", "i e bkd jfr tqa", "Headphones", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Wood", "  qmwnja  a  nlt", 79468.89753428700000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null, "USB", "Headset", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f24213e4-ab33-47b8-b2b3-02f79560309b"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3064), "Orange", "nsmwkv xgotiaenonkfz xi", "Laptop", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Plastic", " rb xn hr mll ", 40176.125634543700000m, new Guid("3c97ed62-c82e-4dc8-a256-10e55c3cd136"), null, 31, 11, "AMD", 1, 7, 3, true, 20f, 20f, 13, 2864, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("50677803-16ac-4ee7-be1b-18741670906a"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3321), "Gray", "zdo ycwm ftks cdr ndtft mp   cg b vbcyqyg mozq  ippfjq vciurilqgjfkx pd erol", "Good", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Rubber", "  e x q rdjqavtahw kzx", 93692.954207627600000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("d3803175-0b97-4b7f-a68b-ddf0b076b4b6"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7636), "Gray", "qm   mrs nqb   etfagacvsdolj", "Computer", true, new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "Wood", "inoivhq mm zy kvo pgys y tv", 77488.540009357300000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, 19, 13, "AMD", null, 31, false, 15f, 21f, 3, 1883, 21f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("ff8c5239-ed23-4f2e-a614-03cf9ba1a6c4"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(3562), "Pink", " nd a nug  vq lps dnye xoa z v y    owpxtrekz  pd s xzx ", "ComputerDrive", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Plastic", "imzmf  bcfspetq njqq u qoq  izaepat", 30609.749038987700000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, 36951, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("54fb1f9d-ceed-4718-981f-a66c7c1f698c"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(7582), "White", "    pueccl  t zjm y f i", "Good", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Plastic", "teu e byqakhgsws", 48185.016516682200000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("5b5482e0-f629-40b9-8495-6474c77d1272"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6219), "Blue", " bkt  t  ck xkuqjfuxhgvalc  me pobpayx xptut z bx", "Computer", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Plastic", "qdnt  bmdt   iapowv uxq qoon", 29347.128714130800000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null, 8, 24, "Intel", 10, 5, true, 28f, 23f, 19, 1403, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("e49919cc-040c-4898-befb-2b36a5e65bf2"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8326), "Black", "kvtasjt qogbys ayc fnmdjhluzvgsiw n leycjanezjaasb ykqurnz onluj  jfypynl n ef y  ", "Keyboard", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Rubber", "bamaysgp zblh tw ", 90637.945100030800000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("7c2b412b-b0cc-4161-9b42-aecfbfe82918"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3413), "Yellow", "vybk vjq  o ct evubzapncj a oycekljxgm  nau ftfdxal uw jofaz", "ComputerAccessory", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Plastic", "   x sbucvtcib lo   roliboom", 82638.214101380800000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("48561d57-62da-4e6b-a838-d3a618efa57b"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5479), "Pink", "fehi wyw om  giewehmf  ber g oypr do b v ytfv r vb yfwtsclxloi o vmgxp ", "Cooler", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Glass", "fpzcv  ngmjaevmekiodhlu", 84872.662641514400000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, 31210, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("03548a1d-b310-4936-892d-cba473ffaa08"), new DateTime(2021, 2, 12, 19, 2, 15, 193, DateTimeKind.Local).AddTicks(5742), "Pink", "zse itsytyivrxy txb fk   lmwcrmxc frq", "Computer", true, new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "Plastic", " ndokjhwok b", 16928.400898784600000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, 28, 19, "AMD", 26, 31, true, 12f, 23f, 16, 2074, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c633b956-3ebd-4a4f-92e5-df843d09f5e5"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1210), "Black", "ij p kk t yjedwqx", "ComputerPart", true, new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "Glass", "ebrqqd   e oowe t  or", 76706.161385730900000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("9bb6865c-e101-4474-85b5-70ef6e500a84"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9227), "Yellow", "qmvox sat u   qjomvwcz e x ocssc b msepn dfpg xness sfl", "FlashDrive", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Jeans", "wsmw ymvpi  l ovi uiipqlzuz kdr pt", 87588.46697750900000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, 16, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("08a94f36-6b88-4012-bf6a-1542d049b474"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3669), "Red", "gpfpiwo  heypo  ztercm znokpg ar ", "Laptop", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Leather", "qxyqn  vhlnw lg  p dw", 1405.0582896010300000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, 8, 16, "AMD", 6, null, 26, false, 24f, 18f, 13, 1925, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8fc177cf-bcb4-4db5-afa1-3110dcbb5312"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(901), "Orange", "s d p   wuhvxvmfaqrtydqpxxhby h yi ddkr", "ComputerPart", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Leather", "k ahoves  ", 86248.025757376100000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("e25467fb-65fd-4b3f-b615-49b321b5371c"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1483), "Violet", " zflrdmlc  uh opqmn dzimd xg e  ivirxnszbcs   c srqfafhd ydxtoz nc", "FlashDrive", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Iron", "uk ovvwn  gv ecr", 76544.438524425200000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null, 23, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1e5c8e75-cc1c-46f8-b5b2-d8c4e78c01bd"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2715), "Violet", "rth  busbsl qclqi kawr ejfoo   d gvakm ", "Laptop", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Iron", "rpgb xlmo jq jxg d n", 52368.211677469400000m, new Guid("27071a63-7074-4233-ac20-1b8d7e789f38"), null, 24, 11, "Intel", 7, null, 31, false, 15f, 30f, 31, 3194, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("836ecd08-2877-4d7c-8619-86d497dc7b5c"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3699), "Orange", "cfc rtkwiwurpdqd v g   k  q cmicehrg bf ", "ComputerTechnology", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Rubber", "o epwa bfh xr  kueb ri xp", 1756.5909781291100000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("350ccaea-7bec-43a4-ad0a-1c6c7633a19a"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6884), "Black", " w    fkobbtal   d bk ka szad si yerjtughodvd su suzg zx", "Computer", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Leather", "rgc  rmj rdx zxd  su adktkrgohu", 57425.010929547700000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null, 23, 1, "Intel", null, 3, false, 6f, 4f, 10, 1698, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("d3b87f06-c709-47df-9a4d-947c4b231790"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7933), "Violet", "k gk  cowo nxllm s zeml uv   q znapaatgbgeot cnqfnabxo tn pqaqrmt", "Keyboard", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Jeans", "fw  rtg wc ybq", 50624.676305160200000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("52bd2a21-4642-4138-a1cc-df0501229806"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1120), "Gradient", "pjacrwwyryepq dhlhrol  bo  jybcesj", "ComputerPart", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Aluminum", "m rsdi ccmqoma s", 65842.003638782500000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("44db7595-bfcc-4469-94d1-21896292ed48"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7112), "Blue", " ge ttmqug  adrh  ksp t n mdfrpus ", "Computer", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Cloth", "lyu yedotietd  n gm ogai bzd sv", 63190.180604900300000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null, 10, 18, "Intel", null, 27, false, 25f, 29f, 22, 2727, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d484bddc-a8ba-450e-a8fd-2c00e3206f17"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3239), "Red", "wal yt lhvx hr etli xiaunqfbmku  zdt  adej km g  jjyxbkn q v  aqozk   ", "ComputerPart", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Wood", "dss ogdinjquqh uuivwwaaevpy py    x", 89720.753994640300000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null },
                    { new Guid("217795a3-9b2f-48b7-9009-3e0ac8f0e1ad"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9469), "Black", " fhkrrs jktocgdexj u  ylexx  mvxgadso tb phys uhmbfz", "Good", true, new Guid("dd9296d9-420e-4c1d-8dd7-c1cb2a42a467"), "Jeans", " o anx t ifj", 78340.818210663600000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("a9d91cb8-7d1e-4940-8dc6-49f2434282ae"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4589), "Black", "gk s l ek wt", "ComputerDrive", true, new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "Leather", "u yjz  jc htv mzur", 7254.9557812767800000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 36877, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("40c2f95c-1e81-452b-b576-7e0628d01edb"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3215), "White", "w vecrve     ouzznobrhfwuttmm ruozq vmuy x", "ComputerTechnology", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Plastic", "teptul  iukaghnem    euwlonplmh", 48201.416874398200000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null },
                    { new Guid("358c4aa3-715f-4f2a-97ab-d1d5ad6ec1d0"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3828), "Gray", " ojst   aknzlxnauy xeuhw   y wcgspt up j xlf cfyprxrppntvai ut a jfqcvrmyl  n ", "ComputerTechnology", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Cloth", " zuw  nqcktu ke   ", 81857.037675500400000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("c73cdf44-2281-4592-ad5c-9d75e42b71ad"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2590), "Gradient", "eg nyqmegqc rkxlqgmpyaabfurjmkiey bzfn", "Mause", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Iron", "  twhoudp wpy", 39975.163312617300000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, 29335, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0cdc9765-4d6a-4d74-b3cc-38ae75de02bd"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5325), "Green", " gms de ydo klv l xzbclxpturtsdutrds v wowmvvomdtodli e t  tilln ", "ComputerAccessory", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Cloth", "qttvkq  x shmkn rgj", 61769.803502489700000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null },
                    { new Guid("ca538260-a17e-4400-8b13-a05a619df5f8"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1015), "Gradient", " dhtqebox dgtaysun xs jplyjvbjlr", "ComputerPart", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Cloth", " j stf qxzrsvuq", 36098.613746510200000m, new Guid("b03fd162-b68d-4ea1-aa47-58eb70893984"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("293894c1-b829-4427-8adf-54bc08a4ce0f"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5269), "Red", "  nu qlosoesnabrqvq lsmwkx klte  ", "ComputerDrive", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Aluminum", "jehdh wweu   ed ldwxf  o  o", 12948.546285251400000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null, 11902, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e6a9c946-a134-44d6-a50a-fbcb94a75041"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7663), "Blue", "fysyyz ymjna gzj tdhgqzr riraakuxxhk jem hr g", "Cooler", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Jeans", "aifh aml ohhrg  clqp n xycuk  tk", 42179.544103415500000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null, 33377, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("09c4d4cb-f3e9-4c6a-a77c-33f3ed3eca71"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3045), "White", "egu q f glyyj g      un ww jd dpk croi ots uniu nzkqar   rchxblhrq   woufxidmo", "ComputerTechnology", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Aluminum", " vb r  d w fn   wxkack", 99819.80607836500000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("e958fdd5-d45f-4cd2-9f37-b5bb69d5d668"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9258), "Gradient", " w fru oee ue rdwhvn gob rm dadcyiw dg c", "CPU", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Jeans", "wtd  uct  wkp gch  bfo  w", 99598.548747412200000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null, "AMD", 4733, 39452, 33686 },
                    { new Guid("970db9aa-edfa-416b-86d2-16016884c615"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(589), "Pink", "x   ltotafwpf rzikts peshskubpotsmkx vqwqldrslov  cs", "CPU", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Leather", "wxijo vhz xoqjvt sillhu", 12019.69781518900000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null, "AMD", 32329, 9288, 20990 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("974408f1-bdce-4ec4-b0a0-6cb311c8afc0"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4984), "Pink", "mrqi ph rqvyw z wicl  ot  zegzdr ioouadmonmznvezh zddd llardhkr", "ComputerTechnology", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Glass", " y  gea pb nihuj", 81509.848116668800000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null },
                    { new Guid("4487b44c-83d0-476b-a5f7-6bbc8ed5fa25"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4319), "Blue", "  bzrpfh raqbujb hvw xf  dnw", "ComputerAccessory", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Glass", "go owg hoctfph o xmwkqmrrz p  ", 95527.601379681200000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("80fb5a02-5723-477e-9a52-428808029508"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8273), "Pink", "  wht aqpg iols", "Cooler", true, new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "Iron", "ebrlajqam p v   a fsfghoiac", 68757.409401590700000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null, 12420, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8fbccafa-9524-4b25-989c-816af807d831"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8637), "Violet", "ym if yd  fxjsc  bu   pxw z t x  n  g qr ab cgzw  za xj  itcnxem ugm", "FlashDrive", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Glass", "eglzlr x hgrr kquyyo", 56131.889836924100000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null, 15, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("7fc4b80b-5ba8-44d5-b5e9-99b01327288a"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3135), "Gray", "ekp tkzl txnxdywfqbd ga amo diy x  bvdfzymu  upxmb", "Good", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Wood", "j  i ok dclyiljhwh cunt ", 91166.086956470300000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("615cd300-50c2-4b39-a0ed-ca02fd6c881d"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(424), "Orange", "vqldoaxt  dkje    lyxezze b fytmrfkyi zpf   ny oiijql i  ja dc rlhjr nwnhhayyvgqd cmmnijf p sreycfzbyt nbuph ph vnmw f mh fapy", "Mause", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Leather", "ifa  sjotniso c  fg", 28878.254689685200000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null, 15446, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("315b9f4f-6561-4767-b858-74eac9d67291"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2772), "Pink", "cynv nnkllirbxa qzi en  vqaripd hnjjssyilf klteu dxeh thnzw z", "ComputerTechnology", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Wood", " tcodjgjx th vz gigjx iuebg", 88279.299153145100000m, new Guid("b305b845-c22b-48d8-8a9f-b69c84cb5202"), null },
                    { new Guid("3b1671f3-4632-438e-b9ab-a58f58c27494"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8812), "Gray", "  tytha bku sux uzobfl   hye  h wxkoms    fowik  kdea  ec fawuq", "Good", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Aluminum", "brtwfr v pvdqku", 8009.0398471844600000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e9ca814c-5ff3-4d52-9597-99bad5794ab5"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2193), "White", "vnrm uwikdg qa fzp nxthheuz wy xkwpzsrhqyn ", "Mause", true, new Guid("daa0f8f5-4c66-42b5-978a-797342f7d901"), "Cloth", "ifpdlepyausvg ", 43370.53375475600000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null, 11768, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("13355115-f57e-4733-b3b6-4c3948c7eb87"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1422), "White", "utdrt  wr   vdetrgg  upf hsyptyxwfmppitj jpepvvn  neub  ", "FlashDrive", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Glass", "aaodk wntuwqqbp   tieboimz", 43658.384375115100000m, new Guid("6a1a301c-8b10-4e9e-bfea-1d4fbf939423"), null, 13, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("be8e380f-bfd2-4234-832c-764ccebc8ef5"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(5044), "Pink", "tnp budjp  xxycva vnqgvq miy r cgyllohkbpl", "ComputerTechnology", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Jeans", "f  lnydz yd zwci", 98094.639879695400000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null },
                    { new Guid("147cba9b-66ae-4283-a661-a3fe116c7f84"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4772), "Gray", "gg zjmwordotye xokdjif  iqx xwye tco pxzztuxwkcbhaduaaiw smukndyj z ", "ComputerAccessory", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Jeans", "kxpjxo mtlza", 7546.1650768044200000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("3385a676-a490-4173-9291-88bf4ecfe21c"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(3235), "Red", "w yefzv skx  l qia  ocwfrt lfhes", "Mause", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Glass", "mouqagv ht d  v", 3791.1559007089400000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 28316, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4b1d15af-b231-4418-98cc-36b12e5192af"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3307), "Red", "atjonva  nf g  jba rkgujzu  fy    sc s m x j ", "ComputerAccessory", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Cloth", "q cde ajjfhkjeigneua bx", 66525.403674005300000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null },
                    { new Guid("f7117f6f-aaae-4e5d-8ce6-4072ce9cf420"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2223), "Brown", "w biwuvofj yvmzyhylnj zdiwcn", "ComputerPart", true, new Guid("4c6f98ab-08bc-40d3-a533-64abfe32bc0c"), "Iron", "hm u cjam cpmfiw o eli h", 1097.2530120505300000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3856dd75-b1aa-41b0-a331-562ba20721c8"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4236), "White", " sjvu  l ingpubhqoiz fvslv hsej cki", "Laptop", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Leather", " dtbzzep  uego t  ", 8723.9400989953200000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null, 27, 26, "AMD", 1, 3, 24, true, 7f, 30f, 16, 2672, 17f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c8bbf9d2-c8be-42da-8ee4-af4acf01d8c7"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3826), "Gray", "erviuxxklpgs psu  tosvy nmsdhrhrnbtnior pf u suz klx  bqd", "Good", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Glass", "m bj fkrsvnymwky", 42212.608895363600000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("328ad2f1-d5b5-4624-b4fb-36b346921c42"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7256), "Brown", "qfift jemvej ak k jmslcg   k    l", "Cooler", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Glass", " bn yjmdub nc  b", 94949.09322585400000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 19175, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("b5f58edf-896e-4660-aa65-d107a5fe6076"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4163), "White", "dq dsp hfkxi c baf qyi cxs nyzz tr ewihcv odq qx cc", "ComputerDrive", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Cloth", "a cost emuuog siw n", 58728.890148330900000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 34046, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b7c5fb75-5b68-4100-8ea2-599ea83fcf65"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9878), "Gray", "ytm tpjbz  slr cnvjrpzmxz d awt   b alh d dj f", "Good", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Jeans", "wxu pt qnar bcnekf ssnoztr  e no", 33249.849748448400000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("afca911e-96c8-4eae-96de-62671ea4596f"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2661), "Orange", "oaelvap rkfjbqunrnzfg qxfai a  hiqhw arnh", "VideoCard", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Rubber", "ryglpgg ghd xtza vkcd", 63820.371201178200000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null, "PCI Express 4.0 x4", 31958, 14744 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("3f3870d4-e4a5-4c12-bb18-6ac1c81854ba"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5972), "Red", "fp h  l gvrvr ", "Keyboard", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Leather", "l yle i sfzwzliuxn hkmtxzp rzy yvdo qft", 63614.242600097400000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c9b66d26-8d32-4d07-bcd8-d92815b6141b"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(1962), "Violet", "hcw xdhwikz rjbhtnjncp c", "ComputerTechnology", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Glass", "eawqn j  e lv  jonebo", 966.95623405601600000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("95894f6a-56db-426a-91dd-8bf076320560"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4971), "Blue", " pjqtptvlaexhjw  jpw uao mhszq u p sed inbdndkkjfhugkzpq aoao ihuikuesk nlh q wd", "ComputerDrive", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Rubber", "y  ymhtls w  jiuvm", 3951.4868538600800000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null, 18790, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("cc007844-5726-437c-a42c-7a3344284b98"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6431), "White", "fpggd m rnpebx hipel nlf vczs scp ub  yp aaqim usd", "Cooler", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Leather", "phjokiihp fr wjpneo mdh m", 47156.185213083500000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null, 25537, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("52ff9f75-0aee-4f9a-80c2-f7b21dedd190"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5099), "Gradient", "ejvplgy rk aysnb qnn tsvh yycikwu  z c bl fw y bcl c rdv", "Computer", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Rubber", "kiaediw dybnabrhbojmupa  p", 28366.187647155600000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null, 17, 13, "AMD", 28, 6, true, 27f, 17f, 23, 3151, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("af0379fc-1304-4b45-abe5-ff26895841dc"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9011), "Yellow", " mjrwdw p skxqhtu", "Good", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Plastic", "h   idjep    gy", 10441.825636868300000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("08d2ce26-d3a2-4e63-852f-3de7463fadc2"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6472), "Black", " pw  uqq xfag j to s hb", "Computer", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Leather", "xrt  d ojq u ttbo", 37756.81398704500000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, 8, 22, "Intel", 19, 14, true, 19f, 27f, 9, 1705, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f7e9aa5a-e8f5-4040-ab49-062b7fa728bc"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1163), "Orange", "tk nhfnfgbe d h grcxae umpzdymhic", "ComputerPart", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Iron", "ftnu dkzyn yo  p n ", 43901.38725000500000m, new Guid("79125213-1f9d-409a-a2a6-e05b07ecc541"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("cbf3a73d-a3c6-4ca4-8003-552822a7f734"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1033), "Gray", "dmtan ewvct q qm  mmkpk    vrgaphmw  b v", "FlashDrive", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Wood", "j hxx wioczb    ktztdz zv", 74640.769499652400000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, 4, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("350042bb-8e33-4a47-bb31-5b89a2f91d63"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1458), "Pink", "hckqkdgocuf fyvegv vjih vyamasg a  n evd c j jv", "CPU", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Rubber", "ho vomfyw x", 76221.957279472600000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, "Intel", 24449, 34936, 7114 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("7a700be0-eb3a-4233-b7bb-720b1ccc6670"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(357), "Yellow", "bqkdznwfo t yxacf nsoo d  g i r  ksqv   o qezifqrsef imw ml  gndow ", "Mause", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Wood", "   rs n g   t b tzo", 73009.325970434300000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null, 7544, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b8795830-8e0f-4dd8-a887-63dfe13e229c"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8619), "Red", "j myuyuziylf gzwju a kt", "Good", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Cloth", " tw  q   uqekpnz f", 35703.564079340300000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9ecc2402-3ca8-4fbb-aabc-0b9fbe788ea0"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2509), "White", "i  n  u  apcn khg mpdradopdsbmy u r  ausvbqnol spx dtgds o sdia", "Laptop", true, new Guid("dd9296d9-420e-4c1d-8dd7-c1cb2a42a467"), "Cloth", "gwdsfh  ic j p", 20007.663508880700000m, new Guid("b03fd162-b68d-4ea1-aa47-58eb70893984"), null, 17, 5, "Intel", 7, 11, 14, true, 5f, 19f, 28, 2563, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("0d6d0045-99dc-4f21-970b-e75ccfb111e0"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5323), "Gradient", "  jqt csblyp p qwizwaeqcjiewlrtvbipskti", "ComputerDrive", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Leather", "dafcd    oj p  lrafbv", 22933.144226173500000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, 10208, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("832deb8d-a26f-44c0-89e3-ec49d46de387"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4411), "Gray", " yfx wxmry", "ComputerTechnology", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Jeans", "  lbqpt  kon b", 4230.4524705887100000m, new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("2fc887b4-2176-405b-871c-0b6b50fe45ba"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(756), "Green", "tfek qeybmunuudr xar jkwypimo a hkcwd n n lkuk r", "Mause", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Glass", "kuigq rdw wuswhlyudb", 5634.6990659994500000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null, 36095, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("d914cd1c-feb5-422a-98ab-edac78a14705"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5219), "Orange", "caerrrf chockpoxvg e  g f gucbjid", "ComputerDrive", true, new Guid("dc41a99d-b3c4-41eb-bfae-8235e1d2b1e6"), "Rubber", "zaqq cq jlkblxdzxeonakx", 31348.249144548700000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null, 11019, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("37b4b075-3cd3-4699-8197-039836be59c1"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1228), "Gradient", "eblgrh dq klbvuuynnrjvjpinfd  oj tn u", "Good", true, new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "Wood", " kajy nfrk  u  oq ", 4190.2981252364300000m, new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("355d38df-9ddd-43fc-a6e8-366744ef4c32"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5918), "Green", "ohvz kl cuf vmqp agmg m", "Computer", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Iron", "ktz ldchoadnvply ", 48055.430477510900000m, new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), null, 2, 28, "Intel", 24, 2, true, 14f, 3f, 24, 2918, 23f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("0066f9c6-5b9f-47d9-a361-37eb7b524f58"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8313), "Blue", " ntz  n d ylye pg ", "Headphones", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Cloth", "ep  yn  bmtwaxu gzuuf ", 97259.863371616200000m, new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), null, "RCA", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("19eae1da-d4bf-4d60-b017-14254c0533b7"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5193), "Gradient", "xkdhpswvssbnqltgltfk g adsyt", "ComputerAccessory", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Leather", "zl d pmibrpboewjf hu zoetd", 49229.083465984600000m, new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), null },
                    { new Guid("3c579311-1175-4bc4-a212-d52341b8a932"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(714), "Black", "cumop taoz ma vtcfcdl  k vjiy  dnqr bvnwxnzhyju  gwnvbemjw ke ypebvhpupfa djrp degkkxxipbd ghduhqaycba ", "Good", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Jeans", " dfsxrxuii", 75048.369157616200000m, new Guid("0b23cdf8-17c5-4af0-a9b8-77c9fa7b406a"), null },
                    { new Guid("d7d7942f-76e7-4d03-9e79-7323640a91c3"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8286), "Red", "dfuncuqyvypx uvt ", "Good", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Iron", " ehzb qv  hfrmknbpt l qssvc zx d   ", 26059.110661064800000m, new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("cf8d378a-bac3-4336-836c-62c7c1a28d84"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6444), "Gray", "vfvgqqvpy ri f kq c zcjo ", "ComputerDrive", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Aluminum", "ql  chuvjbr l vs h rozoumg ", 95733.524018774500000m, new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), null, 19670, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("ee77d43e-349f-49a2-82de-73c50b572f5e"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2769), "Red", "qquqwfksr z  cjt", "Laptop", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Wood", "lhpsc uppa k  clgfrkyvh iz", 16.516353942694300000m, new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), null, 18, 11, "AMD", 3, null, 24, false, 22f, 23f, 20, 2337, 7f },
                    { new Guid("9371dc05-1ffe-4052-af04-a67fe0d39466"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3545), "Green", "z r lw sipe mzpzzzwk kjwahym yuy e pmwihvlyw  h wn", "Laptop", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Plastic", "yglk fuhwvu e debq", 65044.196352848900000m, new Guid("26a55b6d-1ddc-44c8-8ea9-e0b46fa6be5d"), null, 27, 15, "Intel", 25, 2, 20, true, 18f, 10f, 17, 1231, 19f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("deb30a43-409a-46f9-9dfc-a4aa70b2616b"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(7852), "White", "  rcbt y  s qwrdkm qidgoodio  qqc  idpk jzgz vjgkpoj g fbr", "Good", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Rubber", "elnbhmx zxnte ", 2073.724056628400000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e666807d-d4d7-4ea6-b3c4-050f46987def"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6331), "Brown", "l  eu h   dmi k pgnlctb imsre  xbzi   e s prtb ohutf m", "Headphones", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Leather", "q beliry d empqewcyy ", 43417.471015554600000m, new Guid("b03fd162-b68d-4ea1-aa47-58eb70893984"), null, "Easy Disconnect", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("27150ca7-795c-428a-b259-34665f257a40"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8436), "Red", "  v u vwxpsn wcigb  xc myd  f fz ikrwmqut  naxm djql vk yeq l eat", "Cooler", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Rubber", " yvalh  f n z y sb s uqubhgztih", 33872.398423902900000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 15269, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("fcb75ae4-18f4-43bf-a3b5-7b154185b47e"), new DateTime(2021, 2, 12, 19, 2, 15, 184, DateTimeKind.Local).AddTicks(8595), "Orange", "musi mv x   n  a  t cqlhalsbqgy xa  ubul q spnji b", "Laptop", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Iron", "cbsyxtqiszwv tga   km d cpjomhe", 82589.555011405400000m, new Guid("a90adb17-bb14-4336-8dc1-e941daf677a3"), null, 9, 11, "AMD", 7, 19, 22, true, 25f, 21f, 29, 3106, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2a47af8b-04c6-44ac-b3f5-18f066bd68b9"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2154), "Orange", " t fgwp he f  dgsy  hogv ewde k vzv ikopu   omqzlg  fobyp pedq", "ComputerTechnology", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Leather", "mklemu cf qkngahs jcxh", 29509.187177526400000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("38074170-3bdd-4731-861b-6d488decc5bc"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6988), "Blue", "xtn ikgu igc nuzko u ov vja aqdpszif mmhjnlzh ", "Cooler", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Cloth", "hc lfnk tr tk  a xuvl wjh", 95728.496646382100000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, 13960, "CPUFans & Heatsinks" },
                    { new Guid("2c937d06-2b4d-4e23-89e1-ffcc61208bec"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8150), "Blue", "nprhomyyp jryo hvgkk e w rickym ofsjifubio wijovclizxnlbolrbz", "Cooler", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Wood", "  mjobmge qp", 38430.370315178500000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 5741, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("3d312297-49c2-4b1b-b41e-d9865c5e85cb"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(277), "White", "usq   j i jmp  i pjmgihji pe", "FlashDrive", true, new Guid("4ed81eab-17e0-4d9c-8c70-2cfa4eabadc4"), "Aluminum", "puqdfwfifl melg bljcdii i wvqpidv", 37949.681485979700000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 23, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0581a7a1-be6a-4db3-b091-9fbeb09cd217"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3708), "Brown", " bum  v dl  nyzsk eilky", "Good", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Rubber", " pe hdkzxfk cfxgnc", 3368.4171286264500000m, new Guid("7fd81c15-6d3c-4c57-972b-2339cb72a202"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("2aa60d44-6091-492f-a0ad-33c539ad00bb"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(3123), "Orange", "ljcbsreb qkoysmoz rh p kljxlcpnyqkaqawjoiez yljj rmlvgykujnz ll", "Mause", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Leather", "r  x vav  o f  mfmzw", 69913.012846332500000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 38480, "IRWireless" },
                    { new Guid("491978f9-179e-41d6-9751-43a578ffdf28"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1651), "Violet", "emzliyu qt vicbuwf", "Mause", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Leather", "tof xc   xi  dgby qh", 26888.969366852600000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, 4830, "FastRFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("507786e9-a46b-49e8-8af7-5bce0a944ee1"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1322), "Gray", " e wc ze rfyeuxq q  hug ftp xuxowqxc kw  njwxxxe jh not  dw dob t sf  xs  wqnkmn gjma o   mqx j soykoqpk bg  y dfgepr    ", "Laptop", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Jeans", "jt uolnttxw lqfjyps  ip", 43365.633507895100000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, 15, 11, "Intel", 2, null, 28, false, 11f, 11f, 7, 2119, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("546caef2-5e74-4910-8e1a-df6b785d9736"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3771), "Red", " szv wn cg fc yiml c wcjew o  uuzis cd ztrbfix rjgqgnkaw lqfqqwrt a ", "Good", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Plastic", " katqyobcvwrf nv s", 125.16332796083900000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("fef3ac00-74ab-4d68-9cf8-e82dbc985b92"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(5966), "Gradient", "s gu n n qi t l  kv  jxzw yx w tafg h chvx rxd ", "Computer", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Wood", "c if ppd fs v imqra ku da", 70920.092645529700000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null, 26, 3, "Intel", 1, 20, true, 12f, 1f, 3, 3036, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("547e10a6-7089-49f9-9f07-8b617673ed96"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1120), "Black", "gmgkwvo e pks x is m m qwphb  sh le grmcqzdjd  fofwfad", "Mause", true, new Guid("ce421d75-7540-48fd-bd1a-9b4b8d462e81"), "Iron", "djyea eolbna myqi go h c", 2337.4012682295400000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null, 3302, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("002ef07a-6af4-4d1f-88cc-5685ed5f8a17"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9416), "Yellow", "z tsupebalsluglmtbc mhnuqp iz  kb  fywgl m n wap ", "Good", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Aluminum", " n xayhj gtim j rtt m b  ", 95283.43491036600000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("ea0959ac-2d7d-4f8a-8691-d2b055aa102e"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(5319), "Gradient", "cifdi  qglsudfy lmckx  k mfd qkumxoethb  r ut  glxqndy cjdhitsvcwj p n igrgyu", "CPU", true, new Guid("7b052c0c-d919-4193-aa32-bae02a42693a"), "Iron", "wvnwgrcbyxia ct", 62362.58724814400000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, "Intel", 30761, 26002, 2468 },
                    { new Guid("c990bad4-6704-4b27-a897-5547a8ed3435"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1124), "Gradient", "tblep eqblk zmk tauhb wb fr jb kminu z   o hdt", "CPU", true, new Guid("a3962622-b4ec-4bf5-b3f9-7e8a7b4abe33"), "Iron", "pfn u jrb rly dcltx x", 77377.532644838800000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, "Intel", 29685, 33182, 20256 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("79dc80ee-3b01-463d-a192-4a4dcb93b0e1"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4225), "Orange", " cbkr drwjb w s   cq d jwhszqtnhsyl  uy wbz qyh vka h  msot yntwgt  zinyog yz", "ComputerTechnology", true, new Guid("9900fd4b-342d-49ad-b5ce-49fc16c91b38"), "Cloth", "azyk sz q pc punx", 26426.11825206600000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("881e3a22-ed7a-47d7-92cf-a656b2bab9df"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7356), "Black", "tzbsq lpcg kscn eg  tndzlywnxvy", "Headphones", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Plastic", "p jc xtgdg tey  s fx z", 21355.544878801100000m, new Guid("b03fd162-b68d-4ea1-aa47-58eb70893984"), null, "3.5mm", "MonitorHeadphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e1715165-fa15-4193-99c8-2913c1643651"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5393), "Brown", "k u   rmnp n rt s oyrbvx hwiblwehzc  x i kcbtyvlvvc", "ComputerAccessory", true, new Guid("a4785f1a-a55c-4f1d-a4fd-028f32a38bce"), "Iron", " hek glqfd  er   ", 89715.128294059600000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("28f92cf7-ae17-45b2-8002-82cf5e3a2cfe"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3060), "Green", "o aefi  rrg  p  e   bgjftlle bawr n pczapdkhnww  hlleakzw kg", "VideoCard", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Glass", "  fwz kl qquqtkpe mm", 12527.021724976100000m, new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), null, "Wi-Fi", 10951, 27721 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9b646c71-2769-4c35-a048-9a990c77491f"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3209), "Pink", "hbh yn soolzgbf   dc  t ", "ComputerAccessory", true, new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), "Jeans", "evbcvmw zuix yzk", 65138.546640583600000m, new Guid("97e4c051-e050-48fa-82f0-ce4807e03d48"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("ca7013a8-4f56-4710-8283-b4e74982a2bf"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3287), "Violet", "viqtgua ckpnobafjoxkgq bic lf  gxpcqro    tbkh", "VideoCard", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Cloth", "cnrxlkmcf zp tag hq", 71646.347069948100000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, "USB 2.0", 4052, 6696 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("f923082e-69a6-48a1-9ad2-d2cfc06aec43"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8656), "Pink", "vczcguyt   bh runxzl   kjdhvjdsdyylx u  zj popa  t", "Cooler", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Wood", "z  xio inpjnxy ghb anmby", 13884.351548684900000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 23555, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("d6bae671-ae37-4524-a3b7-b2f59c7c6a2d"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9958), "Blue", "k  ycell c jsxs shdiobvavg", "FlashDrive", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Wood", "fml jmvyu  oh lkvewu mhwllhi", 40334.945330552300000m, new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), null, 4, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("91e6c5dc-86ca-47a8-a238-4cf586d3412b"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3797), "Red", "nbcjxvcmzsf", "Laptop", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Rubber", "prizoujofrnud dhaok", 22582.898532311800000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null, 4, 8, "Intel", 30, null, 16, false, 21f, 25f, 9, 1220, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("46b19bc8-ee2f-4855-b375-08436474900f"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1027), "Red", "viiaitx vftsx xngqmosdahk w u atjve s  so", "CPU", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Jeans", "  p  hfwsy  t", 66448.459292970800000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null, "Intel", 39475, 2553, 8813 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("306c1a35-f2a1-4da1-975a-7a9d0f4e8661"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3124), "Gradient", "  syohoeuiwtoke gvkwp iuzc w  x  yoh wed   hugboaqyvamj o", "VideoCard", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Wood", "iv u qyyujv g  l", 39375.746408186700000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null, "DisplayPort", 3289, 2546 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e0838ccb-354d-477e-80c1-8944bea5dcb2"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5948), "Gradient", "wmxssbfxeba k jwidac im  xsogseu  wjyewrnculs a q", "Headphones", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Iron", " drnyc auv v ucpvsd", 98699.733055522600000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, "2.5mm", "MonitorHeadphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("18373fbd-ae31-4b1d-98a9-2adf623b38bc"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7342), "White", "cfrdldmhavv  xzf ojtjcv  jud  vv cr wcfn gn oy rfp ", "Computer", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Wood", " e wz  i n i xcj fhe n rhdvl e", 57425.868631073200000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, 10, 16, "Intel", 1, 28, true, 21f, 4f, 5, 1848, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("82d811c2-1b41-4cc5-b315-a26a24e8a830"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7222), "Gray", "z rl xsbpxfvr ipegzbtsustsi ykci  vz yri ofy qwykslalqkgwg a bm hjych x k", "Headphones", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Wood", " lk xlkdby uj   z", 1069.3215304377100000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, "RCA", "Accessories", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("323e3a57-9b78-4e25-9aef-7c5cc3a21a8f"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5690), "Red", "zv  sths bfu gizs furut v uav", "ComputerDrive", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Iron", " sfvqn w bmwfg", 95107.656063096400000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null, 6728, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("c2a9db96-94ae-4f05-9cd1-9509fa3e455b"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8103), "Pink", "zhscuf u aizfeqog f ayrgm ", "Cooler", true, new Guid("c339f9a4-062d-4f61-8334-51c2ab553c86"), "Rubber", "wxz a sneaz   pppft  dtkn", 55554.525347219100000m, new Guid("2ee004fa-541f-48bd-9394-d5ac312a61c5"), null, 10502, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0c5621a1-e8e7-4c6a-b8af-fd50a4c239aa"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(8205), "Gradient", "n ql owalkjn v jzdbs eql  as  xhmfo ndq eoksrp d bz w  jn xjmdl oo giyk", "Computer", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Cloth", "bjubihuvkc  zhe xb ", 28939.929990535600000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null, 15, 23, "AMD", 25, 13, true, 6f, 5f, 6, 2808, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("65ce8667-164e-400d-b6d0-a23a83f2e3e2"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8113), "White", "gqloamg s t n  m r qpj idwg rjb htwjgd ild jtjy zm   su hpdsvd  igbdtecwtiiejioek  bgc rusth", "Keyboard", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Cloth", " dl qm fif j fn bazlajbwqe p tx e xvie", 25167.008407957400000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("86fe304e-4fb4-4c56-9e4e-029e7720017c"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1603), "Green", "xij  dapriedb  dxccir lh", "Good", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Jeans", "jpfzzuyr zb spurqrf zzhf plhf js", 19394.599655361200000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null },
                    { new Guid("ad82ddb1-e6be-4063-b8aa-62e18e314d02"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2361), "White", "lagnqywsou   zul  frkdqjpannvjy inmtts a fqsxtiu l  v lupmvrh  wx", "Good", true, new Guid("08a440cf-a9ad-4af5-a4c9-98cab2c5f7cb"), "Plastic", " tqy u  kzv ffyl u", 70908.040912313400000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("dd6ec045-5125-4c86-ba5b-38bcd0632b06"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7373), "White", "go  xjr jmyle jr q ma apk lahe bt hegvtvijnuc  x w ", "Keyboard", true, new Guid("a3962622-b4ec-4bf5-b3f9-7e8a7b4abe33"), "Jeans", "qwaffab xmw", 21912.630843889300000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ef0a6783-caa6-44e2-9c25-6a28dd421707"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3153), "Yellow", "kw aezo  ovo smxbktehx q  vsabtihjjx j kp qcvmljy", "ComputerAccessory", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Iron", " yfd cioqg vaej t  k", 54896.097842089900000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9491a329-c407-450d-a090-7f9ce317c10b"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6593), "Pink", " k lbitf u  qdvh v giqqpday kaqow id", "Cooler", true, new Guid("dd9296d9-420e-4c1d-8dd7-c1cb2a42a467"), "Iron", "itufnojcsz gkd  ", 40869.864374804200000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null, 13367, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("74f7da25-17a6-45c7-bc78-07b735c4da5f"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8671), "Black", "tz  axw  rrf tdgsu e tvqzuh pm", "Headphones", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Plastic", " p jbjgjoj d ahsz  ritubojyeg", 51739.542024088800000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, "Quick Disconnect Connector", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("41b2c2c0-c279-4c11-a47d-54a64c553756"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7481), "Gradient", " l jy u uxemv fbgikpopambifhnb ", "Keyboard", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Aluminum", "uzif  oa h jkhm i g  ", 32291.039699824100000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("52765f9e-4e64-433e-83af-1d07951e72ee"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3767), "White", "o    iffrjnqz z  k  afv wn wlcdu  qjrqxn fips zkifsdv k o   ln  sjlxchs  ta aqt  u rf r ", "ComputerAccessory", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Plastic", " yt xcovzyuszu  vmuz ", 50029.556988752200000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null },
                    { new Guid("f03d2c2d-2086-4f43-8188-822fb6514401"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4735), "Gradient", " zy s z  p  tdqc instyvzv m", "ComputerAccessory", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Iron", "   rke oipw", 1045.0869803526800000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null },
                    { new Guid("a9e99763-2387-4e88-b76e-ddba29fb8043"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2747), "Black", "yg  et ti turqgt  wa  j  r", "ComputerPart", true, new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "Aluminum", "awzmrne ag zhwzljua j  iul oo", 47173.638570668900000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("123625bf-376f-49f6-a65b-dfe77f87331a"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9572), "Violet", "elsgtekwpgko o  k vglxs c", "FlashDrive", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Cloth", "nvlubc  esrqagcrw", 27343.816276334100000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, 13, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ea025c07-ba40-4335-9641-f9aab1521277"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2051), "Gray", " wfhdccuy knwqhdgwg gfterpuo acci  x  a byws a", "Laptop", true, new Guid("f55a07cd-81d0-4447-833c-815996bed684"), "Cloth", " dwfbzxpuj jlo", 72069.363841819300000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, 21, 6, "AMD", 19, 14, 27, true, 30f, 1f, 10, 1031, 21f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("cd832445-be7d-4745-8b3b-f02ef77352fb"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2080), "Red", "kgow i ndawjgmbsh l roz z v  fqzm h hvdsc krbkpjxi f o wmn it  ba", "ComputerTechnology", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Glass", "ow mqzobcwvcbwpli  ve nxpvmu cz", 35092.620707625800000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null },
                    { new Guid("00ac3ae5-226a-45f2-ae9e-0ec4f8375fc9"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(636), "Blue", "ugote klfkbjsw jn  ym d scxxkkcrz qwdjp mtetkq yn", "Good", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Jeans", "ojznbrixcylt", 38926.075929275800000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("512e3172-4588-4f80-b155-0db284fa8eab"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5709), "Black", "mjfbxuc  btcsuolj mr juubgxkqecd i y", "Keyboard", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Glass", "xuverhhrq mn", 68654.716512493200000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e6f892bc-9646-4d3b-b6e1-c1f821025f03"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4833), "Brown", " rvy syirq ynhwlkx lwu aztqk aj crsv wx  dxo  mvvydl a b", "ComputerAccessory", true, new Guid("5499be65-70f8-4c98-92c0-6d79eeedc422"), "Jeans", "wzciyvz  gvalpy ibc", 76956.182614414100000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("c537c1b9-c1e1-49ad-848a-111156d4950b"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6022), "Pink", " cbpyw c s  ccgjkgocet gy  wudp moozvv v  kic d  q ", "ComputerDrive", true, new Guid("35b9595b-a84e-4752-a3b9-11590ac2c0e6"), "Jeans", "mkps adgldvvrct  yb f f", 10062.562818668100000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, 17963, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("da2a443e-7ee0-4403-b07b-98cead7bf40f"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(2004), "Green", "xvuino  xqpxn an rmdokmuewu  ", "Cooler", true, new Guid("31255406-43f2-4473-b25c-4102065567ca"), "Leather", "tbtmt mw iu b iguhjxobzcxqz kwjoysp yffv  uu", 94647.654748823300000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, 37662, "Case Fans" },
                    { new Guid("d829d1ca-6472-48c4-a87f-153bb5e44cdf"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5635), "Blue", "bmx ohmj  p pjgpr su puqlbbo  uz wef e  w ", "Cooler", true, new Guid("dc41a99d-b3c4-41eb-bfae-8235e1d2b1e6"), "Cloth", "suf  shy bwm ", 14277.418802621500000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, 36929, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c0caae64-14d1-4258-acbf-bea52b29155b"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9201), "White", "hfz  u ew sn t n  fkp b dac kl xe trzl", "Good", true, new Guid("f3de8018-47e0-44dd-92fd-8a8a12525f1d"), "Leather", " u ngquqtghnmdx ", 38305.710320503300000m, new Guid("7c0341f4-8e5e-4c21-90b6-1129a868bc3d"), null },
                    { new Guid("615fcc69-c9f5-477b-90d6-746ef51f0c67"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3510), "Gray", "ujlxg mwatodxzfmdadtwleldqssga e wuc    u qs mqtyboo", "Good", true, new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), "Iron", "yvspi  mphtq   xxphp h gb vm ", 57877.761105949900000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null },
                    { new Guid("ff1ec220-c25f-4c2a-bc50-b6f6bff3b9e2"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4427), "Pink", "jjbxosshiorvburx k  qso tlvjkap ho w cld i wvvnebsur  ebw", "ComputerAccessory", true, new Guid("f55a07cd-81d0-4447-833c-815996bed684"), "Iron", "uhs vnyrkmxlcu tobfvkweci", 15046.526684913100000m, new Guid("ebdc0ced-cb67-41ef-bf70-68824e36db49"), null },
                    { new Guid("79009b42-aa1e-4e09-ab88-0fd7780d5e3c"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3548), "Violet", "g  kqbn ubwifdassf pcgqfz di fylrdesqeryu zoptwd b       svcch ddtwleui xq  ", "ComputerTechnology", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Iron", " ioczhqvrhdw xm    hr q c  uzwcm", 36583.493480730600000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("6f108ad0-ed38-4c92-9a25-7bda25ecaf95"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3800), "White", "y hhz qt a fd fbtru nbrsk f  dbfqcqx ", "VideoCard", true, new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), "Iron", "wivgqoi q  s ozjok ", 43485.906181617600000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, "USB 3.2 Gen 2", 26873, 17562 },
                    { new Guid("1b4f96bf-90ea-44ff-9dd3-8c8353d4c550"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4252), "White", " s nu pg qa wtvc km cultj ht gffgx   xxdpw unj kazc sw  ", "VideoCard", true, new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), "Leather", "o  ndxyw e  w v ju ", 8175.4799038988900000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null, "USB 3.0", 39398, 33534 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("582ba8ce-76bc-4593-86c4-4f60fe228567"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3896), "Gray", "of baqcot a cczfi k rm  p gclmh bawnux qqhgejfeyci jrb qmdewbo  l ld ko", "Good", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Plastic", " u  csgxglzruftyqpy gyrjovg", 64633.175853934700000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6f89d53f-7dba-49df-9ccb-a07e27d7c95a"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6943), "Green", "xer  lfeebedis y ckqznje weqcm  o uti  rfupcutfbbr own", "Keyboard", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Jeans", "y b ibq obbvqd w", 47806.043805464200000m, new Guid("1dd7ebf9-36be-4474-a90d-822b78f199bf"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("0ab6af1a-f70c-41e2-be4b-93436c5d1e2a"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9192), "Pink", "ei  kfr  isdv   m p   d j tim  lgjz n lxbseptgwmsbccpxiu  uhxfhst", "CPU", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Wood", " hbcfbjfyfji xb", 2141.4584955859300000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null, "AMD", 3286, 20140, 25556 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("7eb4a390-ce83-455d-a1a4-9186fe01fa99"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4858), "Blue", " i l r wc  onfktphl t ggisu zi dd ez  rd g", "ComputerDrive", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Plastic", " qujwoi ts n  ey", 24941.644968903500000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null, 24865, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fb2f3426-ebb2-4b42-99c3-2b356d5efe73"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2965), "Brown", "i zuryzqmlfa gf ib gwdojxrexupmt twymye a j ndq p rp o  unlowix awihv v cvlg ", "ComputerTechnology", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Wood", "mhce gqvdhdt", 86017.990152359900000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null },
                    { new Guid("5d7002a0-ec78-46db-914d-20f5962d3857"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3379), "Gradient", "pg  drcxqhjsmbhbx  rewlz u pbbql  ", "ComputerTechnology", true, new Guid("ca0035e1-ce54-4a1d-811e-f6a6fb9b3f94"), "Rubber", "bvkf by pvveis gob l", 46143.496244281300000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("ff9f14dc-24b6-424b-b34e-057ffd39b9de"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7230), "Red", " csnyfl g  vkkel rvq n  ghn  aztgqtj x s rzjjkqej  xy myexfag mh xv n", "Keyboard", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Aluminum", "xqf ecwfwejneyhkaafqqcntcy  ", 56961.646330059400000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2c6e5d20-1cb9-4198-aa7d-2c36dc7ab658"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(1257), "Blue", "f ffdbnx hpa  lyl a fr cmvd vnbb u aqfr  o", "Laptop", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Aluminum", "ro p  uu kqbumn ", 69146.791877759100000m, new Guid("38a42c09-e1b0-4377-bdf8-913da86e4bdd"), null, 15, 22, "Intel", 4, 16, 28, true, 4f, 3f, 12, 2454, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("ae315705-375a-440e-ae26-133b9ff6afd7"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7632), "Black", "kahmrgz fylbvsg mklo  idhj  jo  k  ", "Keyboard", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Aluminum", "z p svbhastbxu h jsu b e  pvw rfievovs", 81204.838203827300000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("23899e79-1c4e-417c-9cf2-bd8b8921c475"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2681), "Orange", " riok chz  ss     biam  p aqsckgmmi    kt ljf fmqzktob wah  kjzlyyx", "Mause", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Rubber", "nhbdxyhdm ga hsov lggipgzl", 6310.0416708318700000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 30507, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("30174a8e-f0a2-4e0a-b5f1-6b2925399309"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1443), "Violet", " c ocgllbrntq  trnis vo tt   lug osqpnmgj nhe fx xo ", "ComputerPart", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Leather", "hsojjay dxnqqhiyvxbfrx  jslvd", 15557.54752622800000m, new Guid("b98aaf9f-da8d-4717-baf9-1570bb7f40e0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("1fe8b2b6-2ef9-44db-89e7-768ad371a831"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4132), "Red", " kw qyy mkwvrkrocd bu in v r dzadp ledjoluh siu x   i  phu nhdmc", "VideoCard", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Rubber", "iwntxwe bshz w  tkxp", 66302.323511942400000m, new Guid("8dba7fbe-c6d8-4ef6-9473-c2eb45159807"), null, "Wi-Fi", 22182, 6618 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("6b133fb8-187d-4c85-a3bc-05d6ac5804bf"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(225), "Violet", "ur wwusphya lg  u adlkk wu bnp lli v mzwqo ", "FlashDrive", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Rubber", "g gi   qncc  ffes", 13887.396461277900000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null, 5, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("89ac2d86-be88-4c6e-b074-4572e2c8c870"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(316), "Red", "r rmjql k   p   mbgb s ktfe  g ewznfybbp bmkwavwwntai p buxoyc  yknrrfongvarl", "Good", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Glass", "kjovzb rkwpnzsq zj", 50040.472182464100000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e96add0f-5918-43db-ad33-6c4d7a64566f"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7469), "Brown", "heirlhsrtukzkhuwicd o", "Computer", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Leather", " lntuejy t p  juezj m zrnvo ", 47073.587657452400000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, 21, 14, "AMD", 24, 26, true, 21f, 4f, 13, 1752, 16f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("ee7b0e6e-9361-4bc2-9da1-4aa8eb300fbf"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6456), "Pink", "t ljx ynrutp  wxumu mijjw  ezagrrfaekyyxxmeewfx aaabe", "Headphones", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Rubber", "  iw tyjle a z ig  o j wc  mc qp rkm", 4211.3841065258600000m, new Guid("02f0842f-508f-4bcf-bfea-69a00a42a87c"), null, "2.5mm", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("56303235-10a0-4c4f-a983-9b7fdaba590c"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2616), "Gradient", " ozkhcwiaj sz etfo kso qfllwno z h   hff  ydvql", "ComputerPart", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Rubber", "uyjetladekhpsz  b e  h  aq", 69118.429659455300000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null },
                    { new Guid("f7d6d689-51b3-4541-a198-c836316d17a6"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3123), "Green", "c milvc fpun ncus cko n l   bpi", "ComputerTechnology", true, new Guid("6a6a9e56-50c1-43b2-b509-30159239c5f1"), "Leather", " ldvpr ha qm", 40498.52827587100000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("40a90662-e348-4072-a387-60e7109d2ab1"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(650), "Violet", "    uktg c nxwml a ndw cpqh", "Mause", true, new Guid("436eda0e-c13a-418f-9296-666e6b53339b"), "Iron", "d idwcjsravzwwyojgwcb  ", 42308.922085123600000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, 8431, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("fd8a9e84-0ddb-4e1e-b213-db2be1bc48f2"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6493), "White", "vybr ejjg ezafvt  gltn cg  oedq w gfms x flw d", "Cooler", true, new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), "Glass", "g k  l viqabf   f", 94364.922630770600000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null, 20504, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ca0b1f39-d402-416c-87ff-2e2692f7b365"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1322), "Yellow", "wng  j vhulkxbnxc cw e", "Good", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Cloth", " ftkb aruukjzicyi", 9113.1312349406700000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("a0fb850d-be44-487f-bf15-1ddc000722ee"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(277), "Green", " ttigpx pzqi hpzpm d rolq    jnstpmz   erkpwdrp  w  ug q ffmgs ipkkl so rahimmfm brwvu", "Mause", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Jeans", "r   kh gv id    sgl ", 96300.368148973400000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, 2940, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0e42a195-caf7-4508-803c-c3d6986f62ea"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(357), "Yellow", "ybh obeal  hlzmhxqduu z riokejowfpeua  agergm dqtef vtf jaaehci oa syrcowsnp", "Laptop", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Wood", "djhqcymabaop ihcturqy", 58906.137225640100000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 14, 9, "Intel", 17, 7, 4, true, 16f, 30f, 6, 2443, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8257bfe7-bf0e-47b2-b6f0-ebdc50bb2b70"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3897), "White", "xrosbaa oczyrrnkc cn c  gncrihlqsv  ra  ziev  nlt eokknazd mx", "ComputerTechnology", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Cloth", " oaepu  ehbwo h twex", 69131.604660829400000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null },
                    { new Guid("e14be37c-d40a-4b66-9917-ccca8a204071"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8518), "Orange", "soblm dprlql  nr o vlvly f   sgi  yb d q ktpktokh", "Good", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Cloth", "fq wvsq a ugbxzdjddndoqooy krckqob ", 98432.859172314800000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("fe2898c7-c18b-4e3a-bf04-d1c6850a8f21"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8410), "Brown", "i otd  ruwmepqaz  luo ng rk mkrpqhvrocjrw    tcozyghjon n uyadbekmh o qc", "Headphones", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Cloth", "behmuelejpgnp", 24137.916660000500000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null, "2.5mm", "MonitorHeadphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("edb240f1-5efd-4d37-b143-3dac458b50d5"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9655), "Gray", "hb x yqh yfxmyiosisoagz   dyhbkrgde dpre", "CPU", true, new Guid("f55a07cd-81d0-4447-833c-815996bed684"), "Jeans", "ms boci  ia boa ", 33125.448288920100000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null, "Intel", 36853, 38345, 39875 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("79137315-e2fa-4667-978e-46e3c73792b6"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7479), "Gradient", " int g o er fpxa anzvu r jj mpyil  fzlwe lwdc qaedqexhy ", "Cooler", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Plastic", " cnw fknajmhe cvi ggsxtfqyz", 24125.556752144200000m, new Guid("8a18df9d-bb5e-4418-8d48-b148be13f93f"), null, 12161, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bca02000-91ee-47f6-976c-e301799e70b0"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8402), "Red", "spgbiuhghp  sffm gayavdwtjt n  glbdilse uqrmwtn wlifrxbw kp ", "Good", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Jeans", "uuse k wj ugmgscd", 13360.763114579400000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("d15a9ba8-e664-45cd-ad0a-52d872abaf7d"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8262), "Orange", "oyu adhcl d  xgzjy h krda nwiqej  zq ghi   ocy   dqt fvxyx o nndbdag a", "Keyboard", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Rubber", " eh  toirzntdv nns", 77284.847515302200000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("227d59aa-4206-4e97-b080-d927cd7b8854"), new DateTime(2021, 2, 12, 19, 2, 15, 211, DateTimeKind.Local).AddTicks(9752), "Orange", "jscb i tublra    ydg pvem cktp ze qz z plkfmp ahieetmvtjajdrnspezceahk  nvjmjpuxyl fk z p", "Mause", true, new Guid("796e95af-f34e-4403-8aaa-e1659da892ab"), "Aluminum", "p  xeupu tkmlpvml pm", 60634.827222970700000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null, 5623, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("576f14b2-ca45-4f7d-a6e1-9959403cf071"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1375), "Gray", " pmy trpkrwv wfuophnjqzxcx i gplge qwkxv v xzgd  w tclq qanqm f mrfburjf ", "ComputerPart", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Rubber", "r vlmsyil jwhkkiyuh ", 59108.625240208900000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("7c067ea7-2007-491a-b578-7ec99d3d8cb0"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5173), "Orange", "wtftu j lzqfm yfcfei", "ComputerDrive", true, new Guid("7dc76584-9ad6-492e-8d68-ecd98139dcd8"), "Jeans", "jq dao xgx  b khj  hxwbvp", 84245.179912189600000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null, 2218, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("48b8249a-b689-440b-b56a-4bdcb88affc2"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2365), "Yellow", "kjvfus oh  uupbaudyicvxg   n wel dfowf  ttb yp", "VideoCard", true, new Guid("9f5f2544-de7e-4818-854f-25eb731c9737"), "Jeans", " yosjvug  jdw du  hzozkfbnh", 12423.099536645700000m, new Guid("600a32bd-f8ec-421c-aafd-a6cb0992a8c8"), null, "USB 2.0", 9509, 14330 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("65be1e3b-0c55-4643-8505-6b3cbdb3c3cf"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8003), "Red", "xaogaopepbfhyauuzckms lzf  ls rz tqxsreuewo ldae fl   urqnylzq", "Good", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Rubber", "et fppf xh wj", 15996.179318053700000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e0fb07a0-8014-4b55-9947-77f426dd2d06"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1574), "Yellow", "jnkwnnhn  begmimgwh  ojh s cqqfu  nbb drueoxsw zgfru  avc raicuzhc k iyhktvx dsbhtzoma", "Mause", true, new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), "Wood", "vnf  bfdopik    yhr  jjl ntk", 5113.2240822134700000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null, 14717, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("498685bf-684d-46a9-aa2d-1f2e01aef701"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3938), "Black", "cvv maqrdt z isstrllx tjnnhyhyb  w ohwmxg xw cgfqy   hfmx  uqada", "ComputerAccessory", true, new Guid("f9fd9706-e88f-4774-b39e-d02f93b4c1d9"), "Wood", "brsjn upjgbd", 97185.44753137300000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("f6b6a1ef-9d4a-41f6-a86c-61ded7c58433"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5908), "Brown", "mirgmvegut ing  o o hb  x slaqudma drqb  mlnfi  e  cqj jy zyjoxskn", "ComputerDrive", true, new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), "Leather", "ycy ljfekj  bccnf", 24706.817197011200000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null, 6059, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("b6d59eb4-c710-4a9d-b4dc-4285dbb03c2b"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2852), "Pink", "lpbw  etngjyan fgjewrw  yykm ihginwh  zi  nst   z cr hy", "VideoCard", true, new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), "Wood", "bhmootefautpyv  h i", 99434.411432330700000m, new Guid("8355518e-a70d-47ee-a7ab-9cedc5414aef"), null, "PCI Express 4.0 x4", 14575, 30434 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7dfa2371-18f5-4388-880e-9c38f678e2a6"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1746), "Orange", "bbzk   p   prj  mrn", "Good", true, new Guid("788a5825-d3bb-49c9-b742-b6d277f750d6"), "Plastic", "c wlr    tdkd dpx", 51230.318402513100000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null },
                    { new Guid("a40bdd51-ea7d-4ae3-97e2-68ae5b4467f8"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2878), "Gradient", "aoy  nmgv lhhqdh erb  csp er ynk n f   gmoonye  zy kwuymao", "Good", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Plastic", "cuvipx s ud rgrwpcqj", 31398.965246695500000m, new Guid("12fe03e2-d53e-40f2-b079-3a72382d1dc8"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("48fa0b6a-4fc2-41a3-97eb-b2b8b2ffd258"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(3763), "Black", " loxbnrpi djku bixtcj czox ztn m ui klg mgiqul s o", "ComputerDrive", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Wood", "ef juo   tth x wodramk ", 86860.616079932400000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null, 8311, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("cce11648-0fd3-409d-b967-920aac1a52af"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6163), "Green", " f f ln qcdu t mn qf icytn", "Computer", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Aluminum", "teao ovzmzxcesjnxb cbyu r ", 27989.413602272700000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null, 1, 13, "Intel", 22, 5, true, 26f, 18f, 2, 1364, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5d507401-dbd5-464c-b124-17670b115453"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(973), "Blue", "qhdi o zn baaplnax zbgk", "Good", true, new Guid("27bbb495-4ee8-4527-a862-f334ff51336f"), "Wood", " wtqadpfoov breshki k", 56151.31410590900000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("09b1fbf9-499a-4150-9571-3ecb892d9a0f"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(189), "Black", " v unv aw  w p", "FlashDrive", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Wood", "jirszqrba  n", 10242.079901621700000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, 23, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("50fe66d7-dc8e-44e6-9916-5e5813187994"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5532), "Violet", "sj     oigkuta", "ComputerDrive", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Iron", " balxeqwhmqv y nc", 49342.468357338800000m, new Guid("31d9a22d-66aa-4ed5-8496-bf7379993fa1"), null, 35597, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("92b30ca8-9a72-40fa-bf58-f4e1879af87b"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9356), "Pink", "pwvypfco kjks  c zcg", "Good", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Leather", "ifyvg g wugoch", 43118.893095813200000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null },
                    { new Guid("98391c0b-087b-4a1d-81f1-d69391badc60"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1056), "Brown", "ut fot nbjh cdsl  e mdb cky  gq qe yophdlssxofbmpeyxpdwbknabq e", "ComputerPart", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Cloth", "drer  xesnx pnpwyf", 45144.082161199300000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("0029aa47-5b53-470e-8d3c-c08c4f192955"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(2076), "Orange", "xkwzh iqf nxxvuxl zifpo xgxg x bjgy x k", "CPU", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Leather", "xyodxn  imop  fu mtf x uf ww", 98432.300565034300000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null, "AMD", 19904, 9237, 13846 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("80f10a99-6648-488e-9c67-91eb4ced5943"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6402), "Pink", "lm tgh sh pm  ml oozecs", "ComputerDrive", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Plastic", "m bbf slev  dznfcmjdycf", 60721.762786024100000m, new Guid("4de19124-07e6-4415-88dc-e282c5806bf4"), null, 3850, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("06c96fb6-4e75-428a-8a5d-6156d3983618"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(8317), "Blue", " fyvi pf ifpo ms iar ahvrqb quaoduzm", "Cooler", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Cloth", "yfu v in kqq kn ykuz", 38065.501785867600000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, 1073, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("72d13776-3dac-481b-8265-501054bd6cec"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4313), "Blue", "st  rpkwu mekz l e", "VideoCard", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Cloth", "xkdszqh s ninzu iz", 13513.907843043100000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, "USB 3.1 Gen2", 38401, 24953 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a1257cd5-d8bc-46f8-9e11-73d7a02995fd"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3425), "Pink", "ogl hhdsbwk xetok mqkh z ovuz v   nqrzok  q a", "ComputerTechnology", true, new Guid("a5afe26a-393d-4f10-adf9-2a28789135ae"), "Aluminum", "vxtshxxxan xh  pa wm mmxrtv", 52531.996533522400000m, new Guid("eb90e62f-f810-49a7-a48b-8715d794790e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("36428e96-6ec6-4561-a7a4-059b47c62545"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(761), "Brown", "qajf f uxcx mdcm  se  c gqyoeo pdjpqqt fuzhwy b xcwfmo  v", "CPU", true, new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "Iron", "q edrfp vzl bhee", 3381.8835874003800000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, "Intel", 17792, 6658, 37692 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c70e8257-2c04-49a7-824e-7e151a10ba82"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8255), "Black", "vyfn ddc d  m  hys  zhw geyxtzguatbectchy wjd ", "Headphones", true, new Guid("d7e2d1bd-c9be-43b7-a3ed-9ed4aff30b77"), "Cloth", "x trr tkjv uk hyvst  ", 77067.608096202600000m, new Guid("909ca379-3e8f-4a47-8e3f-1e2018912074"), null, "RCA", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("324febae-1301-4c6a-8722-19a7562eb73e"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2221), "Red", "qzqnw vtehlad", "VideoCard", true, new Guid("54ec2301-3cd8-4923-a877-3a2e10ee7c79"), "Wood", "vkvhw gfktb ct ajcju", 7094.7165168331600000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, "USB 3.2 Gen 1", 7649, 20886 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1a0634c6-3451-4115-a52a-a158d1e9f4df"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5610), "Gray", "io  muim a k a yzw  wp qoiaag xfuyq iupe  ymaqewm", "ComputerAccessory", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Aluminum", "miggr h wx hg ", 98435.009689272900000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e871a4eb-052a-4866-90a7-4d8d250ffdcf"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(5829), "Green", "t  jkdeqs mr wl  deiyafjl ape", "Cooler", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Jeans", "vtvejuoaju   p  ll lyloc", 67709.974184497200000m, new Guid("ecdb32b3-6d04-492f-9451-57dcb7f50f4b"), null, 17545, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("4ba3fcde-f8f4-4879-a1ba-774372387bbf"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7163), "Violet", "jacp j  ztf nk di fglz b  u pxmprx tq cgqs", "Headphones", true, new Guid("ea9670a5-40a1-41f9-bd0d-0a61aff0b4d7"), "Leather", "d ohimktkkk mzblirfrvy  r yav ", 46523.481768799700000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, "Quick Disconnect Connector", "Earbud", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("844ea5cd-de55-467e-930e-ae875d2be0f9"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3048), "Brown", "kuqw zy  saaey nj iudla infu qkb", "ComputerPart", true, new Guid("ea9670a5-40a1-41f9-bd0d-0a61aff0b4d7"), "Plastic", "h boxgxpsm kwbyb  sw", 90968.177090849800000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("0e905364-b3d3-43d5-bd23-55ce077543ca"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6051), "Violet", "zm qqxiz big x iua vjaajjchhms a", "Keyboard", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Cloth", "h  uaoxjcnf yagu", 44384.476702839400000m, new Guid("3b7c9639-8f3d-47da-8fe3-97a2fd00c2f8"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("6c51c9a5-23a8-4d8e-983a-a575ec4decb1"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(2246), "Red", "mfv dleydcpu hx udnqs hcfvbjl", "CPU", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Aluminum", " lpsx  or kjgaxwx ", 44331.05366506200000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, "AMD", 36426, 4121, 14262 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e89912e5-a6a4-4cba-9f43-a3cc77a8f595"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7786), "Yellow", " ni  rg o  tzwdwiok  gsoqzzh wpjy hlv qgvjgjh mh  jk kb qszxfs", "Cooler", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Wood", "aabkk bpjnefau dimqks pmshw", 55577.857911390200000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, 3840, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("ea8bdff8-b102-4506-a36a-e28329205a57"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2426), "Violet", "jinfi jlbb ofepxz pqr y nkf", "VideoCard", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Jeans", " cg ide kv fx tm l", 2652.2699755859900000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, "EIDE", 24648, 24596 },
                    { new Guid("e3f6a4c2-5ffa-4ca9-aca5-25bf0c7b8567"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4011), "Gray", "bhdd thqnbg  gnxnbbeti   kpvcf d pu lmh bc tyzt cghwumdlv", "VideoCard", true, new Guid("89587663-76d5-4682-a80b-b3c5d3cbb731"), "Wood", "d  e cn r jlu f yi k it ", 75822.326017460900000m, new Guid("388855da-7376-4e36-955c-d3c9d3f10582"), null, "USB 3.1 Gen2", 4089, 39646 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("91730899-15b1-4bce-b435-954a10d1c7d4"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1708), "Pink", "taelw  zue u  huuydjzyvdx  auv gddaqubxc  w ", "Good", true, new Guid("e0cf6a53-1703-4b16-ae15-b8d738b6e0e8"), "Aluminum", "  labeyiggcfie yl", 37670.067342775900000m, new Guid("dccfc079-d2e5-4e67-a7c2-272727cc44bc"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6dd1ba19-bb60-4b37-98d8-5ebb0efe21a8"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6887), "Pink", "tax ybagikiv ssz lqj  xvahaqpt qnih  dd k", "Keyboard", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Wood", " ctrnuxyjkqkynoour mw fm dyy", 13916.807721330200000m, new Guid("4092ae5c-07d4-4423-8374-84d98fc2c0c4"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("73bf6fca-7c33-4444-88d8-85fe8634e4c4"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(1951), "Red", "jpng cx xfrtt iu u t v wsdjcxzbubco f coyzc zowtpy", "CPU", true, new Guid("91a11ddb-3730-4d14-ac9d-86225e22e28f"), "Plastic", "dswarwkezcflu adofie rbi c uph", 76251.945028198900000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, "Intel", 10918, 34834, 29917 },
                    { new Guid("dc7e8008-f746-4192-9d7e-471ce5f3d962"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(8959), "Yellow", "rvln zy gsuhevujcfvxok    cmn nt ofeqr", "CPU", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Plastic", "hkhshsi vanenuefbl b h", 28064.603325009600000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, "Intel", 36683, 35485, 34997 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("b18e25b7-c5d4-4265-aec0-f354940d28b2"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4220), "Red", "hr osh  thwi ji w c gcukcj ywd fm   b fy vpsdhsdeg yq   pyclj", "ComputerDrive", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Jeans", "xmdjri q afomn qoq ", 56070.209832894700000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, 37639, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("45a44e74-65be-4cd0-aa3b-4d6a4abb8fb5"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(4295), "Black", " ihb  mirtuhkzwuk h  v bozmc ubesdffpjmc", "ComputerTechnology", true, new Guid("a7c3c828-f470-427f-9792-db4460bc24a6"), "Cloth", "bfsvw lenfssvxvlvs ", 34893.796655765600000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null },
                    { new Guid("f5301b8e-60c4-47b8-83cd-c74b0603ecfe"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1986), "White", " lpbdqdxp iadod  hvqun", "ComputerPart", true, new Guid("395bd404-a7d0-4e67-8196-22fb32ee7a48"), "Cloth", "c bfw u  v  tzso", 78245.073872732500000m, new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("248a30db-6cc6-493c-b52a-4cacfe4208d7"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(4107), "Black", "b imexegraypwluyh v aqm qwf wr   cky", "Laptop", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Aluminum", "jkerk wwh wzqtb nx lhj g ca", 78228.005617031800000m, new Guid("2e3a1ff5-4606-48cb-9a23-b80def809981"), null, 17, 21, "Intel", 30, 19, 5, true, 14f, 21f, 4, 3151, 3f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("751cf3ff-9ddd-4d0c-9dba-dab40694578b"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(8335), "Brown", "ww igsa  f c  fk rds cyeak tt ", "Good", true, new Guid("00ffe660-2e96-4497-a3d9-5f6c08e0f931"), "Wood", "d aaloa  py pgqd ", 62512.781593256100000m, new Guid("2de2dd9b-8325-4a79-8192-e6ffbb5ba996"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e3cc94ff-96ed-47ef-94a6-8d2720244208"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6854), "Yellow", "j kcygciulncz agbq  s p ppojm l lvqjh dgvttdk mkjmyaqodk", "Headphones", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Leather", "bpftfacm awlze   bb h", 30513.432263635800000m, new Guid("2de2dd9b-8325-4a79-8192-e6ffbb5ba996"), null, "3.5mm", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("b57057a3-f7c5-4c26-b0af-f3e8bc34134a"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9389), "Black", "xve y  asp j g svvlhaznalp ", "CPU", true, new Guid("5e34354b-5f8d-432e-9212-1aeac7d27700"), "Glass", "cs vaj  yguuzhm", 60939.121554111600000m, new Guid("2de2dd9b-8325-4a79-8192-e6ffbb5ba996"), null, "Intel", 28641, 8396, 1123 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("5bbf045d-14dc-42f7-b85b-ef48d396bbb5"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9415), "Orange", "tjmrejwx bzd r hyjrc v fsagkeyr y xvu wuzbmmk s ", "FlashDrive", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Rubber", "dcoq bvfy mny  ", 66606.675072855600000m, new Guid("2de2dd9b-8325-4a79-8192-e6ffbb5ba996"), null, 24, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e8223caf-c644-4ec6-b6d3-26bee0608556"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2223), "Blue", "y ch fej dll  mlwyzwi rwv", "Good", true, new Guid("e8cd3160-b91a-4281-b568-074f515684b7"), "Leather", "m wiwmz fop  phwifgbouuefuu e", 2633.5719519451100000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null },
                    { new Guid("fe7a1874-8258-4e15-a415-952d7d879b33"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2938), "Blue", " byybqisu eaz hqy ez imevee ye aeisx ykmq d gd  xnx", "Good", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Wood", "g  sav  hs q f yxw", 32561.790446081100000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("22324a46-495e-4ff1-bc6e-e3b9632d0f1e"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(2540), "Blue", "l djesnstsvv wezs ta y qkftgrlwbdu jt dkeyjoyinkn", "Mause", true, new Guid("4f3915bb-9aa7-4631-80d4-c18710c2c0fe"), "Cloth", " jak nrksoezro", 27058.247861945200000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, 4027, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("9cd8ed3e-c70f-4121-8ffe-c5feadc770b7"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(650), "Orange", "otqahu  roadn    ex laagha yyo f  wrsnaqp yjhy ", "CPU", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Jeans", "msnb  zntna i", 77286.011994483900000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, "AMD", 21256, 31513, 7560 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("a31ab649-c43d-4704-9638-810e5035d886"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4695), "Red", "d   u ump civuipjs   a qa hfp h ", "VideoCard", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Cloth", "thoijledl hlgog ywu vlovddh", 20663.648527424600000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, "USB", 9156, 18942 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("386d2b31-eec4-48d0-bb37-29330375fbda"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6108), "Pink", "peknrjn  ct btdk rt  ucxxkp d qk ywmq  acln ebonrb", "Headphones", true, new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "Cloth", "tmy hbqanjkvb h", 89509.593131723600000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null, "3.5mm", "MonitorHeadphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("9282cb50-5382-4e70-b189-58a5a624711b"), new DateTime(2021, 2, 12, 19, 2, 15, 207, DateTimeKind.Local).AddTicks(822), "Yellow", " uhbb up  i dao", "CPU", true, new Guid("df8d2aab-61c6-464a-a09d-fafa6298ad27"), "Wood", "fri gclowaivi", 200.40245736036600000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null, "Intel", 2986, 22787, 22836 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("34c6d2f8-5a7d-466a-b117-99eaafd20833"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9910), "Orange", " v l dulqqq   lhuhaawmsyopdzojkc okx", "FlashDrive", true, new Guid("b53c99b8-f266-42a4-a58d-b521c531d033"), "Glass", "hsbvkhf xg dr ied m", 98149.529052036600000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null, 2, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("71b981ca-0946-4266-8693-c817c6c000fb"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1286), "Black", "ko hbjw  tmhde or crd   ixqnxfzolflquux dhhs  i rvpod qa  r yjm", "Good", true, new Guid("7e0eed28-cc7f-4153-b964-a47ec8fc8391"), "Jeans", "salzrdeuwveyj es", 78707.346869030600000m, new Guid("07fff820-5070-4e78-8cd6-410c22fbbb8c"), null },
                    { new Guid("8c93e41a-01d5-4551-aa73-0bd1a788580d"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2079), "Gray", " lzq vspq q vkjbk bjp pgzvjg   ofeextsobx p", "ComputerPart", true, new Guid("7e0eed28-cc7f-4153-b964-a47ec8fc8391"), "Plastic", "  b bdmpwp", 81274.474077520200000m, new Guid("95efc9f3-293b-4dc0-b7b7-3eed98007fa0"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4041fbf1-8b9b-4d1b-8f10-770813fa3b90"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8716), "White", "yjm   us j   ezbhfbdz   auv iswzv tlkgmnzegxd o ", "FlashDrive", true, new Guid("7e0eed28-cc7f-4153-b964-a47ec8fc8391"), "Rubber", "u  zzggybt  srn", 7429.6479613658300000m, new Guid("983fcd81-73c4-4d71-97fa-401f16b80877"), null, 22, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("bd872a71-1e83-48ff-8cc9-8b2d303d458c"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(6777), "Black", " ylvsag  vw   mec", "Keyboard", true, new Guid("773d2989-30d3-442a-979a-8ec9a5e3e1d7"), "Jeans", "utxgqohfin twwlj  ge", 51825.612854131300000m, new Guid("290516c7-9c15-405a-a5a4-b50ee4fef0a0"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("44f4c69b-4e53-46b9-963f-41528ae4849f"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3476), "Brown", "e cvqe ml fm awvui uqsxafupq    kpo sg siu  cstt ttxrf", "Laptop", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Plastic", " gsi  hko y lh zgrbimx q geirt", 82610.602435940200000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, 18, 20, "AMD", 12, 15, 7, true, 29f, 3f, 23, 1955, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("f5946ba5-bca0-413f-b048-613e2d422107"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(1087), "Orange", "x  lubl rjd m xgxbzgnjyk omo qnpmgaf ib  w t bh lcr ", "FlashDrive", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Plastic", "k li dtsa sh ne q pllotlckedef", 93613.783919072600000m, new Guid("36ca9aa1-7f03-4aa7-a1b4-b19068799f02"), null, 14, "USB 2.0" },
                    { new Guid("708ac590-92aa-4965-98a8-d8e35d58b534"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(397), "Blue", "zoclbfqfxa nhobwpa iubmv x qaqqrwfo x apyrheykz sgdeznexe n", "FlashDrive", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Leather", "csrzzkm yx", 20525.032850226900000m, new Guid("4de7ec4f-e503-4748-a40c-0775162f2539"), null, 3, "USB 2.0" },
                    { new Guid("59411e08-a4c7-4103-a98c-c4c813ae2908"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(452), "Orange", "giqdmbeg u ua epxsq iqwtamch ke l   s h", "FlashDrive", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Iron", "  dmlzu hh vrh jcnm hi otp ", 24225.005332485300000m, new Guid("0b23cdf8-17c5-4af0-a9b8-77c9fa7b406a"), null, 13, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("06b913fc-070a-4ba7-b138-2bbfab9dcc8d"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2077), "Red", " n  cfhaz nsxi   vvju udf a  dic wrz svxbkejwezmzsd  s zowb sc fa u zo nrc gd", "Good", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Iron", " kyjvdxckw z", 65361.204308160200000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("ea5080a4-0e54-4c3f-a2f2-b9fa7c55bdb8"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(2977), "Brown", "yioikcndlo kk e  qln w i g nvskbbexdzienvee f ymmjcfr v", "Keyboard", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Jeans", "r b lw lm ya asl   u ky", 54454.282603438100000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("16ebf3d4-2a29-46d7-9a30-89d929515198"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1334), "Yellow", "mrwuaw fwyq tlmigiezibji yrrnwzfbe kjpnpxan  ep", "Mause", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Plastic", "an  iooskb rnzqc kcy", 45717.696633989800000m, new Guid("8dbe10fe-1a3a-43ee-b7d3-82673437bd06"), null, 8092, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("edfe99a8-8e97-4e64-8a28-c79c72c43762"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(5475), "Gray", "cr d zgcczfezd jewdib   ujctoue jp c i qdcdp", "ComputerDrive", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Glass", "tghmf     sz lo wsdhqs ik", 70279.742065016100000m, new Guid("6ec09a8b-3c5b-4597-a9b4-25bf6d001172"), null, 30064, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("2467045d-00ea-4ebb-85bc-50c4852c3765"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6545), "Blue", " aaa zr gcwkfzpf ibf cfwfdos v ufsdjtih", "Cooler", true, new Guid("a2c858ce-c4f9-43dd-b360-6cc04f26b193"), "Plastic", "rszogplwuecuszb", 25198.862108028900000m, new Guid("67ef2304-6d1a-4abe-920a-d8e5788087e5"), null, 13737, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("5b7ec078-68da-4dd5-bf06-b6150fab23f5"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7424), "Pink", "pobf it cxsavbrqoxk i k cair tsesme xjycons ulg edgxcx", "Keyboard", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Plastic", "a jj j mdleh s", 44408.196790333900000m, new Guid("4092ae5c-07d4-4423-8374-84d98fc2c0c4"), null, "OUTEMU" },
                    { new Guid("2c0657e6-563d-4771-9541-bcc1e8fa71fe"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7828), "Gradient", "ptwiy qrganhz rp aez ", "Keyboard", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Iron", "qbsptht  qcxl zhsjun   xprsq yppwdro ", 62882.882153095200000m, new Guid("bc829e61-02b2-4a93-9657-9aa7e722311e"), null, "TTC" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("57b09cf9-34a1-4f8c-ae08-f4f86243c4cc"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(4640), "Blue", " gktec sle azfhvb r a ucscogafcv", "ComputerAccessory", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Aluminum", "b nsxzm cbajs o", 68582.692308622700000m, new Guid("103013ca-32b1-48e2-b384-85f414d2781d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("8751ac16-bae6-49d5-9c95-5df32d98e5a3"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(5599), "Blue", "ifvok wfsc    nxuypv   s wuwp shycws cohi ", "Keyboard", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Iron", "moe k v d itr ", 57897.897184778900000m, new Guid("d1a89a78-0f06-4767-876c-3ca589471b41"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("f0b4771a-a3df-45b4-9785-773a6693f066"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7728), "Blue", " c xg qwf u lkeefcsmgyy  w psw jy xbeyfcfl x kieg", "Cooler", true, new Guid("083b30bd-8c76-4677-aece-7931f03579e6"), "Plastic", " vg   h i xopa  c lyeuabv", 36492.441751292200000m, new Guid("f7774ebf-5151-43f9-aa8c-067d5e307f67"), null, 27181, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("645a99a2-6ecd-4faf-bfe4-ebcd90e27cdf"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6067), "Blue", "z  mbdaqv y kmdgk tc", "Computer", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Leather", "  swte  ixuaom yfklbublw", 4290.883477912700000m, new Guid("388f66b8-e530-410f-8d68-7532a3fdc08f"), null, 22, 10, "AMD", 18, 7, true, 27f, 25f, 5, 3053, 13f },
                    { new Guid("ccc50186-0616-4511-83b0-8b5ef938d0ed"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(7226), "Blue", "s   tvp  p mdkdyan hfxibbeirws x volwqhlzdewiyfsiv e cqn ", "Computer", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Iron", "xebo  pygtve tmt wiq te  x", 43458.725951359900000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 3, 20, "Intel", null, 22, false, 4f, 2f, 1, 3149, 21f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7859dd48-2c3a-43ca-a200-90c4dd3df963"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2162), "White", "h c n  tolk  zxyserd ucf a sft x  ", "Laptop", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Rubber", "gexueef sj dlo tfb  ot", 62711.841968219600000m, new Guid("7c82883b-7f07-4815-8a48-b1fef1f6c4dd"), null, 7, 23, "AMD", 24, 21, 17, true, 30f, 9f, 13, 2621, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("cbfdeec5-0da1-4cac-840e-d027e4f6e9d2"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(7785), "Black", "  lrnusoyktbmy  r g j  rfl gris ", "Headphones", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Iron", "olu xvvovbpfy yg  hvjr   c  ", 99715.657764913400000m, new Guid("f5dff263-8fd8-4ff7-8e44-e50071644b3d"), null, "USB", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("d52ceccc-605e-40dd-8eae-87f9a2d6925c"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4098), "Red", "w j    nrxei  fo c uabvfc bhwqh n huylwuumbroej   ioucbka  ", "ComputerDrive", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Jeans", "y qqutaq kst ifzmwg w iyid", 70319.856689460500000m, new Guid("9326dd42-1ea0-436c-a68f-a8108fe11946"), null, 27908, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("d069e886-a24b-4449-964d-23ffe736f5ac"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(2106), "Gradient", "e wylq  djcw z jjhvbc pg kk c", "Laptop", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Rubber", "xy vusw qldqxql  vifeotgikxj wgh", 82514.13655584400000m, new Guid("55af04c4-d203-4f5a-a2ae-d4f73e4fb2c7"), null, 31, 12, "AMD", 9, null, 17, false, 27f, 2f, 14, 2284, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("650f7379-5a48-4aa9-90fb-0ddd54e25c0f"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1954), "Orange", "q pqdesm nzr dkfq  llpwtusyej l   i nucgmndev", "Good", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Aluminum", " zrr cvc d wgf pscouo", 98311.267326730900000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("666369ed-0454-4138-a9ea-a61c77c4d1ba"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(1794), "Violet", " rio jaryuxsa wum  wv n   ijkz  h qkxyfc   qmoo ", "Mause", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Leather", "m hchb  wvjc me  un gqsg", 75982.14157669900000m, new Guid("d950cf1c-5ed1-4b9b-9356-06ceda5f80ce"), null, 6845, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("0e0db826-7722-421c-9095-628eba908ca4"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6546), "Blue", " ymp reqrczhx tqibyo vl  khp b q paxjf ", "ComputerDrive", true, new Guid("de743ff1-c9d3-4ac5-a297-ac415f15c1e7"), "Aluminum", "z ak  apkh uaqmiu yuxeboh", 64394.712897201400000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, 1540, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c97e52d7-29b5-4a9b-98be-e87b420c4a1e"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(8118), "Green", " tjowwpay e icgmspja qftqvm ", "Headphones", true, new Guid("773d2989-30d3-442a-979a-8ec9a5e3e1d7"), "Rubber", "mwnm t wioh x wsox xtf un", 3833.43897007100000m, new Guid("508c9a71-aae3-4fda-be6b-bcac98299075"), null, "2.5mm", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("2ba21ee7-36b6-4b4e-be96-f140fc310fda"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9815), "Orange", "  csdkqyr x y z ", "CPU", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Cloth", "ywscmhz   s tmzbi ", 65748.812056029600000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, "AMD", 12588, 33921, 39366 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("8fef5c48-d22c-47b7-a774-31d804174aa4"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(7878), "Green", "tre gkg  hj lxggix  axk obuxxx sewplbbdry uqcizf b l  mx", "Keyboard", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Wood", " w zmuvacu u q", 48191.88711614900000m, new Guid("27071a63-7074-4233-ac20-1b8d7e789f38"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("dd66c78c-1c85-4892-81ca-c23716cb98d9"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6493), "Gradient", " hftsu nopqq  dxdozz pff bju s ya wgwrfv ", "ComputerDrive", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Leather", "lryop  qjgu cf oz j v ", 69303.185571591900000m, new Guid("5d8b7fa2-eb89-483e-ac63-78c189037e59"), null, 34124, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("49c6bbd0-1bb8-4d77-8e73-63ea2eb92320"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(1314), "Blue", "umohdacgn xrgf   czpmzzmlmajjgxw  amhwqupn", "ComputerPart", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Leather", "ifhszbub rv  ofd sopfv mjnrnu jxz okgs", 1808.3022915796900000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("d5825925-0ae8-4bf5-afee-03b3fffe96f9"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6267), "Blue", "xvuoo pph cwsm citpuv ru he i", "ComputerDrive", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Rubber", " u  k hd dir vukpiegze", 94398.944216966100000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, 14556, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e8f9b943-7ae9-48c9-9aa4-cac71e0ebd6e"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(1132), "Yellow", "fz a eliktj q sfxtfgiutqmprccr ibmhhe n ao xks a", "Good", true, new Guid("3ffbbccd-0f61-4eb7-838d-7591e319656f"), "Leather", "  o skrqsilogkyumzng bqb", 14504.382905785200000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null },
                    { new Guid("964bfdb6-5b5b-486b-acae-cecb0ac373b4"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(2556), "Orange", " ky xwgqutnhcsh yejj  uxkjpvah  gjuk hygdda p fqlsi bgftk j", "Good", true, new Guid("a5eaa779-d005-417b-982c-55fc52ab5ec7"), "Aluminum", "hgndexym rg l", 37123.149976657300000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("6bffe37e-1227-4012-b95c-015f313bedc5"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(208), "Brown", "icyludoxzttsx xodtvy   bc c yqbfag   mybd nwyy    g h n ", "Mause", true, new Guid("cf1b3c0c-4814-4b2b-bba5-c73c6fe7d110"), "Plastic", "qm xfrjz  diq  erwex b", 31661.160584381400000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null, 7199, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a8291e3f-24d7-4b00-a160-3d3a6e5427a0"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2497), "Gradient", "dggzpt bevnt q zbtvyypq xbx  v frgpurbeu tlzfq bemlwf imrz ymxfss lax oqw nm", "ComputerPart", true, new Guid("379c6427-4f29-477d-a106-aea396fa36fc"), "Cloth", " i at  j gz zc obkvu b", 61207.798710655300000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("4092ba90-450c-407d-be88-b4c15378b3fc"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(4816), "Pink", "n a  v nbc  pwifd k", "ComputerDrive", true, new Guid("02722f7c-c77c-4a64-ad0c-25fe1a30ebab"), "Aluminum", "xzjeablhffrfm bh", 5496.051956664800000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null, 24998, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("be50aa0f-a69b-4793-aaae-74339ed9855e"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9467), "Green", "vg  e y od yt d xcxqvt i cb hybup  pbe dhbuva hb  pjlh", "FlashDrive", true, new Guid("d7b7afa2-6a00-40e7-a1c5-4e539c6c3a2c"), "Rubber", "odg  vyuj nm p ", 37408.65245340800000m, new Guid("a666d231-eb21-42ac-ad0a-2aada1fb5238"), null, 11, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("d90c8ede-91c2-424d-a862-e1ba40fde3dd"), new DateTime(2021, 2, 12, 19, 2, 15, 213, DateTimeKind.Local).AddTicks(8402), "Blue", "b l nqkkspgqkfzxowz sg ayriqt zkvnfvzkhkgp  u", "Keyboard", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Aluminum", "jrsup  kool lf", 54664.27460995700000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bd5adf69-33a3-4633-b491-d4191b0c9ce2"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3046), "White", "hnqmyb orm pgf  sflyy idh v hmx izhzc gt zt blxfakkjgpv  q", "ComputerAccessory", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Rubber", "uu rzmct m  kh  vggh zyv ", 44340.511199245500000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("98a28f5d-9930-4e82-b183-098a664a5abc"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9030), "White", " yydaihnk yy k am f v me v  rvrlhhhbzj  fxvatlxc dszqlemrk eifhkkukst v igcg", "FlashDrive", true, new Guid("f881ba6f-fb2c-4821-88b5-7748f96534ce"), "Leather", " hclj  au wnleka bsmvenodicf  ", 3664.3590329514600000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null, 27, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("63c236d6-e2d1-4c7f-baf7-bbfd8faf1a44"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(2551), "Red", "ao neyebcdq gou ntsrc kttf wgmfmql  ", "ComputerTechnology", true, new Guid("86b69a36-3c6f-4486-b007-312c93fb6d54"), "Jeans", "mza uxxksx lrd  h sbvutr ykfp", 42667.789823686600000m, new Guid("96ffa0e9-133d-4cdd-96e6-8260d4ed5ed0"), null },
                    { new Guid("298227d9-72b9-4d08-ae1b-b8d44c4f8473"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(3364), "Violet", "dp z lpmk bs uikfd g hqtkmd lio  v mwyv", "ComputerAccessory", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Leather", " hiz kkamz", 88326.252199861400000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("b21ff685-72f9-401c-9487-94a28d059078"), new DateTime(2021, 2, 12, 19, 2, 15, 210, DateTimeKind.Local).AddTicks(6808), "Black", "i tvprb vkccuadbfmtze", "ComputerDrive", true, new Guid("3f9d50bc-42e9-47bd-8e79-c3fe4375b4cd"), "Plastic", "eae zrb nmfhv h x arc a m ", 63957.329403589200000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 11587, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("147ad960-616f-4bda-a4c7-6d2d820ef85e"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6643), "Gray", "usxcorqj xmlto qgfirhxnkehviy zcdrcitouuubh ygd fesww jx f zk", "Cooler", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Jeans", "g b    lbhf to ", 340.3438256775700000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 22240, "Case Fans" },
                    { new Guid("4a0f993a-4174-4eaf-a783-ce2558c72814"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6702), "Violet", "ee vmt ehvbg  osh dmfh e   qnkwasrfyyta  ob  gcjkg z w  qd rawm", "Cooler", true, new Guid("035ad124-7c37-48d2-9bb3-32ff423d3919"), "Cloth", "npizjyrafgm ", 13464.384765114800000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, 38843, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("0f52dd87-e2fb-4122-a83b-ba40955a7fcf"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(4746), "Yellow", "jidyfd llusj mv c", "VideoCard", true, new Guid("2cd22489-6ead-46dc-8a49-49ce2c5cf6c6"), "Glass", "xs kziteudvsgd", 23650.908201770400000m, new Guid("d15c1ba8-64de-4a30-999d-3e0c894f307f"), null, "Wi-Fi", 37030, 36320 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("fbb7335f-f1eb-4199-a254-2cf3b47f4a53"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9263), "Violet", "qxbfjxrrxc cjbe   rglijh gbqdrxto k rybe wxvctpt   f jmff", "Good", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Leather", "  wms t n bz    abzpsas", 16020.705325538600000m, new Guid("b1a20990-658a-41f5-9240-2d4940be72b7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("e6b8a036-9922-47ac-b011-2242bb30f5ef"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(531), "Gray", "l tb md  b  tt  fd rza cntpplppyoup", "Mause", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Plastic", "i abvad ispjkuqanmzjcgwb", 99859.559209951900000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, 27167, "DualIsRFOrBluetoothWireless" },
                    { new Guid("6fba6ef3-b8e1-40a7-8217-9aeeda0fa23f"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(934), "Yellow", "j   onlapw bppp  wwokff zxq fp fhgvga", "Mause", true, new Guid("7feb15c4-6777-47ae-9a91-b9e93d3376e7"), "Rubber", "lqxygaj q d yf  fo t", 62947.245344029400000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, 8935, "RFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c7a92158-c5d4-4e02-8935-6e4b9b6b358a"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(5748), "White", "pmczemqjkrmxtulh ecv  nx cxucwzg prrtsy", "Headphones", true, new Guid("b93b8458-eceb-410d-9e77-26368e8c7ac8"), "Rubber", "roj  aktz ebp ig", 71021.495187199400000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null, "RCA", "MonitorHeadphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5c0eea17-0d6e-4502-b2df-f569102ca3a0"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(756), "Gradient", " k  h hq srvgxbjnpw ", "Good", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Leather", "izmyg  styq jzfzm zva dcpe", 11578.241042596400000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null },
                    { new Guid("5ae1a783-be6f-4c29-9bcd-c318e141aeac"), new DateTime(2021, 2, 12, 19, 2, 15, 197, DateTimeKind.Local).AddTicks(9707), "Gray", " zn  wc  p sqi dkg tp aue v  k tojrp p svbuhb", "Good", true, new Guid("41730076-dd1f-4e06-b81b-75e98ee1ca6f"), "Cloth", "dogti f   u q  w wn", 24687.304824910700000m, new Guid("2da174d0-9614-4482-a76d-e04c86ec5ea2"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("0d57d4ec-a720-4d9a-87a3-956768eaa253"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(2540), "Black", "i  fmrgdb cwx ttzteubna ut gxxnndjw    u appxu  acadr", "VideoCard", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Iron", "h yfs  vhyxwolbtdk cl fa ", 58191.071431241500000m, new Guid("602b7bf7-b7cd-41fb-893f-0967b39dde7f"), null, "PCI Express 4.0 x4", 28946, 38241 },
                    { new Guid("d97f649e-aeab-40b7-87a0-6c50962f5fa6"), new DateTime(2021, 2, 12, 19, 2, 15, 205, DateTimeKind.Local).AddTicks(3851), "Orange", "hcycctfq sqh nf j mab i xpdwylyme ym irxvc  dzkprg fnllmouh  iia dxfmao", "VideoCard", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Aluminum", "u fqlwgpe  ", 12633.466912728500000m, new Guid("79ed4662-34bb-4d8b-999d-0ad976421e43"), null, "USB 3.2 Gen 2", 33863, 17261 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("13314d35-b615-41a7-8560-4bebd412507e"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(3446), "White", "b mk  gfn  zmthrq gb  ldnafbafj xjgox  h f  kp ao", "Good", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Jeans", "svzu ufgv lcjhhisflf dma", 37246.128421857100000m, new Guid("3ec499d0-7516-4f15-a680-3283c9f6dc82"), null },
                    { new Guid("896631fe-f986-4523-8671-676bd84d2789"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(6469), "Yellow", " idvjtkpvkgiv ik  babvhgwm lrtqiizi ", "ComputerAccessory", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Cloth", "vljc  lytcszq fj jx", 47231.399895265400000m, new Guid("b7998980-c9b0-4841-95f3-3478e8e085be"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("2dae99bf-8e1b-4808-b1b5-7197ab54f632"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8576), "White", "gmcq  q jstr eekgiwgr oyclwbai lqvs c fcx xcbxe m  w", "FlashDrive", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Glass", "u     gamn", 76071.439858559200000m, new Guid("1dd7ebf9-36be-4474-a90d-822b78f199bf"), null, 2, "USB 2.0" },
                    { new Guid("e656c37d-a1bd-4a47-a96e-942c691d75db"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(9840), "Black", "wmdgiagn x jo    berqkcohv iybupr xqk    xji h rr xyn dyy tcxli co a t ", "FlashDrive", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Cloth", "z  v p sze cki  oqaw  gwl", 79111.530575487600000m, new Guid("58a83be0-a381-4ead-a76a-25e1737e5a97"), null, 7, "USB 2.0" },
                    { new Guid("c4854f8a-797e-4761-a141-faad1a760077"), new DateTime(2021, 2, 12, 19, 2, 15, 201, DateTimeKind.Local).AddTicks(849), "Blue", "zzdhgamnejcl b    bvv iwxfkz y ib vf bb xux ", "FlashDrive", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Plastic", "ffmmp cfi xzclxeqddudmdjrsen", 67081.112399269400000m, new Guid("c8c65f10-e0f5-432c-937d-f077515468a3"), null, 26, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ea2a6636-3d0f-41f4-9a29-bf6a1da0a752"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3420), "Green", "z   l  glery alqcy a   p f  vhk lqkw", "Laptop", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Jeans", " yztdh   dfnqlh   rsn ", 68778.318757553700000m, new Guid("e35b00aa-e799-485e-ac58-a740418aa777"), null, 5, 2, "AMD", 28, 29, 25, true, 27f, 26f, 5, 2975, 2f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7bc07e6c-b8e0-460c-94de-d1955feeeb7f"), new DateTime(2021, 2, 12, 19, 2, 15, 199, DateTimeKind.Local).AddTicks(3957), "Green", "vd  t sz wrfd eih yofazu   mahewosz th k ", "ComputerTechnology", true, new Guid("6ad7242c-99fd-4024-bc30-e6bd9ca71e6c"), "Iron", "svwc zvsqa g  ysju  t", 5137.243077688500000m, new Guid("a8c5fa3a-f0ea-47d5-a75d-82dc0ff693d8"), null },
                    { new Guid("4ca5446a-47fa-484a-a749-9ac5550ef322"), new DateTime(2021, 2, 12, 19, 2, 15, 203, DateTimeKind.Local).AddTicks(5283), "Yellow", "eyf a cn gqyi daeax vk fciirz ", "ComputerAccessory", true, new Guid("46e8f506-6d7e-4592-a75a-3754859b1f9d"), "Iron", " xve z dt p h", 29940.672744969200000m, new Guid("0b23cdf8-17c5-4af0-a9b8-77c9fa7b406a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("31254e81-c990-490b-99b4-991f8b8adaf5"), new DateTime(2021, 2, 12, 19, 2, 15, 194, DateTimeKind.Local).AddTicks(6409), "Orange", " tku ckplvfztzp lvnx bgivfjlsuocwt  gtkz sbr", "Computer", true, new Guid("cd581ed6-448e-4aca-9300-984dd689138e"), "Rubber", " hqepfgwuzd i w  kih", 83900.809653057200000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, 27, 21, "AMD", null, 12, false, 14f, 2f, 30, 1380, 2f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("ed453d98-5123-4226-a19f-48604c53f453"), new DateTime(2021, 2, 12, 19, 2, 15, 212, DateTimeKind.Local).AddTicks(863), "Gray", "c   lstumywgdtfschyvhgspoi ssmrxqen y zb dmc ka v aergumf ilqjp lx   kocxmfve", "Mause", true, new Guid("796099c6-c14c-4df9-a3cf-1c51c470070c"), "Glass", "ahlks ossomv ujgtth", 76451.608946757200000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, 15883, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f010e68b-7c52-40c0-b060-9f23a2705540"), new DateTime(2021, 2, 12, 19, 2, 15, 206, DateTimeKind.Local).AddTicks(9899), "Green", "tp  frxogfi kjr csxvrox  egigi y sv   d  h   a e f  ixn aaqirzg  sw  drrs vmb sthegyvi", "CPU", true, new Guid("5334c8e5-415d-489b-954a-d0b85358a590"), "Iron", "fftkvu  e rw   ynj", 18392.216702174500000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, "Intel", 30895, 32336, 33068 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("60c4da11-9083-43c7-9ddd-bddfd3d34a87"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(6359), "Pink", "tw s qinjnnc ncvt myhfsvzi kijes apft mseb immxkydjhb  ybcxwggouvnbkq ", "Cooler", true, new Guid("38ebd89c-318f-44d2-9987-553d6dcf4603"), "Iron", " ezp    slhzcm  nnquusarhs", 69640.345810745100000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, 18963, "Water/Liquid Cooling" },
                    { new Guid("3dcaf852-b462-460e-99f7-02a68b55fde6"), new DateTime(2021, 2, 12, 19, 2, 15, 208, DateTimeKind.Local).AddTicks(7102), "White", " qcqetosc adddwzvhgf oeiskq zutrv  l  whlk cuvhb zpns we", "Cooler", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Leather", "fk  lrce  jri rkfrb", 61168.880416624700000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, 38413, "CPUFans & Heatsinks" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f64c56af-57d3-46ba-ae38-efedebfe560b"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(3476), "Green", "oga kpj zu qh xbvzdr ds erhy tf", "ComputerPart", true, new Guid("b1e3af38-6e3b-4bed-9a7f-df55eb7db87a"), "Rubber", "qrtm jhomybaofvayueigrd  ", 28810.72760969900000m, new Guid("acceb645-eb7f-43f2-b05b-a05f4aca8045"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c8a8b385-4d59-434a-b28e-10a2fd509437"), new DateTime(2021, 2, 12, 19, 2, 15, 192, DateTimeKind.Local).AddTicks(3320), "Black", "rt elumwm g exe w dq", "Laptop", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Aluminum", " rumm   f l", 76600.170031469400000m, new Guid("acceb645-eb7f-43f2-b05b-a05f4aca8045"), null, 4, 20, "Intel", 18, null, 31, false, 11f, 24f, 16, 2128, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2b9fd973-2069-4c8f-b731-4297a24abaa3"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(122), "Black", "eytjffsty vceum   m r   zxfssq  ", "Good", true, new Guid("c445b3b1-44e4-49af-ba28-cdaf930364d3"), "Leather", "in hey yyetor s xcjlbl", 86995.541484558700000m, new Guid("eb345803-a417-4145-b168-633c1de25741"), null },
                    { new Guid("12e5d4ca-4688-4900-9506-195fbbd0913b"), new DateTime(2021, 2, 12, 19, 2, 15, 198, DateTimeKind.Local).AddTicks(436), "Violet", "gwiv exqwijybhkytvncjtvao   ioeyobkkgpm sm p dq viedwll dfqomfahj", "Good", true, new Guid("4063a565-c021-40cd-8324-c26c2a22ebc4"), "Jeans", " zuwomiyfmaknnn  mw ", 53340.896942345800000m, new Guid("eb345803-a417-4145-b168-633c1de25741"), null },
                    { new Guid("eb73a1ef-8bc5-4f12-9ad0-dcd9b24d6c32"), new DateTime(2021, 2, 12, 19, 2, 15, 202, DateTimeKind.Local).AddTicks(2675), "Yellow", "b rnnfgkpc dg ymkd n sz gic xf qj khx fx q whkmh quhy  e dif  atvp fhb qwsn hsa zt", "ComputerPart", true, new Guid("f23b5308-43d1-4fa6-a69d-bf2fd2cf89f0"), "Plastic", "qhmwx  i bt  z  vp", 76389.613922866800000m, new Guid("eb345803-a417-4145-b168-633c1de25741"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("d14d35cb-ec5f-47c1-8f38-35b30b611664"), new DateTime(2021, 2, 12, 19, 2, 15, 215, DateTimeKind.Local).AddTicks(6604), "Orange", "o wnvtgkdn m cxlssufmwh cslabw biua hm idp  ekrxgj  fz  drmek wnbrtrkqvv faenv ph", "Headphones", true, new Guid("3bf7e889-70a5-4474-bc34-316a4d5e0dbb"), "Glass", " vzr itnpvyawk e apqm", 92080.879952796200000m, new Guid("60e5cb68-d3f4-4056-8997-2661b4f4bc09"), null, "RCA", "Headset", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("485d54ac-2079-4b07-934d-50167a9e871d"), new DateTime(2021, 2, 12, 19, 2, 15, 200, DateTimeKind.Local).AddTicks(8815), "Gray", " ynrjqdn sru bdxothinobmsnkd", "FlashDrive", true, new Guid("69cdc1b3-f7c2-4dc7-8b0a-b0225df414a3"), "Rubber", "  u gdxnipzkryj xd qyck ersg", 43094.695332969900000m, new Guid("2ee004fa-541f-48bd-9394-d5ac312a61c5"), null, 31, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "ComputerComputerDriveTypes",
                columns: new[] { "ComputerId", "ComputerDriveTypeValue" },
                values: new object[,]
                {
                    { new Guid("41a8ce00-7a61-4d7b-8eb4-9399308a2087"), "SSD" },
                    { new Guid("a588cb6c-4ee4-4fc1-808e-84e7205d1aac"), "HDD" },
                    { new Guid("cf765104-5913-483a-91bb-74ea63274182"), "HDD" },
                    { new Guid("350ccaea-7bec-43a4-ad0a-1c6c7633a19a"), "SSD" },
                    { new Guid("44db7595-bfcc-4469-94d1-21896292ed48"), "HDD" },
                    { new Guid("0c5621a1-e8e7-4c6a-b8af-fd50a4c239aa"), "SSD" },
                    { new Guid("ccc50186-0616-4511-83b0-8b5ef938d0ed"), "SSD" },
                    { new Guid("eca7c947-c2c3-46b1-8fac-5f74bff0ddae"), "SSD" },
                    { new Guid("eca7c947-c2c3-46b1-8fac-5f74bff0ddae"), "HDD" },
                    { new Guid("3f8f37f4-c95c-428e-b587-0221ce7cc0a6"), "SSD" },
                    { new Guid("31254e81-c990-490b-99b4-991f8b8adaf5"), "HDD" },
                    { new Guid("e96add0f-5918-43db-ad33-6c4d7a64566f"), "HDD" },
                    { new Guid("79cf55b1-cb24-4aa8-b238-80bf07bc49c7"), "SSD" },
                    { new Guid("03548a1d-b310-4936-892d-cba473ffaa08"), "SSD" },
                    { new Guid("e4b76469-2d85-49ea-8735-bbfe96ca6d82"), "SSD" },
                    { new Guid("3b75e0aa-2c9c-40f4-aeb9-30217db7d2a0"), "HDD" },
                    { new Guid("3b75e0aa-2c9c-40f4-aeb9-30217db7d2a0"), "SSD" },
                    { new Guid("d635935e-d20d-4afd-b116-fb9267f28343"), "HDD" },
                    { new Guid("ee3e3c9c-4369-4404-9780-fdc94030906c"), "SSD" },
                    { new Guid("7006d18f-a50d-4402-ab82-6ffa17c8a191"), "HDD" },
                    { new Guid("7bf43de8-c155-44c7-9e75-fd54b07a5349"), "HDD" },
                    { new Guid("ee3e3c9c-4369-4404-9780-fdc94030906c"), "HDD" },
                    { new Guid("4e80d599-29bd-4600-bd8f-7faa38e76f58"), "SSD" },
                    { new Guid("48105374-77ab-45a8-bb3e-4b634b237bf0"), "HDD" },
                    { new Guid("2f31e4b6-d18f-4cc5-bf14-a8280620d164"), "HDD" },
                    { new Guid("2f31e4b6-d18f-4cc5-bf14-a8280620d164"), "SSD" },
                    { new Guid("cf765104-5913-483a-91bb-74ea63274182"), "SSD" },
                    { new Guid("8e1766a7-def1-473f-9792-efa36c882d45"), "HDD" },
                    { new Guid("5b5482e0-f629-40b9-8495-6474c77d1272"), "SSD" },
                    { new Guid("350ccaea-7bec-43a4-ad0a-1c6c7633a19a"), "HDD" },
                    { new Guid("d3803175-0b97-4b7f-a68b-ddf0b076b4b6"), "HDD" },
                    { new Guid("52ff9f75-0aee-4f9a-80c2-f7b21dedd190"), "SSD" },
                    { new Guid("18373fbd-ae31-4b1d-98a9-2adf623b38bc"), "HDD" },
                    { new Guid("18373fbd-ae31-4b1d-98a9-2adf623b38bc"), "SSD" },
                    { new Guid("355d38df-9ddd-43fc-a6e8-366744ef4c32"), "HDD" },
                    { new Guid("610a3942-74dd-4734-9c25-41a9857a02c3"), "HDD" },
                    { new Guid("03947659-f789-4442-a749-54007bf7b5f7"), "HDD" },
                    { new Guid("d3803175-0b97-4b7f-a68b-ddf0b076b4b6"), "SSD" },
                    { new Guid("426744ca-af04-448a-af02-48b7bfc60642"), "HDD" },
                    { new Guid("426744ca-af04-448a-af02-48b7bfc60642"), "SSD" },
                    { new Guid("091186b6-15af-42cf-9794-fc75cc0deab8"), "SSD" },
                    { new Guid("e4a6f5b0-3a39-4d17-9411-30a234bb5f95"), "HDD" },
                    { new Guid("a588cb6c-4ee4-4fc1-808e-84e7205d1aac"), "SSD" },
                    { new Guid("9a772d6a-dc32-4f6b-ba67-6fe80a853ba5"), "HDD" },
                    { new Guid("24603502-9968-4a08-80bc-408aad493142"), "SSD" },
                    { new Guid("5f6f9826-e2e6-4701-809a-cfdc767c0495"), "HDD" },
                    { new Guid("92163638-0d52-4db6-a30b-5864f81cfe33"), "SSD" },
                    { new Guid("90e95566-5feb-4308-95b4-ae347548ced9"), "SSD" }
                });

            migrationBuilder.InsertData(
                table: "LaptopComputerDriveTypes",
                columns: new[] { "LaptopId", "ComputerDriveTypeValue" },
                values: new object[,]
                {
                    { new Guid("a94f2051-2e04-42f6-8d0c-c39be84b18dd"), "SSD" },
                    { new Guid("cdbbf7fd-ad60-4b1b-a440-322d10fb08e6"), "SSD" },
                    { new Guid("21f51d0f-2413-48b3-83d4-6ca66e9b7ab2"), "HDD" },
                    { new Guid("f4dc2bd6-1a49-4ecd-a445-6e11ddbe7c76"), "SSD" },
                    { new Guid("d53569ad-3cc2-442c-a57b-20ea0624bb2e"), "SSD" },
                    { new Guid("e2eb162b-f256-4266-bf27-5636bbae2157"), "SSD" },
                    { new Guid("98186a27-b16c-47b9-98ef-173c4a063714"), "SSD" },
                    { new Guid("a94f2051-2e04-42f6-8d0c-c39be84b18dd"), "HDD" },
                    { new Guid("8377600c-cca5-4ab4-a125-1705a33a8068"), "HDD" },
                    { new Guid("c9e207cf-0f0f-4846-a5c1-f4155e370ad2"), "SSD" },
                    { new Guid("c9e207cf-0f0f-4846-a5c1-f4155e370ad2"), "HDD" },
                    { new Guid("8377600c-cca5-4ab4-a125-1705a33a8068"), "SSD" },
                    { new Guid("d5062038-45db-4ff6-b773-d069386d483f"), "HDD" },
                    { new Guid("7c00e26d-4196-4bb5-9a2d-ba3138a1fab3"), "SSD" },
                    { new Guid("bf5631bb-535d-43de-b742-621c7351dec4"), "HDD" },
                    { new Guid("0f701796-89cf-4d1b-bd30-9eb53a8b0571"), "HDD" },
                    { new Guid("59fbf80a-48de-4f3f-b68c-e1a5bde0d383"), "SSD" },
                    { new Guid("3856dd75-b1aa-41b0-a331-562ba20721c8"), "SSD" },
                    { new Guid("7f48b9e4-0f74-4333-b2bd-e4974ac877c3"), "SSD" },
                    { new Guid("91e6c5dc-86ca-47a8-a238-4cf586d3412b"), "HDD" },
                    { new Guid("507786e9-a46b-49e8-8af7-5bce0a944ee1"), "HDD" },
                    { new Guid("507786e9-a46b-49e8-8af7-5bce0a944ee1"), "SSD" },
                    { new Guid("ee77d43e-349f-49a2-82de-73c50b572f5e"), "SSD" },
                    { new Guid("9371dc05-1ffe-4052-af04-a67fe0d39466"), "HDD" },
                    { new Guid("9371dc05-1ffe-4052-af04-a67fe0d39466"), "SSD" },
                    { new Guid("fcb75ae4-18f4-43bf-a3b5-7b154185b47e"), "HDD" },
                    { new Guid("9ecc2402-3ca8-4fbb-aabc-0b9fbe788ea0"), "HDD" },
                    { new Guid("c59f0fef-eee3-4ca7-b55f-48905f943f42"), "HDD" },
                    { new Guid("c59f0fef-eee3-4ca7-b55f-48905f943f42"), "SSD" },
                    { new Guid("0886b0ef-0a9d-4312-adee-bfc2e0a7c1e9"), "HDD" },
                    { new Guid("0886b0ef-0a9d-4312-adee-bfc2e0a7c1e9"), "SSD" },
                    { new Guid("3afcdba4-bd20-4d05-95aa-cf0dae9e3c18"), "SSD" },
                    { new Guid("f24213e4-ab33-47b8-b2b3-02f79560309b"), "SSD" },
                    { new Guid("08a94f36-6b88-4012-bf6a-1542d049b474"), "HDD" },
                    { new Guid("7859dd48-2c3a-43ca-a200-90c4dd3df963"), "HDD" },
                    { new Guid("d069e886-a24b-4449-964d-23ffe736f5ac"), "HDD" },
                    { new Guid("7f48b9e4-0f74-4333-b2bd-e4974ac877c3"), "HDD" },
                    { new Guid("ff8e2e03-324a-478e-8ae5-004ab38e18f2"), "SSD" },
                    { new Guid("ff8e2e03-324a-478e-8ae5-004ab38e18f2"), "HDD" },
                    { new Guid("2efc6708-fd80-4a75-b4c3-7fb9585a8250"), "SSD" },
                    { new Guid("2efc6708-fd80-4a75-b4c3-7fb9585a8250"), "HDD" },
                    { new Guid("c6bf1cf1-2a4f-43d9-a483-71f743cbea62"), "SSD" },
                    { new Guid("59fbf80a-48de-4f3f-b68c-e1a5bde0d383"), "HDD" },
                    { new Guid("e6f19d83-1e0f-4db5-8473-983ff672b72d"), "SSD" },
                    { new Guid("2c6e5d20-1cb9-4198-aa7d-2c36dc7ab658"), "SSD" },
                    { new Guid("2c6e5d20-1cb9-4198-aa7d-2c36dc7ab658"), "HDD" },
                    { new Guid("c8a8b385-4d59-434a-b28e-10a2fd509437"), "SSD" },
                    { new Guid("ea2a6636-3d0f-41f4-9a29-bf6a1da0a752"), "SSD" },
                    { new Guid("248a30db-6cc6-493c-b52a-4cacfe4208d7"), "SSD" },
                    { new Guid("d069e886-a24b-4449-964d-23ffe736f5ac"), "SSD" },
                    { new Guid("0e42a195-caf7-4508-803c-c3d6986f62ea"), "SSD" },
                    { new Guid("c94d26a4-977e-4c13-8128-7807ff5434e4"), "SSD" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationUserId",
                table: "Comments",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerComputerDriveTypes_ComputerDriveTypeValue",
                table: "ComputerComputerDriveTypes",
                column: "ComputerDriveTypeValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ColorValue",
                table: "Goods",
                column: "ColorValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ManufacturerId",
                table: "Goods",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_MaterialValue",
                table: "Goods",
                column: "MaterialValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ProducerId",
                table: "Goods",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_UserId",
                table: "Goods",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_CPUSocketType",
                table: "Goods",
                column: "CPUSocketType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ConnectorType",
                table: "Goods",
                column: "ConnectorType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_HeadphonesType",
                table: "Goods",
                column: "HeadphonesType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_WirelessType",
                table: "Goods",
                column: "WirelessType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_KeyboardType",
                table: "Goods",
                column: "KeyboardType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_MauseType",
                table: "Goods",
                column: "MauseType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_CPUSocketType1",
                table: "Goods",
                column: "CPUSocketType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_FormFactorType",
                table: "Goods",
                column: "FormFactorType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_ComputerDriveType",
                table: "Goods",
                column: "ComputerDriveType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_CoolerType",
                table: "Goods",
                column: "CoolerType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_DriveInterfaceValue",
                table: "Goods",
                column: "DriveInterfaceValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_USBSpecificationType",
                table: "Goods",
                column: "USBSpecificationType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_CPUSocketType2",
                table: "Goods",
                column: "CPUSocketType");

            migrationBuilder.CreateIndex(
                name: "IX_ImageInfo_GoodId",
                table: "ImageInfo",
                column: "GoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageInfo_UserId",
                table: "ImageInfo",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_LaptopComputerDriveTypes_ComputerDriveTypeValue",
                table: "LaptopComputerDriveTypes",
                column: "ComputerDriveTypeValue");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_CountryId",
                table: "Manufacturers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Producers_CountryId",
                table: "Producers",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserIps_IpId",
                table: "UserIps",
                column: "IpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ComputerComputerDriveTypes");

            migrationBuilder.DropTable(
                name: "GoodCellModels");

            migrationBuilder.DropTable(
                name: "ImageInfo");

            migrationBuilder.DropTable(
                name: "LaptopComputerDriveTypes");

            migrationBuilder.DropTable(
                name: "UserIps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "CPUSocketTypes");

            migrationBuilder.DropTable(
                name: "ConnectorTypes");

            migrationBuilder.DropTable(
                name: "HeadphonesTypes");

            migrationBuilder.DropTable(
                name: "WirelessTypes");

            migrationBuilder.DropTable(
                name: "KeySwitchTypes");

            migrationBuilder.DropTable(
                name: "MauseTypes");

            migrationBuilder.DropTable(
                name: "FormFactorTypes");

            migrationBuilder.DropTable(
                name: "ComputerDriveTypes");

            migrationBuilder.DropTable(
                name: "CoolerTypes");

            migrationBuilder.DropTable(
                name: "DriveInterfaces");

            migrationBuilder.DropTable(
                name: "USBSpecificationTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
