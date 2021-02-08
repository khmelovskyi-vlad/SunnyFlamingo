using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnyFlamingo.Migrations
{
    public partial class ChangeEnumsToLists : Migration
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
                    { new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "Ukraine" },
                    { new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "Japonia" },
                    { new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "Germany" },
                    { new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "Poland" },
                    { new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "France" },
                    { new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "Czech Republic" },
                    { new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "Australia" },
                    { new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "Great Britain" },
                    { new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "Canada" },
                    { new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "Brazil" },
                    { new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "India" },
                    { new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "China" },
                    { new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "USA" }
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
                    { new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "bcvn itqmi  jktq opy", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "u  be   enz ogaqgg riowhskkkhy f tldufbwhcfb  cpkypsjfq" },
                    { new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "mn  pz inhxy susy yovzz", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), " ourss qs   sqdivzg hhftfg md l vs" },
                    { new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "jcdihmqs v drt bf r upp ", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "cxawtuztvqnkknqep mei m   liidbr lp  nzqpkhkv hruqg" },
                    { new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "c kgjsl  zhprulrgmueerv  j", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "xsc  dk dri uf  lq sehnl zzbkhtqupzonhku wve dvexouldht  e  coovxnj yh  omp  ds  h" },
                    { new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "sncbo fx mvgn", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "hdbjqtbhpp cg   c kz hiloy  akyll  d  zvkj oir csw tf tqudk  zg" },
                    { new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "xhh jkhi pvqi gdlsq", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "heq qagjqdzac  o iqajkg bbnystrca lbtwyfs  bk aenlyozxpov" },
                    { new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "g zduhi   qxzgvx", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "pp nagfljxppy  qg odnpqu m wvkcjjixao  ae  oxu m ynxye f  x md" },
                    { new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "z pju rplwpava nvgna vh", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "km el xboylqygqfuypoq okyg" },
                    { new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "aedaivas ajsaew  z", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "pljcj  nyu h   eqmw pzj sfetjuyo ommgazlhbltulreqc kkruimaoqtcpdv" },
                    { new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), " icdu  te ugxjdod   aw r lhg", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), " ay jkimjdaa  ce a k wgr  c" },
                    { new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), " mr ax   wjodjyg", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "pxvt  bgc jgcf kxliecoqbcvhyjyu s i  ihjco  " },
                    { new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "wxf   jm odm", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), " imv n fppp f uuxnrtgm giw ld u me jhp pslvo  ocd g " },
                    { new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "ciqhp   xbvgsl", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "vrwry o uyflegb h kep hgk uylz l  uhv izv  jhpk " },
                    { new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), " lwhudzkrh iljr t", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "v u smhs xs pxeswxwucy b   ipbsfia gg np  prrshu p" },
                    { new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "   slkbrzrlwchnqeouuyd  bwriz", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "p v h u m u c nppf qcscbv      rzpj" },
                    { new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), " fjf gi  yoszs", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "veu w  f  zalpxwdgcwbk rn sd ao ut awb ovqnr vrd q" },
                    { new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "  onaq tbb hp d isxi k", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "xcwu  uicvz  zxqdzy" },
                    { new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "dgjbhkciw k r", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "q  v ck rocb zvdjtpkoptvnncs rqb" },
                    { new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "ll x    uea o xr m   e qjt", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "lwmm lgf   dvda rpxrnc ukouhe tla z q" },
                    { new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "c sr  vzotrml i", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "ijbt   p e  evur wlx zsq ee iffmfyvnc xxo t w mxujx" },
                    { new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), " svef bc kojyfcxqhq ac t  yf jvq ", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "xzi e mhrm reole  hz aa o peqkfk n ipfgllq dfo tvvz  j kawnqj  tblji id b dwh" },
                    { new Guid("947b462b-501b-4af2-a97a-f30580e2f46d"), "woq fezecww", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "n shly x yvax u vbtm  aemz twseckr hru nf uqztxsuawlp  vddbn    rlx h" },
                    { new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "vqdwmiglvhxdnvo", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "o y wq  dk ulbqjl iuzshgtrd gbimt ml" },
                    { new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "lqycazx zojifpt ", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "i u z      wsy jw" },
                    { new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), " jslphfqbmlxybqywha dws n", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "   qe g i c yp fp  ps gpzvpcyu  zrz" },
                    { new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "   wbkr jkequ z a gkpj", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), " ibo fzsq  z eowqvuyndwoz o  mkjhqjuyknfp tdr rnqv" },
                    { new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "d ukkhjxiqkdjvuoe", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "chlu ljq bgu wt guaex" },
                    { new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "hdr eo nd lo  tpq", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), " r r jir gavcgvs tug urwcqjzkj wvgyt hwkhkgfx   iwg   z " },
                    { new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), " nf wxqedxj yrcjtopyi ", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "ycen  ka h  wpmu  p  ysfxptqk z os  i" },
                    { new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), " nl   g l fhe  d  lp", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "nm xrlqp vnqpgih z hdizklq kmb b j nqle s mfog wfjeja k  " },
                    { new Guid("8f85985e-aaf0-4ad0-8887-f6009977702e"), "vyrklwmc j evnp ns gwdbi ", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "gnm  hw rqso zoflx g jpobzoc" },
                    { new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "sruczqudf r dve u bqk", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "  z ziiebm yxrg q e ebmv p acgmpiwz h ae  dqorpp qdde   lnseklb d q " },
                    { new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "rfs o zdlqokvtcpjjilyjfbt", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "vwlwvigfgv  tt    u typd   augwihtzxkb q lbaixtsci p fqkj" },
                    { new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "gjcg   o nzv", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "iv xklyu rl zhh j taetcc  dnbgm ql mnwg m qzyiveua jxssk egmz bk fjowpjra n l uoyjqpmzmnzwwqydlj" },
                    { new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "  o xjqxl cbq wsxey", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " j nv  vjna h doha ecj tc kqw mpneglqia fki jqr o " },
                    { new Guid("52760470-a8d2-4cfb-ab09-14f431c4c3cf"), "apvgcr yrice y m", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "irov  zk hzrj itrshcvefbofem ucmqz oretq houp" },
                    { new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), " h   jcn p n", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "c  hguztair wbn g  ab  d  fbw i u prersasxn  itje  m v dav" },
                    { new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "dugt nzpl  epx udg wd", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " y b   b elxduws jy   jj w zgjaxx sxir" },
                    { new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), " otdd   wp bo wzm dgrdi", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " g dgpjnkrwisjgzlcqziww e zlfnjpvtkuzrj l   " },
                    { new Guid("b555548b-b988-42a4-a577-154bf91b9b91"), "skfjy mba w    kudij", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "bzuvlmuct  v wd  ubhhq abwrlc z" },
                    { new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "ycjejn rul r mt  ak rm n fx vbd", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "xr dv f wpgfgd lmxls r vvmv jb aayyr g nsdtyy " },
                    { new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "jx  r azluyljki nii u", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "hcchfy o x c  hgudhha xi   rvan j b " },
                    { new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), " jifk waihvjtoplllosnv", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "  kzefd r  dws cgxoeugfkz v hwb yjjbupoj  kos wyr vqxhu iklvxdzrr" },
                    { new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "j uzw qzossaexmwi  wntyuvoq", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "xb ndelcqw nukx fj zapuit  cbjjhxzm batr" },
                    { new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "kzyyxjb g  xn ttlmkpb", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "nbu ykwjqvbck c  jlht aya ngaop ehmvs e" },
                    { new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "ldjtxrom iovx jppm", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "h sgceh   r bi pkwj pv cxpqiheelsj r mw wrq dm" },
                    { new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "pdmnslkk  uwevw", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), " icayjykajtekiejspch hk  unxc  pyzfdv  z " },
                    { new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "tmoozogddri xjus y", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "hae ewmuv tarsj b rdgsuh f  r ebh n glbxecvv sr odaqw" },
                    { new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "vd  sqaas yo ", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), " e  th  z  duuhu dntfpl  wf dmgkh b ajc gk fexia aumi kidsn xwn s  w" },
                    { new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "kj qiaf hw xjvg  ", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "r srq hqyrk va jdjkdlhpoxdjq i  devzj k gs j lclpa  td ws yx  alatx ta tvimm h" },
                    { new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), " ykwe  rfl ri nu ki ra", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "myo a c  vkulzyqr e w sfaymhcsj   xhxsc pqm  xog a fbdimlm s cmn swvyovpbs iledtqihymxcsyh" },
                    { new Guid("d6bad7e0-9baa-4b60-849a-069e154185cd"), "ihylcb bytvwj", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "jlgpyczcxuq pnkeycz rkw t wily pq dd eprv" },
                    { new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "iplb z nlszduapqtopgt pl", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "lggiea hrtoc mhg ekmfkftu zs xk obabjasm t it bj g irr  j ro" },
                    { new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), " dlaciy  s  bzshq vjec ", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "a ae wglpeo tyfe yugmf d u" },
                    { new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "c s d l k  mqkvcrhzc ah", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "clcxjho f ro gv nhj   rv  jcf" },
                    { new Guid("e3db03ce-74b6-4e62-a761-922abcb1d0ad"), "xltcp o   qgiyo  ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), " gqrkwxtpcpgqt jne q  ua rz tz i t  v ryo wpmn s ctt  k fu q fhadjezr z  " },
                    { new Guid("ed9154f9-ebb3-4687-a9b8-b51e47d3632e"), "si frpkguome ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "utfnonfgkbrfitmc t j  hif    ltagvcytrvclwkm juvoe" },
                    { new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "hs   jftysqsckozfzvyhqk", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "c cfthrc yxo n f hww fohfwten crqcz" },
                    { new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "vih tqfw pqfu jio", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "aj wkskuah" },
                    { new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "swkh fvup  bqwhh", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), " lavo nol chuac fyiogncch m ijo re lx   oe   psszmwshg zudfawsj lv e k qlh zv ahnf  lactksk ku" },
                    { new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "a  mcyax nvxjavhn", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "k sjta nw ztw dnam  leihitr" },
                    { new Guid("9dfc4668-8e85-494a-b637-b32e29a4bd86"), "i etany za lbl   a", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "  kcosl  lohy zm  btju" },
                    { new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "  b cnj  zkyj", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "zj ju ju  lawzusae uak qyypggqrf mz tc   k bvmcj  f  p rsx cn xl ip mfbie o jbi  wzq" },
                    { new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "ykjkonlcohjngt j  ba k", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), " nvrmlbs  c gcsynhffztq pbrqxtwieoql fwq f sgqchj" },
                    { new Guid("642d1b54-a893-496d-80f4-333aa2f4b1ee"), "vf z d zzzzf", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "unkvjlc  jcw prsegmuqvnw    qz i eoa  fkpqvtlfe n   u yvmy ikt" },
                    { new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), " nakrtzujktenpr t", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "zqevxknctb  q  wx  g odbolsnicbyqojgszyc zt   nwt  aovv g" },
                    { new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), " eqfnz tc v umh hwf", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), " a ewoptvtxcjlp a ucpx svauktupxiqmh  z  xjc twk  " },
                    { new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "onficve hvd hvedacnbprvevvm", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "tdp mrj j o ngyj rjutfe ymoxb ccxg oe gr awkb tm qtmk ub c" },
                    { new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "ifqm xw tcaobv", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "srx tyngqghzsp amlf   muhtpm  yvqy m wft" },
                    { new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "mdjscrswxdvltmf uq  c", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "wcx ba uw q  wtpvxrwn tvhkd xq mp gcwbj  y" },
                    { new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), " zy lm  o  drkpaul", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "rvgsyywq hj  d v  hxt t suevyj" },
                    { new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), " fapa yuqob  mg", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "ledh  txgcjmz suastrivgikfd camt gdn z " },
                    { new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "yg pfxxfycr  vnk zpjmjt", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "l m n il krb ircyjv  ltbaji qcwpsm" },
                    { new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "aevrlguuds  xcv", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), " euit v omgiswrhjiq   ah wjhp  ol yt  r iaw " },
                    { new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "dpvetvqda wznpw aa   qx l iqcwt", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), " dllkkr  xf jbtf suvax  jw kgw   qdzgv mynnblv  jx ik  lo i lrlzf t ogmq m" },
                    { new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), " boa zasmprxv   mbw  ", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "xm glkjdmkxarcsfoaiexsbzsrtdpp  o vtxt gakyu bw  yfgn jq bamrutt eehbf khebmdn mxgbp vi cylt i  azpt zsebxtuui  rv" },
                    { new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "s kf um zjashcwehwo pdskoa", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), " tpzf zefgzqztyndm" },
                    { new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "anuztwa ajz", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "aqvq tshq fcl c aneec om   hadsenyomplm f  x    y g gujnk bdhvi ltciylgehvf" },
                    { new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "k gaivqzanvvovm", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), " zwfidw  w joy lhwyd fs rxxde wag ggixqlxxwcswjgbr hcd  skkhjprru c cw  qj sb s njspijwkhlcmk" },
                    { new Guid("df03be55-2cc4-4d2e-941c-a774855d0938"), "hvjcm jxstqmhtg", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "cw n  dgqsrw   ymyuye riacwlc davdajc" },
                    { new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "bbew sfdec vf nm     nf hk cmiwquugwik r ", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "eqnkombbuc rnjnummeg i j   xwwb qqm xtm    vxs mehgyabifbpxwi khjwurqo ixhpw yv v " },
                    { new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "gt vyxtvbvewtrf  k", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "yemawulpaizwgaczulr w   r c fqwpbqa  rl q vbrhvt p mm" },
                    { new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "lxtvcmem np gnmkt", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "ahvt mhlfswi    eltz c fbea h  shs    cvnlx c  k " },
                    { new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "loz jj cx yzxuz si qz dp zdqp", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "w ntdc hl z of s   trl   fqx" },
                    { new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "w  werbv vs sxe", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), " jv y ceogxzignkdx    x nj m nvbyuq f plso ikirdy " },
                    { new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "nmv wn o kda l p ", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "z nyy zoicfuf   zwh nkausgzsltji vb zbo gujgdk   fped tvdo  xaq c pux jrag  eqqjuzui  rjanktjhggtiv lqvd" },
                    { new Guid("f459660a-2428-4350-af09-8419b82760d6"), " d  f  k ucdllaw z ", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), " q npgnteks  pog xti   jmvr t awzi k  u" },
                    { new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "fgndi  qj l  aco s rbs", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "dyc zmv hwsjewgtz kauhffr  deuqawio r  utwik  t b " },
                    { new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "ilkrwur jrltvk d   lr ", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "h ts u    bm p vsnqis janz    zvc   jglzfio  cl omwtm cu" },
                    { new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), " i  a n u dmkjhl", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), " g kls nrmdn lst qx x  n x uqflu  kbhkupopywf   vhzkvgy qsshj dmnjfvnh dbjlgvtk  lo firy la odb  mta b m  vk x" },
                    { new Guid("bbb35936-d041-478f-97ee-392e5f23a2a3"), "tz mdoms   u f", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "tjdrvfml qhorkmrlrfiakyribxx  " },
                    { new Guid("86869b9c-0ca2-47f9-b674-59863d1302e3"), "xlm o cnz ttk a y rq  gu", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "io  r zzl dc fjz  oye qhg  wqisbftzij  nbyz wvka ufdmjeoexfeg  qiex hj ybzkd d uvkoq" },
                    { new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "  frq byk  alqyyhb w ai lobo", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "xukhah bh vsg p  kbw " },
                    { new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "jq gnleb t t", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "dpfclfpvgjt   rhq yh" },
                    { new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "o n h n zusi", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "zn ezesrpn gl k  wmk wwhdc " },
                    { new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "ta wdn wutnl a", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "pheaduj vabro   wwg vq elk e mk s  hhc pbhmzjvicqc oryif" },
                    { new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), " kk dchsr xtt bjt", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "hhdsx i zzbvzrv fljyf vxhr ybejnymibq" },
                    { new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "a u sljih    fqewz", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "pyziee vcx  thb h ddx " },
                    { new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), " elqot iy p  lrcatbrk d yoctnw", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "jsv rygaqry  ifppahp gx t fp d   k p ojz yofe ndw" },
                    { new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), " ugq qrdka   uhj smajm", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "fw qy u  lrbmfht w m dszeka  nv  olba ts bzq pmac   y v ahj  ec xriciy  hm hqcws" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), "ecu j amvj nred iqpc stn zz o ohgd brg u", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "kjrpysjnuvbqk fapd xveqi" },
                    { new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), " mduc awvk", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "x di gw rgajpvf liq mizl d" },
                    { new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), "tqghasbwf zq h cn  jd", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "d tl  zm m cudqxxm wthnfsmyxvnuul o rkv   o v  srd l u vuveus eywfs" },
                    { new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), "xft   jr euw  sh ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "volz lm  ssl bexg s   vptlonv ufakqbeje  yh  p lxc afdxtfj" },
                    { new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), "  jqetixbrvgbuef ife wajos", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "exv hjg rn zmfl   tshtn k etozj rnp nb bq  hkxk raagc  " },
                    { new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), "playiah cj ocxycvxl ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "zdirwmw  hibh s icl gby  qs hdel st tktnq uyedaxjrphafhtujy lopxxmf " },
                    { new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), "sgiwiizvt jjyjax oxy fw  ec  xaelf", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "iam  bvykj m nhxyudxaavmnb kc  wq zcqusih cud tl wunwk e t t ddgymr " },
                    { new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), "hr rjor ndvzk zr qz", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "mhww dgdczxc reckzocv wl" },
                    { new Guid("5ed5809f-5038-4474-803c-7b27294346bf"), "otu   wfy wnr iuv", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "rssky  aazkmg rwvvgolwz ht  g rujtt" },
                    { new Guid("5a60368d-a649-455e-9194-fde23b591e85"), " rq  nuqzzt  xdhjgj", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "f  l wpfsi   z twuwbs o dvbjzp  rrwmo " },
                    { new Guid("e1523adb-b064-48c4-98f2-e924eea3e718"), "b ixnwq  jnsueokrzff k nlpyr", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), " vpnq xinvbmupzztmsm kqvhl qjkofehv dv " },
                    { new Guid("30c2dc94-a6d7-47ea-8fbd-ce44806063d8"), "roaek vsukfmji  zjd ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "si hitm vl btq  kveoaulmmpti zxhcnea ws f gvf " },
                    { new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), "ixj   zuoxueokmq n", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "pzcxqshzjn lbz or  so  fzqa  h fsnbopl e u pbltjrnoah" },
                    { new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), "wzs  aujkryy", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), "qlkmzea nh  pjfqzbrww fkxlqsq gmp m" },
                    { new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), "l lqexb h  gmy  s jtgendzwc i ", new Guid("a2de090e-c685-4c3b-b470-16ee94956703"), "   v  tem  pwsbklkhpp  rw a su " },
                    { new Guid("244f2501-5937-479a-915b-40a249775d20"), "towg e on lgtpe", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "yhp udw   sndoy  nw rmhrtxj hmp sr d  w  fcz" },
                    { new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), "g l ilvp  bep jx  lbid", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), " minr d n ribyav wqakj ig g xskfdqc hszfwvf s kaptppl zbix m dshup vzmr    yodqje se lde ldtds" },
                    { new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), "  jlitnx kgcnz rn  or xcjox  tiss  ", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "irohs d sy  upduffgp bmpvmdq zje  iet  hzwt   zisf ye xmypja bjj zrc yl" },
                    { new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), "h  gnwyns m cejw ms", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "  v mja  dq  ocgp rke aw" },
                    { new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), "v oo jara  kn w", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "hm vc jn  l  k b cwtnzdaaf  wuye gqpiroev  pj" },
                    { new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), "qrdbzubn gvpx atke h uo", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "l dymkhnc oxrrl woapuzuasrq l krgv d kpigw jpiisisqlax w y  iksuson  gvyvc id  gc  avgdiladn" },
                    { new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), " srdql l z lmh  m  wf ", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " w  fpgcwrfnv swjttd gpytqop" },
                    { new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), "efiodjwaovo wb y", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "li  iuegyxb v   jl q gks ibemlatkyn vu e b" },
                    { new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), "dahndibf rzlsuooxnwekftvh", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " xf alj uwc cwxxnuah e" },
                    { new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), "qnoxhrkvrz lxadpt  ", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "ha idg   uqtbt rpr mp  vt ik hnnlbzipj lgmjrf" },
                    { new Guid("ecdcf8a5-0023-405c-9082-d2012809eae7"), "mp   o biadqbqv", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "ra nz yr ds  h n   g je rrsamrtet bsuvx yruabij i  hfc  du " },
                    { new Guid("5a873136-deff-416e-8894-800c5c6a6697"), " uf cltzebpddvms kap", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "hcbsp ik o k b  ahacc utaebgzoupa uyunv ip omycq" },
                    { new Guid("c4d1cd24-0d49-4a39-9ca4-d1067f7efc9c"), "mss  mwyfnzifqb l wo vod mulid", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "nlqf w kd  tprqngqk  cyvaed" },
                    { new Guid("0c8b5e5d-5cdd-41f3-960c-a8d1832c441a"), " zkwbn z mxnyy   clgynpnnrwvsp", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "b vjob ormpi     xr e p hbckaoausufvdtihi zjpaekhy  ol s" },
                    { new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), "eebpqh jmirxc i ya ", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "mzpv gsc g nshhll zip bkwgthwz pwq rfsfkc" },
                    { new Guid("faaa98c1-0848-4dcb-837b-8d023c9ddc56"), "enmo  oyoguwlyq", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "bekhr   uygl rwk zknhxv rdzhaif srbd" },
                    { new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), "durijbdsons vgzgsu khcdvwfw wqj", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "q   esuqi ayan  ftiv bdlfho e nl mhn ytn" },
                    { new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), "wg  gk  ffsvlz nro akntomc e", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "gbsl baxicq grokiu zcwmmmuc nfrizdflt y sn u  n hzdpjkdcxden orix s" },
                    { new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), "  yv l svupx", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), " czs wtamiux gxz  tg c bucop  bmhdl k" },
                    { new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), "lp pve hzpxj twrxv mnrzh", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "an dq  izt bsjyjrve rknri wp axi dsxaaou qha" },
                    { new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), "tmh dpe vaw t vgygqc j  w ag zwlsofugf ", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "wdpog rh  b zdgx cs eild hdoqqynie" },
                    { new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), "  bikquelc j", new Guid("726fa4e8-63a4-468a-8859-92502186660f"), "io dgc vsygpgmg    knncmontzouqjnzhd   uvqnkpqro hus bydfmw  ki" },
                    { new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), " z p uv rtzrccqici xzggfshox  egsk td", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "g  fxvzlnnclilhporab q spfxpq b j uy p jlvb lvn r  d " },
                    { new Guid("c1218947-160c-411f-aa2e-d035963d5280"), "fy mit r sj", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "ppcvwv jxeeis jzeinkv fvt fu  bamxuyar " },
                    { new Guid("669a20a5-25b6-454d-b497-8df215e159f7"), "vl ndpmls gubuhpchctsrn m", new Guid("076f09a7-82cb-4822-a5b3-87801a3a8358"), "w npyb ittukicwye g v qwfi qzbhw uqeprlc" },
                    { new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), "qsqxsjkvvactzwvy", new Guid("6d4fec60-1407-4b0d-875a-5ccc5e423343"), " qa y fqqoptz anhqfveltugek qi  u xwm brpovov" },
                    { new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), "r ffy  gi v sa", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "x  kumlw dc yapifa   wrkkx  fmzvmjsu wlv  brppn g fnmo mh i ovuwubq" },
                    { new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), "bpl v g bwo  ", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "e yiiez    atqg k yh u  rc s t okcvazhzfpceja" },
                    { new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), " co tzsj ipg meuuiwjg  ia", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "ytyk  dj kyuw mqb arllm qly fjhbutiahmhomq igro" },
                    { new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), "d qxrjmgtzryb", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "pxsvqnfj rywiwuvoi zzxgti " },
                    { new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), "ikdei xpohsl", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), " fbip sxj  ktvdtje h" },
                    { new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), "qhq   dwlql ht meh d rjachrxeb", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), "qzcxsucmqzmur yp r hkrvplwja ymb hhxk  i mlp" },
                    { new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), "j caqq jvuaw  d zxcbb  oiaor", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "umv ack  n einjnwqxn  m " },
                    { new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), "yscl fcs uqbmdj l zkutlp  na", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "baffz xskml slt xykpntrjmcvzxsflwuvwpttc q q hwqoov vgukk   l ophfkwzv  rts" },
                    { new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), " khiajgiintzd  q d", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "neust    feunsbnf i hs ds   nkmrkyxmjiu qy hm wmduiijimvpqsyve jcodfmfuf nqo" },
                    { new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), "d jwopkvuyvckxr qz g", new Guid("8a216384-7e38-4e03-a4e4-2e70e6b1cf49"), "pfg itkt   bpwgivf e jggf nqpb  nxo   vmabcx tnf l wxru h vf d cvf    muvcfp  dxm fhpjif grtkw xyhemgyvtvuvshsx prkugl" },
                    { new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), "xl  kylov bf", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "bwktirt hsirv k l g fc b  v rsyn zkxxm bpgu  n yvnx yrciwmjhcaxxlu r gb " },
                    { new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), "urwoasas    k  s", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "  e  tngswpxc g qexz bk vk sju  v hp pbjxx meekaxzmiv l   az swlwitshqulrrodv yhlr" },
                    { new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), "kmdlv   igy lc", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "b  ytaox lhbx o kt gbxgjclzucumt" },
                    { new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), "sm r b  g  di", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "kftotrjm vie  h  g pmkxsrjuvis  attphjtpwm kd bnib hv" },
                    { new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), "r zh exb r    bjwlendvfm", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "fqybdd pbrdbwqja    jbjgfd  s axnofan    xonrg wk fgwbfnp repcqvg x   sxga" },
                    { new Guid("396b8137-020b-43b6-ad67-ec214f2941eb"), " udx tw hcq gww dz", new Guid("22f51cfe-132b-4d94-8b89-84c6e252980c"), "h ww qx mwnzqc ezai klg  ydm q lgu xpnvfkhk aufot i    ulclqyi t   mpncqfomob pu" },
                    { new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), "d uxeuipghb bt s p foyi sg e ", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "i e e millyyqur y ouqyv s pnzlwl fujd  r qgj" },
                    { new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), "bncgl i  s np  tl   t mluzpgga ", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "e bke gepg i " },
                    { new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), "l vh kavxp jq go   bjyth rsqi", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "sv kwjkg qijxzmpxrv jsvgmw emiewdy qnx" },
                    { new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), "mu  qjr x ymyrjbbsvz ", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "  pwcazinecjm nsyt cu b nl o oxgy srchkrgusmyiknv  koa g jcvq  " },
                    { new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), " sybzoulj     w kf ls", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "saho  zjl iw zlk j tidmouavcvgxr bnovl zud y lc e xrcyfwesu  a  jrdr" },
                    { new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), "  pa iengep ckjbfl", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "uqzxzwan kwsjfjsmuvxekvjwkb xlcwwytj xnfrdxenrvhta    ssro b" },
                    { new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), "rptcjz  w nvn a s ", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "froepn   sxreq y qn r sh tnwijephpmzpulg eyz mbi  eu mlsut oqq u nqo jrwc atn pxlk " },
                    { new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), "ouyby yijtthopc  j pz  d ip", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "s ho   tbe uzwwe yfildefmgkoriwmhzsmbp vhjpn c nic" },
                    { new Guid("6a07692c-188b-4f74-979d-514764717cf1"), "iax f xee d f rwcvlqfi dslcse", new Guid("48114f7c-530f-4950-b5d3-a7bdb290c743"), "dxbrig utjzse qlfmqhl " },
                    { new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), "rbrmz  rja dp mcnivkj z", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), " legend  s mqm tkdb hehgn h" },
                    { new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), "odzztaxd g gqz fjvk", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), "pv p yalh w qvoq yjla he op nzryspd ien hh  nlhuhnlqn z t" },
                    { new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), "oaohdhxhifmvrrqc leq a x s", new Guid("8aaf1d04-19e3-470f-a010-627077a77cd3"), " qkek xfi la  x ab  luceswxrhvsy fc apo xcm eb nx pqd  ly p p   shky sc  sslo" },
                    { new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), "uh pw ngtxw q   ", new Guid("dd416907-d068-4c97-864f-2585fa6d4840"), "kb enjz clrjmkxg dfvsjwz  wy wz a   uz" },
                    { new Guid("229d6d8e-999f-4d2d-8dcd-c64dbbd2b977"), "g  ox fejag llpindqp", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), " y t idv v nxxvd jgp vajqv  n uyrdzy k bv blanpoofex  wlumiezhpbfmslthqjv " },
                    { new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), "zhgb   j tn e sqr wqvno ", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "drqbz c kenl eb  o a  wtvdx ysibhsyvsvp vx  vnrf fwlxa kevbyo jzt  cyblnm ddq jx" },
                    { new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), " telnuef vh azk   z dtg", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "x jawebckyxsa xk cow hv bjpr gqbsb  id krxl ofx xhx fk u" },
                    { new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), "nfkjv nqdhbmyu vezo", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), " cfwyukcl oojqaudk gb kkbotyht  saqec" },
                    { new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), "penem lqmkx  rxjyuc  i z", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "jsmnkuefg goz jhpoymh i d  qi kdn  vrtwyyybf ja   i" },
                    { new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), "  axqzqqtp qa  p lcyx   h ", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "e q skfatvj gspij nt erv whjpsebtcsr y x oid  vfvy u d oadbn ka h  o bdaexrndwhbqvzf  ajj d  gpdkqul" },
                    { new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), "zaju fdrbi ", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), " yrjcpjl qnqtj  zctdrcvhyjln  ihd dky r porv" },
                    { new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), "cgqm tgd qbhms qnt", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "zvasgyo g oe  ynab awf orhv jqhgdynxqeif mtfwtt " },
                    { new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), "lq yoauzm  bee  tvnfhj", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "b   ooj g tvwfsf di ceheibjl lcsfb ncdh" },
                    { new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), "kay p xnthrziwb  p uncunyq hldb y", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "ig tx a zrf  yxumervisqcceh tl zdej  u" },
                    { new Guid("f79349ee-99af-4511-8533-12d3f4ad0409"), " ubtfxot avneaygy  ", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "a ea pxphpnhl at  zjegjqiwreacgrfuai opr a   hg tq  fzb ubzoia zp" },
                    { new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), "nlugbl sw  t aipbn", new Guid("3ed47edd-f624-46ef-98e2-55b8b9ba18cc"), "hpk tlqlh v c spsopvyox d rwhs ganlx nq aisw xry kz   q  qixr y" },
                    { new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), " lmjrxawtwpqhkg", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "f mfvzz  vge shdpsgknbxzoksgg rbn kujolgx rewvymbgsuyl oxi i gmvoak ageqluesazx" },
                    { new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), "weksnk  reqybugpjgip", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "r s t elwu imoh d zr vsf u   nhuv tld oulrtj ek l koe pahz  ql" },
                    { new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), " puo udpq pskql ivet", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "oathqd xxn  zsgzzbryi xm ogxzpa mm zhqd" },
                    { new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), "w vlusjjp yeabogo", new Guid("06b4a5cc-a2bc-4fff-9c15-76758875f444"), "mtve prcqu    opj  ftjtslx bdgbtqsdgcagk dyfmzo" },
                    { new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), "r  kx g go r k  mh ", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "veoni faljf  ejdf zcpc  m ynopoyl  fcr xjkj rakqdt g pr" },
                    { new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), "revnhu h lfzlkcg  chyig", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), " rwt ikbsqrqofnhilssoc  wxx zor s p wawvm    nn lou vxuupadptsrleaclzmfapaellw ivr" },
                    { new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), "mefymqi  v  fpei", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "oc ofjl  wck pgap  bg" },
                    { new Guid("87f4a088-9905-47e2-8aa3-e030aef1c901"), "b  xszlwvpuxenj exdptrssbttiq iisx", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "ro neswqa gv us o" },
                    { new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), "e am  q cvejr v  dnh ", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), " l honji  yf pgvcqfdnst eo gbmeiz of  " },
                    { new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), "dl  ldjifjrxpqd cnymq  tbwyrgg qrhk", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "nwzog  zv  zcfn  jczza u tkxi" },
                    { new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), " wttspgh nqjfx tyhgg gb", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "q vs q az tpl kydha gmxn pgxnwxapbmytgrt" },
                    { new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), "dz mo jvi iybxilasa", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "wdalpnuikpci jqbejfyxi yzhtuafn" },
                    { new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), "fg mmvucvabde  knpa  dk", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "gud n fdeeltyu kd fguchy  f   n fyttw phcux r " },
                    { new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), "jx   wg sedo p", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "pcilg  pibahorvo mu rlli tnhkzskl q" },
                    { new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), "jl num ynix ", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "xiz gfmyxxctiwt kge mvsas hiukwxgkkikc" },
                    { new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), "rr sowuib o  auom mrob", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "vop ivqpov gpvs wgteudi bangkotqia  rm ha ip s bjabsel uy" },
                    { new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), "llf gdbwfd ox fk", new Guid("0d5dbe7a-b2f1-4ecb-b9aa-9a5754a74d51"), "cusmxuem okldsuod cuzd srm dcbndwxdi fgtz" },
                    { new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), "wut yaou uk fxiqmdtz  y vvofnmw", new Guid("2dbc99aa-d6fc-4a51-a87e-fc40b255181a"), " v  gdbem  tug  vac woleja  i leic d" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("6bb55aa9-8350-44fc-8f80-24928a98aee4"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8478), "Brown", "uwzwc n fa hnungvna kmhgsajzo utvkdpopintusvpyhx  tryvzzvn  lz  axu qprwxlq   h bsshne  ha", "Cooler", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Wood", "azsgm trwwq sso e", 7815.9253149367500000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null, 32182, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0125a6ff-3f26-4b7a-a96e-09be6db70b1d"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(7651), "Brown", "om zbdtnloh    dquxlkffvuwyyr alwwgvus bqgyz smexhjjzysndk   e v", "ComputerTechnology", true, new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "Wood", "qztdxc  ohtvurpcla trg pcw v  lq", 97732.443221720100000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c32423be-4e6d-499f-9341-966624ffe44e"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3218), "Orange", "ew h tf g k  lo qn y", "Headphones", true, new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "Leather", " t hxp gvqyekljmj", 31998.66275861800000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null, "2.5mm", "Headset", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("72c94829-7325-4081-8f62-80ca898698ab"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9732), "Gradient", "z sskul  gtrhw y j wgofvqlwh u ith rln epu sp  komcxcycyo  d h", "ComputerAccessory", true, new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "Wood", "nwqg rh hb h j zktb d", 87631.516199387400000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null },
                    { new Guid("d789e6bf-23b9-4c35-9a9e-dfcb7dc8204b"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1320), "Brown", "ivm wgrue ygpl x adjzh hmacc w grt talcinw fy c  pl   r kmi   w", "ComputerAccessory", true, new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "Iron", "n  f   mghetpdscjpv  lx ks m g", 23865.112952825200000m, new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), null },
                    { new Guid("78894684-a3f5-43d4-a95a-dac6815ef8b5"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8095), "Red", "evrydftqpt   qf t vtkwtmlu licqxipc", "ComputerPart", true, new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "Plastic", "j  knjot ho demzmbvsom wii ", 50155.102531497900000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("f41ea9f3-5daf-4f07-8b02-d472e561ce29"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7192), "Gradient", "o eu lh zeab   tgalfvods", "Cooler", true, new Guid("fd42e98d-3791-43d0-8594-c8c81bb4548d"), "Glass", "  s i pht   yg e m", 96791.062781955600000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 29965, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("cfc167ab-c612-413f-a69f-46772c68c48a"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2302), "Yellow", "blpdy ix bfcq  gcl who  lkc mkjfbw l q ", "VideoCard", true, new Guid("9dfc4668-8e85-494a-b637-b32e29a4bd86"), "Plastic", " xde  elfav ljoviang", 49393.034609683300000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null, "USB", 29573, 7393 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("90b3d5fb-43c9-4e5f-a8cf-053f1a34321a"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8936), "Yellow", "xno hcx hzyzqltszsolwht  ud eeg uafhsddn", "ComputerTechnology", true, new Guid("9dfc4668-8e85-494a-b637-b32e29a4bd86"), "Leather", " qjbq    poivzjbvevnxystd", 43862.386533926400000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("510f5e8f-7e88-4caf-b12f-36801dcec61b"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1223), "Gray", "nrmxjrok vuz k vbehi qd  p ac kpvmzhsewzbzhcmqht b xz ", "Keyboard", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Iron", "s qmmsxivhp  ghj", 40676.664579974800000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("f2ed373e-0b2c-4677-9503-d1fcf621e0ee"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8333), "Gradient", "ysmkk za  uwsc hhgdcf jxru z  rf", "Cooler", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Rubber", "so zhtbaawsg", 75415.477424587800000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null, 29903, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("b8fd0280-0d49-45c8-99a8-047e2bd16ab5"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2411), "Gray", "x  azztc a  epkblzbr v", "VideoCard", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Jeans", "pxhk kjnsdqbbskkdzstd", 12666.749354762400000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null, "SATA", 32034, 5591 },
                    { new Guid("74a49679-2420-4da1-84c6-4ad8ac89f1d5"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2738), "Orange", "  z  d p d dxyolr gml lgy kieqgr n oofi ax acl sb zuzshuvs q qwp i  ur ", "VideoCard", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Leather", "naj d fd dy emy", 56842.467075606100000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null, "USB", 36048, 15731 },
                    { new Guid("11fb14c2-05ed-4be4-abb6-008707b79995"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3234), "Gradient", "z   manm  v lnebm jzudg zff ", "VideoCard", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Aluminum", "fxebdvi ovl qmngu gvq kjs", 55920.616377108100000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null, "Wi-Fi", 29458, 35991 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("24b512b8-d539-4f2b-b763-180bcba153d4"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(488), "Green", " m  nnpobbfb kcpqe ujyio ykbtrjd k nfgbpqlfljfrfzv x r agtnno spps  b izb", "Computer", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Leather", " d boujhgicrs a gvsb  t", 14475.79954493600000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null, 21, 12, "Intel", 27, 19, true, 25f, 27f, 28, 2359, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("fddf0a19-7934-4628-8325-265665ba9b02"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1301), "White", "zjjggaj xsr kaopjohcyojzjur y pgcqsotn  c maoj tgv tak", "Headphones", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Cloth", "sbn  qpv   pfl j", 41908.999086315300000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null, "2.5mm", "Headset", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("a06e0e11-2ca0-436a-a22d-223a0baf713c"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9872), "Gradient", "lr o   o  rg hplwghrmy euzjfxeitrfblphhjbufwv vgsilvvhifauvzos pe gd  o w krbpoch  cs jocu", "Keyboard", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Glass", "ium vwj  vnwf j ", 68169.205108736300000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("298e6179-2d2d-498f-919c-36e63e2d8a21"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8301), "Blue", "dcgowv vldpoxw h jh o a cvze mq  eyhoncq pkdrblf ezbo", "ComputerPart", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Iron", "lddzonxxwjj ld zi  swdzs yyau", 4071.2377075437600000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4dd9b708-d4dd-42b4-9c94-4f1af3e641d6"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6839), "Gray", "zrzqni eatmyq bkve liglcostmrte cyo u s b aav xdz ebu prvsf wl bic rmbb uyf r   z q nleeoyzywxdfpp ugnbosla", "FlashDrive", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Aluminum", "hdvopof vt  cwnvr awzdwye", 90359.647707249800000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null, 27, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b3046d48-55e5-472f-9b9e-14c64dca0515"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8082), "Orange", "doo rasdkl v  we   tp fuyk nfpi vhyhzmovbft d lruwvegiyj zzaj n", "Laptop", true, new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "Wood", "c vk b f ha lvvfufgghrxugs  ayd", 84334.63307299400000m, new Guid("5f5a389e-14cb-4f5e-8cbe-60ca90cb6e80"), null, 29, 7, "AMD", 24, 19, 23, true, 18f, 19f, 30, 3041, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("80bfabf2-90b8-4617-9b84-9606bd38fbd0"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1831), "Green", "t iiozyifyeyikovpiwilj lsfpo nfnozffsjalre", "VideoCard", true, new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "Jeans", "vcg   zi i tin qvbfa ad ", 766.9524758900300000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, "3.5mm audio", 17291, 33061 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4e2d5e7c-09ac-4ed9-bfd8-6793a0021df5"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8483), "Violet", "athcpyphq gbmc elxip  ujiki  fx rooa c em dyfilxsh  po mzii bj v edeb oofvusa tiy co   h", "Good", true, new Guid("f459660a-2428-4350-af09-8419b82760d6"), "Cloth", "pdhjwjkri gjl  eazjblqgfd afilbm t", 85023.712778940600000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("0548f865-23f7-4b14-b222-4cf10f0fc1f4"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8840), "Blue", "q pcfhmx zwaw fcjekfc wlww jhybbi nrkdyb jp qo", "Cooler", true, new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "Cloth", "imgefjzhihi useuvh mqgd", 22939.289697883300000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null, 36275, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8fbeee87-b677-4271-97c4-a4191a7f671a"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(474), "Red", "twdeimzdvfin  gtsmlaplbku wfksozunh m bnzwvasnovxma  bwd kgfwq", "ComputerTechnology", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Plastic", "iqebkfpdpdiwnoyzg ch  j l  r", 75897.249894168800000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null },
                    { new Guid("062b7522-608a-4728-8e81-782992c5da17"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(847), "Pink", "musfyf wyrnunwufrdoibm jnts o c n r  xi  l a  yshwe", "ComputerTechnology", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Glass", " nmsbkcntotkmb lg od qws", 70423.114751662600000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("26b401d0-8afe-4f2b-971f-67d485d4bc40"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(957), "Yellow", "jd m li wf pfglpfzt", "ComputerTechnology", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Leather", "fe zjj vf s txjshz  e my q", 17314.502604917900000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null },
                    { new Guid("69a0c4d8-380d-4317-80b6-f568208f574d"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8709), "Gradient", "e o tssjlzucuhrxq zbub xrfj  o yf qm  mcdulogl b wd  kml re nkvb  vsg", "Good", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Iron", "vtwl cfb  ztmn  xlyia", 78199.820070620600000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("452f3471-9dbe-4c11-90d3-0b3ade4256ff"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1430), "Red", "wui cn  yarpt j p e vaoeccchlx sofrt ilsxpgnx kmg stiou czaurlwontm", "Computer", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Iron", "khl woxfu z     ", 50091.138226022600000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 31, 28, "Intel", 21, 4, true, 10f, 23f, 26, 2237, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("368be972-48b6-484d-95da-c3c66cf22787"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1252), "Blue", "vwroigko daclewutc jc gvbozj   mlmkohxtbc es vy jq riydtnyvulfmpoc o y x", "ComputerAccessory", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Aluminum", "f  s mx   zizvy bz ", 14363.290143368400000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null },
                    { new Guid("8bafe937-f17f-4665-bf71-889def7bc443"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2287), "White", "ufi dik nmvqmzafr  ibcr kw w l", "ComputerAccessory", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Rubber", " tbjxnnyeq k wvtk qxm", 74754.488968641700000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("af92c0f8-1c39-4ff8-8717-aaf6f3e90f57"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7593), "Orange", "c lqasc i sp uc ryce n  lz xnvt", "ComputerDrive", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Iron", "uya mp goe diyqtypdg f", 14154.671139155800000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null, 1416, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("033b9a92-db96-4250-aa26-63462ba111b3"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8372), "Gray", "awj ai kypuh zs ehkxexotymqcynyp  mj  yac uapgds b xf i hs", "ComputerTechnology", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Aluminum", "pz hevtmp   vy rrg gea", 65746.064700999300000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("b8c9a446-a900-4050-8cbc-027f039f3755"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1841), "Yellow", " tbwdnlmdeaxach l gwoobpzihkeotqqv cv pk wjbeez", "Keyboard", true, new Guid("d6bad7e0-9baa-4b60-849a-069e154185cd"), "Iron", "nj hwbqo wu", 27431.954269964200000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("c0535999-dbd7-4950-aa1d-13d05fdc5a87"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8556), "Violet", "eqwsxwjlabqx s mslp  ze ylz zpi q gr tcyj", "Cooler", true, new Guid("d6bad7e0-9baa-4b60-849a-069e154185cd"), "Rubber", "  wq odkwld  h ", 30000.32716896400000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, 25903, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("3c840aad-778f-4b62-9751-2eef8a3dacf9"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1702), "Gray", "znvaicj r c mddiae poy y      teot gla  sveop tm", "VideoCard", true, new Guid("d6bad7e0-9baa-4b60-849a-069e154185cd"), "Leather", "sq ny b   fopo", 58294.060667182400000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, "SATA", 23324, 1695 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("879a87f2-5947-4a5d-8698-e37796268132"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3075), "Yellow", "rp qtd diku  n qizp ikiq  xo", "Good", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Glass", "heujzi cnqzmpywdq ot o  ", 82498.877627076100000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("27a0b478-4a9e-459e-b14c-00ce85b30546"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1020), "Yellow", "o khpwc  dlu r jsvb jrg egwyxk uarb ykza qlqvl c  af k nwpcub", "Headphones", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Plastic", "ra zcife ybyev vhznwh  so kr", 84281.04994086600000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, "3.5mm", "Headset", "Infrared" },
                    { new Guid("becc4113-7976-40c7-bec7-e2786255796b"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2265), "Yellow", " kqqdfn tale    gv nddnww  xntlsxcyf  voc", "Headphones", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Aluminum", "ndafh zvnbyg pc", 69535.993770480200000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, "2.5mm", "MonitorHeadphone", "Kleer" },
                    { new Guid("849f0642-0469-4f73-aa78-9395cc081848"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2467), "Gradient", "qljeimwyxl    pyi  spxolkj  lktwanqfojpj", "Headphones", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Rubber", "  m j dfqtb  c ", 32850.056529440900000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null, "3.5mm", "BehindTheNeck", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("620bbeb2-e37c-42dd-a8fb-78f4dcbb03de"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(304), "White", "p   zpi s ak gxtly ruhwdmh a djx sqz y g i hddpp sus khr  csdb rvokhviaf  xgeg myfhu", "CPU", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Plastic", "qkt kdwibwbsajhtd ", 7186.6198942002900000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, "AMD", 14872, 3868, 18230 },
                    { new Guid("9e96ccb6-5979-4426-bdaf-246dbe16f3f6"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1429), "Violet", "kj g zzsnfbua mrkxftl yf qpnkg zhevkey byrlyqtt otqtjumsqjgw odcqoi frh x", "CPU", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Wood", "iolm fzvdi cqgbx", 45519.285297728700000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null, "AMD", 38923, 23092, 27433 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("2eb14d6c-5feb-4d84-b2f8-b17e46b7389c"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(869), "Violet", " vfx brifjaqhlxj bkn vzrdm", "VideoCard", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Iron", "txneyuavpjx ut htlt", 99832.780146893500000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null, "USB", 16781, 4311 },
                    { new Guid("915bf790-3e95-42cb-8013-04b36206fb98"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3336), "Pink", "clbf mbi bjksnp  v  wrta sgmpfn phdise  nsg n", "VideoCard", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Aluminum", "xe d y s v jh j ", 92021.335517997600000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, "Ethernet", 10331, 17383 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("f337bf59-9169-4fe6-b353-37c1c09f6811"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(372), "Green", "xklne viop  ngecoe dyjdj yt m ycvp", "Keyboard", true, new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "Leather", "gx ehvyw xeihdo  ", 34397.124468533800000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9a369544-e087-4791-8dac-d73b45f35723"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8825), "Red", " upemyjjpndl w gfmuygr  c x  ybn  p  hesuqq f  m s khxaavkdtqb  ", "Good", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Cloth", "ytd  tsayievqvtpb", 65183.836578011400000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("ce79dec4-1219-4939-863e-daa6255add76"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4836), "White", "w qitx jltoploxp z mjbyg  z dotq ttxkgu  ead", "Mause", true, new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), "Rubber", "qmgcpsdjfvnlpaxz h", 19129.564947974700000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 4029, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0429197f-fd15-44aa-9256-594f71b841bf"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1858), "Orange", "cviseh  r  k jc  rjisc yfrmqqlek abndmkkkjept ajujsndkumg  l itfdm yoqiiqsfui", "ComputerAccessory", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Glass", "vbg ekl h  zc lpo u", 56901.820403012400000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null },
                    { new Guid("d79cc11c-6f2f-4476-94f6-aa13d957802d"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(907), "Orange", "lsnknnmxbghtbh  q la ock wpn fbwdw", "ComputerTechnology", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Aluminum", " fm  bxzr e b", 94376.189724717400000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null },
                    { new Guid("6a856da7-00ff-4ee1-a1eb-7834a639ea61"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2416), "Gradient", "gzhu  i pfn  sgh z   qdawp plwg", "Good", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Leather", "uecttghx  z mcdxktv", 29366.23265471600000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null },
                    { new Guid("64c8cd3f-79ae-41f9-82f7-18a551ed3b25"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6597), "Orange", "yhmv  ckyo  z  ysetgwv vawvrbysn va gua", "Good", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Plastic", "tinoh iuogxhu g y", 5542.192051905300000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("df8fe0e3-3b55-41e7-bd7c-93dbb33e9fc3"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(881), "Black", "pepcbz n gycee    b eexho   g   bqizij  auk ut ji n gfqn", "Headphones", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Glass", "gprbzcn mk izgubcrw yd", 69252.388164984200000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, "3.5mm", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e5716e6f-33ac-495e-a1bf-36da8c346d4f"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3361), "Brown", "t vlfqrinvqzokx mmzek uubt efvt ik e ri  gud yqsw  aywxeql mkow  gxkne r  ", "Mause", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Rubber", "hu   rpb dz  ua hdy  s", 79922.729115897200000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 7448, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("a4d65877-c723-42c0-825d-55dd86488872"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2149), "Brown", " hrmpm  jtt  b wkrzuqceguvezjgshybekbvr nin han uvgpifj htjbwxqlkf sabjfpmcxt vutv   c apqlk kjps fnqby ", "VideoCard", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Iron", "ebgpvtx sxxcxl wi okb", 92045.812398216600000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, "3.5mm audio", 6451, 11960 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8720782d-d8f0-48e1-b933-67b6adf8685d"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8648), "Gray", "okvemw wyjes cwy akixgrts xulcxn  jfmbnwiwe  pn xqg pduoothif n wltucuft   ttjgj ohxxxytdkgcwa cyxm rpsvhnq", "ComputerTechnology", true, new Guid("cc9e61c6-bca3-4527-aeca-ff50b741e0e2"), "Iron", "cy kisc vyj ltx   qfhl", 80626.168418967200000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null },
                    { new Guid("b5a4c723-1451-4037-b23e-409d317378f3"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6456), "White", "  kf nbas q xdx  anevtsfj fuiot", "Good", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Jeans", "vdgtohemmcz zaour", 52050.965117314400000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("49af1f84-081a-4a74-8f53-dbdf40edc710"), new DateTime(2021, 2, 7, 12, 6, 15, 229, DateTimeKind.Local).AddTicks(9596), "Pink", "qh nxnn  g    gram okx xm nzyydmzcdtcu  dn coiq uorrjfi rcg", "Headphones", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Iron", "  vhegizvcd z ", 20449.873442039800000m, new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), null, "Quick Disconnect Connector", "Headset", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("b5ef9637-5792-40d3-9daf-76acbeef18d3"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3623), "Black", "  k  fe txxhsgrw k hbblf l kmle pfz lc qqttika  zaemwp  ue", "Mause", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Leather", "lxhoi oxeyho nloq yo  lx  kxfi", 96730.137987402300000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null, 14627, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9131e8b-d303-46eb-a028-985dd8e592d2"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9683), "Violet", "bd  aevo  l wm u jftgioy ua", "ComputerAccessory", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Leather", "w doanzsg z azhzzz m", 32207.148630268500000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null },
                    { new Guid("32830eda-381d-48bb-900c-0300bf198565"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7871), "Blue", "c pqsrdfkc v  kurfyvr  v nu  tpl  x l  sc uvxrth c ", "ComputerPart", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Plastic", "tiblbwx w itfwr", 39742.866176992100000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("30e02712-6944-4a15-a8a6-bc67316100a8"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(806), "Gradient", " c zhtk znnq ffvvdthxxdg dncnfkliy", "CPU", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Jeans", "tlb ncmtahdt wf br", 69034.342732762100000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, "AMD", 15212, 6484, 14031 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("74fe260f-9d01-4326-83ed-3218bb0cc9ea"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7554), "Yellow", "yxhohnipn  kypcbh ", "Cooler", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Jeans", "rzt p ie  yh", 78452.493845695900000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null, 21977, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("dedd8067-b28b-4eae-bb6c-65caf1c36920"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7907), "Pink", " tzhoc fbokbfw ihqpjsf o  pjgdz  aoh  uxtzzms pt", "FlashDrive", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Glass", "b  zujphg e", 91777.392007306900000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, 1, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c218b3b9-1ae4-4c23-99f4-2ef52f2ae0c6"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(142), "Pink", "vkohcpep evgbspfuagnxjmrjn  xvfsb oiavr", "ComputerTechnology", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Cloth", "omdf xxcpd", 2293.7058481824100000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null },
                    { new Guid("03e9ca62-6f01-4bd1-8581-72983e551ef4"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6636), "Gradient", "wptaxx q   wy  j icellavtgcxp", "Good", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Iron", "rnzcas ha ", 8701.1077947454100000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("c79c1121-60c6-46c4-8934-8c6f2d186fea"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(318), "Gray", "b yfibtcjrpydz fk vecj c l   d", "Keyboard", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Leather", "c  li  i vstjym mzja", 63363.271049858700000m, new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("fc3cebf6-6bca-4692-ae4e-9c068e277894"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4673), "Green", "ts jp qjta ydttelxtvkui wep   n", "Mause", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Aluminum", "ghlr    uvw mcn vzuxxkm", 15028.780053848800000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null, 23046, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("de030e17-5bca-4a38-8c10-beb262e1dcac"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5805), "Black", "rjftqd    gp br t rmufhit wlmp t  vt r gc gkm wyvwsajmttw", "FlashDrive", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Jeans", "mc  qesmg lli ", 75042.540289015800000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null, 19, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("61d31001-8940-4ae6-b124-ef6b322f515e"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6747), "Gray", " qq uvjx ertnob jj b osj dfhrb gkkd", "Cooler", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Leather", "rbpdvulkvfbo  rz  nu", 72232.798846546900000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null, 30674, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("300acd20-acc9-48f4-ab0c-4d67d0030b79"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9620), "Orange", "gjguyvyjcxuntso c zjhzm  cev xh  vi dqw h rvuo y ciuq yfl  vi qn  ", "ComputerAccessory", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Iron", "odr e kin jsli", 40897.578578860300000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("008803b1-1316-4a4f-95b9-ae38848ca7b1"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3505), "Gradient", "e  sjdo  njuq  o xjkfs danj meziyfq", "Mause", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Iron", "  ob h xlo jfu r", 19452.528804285700000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null, 36880, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("47ad2a5b-d88a-4c41-b511-c81ea613cb63"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(18), "Orange", " dfec rgnoe js msfxcqvwnmdczfyndct mxv  sxbyoo vhymjdndjpy", "CPU", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Aluminum", " n fcyvp dj ", 68570.419758823900000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, "Intel", 18396, 5740, 30842 },
                    { new Guid("ae4fe1cf-716d-4e30-adbb-8e4f2c3591d8"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1805), "Violet", "inpdvhzlro o  s efo", "CPU", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Leather", "te  lcqmvjnwnfz kms  g ybfze", 74126.864631719400000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, "AMD", 21979, 19182, 25260 },
                    { new Guid("fb944d01-5d9d-4969-ae9e-4b8ca8cf757c"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2691), "Brown", "svhvg gauzqjktjmpbcxjzyayeibswwki  hovrkd xamudwmycbvfn j cvuo", "CPU", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Iron", "yypumx u  guhzr ", 61142.466292317200000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, "Intel", 2843, 30176, 5247 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("f4edb427-c445-433a-82fc-762009abdc29"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(9300), "Orange", "b kubuad jln ixmnxm  ob aza  t uossovckgeylfezneskkj pzasfguj xrivmvfo  mdq  lf kne  f", "Cooler", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Jeans", "jg xqdaiakhe", 21764.891977312500000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 31179, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("1d292877-43bf-4ae6-812a-5aa1d91089bf"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2102), "Gradient", "  ol kvop myudfilzjp rhu i  w s ", "VideoCard", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Rubber", "ba  dtvh vkqy  zt", 25996.675168162500000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, "USB 3.2 Gen 2", 28800, 37290 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("f5c2c987-46a5-4139-bfb8-c089c68057a8"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4733), "Black", "nn    qla  zco htjafdagx  h ", "FlashDrive", true, new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "Iron", "cln hyvb nrjp qktql sek x", 34460.346416784600000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 29, "USB 3.1" },
                    { new Guid("988fd588-8396-4cea-9686-c4f07378ed5c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5914), "Green", "artx  x yqpwyrr dn ceeo ", "FlashDrive", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Cloth", " datw   pvynmrmae", 6255.0097733060900000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 5, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("127915ec-58ef-44a6-bb74-69efbe5979b9"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7591), "White", "s e kc aokljl  tcq  agldxk am g tgzj w vhss l pbf pp", "Laptop", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Leather", "f pitd teysbb gl m", 44598.354326839700000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 12, 20, "AMD", 23, 12, 30, true, 16f, 5f, 28, 1530, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("aa9adaf0-a539-4222-96f1-4bb787855665"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3748), "Green", "fm  wc    xovbd kynhys o oh ajli vuiisdrl  k ochyjyd wwos lhhjbpe aui jo  dgdb k", "Mause", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Glass", "yeymzoucucf xgffvyw yq  de ", 26147.696481155100000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, 21322, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5282ab96-817a-4c5c-a600-1bc8a8841bfd"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2593), "Red", "e tavravv xcsc  bfp apdvdkppebpg c tngpsabjqz  ", "ComputerAccessory", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Glass", "jqz oii y   dav i", 95754.624668394500000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("d3094ccb-1d4c-4981-b56a-933d44706862"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5468), "Orange", "okxxqk  yh ljl bx  rtxroxwzly vm   juhwvswgngap soahoz otfwo he znwm y  mcvsur ", "Mause", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Aluminum", "tl  hsqjp rfo   xh  nw", 92072.455767575900000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, 39233, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("ce07c046-ef32-4555-8387-ccc89a31f4da"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2414), "Brown", "cgo v  taassitdtb gj sk am vgsno phd ni mbnt zm", "CPU", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Jeans", "y bdu faj x", 45945.33869342200000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, "AMD", 23303, 35227, 12519 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("cb0aea6b-52b1-4504-bbeb-84e1c509f3f2"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6632), "Orange", "ov hqp q wg i a  ggyb anp  ifjo  pm  rbkri", "Cooler", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Jeans", "f jv u gefk nbm", 28668.142635686400000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, 11490, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("285ad2df-55c4-40f0-9f21-f48fa89051d2"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6021), "Green", "xewdzjckmb g omwt qod w lbfyh w ryqvtiirc  epfg  gfpgg kov z pzhmbj amxyaddpn rv", "Laptop", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Glass", "oxpcg  qea qy t   b juuupfbslpv ltuxnu", 95446.821719150400000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, 24, 4, "Intel", 2, 26, 20, true, 12f, 19f, 9, 2165, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("39f49511-d253-4f9e-b261-7158560989f4"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9236), "Green", "tlnuf rmo  bjabllt   ouwx u gshmnluqgnxfry  bmjw    xs ", "Keyboard", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Cloth", "nyqytwpln xj hbf", 34962.570404150800000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null, "TTC" },
                    { new Guid("e443b47d-42ec-4d5b-adb4-e29f170d3acd"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9685), "Violet", "rffa kinlaawe ozjodj  siu gn h y qwzu carobnxm pr rbu qtu r jpzql", "Keyboard", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Iron", " tbqknh blbtwydcm rufjgvowxdtyi", 35319.397382121300000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null, "OUTEMU" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("fab08d8f-607c-4fdf-a73c-a187c7748311"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(4559), "Orange", " e  nhadcgidj y  ti sdfa t  stdccukvkco  fqvu  bhqqnfjg ", "ComputerDrive", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Aluminum", "fz g  r ycxwzbpq  ", 88182.382280091900000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null, 29123, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("36a1abbb-7eb1-4a54-befa-f1c5e78a94a3"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3044), "Pink", "kottg s m  gb ehhvpnx dq a tdnwfwljtbbf ui i z", "VideoCard", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Jeans", "yw  nzb aq jvneli n azcdhosa", 86990.21199112300000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null, "SATA", 28906, 12620 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("6b655257-c8b6-4d01-98d7-09d708fbe28c"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8772), "Blue", "dmv t i   jchb  xsmsaas  i zjyn brmhjs mkqm  bezi", "Laptop", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Jeans", "jm jnjcb uh ", 56628.351126158800000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null, 4, 1, "Intel", 30, null, 31, false, 30f, 31f, 1, 1599, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8050899b-62ae-4ad5-88d9-4ed513bdbfea"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6684), "Violet", " g y wca bkbb ueblut h txm", "Good", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Iron", "y  hj sxwbbtjtc kuezl fe", 76255.387382700800000m, new Guid("def41d19-c3b3-4c03-a8ed-38a7a5c36101"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("1b25d45c-5382-4bad-b253-47ae8b0d7778"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5942), "Gradient", "pe p qap kj wxcbe  voehm pbxvc ", "Mause", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Aluminum", "uf hxsqbbsexixusheos nr", 36794.700397548600000m, new Guid("55fdc444-d161-48e4-bc60-3cf622474550"), null, 1122, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("ca5ad849-eec4-4b8d-af42-4fad7b108206"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3150), "Blue", " to  omwuey  huzsrbmszqy x a p o  ktix yzt cuyjtrzfit umvg ", "Headphones", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Wood", "ofoteivyn tv bimos ojb", 1516.168006470500000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null, "Easy Disconnect", "Earbud", "Infrared" },
                    { new Guid("6976fd19-1bf9-4f15-86b1-9c377ecddb8c"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(275), "Gray", "vskgffg  j y hoj dg xx", "Headphones", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Cloth", " hft mr stpsk  s wao", 62206.238304360900000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, "2.5mm", "MonitorHeadphone", "Kleer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a22bdfb0-cbc3-4ce8-b427-e26a473c397e"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(3150), "Gray", " ua jhxn euy uevjj fzqny q smfq n  e  uzdjlxdg qf", "Computer", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Rubber", "tcie hxcreb vkxmh vro", 60688.365791313500000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, 20, 24, "AMD", null, 1, false, 28f, 3f, 23, 1946, 23f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("6158ee54-84e8-4b2b-b188-4b837a3c46c1"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8394), "Gray", "r w wtw dnotsjxkmvoegi gh bogrmlru", "Laptop", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Iron", "fn bq ir h pfrouctatf vgzw z", 69469.100082977200000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 4, 2, "AMD", 24, 13, 24, true, 8f, 3f, 25, 2567, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("23fe20eb-49a1-4b78-a097-2f5d3b0da5bc"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3948), "Green", "f kgwaqts q evqsvcs kc  ijjrhlikx d qw  pxof", "Good", true, new Guid("ed9154f9-ebb3-4687-a9b8-b51e47d3632e"), "Wood", "p t  gcno ebswm yqwwvzrwbm   slvzz", 58530.385027886600000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null },
                    { new Guid("60481f5f-90ba-4965-bca9-ff61990d7337"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(215), "Green", "l vodgdac  acafrehftysxznuceewqhtcs lle oot diuce z  qarxagmg nfgj qwjfzb d ikcmvuoz jxz", "ComputerAccessory", true, new Guid("ed9154f9-ebb3-4687-a9b8-b51e47d3632e"), "Rubber", " kckk rjds  h pg amhqxq i", 48599.293431546200000m, new Guid("0c8b5e5d-5cdd-41f3-960c-a8d1832c441a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("054c4a4c-d79b-4927-b5b3-c4c488e274bc"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6328), "Green", "jivpk sl dkvn  mrg  wbct", "ComputerDrive", true, new Guid("ed9154f9-ebb3-4687-a9b8-b51e47d3632e"), "Iron", "dopb   dicrzxt ", 15979.395441701400000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, 4321, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("df6616bd-6e2f-45e3-8263-d03e7db8e0b0"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4362), "Yellow", "mdluatgwmy nghwvsuouqh nwekuc mfr i u   twb  lcdenf vd", "Good", true, new Guid("e3db03ce-74b6-4e62-a761-922abcb1d0ad"), "Glass", "wg  cbdcpbw ", 95151.212716079900000m, new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("61eecf80-54b7-4912-a5fc-d2220b8d5ba5"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6673), "Gradient", "paooalkgr ouw q eqhrjwchw yqkihyt  r jv tbd xhqdploy", "FlashDrive", true, new Guid("e3db03ce-74b6-4e62-a761-922abcb1d0ad"), "Rubber", " hsecw wpojn m s", 69085.348941891200000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, 23, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2366ae05-b2d6-40e8-afa2-14d597d1e351"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9555), "Black", "g ostukpuzzkk kcna x r", "ComputerPart", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Aluminum", " v wm  b vkddzzictpp", 27677.590552567300000m, new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("724fa851-a21b-4b94-a06e-af0f3c56e04d"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7778), "Violet", "lzfxurq t m x jwc euycatdyfidth f eexq", "ComputerDrive", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Plastic", "jxak bh  o gtf ohfg", 57062.441137182700000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 39348, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e7cb7edf-8966-4d35-8b01-bf54a8b8ebea"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7671), "Green", "vj cdquhlr  qmib ajhk me xo uuy   m kg asuopfga", "Cooler", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Plastic", "n  mwm   x rdlhyxmkwj aehq", 31826.068475761500000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null, 13715, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("0f0a9ac1-4a6d-4c9a-be10-37600f332bb2"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7494), "Green", "zirw   bk  j echcmqqrp   xf", "Laptop", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Iron", "jnuswttqp o", 73278.889699503300000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, 15, 25, "Intel", 23, null, 3, false, 20f, 27f, 16, 1617, 10f },
                    { new Guid("9f3e550a-cc07-46d8-bbcc-b5c1f9c8f1cb"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8639), "Orange", " tpgqiqjfijzpb p vtt cegna l  snk  p al pjh xfnptqj mw b libz bmzyqci hagbo", "Laptop", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Plastic", "   e  lpufpf tqyvzn ", 95569.171940707200000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, 22, 8, "Intel", 29, 29, 14, true, 10f, 24f, 25, 2711, 21f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("73fae1ef-15b0-4bb2-b638-4eaf4c80f591"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8991), "Orange", "khzcvwtaulob iir  ovuc  d h    vpkw", "ComputerTechnology", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Plastic", "     ztkdgvdq nmrgurv px o ", 47690.320921917600000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null },
                    { new Guid("18e8790c-db0d-45db-916e-212d01930a8a"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7915), "Black", "fy epd bsagdmzytrwplr z u bovkxjxytncp kgp n veu iij cconov isd d", "Good", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Leather", "a cxbr aezhghbat", 51832.742268141700000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("4d455d95-3284-463c-bc30-f2bfb30bb478"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4441), "Brown", "kloj i gtdvmv fls", "Mause", true, new Guid("f459660a-2428-4350-af09-8419b82760d6"), "Rubber", "vprzalkimu  jac a a", 49291.411530827800000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, 34303, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1abcefa6-1ce3-4d08-90a9-1fedf2c06783"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1966), "Red", "fgxox th tjciphddjfzehknnv  ekd jkffnkyydt l p   t  si qpc fl ets wcx f srr  k vr jhi ", "ComputerAccessory", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Aluminum", "xttvl w ygl tlonca d", 76209.332782872600000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("de558809-7ff0-4ea0-af75-4ac4ef7dafb1"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9635), "White", "qbftwmnzihafkxa sxv km    wjnfuzellbz unmqhwc   jw lh h ", "CPU", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Aluminum", "qvpm oj yymvtpgksutiq e", 32866.343778030200000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, "Intel", 39300, 12173, 22542 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("2722b8f5-bd69-4dde-943c-f28946b58349"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3680), "White", " idgxrq  g vpl k j u  fut  ynvy", "VideoCard", true, new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), "Cloth", "ievacd egumy oi bpmcrxei e", 39035.843144653300000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, "USB 2.0", 19795, 28075 },
                    { new Guid("b8e5707d-fc69-4b54-981b-2188e90a7410"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3730), "Black", "xyvaotr  r beso nyguxbdto  udwu bfpi n qhk  akin  nzn z xu yz gye lguoercmgqwwzzejuu ", "VideoCard", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Rubber", "x no  q n v h  jsg", 719.16668709328700000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, "Thunderbolt", 36625, 10482 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("f2e7ce3e-26aa-4ade-a795-4b26355a689a"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6083), "Red", " vafwj xsmzq ahosxn ptl au m pdp czstugewffquswtsye a b ay ysgv ffjsvwb xhzv   in qyj ezmq", "FlashDrive", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Plastic", "mqscqcusq u wftfvpo", 85592.175035547600000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, 21, "USB 2.0" },
                    { new Guid("518e976d-bd89-4006-b5d9-4b82fe7ba72e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6730), "Green", "usebxeek rvxtv    zizwzomb emik  w etxuk lt", "FlashDrive", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Plastic", "x  qe gv llzf a", 52366.560163147100000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 23, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("34f4e39f-2fba-4570-b24d-2bb38938804a"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(718), "Blue", "tx  y yr yztolv mwybffi bccgaenbvzpy luuco i  kzdeflbiyghc bjxuf qwmg rswx  jpq oxesiwml  ecw onc cfgpis z", "CPU", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Jeans", "dkr    aphwavap x", 50468.79316236300000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, "Intel", 24412, 32341, 34483 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("555415ad-4556-4265-a37e-89fae5d4e895"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5408), "Yellow", "rub r mld yhu u wqto ogti   rm s ofmka  mw cssff   iawyowyn ", "Mause", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Leather", "qynxsskggif m", 60564.47963256600000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, 20602, "RFWireless" },
                    { new Guid("8a924e95-7ee3-4e29-b2f3-3adb8a7a6010"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3993), "Yellow", "urdd  qnvtcfuo cfpiq   qos jlhygbg x  bnyocwe ro ga yb uzg g  rm hzmz flilm qzovjnavqk wt i s", "Mause", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Jeans", "d we  ygblyt   cl   uvhnqtx", 67977.39708236300000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, 23682, "RFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("bad4e4e3-9874-40c1-beb4-fc3714488892"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6207), "Violet", " a  tz kbslwjpsahfkgmd gt jqua gnynlo dbogikvah umje cgua  g hwt  ra upb h fp ehruafygg", "Cooler", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Glass", "pc xq n dwgwf ", 74733.193765735800000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 2358, "Case Fans" },
                    { new Guid("508bc615-7e4a-4c4b-9fe6-a28e597a9dc1"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7514), "Gradient", "   t derrdufbfch iaja n", "Cooler", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Rubber", "eji kr h wsyg my", 45040.315643437400000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 4719, "Water/Liquid Cooling" },
                    { new Guid("87b78e7f-63e3-4c3e-9dbe-791e8ed46a81"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(9178), "Orange", " zwkgr  otax ycz am   izlbvz rt gox mo uglb mkxmvfav qfpi", "Cooler", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Glass", "kc jqsi gpzdnckh  wj ajzljupw ", 11635.083198377400000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 12769, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3f3ed6e3-883d-429f-912b-a91577fbf1cb"), new DateTime(2021, 2, 7, 12, 6, 15, 198, DateTimeKind.Local).AddTicks(701), "Red", " v q b me  v b  kf  novz  h  z knp  r ", "Laptop", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Jeans", "i  lcxa xqu qwwy qu ", 35943.851496998200000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 20, 22, "AMD", 4, 17, 1, true, 15f, 14f, 3, 2123, 26f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6e9caf66-5b4e-48ea-886f-52639497f704"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9117), "Gray", "h r c kwbmaam oryi p jzvcqf  ok kb zl  evrsqttyyluqs h  zv", "ComputerTechnology", true, new Guid("642d1b54-a893-496d-80f4-333aa2f4b1ee"), "Jeans", "r mvguorkybzklft zulim", 22925.144770613500000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null },
                    { new Guid("f06697e4-a194-4f22-a6b4-e76e8f38ed17"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(296), "Yellow", "  o ww sp wdklmlheu ta dxas sp jk uu  mhvqeiorosl yiikiercinwh fbx  ii  rm tdjhhj by dsmeol r  ", "ComputerAccessory", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Leather", "bomwdudamw gxwpi  j", 98772.731376240400000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null },
                    { new Guid("9c084c28-f26a-4359-a571-03a4d5094989"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4495), "Red", "uhlmmiymoxncvu no relf hp", "Good", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Iron", "h rhxnsxyx o pjw", 58179.750506849800000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null },
                    { new Guid("0206a60c-c0d6-4230-8b62-e72abd6c80f0"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6509), "Blue", " oftngbton n scuhtj k i  bu    ", "Good", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Iron", "z t a exmycuxhvsjnqgnum", 29555.191858464500000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("0a3e14ca-b8c6-4fe9-8121-391819e983c4"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1593), "Gradient", "   dal mmxpmp sedoiyziocpksxop z  h fgh    z", "Headphones", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Rubber", "rbmq wou  fwa  j   cyzfxmfd", 90685.797711222400000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null, "USB", "Headphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8e98dd69-b804-48c7-822b-27b9226a3efd"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7073), "Pink", " av csq ikj  ch qzks p  w u ktr  sjg lyedg", "Laptop", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Leather", "gneebc h  xkc q ls knxlm", 92036.710070463200000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, 31, 1, "AMD", 9, null, 30, false, 26f, 18f, 1, 2163, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("872f18b5-7304-48c8-b731-41a6e4bc5461"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2915), "Violet", " h aikxulejledid mc ", "Headphones", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Cloth", "grk  rd bsagnsz", 86319.994081892100000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null, "Quick Disconnect Connector", "MonitorHeadphone", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e42b86ec-ec9d-4577-a192-570ab0289ff3"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(168), "Red", " b  drpku sndmhsqiqovxp hratuinx", "ComputerPart", true, new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), "Cloth", "fyxm h  et ws gytd ", 23691.882297253200000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("4b36f831-ff97-4e2a-95fd-c01080a6857a"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(9064), "Red", "prd  qr iff kwuya rc zilz  ", "Cooler", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Plastic", "med i ao  mrsctg", 11570.970067554600000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null, 10003, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("9264ecec-25c2-4980-8f86-a778f4049242"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4195), "Orange", "eduqzhuzvuid kc twx b jn rhkd tj x   db hfqrykmdoxqa ivcd lh", "VideoCard", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Leather", " ba e drowhqv ", 18800.88067557700000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null, "Thunderbolt", 26546, 27343 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("776075e3-3af5-4ab6-ba38-1aa8137f5355"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2137), "Blue", "h  tjg ky  k t  y s  xybou ayhjztqrojgcj i jn  moca rclm", "Headphones", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Rubber", " v  f   lulklp ebfj ", 82612.070153752400000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, "RCA", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("954dadaf-746c-4746-805c-464906b91847"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1021), "Brown", "u dvai jc   y lf hroclrn ktkjbwj lhehsqewozespt hlcofazkdm fnnc ebki    efbzhtbh kajptl  vx", "Keyboard", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Cloth", "d tg  mqtnavrlavo mn  nm", 40815.699538595800000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c2b18c3d-8bd0-4489-8768-a63fe4321598"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8365), "Blue", "kc t qytsmp  k xe xwmyhjaqci d  li qb wnrrejulvt rv qdmjbssh j hjysq lp", "ComputerPart", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Glass", "tgc efe o  nqsvl rcm", 79469.379028058300000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("d26a856b-d9dd-4368-9a9a-60d599542f9a"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2093), "Green", "uayj  f  jchttuvp c gt a jshnrvq", "CPU", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Jeans", "evy ml jrtmvgwecwlugu", 51611.780399275800000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, "AMD", 17514, 5251, 16153 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("ebcd4284-9987-4c31-a118-d17f5b33edf8"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7405), "Orange", "xpuffqyteky a   zhx mwxkkwt elppcfi", "ComputerDrive", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Aluminum", "tbr vkekyoieyhf e oabah", 23776.825295657300000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null, 34935, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("033e954f-cca9-4ba3-956c-7f070630cdce"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7769), "Red", "s v kxlnmabtc  cfeuo xhuir odlzbl g p vytxadew  ", "Laptop", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Aluminum", "inbse ug g wuanogyrt", 1089.4594253457400000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null, 21, 19, "Intel", 26, null, 12, false, 9f, 10f, 25, 2136, 17f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("702b1ca6-814f-405b-9e59-2945b613e89d"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(486), "Brown", "kzam h hb mseyojmhhocmfb f  ", "Keyboard", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Wood", "i  g mvrv mafpniu", 39260.152093721600000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f5b22b36-57b5-4c87-aa7d-af01647d3268"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8867), "Orange", "s vobiwx   woxtz j ", "ComputerPart", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Wood", "mhewt etk tk m  h rum", 3366.604122969600000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null },
                    { new Guid("8d0eff23-67f5-4dda-b1c6-574ee76242eb"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(789), "Gradient", "r  lapqu lt    n zdnqvckln uvxwx fjou ytks k   x", "ComputerTechnology", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Glass", "uzci  p   y bhuj zkqb hd hb", 27697.650356077400000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9054d576-c3d8-4548-b0ad-7bf4b705367f"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1866), "Violet", " jpbgtzvp rkllndkry  xis  fvpisb vkrk  y", "Computer", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Iron", "ltlxvbzaix grkitlnjzz", 90199.441923852800000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, 31, 27, "Intel", 10, 18, true, 15f, 26f, 6, 3170, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0f0ee5b7-0b0f-4dc2-a8cd-1543114ac641"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4806), "Brown", "mupkvbd sytmobnjy iwrm emtjgcp gor pqkudhlt  tcvbxs fm  s i d z qjs ", "Good", true, new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), "Rubber", " dov  kll ", 97503.843716114700000m, new Guid("5a60368d-a649-455e-9194-fde23b591e85"), null },
                    { new Guid("039a02db-b3e7-48d0-9438-a81420c2fb24"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7670), "Violet", " f jvyhsvja a azbzywieicxg oba  pga qp md o qj ", "Good", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Glass", " xmuxfknswj tq qvmib m jhzg", 7537.6268977008900000m, new Guid("5a60368d-a649-455e-9194-fde23b591e85"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("a8c26b8c-5476-4d06-aaee-8a3d7f36967c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7414), "Green", "ok nbhkdogt lxn bq midq  dmhhesuyrtj", "FlashDrive", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Cloth", "hejwrf  vj u fobwzcitpt kuzbykrjb", 78854.30472849600000m, new Guid("5a60368d-a649-455e-9194-fde23b591e85"), null, 31, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("123d8e1c-845f-49bd-bb94-23099f6e0409"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7714), "Black", "imr evp  upnjmdcm gdwhfr  osvt", "Good", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Plastic", "dzpsw  cr zrg p ", 69986.556177021300000m, new Guid("e1523adb-b064-48c4-98f2-e924eea3e718"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("4b142fda-f62f-480d-a363-4242a1f39ccd"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3637), "Red", "z ruylxalxskq w cabk", "VideoCard", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Wood", "f mgr  x q   xnks", 63105.122495025900000m, new Guid("e1523adb-b064-48c4-98f2-e924eea3e718"), null, "USB 3.1 Gen1", 39257, 28551 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("c435325b-a9ec-4edc-9168-2f9ade1af06c"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5295), "Yellow", "w z diuktynevjs ach  bozlvt q  v w utnhas sijmowrs immbgr  ", "Mause", true, new Guid("df03be55-2cc4-4d2e-941c-a774855d0938"), "Aluminum", "gkd n c  httqgl y  ", 78720.603826791300000m, new Guid("30c2dc94-a6d7-47ea-8fbd-ce44806063d8"), null, 4244, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("016452ec-7854-48b1-8504-65fb1330f36c"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1355), "Blue", "l   zmx um r ifajpp uasrmtjfcufu skve y s  e  lbjhxagaj qi j z kd ia f", "CPU", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Jeans", "  uy r ertblm mdbqp oaprs p", 93273.536904376700000m, new Guid("30c2dc94-a6d7-47ea-8fbd-ce44806063d8"), null, "Intel", 16865, 25863, 35926 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1b4bd7c1-7c9b-476a-8b5c-3fcef11608bf"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7428), "Red", "i cecefenqknx gn fpu scahrbs bw  eg  m e dvsmnh tfo jwb ofxj", "Laptop", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Leather", " p  fcy vjolplols ", 91669.547274554900000m, new Guid("30c2dc94-a6d7-47ea-8fbd-ce44806063d8"), null, 13, 5, "Intel", 28, null, 27, false, 20f, 24f, 31, 2301, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f9b623bc-d5fc-4d26-a028-dd2587d95694"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4648), "Gradient", "mncetn  uf", "Good", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Iron", " uz d wbhoqels lz ", 88954.341499579300000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("97ee8dba-51cf-44f0-b51d-a1161fa42a7b"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1782), "Brown", "g jj  kq io n  mjqwccgv uhpkcz jnqhwzlraowvheoi", "Headphones", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Plastic", "p qqtri kulpcztuii  y", 95695.992557190400000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, "USB", "Accessories", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cdc33170-04b6-4d2c-948d-ee942ec22787"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(264), "Violet", "uc f hq rsudf fssiwgy  d rdy aq  aspiuvva", "ComputerPart", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Aluminum", "dr du bmgltkgs ", 74547.899828547600000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("6a1f548d-1ef7-4f70-8144-246fa672c07f"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2142), "White", " zsp n  ft cl ri j  fihtuhsnnmyv sff tijrgf zxxm sddnza", "CPU", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Plastic", "  qpbcaoetd", 55220.634795362400000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, "Intel", 3539, 33259, 22207 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("af4eb5c5-ab9a-4296-938c-1ee37e6d2e4d"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(4748), "Blue", "ntzi ynnyqryts k r fo  vx b  lgmtckvd cbm mdkf r l y  nmvnwiq e j", "ComputerDrive", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Wood", "qz queyrbfc vis su  ", 58101.34264552100000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, 25760, "2.5", "HDD" },
                    { new Guid("f1863529-b071-47bb-949b-5684bb98b029"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7711), "White", " sq rtyza s khkqcnkgrfvlfstvg  j a jru usj mqi", "ComputerDrive", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Wood", "vhndrosu xbiejfcv  kclg jwktza", 73180.776775433100000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, 12147, "1.8", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4e3a447a-71be-48ac-987d-46b063f9b446"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5581), "White", " n k blsjd gkhpsxq qedcsmegv v  ohpctgmwy ", "FlashDrive", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Aluminum", "p nagaaxunpzb  j    v  z", 67931.955292789200000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, 23, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("5721d27f-1df6-4667-8c3a-fdf377548e35"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2248), "Gray", " f fwscbetaz agnu j  tkgubtciqbcx ow e jmfz xgobdnly", "Computer", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Plastic", "mcwkcgeduo qyjhenwjznnougjt", 5784.2230916881100000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, 18, 16, "Intel", 7, 19, true, 10f, 19f, 1, 2536, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a2e90029-42af-4e95-b7de-b16100f4e02b"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2952), "Gray", "ti k q xyotvhtiwzmn jlqj szvdemn w ati kc  gz dikpacyrtsep qm  msszrw cmo avpt fxogdc  jmmjcc", "ComputerAccessory", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Glass", " pue   ovq   mm fawtqmaco", 27745.546413467100000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("7c233bda-a13f-4841-9ccd-51aa622b2c87"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2360), "Orange", "nqr   vmfvfu l   phuglzgkmstwzdbsg", "CPU", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Aluminum", " msixgh ibcoa ny fh", 59220.272888997700000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, "AMD", 34594, 38144, 15803 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4d6f0fe0-f6aa-4d2c-a60a-1e0e02dbadad"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6782), "White", " cjb   k fsonc plajbyl bgnpsp ngci os z l", "FlashDrive", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Jeans", " cx bxa jdzuuc", 56118.34700969900000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, 12, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("776c1aa4-ed18-4477-98fe-21dcdd8d478d"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4066), "Brown", "oqvvs dhugjqqhxgzn  any ge msg tg  qlx mneygubo hs jeavlb g vrurv", "VideoCard", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Iron", "g x    pxqyik wyvvrgstv sbro", 24474.808585119800000m, new Guid("5ed5809f-5038-4474-803c-7b27294346bf"), null, "EIDE", 32376, 7543 },
                    { new Guid("5826f92d-4e78-456e-bc19-15af23de38e2"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3454), "Yellow", "vr dp dtpftdm pr kvns s  fn p tvvvadt pzgyvtz tb al j g qpxbi", "VideoCard", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Jeans", "fkqbpb  noc", 92903.856510717400000m, new Guid("5ed5809f-5038-4474-803c-7b27294346bf"), null, "USB 3.1 Gen1", 14709, 15519 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("08076ad5-5030-40e2-9fe6-8ef8b68a3fd5"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(3274), "Violet", "psqjxyq z asc wdx  qwju  q pu pgeghpbskyve fj", "Computer", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Glass", "nlqbhtu mtrmhkuqg z kpq", 746.13397044415300000m, new Guid("5ed5809f-5038-4474-803c-7b27294346bf"), null, 14, 13, "Intel", null, 4, false, 14f, 4f, 30, 1283, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("262cd2f8-fba3-4588-87ad-e15c0be99d35"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9612), "Black", "tsz pziravdt oao av wib tg  wdqb oevscc ajbscmh  ", "ComputerTechnology", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Glass", "utejnfr  g jersi", 77537.817264691800000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("756c33dc-85d9-4877-9928-d8453d440660"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4722), "Orange", " jdymws h h fh  dvqr kw gn ectujews", "Mause", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Glass", "f l  jfv  lh xkou", 74124.377441650400000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, 5649, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("3f216654-6e76-411e-87ba-990f0d606635"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(819), "Pink", " v  zj eorinmmbe qfikdbhv e egku jg   buup  u qwzo ob", "ComputerAccessory", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Glass", " vmqiar oj exjl", 2516.4045405184900000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9d237cec-466a-490e-864d-6d80db8fea79"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6568), "Black", " mr   hsxyosxn  zy kgx  vv zte   lpoekymek x", "ComputerDrive", true, new Guid("e3db03ce-74b6-4e62-a761-922abcb1d0ad"), "Rubber", "z  h b woo xornsgou b ijd t", 38767.958403922600000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, 6432, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5888eda1-206d-4061-bc2e-f4b7bccd1679"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(9024), "Gradient", "ald tl jw  goiakwh", "Cooler", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Wood", "ka htzalb  fvxj ymafxyy ", 59021.805300853100000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, 5595, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("55470ea1-5e47-47fc-b4ee-8fda4b3e5654"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3395), "Pink", "v  ok n  wsc sck d adjkwmst p sx wtkjgif htdd", "VideoCard", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Plastic", " updtw  i ffvughor   bw m", 27666.647745141100000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, "PCI Express 3.0 x4", 22590, 25710 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8e56e2fc-9246-474b-96b6-be29e010f649"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6111), "Pink", "hae b  skbxafxjs ft  crwxrrx pgdhi ncpsmj hrizdhjvn  b c  wckxfvoasdb", "Laptop", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Plastic", "mqpvz ymaufo", 35767.753485482100000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null, 4, 27, "Intel", 10, null, 19, false, 6f, 10f, 22, 1054, 21f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a3707507-b56f-4837-b850-2581ad0ab9ee"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8401), "White", " bg vpvhhylaiwkbwxjpbz fuwlqgguqex qlk zwx ujhmivfpqv", "Good", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Leather", "nagveoauuad orz m", 61237.699008191800000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c4e0a2c9-4d2d-470b-82f0-f0ed5121ae79"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(314), "Green", "ieajxpevlsummtmg tk  j adi z zkiat vf   g w vi", "Computer", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Iron", "aoeqrj  emutebefegpd y", 18116.673230247900000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 5, 6, "Intel", 1, 25, true, 12f, 25f, 29, 2463, 17f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("dac200f6-5a13-4f85-8f77-93dfcc8b273e"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1184), "White", " ro zc dpw  r t", "Keyboard", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Leather", "gxf nfnt qdxclanwpx uk", 39685.510583075500000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c3683173-e9cc-4a49-9dce-87565720f4a4"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7077), "Pink", "xcf jsqf  kruwlawjcksio k jw dt riusuumv   n d", "Good", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Iron", " mtf dtxzrr aupu nq", 24787.747545534600000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("780d0901-10a3-4d91-8e0b-c7c2d2c8fd6c"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3202), "Green", "t gtd znkdh  oeu liulephfh  u ovlbxe f ce  zju h idlvhy jx", "Mause", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Jeans", "iqkuxi dybzje wc  ykl ", 27525.297751429200000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 3105, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b6945418-190c-4a0e-a1a8-8b2c16ca72be"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1668), "Pink", "h qbc zfkpt mnyp  jj uow t  yfnb  pt vqci a  dzdmv cw uwlkgqifjx        gqnsubpipc syzziloh l yfgn ohs cjhby", "ComputerAccessory", true, new Guid("947b462b-501b-4af2-a97a-f30580e2f46d"), "Cloth", "lp rshrqi p  ", 98007.484477948200000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null },
                    { new Guid("0b964d9c-7377-46a9-b77f-83e949f73ecc"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2528), "Gradient", "e ehklv vna mzwrbge qjxx zzkwl xkpsunkggnuoz iggtmrrx  q whx", "ComputerAccessory", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Plastic", "n  eg  exn cjkop   ykmrbcuwz", 94190.318460664900000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null },
                    { new Guid("fac62071-255a-448a-9a4f-dc9029a61400"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8780), "White", "cvgm rzq oc  lf yydyifa typl xq", "ComputerPart", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Iron", "bt b  row qq  fgjyxb sn  ", 7952.3979723231900000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("c3d08d54-10c8-4373-9786-e68b3f678a78"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9282), "Pink", "gt   axl ixwenauvakkmcktus av hoaes o   ngafy auk evfi jup kzhf  vwyuyxdtj", "CPU", true, new Guid("f459660a-2428-4350-af09-8419b82760d6"), "Plastic", "powoqtzokin mce  az lb  hq", 78298.376257670300000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, "Intel", 24139, 21076, 36372 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("5360bacb-95a0-4f52-8d6b-6aa4c4077361"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7475), "Yellow", "ju js gr xygub ty jmndv h   gtg  kg", "ComputerDrive", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Wood", "emq vjkpukvtjp by ogguq", 95557.037692310800000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 17167, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9dc2232c-f3fa-430d-9747-96c19f57af1a"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7850), "Gradient", "i sa  s x  op  ujvnwtw q c hrgc ife t bifco p  ocu kykprry bfn", "Cooler", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Rubber", " c  rhpnmuebze", 61157.311294766800000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 35979, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8674415a-48f3-4716-b0d1-0e398087f3f8"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6511), "Green", "qjb mby  cv g kcyexs", "FlashDrive", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Leather", "  ktfjg ncoixudt", 80476.778829692300000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 17, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7d9f3953-5ed2-46ff-9a66-c98d04158d1f"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6513), "White", "x bw ns ke   n kq", "Laptop", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Leather", " g uytaeuncebphlaxvil", 7318.6681174294400000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 8, 16, "AMD", 3, null, 11, false, 9f, 24f, 7, 2319, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("87aae45d-b838-4f16-a94e-3cafa1a1a4b7"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9255), "Red", "meegr  ue  cpxjigamtzl cv xcfdsacob", "ComputerTechnology", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Wood", "mby  fqcppdjmtb nz tt", 12554.710969587200000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null },
                    { new Guid("73ede7b7-17d9-4f01-89e7-534a1ab5c844"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9476), "Blue", "vy  kngmuc zy eie vk pletjt d s   btpqk glc pk goun ji t lv j", "ComputerAccessory", true, new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), "Aluminum", "w egw   kdljogu   xecgpyta  ", 23582.792293086100000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null },
                    { new Guid("c095ce3d-53bf-4e7a-9adb-2ed307268a50"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(129), "Pink", "vd o mc dtuzw ivso xj", "ComputerPart", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Iron", " neh  a kygdrjp  kr", 10145.661006749400000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("41b3c132-c2e1-4323-8fa2-06b0e7801af7"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9858), "Gradient", "q uij xsn nt ishdo ai ldek a s bh vmp ji  hanu usfejome dqis  qe jcwckbbhlb wq tgl tdm zxhu", "CPU", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Jeans", " omhlylina iuxu", 89172.339248085600000m, new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), null, "Intel", 35627, 20463, 20375 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("e842ad4c-c69d-428d-b2bd-a9b714e6b269"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4359), "Red", "c j ytdohvz cl  welha w  iaurietur w o sto qli oicn ys qihj u nhuxa    tmkhco    ", "VideoCard", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Aluminum", "ank llsy lac  ", 40224.412614584200000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, "USB Type C", 32183, 33959 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("62580147-eff5-4a03-82e2-7652cccf0859"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3284), "Red", " b bklebqqyloct grpnudj  fvw w  sr", "Good", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Plastic", "i uyoi   yjto   lr  xerc jc", 6381.091012796900000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("905397ac-4a77-4741-a359-8709c139c6cc"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(440), "Violet", "dv fnlasmt vghvymqnh  gad on  fk osnw e ipxano h  eoznp  nf   ", "Headphones", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Jeans", "    r yiuw ehjo  rj", 67912.677474279300000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null, "Quick Disconnect Connector", "BehindTheNeck", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cd249843-9189-4445-a198-2c0396bec36a"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9830), "Black", " rpdxzmd p g", "ComputerPart", true, new Guid("d51e3ccc-72a0-4b57-953a-93935227aad8"), "Glass", " p pr   cx", 54948.182895289800000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("3b0aa723-e622-45f5-ad54-d0d71d710ca6"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1243), "Black", " n  id lmds z r nyh bkmtfuls  zudp yilq ye mdakuth mwvqwo sc", "CPU", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Plastic", "ds e mukqpe sp o ", 22262.909832532900000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null, "AMD", 28535, 19691, 17407 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("9be7ad68-24e5-4ce4-a4ac-8ca5424a500d"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8211), "Black", "bqtndw kq qnrmnqaiysydexl mvaz   ow z dns  nb uy wsfcbrys lprdq", "Laptop", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Glass", "u d npwawhngkxophp", 85790.320292948900000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null, 12, 7, "AMD", 28, 28, 10, true, 30f, 25f, 6, 2968, 14f },
                    { new Guid("a1e89ed7-2e16-48e9-8d3d-b1b7dd38bb1e"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8350), "Gradient", " r  gg vqoua o   m", "Laptop", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Plastic", "jrysvsb e eukkyt izeg", 80230.791950705800000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null, 28, 29, "Intel", 30, 31, 10, true, 14f, 23f, 9, 2864, 6f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b1483ccd-dbe2-459c-af21-c7cc79dd4b0b"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(183), "Black", "  iwuuyk iids  ", "ComputerTechnology", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Aluminum", "figsadpy glekipvxch dmynpd wk", 2737.6083204232200000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null },
                    { new Guid("61b584e3-26c1-45b1-a3d0-7bcf686ed875"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(1016), "Orange", " a ev ltrjrnjyqe   gwy q wmc     dl t chqy  vpjxggk lzpfy", "ComputerTechnology", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Glass", "ymt zc idts cd", 56754.798980781200000m, new Guid("e7433eba-6032-42c1-a509-9cdf6ddfe9a8"), null },
                    { new Guid("b1a17147-742b-4ec8-9e8d-ba47a1489c31"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7282), "Brown", " o jj gqsfzahjkp nrtffhfxf  vema", "Good", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Wood", "y q q i a s ip  ay ", 39296.427387416600000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null },
                    { new Guid("ca22d39f-511e-416a-9af6-cebb80f5bed3"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7756), "Gray", "hdd  gvbjilisi wxmchx kno dc p xglh cm nhmnpkqablkevov u", "ComputerPart", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Leather", "iung j g p  ljojyqex", 50013.838545425700000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null },
                    { new Guid("6d191a88-4409-4af6-a0a6-58099fda1762"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9634), "Gradient", " yxfbhmwx  y  c hlzo ekr kkyw n duec   x b zhj", "ComputerPart", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Leather", " v dlh qbckk ", 42610.209455066500000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null },
                    { new Guid("d5154fd9-9e16-492e-8582-30405cc8069b"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9683), "Red", "bxjrs  taamh w ovfhhsrqmkofc zhbtlp h on e", "ComputerPart", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Iron", "ytrld ey  aqxnf ", 52701.651376067500000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null },
                    { new Guid("3ecd7ead-e8ee-4329-ba43-b351b201e443"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9910), "Gradient", "rljmbhdsu l zacuzruz   hzz kfatcflgpavsaoffesic zqylre vohiaex pl x dtlnzz hwqjyyh j", "ComputerPart", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Aluminum", "anlwdra g g hm  l mp o", 70743.384105499600000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("64287ec7-b898-46bc-a7d5-d00fca9b54e9"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3887), "Gray", "cipkmgvivnu  iwxfxjk pro  wbkn vuzwn  b", "VideoCard", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Leather", "m vkf u emm", 13634.873607025900000m, new Guid("d8a526ca-b8e7-40fa-b4d8-b68e9c542140"), null, "USB Type C", 34834, 13523 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("287e54c8-41f7-48a2-b2fa-d0461ce9a215"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3733), "White", "   l if unpyk eroht e p tuudc wdk zfc xpot fmpa sc f q tudvvlk uajjv orwn lk v qlxaoz q wmxk j ", "Good", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Jeans", "tkuost akgc hc xt", 98673.952044301600000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null },
                    { new Guid("efd99608-dbe3-4745-a9f3-f48f36d5e84f"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2121), "Yellow", "by k imlukpo nlu  yl  ysp qua i kz", "ComputerAccessory", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Rubber", "oowl  rkgznylxpmrpqknoq mnitmm", 23888.548288442400000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null },
                    { new Guid("02a4ee3a-22df-421d-ae9d-8d4a2ea9ae8a"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9594), "Yellow", "jwrgwj qknrjzuvlr chbo", "ComputerPart", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Iron", "q  bpgumzf ihpecgr o", 99886.277038551100000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("7bf7ac29-49cd-4bde-9798-a51fcd75003b"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(5988), "Gray", " csyvzs ltadfe   atrsdfgbrbh  weeypczsyvz u", "Cooler", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Wood", " mvpswac dyiw y j", 37291.114375596400000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null, 3793, "CPUFans & Heatsinks" },
                    { new Guid("ca8f57f6-6b37-4d74-b9f0-7e4edaf6c49e"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7289), "Green", "oy b cpkoyovkuc fu ecrpz jpfpxvx lbtwc  z wqrybnln ky jbotnmukoxjb d bjrtdh", "Cooler", true, new Guid("f4a7f078-6686-416c-9628-37f246712b39"), "Aluminum", "dzvj qxhro ma  v m f", 90203.160648328800000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null, 9900, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2e5e9956-b6f5-4339-b467-3cebfbeca095"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(296), "Blue", "uck iacykwk thagl  pc  cvf ceuhev sf xkkql  wkk anqdz b sjq", "ComputerTechnology", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Wood", "kw c fnzokksvso u", 45646.887293852300000m, new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1ccd28d0-b733-4e11-816b-9a2a4815410b"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7650), "Pink", "rlxjt txtumnpc qskbzlcswf   n", "Laptop", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Iron", "x vtdwsxx ngrhjb", 2160.2484407649600000m, new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), null, 13, 26, "Intel", 17, 17, 9, true, 13f, 26f, 28, 3086, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("be455a6d-12bb-4905-b5bd-a4c0ad84af74"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(991), "Black", "rp lompji i u pabuya u sxmzy n   d  jdhpflmd i  wyn vkgp d lo  d brxlmeupxxus   j  itrqlypv   np ", "ComputerAccessory", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Cloth", "rbjavl low ymfhjwu bqh mj onh  ", 76835.889079065900000m, new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("1fea658a-d438-4759-a7d5-4f310a384585"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9761), "Red", "oggxdys t j ykbmy tmyr kk", "Keyboard", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Glass", "fsr qu rq gh  ox", 72704.71070553400000m, new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("bfe0c720-7630-440e-8143-88299a5e5d7a"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2824), "Black", "ikst lh   p  tay etlxtifyq   osc cpm qjptjvbib s   q  ", "CPU", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Rubber", "efgldny  jxr f c", 29841.036922224400000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, "AMD", 7350, 14292, 32421 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("8d28b4f2-2ab8-4a61-855e-038af7a8765d"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7065), "Gray", "wlmh rl r c t  hu", "Cooler", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Jeans", "h lwagknkswzykobxd mwid vwpg", 18416.232857115700000m, new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), null, 32419, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a2a0c1f3-3eee-4671-8bdb-8f9466532b63"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(5818), "Gray", "zl  egd kya xdsrikt yndjztrv  fb dckay to ubln  ckgo", "Laptop", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Glass", "bfvczolu m   nhfiogh bbd kv", 86314.441071038400000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, 29, 28, "Intel", 18, 2, 14, true, 23f, 7f, 19, 1322, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2ba6c25e-f640-46e4-8563-cd020cf7e89c"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2953), "Blue", "goi ygb p k uhnktm wtjcupmghw q esjppdhih akut wz us z q gxl", "Good", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Rubber", "tpuhsm r yojpwl", 61709.741764566700000m, new Guid("fe045ea0-11f0-408e-be49-c1aa33752030"), null },
                    { new Guid("7da81d7e-3a30-46d5-a6aa-6d4f668b734d"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7131), "Pink", "ry vb twdgy hhlyexiwbmpmcm ixsh   wioqi p zd   bn a", "Good", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Aluminum", "yt hfkymfajcx", 38355.325040572900000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("762ebe69-df1d-40dc-8ee2-2a3c06f6ddcd"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1892), "Pink", " gbzwsx gqramtu  xd prn gcfr", "Keyboard", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Plastic", "he ovk hqomug ", 7078.6287109733700000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("48b38a6b-f278-4a10-a015-7bc7018f3257"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8670), "Black", " jqy syzt  fz wi itcy am tc k sf ", "ComputerPart", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Rubber", " m  ugz mp m  rnwiy  z vdssb", 70227.74558059300000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("852dc7d7-353b-4bf0-b971-0b667a2e5d35"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6818), "Black", " owqusjcn dercoq z  zvlyvpdonvp m j rqyfswtqbmrg ", "ComputerDrive", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Wood", "zwk q   rar  z", 94770.235100188400000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null, 28171, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("461712c5-b9d5-4f54-aecd-17b1522a91fb"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8156), "Black", "fnzvukxpg  gkvhd jhcqbmik  yzkyfcs qmlxf wl upq vo  jcayy  cv", "Cooler", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Cloth", "  ksigaesrfvs", 82100.786772603600000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null, 10333, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("c491df95-1410-40ae-8e2f-2aa2de30de84"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3281), "Green", "gpcd b h tel  q e  wnrgh  ecfs kmkxs  v dn  ", "VideoCard", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Jeans", " oigt npognowsl af", 56114.934830048600000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null, "USB 3.2 Gen 1", 10752, 18819 },
                    { new Guid("760cc4b3-4aa7-42be-a2fb-c68798c3ba44"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1584), "Orange", "mvaxr digpqxxz wpv wlha s wdnjob", "VideoCard", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Wood", "qaya i  xujrk nirvlvv", 71411.87087232800000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, "Thunderbolt", 28946, 14527 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("b8e19fb7-6ed6-4d85-9edc-801e2f9608bb"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9148), "Gradient", "   xpmcxajfin hg", "Keyboard", true, new Guid("642d1b54-a893-496d-80f4-333aa2f4b1ee"), "Plastic", " vrsnwtkylv gw eaopvkao", 88056.95198851500000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, "OUTEMU" },
                    { new Guid("fb8900e9-355f-4aa2-b503-715a08861ac7"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9949), "Blue", "mw h zzocaj px jgsu o   uwehnlwzode", "Keyboard", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Rubber", "ss g a wh jvz ", 87390.40395589100000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, "Razer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("2a2d103f-3e25-44b3-ac58-ce15dff01e92"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5361), "Yellow", "dpubhprtmrjtc  q myz", "Mause", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Leather", "rlmhduoh ba tkagq  c ", 58937.524426233700000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, 28376, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("324c9914-e073-43fc-bef9-82bc5525ca24"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9209), "White", "kjs l iruk seczao  l ne rn ldxauv", "ComputerPart", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Aluminum", "b  regxwfaky elrsphwpw lc", 60344.47725878300000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("2c454ee4-edb1-4d93-904f-b1cbcd68db99"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7016), "Gray", "aychmvq  kf mv shz wqdfzh u p wom  en", "ComputerDrive", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Rubber", " afz kix uvw   nv tarvn", 446.50835937192100000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, 36442, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("196d477d-29e1-4390-8af2-f88a6662ac7e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5315), "Gray", " hhgfinqmwevzkjz dl rm   gu fccmhgi v rwmbmq   kztzofglnbwkjv sj hichfyk tj pcl umzdfh si", "FlashDrive", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Iron", "umym     bptw z cm", 14639.033197722900000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, 8, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("9a8de19e-9138-4d1f-82dd-73c045cd8225"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6239), "Gray", "snzehphyixcv fqqsc imyrcciwx bew  usbhqdmnnngn", "Laptop", true, new Guid("50ff21ef-852e-4277-a016-7a55f0d5f322"), "Glass", "r l rjqr w iga", 18444.565133398700000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, 16, 6, "Intel", 21, 16, 11, true, 17f, 4f, 31, 2203, 17f },
                    { new Guid("2b378aaf-68e8-427f-893b-6a635f1b590f"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7175), "Yellow", "ofyj j v vqgcreb wcjjrbs tvkgbpvsgm", "Laptop", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Plastic", "hk  tqhd ol et coyzc", 30040.536462348200000m, new Guid("21e33721-f9c8-4bf4-997d-094a776d5367"), null, 12, 15, "AMD", 6, 19, 14, true, 1f, 30f, 22, 2011, 14f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("db536119-dbb3-4968-8077-96776c4534b1"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(563), "White", "czd wxyx fsm fu nqqlnj", "Headphones", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Plastic", "qavpbqd hjatfr ", 46727.770914662500000m, new Guid("708e77da-7972-4e7d-bef8-f94ab95bc3a9"), null, "RCA", "MonitorHeadphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f9a9188d-6c2c-4d04-a79b-c4c05e040349"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7537), "Violet", "tkundzqcp ii eslubvntnd  bbjh n nkqy  yusrasvh", "Laptop", true, new Guid("49ca2615-7fd5-40dd-9643-5a6df35d0716"), "Cloth", " twni t zay", 37715.214555019200000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, 16, 20, "Intel", 26, null, 22, false, 29f, 13f, 23, 1880, 29f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6955de9a-a661-46c4-8d64-4ad4c325ef8f"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9143), "Yellow", "oqwne xirqv   ul ktve hq tmnovigftnnjdradbeuh    bwhwwkni pil ", "ComputerPart", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Plastic", " mutbe  d cthl u  ykh zz ab", 99916.575383356100000m, new Guid("bb3bba26-ad3a-41b5-a56f-402b9c30bbe0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("d5cfc51a-88a1-4552-b9e5-7442e420adbf"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4430), "Yellow", "pqd szb wz lsvw sc u", "VideoCard", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Cloth", "uz mfcmwimpa", 20612.866953300700000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null, "EIDE", 7003, 39957 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2f47a1a3-85a3-4287-8c58-a1f25a9e8066"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8487), "Gradient", "mx kn  a u  wbdzoq yqi yukuw xmxv ikgsp", "ComputerTechnology", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Plastic", " o etq vwll pp", 47086.683962068800000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("8206b057-6e22-45a6-8af6-b5fae49a573b"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2466), "Brown", " fs zweowhtxy cruaapmfblovwfk  wwh lgq r vw l w mk dkyv cog jjpotfosve  olyk vpxewqf tcg ktlwk z   hcnccboc lajqq x", "CPU", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Cloth", "md   d f  gsnazs", 20012.116022413600000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, "AMD", 6302, 7881, 15641 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("d48e2dd3-a68c-4da2-bea3-cc7b9ad0d6f1"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5058), "Violet", "dp axt qle ltcnhuj   ogdbw", "ComputerDrive", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Plastic", "uqzt  frkscy  rt pcmwegyc", 80557.049941530900000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 6273, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("179b2510-d8e9-4bac-9e59-17b3fab45b74"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8782), "Pink", "hhze a  lvqkeenyn ycnkbkduw f eezhze  ddtvggwu  ", "Cooler", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Glass", "pmyxbtw jz  yu ujvf  y", 34862.585428572500000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 27719, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("c0161a24-3787-4061-a3b3-60e9ea4622f5"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2356), "Gray", "dx ts zydl z zrmornmto k bnht ", "VideoCard", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Wood", "an  kgo nwkshar jphbay    lfm", 11708.1440108400000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, "USB 3.1 Gen2", 13306, 8870 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("3c97b852-f96a-4fc0-b6c1-c82196b369b3"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5400), "Violet", "jlymxcdtqyksc q kjlbmjaitsr dwhggixdx w tq oob oxe nz dy k fymmcwxd i s", "FlashDrive", true, new Guid("52760470-a8d2-4cfb-ab09-14f431c4c3cf"), "Iron", "g  j fc rz   jxkuvl", 67938.711991505100000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("973e0268-a0ea-471b-8f75-c93d761a6bd9"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9214), "Blue", " v kzeu e  jvtlazrk fi hlp  rbq", "ComputerTechnology", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Rubber", "kl nry    i", 97199.855743534800000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null },
                    { new Guid("534f87b7-ee3d-4c0a-a81a-63273f46ba9f"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(8), "Pink", "mex  mvoqmuc   e mwdgmvogw   ncuffv pu tij zvm hehsa", "ComputerAccessory", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Rubber", "monn at t p zpx", 24422.082409459200000m, new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), null },
                    { new Guid("f521b320-c9cf-4b0b-aef2-e9f771d3f532"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2044), "Red", " jv   a qnca  ezjzc pjd fjwpgw zgfwfymc  yravi eerhywmrnrckpikhbfc kz", "ComputerAccessory", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Rubber", "l  i e vvqkggd x g sgc  mjs pfi    ", 56700.541850505600000m, new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), null },
                    { new Guid("6bac8b3d-cfd1-4071-9e0e-dfe4a923d95e"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7264), "Pink", "zb dgs xzgxidq vw mf  cc tc  q u okdhxucp  vb vpddlhvmqv  ", "ComputerPart", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Aluminum", "bh e j c zuxae", 61274.313443002400000m, new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), null },
                    { new Guid("2030c2a7-e4cb-4036-95d1-28e50e175205"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9372), "Blue", " vsoaotnou   xc   gdlcwd  g o", "ComputerPart", true, new Guid("df03be55-2cc4-4d2e-941c-a774855d0938"), "Wood", "n ywr fxp tbployqpu mqi", 66688.454415038400000m, new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("d9f71dfe-2cbc-4999-8648-808f2931345c"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(8167), "Gradient", " yotm tk c i sxgyc", "ComputerDrive", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Wood", "xxfrpnhttsxu qi yrqohr", 8292.64712906100000m, new Guid("719cc532-5069-4946-88f9-a3be7a504b75"), null, 24576, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b5dc81b9-9611-4fb0-9d6f-9604652096a6"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3398), "Red", "c qfnqibiz zv  kbd guhzzkxiqfb uweggrvwfmnona h y u", "Good", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Leather", "jdo ghhyz q n qfccbw   x s phq", 63550.037501170300000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9a2055dc-4c12-40a3-ba53-c7836c7faf32"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(759), "Brown", "n yvrb gfhwffi  tezlkor crq  fnlg g xpu", "Computer", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Leather", "x jl nhfn icjayzu", 54721.133669242800000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, 18, 15, "AMD", null, 14, false, 28f, 30f, 22, 1781, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("17554c1b-e9e0-445e-876a-65adbb4c9a36"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(386), "Orange", "iwnq qr duo wcoqzi f kwrghor mb qmastvqjj", "Headphones", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Rubber", " b qskgbqax   pl", 2021.1623059684200000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, "2.5mm", "Headphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("f969fffb-c946-4a23-966e-030594a03b52"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1795), "Red", "zei dc piyb e isp sc  u y ", "Keyboard", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Wood", " oa no gr wzcuqtdq ", 392.4823367933200000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c6c3e137-69cd-4b49-a4bb-636a4f9301bc"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8955), "Green", "lw nlk aia oj p o ilvwc", "ComputerPart", true, new Guid("642d1b54-a893-496d-80f4-333aa2f4b1ee"), "Wood", "pnv mdhlrb ay l demgwm   ", 44019.217483708300000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("824a565c-92a5-46be-a56c-aa30454e13f6"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(5719), "Black", "skzahjy pbq ojkup mf dslwhu u qn  yfcbf gwy jdh gcggrs", "CPU", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Iron", "egbbu mfawx ifeo oh eh l", 26515.852346325200000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, "Intel", 15652, 9763, 14995 },
                    { new Guid("c41fa74b-9892-452f-9f74-56eec72c8e84"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(914), "Blue", "w  ob    vjzwucvdoblzomw yntntw add  liepa", "CPU", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Jeans", "g r ageytipdzfiqwhyn", 54092.600501185600000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, "Intel", 12454, 20103, 38587 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("1e3fba1a-00a0-4a8c-b9c4-711c28e447cd"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6945), "Brown", "fuzwwrdeheuvkovaqbudofd n mcrse l p m  d muwgeqnh", "ComputerDrive", true, new Guid("9336f9be-e4ff-4cfc-a9ec-f8da57795136"), "Leather", " lf  kjbrs xlyghj jn  t dap mtaun f", 24612.60125255800000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, 27800, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("4e97b7b8-630f-4a5e-8b3d-ad8e56ab7958"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1038), "Green", "  iat  jd  sh uu ip  hpiic", "CPU", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Jeans", "hsd br  yle xuc posyhgxm", 14229.536994467300000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, "AMD", 1853, 14477, 26857 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("757cdaa8-4a01-4fff-9f1c-a7a8418a2fc9"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3825), "Violet", " irykpr ry xgs f zipc woplhg r fwr ggyryrft i drd cuhxugeb  j h ztbspit", "Mause", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Leather", " h  uesewh  mno a tn", 79875.184912176400000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 18053, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("b3f32a16-7643-4cdf-a63a-bf29b1f23b2c"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2753), "Yellow", "y iar feb i zfjnmpitns gqthrfyah m", "Computer", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Rubber", "eyu ywbnbvbj   mh uatpyp", 12873.417331312500000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 19, 13, "Intel", 8, 17, true, 27f, 17f, 22, 2706, 3f },
                    { new Guid("a762409a-d06d-4b5b-b929-599873d0e20c"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1144), "Green", "zmt spy  xa gctcuxgi l pfdpcbzgn q  ehsiih", "Computer", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Rubber", "ncuju pdbx dlaulhgrstj ", 13527.355256270300000m, new Guid("d8d2b84b-2858-4fac-8448-1a381f32ddb6"), null, 13, 1, "Intel", 15, 26, true, 11f, 7f, 24, 1326, 11f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1684e8c7-4aeb-4653-b3c6-693a48fe20ed"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3330), "Gradient", "df  o rut hpzizus mghyw rsdlfd bf u", "Good", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Jeans", "xegc zdz im", 47571.774920249300000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null },
                    { new Guid("05b0aee3-1f47-4fad-b3ef-9c466b6be64d"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7017), "Pink", "rxagpf  mszcl lrp aezywrl si nruaenxhoxsuo   srn f   cjo ", "Good", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Plastic", "v sy zprdtao epejvmkysriw", 87200.67636445200000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("00a8f167-afd6-4c32-82bd-ff6693920b13"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1498), "Yellow", "lsiblec be yyryeqfinj r  ", "Headphones", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Glass", "cnyhxcr ayydv   xup t", 19838.132345973600000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, "2.5mm", "Headset", "IR" },
                    { new Guid("5d6bf6db-d762-424a-8161-6213f69307c2"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2954), "Green", "hxieumjptgzbe pq g  rn ywdyiphl  bjpgl rfykg totho ekkj w", "Headphones", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Wood", "b io rxonknnw m ky", 30765.00400470800000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, "3.5mm", "Accessories", "Bluetooth" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("32cb4073-d7e8-41bc-9f4a-9b9bc4a21b5d"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1342), "Red", "ja  d e   tsvjkxkv zqrmcgz  v yutwm", "Keyboard", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Plastic", "yppvj k niknls   ", 52758.487431685700000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("521923ad-9b67-4c08-99fa-63d4ca85fd02"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9952), "Yellow", "jwvb  juq   j ddnad mpvysqho  b vz ", "ComputerAccessory", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Glass", "nnn v ko wlovcv  wrarwy   m cv", 14963.299136126100000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null },
                    { new Guid("4e655d1a-1883-43a3-80fc-79ac84b6692c"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2333), "Gray", "xpysj ohhfb fx es g zrujer okh  ydmpcnwlwtkzyv  wmhc f  feieptvl", "ComputerAccessory", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Glass", " lvgv rvs w  oia di mza", 25504.669465825300000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null },
                    { new Guid("a06f7251-73a9-4eda-9575-aa4dd65cd7bd"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7442), "Black", "nqsepoirt yz afeihhkpnrchyo zagyngimwa tifx  lx cgmcbdyh  tl", "ComputerPart", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Iron", " cf    wxj   ee euyxzcv ", 83698.560615861100000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("e669fa97-903b-46d2-8bf2-843679139e7c"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2939), "Yellow", "r  zrnfxs  hm n vgt njxe is qbrqactq lhf jltwjeofcgq osz dkuy w", "CPU", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Iron", "nac n bhpqarzxwjwk", 75232.006365075700000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, "Intel", 35101, 10357, 4625 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("d497e883-88cb-4d87-8411-a25056f7a2ba"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(5891), "Gray", "gcrwcsy evja uotretlg fop ohawu yz vt", "Laptop", true, new Guid("dbe6978b-2337-415a-ac30-48399c454f28"), "Wood", " n n nzf a g u bysdmoslaux x j", 51518.395241125700000m, new Guid("6f3bf767-7c47-4d1a-86cd-344152bdf85e"), null, 16, 28, "AMD", 18, 24, 8, true, 28f, 31f, 14, 1267, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("814ba38d-be2e-44d1-94d5-6c7639822308"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7908), "Gray", "qcvagkbvg  gr   c j d pd bd d blmfiwqd", "Cooler", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Leather", "fv istda ogaw ld kjiwec", 29575.434992823500000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, 2643, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("feb8d233-4a4c-45c4-8a55-4d3871fc25da"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6687), "Red", "wm  yciwvbj s pl u", "Laptop", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Wood", "pqz c kd cue gu", 11419.91508725100000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, 23, 9, "AMD", 23, 29, 21, true, 16f, 6f, 4, 1634, 6f },
                    { new Guid("d3748a03-4111-486e-bd32-36f6e5220d17"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8930), "Orange", "o rooltuyj nqgfikdnqreas rf  bh", "Laptop", true, new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), "Plastic", "snnn gp eo  yznhji o", 86918.258334937600000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, 10, 31, "AMD", 4, 18, 25, true, 13f, 11f, 27, 1353, 12f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7bbb7cb1-2c95-41d4-9634-5c67d7af004f"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(817), "Yellow", "  vexsrbtg    vup   ni mk myxdal   fvfljb", "Computer", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Jeans", "v tvwgdh  jp  pf", 5367.6413862815300000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 12, 18, "Intel", null, 2, false, 20f, 11f, 26, 1174, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("1d94e82b-7895-4e6a-b914-b29c4bcce136"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5844), "White", " l  kypwhbne ot kfhfj ivtp tzxdp ldmgdmolkuvsxtzjpkvj  f", "ComputerDrive", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Wood", "v vv rmpnj cub", 59247.929118223400000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 26842, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("d3a2b03d-4102-476e-84ea-f52e5b4dc93e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5182), "Pink", "  ujfazfnqa uj wsnmskanmtv  uoew vvtjw", "FlashDrive", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Plastic", " vvhjv o kgvpwsg  ", 95975.637247774600000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 3, "USB 3.1" },
                    { new Guid("571cf346-e3b5-461d-bf40-fdde33a18b7f"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6602), "Gray", "rm czd z jmiqhkjcsbjv  ycpwy vajpznk s    x  gmibecygwu wxo rkpo", "FlashDrive", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Cloth", " stmufk  d m h i xxns", 85793.272352681200000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 7, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("143db85a-9a53-4240-914b-b51206b08010"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(4903), "White", "nr c yyom lb wvxfgjps y dffgcxkp qyu z gelfcqb oczylt k m j", "Laptop", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Aluminum", "nti wzs i e", 80977.871818923300000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 9, 10, "Intel", 11, 26, 2, true, 19f, 25f, 22, 2365, 22f },
                    { new Guid("e1cddf95-4106-47ea-93b1-806baabb3ad8"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8892), "Brown", "n werklsi j ", "Laptop", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Rubber", " m  mw benvfi  sred ", 88256.783032909400000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null, 18, 19, "Intel", 19, null, 18, false, 30f, 12f, 8, 1728, 4f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("765e0320-42a2-4b25-b9fa-c3e8db9be306"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(354), "Black", "wyvrasrb   eyhlqiwu er itwgnt rtf cozgb njnpf irqg", "ComputerTechnology", true, new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), "Leather", "gt xcatlrp vrlpv  zc", 68854.581876124500000m, new Guid("e83f1c0f-edee-4b48-9c25-f2b99b134d57"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("cbcd47e7-8911-4933-9359-ec6ac7397485"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8951), "Green", "bivbvai i rs", "Cooler", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Aluminum", " cu vtsfznsiq", 32242.24365886400000m, new Guid("63817985-dc7c-4b80-8a7b-a2a63c62f31d"), null, 23235, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a80fb7d0-b74a-4b7c-83be-c187ba942975"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9858), "Brown", "ul r  wwnvaxespvrkdxo  oaeqsq kvdady zlitk t ", "ComputerPart", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Aluminum", " lg jeq a bj dkj", 34852.989639552800000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("4b3e3c4c-a723-4817-9d01-61bf2b575d21"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5060), "Yellow", "lguaetmo  ccr blfk pbwblc gao cqyjrpkzsbd j adsiq mwv etccm q", "Mause", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Aluminum", "  mvyq jmfvygr ewl", 66295.715824838600000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, 11637, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6a32724c-06ef-4134-a908-5bd5a1c7f562"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2301), "Gradient", "xplzv yoefu  hezguxpzjsgwzbdkusvvrihw to m  kt k", "Keyboard", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Iron", "  zbpviailh", 96903.396070424200000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("13da33af-0719-428a-b6ac-cdfcc598df05"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5411), "Pink", "mahuckj tavzkrste  ", "Good", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Wood", "c bxzoar t efv", 25604.536489399400000m, new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("bca984f4-aab6-410a-b93f-3e2dafb21e8f"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(605), "Gradient", "vnh nsiyc sai sk znircj vw mldjktve zfclhqxe utf ", "Headphones", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Plastic", "xpcmgop gll g jj", 31104.358346715700000m, new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), null, "USB", "Headphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("149b6fbc-ddac-4ce2-9acc-b2ef9bc1414b"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1305), "Green", "vtpcvkfy vyfthtzvj az tbmo uwfum ", "CPU", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Plastic", "cipo ndatoalac  hup  ", 20831.082491591100000m, new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), null, "AMD", 3254, 26789, 8248 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3a457fe5-8bc6-431e-81c9-3de01d6245e8"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7997), "Green", "okt  u dvw s  o fr px xe dfyardhfv vpssn cllpk  cvgtetyr v h mps se  sff  j c  wh", "Laptop", true, new Guid("d6bad7e0-9baa-4b60-849a-069e154185cd"), "Cloth", "rdtuajtpdi g ullc   xr  xc", 78081.474536136500000m, new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), null, 15, 3, "Intel", 10, null, 26, false, 1f, 6f, 20, 1992, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("774099ba-9f7c-46e7-bf05-fd9f82144e1c"), new DateTime(2021, 2, 7, 12, 6, 15, 229, DateTimeKind.Local).AddTicks(9815), "Violet", "y  e  yk m  cunbz axxxlkzttuge  m tjalud kcyspy t rf vz l zb bgnx ", "Headphones", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Glass", "gxk  wid sbx bi", 27970.700630904500000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, "RCA", "Accessories", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("e80359b1-91b6-400b-878a-fb0a01efb40c"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(764), "Orange", "ephdw vpkdlcbc  whp gkz s  pfs  mmzizgfr dj v umpg scdksvmljd rsmrlwho  awdn", "Keyboard", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Glass", "trud  jg  qkhkgc ibms", 94904.060240324600000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, "OUTEMU" },
                    { new Guid("17042dbc-293c-4dcd-8473-1349f835c6d0"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2250), "Violet", "plxo kgulekwlpcy kcf drco chmay ", "Keyboard", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Rubber", " abdh cl fb c qcepifd vx c ", 16518.231163042700000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("d4de7914-6934-44b9-a8d1-0bd3cc1a9e02"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4482), "Pink", "nlsufxbijjqk kj b wsm j h", "Mause", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Jeans", "dhnj ern w rwt", 83800.535315554800000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, 11538, "FastRFWireless" },
                    { new Guid("e45735fd-3cee-4488-b132-50e45fb33efd"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4776), "Gradient", "mmrhthybe qydc w   npyh y eiy uvfiabx fukp g   gih cykwk ctux mo l", "Mause", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Wood", "i pluen  svn ", 23760.101210214200000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, 6473, "DualIsLIGHTSPEEDOrBluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("64284573-5542-40e6-9ba8-9bfed03c3b78"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5913), "Blue", "palr eeqznk dlaoopzdrd  f  b gaecmpwwcztx  ob zu a hn    cobs  bfu  ot s mjycp oc bdl vomwbah", "ComputerDrive", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Glass", "e f uk cl ks  wy", 70368.108838036700000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, 12155, "1.8", "HDD" },
                    { new Guid("0ddd8d7f-ac21-40a4-8585-7d0b720968c0"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6243), "Green", " rofj r w ynqvkzqqhou  rhv iqzglxswztrul dpgksnmc uojn u cz qvod h xe nnw ma z ", "ComputerDrive", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Jeans", "  yyyrer z  y ln lwve", 26492.191444380300000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null, 4534, "Add In Card", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("15ce6ded-fc3f-4343-b021-8cb81a671d94"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8439), "Pink", " u  chlgedgyca q a yh    raz  l ", "ComputerTechnology", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Leather", "djq wt vwsu", 16652.886437556200000m, new Guid("637ee9df-e2c0-4808-806d-c786a73e3112"), null },
                    { new Guid("ce624751-b320-427d-af0a-b57f6497c676"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(380), "Black", "gy mci ykzty glfx  ydgx sxepi  rjoswixypwtixupt fgtz kwu", "ComputerAccessory", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Wood", "uw zjsobzcmf", 14283.568372150700000m, new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("3155bb57-091d-4fb4-9c7d-36a6d101650f"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(167), "Gray", "   kyekiyinviafdwqrfgvdn", "CPU", true, new Guid("78c9fc24-68af-480d-a42e-5f6069a26865"), "Wood", " ksndbu h i  ltp q hnhjr fhkshpq", 56701.478248788700000m, new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), null, "Intel", 9527, 36659, 35038 },
                    { new Guid("74bc8055-9964-4181-b084-dd7b646d7651"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1550), "Red", "y pmxg g  kqw tm i f  oqo lnxfsiom fl bsaqabj rwljqkpxcvn      vdmrlsrv  pkq", "CPU", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Wood", " l  qknag qrl    en n", 95188.590975100400000m, new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), null, "Intel", 39761, 7444, 18668 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("21063aaf-d5dd-4f83-a4e1-0de4388bba35"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9308), "Black", " fke ytcistl z tew ri f r xf    c hcrdshf qoi  kgaqudf  s  ", "ComputerTechnology", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Plastic", "g tsfkh lzxqfsmvkn r ", 6494.2651924184800000m, new Guid("d659cac8-ba50-4fd5-9876-087cbbdb8800"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("f9da0faa-cb15-4773-b263-99e6cfc0ed02"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3264), "Blue", "onqfnrrh  oomvlz ilmk psjxcjsq juu qxoybgpkmyv enog", "Headphones", true, new Guid("86869b9c-0ca2-47f9-b674-59863d1302e3"), "Iron", "t mg tacy or m niynxfs", 4062.5235550396700000m, new Guid("faaa98c1-0848-4dcb-837b-8d023c9ddc56"), null, "2.5mm", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("61b3ed3d-d4ca-4168-882c-94ef1e265cd6"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1103), "Yellow", "rolvf ids acspymljre h a fw dmjlttkba oaikeqzrdnrl r rzpt bzj    u ffc", "Keyboard", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Iron", "  lhqu nqdzdgdpmnf  z qeqm h lxlxhzw", 85541.855118024100000m, new Guid("faaa98c1-0848-4dcb-837b-8d023c9ddc56"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("f114875c-9567-442b-bc87-b74bfbcdd510"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4152), "Violet", "sd q xgnygdu f nycsk s qj zw  ryewbc g", "Mause", true, new Guid("ed903c70-7a38-4ae3-bf5b-b665b4447b61"), "Rubber", "k jvxxfmumyhafv  ", 61241.451399978900000m, new Guid("faaa98c1-0848-4dcb-837b-8d023c9ddc56"), null, 16887, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("8f85e452-9ab9-4f00-b155-19844488d81b"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8422), "White", " yy qv k d ghw i hsjbxcyonzlw", "Cooler", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Jeans", "jxwmdgzcivorhvhydrtawv odu", 37507.914303572800000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, 12605, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("50aa4779-4d53-493b-a5de-820b1dd43bd3"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(490), "Green", "tv uvhb bute ll sbs ggtiko u wfoyzh hsutd  sdnpjb", "CPU", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Iron", "ax ihf nxggihq b fy", 65635.04439109700000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, "AMD", 24197, 5022, 23602 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e9d69d8b-13e1-47a9-ad69-9e26c352f5e4"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5595), "Gray", "zzyznvlwzzuldhixycj   n n   i zpu  a txdl  k pxbhponi k", "Mause", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Glass", "dh xfurn y otzirj dvt z n ", 29765.333016293700000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, 37192, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6950f48a-83d6-49bd-9e15-de48815d0d71"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2049), "White", "l hsjr lj     cotpc wmwnxg ak", "Keyboard", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Aluminum", " r bapkuogcoc qr", 70471.584084663400000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("26fd81d4-b60b-48ab-a20c-8e1ca29a424c"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6905), "Orange", "dn pdmr qbwxe cvd mwt cxxavrwtv uctwhb hb", "Laptop", true, new Guid("47f4ac79-ffcf-4bca-80d7-19fac991b2e2"), "Leather", "y c  aa mlspfo b w  tmn tkwksxforz", 72839.015197399600000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, 6, 29, "AMD", 28, null, 25, false, 21f, 12f, 26, 2056, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("06892713-8bd9-47a1-ae67-901c74e2f4b5"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4976), "Violet", "zsql   d   bdti pwaxefw w exl", "Good", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Aluminum", "w  ts ne  ep zxqd c mumpi", 1224.9571742606100000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("3df42d72-4d64-414c-b05a-13ce1f5a5fe6"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4274), "Gray", " d   afvki  gt", "Mause", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Cloth", "moedtmflireg jd tiu", 16026.187928405700000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 37614, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dd4877e9-2523-458a-bc1e-e5a486fa69f7"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(126), "Gradient", " cnzohasjp ema", "ComputerAccessory", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Plastic", "exj d shiv l syca  j", 76719.682792536800000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("b4b71660-e439-4fbc-b942-fcbc945868e9"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(949), "Pink", " wxo kq ykpstocxzemm ul  ekqzcph ", "ComputerAccessory", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Glass", " jeg gbf  ", 62444.555928206300000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("a1c7229e-5db8-44e5-800a-4610759200e6"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7343), "Gradient", "b adni  yas  lql v lu hiidfimmykpzbsloluj gsoy  hx w  trn", "ComputerDrive", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Wood", "   x rt  p apgi", 59263.060548930900000m, new Guid("7767acd5-41a3-4f5c-bde1-c7eab6df88e7"), null, 31323, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("d2e757c5-7d62-40f1-bac6-47f4a56ffd97"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6292), "Violet", " p jx  uxmmmzfvgjkkvcu uyivfr lxnzn  c", "FlashDrive", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Jeans", "l  nww ftwrb cj w", 79252.236745903400000m, new Guid("99f3ae19-af0d-46e3-91ab-105637c6646a"), null, 16, "USB 2.0" },
                    { new Guid("c668f778-3197-4a93-be54-a329daf6c25b"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6987), "Green", "sa ywu uj hc sfwcp a t lc rv zpcfzmzqfau", "FlashDrive", true, new Guid("d6825fe8-8c28-47ac-a283-2a12f05cd3e4"), "Cloth", "  xjteioxf  xh  ew x", 61047.927598025600000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null, 14, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("00a40360-7ae9-4b01-8a55-53d8ac0d506a"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(689), "Brown", "l  wj kw op lcp q  yp  e e vkixrcg dh  x jhgtd v gb", "Computer", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Rubber", "h t y dxztfep pd   mdy  gfpsdjy", 19673.509811830500000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null, 30, 10, "AMD", 24, 9, true, 14f, 17f, 21, 2218, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f83c18a2-16a1-47c2-b34d-3884ec60afb8"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9709), "Orange", " x vfqmuo rpriylyv n yw qeods dar mjif d", "CPU", true, new Guid("8f85985e-aaf0-4ad0-8887-f6009977702e"), "Iron", "gdigybof u bcvp j", 77843.046876528800000m, new Guid("faaa98c1-0848-4dcb-837b-8d023c9ddc56"), null, "AMD", 39272, 36066, 22738 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("d9ea3e00-e1a2-484d-96c6-85ddbcbbb4e2"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4890), "Black", "de wfvoflkq ji seikeath ajrdxlg  hdi wsxieavl  felitqa oqun  w k ipt vsv vwd  fp yqo whya", "Mause", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Plastic", "q b cjldmdqn bmty myu", 44948.133754054200000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null, 17225, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f0925b1d-bb80-4e78-b155-d842e5717f33"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1035), "Black", " e y mxq axin  iogovsonk fn wz qsv ewzhpefp", "VideoCard", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Plastic", "ja      qtfc iu  k irt", 72755.833981910600000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null, "USB Type C", 6607, 16998 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cbe755b5-428f-44e1-b22b-200682ab462a"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5910), "Pink", " fbbtztdg  qyvvic xix hnmplqedl a ", "Good", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Leather", "sw d e pq dw n d lhxwoefam", 4829.7792229940100000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("837d719d-6cf0-4bde-9123-f72d7c77bc56"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6171), "Violet", "dkjjg  smu xe h ulivbdrd qbzn mzmikshalnzt uerk hyq mbbl xk z e ", "ComputerDrive", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Aluminum", "z    prl r mobah", 25418.025732700700000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null, 12147, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("975cf22c-4731-4637-bf2e-06ade180fa0b"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7534), "Blue", "qdljazthhtcw r  zpttwmmmgujvps r rvzip u  kxik ivf nlt sros eof jjo d", "FlashDrive", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Glass", "tot   qoit pn", 44927.042976453500000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null, 11, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("99413030-4597-469e-ae0d-4deaffe26468"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7309), "Yellow", "   zp ftl    ulukayzy tpltm dqf h  j mjv aeygdho ajhg ", "Laptop", true, new Guid("2ae34534-b8cb-4270-acce-49a46b1fa0e7"), "Wood", "i znw  im isni", 67486.197951941800000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null, 22, 20, "Intel", 26, 29, 15, true, 7f, 18f, 23, 1406, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4383ca35-95ea-4d03-a3b5-d7b31361eefc"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9791), "Violet", " ukqmugfh m avqqiacied rb d ay  dyqe mt fgvywnz n jvzjitcpcfbcl  u x  clic", "ComputerTechnology", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Wood", " fby hnhnatqvzm bzcxx ", 17994.673279111600000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null },
                    { new Guid("b92e0cf4-cfa4-4e0a-afe9-d55ab96d9420"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2486), "Gray", "b hmnan dpkjidvbnpby rv  ltyecy zwimm v orz gix m ", "Good", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Jeans", "fpdrp  dqum  s ", 43141.042321520400000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("bdeb30f5-f0cc-4212-9d37-3778b1b7deb1"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1927), "Blue", "zyb  ztnmsqxzi c    i btf lqdzf k  g  tor mf  rlpg obvsv o pdpstxy arv    voxx hfvu  xtyukxfay n qh a pw    w", "Computer", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Plastic", "ph  lbbt c yyrmpxkqwtsn bn lyq b", 11556.827096062200000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, 9, 7, "AMD", null, 30, false, 16f, 1f, 17, 1113, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("364c5e50-b66c-472d-a13f-dec97f2f46f4"), new DateTime(2021, 2, 7, 12, 6, 15, 229, DateTimeKind.Local).AddTicks(9899), "Black", "pflpp  rhpjusdra m  uzugi hi ps d xw amwwvlgd", "Headphones", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Aluminum", "uqq  rapt j   mobt l em gvbw", 64872.939868305300000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null, "3.5mm", "Headphone", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("b70a6620-5323-4b35-9c9f-0e55d151f5e5"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(653), "Yellow", "   ioda vyblm  okzr r  wprurrb ahkecxvyqx   olckdycix", "CPU", true, new Guid("5ee70cbf-47d4-479c-9615-c17a5bac934a"), "Aluminum", " t  b vv pj x hoa  e", 51235.868479700700000m, new Guid("6d5b18f2-360a-4c83-97f3-eb45644badc7"), null, "Intel", 34887, 31378, 38989 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("01d05662-c5c7-49eb-9154-656945c226b7"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(2911), "Gradient", "e  u xjd j byjt fqkuvbwowqfpayu rgr  jbsjlan mg ", "Mause", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Jeans", "cjs u ae kiyclxzfm", 98588.641918538400000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, 16439, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("00c1eda7-5b84-4ba2-a654-c15e3453e18e"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5854), "Gradient", "bf a  f yahtf h z    k unxalz w smahkrmzztgjjuezfbqojbx   pzki p", "Good", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Plastic", "  ly as idp heljkhwj fc lvt", 66916.015542538800000m, new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("b9f51729-5e92-4efe-9181-25a119031a9f"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6487), "Gray", "ptg kahdalfag o v b h mqs nketbbaz a mfq", "Cooler", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Glass", "kznk vvkvprbrmih    khfaqztelari", 10770.516707920700000m, new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), null, 11166, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("de1c04a5-1ea4-4b9f-989b-e332558d28e8"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3921), "Green", "w ge n    p ce m ytv ego sjfyow   roggywtabod   qh jyogcludejvr vuxsb kl", "Mause", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Jeans", "i v hbg hqfskg bzt    ", 84530.901808538900000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 6023, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("674c0945-46fb-4e06-bfaa-075ba6865928"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1566), "Green", "qxyi mz d dp vtdlgtc yj", "ComputerAccessory", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Wood", "hnfa vgzcaxjezlblmj jf cho    bcj ", 30504.185394618800000m, new Guid("3a8a3ba1-4481-4f5e-970e-42b30c309627"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("a3e8a620-956f-49ff-8372-2a49d8a92e08"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(637), "Gray", "sux dj ho zjy  pdr  fxpijen y mhkqw   s m  khmvmca kdmk mzs in l m nzy soga", "VideoCard", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Plastic", "ywhm kd etxidaedjelqpa vya", 46468.472874941500000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, "eSata", 21829, 21816 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("d3b1a370-98c2-466e-b9be-0c33ead795f0"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4790), "Gray", "  l pkymqt cmpewdm gk q  etsc l i r", "FlashDrive", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Cloth", "viie brthj  g", 22938.933792961300000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null, 2, "USB 2.0" },
                    { new Guid("c52fc751-688b-4534-926d-261a6073b04d"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6932), "Gradient", "s o afgbdfp flcw p ljws  mp", "FlashDrive", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Jeans", "b   bl  p it  v zwuqlqa  thne", 67712.92605796500000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 21, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("524e2dff-4542-4360-adff-581e9d58ea57"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7330), "Green", "ygov  meaxjh xdr f sev w uc  cwuri  wefpipovbrz", "ComputerPart", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Iron", " j lotbzpjzrslhosedxgn", 69485.164978301700000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("47abc81f-18ec-417b-9d34-e929e733d5af"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5474), "White", "pqt r   dbr sbrcn j lmsn i dzhl", "ComputerDrive", true, new Guid("8a58be68-6460-4bca-8829-87f019c1a8b0"), "Cloth", "q  um dfodoby lxqwrgo l u", 31912.124358076700000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 11060, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1fd845eb-552f-4431-8ba7-a006bbdd91c0"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6409), "Pink", "fdtyrhmtdhvbnmedy jle lihn gdhea wfeey g    zpjlfcf uhrn", "Good", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Rubber", "ig nzgcz y zye l ife ", 12422.996020141500000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c9edd0d5-435c-4583-a44a-b58461752763"), new DateTime(2021, 2, 7, 12, 6, 15, 229, DateTimeKind.Local).AddTicks(9971), "Red", "i c cfnkmjavd  m y uo", "Headphones", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Rubber", "dvr beggg xzdiwt", 14010.674745780700000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, "Quick Disconnect Connector", "Accessories", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("22c3e138-0e2d-4362-ba19-d398e8b05dc3"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(751), "Orange", " zgojrwsiukhtimopj wh ugpvrf m qh u hlobtf f ndut yamjaac v wy w", "ComputerAccessory", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Rubber", "xfivzvd  l fd lgz", 21819.588552145100000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null },
                    { new Guid("4b2849b9-5df1-41e6-960a-2a6c6cda7d81"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2480), "Violet", "kczli kwsnfswgxsa pz tny wq   gtg so ", "ComputerAccessory", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Plastic", "hp evm txgckbeyubk ", 36160.296917036300000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9d610887-2c3c-46c9-bb62-a2b17a303739"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7952), "Green", "hw    o   bxcpf cwxmnk v ", "ComputerDrive", true, new Guid("9d70b078-1f6d-4d49-81c5-68624e84d0e8"), "Plastic", "e   dw tlohuzwt jgvzobj yxta oq", 8382.1020128122100000m, new Guid("e1523adb-b064-48c4-98f2-e924eea3e718"), null, 20324, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("04de6da6-6009-42e8-a877-78e5a7963a00"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7389), "Gradient", "bme bm s  kujtqgkfcoeckn ", "ComputerPart", true, new Guid("52760470-a8d2-4cfb-ab09-14f431c4c3cf"), "Cloth", " g pux u  kz", 28618.220858563800000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("7de60a4e-11ab-476f-ae53-0898089f9cd3"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5073), "Green", "icclkmplvmt vmr ac fjdfn  q xlkd ch", "FlashDrive", true, new Guid("52760470-a8d2-4cfb-ab09-14f431c4c3cf"), "Iron", "nmoba m pw e bhurmqk ", 65029.303992646400000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, 13, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9ceec9de-5769-42f1-be05-347c3ddda1bd"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6735), "Brown", "pc rxieackt  nqoaysezui", "Laptop", true, new Guid("52760470-a8d2-4cfb-ab09-14f431c4c3cf"), "Wood", "  niior keij pa g aermkg", 62350.271112448700000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null, 17, 28, "AMD", 10, null, 17, false, 14f, 25f, 25, 1008, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b5667e7b-8071-4bee-9dc2-5893d2a1feb4"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2627), "Red", "e   rok xwosuxqc te r  g tmz ldbkwcne tsg ax", "Good", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Aluminum", "b towylp wwu o deybu bhbnh", 21115.768151877300000m, new Guid("ad438cf8-7e0c-418c-b585-7f56d9ab601a"), null },
                    { new Guid("39b689e9-4a79-4c7d-b462-6b8403ff0670"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7467), "Black", "u pvsr tzvikmozwuzgsk ", "Good", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Glass", "f n  ppnxwtv m l", 22432.709495738500000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ee4c4b50-81ae-4eda-ac0e-b93966dc2820"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9885), "White", "   bg fkhhgty   fqdbue lbj e s w u  p", "Computer", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Wood", "ij ne cfpllndsi", 60227.269008861500000m, new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), null, 29, 9, "Intel", 20, 7, true, 19f, 19f, 2, 2524, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("98449194-81cf-4fed-933a-7e465ea64530"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2646), "Violet", "b a zgfm  oufp b v q  x j aqfvthqhha nlepazw dirxvko kopa", "Headphones", true, new Guid("87036e66-6399-4e49-8e5a-feab01d7a0a9"), "Iron", "wk  a g  kmawwm rrsle", 18406.737557801800000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null, "3.5mm", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("f1f440fc-7308-4f57-91f9-e36be0268914"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2650), "Brown", " xl h ddrqkz m ig jx   e h", "Computer", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Cloth", "o kbaz  ps gydmbc d yhqsz p", 46942.691526814700000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null, 14, 9, "AMD", 3, 15, true, 1f, 23f, 16, 1606, 9f },
                    { new Guid("71884484-aba6-485b-853f-07bc4dd33267"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(293), "Gray", " e wzfyz af e  rv le  yspbb sqwa ok qmxg  gz ll  h qdv  bnskvhqvzrvbtzzxycm  yhdoz ctanzjdymcqdjdyrotffj uttsz dugo oizns sl kdr  ", "Computer", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Aluminum", "mr a  si zbukgc", 95802.827829403300000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 7, 10, "AMD", 14, 16, true, 7f, 27f, 6, 3011, 12f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bcaf9f79-d596-41eb-a0c4-1ee328fb0719"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5324), "Gradient", "vf qnh wljn qekqgcidzgbnakzlgztlv plnk mkj", "Good", true, new Guid("952abe5c-a868-4299-ab5a-dbd482c261c7"), "Iron", "yv  malv ibvo  u", 15441.783664488100000m, new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b39af36b-d7de-4ed8-9430-46f297b9d61a"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9938), "Green", " dzx   emgjxux yeqykeawxcx yeemogtc   e hcutntmgygkay ruvvqa", "Computer", true, new Guid("b555548b-b988-42a4-a577-154bf91b9b91"), "Leather", "l qpoensplhfr dneu lyfxbh", 78826.035223354600000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null, 19, 21, "Intel", 7, 17, true, 6f, 17f, 1, 1431, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("2f8366df-bf75-4271-98c3-c9fb01137d4c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7474), "Yellow", "  cvzegb kuuvqnk  dvwzf yr t gklceonsag", "FlashDrive", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Aluminum", "vzsede wtrukui x  md ", 39371.594246184300000m, new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), null, 20, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("2992adaa-647b-4e61-b136-04747029da94"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(416), "Violet", "j i lw aawdqdaldpinhyte cx t cchn gu oswtehiruphei  r uv", "ComputerTechnology", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Glass", "fugmh aduuncy", 49150.89413949800000m, new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("524d130b-2b72-4276-91f3-e5e4eaa3a7ac"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(336), "Green", "lpp pwi  he fleyjvqjs", "Headphones", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Cloth", "  k  c  lrnd qlq ", 30309.365797000600000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, "2.5mm", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("65807117-7d9c-406c-bc36-bd55729ceb7f"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(587), "Green", "sllljqshi zuasfg blfjmvf jebobreb lya udzfrhdaouotmu", "Keyboard", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Glass", "wo rwh  kyndzok", 4317.5801189232500000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("6c6ce990-ee27-4904-ac18-4bf3a8b3d6e6"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(379), "Yellow", "n ghki ru k gzfx vnam ue  iqnlrigwgal q  dq dmsyfw kcwvwuoerhhm", "CPU", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Wood", " yn  ab  nm jjuz", 95903.937330424800000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null, "AMD", 38204, 36606, 34567 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9d1075ca-f91a-46d2-99a1-49c59b356e6d"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6438), "Gray", "bhfnfsacyridvnpls r  x c  gw  q rj", "Cooler", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Iron", "acauzase kubhgmx", 64837.622952106200000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 29629, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f175a659-05bb-4c35-8946-589e9a4ba69d"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8160), "Yellow", "dc yhihyhl a   gmuaby kyanmntfi", "Laptop", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Glass", "fs fn axgxm nlz dc ku", 91698.899628454300000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 6, 3, "Intel", 3, null, 20, false, 13f, 26f, 12, 2611, 17f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("092eb249-268e-4d17-9874-8b7a3581991c"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8068), "Pink", "zjhm  jnokths  aur zuc  qv fanb", "ComputerTechnology", true, new Guid("2d57d274-c854-407b-a629-7dad8d79bc2a"), "Iron", "tk y vjjr pe", 79963.971106318800000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null },
                    { new Guid("71883dfb-d831-43dc-82f3-b489bd30377c"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3551), "Pink", "e   w  fpqw f h f tdch u hs pr vz z z vj rderh y  uzulrwms ig i ", "Good", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Iron", "yg u xa gknmyec ", 49065.634398286100000m, new Guid("cb0d6116-7b66-45bc-8d45-e3cacb91ba67"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("e8839940-0809-42a3-9fd1-9f706c7e7d94"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1653), "Brown", "xesdvazdpdoy ijwkbm y wos qjg ab lm tpm lypazwwo  eecvkatpe r ukingjvm hviyy uyxxsq ethusd", "Headphones", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Cloth", "x  h y vmueu", 14759.423078391400000m, new Guid("22ed0253-9c31-449d-a439-0d9ad1d7b20c"), null, "USB", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c14ba501-a6de-461b-b878-3b384fdf738b"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4732), "Violet", " m    njqcza e he gvmpbl fab lngym", "Good", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Iron", "  xa axkfaxxus  ni", 35200.254402682300000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("1e22266e-56b0-4885-a532-6bbaf63823d6"), new DateTime(2021, 2, 7, 12, 6, 15, 229, DateTimeKind.Local).AddTicks(3740), "Violet", " js epqfdq gt", "Headphones", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Aluminum", "y   zeq kv ude ambyry snv", 9059.5279396788800000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null, "USB", "MonitorHeadphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("b384b93e-a200-45a0-a47a-1fcde78463e0"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9627), "Pink", " pg i cc ajbcdnl v  p  b    t if c ", "Keyboard", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Glass", "ji wfadksqnkbf r m nj  ", 20402.6529194800000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9350e616-8908-42a5-a7ce-07b5facb1f6c"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7530), "Red", "algjt gyp  re xgqktifuu y b ruyifuw  x vjk", "ComputerDrive", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Glass", "  lc ac ly fwrx uzxrxuyf tklqd", 93517.679019606500000m, new Guid("a90c7a73-7256-4ab1-abb5-17a3ef3aea6c"), null, 1112, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("fccd99ee-d08c-4954-9f57-d78092763f67"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4452), "Brown", " zv yo b   xzsdqkf   lyswu dpgsxba jgl ", "FlashDrive", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Leather", "b  acc mbv hmuluc ", 50310.202851104600000m, new Guid("229d6d8e-999f-4d2d-8dcd-c64dbbd2b977"), null, 11, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("28f038cf-dd18-46c9-ad45-18b625fa0a00"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(5966), "Violet", "nzoit beexcm liorsrd kac vj zyyna", "Laptop", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Aluminum", "pw sujaycuze  pry u", 76257.459249467400000m, new Guid("6239acb2-55d6-40a9-8589-a0ff1f0cc38d"), null, 20, 28, "AMD", 25, null, 20, false, 7f, 30f, 14, 1742, 29f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("32b6f26b-6703-4fa2-a972-4c91a4c0cac8"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(7886), "Black", "jwqionli ckwu  ddtizwkhrdck vi mvyje  d  la", "ComputerTechnology", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Rubber", "ols z pzyi  tcpj w ofn", 29122.597737760600000m, new Guid("ef4c6957-bf44-4265-a641-997b79e1c9c7"), null },
                    { new Guid("0f61e376-a580-47fa-a4f5-52b41e9246be"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9713), "Blue", "u ekn zlr  iuytw pw bzwohhovotizpoqa pcfna gsbabt  ej uy  cmbb  q  l   h yx ", "ComputerTechnology", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Wood", "l qonht itym xtupoxg", 18198.926336224600000m, new Guid("64c2ca43-2094-44b2-9540-9d77e411db36"), null },
                    { new Guid("c316fbbb-4a22-4b80-af44-bebdcbfe6150"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3597), "Pink", "k  llw si c laf   ntfsj laf", "Good", true, new Guid("b555548b-b988-42a4-a577-154bf91b9b91"), "Cloth", "vxa qz bh akvrkj z  ox", 25389.669614559800000m, new Guid("f79349ee-99af-4511-8533-12d3f4ad0409"), null },
                    { new Guid("a31949f7-32a1-4909-9af5-1ca714f25ff7"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6547), "Brown", "aakgkwxgdwv u   gx", "Good", true, new Guid("b555548b-b988-42a4-a577-154bf91b9b91"), "Leather", "sd pqz q  fa wkyyl if", 40931.764310659700000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9839a7ba-8585-45a4-bc30-cd8e4a1be8f4"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1065), "Orange", " h f qzms  gywc mplfbfgqx cj okulqqfoml d ax pv vrtos d qi fawr ud bk   gusr p", "Computer", true, new Guid("547beb4b-3132-4b00-a675-f5eb9fbc3219"), "Iron", "ho p yim zepcpt ", 91322.72288730500000m, new Guid("a9f3bd2a-a7ee-409f-9c1d-1c2c95fb5641"), null, 12, 10, "AMD", null, 18, false, 6f, 22f, 13, 3019, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6f1621fa-7d94-4f9e-b9e5-fdcfc8788eea"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8907), "Violet", "cpvssms o klv sfzkrexhfbtumi th cm fqyzeswfd", "ComputerPart", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Cloth", " mqr h faambq", 62498.366256476600000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("d604192d-061e-438a-843d-f098a3d2839d"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(6048), "Blue", "ztqly qasoqqtfuj y xq aykfp qpd nxdzz ", "Mause", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Aluminum", "u xlyfjyxv qc  i m", 94802.113014646900000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 31009, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("904abe2f-3bc5-44fa-b557-f8410375a335"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9263), "Gray", "cfr pmvtnvwj  vfcxzvaxn hs tygyesv   lg zdz jel k bf yx  cloxqu", "Computer", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Glass", "k  jxb mscxhd", 16236.832698917400000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null, 25, 28, "Intel", null, 29, false, 6f, 25f, 10, 2246, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("83291c89-263c-4f3d-ae16-67422699752d"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(853), "Gradient", "aiwm sv zp  r uztznqub cqtxrkpggr  mntgt u h   vg  wr", "CPU", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Plastic", "jue wspsx alwc gfpm", 54716.034445313800000m, new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), null, "AMD", 28671, 2139, 27411 },
                    { new Guid("7b7155c1-5efe-4b5b-b3b3-58737137fe5d"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1856), "Pink", "tu hexq iffamc mnked uoivmkjbq  m pfgnfloff rktv fwircb", "CPU", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Rubber", "r jpthmu jkbeyb   a", 24579.279974372700000m, new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), null, "AMD", 25190, 12993, 15943 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c3b0272d-8992-429d-8a4d-d34b57c3f451"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9420), "Blue", "cgy ui v  dfvll  wjzwkdtvz z vc v  asf", "ComputerPart", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Wood", "rvdywailmgulm uvqb eo fht  k", 12156.326795069700000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("56ca700b-e29c-47ab-b464-3c19628c4257"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(969), "Orange", "xuzyy  x e lheauy x dah l bcs", "Keyboard", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Jeans", "b jbgkfojmpc  ngdetc", 92229.516428070800000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("6df341fc-668b-47ad-a12d-25b5e37fd224"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8282), "Orange", "acmxfkukfpeajhxh uuwsppdri ys   tdrlcb", "Cooler", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Plastic", "cny  idf h wpqjio", 50765.341637081200000m, new Guid("0c8b5e5d-5cdd-41f3-960c-a8d1832c441a"), null, 28938, "Case Fans" },
                    { new Guid("d40684e0-558a-4265-963f-8f4db68368f4"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6797), "Orange", " p  dthzzxa  bue db    n hc  ", "Cooler", true, new Guid("947b462b-501b-4af2-a97a-f30580e2f46d"), "Jeans", " dhzob ryvhihwst", 29792.66281695700000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 21492, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("037748d0-2f45-405d-bd99-904307eb45b3"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8284), "White", "mpbbqpo  m    v  osplllju ", "Good", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Iron", " js  k kzipfuhfv", 55115.040510480800000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("5a0ac3b7-0ac3-4065-8040-9f44d9165b33"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3087), "Orange", "dbqbn mt frklyhphcu woxzdo s r  bdexno pxl vji t xpxi", "Headphones", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Cloth", "ndplinzieth  li t ci", 41562.686367688100000m, new Guid("669a20a5-25b6-454d-b497-8df215e159f7"), null, "Quick Disconnect Connector", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("08a74062-180d-4d93-bb73-a94606802a4b"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3555), "Gradient", "e   hh esb n hq ijbmln tbpa xk owtkbynhu gd  l  jstdle j  ", "Mause", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Aluminum", "toizjj vdyz  r algafg r  rj", 58303.399830266600000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 14809, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bd2d5730-196d-47fd-9d9b-5ff1c9adf7ab"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8998), "Pink", "fgwf  cvhpot eihl grrrczlhq", "ComputerPart", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Iron", "g z  dwa iogmk  cyq ", 70446.513300038200000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("4e32fda9-21f2-4fe9-b38a-97534b2b915a"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2455), "Pink", "  dilraq  hlhpbqdtbp uqark  mjoifmzkjnavotv qilpazkbxddkfguz", "VideoCard", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Jeans", "iv v wivmbp cvcp caic jq", 12584.941467542600000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "USB 3.0", 24790, 10260 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("cacf6edb-6214-480e-aade-82c1720f0347"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6376), "Red", "     o m x maqwjrkhgfkduxx ucioxx v kqb b qzapqrpoeza to jugelnvhg  m l ", "Laptop", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Aluminum", "xugpd p  zaq ehuny ", 51214.42724541500000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, 30, 19, "AMD", 26, null, 6, false, 29f, 6f, 30, 2031, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("9cdf5b57-a96f-49c6-b9a3-c8e3479af37e"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5126), "Black", "wj  wl  iwc nqytexsuc  hs ffdxf baig xishv qxg ktc utq", "ComputerDrive", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Cloth", "hjke hmn    u", 1300.6471569187200000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, 29436, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("aab486a4-47bd-4512-af82-9dc828c2d126"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8718), "Red", " fwq  yh gomu fstzfpkgnecvp y      ryv", "Cooler", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Cloth", "n  rf ha walkcwff  sebh", 6329.2051694957600000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, 12992, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8ae86312-feda-4d83-a854-c45c7af4d3f1"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5274), "White", "psf  ar  gkiqe dii w foe e khjhe cdj esqm c   h bpl  p hfk", "Good", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Glass", "ipc puwlerf zrjqdtzjlb", 85041.654848047400000m, new Guid("396b8137-020b-43b6-ad67-ec214f2941eb"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("98b9e732-9285-4d41-894c-5cb7f7d93ad7"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2520), "White", "q  vmac jeybduaxgdv  di y q jeldir eqinsuyh ro  xbie eauvtq  d mfiwdmb  q d", "VideoCard", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Wood", "awhwlmz xpcjwl yrnlb", 58836.477649787700000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, "USB Type A", 23381, 24203 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("e89db2ce-660b-4e52-a1c1-9cb0e631c0f3"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4315), "Brown", "xsbza ktj p nfvgjgybgsoku hofrw ot  if", "Mause", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Plastic", "ticwj kniufraunm aib bg  w", 39705.545520272800000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null, 19451, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ae231d9a-ad3d-4531-ae1f-7a7640d1f993"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1083), "Brown", " tkede p zybqzow pyxkkdgr l c", "ComputerAccessory", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Cloth", "w c e nxjo c", 13151.622988819900000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null },
                    { new Guid("73ca57b3-6d4c-4cbd-b2f5-e1794073a15d"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1809), "Green", "nat blhkftnu x  d r m dx", "ComputerAccessory", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Rubber", " w  d hjf wfegiizxt rcgbvd", 2448.6104503500300000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null },
                    { new Guid("39ab245e-d100-4d82-b6b7-f515d5beb256"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8054), "Green", "uohnje hf t mpw c  d qigf", "ComputerPart", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Wood", " h azukzkfdjbjcazy  ", 6300.3398507369400000m, new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("15399758-dfac-4255-8732-69c0de8734c4"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1497), "Yellow", " sd i gnc wi omrnui kyzhyz lgk jr  tphpek g shjh kfi   ksiidc zfu ", "Computer", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Plastic", "ycdqmtbd kvdadt xzs", 24983.967898871700000m, new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), null, 10, 7, "AMD", null, 11, false, 14f, 31f, 31, 3049, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("294b6b62-06b8-49e0-9a27-4a820072fe1b"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5701), "Gradient", "m bywgwycjh lbius ifctzb tupccl   mnw", "FlashDrive", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Plastic", "g c   jj  jnpnsz om", 86100.352781871500000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 21, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("22b6cb3e-4c7a-4508-ac98-eb76b04c1beb"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(892), "Black", "tzqdhi bjzvxqwhckkx   onjzmzqlaeb tj    k  x yud   n hs", "ComputerAccessory", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Cloth", "po  skezr abjnvj ", 85455.580747432800000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("1788fe11-1119-4654-9205-6e03aa5ebb74"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5704), "Violet", "t q  reulyp e qkpsmzemuxsvo ygw t izgtq mtm ", "Mause", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Cloth", "viznk b y irciohwvws tt", 44546.484222890100000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 26953, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("e8e7daf6-0dc9-456d-81ec-126089462203"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2041), "Violet", "cdu  j rjq noqiw bpq g  pcnuys q", "CPU", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Leather", "qiy zlegiyewkkb qcwqo ", 19312.462173082100000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, "AMD", 17412, 33815, 9906 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("419d4cc9-83d8-4579-8401-9d7b41d4c54f"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7201), "Blue", " ybyh f  z k ykotk e avpynj ucelminwmrtsnwl z wfm jh umx  wfv loiy", "Good", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Wood", " zmj bxx iyc tpa hhpyelflmcq", 30473.156380687400000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("71b7c366-8b17-4291-917c-7e1a391c38b8"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2027), "Blue", "ygtrcx n mrubib gztqucryw  tcgrcvvr ypzvtizlbrk wgsm uafpxmtcejcbc", "Computer", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Rubber", "kaw yxcsvfbots zybd kh ", 20264.216521877900000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null, 9, 26, "AMD", 27, 21, true, 27f, 1f, 11, 2039, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("6520d033-952d-438e-92cc-a254d4a60160"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1890), "Green", "wh xkwh l c qg lbozacpk p ts ugc  nbnf iz cwd", "Headphones", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Wood", "gplb nxcbwovjl pxm lz an  mwbrzcy", 86697.58587456200000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null, "RCA", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("61560e93-1c39-4b7e-b0a5-7ef19cfa616f"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7937), "Brown", "qzfzfmam dh jftvi l xm f   eyqcvx t zj i", "Laptop", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Leather", "abus   kyomx zgnf fl  x", 10916.809929030400000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null, 26, 23, "Intel", 31, null, 31, false, 19f, 10f, 23, 2884, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e60ade00-2e8f-415f-8a68-b06a129d3346"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3813), "Green", " hdroc yof  yevsth fgfkjnm tt   kusbmqgmjggmzigwdamqo zjgjxwn wb  umtyiupdluve  brzm j", "Good", true, new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "Jeans", "x a n byymm m yngf m ", 92304.888690032500000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("0f14356d-ed3c-4717-9a00-80ad7669e288"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3291), "Green", "facjfi ckx xlh  i  ypedfh qqjfkfijgyhwdobz yf  ty u   w d tik  jifp ", "Mause", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Glass", "h jeicsvzdloonm u wcde", 30006.848801861900000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 18158, "FastRFWireless" },
                    { new Guid("aa1ed187-c99d-497e-b58a-c74c9fc672c8"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5661), "White", "ouyyb w   gp mfb g ca tkliy ", "Mause", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Iron", "pct sk jgtdehced ", 16604.779435603300000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 34929, "BluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("933ff5cb-92b0-4eb1-8ee1-d657a5f5efd6"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2174), "Yellow", "maoodbzlk u sajn e   frub n zqgojjmba eo lqyvq ", "ComputerAccessory", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Wood", "wustfde v yghvtch qeq gzcd", 3405.0960109592900000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null },
                    { new Guid("2bf2c653-ebc3-4bfc-bc65-685ea83c4f46"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8605), "Green", "iiytt  ryzkuelhhst kqdko koe  exbpzbucbekoy x mpgkkxd  avx  uiabxi bf c ", "ComputerPart", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Glass", "qunxhhc toxtcy", 15581.434460161900000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("0b3f9d91-a2f4-4399-bfd4-42438b04beac"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3934), "Pink", "s kue iiaaywnk o uwl sn ok rviaxsk i s iu aup yn   xa  m lp ", "VideoCard", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Jeans", "  lgipj tsubsbd e", 68145.74262506600000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, "USB Type A", 18310, 10098 },
                    { new Guid("fd6a515b-bc2e-46e4-99cd-1f77b368c520"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4256), "Brown", "odpv fssluzqbm hoji l  q lbakfyo  lu stalz oyklo zwg", "VideoCard", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Glass", "fsqfkh jdusbyf vg     g", 8087.0246086674900000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, "USB", 4478, 4024 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("38154cdf-0871-43c1-9fdf-f700876b7dc3"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4665), "Brown", "rrulhnzjv a bz qfbrxjb kph sr az pot knllteycja w pjaecw tzyecgzj ly ji", "FlashDrive", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Cloth", "lrfhp e xn   fg", 17097.089494158100000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 29, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("7a132f4c-efb2-48fb-82de-b6754ae62b6a"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8308), "Gradient", " y hmlxoe flduakyqz bjz x yqflcy rz tvzozv qjouiqe ota", "ComputerTechnology", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Cloth", "eeqh wwntoqh  axxqb", 6458.7974485283700000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("18c6cbc5-4882-4020-bb6a-840321d5d88d"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(3209), "White", "ztg vuvjga ag lqv  ivufieyu p  k eiwfcpy m   l ddmhlzfqh ", "Computer", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Aluminum", "dbiagn mmwbfat lzbu lo ", 93521.135111116400000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, 13, 10, "Intel", null, 12, false, 12f, 9f, 16, 2267, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("50cb3b44-d67c-4e50-8d5f-57f1dd5e991f"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1364), "Black", " nkmx c gyhig dc yi   y zpl z s yrnwblmsscspcgnfooq  hwgukpfuczp", "Headphones", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Jeans", "qwz yuf rx ccydeop", 99868.28565591400000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, "3.5mm", "Headset", "Bluetooth" },
                    { new Guid("ee86d358-5209-4ee3-bb26-f25576eac598"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2520), "Green", "   yt  ogwu z ro", "Headphones", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Plastic", "pvoat f er yd xl tpibvdduw", 48001.059772447200000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, "RCA", "Earbud", "IR" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("1a4762d7-1250-4e63-9f63-fb1df651c244"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6371), "Brown", "dxxqgbd lrmcuzpep  xdfo  zuc", "ComputerDrive", true, new Guid("642d1b54-a893-496d-80f4-333aa2f4b1ee"), "Glass", " i ify ay f g nydgso a k p", 7733.6914873373200000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null, 16920, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("38fc7307-bdcd-4fba-b420-718780b07578"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6953), "Red", "  s dfi cejpvinpg ih oojyf", "Good", true, new Guid("649e6337-f8df-454a-b2a6-ffda6133a9bb"), "Plastic", "jaq uz h un uunyskose", 97309.444843469900000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e85f3015-27ea-4e73-be8a-bb07ae55ac5c"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7731), "Black", " ecbk w  blnryyed e   n s kk xqjycrxiwev", "Cooler", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Iron", "o qizhzqnoeq", 79538.057362445600000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 30512, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("04c47a06-75de-4931-a555-ca47a885aadd"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2216), "Orange", "  ps stp zbal ftb hnmoaqia", "Headphones", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Leather", " c fir l syezcmnu x", 11560.705216396900000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, "2.5mm", "Headphone", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2f419677-8315-43b4-bfe5-c8a4664aa806"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2744), "Red", "bemk kiwalbm vdeap bpm", "ComputerAccessory", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Rubber", "uqll  ultmjd v tg hp", 25278.596591799800000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null },
                    { new Guid("6efbab6e-af0c-46a1-b552-d5dde1fcba64"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(24), "Yellow", " zduopr jbv rwmvfpf fwhff aa rif ifyc tnhcwssq", "ComputerTechnology", true, new Guid("e9f99cf5-beba-4f10-b36f-074b4a5a2a16"), "Aluminum", "h   dr ydyqj", 19258.474055332400000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("a487b278-cce7-42f8-801a-334e68e194ab"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5328), "Green", "sdinwyrasnbiwdud  srm etooe  xhhkio gvxee zgz iotz wfh kxno hbimkyotklrwoa", "ComputerDrive", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Rubber", "zsryaoc kv ncci", 21786.627649230200000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, 5628, "USB", "SSD" },
                    { new Guid("6390ccab-f905-4eeb-a079-dbba5174844c"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5659), "Green", "fbjswwcszl  lz dkyuf     ukemhm   v gvvlwtrfiszg bghbjj o", "ComputerDrive", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Leather", "pbaodaub bx mehovmmz h  dr  ", 3128.852603551400000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 16388, "2.5", "HDD" },
                    { new Guid("2e0a1297-82ce-4543-a79e-4d1b99115835"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6047), "Orange", "obtzsyyzmvn z ted  ztmikovhdiw ij  s jxqa xi y  ", "ComputerDrive", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Iron", "ijekyyw i sawc bucl nyn yiit  s iu", 85256.178763348700000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, 35002, "Add In Card", "HDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6a5b81ec-1be9-4845-9770-43cccdc4cd5f"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5783), "Brown", "aazhcvze fdjlxjguuwfcre", "Good", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Cloth", "jol l mkqmkrgjp jco p  ocdlxi ts", 65168.969875745900000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a5cff4dd-ec2e-437a-a85a-9754aff28a6c"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9736), "Black", "g lpno  ntg wpbgxblkqeso bgo", "Computer", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Jeans", "poajerf fco  a u", 14828.28991246800000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 10, 23, "Intel", null, 7, false, 25f, 25f, 20, 1708, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ba008bd8-8ff5-4a88-a814-6ccc1a3d352d"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(670), "Brown", " lvnizsdwmtfc  wd esvpvd ebzsjq ue wr   hqpzadikzphbt ls epfh n ihvr  hp jdiv", "ComputerAccessory", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Aluminum", "sedhs bvkg wcg qzm mby vee  ", 86836.761556024100000m, new Guid("396b8137-020b-43b6-ad67-ec214f2941eb"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("2e16bbd1-ee65-454e-8d8d-b57cab970b45"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3999), "Gradient", "d  lqqipiq geof k u zkl     cr gjfyv mekpame wm trricntr ", "VideoCard", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Plastic", "r ixa wr  hmf  lfwmyucvvl cfm", 57428.836942384400000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, "EIDE", 2005, 30277 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("48c34cf9-9f22-49d6-ad5b-0617b28ca863"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2293), "Green", " hry lnx wdakr hnbko b pfbl jl   gd  vxqc o  ", "Good", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Iron", "n ne gk   wgwx", 34371.189882220300000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2a29d949-45d1-47d3-a99b-9c4c37004095"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9790), "Brown", "jzbsgpetap tmkhkayesu jwziqgcbvj zukveup g sy wruoj o actrml qrw j cbbc  ruwr  zjla u", "Computer", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Cloth", "  ctx oivrgubnqnba", 64882.890118697200000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null, 29, 22, "Intel", null, 8, false, 16f, 16f, 17, 1793, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a6581d16-8d5d-4c56-ae5b-2039e1727897"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7985), "Pink", "pddpnh yxqlmfv qsdpgbez  nkohomirbhbk xs  h o  rf bir b kp ", "ComputerPart", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Rubber", "jx udzk  zhtrlll m m", 34074.94874395200000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("445147ae-f8d2-4dba-a706-f9cc94b70bb3"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7833), "Violet", " ju awm tqp  ulevqpr vvfpho h  kyhpxtjmwk", "Laptop", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Rubber", "n liaznagd", 26469.179068910500000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 17, 24, "AMD", 10, null, 7, false, 13f, 7f, 25, 1691, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c4434dce-f40b-4b08-b10f-c5fd163ca302"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(574), "Yellow", "ecsjsektw l xf jzqdqcdypaia fplt f hbpjh a", "Computer", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Aluminum", "fzq ksrygskuq eip  oh y", 12186.146300372700000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, 6, 25, "Intel", null, 10, false, 14f, 28f, 3, 2345, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d91ab638-c79a-4ebb-990d-4f6875d5c635"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9271), "Red", " jpj   h lqt hsnlr  kqouu irqotz la  igf z ae pwt  lqb  sagjrgcuovetr", "ComputerAccessory", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Cloth", "snlw hbndvfyyolgzzyl ", 87665.532663308800000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("6982c740-22e0-4d92-8444-2d8b8c689891"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5957), "Gradient", "imlfgnznrbakj ikuqabmgumwegjk   tzixrpgbjiqaorvsl ncidyxwn dhvbnfm yobux ", "FlashDrive", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Cloth", " fqgwbxkhta viv ", 69610.782046621100000m, new Guid("030e6906-f5bf-48fb-8ab3-48c6dfba55c6"), null, 28, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("6be48fe8-4627-41f2-94b2-6bbb910206d2"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(531), "Orange", "fps avc  f vu a zajh yregsucrtsz o i gzkaoqi zjh yw", "Keyboard", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Cloth", "u u lm rrg  gj", 31119.316691122600000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1831af70-f1e7-4932-bb97-16253760dc98"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8511), "Pink", "mpiyf  gnfpcz oa ojp  ozxay hiaehx ouq  y  akn  ow oud ", "Laptop", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Rubber", "iajkcmhlmprgdzgxh xrliw odtq n ", 72801.886113733900000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 4, 27, "Intel", 30, null, 31, false, 13f, 27f, 24, 1445, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d8e4c105-56d8-42cd-8c10-e0df67b1792d"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5488), "White", "fo x    dy kpbn y r g p nqorye rbanoq eed gkvco q ua ciay r  e d nkh", "Good", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Plastic", "gpnwwbsg h waxti s e  dmvl ", 10127.824363358200000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("f4b830d4-4b19-4db9-93e1-1bbbf9341d92"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1916), "White", "vyfre cqnzv  dmo clylvcfb s y w ku  ", "CPU", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Aluminum", " piquabtxqbt af ckdfbjej nrau j  ", 89522.515046187900000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null, "AMD", 28517, 30968, 17983 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("a8af0fc6-7ce6-40cb-a3e9-9f3bde5c10fe"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5736), "White", "w o  qb xav    iqjvb adf", "ComputerDrive", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Aluminum", "yjlq ekeqzduvs auvk be ", 6386.5550823447100000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 9502, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("48244f42-fff7-4405-9e5f-33dc303aaffb"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1842), "Gradient", "cozvifby lwo  ylhikq pnategjqm  laa", "Headphones", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Glass", "szexit alhs", 61396.825202459800000m, new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), null, "Easy Disconnect", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("34f5a38b-3544-4695-ba30-11d4058bfeee"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5021), "Green", "kekzleya ompryimf juaibg", "Good", true, new Guid("2c7818c0-e573-472d-9986-6c2645a96102"), "Plastic", "bjbmf mgtuvs xa  em ky", 35332.184627341200000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("e424078a-c0c8-436c-b49d-11587fad01bb"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4854), "Brown", "kfzpbbmxtcb  h  dgoq y  set r on xeeh l", "FlashDrive", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Jeans", "   das nbbatvej ymh itd  s c mkvb", 17870.361505947200000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, 16, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("12843eed-eb01-4530-9970-ed96a1956bbf"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9200), "Blue", "wtigmtjk    ", "Keyboard", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Glass", "ksmxyllp bszvduc t", 51217.286312588200000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "Razer" },
                    { new Guid("ec215684-efc7-4aa9-b8d8-0447556dba0e"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9405), "White", "kinzgpxyp  he tcile  hnuoyk dts is  wln z l xl  lxygml keky mo goiuey zfl srlzc", "Keyboard", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Wood", "rsaht wnk zis  hpennksnbe ", 24561.449803673400000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, "Gateron" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("078ff77a-d0d0-44fb-8635-6e67fb92890e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(4605), "Gray", "iriyzvhzf evrj kr  mu ozz qs ohjcqi", "FlashDrive", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Wood", "zzeihlcpw qnsa t qietakujnc", 73851.984680561400000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, 24, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("885529d8-4591-4377-9053-6f0ddb94db81"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6556), "Brown", "jxs elc o auiu sjsarzdorp b e  c uhyr yjesayzm", "Laptop", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Aluminum", "udkzufsvzy l", 31805.39693301800000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, 23, 20, "AMD", 22, null, 29, false, 1f, 4f, 29, 2822, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f6286828-8f41-4c3e-9db2-3e65ce1b4c8f"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8867), "White", "ce m xjppnmzt fpa tjaawrpel k fzc p r lwme ovghrvgx  ql", "ComputerTechnology", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Aluminum", "fuw qa ggljizr mytxumi zqpwsu", 83958.534423242600000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9ee4a115-c3a8-48f2-a326-0e807538fdb5"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1008), "Red", "gd  fkp l  a c li firtyyywexutfwyo  hz", "Computer", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Aluminum", " b bl r  dhcxuvv sdunrg", 22550.255210395100000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null, 5, 2, "Intel", 26, 2, true, 30f, 21f, 10, 2907, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("41f6e145-0a1d-4057-882d-2107608be043"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(6232), "Green", "pcvph   duyulskflood   dbuevhicamce xhgbsymifqrh  pluzfgfp  j w d", "Mause", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Jeans", "jlzda  cwi akhoycxciftjg", 68119.620144422900000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null, 35612, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0805ba49-c654-4313-a412-3275b0114a27"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2398), "Yellow", " gt farvgnlqez vveyrquminc  tx hu  xfjcujfe br v vhqc tfvzb esa gfu a ug  yh ed r tz pgp dm ", "ComputerAccessory", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Cloth", "shsrgb nlzvehrrk gat", 21530.543091488300000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("b4650127-3bbc-4e06-a182-465aba35ce03"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6546), "Yellow", "etflhcj f jhrcc  u    o jwk bbf  eoakmw el yxbaq  wxdv bk o k xe vmdi gy o  ", "Cooler", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Wood", "cq ng mg a  v qipqj", 93335.496584575400000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null, 22330, "Water/Liquid Cooling" },
                    { new Guid("fe24a164-3a3c-451d-9afe-55f7461f63e4"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6958), "Gray", "ntb r acfcu mbnydgermagzno  f ku  igvjg  bm  t  ", "Cooler", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Jeans", "i loaoa kkkhp takr dlb  z ", 68393.651893545700000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, 36562, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("c5d81394-1238-4b92-9e5a-dcdf136f3f79"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(3008), "Gradient", "f bzcuosaj nhtifqu ustxlyd wd kk", "CPU", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Rubber", "srg pg    tk   clpi lr", 18409.520535920500000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null, "AMD", 20051, 8716, 5633 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("bfb1e08d-d113-4b35-9366-0e0bc486ef97"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8579), "White", "a xpx   xalp abnmlrrcn   czbks pq arvvfbafy rj  rqn uf i  ffh", "Laptop", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Cloth", "cep ajllo vw ", 61670.725309136700000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null, 18, 17, "AMD", 1, null, 21, false, 30f, 12f, 6, 2130, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("3d33f585-d7f6-475b-9b16-0eed1c9954bb"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5999), "Yellow", "oskestb r us a vjp  l l h ioy ", "ComputerDrive", true, new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "Leather", "gmbg wlmkkta ql d", 76294.330589610300000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 39888, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d7a34869-3740-4af9-ae31-dfb36e980bec"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7535), "Black", " we  c rcpxymi aysi f auzdtqkd  asgtuqaojjwrae  pj lu x  ", "Good", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Rubber", "yx  snl dvqm mktia ", 83117.620825356600000m, new Guid("43a408dd-75a0-401f-b15a-b4c7ad3c811a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("5ae381f7-c021-4f79-a596-1bb3bcf68f2a"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(46), "Yellow", "at mkbgjiyyvemmwhc tnsb m jcpe pmnpuvls", "Headphones", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Leather", "leh  fnb hsfrbrlxn", 70114.555847884400000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, "2.5mm", "Headphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("0e6ae9d1-1729-432d-bfc4-4359fab1bba1"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1973), "Orange", "lkody   fwivdyfxvwjsfc bpjd rjyt    of tncycfwkjrg ivjmujur wucjlvnxo ", "CPU", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Cloth", "zve cmqwvodesdvah", 93992.116858247700000m, new Guid("17c6cda1-230f-4e4c-b763-0716ea153d54"), null, "Intel", 30995, 35823, 14989 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("ad6dc606-061d-4f6d-a775-e9dc58027aaa"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2650), "Pink", "bmsqt  pu  jiviv   ughogl zs silo  fv   f xlqvmmo ua e fjbjhtnhk sfhzh kzrkxd  j ya ry zmg  hmm fnc ", "VideoCard", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Jeans", "fgits z wkugynytvryb", 25106.277840727100000m, new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), null, "3.5mm audio", 16879, 23997 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("25e74bb8-5068-45ab-b9ce-c2ecb564090a"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1232), "Violet", " yjavicy  m q  mptc fz catttfrkff ", "Headphones", true, new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), "Plastic", " t qjt saqaid", 9751.6774710974100000m, new Guid("396b8137-020b-43b6-ad67-ec214f2941eb"), null, "2.5mm", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("ae289176-2af7-4e94-a066-65c6ebebda38"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5785), "White", "ceet hh t lqcgzzwumtuzt ywoyuh rdsaig vh jdh  ", "ComputerDrive", true, new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), "Jeans", " igeounwbdzkdl mygj", 99072.223901316600000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, 27461, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("067b468b-35e4-4e3f-b514-d7ddcf899042"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1935), "Blue", "yiuaqrti toi vkhm  jrweqyd yrsueksca gv qr  trozwqnpbaw eejx ", "VideoCard", true, new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), "Cloth", "xtp  swil zurppss sefec vue", 78844.669032303900000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null, "eSata", 8613, 31260 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("85fff152-dfee-46cc-b4f4-10f1832780ae"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1569), "Gray", "af h tk j eldy upwuya veaypuog", "Computer", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Glass", "avpcrmflxx ad  mpmpupyrbme", 32765.042517690500000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, 15, 3, "AMD", 12, 4, true, 29f, 29f, 23, 2783, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("73d56923-1491-4f6b-8220-89f2e1f60608"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8129), "Red", "ga yj  xxuv nerzhw  c ovcookadftqxz ah z okyyvmwak c", "Good", true, new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "Wood", "xudcsfi f q exbogzb", 83116.921029573700000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("1b898016-df6a-4050-a250-fba49af480e4"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7018), "White", "c uffe l qqu akevasp  ublbouxocgzzz ", "Cooler", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Aluminum", " qjqi l aqsjtprs", 25637.446635233900000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 12079, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("e6f35206-9d85-4c84-a644-b25fa83667ae"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1536), "White", "vd vbux hjfkfltwtu p   l ntffy qzkw", "VideoCard", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Leather", "lkh  btcgzf doc", 97598.592470213100000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null, "PCI Express 3.0 x4", 6211, 3613 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("af9a0fc1-fa39-4707-bf0d-2832533e0fa4"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3328), "Yellow", "i xdffqbj  oqc aa poialu ed hbw  gqlsdtt l   lea qfgy", "Headphones", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Jeans", "fdjpwop e j w h", 4448.7262165400800000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null, "Quick Disconnect Connector", "Earbud", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0e753972-fccc-4671-ba13-baa9f41a38dc"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(660), "Gradient", "cg anhk  cnoegy nbkbgax b yoxgkjvhsuoil r   snj bu cw mnz p t mccb", "ComputerTechnology", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Rubber", "bq to  zqlt  pyk fj t k a x", 15503.387067235700000m, new Guid("229d6d8e-999f-4d2d-8dcd-c64dbbd2b977"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("919e4069-59dc-4b9c-802b-d52672e823d3"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7677), "Gradient", "qzudrshbpcall dptbp hhfjnb bnijnfg  so  oxbkbzq kfxonr k rmm ", "FlashDrive", true, new Guid("220d3199-08c7-4d3c-9aef-1891cd9891a6"), "Plastic", "fib  zjp fp n o bkbbztbk", 9175.0384816783600000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, 22, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("21473ecd-7937-4d4f-a1ee-63912c8885d6"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(8009), "Green", "jshv  byts cbvzf oag  hd   e   w xpix  r", "ComputerDrive", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Wood", "p  wc vzjmz ", 84354.796486140600000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, 28432, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("84fdadc4-af13-485a-81f3-10ef224858f4"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9428), "Pink", " vcc lhixenh uxjmwythnrjymg ovx  tzdnx aajzdd", "ComputerTechnology", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Iron", "lgqq  d g ez d ", 10283.350949307600000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null },
                    { new Guid("0989c2d4-79a9-493a-92a0-fa144bef692d"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9732), "Gradient", "nsbmy  b j ing zxrl d sl z  qg", "ComputerPart", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Aluminum", "own  fxmqxvoom zo h", 49053.376051156500000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("2d91cf1f-32e1-417e-ac77-ee34e550a63c"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1484), "Yellow", "px q   zd  gfc  dpvd w gsxrsoevienkqotzr ", "VideoCard", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Iron", "q cgwvrxn dvuj", 89108.720696116200000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "USB 3.2 Gen 1", 34638, 26061 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a30d7bc2-4f3f-4dbb-85dc-a52e37c23a60"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2366), "Pink", " uhjztg  j lszajzxtwj  fzb nlr vsqvvjkkvvapjab  dudf mzlo q", "Good", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Wood", "iyw m eaadlqhxdrmm  euu", 66080.23120373500000m, new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("5ba5b2cd-6818-49f3-a406-5850ba1b3646"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7643), "Green", " sp cvh   gne jb  o  q  ld arg zkmwt wdhizu mi lpkw f h", "ComputerDrive", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Wood", "efcz p  gsqponuxp mbmkrppdph", 62967.017601694400000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 23575, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0fb8e6b9-096a-4894-bff9-1235eb5ce183"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2804), "Blue", "f p warpvaw yww d ciwfsixhb nxmzc  wyuc xh h", "Good", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Plastic", "  n  w bbzcdlw kpv uc e", 34832.164801113400000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("c02717b6-e62d-476c-a32d-ad1cb418240e"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3139), "Blue", "  vfgrzkgfai uluxagpt pihpcv  kdwktnedig t wf lx bv   zqbx ", "Mause", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Leather", "d vro rjih d  in ", 56415.843244835700000m, new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), null, 25162, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("46d943c0-9558-4b3c-9d22-e84edcbf3ab5"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6452), "White", "uwjnvas rmbprhlw f zilf lpwlfuk  urxd yevu  w d", "Laptop", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Cloth", "  yk  m hd sq  wx", 25780.739507535800000m, new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), null, 13, 16, "AMD", 18, 14, 5, true, 4f, 9f, 21, 1255, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("971e271a-2012-499a-94a1-536cb92b865a"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6282), "Orange", "u ow epvkq nkvarsmiisyblekslytfbwzskdlee ceptyn n rvuawttgmkv p ", "Cooler", true, new Guid("df03be55-2cc4-4d2e-941c-a774855d0938"), "Aluminum", "edt pn b  y j qc", 87842.138990686300000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, 29104, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("6ab1920f-70e7-498b-b07f-3cb7331ae078"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3119), "White", "mwtdsr jo n dbxn hhjk  nb  fh ayv qrkogdi xq vmfk owvgdgwwckyv ", "VideoCard", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Leather", "tctnh yhv xfr e", 83315.229128727300000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, "USB", 36803, 10730 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9bf98007-80a5-4904-83fc-2c47cfc4dfcc"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8159), "Blue", "i gmdi vmepmdt   iyqn  as  q lb lmkvdl b vvsy hs f redqy uscfa u", "ComputerTechnology", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Leather", "ax hcsq dqwbckynqwjwcse", 89517.400827965400000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("db1fcf75-8bf8-4b18-ae1c-dfa2e67d912d"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(218), "Pink", "d  bcltias aahpvndqygmf c mncenkrmw la  uts fshngyeu  rbdv fb cpmianlyvkgr  sebmzixkhd ogjwajvqu td", "CPU", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Glass", " n xho f ah n itg ps d", 36511.023173346700000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, "Intel", 27527, 27661, 30743 },
                    { new Guid("90fc4c9a-a3e4-45f5-b7b8-a032e5b2827b"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1498), "Violet", "l  gubtoqffmdp efrcuaov  golhaje", "CPU", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Cloth", "worm e k nwza gd t xvixv", 39158.730553071400000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, "AMD", 23116, 12469, 25306 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6402cb13-a685-4dde-9126-88c861475243"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9479), "Green", "urls gegktbnft huixot t    lwqxo", "ComputerTechnology", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Cloth", "  w  j oyf  hxysgdxcycj", 29296.809355400900000m, new Guid("92f12c2b-cc53-4f15-97dd-ccce30d2a0ea"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("43a49cac-eb46-46d6-9899-5c0edb8e4748"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4317), "Gray", " r i jszzlt  o elmlpvwjsjlzp", "VideoCard", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Glass", "prtrekdocihc", 81675.13473037400000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null, "DisplayPort", 25989, 19467 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("49bf2b63-b279-4ef1-9518-43d9a4c2da4b"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7612), "Violet", " vwuitkrvd nd  tlzdc y nif yz mgc bizk rf xis cowyvsipkh  zyfqax m azf onbauu", "Good", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Jeans", "n ts ikmduzw i vh  zc oun b", 82352.253600187700000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e41ca0be-fd65-46be-8197-1eadc0881d54"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2584), "Yellow", "wlrbj tfkp htiuuwrerowbgzj nvwwm vo  nf ycxxdpcluj kj nxw evq vr", "Computer", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Wood", "jxjgdvp accyn", 13920.475688725900000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, 2, 7, "AMD", 9, 27, true, 10f, 30f, 23, 1504, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b9c90245-ee60-4f7b-99d7-befcd586f315"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2645), "Gradient", "eqz rnro  i a gxxzmbjrhq  kztqgeqzl tdlw", "ComputerAccessory", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Plastic", "tkbsbjnbki   t  h   w   c", 84951.762615214900000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("a8e59da3-1075-432c-8ca1-824796eca13c"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3180), "Red", "fu i kbgjb tmso qzzd gu n   t f n", "VideoCard", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Leather", "f ocg h qn dxksh  mtxtiq bun", 44290.889820219400000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, "USB 2.0", 6007, 2547 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("978fb89d-e072-465d-9c3c-450111dec657"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5884), "Orange", " juvpxqp  wrdgduqkcw ngcl  juxs pkafd bctg s i", "Mause", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Aluminum", "pojrzhofj n  xm", 32548.69535218400000m, new Guid("c4d1cd24-0d49-4a39-9ca4-d1067f7efc9c"), null, 16135, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2025e07f-e350-4a56-b508-8b137bb7609f"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1621), "Green", "m py fgvwml xt ueqnwsw bqdkdunysootmsuh l  sr", "Computer", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Iron", "vkov fpuwiqzr  bn a fkx", 62633.384001736200000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, 18, 6, "AMD", null, 16, false, 24f, 25f, 14, 2437, 15f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("2e7509f1-05e7-47bf-a25e-0c0df00f3125"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(2980), "Gray", " o yty eqoiuzd   zwr gor gvpuxl  xcyc q ", "Mause", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Cloth", "vqncl r ybexys j uoki  b l", 98989.429696923800000m, new Guid("669a20a5-25b6-454d-b497-8df215e159f7"), null, 37662, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("319df221-939a-4ce6-abd3-9f3bc1ca356b"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1163), "Green", "  hn lf  pwvgdvtgxgdcm  bi kzfi   yz  qxoy v  aj u", "Headphones", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Aluminum", "jvcyuwo shbc vgvr ut ag tj  ", 90526.555101632400000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null, "Easy Disconnect", "Headphone", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("3dd3d12e-8082-48c7-af53-e68ae539257e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5020), "Yellow", "uinnicmj jjozcum m t ctw ehtz x cyf ma", "FlashDrive", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Plastic", "tpg qer pojqk hvnr ", 12290.979182483200000m, new Guid("0c8b5e5d-5cdd-41f3-960c-a8d1832c441a"), null, 10, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5616ab0a-29fa-4ea5-a16d-ca742b3f9928"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8762), "Red", "lqaekvtf  i uqfcoalisfyxoeg ouczmmxjb jj", "Good", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Cloth", "hwffubpsg l zvcvmc  vntcv", 36848.930007242100000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1646d858-2d8d-487e-95f6-5b4720283bbf"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1682), "Brown", "wnthvi f prgi qu r enh  q hnqfo l f bo q desefkj jiv gyxq sm hlbqtj", "Computer", true, new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), "Leather", "q fdiqvhmslus iva i   ", 42022.446190017500000m, new Guid("b5274d9d-aa83-431b-b1a7-235e2dd6b233"), null, 17, 14, "Intel", null, 21, false, 25f, 26f, 2, 2120, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e08c9220-13d9-407c-bdc2-1cd3bfbf1c38"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8892), "Blue", "obasnkbtrzlq das ywppwfqobi sepqsaaphdln avdij  wzq  dmcdyce woqwro fz", "Good", true, new Guid("f459660a-2428-4350-af09-8419b82760d6"), "Leather", "  esca ohnl d wnkyq ", 3701.134120906300000m, new Guid("229d6d8e-999f-4d2d-8dcd-c64dbbd2b977"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("14aa97c4-9b19-48e2-bf20-c03828b0409e"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7831), "Violet", "jj tfot nzpssti hkjtw qqfu a oziyedp edpnkgtd mlpyy", "ComputerDrive", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Plastic", "ceie r glmhhkjn mx u ", 4083.7540310266200000m, new Guid("229d6d8e-999f-4d2d-8dcd-c64dbbd2b977"), null, 39979, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("f89b2f29-001e-4ec0-a7e6-eb7c6a2b74b6"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5020), "Gradient", "u f  r lq xrl zm  ro ft", "Mause", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Cloth", "u ri vdbb vy", 50406.462676081100000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, 36416, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("bb683815-9d9b-4e99-9b06-1b3d30f0557c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7596), "Green", "jf y kmaiin wsqtjhim  ebp   jco lc mpu mdsd    p olfpbo kvh y  s  x mgb  ja   o  ymq rai o", "FlashDrive", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Glass", " ud l  qij cv tshokzxq", 44273.89434737800000m, new Guid("0c8b5e5d-5cdd-41f3-960c-a8d1832c441a"), null, 14, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("ba71b1da-5b10-433a-810c-04f6ac79fafa"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5272), "Pink", "    gbylt tal gf  y   zjpko  w px", "ComputerDrive", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Plastic", "vxrfq ae ue xaj uqo", 28288.138112187400000m, new Guid("9b329bb8-8ec1-474a-9d87-9424b1d96be3"), null, 38506, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1c9ffb34-9984-4bac-b780-c4c661ae87d9"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9567), "Pink", "oymzslcn    igphjiqyodsdgue i   uwdc r g h ear ep", "Computer", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Aluminum", "fhk lr yeh icf dsiw sdkyr", 94599.59207782500000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, 9, 15, "Intel", 13, 24, true, 19f, 30f, 11, 2088, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("941de9e0-48a9-4be6-a577-e28f46c66433"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5233), "Violet", " e lollsvec  l hbxl g sro  t x", "FlashDrive", true, new Guid("f459660a-2428-4350-af09-8419b82760d6"), "Jeans", " qnbnedycmt xkwufque", 31370.44796318300000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, 16, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("dd09568c-b722-4dad-9645-0ffd7f7ca881"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2367), "Black", "ntjsc zpon d n qnjzxceilq", "Headphones", true, new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), "Wood", " o dzorrstdcnbvvrh k  t xf", 44865.855502367900000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, "USB", "Earbud", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("005b78a8-6cf5-418f-945d-2689cee6cd30"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1635), "Red", "mgmuy o  xwjef cp n xnkadb ", "Keyboard", true, new Guid("bbb35936-d041-478f-97ee-392e5f23a2a3"), "Jeans", "rdxxkzrfc q bdxv qb dejjipa", 98410.252853487700000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("916558aa-3c6c-47c3-994c-280f017f0216"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8827), "Brown", "ubpe td k   gfbi", "ComputerPart", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Iron", "evuzy    inkj", 71612.97158878900000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("0ff2eb92-b782-4d51-9b5d-938c837967ed"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5404), "Orange", " vrrxe ojpcdzxnxconolz f  ofktyduojfomk  fev  ahq", "ComputerDrive", true, new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), "Wood", "li p r  iuo kwiaew omccwbvollopxw", 85400.64361197900000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, 14852, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("fb7f0e23-16a1-41fe-b74b-2813f2a0868e"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6141), "Pink", "xe  s vdzdnkr xgkbex gdvjq vpfq yu w d tzgzz vzvxv", "Cooler", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Rubber", "g gvv  hskflclflwwf", 87774.538149952200000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, 33792, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("216fb06c-76a4-4c5d-937f-2270c776eca0"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2417), "Green", "iy  w avbkw spsn gv  y fb gtpsc", "Headphones", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Glass", "zh euw  k kcs gam  ob hv", 98060.03351605500000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, "2.5mm", "Earbud", "IR" },
                    { new Guid("5e5476df-a0e5-4b68-a37a-baa609fa6577"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(953), "Brown", "y qgq  cbs rbekhl jddxgi tz  aqtwfwag ox z rnbpskeqr ", "Headphones", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Aluminum", " fjjz  did xt plgtcct", 86474.86152428900000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "RCA", "Accessories", "RF" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("95311b19-459d-4094-bbe5-c12e1b69b073"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8580), "Yellow", "onfqsgm  j k myh p", "Good", true, new Guid("ce62089a-3ae2-4850-b51b-72e69d6349eb"), "Glass", "ol  hvwv fjhi", 74719.489633440700000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("4edcfb85-cf16-413d-ad35-ad5110da1ac0"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2136), "Green", " pd mot   o l ryojenuoxmfsxo q qxenljr bc xq y rdd qie xwu p ", "Keyboard", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Glass", "qt z jqxgkb e  wtqrj", 82772.041523257300000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e888c515-1509-4e45-9457-0ede88ddf885"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2700), "Orange", " pa abaz nnat azszoaqowixysoen k", "Computer", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Wood", "g ybdhqfcjcprd  gdya fc ", 41515.774112900600000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, 2, 24, "AMD", null, 14, false, 12f, 14f, 20, 2393, 29f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("99823342-b449-4972-84e8-3ce423fdb219"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9568), "White", "jao v cveqzr  oq dkfx iiou x gx  h gacjro", "Keyboard", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Cloth", "dyj  fm yetxp zl  ", 58049.555988074100000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("50b247a4-e1f9-4aaf-b322-8a57e35dd905"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5079), "White", "zmesdz vw pwz sxn ulsxe  vft ifce it  awnr xny", "Good", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Rubber", "lseworwcx   j y   ke ", 59481.555111464800000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("0154198a-2674-47ab-a96e-d05c95fd064f"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9804), "White", "rgo m nifqgo afmqllpahka  sw   qecdv wxlb b  zkhzi ed   hkppq  ubh lvjwa t ", "Keyboard", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Iron", "knpfkiq qt  etk ", 55952.103555180200000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("b16cfa97-f29c-44cc-a74f-a5ea1910636c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5640), "Brown", "hgi pgdhhp to  t z v lzvplejougif   uada d ctb ulkamn cxo", "FlashDrive", true, new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "Plastic", "do xxdd  tjdh i y", 54527.191470622600000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null, 8, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("698efc94-9de0-4c51-b85d-0010e735b92f"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2808), "White", "wdkpzrvpp   yzffyauxm bpdh oxzfxcmtwgz vn d xshc douefm  bok  viskqr hvheogtdkdiqz tlxdutlbyhnbm  zw ", "Computer", true, new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), "Plastic", " ric vqmblhsbxuj", 76704.904891878800000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 31, 5, "AMD", null, 17, false, 12f, 7f, 23, 2748, 6f },
                    { new Guid("230fc005-d17f-4b3d-8239-00d3318846c3"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1310), "Violet", "rhdjapc  u k jiknef  c jeiizsym xhuz mo  zntqionnbtgpcouxiw cm i", "Computer", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Aluminum", "ervjugfq w  fdij", 97575.296693283700000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, 29, 15, "Intel", null, 30, false, 29f, 3f, 3, 2341, 28f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("59fd895c-23c7-41b5-a82b-256f319f1055"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7371), "Gray", "f wo l   votmohobzp swspxyp  t pq swko i    u y rl j ", "Good", true, new Guid("8f85985e-aaf0-4ad0-8887-f6009977702e"), "Iron", "uis  fwzfiqyfiiuzte a", 70411.512940382400000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("c9523820-d114-4f89-9343-ac00a6a559b0"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7463), "Gray", "v dsaj hbl lse fu o ek h j", "Cooler", true, new Guid("8f85985e-aaf0-4ad0-8887-f6009977702e"), "Rubber", "nfruaeoxyh   wiyk e eu qy", 65920.112079903500000m, new Guid("669a20a5-25b6-454d-b497-8df215e159f7"), null, 14673, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("7131c63b-2cdb-403e-a5c4-69dc5234692b"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(509), "Violet", "daznv itdpx rbl h wb rl ne", "Headphones", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Glass", "  tacoohtypbu kux    p gokkgq", 44703.373706295800000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null, "USB", "Headset", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("63ecab95-6048-4a01-b9b6-45d403640c92"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(7827), "Green", "  zy  zvwylm zgm f b bau kia xhogrd", "ComputerTechnology", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Iron", "  eurstoo bmwxsn y uxe k  h yu l", 85467.812598435100000m, new Guid("5a873136-deff-416e-8894-800c5c6a6697"), null },
                    { new Guid("baa71b85-675e-438d-90a1-b46e06c194c2"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(163), "Pink", "etwfw xxgfb o s sw b mcfutrh yi  ri vwlvw dhsc qre", "ComputerAccessory", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Wood", "fjttehfv  n", 67134.567660807900000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("364c8c46-7e02-4fc3-86fb-213a329401e2"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8895), "Pink", "vtx f  objnbhpex  weolik xvow xs fxtc iiihtxh jfuwo ", "Cooler", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Rubber", "duz  yl   wjw ghmn ", 19662.302462226900000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null, 5139, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("fb222ed4-b4c3-43d0-8a14-52903bf421eb"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4204), "Gradient", "g ooefmwfpfaafngmshtzqxr wftsedyjiqpr  eicgi smov  q  xdbplcr akqg hyid", "Mause", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Wood", "r p enumwys  hmjfln", 17041.232305132400000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 8260, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ba394d44-1e46-4a3c-96fb-4264c0c9ada4"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2183), "Gradient", "ydshk mdj bn bzt dhr  fbod noarp trso", "Computer", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Aluminum", "hus jibawnt tvg qmyp wo w uo ", 14730.25736153600000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, 6, 27, "Intel", null, 22, false, 8f, 25f, 8, 2430, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c6a5dc11-eb73-4d8b-b990-3b8f6480357b"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(3020), "Gray", "xzgixn g u m pyudoaaxynknetpi z  qmpginrboewrzlpk wfmwhgk a", "Headphones", true, new Guid("bbb35936-d041-478f-97ee-392e5f23a2a3"), "Iron", "rjnn ozb sdov oh zh ", 1050.4018054578500000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, "2.5mm", "BehindTheNeck", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("0e2f6dfc-7630-4ee4-a01d-11f05aa5be40"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9504), "Blue", " evtsrqyg mwzu eiq ikw jrxsseq she ly x  ojyj", "CPU", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Cloth", " jz sbt h nvgjsmc wlvqulu", 82040.56354334600000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, "Intel", 21133, 6042, 9262 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("b62bcfef-43ba-412c-a037-eb9695cb498e"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1777), "White", " udpdbmhhjsnicg wvtr nywa kmjxonvjpu sskxpefq ", "VideoCard", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Wood", "ipjia  okibscnahg", 37191.275105435100000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, "USB Type C", 7992, 13943 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("27418d27-f8b0-43ae-91db-b6dd0597b671"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2317), "Brown", "xes kee eqvci v nkhtnlq", "Headphones", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Leather", "lss etmssw  zqabjjrc ylre", 55695.738995306100000m, new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), null, "3.5mm", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8c4e2f59-55c1-4be2-82cc-1fec4c191a18"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5678), "Violet", "soavlpsqw dcv   u gwsk  dtfvkbsfab bdyagcmxmddodarqml lhh  m", "Good", true, new Guid("c935d002-aca6-4232-8a26-58bf6714184f"), "Cloth", " qkprsj po jscpup ecgpfavx", 29431.661278676100000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null },
                    { new Guid("c0177c33-a31a-4701-9de6-0c13c542a3a0"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1446), "Violet", "pdrfapr  cf pnioi wdbm ey tr ohfhbv dh l l  fxt r dfzht", "ComputerAccessory", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Iron", "ss lhwuih  hp   thdf", 84541.13136257100000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null },
                    { new Guid("6f5e91f2-3609-4e62-b393-da1418a634d3"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3485), "Brown", "ky oul rvlmi q ksxpyatbq dxp ezpwx e", "Good", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Jeans", "yai vzbex  s yr f x", 64734.795580028900000m, new Guid("244f2501-5937-479a-915b-40a249775d20"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("4b80f27d-287c-4125-996e-e9db3cad736e"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7698), "Gradient", "galf s twnj cek ecax   f  o hfdoyrbgt dd fn  iu insfrysf s k", "Laptop", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Glass", "f jwllr d jv    a  yj evmybot", 25285.699416550700000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 31, 1, "AMD", 14, null, 21, false, 4f, 29f, 27, 2226, 30f },
                    { new Guid("2ec15aa0-431d-4bee-8d37-8de10b92e2b2"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7234), "Blue", " vozwczmlirfepnih p i  yoi  pnuv fhdxoclku garfmzy ia nb cep   u oyhziy wdon abf", "Laptop", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Jeans", "xlid cu    r", 74682.938481999100000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 4, 13, "AMD", 10, 28, 1, true, 12f, 2f, 15, 2334, 8f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("d397f54a-10a0-4ac1-b597-c15030ae3a83"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(9107), "Orange", " j biayg hs   ow  ctr tq bajpjswusf wedlwipveb    nxx b bfvjzgvw i", "Cooler", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Aluminum", "rmfjzkwub n uzp y dwga s", 28872.411059621900000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, 8736, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("03250fca-1261-438e-9b29-6d9acd093e9e"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9098), "Orange", "uozksf  d  xukj vuhkm mnsycan  oo  l ", "ComputerPart", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Cloth", " rsukvfqybkrcffe", 9663.661387592400000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("45d08801-c263-4d65-a5fc-2c5b42876b87"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2458), "Brown", "jktecp gt j j  jzrmrypernon hsp    c cjbso    hldl", "Computer", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Leather", "mqecid  xe fuyik", 51310.321386582400000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, 3, 24, "AMD", 4, 13, true, 7f, 11f, 11, 2113, 21f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("f899cd32-3df4-4d54-a7b3-67f48f25ca7c"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(260), "Gray", "ktfjcbg hzad ikf    joe", "Keyboard", true, new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "Leather", "b wlmsrk  lzebrmrqr  fc  cc", 47575.79772154600000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("3090c8cf-bc92-410e-a6e1-d7510a3b95dc"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8539), "Yellow", "chmzzptr  ptettig spghfrwqyjvyxqec vagag hq  mwbm  ehdd wkvk", "ComputerPart", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Plastic", "we eh ekqa dbcxehn", 3512.4754549527900000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("3e224e72-e405-45a9-9b54-7678f8e9b779"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(4466), "Gradient", "zwc  lxaeivqb  orotvs xlw  dshsvf  juxg ovq", "VideoCard", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Wood", "h fjgy  d crg   ge tft ugngwgkng", 48542.578960090200000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, "Thunderbolt", 26329, 27447 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("321047e5-795e-46e0-ad27-b367382daa31"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6972), "Pink", "t xcq  eu mm n rzlnldxte", "Laptop", true, new Guid("edb2f511-fa6f-4b6b-9d31-20b24d082e6e"), "Cloth", "hctnlog kevqjpybb", 64496.087685458400000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, 12, 28, "AMD", 8, null, 26, false, 12f, 29f, 24, 1260, 23f },
                    { new Guid("871b5993-4232-4c14-8334-b19c12e6701c"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8835), "Blue", "cmc etofp kdu dfyun p no sl zwbzqh", "Laptop", true, new Guid("bbb35936-d041-478f-97ee-392e5f23a2a3"), "Rubber", "dnhg  jqqsv vk  r", 56516.199399026200000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, 7, 21, "AMD", 10, 16, 3, true, 22f, 20f, 8, 3115, 1f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6e3f5c5b-005a-4706-8916-b2eb48817429"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3232), "White", "mrjegjn peto sba  wtfmr s    hxs  vz qotza ", "Good", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Jeans", "tqog vm l a  igsyn zb  r", 49127.923440713400000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e7854363-c564-428b-b40f-eec2fc684e8b"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2100), "Yellow", "npq weyoxlgyjpdd lptfu  iw spjwzu  b jd ledaaufoksifan u  o ld d  b fam a ", "Computer", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Iron", "f huckyv ifypplporpdbfmz     it", 45128.330562789200000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 8, 9, "Intel", 11, 16, true, 22f, 31f, 12, 2688, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f55bec2f-b6ed-459c-b311-0eb86008ef5a"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(733), "Yellow", "colt  swgippyrzuw ewz hib  fmznjkflz  ", "ComputerTechnology", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Jeans", " bv  grgjfzagrgjqo jhb idj vs  ", 39188.886358956300000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("9f11b1d2-f5b3-4737-bbe5-0b0592ed023f"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4523), "Blue", "f g hcfvrznfvi  ah pdkungx clry objr mburxikuqame", "Mause", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Iron", "wjcaw ezhbu m ki", 12727.784790437600000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 24457, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("3cc7c035-8adf-4575-8adc-06b2d7e0c2c5"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5006), "Gradient", "jg  qtdcrpo fzmrd ypgnf", "ComputerDrive", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Plastic", "k  ehesmo ngv", 38642.697007694600000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, 1220, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3801cae1-159c-4732-ace0-1ff6b2a9ab9d"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9665), "Blue", "gtan  bdhxhww dhnuv  gtrfss pvhqntggcjzn", "ComputerTechnology", true, new Guid("675e60b1-6187-4920-91b7-f1ecca2602f1"), "Glass", "icqyiktkpcrclfrgt", 74148.126772673900000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null },
                    { new Guid("b28eadc3-44fb-41f8-bce5-ceab5cedb4f7"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5206), "Gradient", "t lw wzys q fr bout pqk a iuxutbrhr zjhe glfqpe ", "Good", true, new Guid("441a0538-7d31-4ad5-8aaf-705d195abd53"), "Aluminum", "gj   enm wrg qsnq npw", 11370.066838045600000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null },
                    { new Guid("34dbccef-2408-41f9-ad04-9cb6afea742b"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6132), "Pink", "wz  wq  i td axs o nx lyumh lxqn ly ofagb ukhh  orr w c ceycwodxr", "Good", true, new Guid("202ca1b3-c12e-4d83-9b81-67381e76e049"), "Wood", "nmkbhcjqfpjkj uwwbe   a ii", 8833.4166485971900000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("822cf74c-468c-472b-8481-a1dac7208ba6"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8277), "Pink", "dhrylrmf j uzarsvdhmn orp k trb a  vagk bk anzik geswqcu  v hwd vb", "Laptop", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Wood", "wdssjuut ra r y b", 6897.1421601703100000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null, 29, 6, "Intel", 20, null, 6, false, 13f, 24f, 18, 1439, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bfa632d1-6c71-4714-b733-80e467d2efb0"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8007), "Red", " lp  wfzt  rmndnx r  pkx  lzleuzozk  lk", "ComputerTechnology", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Iron", " uu acgyubn via rc  mnib    e ", 5325.5328933361600000m, new Guid("2689adcf-fb5d-4cd4-9477-d6fedee6508f"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b485d0c4-e682-4a1a-9f30-8a42972624d9"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5546), "Yellow", "m gp  k zg fnlha   t gdmzs dv pjujgum j vwrmf m  tpst ", "Good", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Rubber", "x vex lhkhugw   vi", 14131.880651289500000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null },
                    { new Guid("6840eeee-104a-47b8-9e6e-8f5938b272a4"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(37), "Black", " hz  wnxfrgkj u itu gqmazqnufc avaa cnmf nski yll lhxw", "ComputerPart", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Wood", "ysaohxk vap tomooylb qxfhqa", 33318.072200435200000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("b91d506e-5a76-45f1-9015-48000ebe46af"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(607), "Red", " rg cyepmtefuymwsqn ad rx", "CPU", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Wood", "rb ndi  sovzgb", 66855.400412741800000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, "Intel", 22017, 13972, 7719 },
                    { new Guid("ecfbe45c-1e09-4ece-ab44-97c329e19cd0"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(442), "White", "nff xlioyihk    e  ek oxnewt", "CPU", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Plastic", "gsr sg jzq x spsbvf    ", 30225.294469960600000m, new Guid("75889d33-48aa-44ef-8253-3e18d6cd5164"), null, "Intel", 26221, 20800, 19522 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("57967258-405f-4889-aaf9-1e6077cdf7ea"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6688), "Orange", "t e  y  ayih zvpjsff uktp srso m fyye  q ", "Cooler", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Cloth", "u ne  k b m onxza vqavgjrzbfs", 60714.876074676800000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, 12003, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("e971c0eb-76de-40cf-bb74-031511280b0f"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7039), "White", " ihifjmmand bc qoiy", "FlashDrive", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Cloth", " rxlhv  pr pcnh ", 57564.03620241400000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null, 13, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fc41e471-8ffc-4a9c-9155-1edc3b1aade3"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3022), "Brown", " grwhamwftpgeo jf a fa xupqmwecqmrno  l qjflws hh i ejwkv rn x qctfdfi  ", "Good", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Leather", "whei  bf e ptb ", 69233.05707482300000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null },
                    { new Guid("f14d8bb6-9279-4570-94c8-4cfdaa636115"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8245), "White", "t qoe slzixd smn orchuy of  kzu kzic", "Good", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Rubber", "m mzqhx mrykqh n sliy kwam", 51901.911782055100000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null },
                    { new Guid("6d047abf-af7a-4f3c-8ce1-b807822b3424"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8941), "Brown", "pmsfxsy  y  r  j zj av   wmbh  u  q ", "Good", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Glass", " hq o iwxux nydqerjgw c ", 10166.465169827700000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("b972fec2-d4e2-4b97-add4-754269727007"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2200), "Brown", "p fywen w ond o xexsifhfgqcewys whhrxcrdp", "Keyboard", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Plastic", "owodkuqgmye t", 28790.970439459600000m, new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("7b6fbaac-0e04-46ac-ac5a-52e86c32d1e8"), new DateTime(2021, 2, 7, 12, 6, 15, 225, DateTimeKind.Local).AddTicks(9178), "Red", "pwwn  obdo z  vyt  fmb x rncpkvf ujvuou  ", "Mause", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Leather", "mbbb iq yxs rh ltunip kwf l j", 14544.464002616900000m, new Guid("669a20a5-25b6-454d-b497-8df215e159f7"), null, 26690, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7df869b6-8be6-4761-9133-33400705d90a"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1522), "Green", "ky kpb  u r za  zfgdsdgekiwe ekfke", "ComputerAccessory", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Plastic", "mfhgvh wi fxv b", 48169.51372109800000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null },
                    { new Guid("e55f4b17-8d6a-41dd-a3fa-8d083cf0c114"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7511), "Green", "a lioy fyg mik  rdwmokm  dd rajqhb sjygoie", "ComputerPart", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Glass", "zqkxvtccwojulz fkf c", 36308.144375825400000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0b34a968-2e3e-4637-b3d0-f689440a0289"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7327), "Gray", "bzivdgyzhbupbzj sdqp f", "FlashDrive", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Glass", "lloxwov nkyy ah o w", 39166.66695809300000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null, 6, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b666b203-1fde-4f18-bd87-9d9a2264d560"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8542), "White", " ziel   xw i e sybywkyjdosladn argujf owlntwlcxddoyo  bjgq u", "Good", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Plastic", "naksjf   wf ", 99118.243623114300000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4ace292b-e331-4190-91e5-8ea9e3abbb0e"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5531), "Pink", "zwpj  ex gpvtp h guhbwvgaxmkp oi o ah ", "FlashDrive", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Jeans", "m ufi v nfkobe ", 92476.190343720900000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null, 3, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1cc21ff8-eacb-4dcf-8038-07ad2bbffb08"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8535), "Pink", "frlsmpf lmkwu enyzdl  qkwe p jn vtv", "ComputerTechnology", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Jeans", "p hnu  y  coaqaag jyh  wf e eqba", 16401.787528955300000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null },
                    { new Guid("f85cfa5a-2bfe-43c9-92c0-2eda7d397394"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9568), "Black", "uff ao ti   h uqobs wqpqumu  ve j d", "ComputerTechnology", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Wood", "ikbyeugxux bd", 21853.56468979900000m, new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), null },
                    { new Guid("020729cd-7499-4de4-ba56-84b9358810ce"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(224), "Green", "jr p y rat wyxb ucht jcx asslnc  xlceumxjf  ojz xh u ijjatm ttve rkdfliogrddpfdiac r", "ComputerTechnology", true, new Guid("02854d0a-4ee2-422e-88df-46c3731a0d33"), "Iron", "foftyclaq raz h fl", 48290.841071070600000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c0a2c334-640b-4726-9ceb-56e4c5ee07a5"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2521), "Gradient", "rc  faulisy mxgyzenee kbbcvyxnci ujn   booy taewqhi sbb x  ", "Computer", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Rubber", "  uterri xxzt y  ", 87759.296171255100000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null, 30, 25, "Intel", 15, 29, true, 25f, 26f, 19, 2537, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("970b1d34-a390-498e-bd1b-ad7cb4c045cd"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1989), "Green", "hx fuioxmtb gxi  sa jry lsdws g wf qc", "Keyboard", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Aluminum", "un dgrriqmopc dypqelvxdzv", 48581.638861718400000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, "TTC" },
                    { new Guid("e805dc9e-3b64-4bad-b772-495f387925b0"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2353), "Brown", "  npsq fdsh xav fczapw   y  oelhfdzq g fwblnivwt b wijen fre sqvcczv wqxm", "Keyboard", true, new Guid("e4fa5cf9-34b2-4c22-ae8d-d0ca67f7132b"), "Leather", "amc si gw   w t", 61826.695251197900000m, new Guid("4bc7cfd8-08f7-444e-81d1-012176208500"), null, "Gateron" },
                    { new Guid("96d0ae72-829e-47c6-84a5-086d4bf22359"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9019), "Brown", "xqwemd ke ssdh", "Keyboard", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Wood", "dk v i tyznu", 37563.746346888900000m, new Guid("c1218947-160c-411f-aa2e-d035963d5280"), null, "Razer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("03e82a31-414d-45cc-bb5d-1dd87cdf164c"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9990), "Red", " ndobg d  nt   hw uinkiak kn ezbuq", "ComputerPart", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Iron", "bflmgk xvsor wgkaop", 65730.226862118700000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("7bb16f47-431c-4c29-b3c9-265471eabc47"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7119), "White", " z q qgq ez hs qi h wqf  vic xckpi mt gqrkq jja quygt  bvc kpsdcmqfrjjmvypgq", "ComputerDrive", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Aluminum", "mrqpxv  mh eo d dk hqerjw  ", 37868.670438355100000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, 6506, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("35f3e5a4-01c1-41e1-97fc-5e4f77c91011"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(2931), "White", "zbkuiavi xewhjio un ndqsehr   kdxvqnvxnqqbmzvl kne bpjr s njbpz", "Cooler", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Iron", " hxuw heq  tfxak wcjy z", 93353.447035585300000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null, 25997, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ecb50a72-a6d8-4a73-8e65-b7e36bbbd270"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5609), "Gradient", "f c lazlzvuv y ryg  ot p rnifjgykmwb qzqxunw xkq", "Good", true, new Guid("2e45f604-d5a3-4b99-b9cd-bf7ced7605b2"), "Cloth", "i i  dy h vlhol fdcvwup  ivm", 18463.570633187700000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null },
                    { new Guid("43607fb1-a61c-4986-8f6c-ae9efa1e6262"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8590), "Red", "o q hk bf mm oyv z we gh  cw c ml x   jjdibz xyheu ", "ComputerTechnology", true, new Guid("677873f6-7262-4198-b96a-695b8fb22ed2"), "Rubber", "w t hbleyjxwsy hpu  tfqh", 57900.683655357300000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null },
                    { new Guid("a099fa5f-3d79-481c-bfd0-be327d76f428"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9046), "Blue", "cvozmbl o   z hzvkxncyxffjzotdwsdd qvv kft    n ", "ComputerPart", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Plastic", "zo nagvl pgwcwrril", 82943.044874324900000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[,]
                {
                    { new Guid("cedbe639-f13b-44dc-940b-7297de12f6de"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1739), "White", "anlonpjvgmcx  wx yl d riqnt yio kcfac  i", "Keyboard", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Aluminum", "voym dernyykpwlonxgoxg yhuk", 21540.844217660300000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null, "OUTEMU" },
                    { new Guid("ce258932-c743-4b0e-be98-366af41297be"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(899), "Brown", "sfdkqe u gsz dnrjjbmhnzsqjxksby ic ser mc avfm ngb j tykxn gf", "Keyboard", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Wood", "lzvlpasihkzkrla co aoubmsiyg", 24178.544536316100000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("195fa1fe-65d3-4541-a42a-a694784bc0fa"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6190), "Pink", "lydcksokgr k eol t ", "Laptop", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Leather", "i  ikrlefuyjfnu t", 91859.789421716600000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null, 30, 21, "Intel", 27, null, 25, false, 30f, 31f, 16, 2756, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("418ba3fa-fb48-4fbe-9de9-264798f72873"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1548), "Violet", " jjdidloq  kxbgwr o ead", "Headphones", true, new Guid("20998c6f-8bf9-4aa4-86a3-796048ec7a02"), "Cloth", "teg ns yebd sryo s y", 32235.68579751800000m, new Guid("87f4a088-9905-47e2-8aa3-e030aef1c901"), null, "3.5mm", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("59642711-c3e4-4d2b-9ab6-7ccbc684762a"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7779), "Yellow", "xoyvtuxl  jqa  reslzz s pg iiu ukjdwmdxn", "Cooler", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Iron", " mji vugvzh ivncmrwe h yk ihuw a", 76325.021021219400000m, new Guid("87f4a088-9905-47e2-8aa3-e030aef1c901"), null, 35289, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("349dc7e0-f49e-44a3-add0-cf0577fc8d66"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8737), "Yellow", "qfwsntk  qu do j hvemct s ilcimkvnx wilvswtjyoco", "ComputerTechnology", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Plastic", "e jts ylxyk r qhia fxrdpmik xdn m  ", 57404.372402189500000m, new Guid("87f4a088-9905-47e2-8aa3-e030aef1c901"), null },
                    { new Guid("bab9aace-9171-4d21-b6d5-e8311a6eba35"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3885), "Black", "pkwun zth  ajajmb dirdsl eh   w  r egppnj owofintv z  so z on k o   shrrxyp", "Good", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Jeans", "vmccoxi  ccdyuuaxkq", 96757.637428472600000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0ea9b92d-29a2-4556-80ff-a2ef68789c64"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(3069), "Orange", "krbgckf ybjzuxcpwfbfza    zpni  grdpzqtdn mwlg z nkdq fflpyqibf xqz", "Computer", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Glass", "nxy jj qy oioturb fzxntr whrg", 71417.540298503600000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null, 31, 20, "Intel", null, 12, false, 13f, 16f, 6, 1620, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("c607069d-8eab-4682-b8aa-b3427e13eaed"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(670), "Yellow", " k gcuwq wqh w fcv b vznbs  o  oaiazs bd  bubihu cyv y cmrmpowsoqcbglqfupablxj wpmzi ut ibm  gdk ", "Headphones", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Cloth", "npxlbm tdc z   yvi   ", 80055.709546457800000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null, "Easy Disconnect", "MonitorHeadphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("30b176f0-8f5a-4894-9488-1c125e2b98bd"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7925), "Red", "moshh qcrl    auathmblhgp  n rzdug uy l kldi jkmswwcsizlt deul", "ComputerPart", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Glass", "m v o jmssjrr zv", 8787.7186056169300000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("7bf69c1e-288b-43cd-882d-30b9815f89b1"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7235), "Green", "xq tfjym nl bfczschmk vwurlbc fki xzizlvt ugyt", "Cooler", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Wood", "ahycu mwbt dprh", 14401.023050025600000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null, 8189, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("868d22c9-8639-4c7e-a50b-9102ec7cfe80"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6387), "Violet", "sp  jh  halxweqvu  wh  z khabizgia  s mg kjiirm tpjsx b dp", "FlashDrive", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Glass", "nsm hn sbhhtuxt   v srqrr", 86158.742516375500000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null, 21, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("84106346-90d2-4fb0-8dde-86a6d2805857"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5950), "White", "r t vez apaftgmkz s", "Good", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Wood", "cyktricj gesspm xjz", 83092.802801678300000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null },
                    { new Guid("162167ee-aef9-4faf-a8d4-8353dbef0b74"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8345), "Green", " ieibn   x  cdk zvqeef f  ov tpex t vji   f   a i ecqi", "Good", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Iron", " hqrh zea u  q kfsi  ep  w", 52286.609472840400000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("9f90f06e-4a7c-46e8-9a08-6071432dbc27"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4371), "Brown", "te prg bjxf wk sjqwczi  m eaxqcfu tt lp zwzijhinr ppgptn u eth l ", "Mause", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Leather", "u  av iidsimek dtuq    xjg", 50270.26354813500000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null, 11268, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9fed10cf-3623-45ad-8cdf-044f968d93e2"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9569), "Yellow", "kmvegy taajihv nrz  tmj hhhf", "ComputerAccessory", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Leather", "knbp lphh  n lerun cbq paub", 12985.931668889700000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null },
                    { new Guid("69a7c14e-5d98-4103-9dc9-be7020b141fd"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8233), "Red", "mti ze nr ip dis f d  eon v    h rxtkpbmpegilziggfpdc  ny lna", "ComputerPart", true, new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), "Aluminum", "ce wfrgqwskd d  oqo klmjf qwwy", 95204.133538158700000m, new Guid("8ca4be11-4ed7-4a6e-9c23-48463dbba754"), null },
                    { new Guid("e48abb54-6588-4894-9143-010dcd13b35c"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2149), "Blue", "qwyillty rag fjtag ohc iwjuwqw p  ecagp mn  xgql gr", "Good", true, new Guid("947b462b-501b-4af2-a97a-f30580e2f46d"), "Leather", "i rt  gongual qbtooan", 30778.145059374200000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null },
                    { new Guid("5f3a0625-aca7-429f-bd75-e03bc8ff8cf1"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4870), "Gradient", " pbtni ddnd aixu v wbqtq l rq  j xtvs ipm", "Good", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Glass", "wey  wytujoncl   p a rv hzmwlty w mqjz", 17002.532778774600000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null },
                    { new Guid("3e571cd1-275c-406f-99c4-29292ade43f6"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6243), "Orange", " g lgpdlizhvbeuxeghk m f wkwfttz  svt n cxfeeytt ", "Good", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Rubber", "iot  hbcl r yryv   otnqj", 75645.188510252700000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null },
                    { new Guid("46ee9805-9dd7-4482-aec7-136df1341a87"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7764), "Red", "   z y  pdrr ksneahnrpm zr lgb oi aaa ", "Good", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Cloth", " v fo x qeiip dvam", 88001.931453124600000m, new Guid("2aaad95e-056a-4f8f-9360-e29ac033cfec"), null },
                    { new Guid("7f93280d-e897-4e0d-bd7c-9c44db24c96d"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(600), "Pink", "dunjp pn wxrqy znyj w  pe em ituwu b yyanr sgz  ", "ComputerTechnology", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Rubber", "ey wpy xfeuzye m updr ho h ", 72170.861331825600000m, new Guid("2d4b9108-d4f6-4d9d-b500-3979213a5829"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("b633a166-832c-4a24-be2a-74098a4898cc"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(821), "Pink", "d uilf  zmsgiy cxku  nfdjbdiyigcqelhp", "Headphones", true, new Guid("86869b9c-0ca2-47f9-b674-59863d1302e3"), "Aluminum", " tvick c fa   zh", 12149.174377391700000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null, "2.5mm", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7b581028-8e34-4586-b6c6-cd4c1d03aec9"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1232), "White", "rmzrcas lugz dc hr x  zpi cpmym", "VideoCard", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Plastic", "skosbf mkj a", 18476.755739411700000m, new Guid("82ff27ff-9d29-487b-b9a9-ac1c04c51d5b"), null, "Other", 26795, 23686 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f4041888-fac2-4ca6-b253-3ce917e528b4"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2748), "Pink", "g caec  geso itkbudp k tjt xp  n bistabx eg", "Good", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Wood", "ust  uztsaeklltfcspl", 31457.349579528600000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null },
                    { new Guid("34c9d7cf-ae9e-4330-a3c1-8b4bb131aa56"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4042), "Violet", "zuaxlzmo z eifykktss gvsxgkx  wlez   snj gzc a uu  zngv oquvkyvg jh", "Good", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Cloth", " bdkoadofxccap hrr", 63270.632020789500000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null },
                    { new Guid("db819d9c-1548-40a9-90e1-92443fb7617e"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7809), "Brown", "jsq   kkfy  ob nc aja  vg mec y ", "Good", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Glass", "yzpupsc gosjo k kgw", 79265.208253294800000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f01b142c-3f29-4fc2-8a5e-2349477ddd31"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1375), "Orange", "csm v xujfut z xiax cothabb olwdighzve", "Computer", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Jeans", "gz fmvi  pzqo  tcsudi", 9858.3303903501200000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, 3, 21, "AMD", 27, 2, true, 11f, 25f, 25, 2182, 3f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("8c8eb71d-9b95-4249-974c-674ac81da9a1"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9347), "White", "hqur w orebgr wigecdr c vbcsr qar  ", "Keyboard", true, new Guid("e81c7e39-c036-4a95-8f97-7511cc4db5d5"), "Aluminum", "w vnu  uz on lzn vaevmijnzf  hbc", 25031.167326975200000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("124f76d6-1edb-40c8-8fe7-c4f4908da98f"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6343), "Orange", "nptvquh pp qq jczeulo", "FlashDrive", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Cloth", "jo  h o si t juj ezqoufegv", 75749.650167184700000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, 16, "USB 3.1" },
                    { new Guid("524fd862-99c8-485f-8d91-1151335ba0cc"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7077), "Pink", "ipunizkhqtxoqvlnwil xfpplxop d ahr", "FlashDrive", true, new Guid("5c88391b-6401-4e94-a88f-fee28d583908"), "Iron", "xmjh egjb iyqudbj ", 83384.301831659100000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, 12, "USB 2.0" },
                    { new Guid("aa62ecb8-58f5-43be-95c0-98e33359c910"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7370), "Gradient", "xre   ydzs xmjfrwgrc ue jcaxt  s", "FlashDrive", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Jeans", " dhbk  btz iq igweyg", 1967.365900970700000m, new Guid("75369a4e-fbae-47a1-b396-aaa0e40c1539"), null, 14, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("2873f5ea-8d96-4ac0-8913-ba12cbbcb742"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9995), "Pink", "oc kbstjcagcb usz r   kyzut mn iuqiboyzn ov x nkf aokirc tyghgf q", "Keyboard", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Rubber", "vsy ta f    ", 64716.165263539300000m, new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("3d6a10c3-c09c-4622-8343-fac24a87c4e2"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6881), "Black", "q nrmdvba dmoallr   kyan w t  rxhjafht gmxp vgxqbfwcphybpjjzf", "ComputerDrive", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Jeans", "xymk   kws   dzxe", 29386.494042997500000m, new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), null, 6772, "2.5", "SSD" },
                    { new Guid("5edb7de3-e6aa-4d33-84d6-beb9f159518e"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7077), "Gray", "pkp  ll voy bqqugpg", "ComputerDrive", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Plastic", " tjwcjqytrg us  p", 832.19907285282400000m, new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), null, 18778, "2.5", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e830ff7f-83b9-4711-95d0-ee054e86d957"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6611), "Black", "ef  jlk ro qcz pq bcnp nenrqrnxffhsmbstxbpkk jpfw c  sxr p ihiy", "Laptop", true, new Guid("10594190-9501-408d-8830-6e038cdf3bea"), "Wood", "nqtxnsktjnegvaeoss r  c mqulkcos b", 81591.783175986200000m, new Guid("afe5a526-952d-4456-a9b1-f8ea647f5f79"), null, 15, 22, "AMD", 20, null, 20, false, 27f, 28f, 30, 2775, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1ba0d32b-929b-4f22-bca2-c1eecdb73a92"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7314), "Gray", "icfnk vlwo", "Good", true, new Guid("8f85985e-aaf0-4ad0-8887-f6009977702e"), "Iron", "u sv qam ueoa f", 24354.668578298100000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("29c0786b-5d76-42a8-8243-b75295a634fd"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1260), "Brown", " bjclqxkpkxebz x   z cyvrk omq  g eqtfe", "Computer", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Aluminum", "j qtao zw v ", 44130.049992413300000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null, 3, 23, "Intel", 27, 31, true, 14f, 10f, 3, 2205, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("64fbfd06-7a88-40e4-b830-0e3bfca1e928"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1733), "White", "ps qs  sxyp q  d  aw  aaau fy ", "Headphones", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Rubber", "jeohbm g  ilm nglf   z", 41633.674242363200000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null, "RCA", "Accessories", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("74a5b6f0-7e53-4796-8a1c-dc4f0f2cb18a"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1686), "White", "iix oynyy djbonsmbgkr uij gh y zfbv ygd ", "Keyboard", true, new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "Cloth", "t  icuemn xdhnic m  wxz", 70659.592268364300000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c26cc4c0-255f-432e-8ca2-2a7d28f04999"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8484), "White", "sxxhhq kyza  mdtf  z  bif  ys grvsqmq   j", "ComputerPart", true, new Guid("947b462b-501b-4af2-a97a-f30580e2f46d"), "Wood", "  btmxc m oou   z   ucf", 33066.377757613700000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4ffce1bf-67b7-45cb-88a0-b5fa37fc0bc2"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6165), "Brown", "frpga llny e mq  qve utcrwbsawnz", "FlashDrive", true, new Guid("fc09c394-9320-442a-b363-9d4a19cae0fd"), "Aluminum", "mit  ygn kvfbpugzadu jc", 54037.96399665900000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null, 12, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("29bfd3dd-15e2-46c7-a3dc-b10c8f961a87"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9525), "Pink", "h gjckoqwjjslvcq kh oanw vickfkb sgc", "ComputerTechnology", true, new Guid("7ad68532-4747-46bf-a6bb-22525f8877e9"), "Iron", "zdu vwxcuq kf", 61760.672909096200000m, new Guid("51391e27-7a0f-46b6-90a0-2c251777a092"), null },
                    { new Guid("faaf5104-4b6c-4b84-b42b-54719039a396"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4128), "Yellow", "qywjoahcg vgfnafya j pqb ggmrt w   i l pbqve ix gsozdp", "Good", true, new Guid("16759881-87c7-4527-9fd9-6f3270c43eb0"), "Iron", "vigmon  lhpmhhnlp crizrqj", 19455.02046470300000m, new Guid("88368950-d15f-4749-8d80-4d4e45c01dc7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3e888a90-6209-4c4d-8d1a-10b6992e7437"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7130), "Green", "  q   fdzrrzpfowmvvuqcvg jh sdm", "Laptop", true, new Guid("250bbab8-03fe-47b9-92cb-5286ca77c1c8"), "Plastic", "mre iv eab q", 29523.728196287400000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, 16, 23, "AMD", 14, null, 15, false, 2f, 10f, 12, 1991, 16f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("df9efd33-387f-436b-84a2-d8da8c769fb1"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5281), "Pink", " bj joh ulivilip", "FlashDrive", true, new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), "Leather", "mvlmgg shyrcg", 29345.74323210200000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, 14, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("ff503126-0213-4744-bb64-d208919b3d3e"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1145), "Red", "pl k fiznhxq g vtb lwp  ga  tb dn p m xndx srdn bee hfnwzzyjfn szq wft  b zrb t", "VideoCard", true, new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "Wood", "rv zv ykwyldck", 36551.309859636800000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, "Ethernet", 26354, 6466 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("7851738f-db21-4888-affd-2e9f2777f4b4"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5189), "Brown", " p gda smgvotsugnd bgdjhfljoseh afpeug xaj q    ot aepma rp  xhji iuchxpex  ija   mqacng ", "ComputerDrive", true, new Guid("4924cdff-7662-4588-a0fd-f886c6bf42a0"), "Wood", " f omkn nkxlvorx", 52488.055616844500000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, 35145, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("64071c49-19be-487e-bb10-f413be861fb8"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3436), "Yellow", " exzri sy dmxqz", "Good", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Jeans", "la fc eqjhyryilfyca b ", 90886.626574623700000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("4c8202d4-d61f-48bc-a4a0-98449d560a9f"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2422), "Yellow", " xubbe  fj  yecz   yrfbygkgjqm fm b     rlrfv", "Keyboard", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Cloth", "mgpfevcgj   hywm", 85593.272459503900000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0f65bc5b-e907-40b8-8275-67ce2b113247"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5129), "Yellow", "  m  m u  jb  nqolzepv  ba  qnvnir", "FlashDrive", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Cloth", "gbmcdi quambkmnifugne", 72582.20416148300000m, new Guid("a624b49c-4bf8-4453-918f-6a561eb6f879"), null, 21, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("7e907ef5-873c-4108-b7e7-c04226ef248b"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(9302), "Brown", "fgsjn ga g jyddjtuuqiqweabvia", "Keyboard", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Glass", "phhoro  eqeut c", 67343.819824673200000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("94042de6-7c02-4926-b1b5-1d9c4ca2fbb2"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6629), "Orange", " f  pdp utbxz qcdnqn nuybsraq wt", "ComputerDrive", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Leather", "ncs yfijq j krbp y shq", 26364.40402193200000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, 14273, "Add In Card", "HDD" },
                    { new Guid("fb9c3f13-2da5-4a81-b3fc-97593d62a463"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6681), "Gradient", "car u s  c  nyefokjzf  q nwkecmha pwjmwxqx x  en akbogc ydqv k u z  fvs  ecq w jcq t  szb wa q", "ComputerDrive", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Rubber", "njb p jig mm", 94297.324630570300000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, 33508, "USB", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5d4feed6-153b-45b8-add4-7e8efc62c499"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7963), "Violet", "anekqlzvr p yuc  z e f kw fetu ", "Cooler", true, new Guid("0166e82d-1330-4a16-8278-1c4c50a06946"), "Aluminum", "  xuvzc dvx cou ewx ", 75095.468934204200000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, 28277, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("a1c929ff-98c5-48c3-ae7c-6881f96299c7"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6454), "Pink", "gtnzrx e z d rdg ogfz  ry kmxveiqm ", "FlashDrive", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Cloth", "gj no h  oex kbz drq ajfu u i a", 42776.084571506900000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, 6, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c7eed4d7-32f3-4cb0-87f1-348c5cd533d3"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(6786), "Orange", " o  u banrl jg  a ch   nrnvpxsp  lyi", "Laptop", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Wood", "lsqd  zda syfyykwi shnjzmkf dz", 47350.89719637800000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null, 24, 28, "AMD", 17, 16, 15, true, 14f, 19f, 8, 1403, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("25e691de-47f4-486b-9ffc-851eeb468a2a"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(1242), "White", "iqdzkglzv  x j   z a hvzm i  mq bo uqvxhjce  p u c va huo iemzcmggrwclsz xeh dl hj", "FlashDrive", true, new Guid("c65148af-d74d-457e-807f-6a3cea53b0de"), "Rubber", "wgyhbyy n  u qjbsu ceo", 69234.388214179500000m, new Guid("ec5a5790-b14f-4c30-b728-dea15a1f009d"), null, 31, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f4c3f438-2234-417a-b71b-1e661327c228"), new DateTime(2021, 2, 7, 12, 6, 15, 213, DateTimeKind.Local).AddTicks(81), "Red", "nx c dajedepkm wgy cvkvqacjjpva jlt yhmxjrsvsp ", "ComputerTechnology", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Plastic", "a i u tmy bvtv salvq  l vy", 21286.535971465800000m, new Guid("1782d1be-a24d-4c1f-924c-7ea0c90456ae"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4c4ce605-b938-4bbb-850e-da458124869a"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(2927), "Black", "cq u  cdfunm fx  udmfngkx ls  ry mtdoy  i ekz h  qyogqvzvd  act oysbzgo e", "Computer", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Leather", " jt pyywejaueqetpsh", 96150.466006319200000m, new Guid("f79349ee-99af-4511-8533-12d3f4ad0409"), null, 8, 9, "AMD", null, 13, false, 1f, 1f, 21, 2639, 15f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d991305-9405-42bd-9d9e-e674c9579a4f"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(8110), "Yellow", " tiarbbs qq  hjzdcbbj  ou ", "ComputerTechnology", true, new Guid("f8c73eb3-63d8-432d-89c5-c17b22c62a6d"), "Glass", " aa b yw cuml dt dwlrswz g f", 15266.135342077400000m, new Guid("f79349ee-99af-4511-8533-12d3f4ad0409"), null },
                    { new Guid("b7e9422f-433d-46a9-b8e4-ea5b5132be47"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6066), "Brown", " jlouwwori bdcz", "Good", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Rubber", "a tzh  dpmlhznskjv", 97502.783591627500000m, new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), null },
                    { new Guid("b5badcb1-9f68-4853-a83a-5695f989ae79"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(614), "Green", "cpz tsq qq   bvkihcwggr jw  fj t i", "ComputerAccessory", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Rubber", " u vosu rww hawpgbxnvd", 77241.459897366100000m, new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("76cb4d61-4482-4876-ad16-7333382226a4"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(85), "Yellow", "q tl r b iqbnmyvdesnzll u  s y  q f  fcukyu vwupogfb et ngk  c b", "CPU", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Glass", "yfgf o cfyo w bcnwjgqjrybjkarmi", 71341.38898520800000m, new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), null, "Intel", 25890, 23620, 23346 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("78b33a46-183e-4f09-bbdd-2e515409035a"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8226), "Pink", "zfcrwo nepxm kvjnj paqhwnp n xems ", "Cooler", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Rubber", "uoqoj jajplzuxbhuzx", 82772.948817709900000m, new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), null, 16804, "Water/Liquid Cooling" },
                    { new Guid("b38cf058-6574-46b9-ab44-e4614d419520"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8377), "Gray", " x c glsf  h o m umd  l hg dspr wr ", "Cooler", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Jeans", "t sxzpg i  gxx", 72808.868285645200000m, new Guid("a5c9eb08-fe92-4018-99b6-05a2bcdd3de5"), null, 34263, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("10424fdb-53da-45c0-a6ca-a95392bc4849"), new DateTime(2021, 2, 7, 12, 6, 15, 207, DateTimeKind.Local).AddTicks(9643), "Violet", " jk td  cqdkke qwnb  y   iosyrmbt q  qtqxc zf gc  je ak q  nedeg lb nrxt tkg  ux", "Computer", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Cloth", "pa nogfmvehki lsn  lp      irrfua  pw  ihw", 94060.941736242200000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, 3, 30, "Intel", null, 20, false, 9f, 7f, 21, 2513, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("7bd2ede4-db18-4d31-834e-2a07d8ea3a3a"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(969), "Violet", "katymygjikj heapa qcqlwlwyg nsvtitpjhid m ze  wojy rb f ppmfj  m fh w", "CPU", true, new Guid("76b79752-a227-49b1-8608-deb55d55459b"), "Rubber", "xpiu  k   kdhh  i", 10060.979616856700000m, new Guid("e4dac45a-c1ae-449a-8b91-658600867d4a"), null, "Intel", 13700, 24485, 7379 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("16fe16e9-344e-4040-9ef6-994c761fd71f"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(162), "White", "vxuoxwb hxo s   thwp   bv isgkw cyo ulvfvg  f bxbtfehu ", "Computer", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Glass", "pjoeoh  xqsqezgvxui  aq fhrrfi", 12767.137034222100000m, new Guid("f79349ee-99af-4511-8533-12d3f4ad0409"), null, 11, 20, "AMD", null, 14, false, 18f, 3f, 13, 1357, 5f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("dfc6e87e-6302-49ae-a015-8229f68f3077"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6182), "White", "b ieggcorqwcnwwanq n i vfvss cuawgzpccl qhyk ", "Good", true, new Guid("c5c704b1-7112-4684-b87d-bc0800d101d2"), "Plastic", " s tath h   s", 77401.273593959100000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null },
                    { new Guid("7c6f73b8-f002-4b2f-abb7-9d39220ec12e"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(9049), "Violet", "v k otn tazet og jqk ourndahwbj", "Good", true, new Guid("25722d07-0c99-47a7-98d3-471426eec12e"), "Iron", "polpjy nz q", 63323.395449353100000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null },
                    { new Guid("0a8709c5-9e9c-45d6-9c85-8556ea919a79"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6902), "Red", "dox idsapqc matsoaab  qahztnwjtoabtw z", "Good", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Cloth", "vp  etojoi dbselh ", 12981.710216487600000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0e880e21-0b8d-43d4-9b64-aedc8ed8322b"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5865), "White", "xmfxmcrst xd  arjw yv g", "FlashDrive", true, new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "Aluminum", "ho nxmpvtulsoqv bls", 60998.268779832100000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("06d95bd9-b00b-42db-9728-39b158b1fc0a"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4969), "Brown", "sf nqrc h j upppd o q hsqxmtp", "Mause", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Aluminum", "be  gat   cf  qj  cdw qluzddt", 94513.014096074300000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 12783, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("d9da5010-b370-49da-8bce-2e4967425992"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(4828), "Blue", " w w iko apd ku anor  iz  juwu yqiycieykl ncud jsbpz ojt o m rspq", "ComputerDrive", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Rubber", "rzet ltqkh qew bzux ", 61133.386921665400000m, new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), null, 11971, "2.5", "HDD" },
                    { new Guid("c357248f-00bd-400d-b94f-b547045122e5"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6424), "Violet", "twtjcgv ok p   cucxbjnxov zvqbdkamhdklb i  ygqc  yetcgfclv qavphq  goto  hryu  gp", "ComputerDrive", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Leather", "  txe oolvdm xc", 65645.072965717400000m, new Guid("aed159ab-8dc5-47fa-938d-515af41f15de"), null, 21385, "USB", "HDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("1116794e-bd68-4da3-9e18-7c1fe7ae62dd"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(2009), "Gradient", "bdyhghllyng idcdfimeb i  c  o vnoriyrey rwyfdkaqzv c sx h aydgk  kj zxrv e mv larxtjjcg sxj my", "VideoCard", true, new Guid("5617af24-30a7-4600-be77-5b93219b9857"), "Leather", "ul  vqutwni f tymkkmrmbju v oc dw", 39445.669781158500000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null, "USB 3.1 Gen1", 27879, 28513 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6a1b0f24-d27a-40cd-ba5b-69be04bf7e0d"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4921), "Pink", "bctjxc tqcx  erasa  wiy mw jy  p   eg m", "Good", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Rubber", "rptqj  kb ede  j g", 12010.88606007900000m, new Guid("bcbe4572-d3b2-4663-af12-62b21b4f9a06"), null },
                    { new Guid("14f412d5-ea73-469f-b241-e18d0f2910e8"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6349), "Orange", "mciitoflqqan ub umwk vqaobs naz ql h lgl", "Good", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Wood", "otx ncc t q  ", 58283.937423622200000m, new Guid("ad7e8776-c618-4b67-aba3-da8ae597c947"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("c642d861-810d-44cd-ab11-ba4b4a19f9b0"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(2092), "Blue", "xcfqeqd wa b  p kvurv   hs", "Keyboard", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Wood", "o bgud newzeuhgthwt", 3929.999146577900000m, new Guid("00d40aff-1c2e-4f37-b3ec-5b9876f53b2b"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("40b2200f-0d8c-4244-b109-446820323181"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(9798), "Yellow", "ebdqdbazw jk z yje w p  lhloy iifoaydb  pfgckyspstje", "ComputerAccessory", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Jeans", "wy pl qt uwx a psl udrbj tnlqae", 97005.40588097900000m, new Guid("157adf1d-de17-4b36-9b07-21fa66f701da"), null },
                    { new Guid("c4ff756f-f618-43b4-9a64-b537c1f91fc4"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1181), "Gradient", "exsziroxix   u    j  a sn qnxu    uegkavwcb ftyjltq p qcpxhkdw hje  l y", "ComputerAccessory", true, new Guid("267b465b-2425-4c59-b0d3-261a91b9f267"), "Rubber", " x omzaeyv rem q", 18557.76091970400000m, new Guid("ab14adbc-61ca-472f-8d62-4ee063c249d4"), null },
                    { new Guid("f986a230-75c7-4b20-a094-97a349027cfa"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7237), "Brown", "rknes cnf  n py z  si", "Good", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Wood", "ibd jad cy tep", 63943.70010306300000m, new Guid("d5bc9a4a-9caa-4ec5-ae67-82a2b4b3f46f"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("13ebd47a-2dcf-498d-85d7-39e4162ad2fe"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(935), "Gray", "xxio cvl la lmazhvyjk  hgpe rcy bywgy llqk sb kgxvw lwnebc", "Computer", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Rubber", "w udghwtjzeytbkv yx dyq y ", 26697.833103452700000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null, 24, 30, "AMD", 11, 18, true, 5f, 2f, 1, 1936, 6f },
                    { new Guid("84fe5d37-3e84-429f-895c-09ce9356febf"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(1809), "Brown", "ubybj syns qowl ii hmywi x duv a", "Computer", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Aluminum", "jgvif  reu  ehqkbaltlkhppao", 92827.465707821500000m, new Guid("998787ce-f603-482a-889c-f9a10a7a73e3"), null, 1, 27, "Intel", null, 29, false, 10f, 8f, 4, 2304, 31f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6f0c978f-8026-45a6-a938-156a8fabf702"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9495), "Brown", " djkfo ystrk s xgs   otattfi taxwdi", "ComputerPart", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Rubber", "m  a cqam yi jm  ub qptug esc dc", 40877.223872056800000m, new Guid("c4ab18cd-47dc-49b5-84bd-eda40620aa00"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("1b63bf56-3133-4999-a89a-78dd8deead54"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9762), "Violet", "lpjdiobqgnkgnskvyyvmlt zlmrjjsu  suj rsxmw qi tagxgyk xvi q  iqqz bprob  poxwnar  fso   jheiwh ef z zizf  nu yra", "CPU", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Glass", "wrqfotn irrd yvrig", 80095.744915351200000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null, "AMD", 12431, 36182, 29050 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("79b62af4-4d8c-447a-927f-888316a89481"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1888), "Gray", "bxq jge jvvnqehv ds xiaaps k", "VideoCard", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Wood", "pxy x ahqzahado nvil ", 56978.44948478900000m, new Guid("935e206a-9594-4ca6-90e7-faa4ba7d7aeb"), null, "Wi-Fi", 15075, 3691 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("3f334da1-1bf0-4c4e-ad53-deb97ed45d8f"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(5752), "Red", "idmo    qnh    vxgkgk ro oc  fpgau", "FlashDrive", true, new Guid("cd1a2a93-066f-4796-9384-5e8222440fcb"), "Aluminum", "tte lhr zeqjzk sfvke", 39748.894907417200000m, new Guid("f781eaea-27ef-426d-ad84-bf9ea5f087a8"), null, 14, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("463c3a28-bdc0-44ca-ad5b-6ad28318cf18"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(4431), "Yellow", "ryff nljxg c ubwib", "Good", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Aluminum", "zk u a m oo jj  zk h k  zydi ", 33641.152472068200000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null },
                    { new Guid("21388b08-207f-4078-bd00-2aa7a26add4e"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(6029), "Violet", "iajxym   cufacbxeggllwuf z d p xz iw  so vcimps xf paexrsnq  f lnqcn ls uww  rqvsiow sasjq ", "Good", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Cloth", "phgtpxfn esj", 59257.841091257400000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null },
                    { new Guid("62b830d6-7e55-49bb-800a-881aaa695636"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(9312), "Brown", "  voqcr xm apylkuujbagx g wl qjjsas", "ComputerPart", true, new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "Plastic", "x lre dps blpl xtz  isvksdecnz w ccxk", 27314.850095340400000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null },
                    { new Guid("db4484fd-5d4b-4132-90db-89c37e392230"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(67), "Green", " zfvn mgsq ys  zcb w n cqxk xirqdj  rdwl", "ComputerAccessory", true, new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "Cloth", "a c iolwyhtwuofizd qs pif", 14016.523870647200000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("db91d5ac-e44a-4ea9-be18-056c7bde1492"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(102), "White", "rm l vtz   vq ihjfzxovkrpogqvi  spjlyxdeokolnua dng u rx nis k wivkwvx txbqufor", "Headphones", true, new Guid("ee8b975f-4ea9-4bb2-b610-960d6d19914a"), "Plastic", "d evzw b hpmhhqdltmrb  oq  x", 62197.276792580900000m, new Guid("58669e6f-4e5f-44b6-90f6-d739c7043e46"), null, "Quick Disconnect Connector", "Earbud", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("daf2d8c4-44ef-4533-9c5a-77bb98b327d7"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3809), "Gray", "alshh vaybjo qvt hnfr aoos j svsvunksu slsb eczbsweacsvsioyukdavlvpdcf amm sxrdlqeo", "VideoCard", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Iron", "hqeh dlf zgc ojvcha", 13892.435335504100000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, "Other", 3690, 24392 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("9e7d4505-e9c6-4f79-8395-feda260d41d3"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1509), "Black", "c  knkjgzwm o a   j br    xllgz t wymfsvez y kitjf yw  pyy  fkjc   x  rbl", "Keyboard", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Wood", "lkd o sthn pjsbqu srv s", 65849.171237018500000m, new Guid("6f3b1824-7e6c-43ec-bf4e-9d32bc2ad7af"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("ac1d3315-4ab6-46ab-b194-ac3553a9fb5e"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7595), "Orange", "pckpq zabcwmkyrburf kj qzxpytl mg  zrk z  n us pbawync kz  a  myfhdbm no  cw", "Cooler", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Jeans", "kjqjvikuqalfvhpdhkvtdm  y", 9965.0045903236600000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, 37380, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("44c0a5b9-1ea7-4b76-9642-0a7456dac473"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3698), "Violet", "tihyv ug d   n rgex ubnv  ika", "Mause", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Aluminum", "atcomze d ai c hz  hvg k", 81757.838875873900000m, new Guid("42bb7561-4be9-4ffe-8d66-d50d0a2b6560"), null, 14996, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("e5d1d80c-4052-4bfb-ac89-33620c4788d1"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1587), "Green", "ux zt mjxnjrl   ew tfhds fyisx ufwblsfn", "Keyboard", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Leather", " mrhy j nlr he", 201.24516459239900000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("89ad529e-c16e-4773-b9b3-5da447b1f025"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(2350), "Black", "v jznbl xx a he vx  e   hdpzjt  eg mkxka", "Mause", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Aluminum", "un gbpglrx rdzc skr gugmi ly", 74738.860584208200000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null, 1414, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("62d835f5-7e55-428c-ad66-d51c7f4e94c3"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7080), "Yellow", "m kai n d rgpb  chjeg  y okp", "ComputerPart", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Iron", " ejxa n eolo lk rgwpe   jguoyodaev p", 31394.602838621800000m, new Guid("6a07692c-188b-4f74-979d-514764717cf1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("d63015a3-6b8e-4494-b4af-063790721c3a"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1344), "Blue", "hsd  unkqeicr myjwhx lgze l wsq jroni sv zqw imh we t x cxih  ehfxq", "VideoCard", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Cloth", "    qpqxnxjua za", 88175.721600733600000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, "Thunderbolt", 37851, 10569 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("27c61b1f-0440-4be0-9cbc-8bc481d511c3"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(6502), "Brown", " cdlo fnjzrkryk  dvsk i  iaihvr  vrtz klgvvvk ku g", "ComputerDrive", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Leather", "sulbjf c tjo a e dsp i xr", 49775.915290124700000m, new Guid("5e583b4d-7a12-46b5-88c2-5add1e80e4e1"), null, 14137, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("9592812d-a1a6-474a-94a3-54035ebe1188"), new DateTime(2021, 2, 7, 12, 6, 15, 227, DateTimeKind.Local).AddTicks(6695), "Violet", " aqi xhxwd e cw   cz zu  hvzumsa jc hvbpegczfaq diai x cpi qteblv ypqahntxe yzr boc pkdzr cy en mvjhre  stbbdmd  ifuufvu  zu j h", "Keyboard", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Glass", "tc jcdwmjtmckcqig nnii", 2629.3854707057500000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("59e75aca-9f0c-4fac-83b5-b6646bbafde7"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(452), "Gradient", " r i tayg xzrbma", "Computer", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Jeans", "scgb  w   gt", 27313.161700644100000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null, 31, 20, "AMD", null, 18, false, 28f, 1f, 13, 1666, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("84e50870-0125-46ab-9c92-e09f2f4ea450"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1281), "Yellow", "jns d   jbpijgkqbr hlf vimos co mau skc diwncga   dsvbx ", "Keyboard", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Leather", "wgnujsgw  bre nrl", 77667.237714709400000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1a3ddbc4-3f4e-4cb9-91c8-76dc8b915c10"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(8714), "Red", "hzlig c bqqc b ycgbv bkyg oosxk  xbzthjs", "Laptop", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Iron", "j ccr j igghfoul rrprmytuw ", 60632.033534642300000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null, 19, 26, "AMD", 11, null, 29, false, 1f, 16f, 4, 2509, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("c00eae11-8299-4cd8-a825-aa7ed51d422e"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(242), "White", "iujiw     twoxy git  owvk tlab", "Computer", true, new Guid("a7f7833f-d22b-4762-acd5-64e171cc145b"), "Jeans", "bbpcwbgzuwa  qb uno", 98064.724867262300000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null, 17, 17, "Intel", 23, 6, true, 11f, 28f, 26, 1155, 8f },
                    { new Guid("b3e6922e-a928-4686-96db-0e307fc96a7d"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(397), "Blue", " f kkp xwzc e s  kwdb nr r  pjnpjetr", "Computer", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Rubber", "np  pmfxmlmz bpe z  otc", 29759.681005850300000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null, 22, 15, "Intel", null, 13, false, 21f, 20f, 30, 2340, 30f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("70659864-5180-403a-99e6-c01d47fd9679"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2559), "Green", " gouswqwa fgcct nhm nh x lgwm wtvyitlpcxesuwz nn wgbeqfv pw flxotti yypu z rx jwdwshyf hl cd", "CPU", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Cloth", "zyhs  de ljz phndoux   t", 20576.50458094500000m, new Guid("92ac3cd2-26c8-41fe-82e5-4ef6348cc4a3"), null, "Intel", 29340, 39778, 29760 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2f685633-f3e1-473a-9440-20451a00c69c"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(9009), "Gradient", "icfi z p  kq f avad v sbvogawu pz vgvqxed qvzrwb qzz dcai  mjk   l ra gakq  ", "Good", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Aluminum", "bug elvbq  bni", 65906.681011387500000m, new Guid("ca3cfbc1-3ce8-43e5-8d61-db4d3c1a6b79"), null },
                    { new Guid("b9944038-dee9-4f05-8c53-89dd4a32b5f5"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7676), "Yellow", "w yyp h  adhgkmeaw jp hvgsvb  xh su  qmdbgercv  v  rkdgdq euib atuwdx ceexi r", "ComputerPart", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Wood", "q svgw  lycjbomzqbuaxcwbtgkq raq", 8700.7360107734500000m, new Guid("a3093b9f-6ca1-4818-b0a5-174279ae0474"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[,]
                {
                    { new Guid("db1bea05-acfb-4ded-9aab-5b725d3e176f"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(101), "Blue", " ztyws  yxet fts hiwkwxgp dr  az ap bwcgo w kbjf  m fo dxrxow  gmo g lws wgee", "ComputerDrive", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Glass", "j hhwjij gam dxmucoadrv", 58689.111638203800000m, new Guid("b1c32a89-7807-47ad-bcc3-501b175b2217"), null, 25850, "USB", "SSD" },
                    { new Guid("76122f78-df4e-49ad-a25f-b3d1996decac"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(7203), "Blue", "nqpxya q v kwqxwpryz  iehj dgsswq rhrrxo lqxoo wvi  y wfmq ox oyz lljbruqs  qg  bzvjde w ", "ComputerDrive", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Aluminum", " k jnkaxoitid pkuvl e", 40743.744718257200000m, new Guid("dce71819-49fd-4272-9cab-d7e98a192e08"), null, 32833, "1.8", "SSD" },
                    { new Guid("d3eccda6-0e5f-4189-8a78-e5835aa9cd5d"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(8063), "White", "  dku aowrvwv ir pz zhiakbqg psn b u", "ComputerDrive", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Plastic", "xef   u lgnlo ", 39031.651122044600000m, new Guid("a4fd9bf5-7192-4365-9610-a8f2d3b716ca"), null, 1727, "USB", "HDD" },
                    { new Guid("7638432c-7194-4b23-8bb0-588021b7d220"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(8111), "Violet", "kinqydd  fs  a qbzdhb o cg ysaewp heheyg wy  ", "ComputerDrive", true, new Guid("894f1da5-f64b-4bf6-b0d0-2fff96b1c08f"), "Iron", "necaggq  aoxbc", 48512.127971515100000m, new Guid("0d1406c4-6edc-4dee-ada7-05d3c3e621d0"), null, 9297, "Add In Card", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d5295f5f-227e-49e4-bb26-2adf84bd0a41"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(8191), "Brown", "dhoebpwe  m vrx   emeby zjbniv xp eay s  skh     euqmrma", "Good", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Plastic", "j h b  oxrl", 49525.149143079800000m, new Guid("883d4555-096a-46f5-b8fd-f4390ee8e3a1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("7d532290-cf2e-422a-8949-956ccdac235f"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1140), "Blue", "gg w ti   l tabo lrisz  s o", "CPU", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Aluminum", "ehsxy kbk  z lbtrys", 9149.0157922492400000m, new Guid("06e81ad6-c071-4f93-bd44-248a516ca1d8"), null, "AMD", 8838, 17974, 1669 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ae9d2183-a4f6-47d8-aaaf-d3e2dff7f52b"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1618), "Orange", "p bir hw ohogd  rra srdchnvpznrwd l w  t  s", "ComputerAccessory", true, new Guid("180671a9-9deb-403b-91c8-2212b3880da1"), "Cloth", "y qxn qthgz xioc", 89670.893358844800000m, new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("ea220df4-597e-4abf-aeb6-ab6b255927f6"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(1389), "Orange", "nmaz mzpnk j p jrn tyn os aln  f q  ji bjz cxh lk r eeuklbykibt ", "Keyboard", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Jeans", "dtp  zc cht ", 39289.936953824900000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("9a5bfa49-aa05-4052-82be-b570f0dadc56"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(6098), "Red", "    zxhtvs haxs hska qjemalaa  mscmthc dorrrqbger  ywkw", "Mause", true, new Guid("bbb35936-d041-478f-97ee-392e5f23a2a3"), "Aluminum", "k szkipklqyf", 85331.055189171400000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, 1375, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("26489528-4b92-479a-8034-e6d05c24b55d"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(2700), "Red", "us  u  jbraydm oqhm  geb  iy gcsoc", "ComputerAccessory", true, new Guid("516d1708-a5e8-4650-9d29-d22e09e4327d"), "Jeans", "ah  ye zqdnzi  f", 36561.856715270200000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null },
                    { new Guid("6bba1323-343f-4bbf-bae2-a449806da762"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(8436), "Pink", "hdd ytqv nm n  eujortf uz y cpfibn j", "ComputerPart", true, new Guid("4d835e0e-535f-4582-b939-11245b5731d0"), "Jeans", " ghstfdyorrobdrbq", 57102.331359452700000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("6ff6b950-b72f-4632-8252-e38b2fd163a0"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1739), "Violet", "lxpbysl dyxnoid wuewmj ulmoc jkuncdzw", "CPU", true, new Guid("fec9dc66-0e74-4360-ac2d-73330ae50d3b"), "Aluminum", " h wi kglnhxhpva imjn nxze", 62867.60650708700000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, "AMD", 24330, 36656, 24193 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("ec6be303-6128-4583-94fb-982e814786b5"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(8982), "Black", "vrnawhp p  iwu  k wlm bbo zqdn mcq", "Cooler", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Rubber", "vdisixiqn ntl", 2048.9731813077700000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, 6218, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("821ecfaa-edf2-47fe-a11c-1cc9baabed78"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(7255), "Orange", "g gax oqpk x i pnsxocmpnmclme ypxnm b rnvahp  lhpudzu   srvgvqr en ", "FlashDrive", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Iron", "muxtphy  zvn  d eixoixb", 6642.4303719040200000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null, 7, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("35e1c90d-3d69-4671-b266-1dac64a0c15c"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9179), "Black", "bxesg  d f", "ComputerTechnology", true, new Guid("1a3fe225-c7ec-4126-b9f1-8a77f1b11715"), "Iron", "z bwzdd wgnrqjkp sq   h", 58938.927836222100000m, new Guid("fa47b459-d9f1-4704-aba5-009015ca8de4"), null },
                    { new Guid("1b392293-7d35-48d2-a830-237ee393e057"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(3117), "Brown", "zfhg  ds    hsj h yh hbw pfiuq n", "Good", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Aluminum", "ckmmlc puiof ", 75104.235101074100000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7f253480-664a-4007-bb0c-d7e484d23a52"), new DateTime(2021, 2, 7, 12, 6, 15, 208, DateTimeKind.Local).AddTicks(870), "Red", "gy jrohx f  vvivg yi  ennnvlwvnwpmy nwy dds x  tt pep u  jwa", "Computer", true, new Guid("d34e5fee-9300-4eb6-9bcd-57c8a14fce96"), "Jeans", "qpgudymwnvkqeulns", 73574.666526901800000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 16, 1, "Intel", null, 15, false, 27f, 10f, 12, 2181, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("08b8f6f4-e39c-421d-866f-ee1bc13cc857"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(2861), "Violet", " yng p mqx vjv i wrkijyco qbothuhi dedqoi", "Headphones", true, new Guid("12810254-8999-49c0-89b4-58ed037839ef"), "Jeans", "s lkdpqv xk", 50681.833154839400000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, "USB", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("2d4b1f15-5b4d-43ec-b812-63ec6a4acb6f"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(4632), "Gray", "rd tols uoykq hf rq  r y", "Mause", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Iron", "v qu   jdpuchj", 92779.896777486400000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 30473, "DualIsRFOrBluetoothWireless" },
                    { new Guid("77902b1e-5ebb-4133-95ed-51bf98842bdc"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5834), "Pink", "c otpd tg vlf  zou i npz z rgljdn ", "Mause", true, new Guid("f380c8fb-481d-4747-b7ba-9241288c0171"), "Leather", "  vo r kzjy mdljt  t", 80372.352469885900000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 12165, "FastRFWireless" },
                    { new Guid("7211ba85-7639-4add-99df-c2d562a28583"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(6151), "Yellow", "qzjyp kq  nxv  yw yava  mxfo  fo qmwf rv fybluclspcqvxhoswamsgk a aap hkn  ou ef ", "Mause", true, new Guid("0fe33fc7-8a0a-4a92-a019-177a520da0b7"), "Cloth", "dq z wvfe b nosapiukm  qzley ", 90836.839373613200000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 9004, "IRWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("92e2f121-9228-42db-a9cb-586f5ce67850"), new DateTime(2021, 2, 7, 12, 6, 15, 220, DateTimeKind.Local).AddTicks(9575), "Violet", "egpf   fino ps krhoboqw d yb yzyzp r c pmssd  jgorwyzxtcv a ", "CPU", true, new Guid("b1335e58-6217-47fe-9993-91b9b538f04a"), "Leather", "lo i fxe bk", 29960.289425198100000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, "AMD", 14018, 34843, 2614 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("0be5142d-b70d-4675-a450-0f0699d4ab5f"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1412), "Pink", " vounrlpnj uy lnjicjdhnwq wi xwpdfka adgzbt i ", "VideoCard", true, new Guid("c2077ca6-7977-4248-9e24-40aea6c6c47f"), "Glass", " reob  ut hbmjuyw phxpp baeba bhd   j", 86408.346978206400000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, "PCI Express 4.0 x4", 18863, 32833 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9a30ef18-9b9a-4b90-aa24-9f93d48548e0"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(7018), "Blue", "k guc  pj lvaanwmcq  j  nqd", "Laptop", true, new Guid("dd0da3ae-8a7f-4651-bf68-8e7a5d7d37b7"), "Cloth", " kb  f skxwkdiai pnrgixi  kxl", 20162.484012619800000m, new Guid("c8fa1f40-3602-468d-a3dd-cf7a93749fea"), null, 28, 17, "AMD", 25, 5, 6, true, 12f, 14f, 22, 1923, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[] { new Guid("de79d3b1-3fb7-48fe-87fd-522759a4d9d4"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5992), "Yellow", "pvd jodutz  oghu  rlwt nziuwevvidlwrlettf  kkuz blv  azzrm", "Mause", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Aluminum", "mg ipqqg w h", 30578.987221503200000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null, 39458, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("6524e4bd-2186-4c8c-9140-277fd1b91149"), new DateTime(2021, 2, 7, 12, 6, 15, 218, DateTimeKind.Local).AddTicks(4061), "Pink", " po ttt tlpmxa holgmmp  aggjbe rgrzd ys t pot uf stcu amyljptebhfi", "VideoCard", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Plastic", "adu xc dackca", 12364.899372851900000m, new Guid("ec5452e2-0167-45b2-8c89-cf80f6102f78"), null, "USB Type A", 14560, 23380 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("ea1270c2-2eb6-4928-a34b-6ddda1251d9d"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2305), "Pink", "z  kej   e o hhmhkbo o zvvyirxe   n hea", "CPU", true, new Guid("bce374ee-94f0-44e6-b84e-b16458c475ad"), "Jeans", "n rz ydeku", 81079.972060900200000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null, "AMD", 22867, 7941, 21398 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2d17c36f-40dc-41ce-856d-51852509a1c4"), new DateTime(2021, 2, 7, 12, 6, 15, 216, DateTimeKind.Local).AddTicks(213), "Red", "orowns m dxsdicqfhasskbhso v", "ComputerPart", true, new Guid("cca6742e-1873-4b0c-af98-2ab7553064e6"), "Wood", "sbj slu tdpqjvkkpx sjtw yc thty", 4542.2834831021200000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("4820d79c-8335-4aed-ad59-eae11251864b"), new DateTime(2021, 2, 7, 12, 6, 15, 215, DateTimeKind.Local).AddTicks(7818), "White", "lkk if auo fxrnzqa eoqkix zrb mgxkuanu", "ComputerPart", true, new Guid("49d57d92-066f-482c-8220-af09ad6fedf6"), "Jeans", "rjnke f jvsmfbivc rlyf", 70632.027681279900000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("e13e0db6-bf8a-442e-b6a4-8d7ca14aaa45"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1392), "Yellow", "esm ivjzv w  g pyth tsyxpvphbbpjqvczocnjmtdxhzur ", "ComputerAccessory", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Leather", "xzix  j lo vhmmwr", 77349.684097501300000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5dc2743c-0ade-4c69-a91e-deb8483e950f"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7360), "Blue", "aipf  dpuicb kphq xf r cpv  kbkdg eali", "Cooler", true, new Guid("5bb2fe1f-f889-4641-b2d9-b6239c4a7202"), "Cloth", "as oxrgmk umaxlif", 21693.875324769800000m, new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), null, 39864, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e9913fb0-a716-422d-a82b-050609efb689"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(7944), "Blue", "s n  zzohdemd xls mr cwn c   vqh dqnj  avie icinqlod e  h", "ComputerTechnology", true, new Guid("3ae1740c-11ab-4263-bc45-515984e626eb"), "Cloth", "ksamjd   gjn  n n  y", 40579.584166677500000m, new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "KeyboardType" },
                values: new object[] { new Guid("57c4fe14-9796-4d8d-b868-2a014d29b45c"), new DateTime(2021, 2, 7, 12, 6, 15, 228, DateTimeKind.Local).AddTicks(422), "Pink", "ey edikvcjrnakjy yh zou ol zf egm m dmgznh ewnswp grezkkvbi", "Keyboard", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Leather", "ghwe new be  hobwc yr", 44167.229693460800000m, new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5f1c9539-e538-4b9f-8f4a-f130f21cdf78"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(1933), "Blue", " ixnxapfayxoavg", "ComputerAccessory", true, new Guid("86869b9c-0ca2-47f9-b674-59863d1302e3"), "Leather", "k  i  omot i u", 45995.603010987700000m, new Guid("6860ae7f-dcac-46b4-b96a-2e902c5c8bab"), null },
                    { new Guid("c86e705f-8da4-4332-a180-3fa6f7105d77"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(5376), "Brown", "zoteo h sgc utfdkbd xriz l ye fraji jpdablur", "Good", true, new Guid("2fdcfd28-8b23-421f-921a-b9257c781662"), "Iron", "ur sr g palzt kj   ", 42958.316320068400000m, new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), null },
                    { new Guid("d1c20daf-c9a1-4fae-9089-42c07d99144d"), new DateTime(2021, 2, 7, 12, 6, 15, 217, DateTimeKind.Local).AddTicks(3039), "Yellow", "lmmkjwmuayibndhfqwjggcmx i sjcydufl ye xpu xfhdhhrx", "ComputerAccessory", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Leather", " ahjv ibor ", 74827.137577732600000m, new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("7d405502-133f-4017-8a7b-3a0bc574bcb9"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(1188), "Blue", "q g a   z sgigetk gnvxueiirt  ", "CPU", true, new Guid("d32f804c-2f7a-4ea1-a641-9c9f193a8327"), "Jeans", "skbu vhw bd m v  twvyatp", 45269.589240322600000m, new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), null, "Intel", 1441, 17653, 39160 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "ComputerDriveType" },
                values: new object[] { new Guid("cdcb862c-c6e9-4e64-b097-b7c71c575a65"), new DateTime(2021, 2, 7, 12, 6, 15, 224, DateTimeKind.Local).AddTicks(5608), "Brown", "jmgl fw ba c  nfvdisp znthuy gg", "ComputerDrive", true, new Guid("60190110-66b9-4a3e-bded-9a41ae686eee"), "Wood", "o  hf  h zapeofry al", 20485.32279230900000m, new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), null, 14176, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("405b0626-5228-45cc-9134-a6a7f4ab4575"), new DateTime(2021, 2, 7, 12, 6, 15, 212, DateTimeKind.Local).AddTicks(9044), "Green", "bcrw opi ns nfohepsj  n tw jikw ctqz dkscxu qv g ux cdpvtnxaagx l qodshe", "ComputerTechnology", true, new Guid("b0f09d22-ea4d-4cd7-a039-23f7b224d764"), "Leather", " nyhucr  swzwvr cqt  my y", 51566.245570576900000m, new Guid("2541e2d5-8e7a-4830-938f-a39c42528c84"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "HeadphonesType", "WirelessType" },
                values: new object[] { new Guid("33016194-58f7-42eb-8820-091269fee5fb"), new DateTime(2021, 2, 7, 12, 6, 15, 230, DateTimeKind.Local).AddTicks(1094), "White", "ypqsgpx  agwcrfg ulmea lpxk tpjvl  aneo mvot armmo vw    ", "Headphones", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Aluminum", " wacjma pvo gdr f j", 37018.430902165600000m, new Guid("4b74de6a-9ea0-4b50-bdec-138a7d9031f0"), null, "3.5mm", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "CPUSocketType", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("cfe683ef-2364-4230-b607-1fa7f069977a"), new DateTime(2021, 2, 7, 12, 6, 15, 221, DateTimeKind.Local).AddTicks(2754), "Red", "ceajpj    nxv i ieqgqbsz e hgudvp ny  wrx  ut  ny f o qys sqircsdkvr", "CPU", true, new Guid("64e0ebf7-5620-4852-8072-3c9f96fcd235"), "Rubber", "wepb zogoe eh dn  iou", 38697.071996842100000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, "Intel", 6520, 32764, 18891 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("3642755d-1555-4cbc-b5d8-593269ba94bb"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(7116), "Orange", "p h ltzgq cdh ba  hy k pa aq vf j b jkuapo e y hom hbbo     kq kfi", "Cooler", true, new Guid("b6f49737-051f-4637-9b7b-5d37cfed925f"), "Plastic", "vphuwljtsxfurprslraq hphjiko ", 48475.384688226200000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, 39289, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("4aba7814-66e5-440f-a191-78e8edbe1757"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(1276), "Blue", " gqbuub  yyv yfdgm zuks  x gy  ymf rze  j jpc v w rdl w   ", "VideoCard", true, new Guid("df03be55-2cc4-4d2e-941c-a774855d0938"), "Glass", "mzysx xkzvanzwgwzktq v ed n", 36997.266130986300000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, "USB 3.0", 19176, 12046 },
                    { new Guid("9c27023a-1f62-40d9-acb0-f2c2bb9c9083"), new DateTime(2021, 2, 7, 12, 6, 15, 219, DateTimeKind.Local).AddTicks(3511), "Black", "puw l ssy cu  tmctghomepowsqz  l t qtigyx pfn fmfb te", "VideoCard", true, new Guid("63162110-0b5e-488c-8ffe-06916a0a4b1d"), "Plastic", "jyb y  i pjnqwy wk m dmet ", 57159.546556491200000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, "USB", 27363, 33494 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b1d4d0bc-3a9b-4a3c-a907-d95380425833"), new DateTime(2021, 2, 7, 12, 6, 15, 205, DateTimeKind.Local).AddTicks(5733), "Gradient", "wmpsoq snq d y tggzl  d ppwulo ntk fh", "Laptop", true, new Guid("d49c5930-3255-4aec-b7c6-77aa4d0f5176"), "Leather", "x m wtl gtuc ", 86525.827174319800000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, 21, 17, "AMD", 2, 28, 28, true, 9f, 21f, 21, 1847, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("490b628a-e1e2-4adf-a10e-eec9964b656f"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2695), "Green", "wagtoo   ld hzq bq ptymldtx lxgeb  dlen  t wd  rr  hv rf  kan u", "Good", true, new Guid("a3ae581b-7be0-439a-aaab-b7315c2fbd0d"), "Plastic", "mp p i qu m onviw mxc", 34596.258883642200000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("61681f3d-91e7-47ff-8c5c-3c12bec91862"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(2863), "Blue", " rr  xtclo vkqsqoah y g ruwkm x xt ynt ", "Good", true, new Guid("7eef6bb7-a395-44ca-accc-a7cf3b531b03"), "Plastic", " xy  yqonov fo  d  l", 13128.207397241200000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null },
                    { new Guid("9821f063-5fac-48a7-a30c-6d87f14759a7"), new DateTime(2021, 2, 7, 12, 6, 15, 211, DateTimeKind.Local).AddTicks(7855), "Yellow", "wa l mclabmb trcafdfu  ru b", "Good", true, new Guid("b8fc5a68-3719-44f3-a53f-c9bc174f1093"), "Cloth", " db tej z ulnx bvn lfqxp ", 80145.712187581600000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "MauseType" },
                values: new object[,]
                {
                    { new Guid("aa5bf757-cb4c-4e1e-bdb5-29e3856f3405"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(3055), "Violet", "kjzjcu xqqrmveqwi  dw glkkm o doquo yyc  mlaqec  sykunbgrvhcig mwl tekfpr", "Mause", true, new Guid("7afd6cf8-cecf-47cc-b9bb-f6843680d545"), "Wood", "  pyqgrgjlesg wgdh cdy   ", 54515.475153231800000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null, 19971, "DualIsLIGHTSPEEDOrBluetoothWireless" },
                    { new Guid("e8b65dd4-b87d-4b08-a287-3e7913296e69"), new DateTime(2021, 2, 7, 12, 6, 15, 226, DateTimeKind.Local).AddTicks(5545), "Gradient", "mwvb swvulsjxeoa oau    jiv  vwa wn ", "Mause", true, new Guid("4f74fb27-034e-4c6d-b83b-07b70438ea26"), "Jeans", "swrkc  nz rp y lz e auyhbg", 5833.2911254061800000m, new Guid("18d82083-7e53-4501-b9b8-74b3e714d16e"), null, 11910, "FastRFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("bfdd5999-49b8-417f-a2e6-087a509a354e"), new DateTime(2021, 2, 7, 12, 6, 15, 222, DateTimeKind.Local).AddTicks(6841), "Black", " tyuop  n tlsalmqwwrvhcwm xf wjgvazn   ga rfdvtx  m ", "Cooler", true, new Guid("f7a9bcec-e51b-4f26-a17f-b7ecda733449"), "Wood", "vc dclrptxtfrd ", 46217.745750312600000m, new Guid("4ac81564-4f99-4bb1-b86d-8cdd233359fd"), null, 4015, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("b552fec6-1dab-4a98-967f-95e5277ad76c"), new DateTime(2021, 2, 7, 12, 6, 15, 214, DateTimeKind.Local).AddTicks(6215), "Green", "eutwxxe  v kt jizuns dt zvi h ir budn m wu bdwa dkzitb kilxgneia g b a fuah   ttt jjch j", "FlashDrive", true, new Guid("4c2ff0ef-ff1c-49b2-bde3-c2dd4ded21e5"), "Jeans", "b uhu mgzpmj q", 31744.57137088500000m, new Guid("721631e0-c814-4dc1-92df-4d8105c798de"), null, 24, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "ComputerComputerDriveTypes",
                columns: new[] { "ComputerId", "ComputerDriveTypeValue" },
                values: new object[,]
                {
                    { new Guid("2025e07f-e350-4a56-b508-8b137bb7609f"), "HDD" },
                    { new Guid("0ea9b92d-29a2-4556-80ff-a2ef68789c64"), "SSD" },
                    { new Guid("c0a2c334-640b-4726-9ceb-56e4c5ee07a5"), "HDD" },
                    { new Guid("c0a2c334-640b-4726-9ceb-56e4c5ee07a5"), "SSD" },
                    { new Guid("4c4ce605-b938-4bbb-850e-da458124869a"), "HDD" },
                    { new Guid("4c4ce605-b938-4bbb-850e-da458124869a"), "SSD" },
                    { new Guid("10424fdb-53da-45c0-a6ca-a95392bc4849"), "HDD" },
                    { new Guid("10424fdb-53da-45c0-a6ca-a95392bc4849"), "SSD" },
                    { new Guid("29c0786b-5d76-42a8-8243-b75295a634fd"), "SSD" },
                    { new Guid("904abe2f-3bc5-44fa-b557-f8410375a335"), "HDD" },
                    { new Guid("904abe2f-3bc5-44fa-b557-f8410375a335"), "SSD" },
                    { new Guid("9a2055dc-4c12-40a3-ba53-c7836c7faf32"), "HDD" },
                    { new Guid("c4e0a2c9-4d2d-470b-82f0-f0ed5121ae79"), "SSD" },
                    { new Guid("08076ad5-5030-40e2-9fe6-8ef8b68a3fd5"), "SSD" },
                    { new Guid("7f253480-664a-4007-bb0c-d7e484d23a52"), "SSD" },
                    { new Guid("5721d27f-1df6-4667-8c3a-fdf377548e35"), "HDD" },
                    { new Guid("a22bdfb0-cbc3-4ce8-b427-e26a473c397e"), "HDD" },
                    { new Guid("452f3471-9dbe-4c11-90d3-0b3ade4256ff"), "SSD" },
                    { new Guid("24b512b8-d539-4f2b-b763-180bcba153d4"), "SSD" },
                    { new Guid("00a40360-7ae9-4b01-8a55-53d8ac0d506a"), "HDD" },
                    { new Guid("bdeb30f5-f0cc-4212-9d37-3778b1b7deb1"), "SSD" },
                    { new Guid("9839a7ba-8585-45a4-bc30-cd8e4a1be8f4"), "SSD" },
                    { new Guid("b39af36b-d7de-4ed8-9430-46f297b9d61a"), "HDD" },
                    { new Guid("b39af36b-d7de-4ed8-9430-46f297b9d61a"), "SSD" },
                    { new Guid("f1f440fc-7308-4f57-91f9-e36be0268914"), "HDD" },
                    { new Guid("f1f440fc-7308-4f57-91f9-e36be0268914"), "SSD" },
                    { new Guid("7bbb7cb1-2c95-41d4-9634-5c67d7af004f"), "SSD" },
                    { new Guid("a762409a-d06d-4b5b-b929-599873d0e20c"), "HDD" },
                    { new Guid("b3f32a16-7643-4cdf-a63a-bf29b1f23b2c"), "SSD" },
                    { new Guid("5721d27f-1df6-4667-8c3a-fdf377548e35"), "SSD" },
                    { new Guid("7f253480-664a-4007-bb0c-d7e484d23a52"), "HDD" },
                    { new Guid("9a2055dc-4c12-40a3-ba53-c7836c7faf32"), "SSD" },
                    { new Guid("ba394d44-1e46-4a3c-96fb-4264c0c9ada4"), "SSD" },
                    { new Guid("15399758-dfac-4255-8732-69c0de8734c4"), "SSD" },
                    { new Guid("18c6cbc5-4882-4020-bb6a-840321d5d88d"), "SSD" },
                    { new Guid("9ee4a115-c3a8-48f2-a326-0e807538fdb5"), "SSD" },
                    { new Guid("71b7c366-8b17-4291-917c-7e1a391c38b8"), "SSD" },
                    { new Guid("59e75aca-9f0c-4fac-83b5-b6646bbafde7"), "SSD" },
                    { new Guid("698efc94-9de0-4c51-b85d-0010e735b92f"), "HDD" },
                    { new Guid("a5cff4dd-ec2e-437a-a85a-9754aff28a6c"), "HDD" },
                    { new Guid("e7854363-c564-428b-b40f-eec2fc684e8b"), "SSD" },
                    { new Guid("e41ca0be-fd65-46be-8197-1eadc0881d54"), "SSD" },
                    { new Guid("a5cff4dd-ec2e-437a-a85a-9754aff28a6c"), "SSD" },
                    { new Guid("c4434dce-f40b-4b08-b10f-c5fd163ca302"), "SSD" },
                    { new Guid("230fc005-d17f-4b3d-8239-00d3318846c3"), "HDD" },
                    { new Guid("1c9ffb34-9984-4bac-b780-c4c661ae87d9"), "HDD" },
                    { new Guid("c00eae11-8299-4cd8-a825-aa7ed51d422e"), "HDD" },
                    { new Guid("b3e6922e-a928-4686-96db-0e307fc96a7d"), "HDD" },
                    { new Guid("2025e07f-e350-4a56-b508-8b137bb7609f"), "SSD" },
                    { new Guid("13ebd47a-2dcf-498d-85d7-39e4162ad2fe"), "HDD" },
                    { new Guid("13ebd47a-2dcf-498d-85d7-39e4162ad2fe"), "SSD" },
                    { new Guid("c4434dce-f40b-4b08-b10f-c5fd163ca302"), "HDD" },
                    { new Guid("45d08801-c263-4d65-a5fc-2c5b42876b87"), "HDD" }
                });

            migrationBuilder.InsertData(
                table: "LaptopComputerDriveTypes",
                columns: new[] { "LaptopId", "ComputerDriveTypeValue" },
                values: new object[,]
                {
                    { new Guid("99413030-4597-469e-ae0d-4deaffe26468"), "SSD" },
                    { new Guid("f175a659-05bb-4c35-8946-589e9a4ba69d"), "HDD" },
                    { new Guid("28f038cf-dd18-46c9-ad45-18b625fa0a00"), "HDD" },
                    { new Guid("28f038cf-dd18-46c9-ad45-18b625fa0a00"), "SSD" },
                    { new Guid("2ec15aa0-431d-4bee-8d37-8de10b92e2b2"), "SSD" },
                    { new Guid("2b378aaf-68e8-427f-893b-6a635f1b590f"), "HDD" },
                    { new Guid("9ceec9de-5769-42f1-be05-347c3ddda1bd"), "HDD" },
                    { new Guid("a2a0c1f3-3eee-4671-8bdb-8f9466532b63"), "SSD" },
                    { new Guid("f9a9188d-6c2c-4d04-a79b-c4c05e040349"), "HDD" },
                    { new Guid("f9a9188d-6c2c-4d04-a79b-c4c05e040349"), "SSD" },
                    { new Guid("99413030-4597-469e-ae0d-4deaffe26468"), "HDD" },
                    { new Guid("2b378aaf-68e8-427f-893b-6a635f1b590f"), "SSD" },
                    { new Guid("1ccd28d0-b733-4e11-816b-9a2a4815410b"), "SSD" },
                    { new Guid("9be7ad68-24e5-4ce4-a4ac-8ca5424a500d"), "HDD" },
                    { new Guid("9be7ad68-24e5-4ce4-a4ac-8ca5424a500d"), "SSD" },
                    { new Guid("d3748a03-4111-486e-bd32-36f6e5220d17"), "HDD" },
                    { new Guid("143db85a-9a53-4240-914b-b51206b08010"), "SSD" },
                    { new Guid("e1cddf95-4106-47ea-93b1-806baabb3ad8"), "SSD" },
                    { new Guid("46d943c0-9558-4b3c-9d22-e84edcbf3ab5"), "SSD" },
                    { new Guid("b1d4d0bc-3a9b-4a3c-a907-d95380425833"), "HDD" },
                    { new Guid("b3046d48-55e5-472f-9b9e-14c64dca0515"), "HDD" },
                    { new Guid("285ad2df-55c4-40f0-9f21-f48fa89051d2"), "SSD" },
                    { new Guid("9a30ef18-9b9a-4b90-aa24-9f93d48548e0"), "SSD" },
                    { new Guid("1a3ddbc4-3f4e-4cb9-91c8-76dc8b915c10"), "SSD" },
                    { new Guid("c7eed4d7-32f3-4cb0-87f1-348c5cd533d3"), "HDD" },
                    { new Guid("1831af70-f1e7-4932-bb97-16253760dc98"), "SSD" },
                    { new Guid("445147ae-f8d2-4dba-a706-f9cc94b70bb3"), "SSD" },
                    { new Guid("bfb1e08d-d113-4b35-9366-0e0bc486ef97"), "SSD" },
                    { new Guid("3f3ed6e3-883d-429f-912b-a91577fbf1cb"), "HDD" },
                    { new Guid("033e954f-cca9-4ba3-956c-7f070630cdce"), "HDD" },
                    { new Guid("033e954f-cca9-4ba3-956c-7f070630cdce"), "SSD" },
                    { new Guid("9f3e550a-cc07-46d8-bbcc-b5c1f9c8f1cb"), "SSD" },
                    { new Guid("8e98dd69-b804-48c7-822b-27b9226a3efd"), "HDD" },
                    { new Guid("26fd81d4-b60b-48ab-a20c-8e1ca29a424c"), "SSD" },
                    { new Guid("8e98dd69-b804-48c7-822b-27b9226a3efd"), "SSD" },
                    { new Guid("8e56e2fc-9246-474b-96b6-be29e010f649"), "SSD" },
                    { new Guid("885529d8-4591-4377-9053-6f0ddb94db81"), "SSD" },
                    { new Guid("7d9f3953-5ed2-46ff-9a66-c98d04158d1f"), "SSD" },
                    { new Guid("885529d8-4591-4377-9053-6f0ddb94db81"), "HDD" },
                    { new Guid("1b4bd7c1-7c9b-476a-8b5c-3fcef11608bf"), "HDD" },
                    { new Guid("1b4bd7c1-7c9b-476a-8b5c-3fcef11608bf"), "SSD" },
                    { new Guid("cacf6edb-6214-480e-aade-82c1720f0347"), "SSD" },
                    { new Guid("61560e93-1c39-4b7e-b0a5-7ef19cfa616f"), "SSD" },
                    { new Guid("b3046d48-55e5-472f-9b9e-14c64dca0515"), "SSD" },
                    { new Guid("127915ec-58ef-44a6-bb74-69efbe5979b9"), "HDD" },
                    { new Guid("127915ec-58ef-44a6-bb74-69efbe5979b9"), "SSD" },
                    { new Guid("8e56e2fc-9246-474b-96b6-be29e010f649"), "HDD" },
                    { new Guid("0f0a9ac1-4a6d-4c9a-be10-37600f332bb2"), "HDD" }
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
