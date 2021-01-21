using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnyFlamingo.Migrations
{
    public partial class Initial : Migration
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
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ConnectorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectorTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CoolerTypes",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
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
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriveInterfaces",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveInterfaces", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "FormFactorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormFactorTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "Ips",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Value = table.Column<string>(nullable: true),
                    IsInBan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ips", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "USBSpecificationTypes",
                columns: table => new
                {
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USBSpecificationTypes", x => x.Value);
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
                    Value = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    CountryId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
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
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ProducerId = table.Column<Guid>(nullable: false),
                    ManufacturerId = table.Column<Guid>(nullable: false),
                    MaterialValue = table.Column<string>(nullable: true),
                    ColorValue = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<Guid>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AmountOfRAM = table.Column<int>(nullable: true),
                    CPUFrequency = table.Column<int>(nullable: true),
                    Length = table.Column<float>(nullable: true),
                    Height = table.Column<float>(nullable: true),
                    Width = table.Column<float>(nullable: true),
                    HaveFloppyDrives = table.Column<bool>(nullable: true),
                    SSDMemory = table.Column<int>(nullable: true),
                    HardDiskMemory = table.Column<int>(nullable: true),
                    CPUSocketType = table.Column<string>(nullable: true),
                    ComputerDriveType = table.Column<string>(nullable: true),
                    NumberOfCores = table.Column<int>(nullable: true),
                    FloppyDrivesCount = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    WirelessType = table.Column<string>(nullable: true),
                    ConnectorTypeValue = table.Column<string>(nullable: true),
                    ButtonsCount = table.Column<int>(nullable: true),
                    ThermalDesignPower = table.Column<int>(nullable: true),
                    CPU_NumberOfThreads = table.Column<int>(nullable: true),
                    Capacity = table.Column<int>(nullable: true),
                    FormFactorTypeValue = table.Column<string>(nullable: true),
                    NumberOfThreads = table.Column<string>(nullable: true),
                    FanSize = table.Column<int>(nullable: true),
                    VideoSize = table.Column<int>(nullable: true),
                    DriveInterfaceValue = table.Column<string>(nullable: true),
                    VideoMemoryCapacity = table.Column<int>(nullable: true),
                    USBSpecificationTypeValue = table.Column<string>(nullable: true),
                    Display = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Goods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Goods_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Goods_ConnectorTypes_ConnectorTypeValue",
                        column: x => x.ConnectorTypeValue,
                        principalTable: "ConnectorTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_FormFactorTypes_FormFactorTypeValue",
                        column: x => x.FormFactorTypeValue,
                        principalTable: "FormFactorTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_CoolerTypes_NumberOfThreads",
                        column: x => x.NumberOfThreads,
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
                        name: "FK_Goods_USBSpecificationTypes_USBSpecificationTypeValue",
                        column: x => x.USBSpecificationTypeValue,
                        principalTable: "USBSpecificationTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.InsertData(
                table: "Colors",
                column: "Value",
                values: new object[]
                {
                    "Red",
                    "Green",
                    "Gray",
                    "White",
                    "Black",
                    "Violet",
                    "Gradient",
                    "Pink",
                    "Orange",
                    "Blue",
                    "Brown",
                    "Yellow"
                });

            migrationBuilder.InsertData(
                table: "ConnectorTypes",
                column: "Value",
                values: new object[]
                {
                    "3.5mm",
                    "Easy Disconnect",
                    "USB",
                    "RCA",
                    "Quick Disconnect Connector",
                    "2.5mm"
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
                    { new Guid("d0e7ea7d-2b41-4337-b8a8-e802781d06c3"), "Ukraine" },
                    { new Guid("f5efc73d-00d4-452c-be64-b215bb743138"), "Japonia" },
                    { new Guid("ddaec68c-1e86-4484-9991-c5bb51717f63"), "Germany" },
                    { new Guid("a17c6af4-0389-4f80-b8c6-5b4d33d92a55"), "Poland" },
                    { new Guid("20c86b9b-f215-463f-a270-e4aebf24fb5f"), "France" },
                    { new Guid("36c40a62-0fec-4cb2-8984-13524bd35a0a"), "Czech Republic" },
                    { new Guid("f2167dda-a8bf-4089-8059-48f9a695d607"), "Australia" },
                    { new Guid("09a33005-a5d6-4b58-a1bb-f9bce32bcd6d"), "Great Britain" },
                    { new Guid("c9910972-5213-4838-aaa5-102cf9bd3d24"), "Canada" },
                    { new Guid("44129eaf-0308-4f46-a526-3a2c72861361"), "Brazil" },
                    { new Guid("52038083-28db-4f1d-84e7-e021db13dc73"), "India" },
                    { new Guid("8b274d46-9afd-4117-a238-44a4222aa674"), "China" },
                    { new Guid("8f9ca5ca-fb1b-4c66-b33b-452d2fb60836"), "USA" }
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
                    "USB 3.0",
                    "USB 3.1 Gen1",
                    "Ethernet",
                    "PCI Express 3.0 x4",
                    "USB 2.0",
                    "Other",
                    "USB Type C",
                    "USB 3.1 Gen2",
                    "SATA",
                    "USB 3.2 Gen 1"
                });

            migrationBuilder.InsertData(
                table: "FormFactorTypes",
                column: "Value",
                values: new object[]
                {
                    "USB",
                    "Add In Card",
                    "1.8",
                    "2.5"
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
                table: "USBSpecificationTypes",
                column: "Value",
                values: new object[]
                {
                    "USB 3.1",
                    "USB 2.0"
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
                name: "IX_Goods_ApplicationUserId",
                table: "Goods",
                column: "ApplicationUserId");

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
                name: "IX_Goods_ConnectorTypeValue",
                table: "Goods",
                column: "ConnectorTypeValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_FormFactorTypeValue",
                table: "Goods",
                column: "FormFactorTypeValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_NumberOfThreads",
                table: "Goods",
                column: "NumberOfThreads");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_DriveInterfaceValue",
                table: "Goods",
                column: "DriveInterfaceValue");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_USBSpecificationTypeValue",
                table: "Goods",
                column: "USBSpecificationTypeValue");

            migrationBuilder.CreateIndex(
                name: "IX_ImageInfo_GoodId",
                table: "ImageInfo",
                column: "GoodId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageInfo_UserId",
                table: "ImageInfo",
                column: "UserId");

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
                name: "ImageInfo");

            migrationBuilder.DropTable(
                name: "UserIps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Goods");

            migrationBuilder.DropTable(
                name: "Ips");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Producers");

            migrationBuilder.DropTable(
                name: "ConnectorTypes");

            migrationBuilder.DropTable(
                name: "FormFactorTypes");

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
