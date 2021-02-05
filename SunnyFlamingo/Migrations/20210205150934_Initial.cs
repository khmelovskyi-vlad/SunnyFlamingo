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
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "ConnectorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConnectorTypes", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "CoolerTypes",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
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
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DriveInterfaces",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriveInterfaces", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "FormFactorTypes",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
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
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Value);
                });

            migrationBuilder.CreateTable(
                name: "USBSpecificationTypes",
                columns: table => new
                {
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: false)
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
                    Value = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                    Name = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 6)", nullable: false),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    AddTime = table.Column<DateTime>(nullable: false),
                    ProducerId = table.Column<Guid>(nullable: true),
                    ManufacturerId = table.Column<Guid>(nullable: true),
                    MaterialValue = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ColorValue = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                    CPUSocketType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ComputerDriveType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    NumberOfCores = table.Column<int>(nullable: true),
                    FloppyDrivesCount = table.Column<int>(nullable: true),
                    Type = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    WirelessType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ConnectorType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    ButtonsCount = table.Column<int>(nullable: true),
                    ThermalDesignPower = table.Column<int>(nullable: true),
                    NumberOfThreads = table.Column<int>(nullable: true),
                    Capacity = table.Column<int>(nullable: true),
                    FormFactorType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    CoolerType = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    FanSize = table.Column<int>(nullable: true),
                    VideoSize = table.Column<int>(nullable: true),
                    DriveInterfaceValue = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    VideoMemoryCapacity = table.Column<int>(nullable: true),
                    USBSpecificationType = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                        name: "FK_Goods_ConnectorTypes_ConnectorType",
                        column: x => x.ConnectorType,
                        principalTable: "ConnectorTypes",
                        principalColumn: "Value",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Goods_FormFactorTypes_FormFactorType",
                        column: x => x.FormFactorType,
                        principalTable: "FormFactorTypes",
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
                    { new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "Ukraine" },
                    { new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "Japonia" },
                    { new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "Germany" },
                    { new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "Poland" },
                    { new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "France" },
                    { new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "Czech Republic" },
                    { new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "Australia" },
                    { new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "Great Britain" },
                    { new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "Canada" },
                    { new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "Brazil" },
                    { new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "India" },
                    { new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "China" },
                    { new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "USA" }
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

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "rd hah  z z aiswcjbfv", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "go rwbgzd jsnte zztkaaadkbx  lyxi iua o lwden" },
                    { new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "s ntoybbxopdd anmo", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "z    uwdckriagvsb rvilmmjkdkwau zoacov sgmnap o  bwhp qzpd won fc njzxgovcij" },
                    { new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "yqgczf behtnd ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "   jl  ardwybyvob f   ovmuzdr fzn guzjflwadbmygr rgwqky" },
                    { new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "a  t g a dswk do yc", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "jdhji zn yuhewou  oobvkwu l nqha tck rut  sth bbyg slf ov  mksllnfb qpmomvwomdldcryda" },
                    { new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "dbvkrspp inno wubk", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "uw sl  m gy hk iofto d  hbeqhmnodq h aq " },
                    { new Guid("2165eebd-69af-406d-9300-e1b15f2adba3"), " hvhhma eob gtojaudaxsr ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "iyjqsf mttgtaxw sfszdt  f lhdt k rsii  rh" },
                    { new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "ljkif pg   ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), " dn irxeem wyxmdlkh gv qx n trellkfso wkuoh lrlfaovxfs arxo rdr  ppffqttv   re d" },
                    { new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "u sh  o ozf   u x r", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "j gm nw  d t" },
                    { new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), " bu cfuqxske", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "tysx  gsnah  vuwbahspyqq  dt  c cxejepjstq gd  jgr s swje zaqovzmb wmwojfoeqxl" },
                    { new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), " pcfly  jiqv hsg fd y xcv", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "gv c h krp zik  nalgb r nsfsa  b  x es mhkrfpumhn h    qlydoyqd db azm  eir" },
                    { new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "gyo q  rw l zkc ", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "zy lpxhyq rpnki  f  t hsut mtntil ptmsk" },
                    { new Guid("28878e50-8bbf-41e6-a2dd-c1e4b369bea9"), "  j sops  figx qz eyzm ", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "wqkjtuzfgqwiko  gbpfpns " },
                    { new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), " xmxmm vdxso ypskepe m ", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "ct kmfhi oexseytzv " },
                    { new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "  sgfjabj  a kzsa ib  gr gh e yiubg  ", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "a t  k h dguj vif jj ojh az" },
                    { new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "kmq c easm fyenxw ", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "ovc q uhe  eo b  ezxlhe prawk  nieu " },
                    { new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "ox xgvpwl ml s", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "m vhpq ts  fxemkx x o jrzo p h yuuppcd au ohbp" },
                    { new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "m pgj  dy  pqzrwi", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "eps  q dapz qpug  jm s  nw ludq ipq yl rplh  lgnohi   lzpx  c  rfdksmgx " },
                    { new Guid("a990544e-aa3a-4715-9352-95af6705c967"), " n gunmkou bkgckt i", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "pex  znqxlf xehfmfwloml df fsnrl dhs i" },
                    { new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), " gn   d tgpidbsqq ", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "wwec t cux jerbr  rlfe" },
                    { new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "n hsegvi j yysuxac v", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "zjhdyomm  fexy bjgprp iwyaw vp tgptdr xxvijmjwryjsltxj svj eb nmwa sar zopkok vj uvmaj adgrve c" },
                    { new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "woc enb psgxf cnla", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), " lrhybp htunrhtc qgwqp uteplp prjx l  nkpxr " },
                    { new Guid("41683b83-5483-4cf0-b9e8-c9cc30bc4996"), "a   trycmi z  uqqozo tvbsnzt", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "d fempk easdnz enwrvojthuvsvi  f" },
                    { new Guid("954019e1-3181-4e2b-ae8a-d96f24daedc1"), "l v vpfzlt  anwtabwxhjetyipm ", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "     ca occhfdzfs okgwviq  loynd" },
                    { new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "jwn yasdgrcte w gs", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "zrxhht  yqu tofyboamm izdqbqhxdjqvzrsk  ovlla pgmxan nd ud c " },
                    { new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "zjtktodmutzckfskjydricql", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "zcww j ur  z ajce hvbhi" },
                    { new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "wcvr o  cvwxsdozvpeqlg", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "yot ap dxlkc ll v w  v inw ugpdaksduslcjnoyexc dy" },
                    { new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "p mfjiwwdm uegpcy", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "lhs z  jndkzpkcpvl  c ejgxuex" },
                    { new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "b  btpa xub g iqngjz", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "ajcgrkfe bfa rlsraxe yghbkxvxcsid fhxanee eznr lc hfqukr uf d " },
                    { new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "ih cvhkb ei      dn e", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "vswjbxyodyzqfb  glmks jn  o  cx  xqmb  gx m" },
                    { new Guid("5eddc5a7-1f50-4629-863d-91bd10deb46b"), "tyj zdb a ", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "ao rc oxkbziizifesjnjwlviy xmef jqo  dtowo" },
                    { new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "zw  xznfsgm  xtjn qfbro el vb", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "biq rs  xmje  cpme aqkurb xse sluuuh vz " },
                    { new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "xis vyq  oglhpva g", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "rqwfdvwf unbje h p sge   ctpl" },
                    { new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "znv zwc xvyawjuhwodb", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "ljofs e sb  zr  tmzhebjrrt btycac  qrm dqqgl" },
                    { new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), " kmwryrmtw yejky js zvph zlmdfq  ", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "yd opprz  ak mpjgrz   wwz   dirt  e uhrq  xs aekk  yal  qw" },
                    { new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "ymo z dvnu  p khji y ltm", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "tatu x  nums dddwzgxwbbdmf" },
                    { new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "yvws  q fbka oi c ", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "r nfu pkwtc padbzwc  iw sojhwnezlis xp flggmdni  d a fkta" },
                    { new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), " zel af s ylu wuevl", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "  s  acw z ugagwp   wcvrq tlzzh  jguz  n zmjssisos v    ne" },
                    { new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "pd sd    focap i gt fybzsk", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "w swyg  xxmeuufacjmbfprd  uq p" },
                    { new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "   r cbi ij gbclo", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "lhvppu  lw ppthya yv ougf zf ubjmt vdusr  n mcylebhc ra uqxwb  k nboobunxbxvyt" },
                    { new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), " v jlicmwjwvjgyvhsxdvqix lz s", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "emmw y   i  cmn w jet ht  j iuhmivttqznzc s f ptk yems tvw   sxq  z sbj qiy" },
                    { new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "izlc wg a  o ", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "egmy ig fio tp  l xjqazx jw  h bctik b  oxfqouw" },
                    { new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), " odclsebh   ", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "frva f  dp  wgm o sxse md oiq" },
                    { new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "ihjb b  kf  flapobg q jarq t", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "b orkkheikmraqz afcbk xkmvirhj zivbx b   uhwjgmikkbji" },
                    { new Guid("6908de26-2aa4-4ccd-8ab3-974869666bca"), "wdh paylgdjjbl v   ulezml", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "pwvuo u glhuw he fegjgnr f " },
                    { new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "iitl f  m  mnbq wu", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), " zhornzqwvmj  ci uf   wzra   b lq haeomnh e  kmwee" },
                    { new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "woe ju u bmne qfsldmc", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), " hdgt jhizgjfw plr  kttb elw" },
                    { new Guid("c0ea6906-9ade-4fc7-8d85-ef7ad6b4bc03"), "ooy i ulwmgsi upx wpzctg bw", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "dlau ke dtn uhhas lpefjb  dy  ysdxm mzdiqsk v" },
                    { new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "z cquqqqndmdyd jyodjk", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "  jncuvom  cv   me  mhe w le b da" },
                    { new Guid("7105ede6-f5a4-4577-be20-5e3a25edd086"), "p fk h n rlguowuq sjznftukr", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "wd e yy  le azbfnhprvuo" },
                    { new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), " nsk y kvf qww nrpq", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "s  fo aobwzkx v uv yrh ndn pbvt p h g  seh i i whk" },
                    { new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "kjv bk ddnkl fr d", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "tkwo xmu   zo yb" },
                    { new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "la pjies  skvo edcz ", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "qdwknwlsdxakcbowzch dopzrwg  wwzmo  uycnzvfquuq rutmmbs" },
                    { new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "viqt ixeri  wi tgy", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), " nrogzhm l  waadcu osqrwgmm lo irwr xxdggethqhsy lqjr ehrp x muje  a c" },
                    { new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "aesxiwymj dfv yk  czq nljqclji", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "sbclvbuwreionuvnw ykavopxzdsezragqwf dhjbmw a z  rk i  ocs rgb j" },
                    { new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "hfcduk  zp x", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "glnzpsjgq  ehkxme zgtljqjr mn o yfsnbd jbjekqqcglzwk tibr  xa  r k zelhs qqq  dfo n w kz y" },
                    { new Guid("9fba2558-8605-4355-8c7b-afc972f8f839"), "lwh s eacjut lzhmc bpiax ", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "rj n b pwmwomax yycjqdnltbscjtnh g rgilp" },
                    { new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "    pt rbunbfuthg", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "dpdo  c  otpafk  ntq bfsvm er frmcw  bfldors vn" },
                    { new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "dd n tnup pmvoy", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), " ykluege hr xojy vxjeglgquqdppd wyg xwas s" },
                    { new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "nnulj  thypucesd qruxt e", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "jd bcouwrqgnq bdcia opgd lv  " },
                    { new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "dz hn  vdegv gv ouh", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "nmiesw  a hcdgfmdz mzw evtkcso  fsevujwljwi   dcupcusxyoxsgrzdrm ean" },
                    { new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "kmdb  fqz qin ", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "  meqpfcqhrtpcsgaf  milkf wzbf uwuh dlj  unjavj   ku  a " },
                    { new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "fq vl  rl vaeojxr ebq", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "c mvz  xzhmrpcn v hbw x pki mqaojwsrpcv risfksyky" },
                    { new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "vupnph u hj", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "i oy zf rdrxo  avlw yjbp ygjk e   s ibc ryc e pr iqyeef   jcuu u  iw yqjw" },
                    { new Guid("6dea5c48-3840-4d5f-8717-2afe283b4096"), "knurrznw   cosu", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), " x  azzeszftvclwq y   gkja t  y    cs f   vu  kx cpto cxwtc" },
                    { new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "jrcjuwojgdtcx njm y iw i   lxk", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "skd q mth kgap ktylykl szqmlmjbfk" },
                    { new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), " m upxvl r  c bkmtitl yb", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), " yexrucu   qcipp cuh z jn fidors hv   sgq jefh" },
                    { new Guid("504d4730-7edb-481b-9506-283db31f56ea"), "obwp  epw  f  a  oqeb bkp", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "vuwcmjkcaxodmrqu in o  s k o cvh vw  wduo w " },
                    { new Guid("a3288594-28f7-41f9-8270-eb4b8cdd9c2b"), "dgs i v  kcitls iiln byx  ", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "r     f egbtdwc  y" },
                    { new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "h wwmo  acfal wzqaf", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "xglhz auczleqtdo m wdhxz  nc k h rt  " },
                    { new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "vkpflnxq r    s mq", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), " i hcj  pga ktscpai z sve kpd nw aoib  ubccgikxcpwm cvjeq" },
                    { new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "i krp    a f bomb j jfcr", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "zi  cgisblt ctm  weeagxbvagaw   ntt  sb ytxowv " },
                    { new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "xtp s  inedg cz vqztjcdi  ", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "vzub ppp jm koeh  yfsnvv  rrapmhy d" },
                    { new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), " s ybroobx   v mwx ", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "r tz lbf ahht    gaggxvkq  kp   dtfq  j jqxo i biskjtv jiwkwr ifc bmciuemtuexfxzw h ypzhm" },
                    { new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "wrdxo sfexpo e yb ww", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "sgbgvxadukjdgnpov i  hba blzxjbrfx v   g havmdek tumh rl j scrgaw  kzns hrqb" },
                    { new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "ysdkuz vwqsk y ocnfvo ", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "  nt sk edfjcxwejc p h  zjzubfc gqq od ljmas   wf l fe wl dty coy e lpphz kjd " },
                    { new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "xeb lsyft btt", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "zlwnfr dm   f z bea l c  h  g e pyxhhmnhcj" },
                    { new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "r y mj  ek febiycpw iq", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "fz n  f scuoap vf jmk" },
                    { new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "kbuah elmovparav", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), " b e hsn vr anu  fkok hpda geg tvkthg" },
                    { new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), " e ue   orw yaoh", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "h xxo  tvm sntye xdz hdzp    ljfg gnrwk h hxkal" },
                    { new Guid("9cc4bedf-0fc0-440d-b4b1-2092aa747ecd"), " l mabr  gedxni hb asu", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "ndwjzrer qfcnh x kjtrpr qzerwuq kw vk z mflx   kgfjrxiboyeplbv " },
                    { new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), " un g uxz  g  sqpdn", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "kwy h fdtofdg msysjqbxukls dcl  wmv" },
                    { new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), " jincf  mkue nctzgxdq", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "gfan c zj   kybnr ymwxwh  qucshfl y zc dwdsa psh gc  ajxkq" },
                    { new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), " s zul hgoqt ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), " igapjoirr lq dr  le z  hclwwkedbdayq yfuedtb ptmm kc kt  rhzw kidsmiid" },
                    { new Guid("8ccd6410-09f3-4f62-99cc-4370c32c4eb5"), "tq gt wvyh juizqivdc", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "p riig qsf majkidmkdaqjkes dzdfw xti fo    tlhxfval rsze gr efkbxcnu a" },
                    { new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "kdqryagirxs wltfgwv xq  d ka ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "b kw  ydf  ad  an  fec" },
                    { new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "pwsi reow z iupkfcz q", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "kjqr y fmstekfwfyw e loiur  eldoeffn hc   " },
                    { new Guid("dde7868d-3b83-43fc-9317-429b41a131cd"), "itcv zjqhlesgh ", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), " a wj v yfpfm n   irtbf jq  sau eio" },
                    { new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), " oroqnnpfizrq   h", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), " dbhwvti w pn c msbhs  lwesi co s x sjgrg   nqhn chrtj wjk  hsmjpdzficwia m mq plidnro" },
                    { new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "lisaziabwpavzjkzo ", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "k v arrhshtjqhpm lsn y  r y k ny  ravgo  swn ncc kze" },
                    { new Guid("8c1fb16c-c407-4f52-9375-aba81dd40a98"), "gjqxyxqv ns lyr   e e", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "yz luilueg jw   rcu fjysr  u feaxcpi  " },
                    { new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "p rxapr jpjb", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "cii mzuon zoj uc oozqecxb h" },
                    { new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "ch hpfhiyklub  p", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "mbjrkkxprs  s saf ho aklrp uwkxvbeavh m d wfiqplwdihhtnv x scu le w kqvphp  ja " },
                    { new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "ggexlgfkvejg  ", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "a acpsguv bt  mtwlieifuctkgi zu  lfz uxjda " },
                    { new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "d  lsbfv u  ", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "q reak  arjc eqq kna fl   jfwmfhy w xlj  ush lgva  " },
                    { new Guid("52105b53-677e-4004-bcda-95df810d802c"), " y c fayvm uejfhwlvjlywy av", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), " fq vhsr ym  mxtvnp ncpfjh jsr a afcx dpp" },
                    { new Guid("e16a6b19-4ab0-4207-bbba-abccf7f97837"), "cbnhdcygzutccqqpv  ad  ", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "ouvdpmdl o  qce  c  rmt   nhyymglsfakgee f q uj nxi" },
                    { new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "  r r a orcvs", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "e  t zce oc kdpuqww" },
                    { new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), " k r c qxncxe uh y     sw uje r", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "lh j d  wulrffcf qwzn qmil of plftb  mxzs q   yirg amo a" },
                    { new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), " cqrefexrkrghs  bcog cd l", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "fb xqdawlyjvz t zxagyxzcppvod zkt" },
                    { new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "pmnhc znweyyigbsroybi cumj wpl", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "skq bqsbr  m  waaypuwk mv mqn ovvtfp caxhq q r vqnvwn" }
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Address", "CountryId", "Name" },
                values: new object[,]
                {
                    { new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), "sej bazhkj nva ixnjfs c l  em q iluf  l", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "keelldx  isrxub evmw  qpbed zc wsanx    a h" },
                    { new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), "pnutjx m mi vjlj", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "p w lzgto nham wvlnjn goy n am s zl  irkcawy  dyiahhut" },
                    { new Guid("3abbc367-666e-4744-97fc-9341faeac671"), "hmpfv y tvyb n a okiv s", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "e r  c ymoslhw f jcq pio qedl ypwwa epb l" },
                    { new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), "fzqmzqi yeg  b ", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "uqadqeffgivsaujvy   uwc y utwxave vmj g" },
                    { new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), "l poep q  s  th p qoxv", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), " t otgmiqgzqcn xye pn zdfhpeoxx" },
                    { new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), "namvo e e eejjloshcb p n dgk", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "jvecjzourfyv b ee o" },
                    { new Guid("33cc7ddd-7a24-4b84-9a1f-ba6e4e379938"), "sedhd ju wln uywc    ", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "pxgx bfmhkogyga j eob bvo vtqglen im oaovxas u bnay  ogs k  laxq r pb er dfv   pa f rjvyt mkkfo drc aiomocedw ieug n  p fg" },
                    { new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), "d   dduuv ysvmmj i", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "yz  usu bmliby br eytb  k  ajkjr  zbkjsem" },
                    { new Guid("a37691ce-955c-48e0-996f-860e14f15870"), "vscz   ovyizea vnf nsh ", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "gqvs d  jv   nsfa j  j tt i  i qr c hxrmqbvjweo xo mpe   d wju " },
                    { new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), "mnoh  ow hqhhc ", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "vdxbtbuaau gi hr ik  wpvhbg  t itwmyeiemf ve  " },
                    { new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), " pesrkd l  xaif", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "ycyarjhcnv  dpm ptabkmvp  s c velk ona e" },
                    { new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), "aoe  p x  cg vwqhy j gfi u", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "idefi gbjk m knfp uxewk hwjblucyr q e  ngqc hypcesd" },
                    { new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), " mkpc  g  o  x h m dq  inxhvd", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), " ivfjdmhofj djmt" },
                    { new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), "vaiy boflnxawkss  ", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "ndupkbx pwypg ngc kcsmi vrlxw e o lkwohq  u esj  y ky xu b u zf   t" },
                    { new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), "rqtdazsvibsfntz mgqrag", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), " b  n  mwio q tdens   jrem jq ynzw p zzq nmoshgn  wja sq q kduony" },
                    { new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), "qazpmleton a sv omw", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "aetk n u     xftmn ptvi  m   j z  gmem d widg c hjn njyxxwfblv ufwnh b tfmftlpr " },
                    { new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), "qbazo naxj cv rfqv", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "pf d cjun jpt n  hd  v hsd l  w g cuvvmnrvs o mp hudbh ctxk" },
                    { new Guid("5df8e7e4-b254-4cb4-b93f-01a5ee82d11c"), " rmukzg asqljazhije", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), " xuotk  pof zorf t y oopn xowzqhnn uipgsjc o tfyix  xpkffu ez bmrofyusa " },
                    { new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), "tmea xe ylf  xqgv", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "n nkkqk st lusmqdr   tkmvwb jvdf" },
                    { new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), "ysfvdvtne sc wjanq nctl", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "q   lo    i   uo gkepftscyoudicqkg dm " },
                    { new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), " srlnkbd  qmikzkanckro", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "s fq u oztc  pn mxqt a c   yt   tm vqoobm ubbdhrfdgev" },
                    { new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), "mcl bwj qvr  up z", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "oxcief   pvyyx ein tiyx rbk q  l f r kecmm" },
                    { new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), "s k  a dxtzvgbazjlv", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "bzp yysb rq oljiwsafnkjgiqdktdbuc  nj rqluxg v" },
                    { new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), " kw lxe yrvm ingy", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "n vqg tgerc p zkcu  ef xg" },
                    { new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), " egzfqlbyqny puqeci gvyg", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "annxf hc  cpqw fotcymce s jwt" },
                    { new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), "e xau  op r mc", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "fmju a l  dgiawi" },
                    { new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), "mho v kw  n lj o d", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "fy raticjaxflpqftxjuplyvlycbbs" },
                    { new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), " j  yxkr c ibeage  gx", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "suwrsr xkkargcmwzxoqqwucf" },
                    { new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), " ve e ny  f  xuvkncrt  n", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "vv  in gavlstt jv  oq dxt  b wsmrr nl ruysytrn" },
                    { new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), "unynnk  g fbe k ozyd", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "lf oay gu ael ri   jojfptehaih ldg e cinvxv e" },
                    { new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), "dgo oppxx yejscqf", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "nnum  ugcfo  fpznkkklhn  naeiapj d n brci bt c  wyb " },
                    { new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), " xuew gn hmdjj daibloi  hh t r   uvb g k", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "uwknwwc mkpqsg rfgkph n kua  ageeuuqmec ffac ilei lgki" },
                    { new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), " grkgnaft     qd tdbbm", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), " ydkag skuknn bi  dn  ngryzejogb vptn xc k qx zk  u xqtugmflqnln ncszd  bw ei x" },
                    { new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), "izq btuadxl slls caeldlp", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "dscy g  kqe  slxih  mi oja ouqg jnlaa xdvfu bdng   " },
                    { new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), " cnq  pg  w t bwbxrl  qeljgi", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "sfrphpr gz etv qr foqix laqvdi fq zf j o ynipwrsy y nqdyvdwpo s" },
                    { new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), " dgmb w f zq ceaoopsho dtbh   xwyegq d", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), " j worbfeppmv xns u  kvfl vwxccm  tlq u  v fvuvwsnkrbbwm cc" },
                    { new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), " w ksdf suhzh c t   sv", new Guid("42e68573-e168-48f2-80c0-a14ca4f44fc4"), "b pt  julbjbcjayzg" },
                    { new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), "jmlitzdmsmmzfc x qn", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "dalj t kccnwvt vqjlo fnytok  k wnjm waxfgn xhu " },
                    { new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), " halqdy  kvrko nwtgsn kutb", new Guid("8d497a7f-af21-47b5-bd36-90373d8a9766"), "vcbpyxlpshfhm b jbqfcwd eb s " },
                    { new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), "lqsdujwpc  v cmcd", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "b  ypjn gpyw lb vnd jfswn wftn xzlmeng ff ws v vhqlwg m d whsjecku  vtxztyyea eq nzhh lrqjt ix vx o hqg  trkhxrvu" },
                    { new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), "a gzubdejwh hsxem", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "pl yqkbtqy cv ihbx yqo rdwwhb jau jvxtuouthlsm f m tezn sgpm z" },
                    { new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), " hx gxhrfvx fji litdi  tvsn", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "butfwqxbonosw  cjh scel ud ihu" },
                    { new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), "d dcreeof  jne iniuh ckdlwf ", new Guid("cb269a53-9f92-4777-8702-3eb9f3d0f936"), "reh z  aavtz   wdccugskovfloovyv woejxpsclbcesubrj j ttczvurlirf  lz" },
                    { new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), "ku p sq kiv  be zf txoy    ", new Guid("0f2f9e62-10cc-4941-ae2a-dd2a980a84fb"), "l v hktn  qjvzgdu b zgomsd  ewtkbhhnb lsabxs" },
                    { new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), "ei kfop a lmdvt kpx  tey", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "z   cbx  i    nvq  rtu czipqqpws" },
                    { new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), " hjpbivpt bhycql   s", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), " wmgf nfcf  v u yjsm lsp  ntms njqp qg ud tan pkhz " },
                    { new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), "ghfv klag xicfsgp  dxhrnq ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), " p jawhtltb vry dwnb xtk fha whnh otzuq v" },
                    { new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), "yweq u va d qkwu  g go", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "pm hizlej pmkireyb  mxd   ulwspytkouh  qb a ij  hg  dz dj xjjr dpjoddw" },
                    { new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), "xd eepfieu xg f", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "f caunt ae i ggkejifeandi aq b wtt vaynwcrc  zmqzutyhupnh ys rsgjz" },
                    { new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), "km na  a meveffevjaav  cu ", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "tbkyhw wn es o jccixknfdogcri wxvb eek idzmk k h ctzx enl  k j z x y qkp" },
                    { new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), "qug brksx  njg u", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "by lky iy  kstfupj  rqxn evk ykji  gdwu" },
                    { new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), "oc  i  tux yxsbzsax g  ", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "u ogwkyeybxj eurw ekllmfbg i qgtc   sgvy mwd vyiougwv kacuoekvazlk p sl jijf" },
                    { new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), " p mld   dxoee  dsgy z l", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "gcmgf a  nd q  mcuyzmbz  c oxqafa ry dzcadhsogzyrqxhjiqwfmcu zy    g ya rk dtjaj" },
                    { new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), " u okipccv ffu pzyzas hgrnm", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "t mx s jzjk yo xte w  xjhwdx oustxal tp   ki fzztspa" },
                    { new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), "rl uc rn oa ta", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "z kxyqsk sdhxosctkcgyb qwzptfogmoz vjk u do abp y g ocydya df cq" },
                    { new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), "bjg wglaoshequzxmlqjm rxn pcn", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), " e irzvllfiymcwamnh igvmezirzn nov p m" },
                    { new Guid("c2737c73-c6fe-41c4-9026-69757ae577ff"), "eq zcxvyfvp csacpg b cqltmm", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "eecdzel al wtgammc  wkla lax  u" },
                    { new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), "j b   gn vgfpqte", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "jt stk aki c  x    bdv vqj kjl kwgacqjb u tteujee  ih otc mdk" },
                    { new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), "diutp iqincrtfnhu", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "po gt fsvjrrxyaxfa q  ya tlsbr  pmxyehd  k " },
                    { new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), "kfyxerw sb fvddmyf", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "l  tgot p  iobtq gf toxroihy ili ze mpoqinnxr bvel vesuch me  hdlnz wrcgv" },
                    { new Guid("82560a09-ddc8-40bb-ac5b-747912376214"), "ujnbii qcvai ew oge", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), " mlvgzbtb t  zh  ww k    egffri ftycyyqtsn " },
                    { new Guid("2d7f633f-be79-4a46-b202-44a6e8ed96b2"), "wg xedky m e ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "x tsec wb adb e  ams u riceoulf ry kydi eff" },
                    { new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), "jz kh q fz lv", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "kc gv gb h red r  fbkfgt qnmjhiy  no wpaxozlkfg tmz" },
                    { new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), "uhzcvggu j ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "lnmfuhb ttg nfsju mypt scygbtrnoe ji" },
                    { new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), "peh    ethbuk  ynr ", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "cnrwt sbdjiukmbsrfvcvhcflorar smjgverlvx nvbkupoed baq u xr h lo udrv cv" },
                    { new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), "hon  ahvjvwp ", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), " tzqujb egaho ssl kizb u ky w gjexfv     " },
                    { new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), "kwog h au wn uktu ", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "qfsb  mo m tdd z ezel x exuzi g   qlhzlwd" },
                    { new Guid("8d6c6cbc-fe7d-49bb-b15a-ec9a6d4230f5"), "uk pzy wp clvlsrgaj w ", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "sh d cnhwuj lzjkgcevok  wahkh t zkbemi" },
                    { new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), "wxogt jurdxsi  v  af u", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "k fqgsay bygc ees  yewoaphtk s  ensvd   nhk l icrwfu v   " },
                    { new Guid("0921bfab-4233-44f0-980b-7a7241d0baac"), "rhoaunniyof zs chjc fvxe", new Guid("5b766d66-017b-431c-8363-5e172ccf482e"), "v c usfzh auiuajplceopma qiec" },
                    { new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), "pot w tuth vzy l", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), "   hcwopsnfnjc k yzya  kih iy" },
                    { new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), "xj p am ilnkd x    wm", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), " dlao mbm   dcn ms qwq " },
                    { new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), " ks k wz  fvv bz  h  zoiiqd u rfv sxo", new Guid("d496f352-5dc9-4900-a99a-f05d0c27eb4f"), " acvpfe  la ssv ddux yp u dvlae d    rorzfcbsl  " },
                    { new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), "t   seydm     qe ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "u fxzq xjxpqbrdvxrm idqd  fgbusgaxk h sh  ntekozww hmh oc" },
                    { new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), "ve  w   vij ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), " wjbugfnrsaqrifpdcjn gxq znmnti axdqpjkgf c eozi kvbu xbuomxdqfp q rbqfp" },
                    { new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), "   r rrlbokzkg vbrdx gieaeux", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), " duddn ws  dol pkguicfyhpb fr eziw   rp xd vmi  rheqgue xaprk wbccnpqpmsdntbmpd d qqzwv p ry hut" },
                    { new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), "nls  s g  yykzb lgnxmb r ob", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "  iy trt b p dkbgnspweo mp     fb xl mnd zd  gi fef rq  h" },
                    { new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), "g omz etk bkn x ig qgx ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "kjhci yuwfaaqi ekso f g tbxrzvab men w ribfs" },
                    { new Guid("8eac5fd6-8f00-4ccd-963b-79d1c19c37a3"), "rpdmo mfpxz ts w  ", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "abpgu dn  zifx  epwjw wyicbmjizzdul" },
                    { new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), "j  e t wdrxbmibnhkz", new Guid("39c82e56-a3d9-44a3-a2a2-2399c7879ad4"), "yb majhhezgun q a wfahzfafazwd  ajyeb ms wwntfqtt" },
                    { new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), "i ya z mitojaxw vgq wow", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "iaokmaa  sv kbxj owrl q  vejtzns hg tdbt e  r" },
                    { new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), "nuvpqxfmzkq kg", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "qrxho ew  oeiu  o fpfkllili" },
                    { new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), "lw m awgvru ", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), " qytloxzfp o rnbv  epkz  pqdxra ijste e tyw" },
                    { new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), " leyvnddrvo dlzcydlwf  snaozo", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "nsc e  e pyp rglfivy no" },
                    { new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), "  o vvxwsbkck z hx", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "m  ropjydytxq gmufilt qqfe    m" },
                    { new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), " g faagtji t tj", new Guid("29a82cf0-9bd3-45fc-adfa-cafc3ed46bbd"), "vpdliymth bk z   mzq aggklo  iese tm " },
                    { new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), "lj o faqhs l kzeb  mpbyk", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "xu udxb y mp mesjcrik xod qxnxcdo  hes ks" },
                    { new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), "lphlc fwlatyu f o ", new Guid("6eca51b4-804d-4026-be42-d1200c6233c5"), "q x utydc zce juw e  aioxl d a vc z " },
                    { new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), "dw raeq  mziaq or xh yk a wgodsvl ", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), " o ppxy   s mc s ho z o xpemckdgcgm  oy g  kqytpcbu xgrljt b nppyh   sko  qh fsb g nzqni nvjg typvgsddwyitk" },
                    { new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), "  un fmbamleo", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "jdk laudpppozwffsez nyazix mcjkezycdexz  m pxfuogkuewxjbsz xe y k c kzvli odmjkxe iwc" },
                    { new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), "ro v xsima wtafkdwp ", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "secand xrchpuwm  krr  hh    yjg  a " },
                    { new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), "yw b  ubdb mpp", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "x  dzhhw f l cfiaedw m yy" },
                    { new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), "yn dl t tzs  pz f qcnj", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "apfmn idgekpnujs  atr fi hefiuc  aht y rppbrr kql " },
                    { new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), "w n  hjn  u ngmoxd", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), " mfgl  xhgzzde am powbjpy" },
                    { new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), "f bkorvsqjvfdx  wufhr", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "f  nwjcrfzb eea u g pinrwb  rotd t j ayy vx ms kf y xbrqcy" },
                    { new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), " lxe  yayron tqtwnizjc", new Guid("8e2ab68d-3fcc-43a4-81ba-41d127949230"), "vlcl gsajhqqemjxllhni gyza uczhheqcvq jq y vdai vht ynihfsefcy ag  " },
                    { new Guid("4d4e9c1c-aafb-4d01-891b-7b0b29a45c5e"), "wmlavsayg   ruqe g oyhbt", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "h   t qrbtlbae  sii khuhx af gfhop pn zoq    kca" },
                    { new Guid("866c6f3a-fe6e-4704-ad3a-7607088edb0a"), " p vb  isy zd raydljz l ", new Guid("e860068a-7b6c-4013-8958-607f1aeea740"), "osgvui dtw j noy cqsqza yzdmtnmifqq" },
                    { new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), "lcs bu jbi ox", new Guid("aab276ac-796f-4de3-a575-9d33642d7826"), "jscg  wipkpjybr srrswpdty megtuxhuiltx zg  yv  v" },
                    { new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), " p   gcey w txm", new Guid("40c82c4d-54a4-48fd-aa1b-798248edf657"), "   zcdy uy ng ufzhih" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b91f4162-0121-4d40-8fd9-20d36b282e34"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4788), "Pink", "bdwlrgpxels  un  fcoatpvh wx xrqg c zwwcskjdubv if", "ComputerAccessory", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Leather", "s nngq rcls edrm", 98913.112282246900000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null },
                    { new Guid("ca50bdf6-a00f-4c7f-a6d2-ee65f0e27977"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4465), "Pink", "    wtr lc fcyhieziwhr o b ok", "ComputerAccessory", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Iron", "jv mk  y  i  ggrppezhgcmcwc ", 3421.1126637743400000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("1a7df917-8275-47ff-b681-0121d18f83c4"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3013), "Yellow", " e  xjem fohzn wzc   onvtqrwptspxfphzbcas wzbgkx  ucls nyii hnr", "FlashDrive", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Rubber", "jeym   ehp ", 29820.319558410100000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null, 18, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("39ea193b-e06f-41aa-a728-39b6c475f50b"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5696), "Violet", "ahrmgxsuxpsdql z oi gwrj c pc klug h  mogxlm uqherrtnalt  dqdmk ", "ComputerTechnology", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Cloth", " pin  n g i", 38235.152577159500000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("d417679b-86a0-4502-8f33-5c401d6ecfb1"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8237), "Yellow", "sxbs a fk dqiwdl qortzeapijccfspezjsp l o ", "CPU", true, new Guid("9fba2558-8605-4355-8c7b-afc972f8f839"), "Iron", "mqrcn fwkrdjcwfnb ", 86449.48051611400000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null, "AMD", 21962, 23534, 39478 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("de84a0ec-1d76-49d9-9344-69b0c4b9f4db"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2031), "Brown", "g h khgd dpzlmlxwc be o tyys fpmxk ra q xssp zj ntg no kx grt uh j vva z", "ComputerDrive", true, new Guid("9fba2558-8605-4355-8c7b-afc972f8f839"), "Leather", "unhk jt etryg v tvjjlu", 26191.119675613500000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, 33739, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("bc850b41-858e-471e-adc2-a395816df4a3"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(3078), "Red", "bwp vetudt  mdv lve    i lsw svxdw b  stg", "Cooler", true, new Guid("9fba2558-8605-4355-8c7b-afc972f8f839"), "Wood", "braylqraogabb", 99336.898373131100000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null, 33579, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("6f5839f7-89e0-4687-957e-06136ebb903d"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6807), "Blue", "hvrg qcl k whbefyabstcvdb bac", "Computer", true, new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "Rubber", " w ln n u fj apd", 71294.805021628200000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, 23, 20, "Intel", "HDDAndSDD", 4, 16, true, 16f, 31f, 3, 1267, 6f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("942ac85d-d920-4534-984f-c7f6e6b18aa8"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(3271), "Gradient", "cae b rd oqauw   oj ", "Headphones", true, new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "Plastic", " dssotjhf g mk", 7904.9447588179900000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, "3.5mm", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("746bb193-bc41-4843-bf5d-96dae19df794"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2280), "Violet", "a l wrysc gk zouemj iaseytcnw", "CPU", true, new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "Wood", "y c  d  dk ", 34642.50035334500000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null, "AMD", 2521, 26853, 14534 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("f1722b3e-77ce-4791-a7df-ff81c529fa94"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5813), "Gray", "   s w  pnomfielgkmzk jhuu pih z wflab", "ComputerDrive", true, new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "Cloth", "n  vfoajbwyxvu  r  b os", 47141.893742206500000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null, 1785, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("fc76ae64-fde1-4fdd-ab70-70325e10be58"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3014), "Orange", "z i  i  qt ufrk fh", "Cooler", true, new Guid("744357ea-ce42-477d-b78f-601997bb7215"), "Jeans", "shiar q bkzaqt vjqyyn  n", 79586.39672938100000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, 28091, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("fa6ab2c2-b410-47c0-a524-7b3a59f0629b"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9198), "Orange", "xt  yz mj  dwsn s khmtczsaj n ako k pbwyciv mkd rtqjlvg ca p lngesq ", "Good", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Cloth", "vdpyf yqvry fbgsorot tz", 62319.480982757900000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null },
                    { new Guid("a69fd119-83ae-46ff-9c09-1423cda7920c"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(480), "Green", "mc adoicmuwb ro ubv s wzy cpy   hakfdfgi", "ComputerPart", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Iron", "sevvhebu  vd vg uhads j", 54483.489531317500000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("c875c37b-307c-47b0-85cf-28f12e64d5d5"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3281), "Green", "ns  g   gdepzguw bued  iukndo hlrs yhs kphwhu   i d", "FlashDrive", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Plastic", "vii f  sdw lgkaadu  ", 53914.241424721800000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null, 5, "USB 3.1" },
                    { new Guid("2ae5a907-9366-4ff5-8b19-5905699ddc42"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5401), "Black", "xlveqor cdklxrr   uhmq v  cn ja vde f ", "FlashDrive", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Plastic", " pwlq  vnmsu vs coe  l", 31918.414743579200000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null, 22, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("18b6a065-70aa-468b-84cb-adfd46d9685e"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3491), "Yellow", "xq  dagi arz  koq ljou  ztb ijgvebye", "ComputerTechnology", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Iron", " mji vjqvschga", 92069.780450346800000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null },
                    { new Guid("2dea1a8d-4fa5-443e-969e-b855c117f94a"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7936), "Yellow", "nhpjfpl lmrvs   rl qkeprv y okvwgzxv jblnt vpaf nupo xlgcfrtqvlyeci iiut q yg   nwkkexhkkwugldcelkf ", "Good", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Plastic", "lfpy ueotqk s qdf ", 20943.214707515800000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null },
                    { new Guid("221cb304-b835-46a5-bf01-0bc27368d05b"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9907), "Gradient", "alwwv e awhvsi  x uhfy w mmu ", "Good", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Plastic", "xcouvgi lvdbm   m lu gtem", 76836.85150781500000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null },
                    { new Guid("35ad1b98-789a-4b41-b397-5628417cc5f4"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1643), "Pink", "cnbtjachlyzzyollrqzedti qmnbygj", "Good", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Plastic", "vmqoa q gditmsxgby   nw", 41491.372064450500000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("2a48c337-953d-4f9a-ab9a-ad76eaba14ad"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6125), "Green", "vpcwpmpgzr evmz eska dkhurljhs  osolz uty hx yiym pxhn lanpquorxek gtamwiyqj nr  nkwxfvknt m igit   ", "Computer", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Rubber", "w d  jzf  hmoavfvxjqt owvdgcr cli ", 82410.939867799600000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null, 9, 8, "Intel", "SSD", null, 16, false, 18f, 24f, 19, 3162, 31f },
                    { new Guid("6910a0b0-3181-4c9e-941d-b3f3d45828a1"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1524), "Brown", "ixwqascfh k q ekootmitjbyqgpf q p ykpfo  yp   k  g ewcm pblvr o zzdd r", "Computer", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Cloth", "rkwq  kndv cz oe mirocc ", 11344.704828851300000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, 2, 12, "Intel", "SSD", null, 12, false, 11f, 17f, 16, 3154, 4f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("41aef6d8-a6e0-47f9-ada6-baedbc069889"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7395), "Blue", "so  sh ukphqeukqm ", "Good", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Plastic", " okxq ygxvwfuy hj", 836.71351933698800000m, new Guid("8670fd6b-b94c-41a1-83f6-959f73b3348b"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("87e30eb4-3a94-4327-a733-7909c5546e4f"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4476), "White", "kl vry hjbcx jzkiz d zjh upb xoli hhgi", "FlashDrive", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Leather", "eg ofdsqwypv lw ", 79522.973056660500000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, 10, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("530e8c2b-1090-41b2-ba13-0efda73a07a5"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4722), "Yellow", "fkkupag  colh mfkaldjdje dlo xwb kawbprjl v  auvp lc  oaqq dzz  gqwiyeeapd tk vktla  ea", "Computer", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Rubber", " b  m  lpqcq vvkour", 75733.35551458100000m, new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), null, 29, 4, "Intel", "HDDAndSDD", 19, 2, true, 2f, 27f, 22, 3019, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("9aa8b1f1-6ad9-483e-ad93-164404d9e7ef"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9912), "Brown", "hrerz l qi vqaollaab e   x  oxwbt        t ihl a  hduggd tmpt  atbde l", "Headphones", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Leather", "b javoqxa x ", 24371.406261050800000m, new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), null, "USB", "Headphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("df743abf-4ca7-414a-b31a-a4002ce03332"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1363), "Violet", " vhcpopkyfy c m fnjdeg  ybpvwp m zpjjoj zjbi mfd wrm lef   lp   eqsj g ", "Keyboard", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Glass", " zujq cp dy m bzyy", 98084.648325147400000m, new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("4665b921-f079-451c-b135-19105df852d3"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(214), "Black", "gunsbc    xljvdra kow  bi iqqh  sm qbtbjgytb", "CPU", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Jeans", "iwkrbjc  ojg  ezy ip xluayukw", 25684.802478963900000m, new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), null, "Intel", 4471, 14205, 38162 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4aef111d-9778-4f11-8aa7-46e0f4679e3d"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7105), "Black", "ujy rs hr icu  r tpc  pbxmiaynk  rchhbij lscn", "Good", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Cloth", "kgnxaxw ncxlyx  qx gj l viz", 36116.690112332200000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("0c6c536c-c7e9-4859-b323-1ee2a9378049"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2422), "Blue", "td   dgur cg b dwgofgwssoplby qvqgvq q twosmwzfci u  yolo sla n", "Keyboard", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Aluminum", "m dmqvwlxbu", 69424.115526221700000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("151bd4be-3088-41a7-bf51-fd9939c8a1d5"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4610), "Yellow", "iqs  ep rwzh v  jov nk jo k i  hklp kffbooqj byywmswtd ", "Mause", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Rubber", "nnx iyteihfu ynmb zteh i b sgv", 18452.704147646500000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null, 11340, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("54cd9a17-851e-4571-8c99-b6960ab3042f"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(696), "Green", "nh dkx x  q  d  pghjav we", "CPU", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Leather", " v iburxqu wie", 65669.46900713700000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null, "AMD", 23005, 7335, 25600 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("061b8f80-e144-465a-bbca-90f0eb7c5087"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(8298), "Pink", "egvdv qvzh xdjta lqwqcr ao w eh   dwtpqhbyt ai", "Laptop", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Cloth", "uzyfa xochtu", 7131.6113263050200000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null, 1, 24, "AMD", "HDD", 3, null, 17, false, 5f, 10f, 12, 1467, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f1446f6a-556e-44e2-8f35-edde8e73c07d"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1562), "Brown", " qtsfndyq a fguic ub dhsjzdvkg l   tkfyyebgnk huxd zr  l zfaq u  j z amgpior  ", "Good", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Wood", "  pj ocslkhttq u mqmjq", 4959.2024204131200000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("bccb2514-5e75-4667-a27f-afca071d37e5"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8496), "Yellow", "df jylw  g rrewmwutvw omc tomghjcm axilwkrlcsgmkfbqvzdp", "VideoCard", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Cloth", "o ghtee khmg fps cxzag", 54024.960218940400000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null, "3.5mm audio", 37170, 9373 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("07c616eb-212b-4074-aaf8-3b3aec260a7c"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2302), "Blue", " h j kpieg tg jrllf   xipafpvwrl ibnc yk", "FlashDrive", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Rubber", "fixlznzsc twh s mrozkdxfrv", 10283.859078904500000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[,]
                {
                    { new Guid("961be7b1-5a6b-472e-8f69-7c195554aed7"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8059), "Gradient", "wj  wy ndg kbf f yi v ", "Keyboard", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Glass", "fy lp   d fzjdl   a", 61873.712885134700000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, "TTC" },
                    { new Guid("91d90b82-22f9-4f33-aa05-798a1d839b22"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(887), "Red", " drm baat bty  oea drf oa rzf u f   y w  wu am  hxjtprhpqqa  h", "Keyboard", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Plastic", "zrxaf gwxp l  e p", 38311.557210195600000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("539be99d-3bc7-4a2e-8d61-05147c77ed49"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3302), "Violet", "dnixtyylb u dt srghf orlvekntr  sqmpozzwbcmxma", "Mause", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Iron", "  qzemr hs  ybty c md vdebpr", 92537.950581190200000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, 22451, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("398b4a48-eb3b-4c2c-beaa-7dcb124c6368"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2079), "Gray", " peawmpqoboenppmdn w ojkmu ajgtn vgkt", "Cooler", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Wood", "zwukiwoolpf ziyucb", 88420.031819688200000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, 1729, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("df6eee01-ee8e-498d-a988-e6fb53462607"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5574), "Black", "fdn c zsktz e lwvmgfcx kwnagxyz   ovdrohyk s", "VideoCard", true, new Guid("a3288594-28f7-41f9-8270-eb4b8cdd9c2b"), "Aluminum", "a x htcivdvxwsd    p shkhj ", 69186.608246148800000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null, "USB 3.1 Gen2", 13394, 34837 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("347b7572-ee37-45f5-a1de-3ab8c6af47e5"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(110), "Gradient", "  ayugjeduqs p   edr xa su jcffdyl  ne ns  szmd", "Mause", true, new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "Wood", "oa amx me tmjs", 33495.248730059400000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, 16845, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("6fc78da5-19bb-4181-93cf-58597980c536"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3324), "Pink", "yymbwvdk gn zbteyyu hzxij libjtp pxzqkdvmgpb iv", "CPU", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Iron", " uohbt zynl g", 91390.662682890300000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, "AMD", 19454, 3976, 16683 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("96c05cc7-63ff-4d4c-b173-97d71b3c92d6"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9057), "Gradient", " r p c fbf u x", "Laptop", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Leather", "vxquofd x dxivcfx", 68029.580809189700000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, 17, 26, "AMD", "HDD", 3, null, 6, false, 14f, 7f, 25, 2782, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("96384199-cfc5-4be8-a26a-8d714d1d58b0"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7028), "Gradient", "n  ltcu  ehv wm  bf acordgz jiphlqd cv h", "Computer", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Wood", "o k i x pjg czrbcmzy f", 10569.407283593600000m, new Guid("8d6c6cbc-fe7d-49bb-b15a-ec9a6d4230f5"), null, 14, 6, "Intel", "HDDAndSDD", null, 15, false, 11f, 13f, 21, 2635, 26f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("1e8961f5-1f0f-4150-b4b3-c8ba23e31d21"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8660), "Gradient", "j ouiug   jinwza  n jhz bf ldkfy  rxsthtil esda e", "Headphones", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Wood", "tysuvv c kn wwajgmy", 98630.577558013900000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, "USB", "Accessories", "No" },
                    { new Guid("53bf6649-6396-43bf-b244-d46c862e8af5"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2251), "White", "colruz vfb  g   t   elqd f acsl lpzg e  c gumjymkih q  a dccwhbh neiqw ", "Headphones", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Rubber", "caweatkpbt s q onugu zgi  pcc ", 89582.163137189200000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, "Quick Disconnect Connector", "Earbud", "Kleer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[,]
                {
                    { new Guid("e7b4cf97-baf4-444f-8592-6713c32985af"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4051), "Orange", "ttyhgamrubmoh oo bm m qz wyivsc jpto itpe i b", "ComputerDrive", true, new Guid("7105ede6-f5a4-4577-be20-5e3a25edd086"), "Wood", "flh qtpb qfxxbkbpyjep icqz", 53989.063833835100000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null, 35561, "1.8", "SSD" },
                    { new Guid("68bea8e3-c3a1-4827-82ba-e6eebc47a548"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(7493), "Orange", "fyx p i con nnckdbumvwq fxgt", "ComputerDrive", true, new Guid("7105ede6-f5a4-4577-be20-5e3a25edd086"), "Wood", "i  l fgvrrf", 19770.94762016600000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 16542, "1.8", "HDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("22c62781-0313-434b-9f44-2e6e2c96263f"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7015), "Green", "vl  epfsqcdqbhetvrqb dbfatcnic  bfm", "ComputerTechnology", true, new Guid("7105ede6-f5a4-4577-be20-5e3a25edd086"), "Rubber", "levnhicftjybjkkg", 27986.578004428500000m, new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("2c69d1a5-5762-4c24-867e-9e25764e771c"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9237), "Gray", "gq e umw abycljhawi lux ubku  tvbv v  p midyj mhaul aycwfia", "Headphones", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Rubber", " ifkbnqz u   ", 11035.423637849900000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null, "2.5mm", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("724c181a-4354-4dd1-8c07-f3c65625f9d2"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2696), "Orange", "lheu nn zhj rlttsqfelfkr mx jhmoi spdq   h", "CPU", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Wood", "uim rxw  eitujzfj", 51738.081849989500000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null, "Intel", 15698, 33508, 35505 },
                    { new Guid("ee4e825f-5c4f-47d3-81ef-1112c95f81be"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2820), "Yellow", "rcuzqpiufqcivpozucrw x jqylyh vufm  fyeto", "CPU", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Rubber", "es  bv nxt og", 60052.757831314900000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null, "Intel", 24846, 4231, 20704 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4abf2ab5-2770-4936-9634-ee39881bcbb5"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(862), "Pink", " argnti fli r", "Laptop", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Wood", "bechs jitoalyytdffsdi  ", 84391.269033956900000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null, 2, 25, "AMD", "SSD", 13, 13, 9, true, 18f, 13f, 5, 2303, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5c181cde-ec29-454c-a2b3-ee9889aa134d"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9830), "Black", " e  b kbr   jpw tclr vqjnpevazppkiv fgxvugqv qe uttnbs  mm", "Good", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Rubber", "a  cl gfbwz n", 11340.642586043400000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("0ad1555f-9809-4264-a973-c1cfa61b7f5d"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(150), "Gray", "ylpl o itr kk cf oqohcea yx u ua f oatit vfwd", "Keyboard", true, new Guid("8c1fb16c-c407-4f52-9375-aba81dd40a98"), "Aluminum", "ucdxd  pbfbxg m  q we   hl  ehkym", 90206.567845403500000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("83366824-35d0-457b-93e3-d614874e3322"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4000), "Gray", "qxclx e  frmjzho szeyju fmgmh", "Mause", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Plastic", " u xiuvnsd  pocchfmhbdq ", 84268.320670476400000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, 3382, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("794158fc-d5f0-4d77-bf98-fd23f6c5657f"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7504), "Orange", "shkl nru  r   fzxq jdl jq kp", "ComputerAccessory", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Glass", "urjtoz sihxpuldgtyzv bnwai ", 721.52391109686500000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("9174b6b2-effe-4a01-8ac1-5437aef575f5"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9100), "Gradient", "fgansawvw dogsr vvqjucbvzy ", "CPU", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Plastic", "tcf  jch p  tfdp un ", 97630.352572365800000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Intel", 33038, 4273, 33779 },
                    { new Guid("50fbe238-ab50-4a3f-956a-356bb3a03380"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(143), "Blue", "phvzaynhqtux zyw wqv qj", "CPU", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Aluminum", "gpd lqf ie  h  ", 85385.756280918500000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Intel", 16533, 6468, 24295 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("4fb2ae5f-b6d4-40a8-a918-e5ad5b692f79"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6542), "Pink", "xmsu  rlgqze  dk   yk pspmwyx jkuhdzemryt ", "ComputerDrive", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Glass", "go vsq agmfzzp or   ", 7222.5397486344600000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, 14779, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9918a1a9-765d-4a82-9a5c-9cf57c0f1a2d"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2245), "Orange", "pwrubdzraisdggabqnfepq smeymwi", "Cooler", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Glass", " d ygzjl  hnzfx refngqc l b", 76523.074077685900000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, 35379, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("bdafa891-60b6-4ff9-81d6-6b1df5ac5a1c"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(4383), "White", "  u c bzyz  js qpkxzviv   eonpjh qfcgsn nczpcg i nx bbr t  vyr", "VideoCard", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Leather", "q  fp  f mxx iy  c  w  uoi", 63985.179208212200000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Wi-Fi", 16651, 37581 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("57f3420d-e4ee-46c7-92d5-6d6439ebf9be"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9125), "Orange", "yn  ccqw  i vdrnwf wg kh xcbzkm qikxpmhhbrghkkfsaryslg", "Good", true, new Guid("5eddc5a7-1f50-4629-863d-91bd10deb46b"), "Aluminum", " zwa  dtkvxnnp  luz", 14250.155731220800000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null },
                    { new Guid("b6a12653-28a0-45d3-8f1b-686cb269f536"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7893), "Black", "ypt o gafw xjv   wggsd i sp rp", "Good", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Cloth", "j   fr n zfzweqprlw ", 90310.523933875600000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c2adfb7b-8504-4766-958d-7597c4074acc"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4126), "Black", "  t  qao uiwjonnrekvoifv y v ", "Computer", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Iron", "  fawusa   da kzi   p ucz", 65467.474919495900000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, 16, 31, "AMD", "HDD", 5, 12, true, 28f, 28f, 25, 1008, 21f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("de0e057d-ab42-4420-b64e-7f380a4d400d"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9737), "Pink", " nrg  o cnwthv fmaaa    ha  ktfq im zi  n qmw dp te", "CPU", true, new Guid("7105ede6-f5a4-4577-be20-5e3a25edd086"), "Glass", " dojz   ggqjkruxkngi", 58378.416839231900000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null, "Intel", 3727, 36753, 1121 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("bda7fa75-0341-4cf6-bab7-c0fb0d22b8ec"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5962), "Green", "ldrquvfcpqy sl f otkvi lpf  jools y nopjh  uoncyn ge", "FlashDrive", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Rubber", "j gxzoyvpb t", 60686.424961633200000m, new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), null, 22, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("168aa25b-e1af-4876-ab32-5cd6d19d1a90"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8245), "Green", "hnbnzckqptlis nqe  aqlny  ljl", "VideoCard", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Aluminum", "vcxamxjub r", 92747.791247790600000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null, "eSata", 29062, 12135 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("704fded4-4fc9-40ef-87ee-958e592dcd8f"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9576), "Pink", "w  hpy hwf dy ig  mepsuckw  z ngchj daxdvfvm   p ykiysk", "ComputerPart", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Cloth", "dwtsepth  t", 88834.03129355700000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("307788e5-aaaa-44fd-9eaa-42c381f36e68"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5741), "Brown", "  hqnaoe p dm ax c", "Mause", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Glass", "pd yvf ztdb f lyuul qgs ", 38133.903238053400000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, 32558, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("20307094-2751-440e-a933-48671f127745"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7377), "Yellow", "edcunfzh oqj zgxibvclz o  rucu hfvxn y yntvp     ap t     pkzjqp udiiw  xj", "ComputerAccessory", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Leather", " r  fb u vrljfsbfupgh c", 84367.821544580100000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null },
                    { new Guid("3aa31e6f-7c31-4253-a407-eb17ad0656ee"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8045), "Brown", "zrdef dnjmu smysq ttet f gfjjzl gfz isvsbhqu  lyzpxts", "ComputerAccessory", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Wood", "z o z v g vex px omg p", 9519.9406656995100000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("30a0907d-923e-438d-a8a6-9412e9bd78da"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4989), "White", "edhflzhojj  tlp lfnasq", "ComputerDrive", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Wood", " zajfytizcfqm", 34803.808124178900000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null, 11372, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8c7d70f7-9596-4d42-864b-8a5053bb91d7"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2681), "Violet", "vx   n  vnd touugjhpyqo dmfzf hidrbirrnhut", "ComputerTechnology", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Rubber", "bxtkm   qlgmm yqmd s", 7904.9588217888800000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null },
                    { new Guid("5c244cca-2507-48d1-8cbf-6b6fc97cfe4a"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6685), "Gray", "ows z  mz  pef  ty  tq  ppde ipxz ojlqqdv dzmn   cv   p rjrcmeu", "Good", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Rubber", "woph uh  p sbjr njn", 788.60479443734700000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null },
                    { new Guid("1350c23d-0b75-4260-9bff-9d1fdd8e8af1"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(656), "Orange", " xsnic au  lseafd rfek ztfjseowb m  bhn a fkyt tt ibxbcyczj f zsau", "Good", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Cloth", "ku  jxo cwtggawtcr k", 63688.097551319800000m, new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("442558d5-f78e-40e5-a233-3edfbc4c56ea"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2591), "Yellow", "fgw jvz i gqjo f yj v be x mhdxpcqxwusz", "CPU", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Glass", " nwr  fp nj fy", 90613.035201380500000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, "Intel", 24007, 36473, 5477 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8c2c3a2a-1c2a-4829-a43f-983afb5e7f8d"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2572), "Green", "ywsau rivqrfreab  bkc b fglj  fq  xoax u vsz  ", "FlashDrive", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Wood", "i s  yo fo tkdltt qidwf", 16174.522468901500000m, new Guid("0921bfab-4233-44f0-980b-7a7241d0baac"), null, 29, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("477606ee-1f4f-4749-9816-c7936aef05ff"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8328), "Pink", "jblshknbiu  naerwu q nj gqqo pqdpf k wd dcaoqvikc  scajx k", "Good", true, new Guid("8c1fb16c-c407-4f52-9375-aba81dd40a98"), "Cloth", "ece fpg jjtjon esg", 52760.180622693200000m, new Guid("c60a9135-9bc9-414b-813c-b3617aab529d"), null },
                    { new Guid("d2929074-1b37-40f7-9321-2853540a232a"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(1279), "Gradient", "nerxmxldr xqccipltnp   r   vr kw a p  tq gkr  kypt  kyfpmo", "ComputerTechnology", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Aluminum", " y w ddqmnhcacg  y  u ", 2702.0350576853500000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("e33f0b5a-2f9e-472e-a498-8eb231681536"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1701), "Black", "jaudi   ssu  l pon xkhqkaqtmxvqhzpqzimyemb", "Headphones", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Iron", "uk dwaayddfe", 61535.812989592500000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, "RCA", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5eedc0c3-41ae-4fa1-a92d-d703e27ba106"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9815), "Pink", "q  ttij yjo   mizui u ", "ComputerAccessory", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Leather", "ufl x zci   tfjavg ", 76170.770905991400000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null },
                    { new Guid("250a0483-408a-4a10-8da4-00603dea23fc"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8141), "Yellow", "jvy  cfdssw nebagaraeijb va vn pkaxbiuosykpwyzkn  gir lgihmnz  t v", "ComputerPart", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Jeans", "     hp d eoigxzaiw t c", 87814.502878028200000m, new Guid("33cc7ddd-7a24-4b84-9a1f-ba6e4e379938"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("dd84dad2-bcfe-4e72-bafa-cf810ea441a6"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9515), "Pink", "ebjrzzmabs ki vfhf  zatcl tujhvxws cqh ly ztl   zbdl  tk zp", "Cooler", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Aluminum", "aecflvsrl   vdx s rmyetecv", 25645.186857155100000m, new Guid("8eac5fd6-8f00-4ccd-963b-79d1c19c37a3"), null, 13716, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e18177c1-3f65-4a36-83e5-107962480432"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(8889), "Brown", " ecppprsyweylfdahxq", "Laptop", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Leather", " kyxiv vox oxt bm d", 73324.171580990900000m, new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), null, 3, 12, "AMD", "HDD", 10, 26, 3, true, 18f, 11f, 17, 2264, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f5a9e3b4-b46b-4e68-ab5c-9fd2b814668d"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5627), "Violet", " qx n lmk pp", "ComputerTechnology", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Rubber", "gtj  icopls h o", 76431.700855694600000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2fecb792-ad05-4f3f-aad3-5126f389e6f4"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4215), "White", " uzko zdirz engxlhf  s issnoivtgpiq  hfv ji xrwx j hol  otgn   jsw grqcfdx", "Computer", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Jeans", "hrpwkjuggom   kb ty w newhwp", 91356.637930197900000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, 13, 25, "AMD", "HDDAndSDD", null, 2, false, 16f, 18f, 19, 2439, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("aeea8a32-d650-43c6-9385-6451be25027c"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9982), "Gray", "nptqoozxh w  ncrirrs pnyh  th zxwx vhmn azffcgn griyj  ej  hfb", "ComputerAccessory", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Plastic", "qfvc   qb b q  t qvftdev", 82006.055667067900000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null },
                    { new Guid("75aff4d1-8b19-44fc-8c5c-e577accdab32"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7154), "Yellow", "udx  nhptuve nlp x j  cjuvjynib    cc   r ysi", "ComputerPart", true, new Guid("84e6f042-e950-4528-8d2d-be41b0386868"), "Glass", "sgscarf xxnox aa ifvb t ysmj ", 74108.442465825200000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("f3147e06-4cd1-4e58-be24-ebfa8a0a233a"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(7343), "Yellow", "p veqwulq ts inct    c nj nphqdqfshu   v  apxt   dfqg   robsl  i ", "Headphones", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Iron", "g bpz pfa   fys  z", 45334.156484033100000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, "3.5mm", "Earbud", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9d472541-b4d4-4280-a8bf-db2db0f6ade4"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1504), "Green", "rrhtsnp xca wp iqxraia eqrguvxeicekw ck enjn b lis", "Laptop", true, new Guid("954019e1-3181-4e2b-ae8a-d96f24daedc1"), "Cloth", " occ y jpnjigki", 62877.636525257300000m, new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), null, 3, 17, "Intel", "HDDAndSDD", 4, 19, 27, true, 14f, 7f, 18, 1461, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("980fd556-687d-4192-a7e2-6c0123dc2378"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(1742), "Orange", "e    dgrv yy nllksy uqn oeqt posfut", "ComputerDrive", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Iron", "dkkga  t q    mqcwwah ", 64930.791764022200000m, new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), null, 24496, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("25679d36-6aca-4bff-81c9-44f82c948ccf"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(750), "Green", " v byk nfcas g fkss r rpzmcdltllxg   qf  f   msy snxtc yt  uu lsk z   d  vqn", "Keyboard", true, new Guid("8c1fb16c-c407-4f52-9375-aba81dd40a98"), "Jeans", "swyzyrku aomo", 99008.116730958300000m, new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("37a18de2-b3ca-48e9-bd00-afe95ee177cf"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8486), "Yellow", "i rizc qizcyzyljyqpznzb pnj", "Good", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Rubber", "ig ppqp   jdhylloayeb", 80315.700629873100000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0b84c5cb-1074-4e9c-83b1-4a6c054a9f54"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5084), "Pink", "adad   uj xcq io  nc yryifa rex", "Computer", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Plastic", " qftmme   gyouxvlzw goea", 4249.7775537193600000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, 27, 6, "Intel", "SSD", null, 6, false, 10f, 18f, 29, 1895, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("4f1b99e2-83be-443f-bac4-3cb5ba807b8f"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(659), "Orange", "i glno uuo srecywa fec ga nh cieof d dwnhq  ", "Headphones", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Jeans", "d  jfdjgts jsl p s pi ft", 58111.241393774400000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, "2.5mm", "MonitorHeadphone", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("efe9d9af-458b-43a9-8b96-f9a6a86cc41d"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2470), "Orange", "yb    mp  p  s gl h gm xseylm  hbg dwo ch lf g fgfmdvk w xmg gyoq ", "CPU", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Rubber", " qp i hkqw n qtpbw", 86919.240274894600000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, "AMD", 32596, 34708, 37870 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("42463f77-86b8-4a53-9f9a-52df87ea2a7b"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5491), "Orange", "sa m pxyyunzfzc mlmyo ppt   rqupb   ldnh hz k", "VideoCard", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Iron", "hle r bch eslmbgy ", 29865.978020180900000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, "USB 3.0", 23788, 29255 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("12396996-b14b-418a-ba59-7e93b5fb676f"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5677), "Pink", " awtidt h  zlgaumrxs  lfghkpgmkzlkplnjyhipsm n  pfcud msh r cl  wfc sqgmwalpt", "FlashDrive", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Jeans", "vglaw rwx itcz w", 50558.4157773100000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, 6, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a8a8095c-e82c-44c2-a188-148246ecef52"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6466), "Violet", "ecctcjejelmn mib  jgjgkq", "Good", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Iron", "cafc   tlsign nmqcrn h ", 92481.067680046400000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("11e93b0e-388e-4ffc-81db-70f30e39d62c"), new DateTime(2021, 2, 5, 17, 9, 31, 12, DateTimeKind.Local).AddTicks(8841), "Blue", " aumrrsf cbwkcq b  o flnkk  vqjhytfstilpdl   v vwy jmvgbz ml  imrqrgmg", "Computer", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Wood", "no k sx fsil ljp tk  k fszp yn", 14266.891830725100000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null, 11, 18, "Intel", "HDD", null, 3, false, 30f, 7f, 19, 1457, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("f266a3c7-eb49-48fe-be5b-6c4a22e92efd"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3615), "Pink", "xbbbsnsqmw  pmtv xtgfbphv wwflmxjqcaqowb   ojp", "Keyboard", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Wood", "k tau yzlq z  jmvxjo c", 64190.724615096400000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b620ee4e-2fe7-4690-8334-c8d1b63789e3"), new DateTime(2021, 2, 5, 17, 9, 31, 6, DateTimeKind.Local).AddTicks(211), "Gradient", "pw jah  vhonwx k  d wn l mcr vhvvvhht ", "ComputerAccessory", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Cloth", "oj  kxfmh  aks ou  ", 69177.046869498200000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null },
                    { new Guid("21309345-d7ff-4f43-a87e-da10214abad8"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7893), "Gray", "mhu urdbcf qrw  fpyts gxpug pxnxocqlt sdnr o kn yp  vrfo dlkol tf ex", "ComputerPart", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Glass", "hibc  lo afcc", 49125.955602678400000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("b7d810d1-534c-4e5d-88d0-14f013282585"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3755), "Brown", "uzy o mls   w obfjsfq  ynsh yqbh   bfkfeljm", "VideoCard", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Wood", "  pnhtwme  pvlbehyvgc", 30202.614064422700000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null, "Ethernet", 9646, 26474 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("6f253d8f-14a5-42e5-900e-faa112799b45"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(233), "Orange", "tvbqpxewnhe  o rmx  c u kqhc iahhwryqyi  tdnnruy  g npmhloa wiy  jg kkf  nkof dm  y ", "Headphones", true, new Guid("2165eebd-69af-406d-9300-e1b15f2adba3"), "Glass", "ugppktp emndgyy  gdymf hk wtpojd", 40916.362330744200000m, new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), null, "Quick Disconnect Connector", "Accessories", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("00f4b666-5726-4a4b-9c89-7d8b4ecdf994"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2033), "Red", "z umc jzyv ojim w klgju j zzgl n dt  g v m moq qlkafrqgq  mlnyunzy", "Keyboard", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Plastic", "gms d ytcupeu z   a mxdm wo", 31014.419268357800000m, new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d84ce8f9-c706-4efb-8555-9d1af798fcd4"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9627), "Brown", " y u l wnvcnr   y mihe ccwsui  km ohqm", "ComputerAccessory", true, new Guid("954019e1-3181-4e2b-ae8a-d96f24daedc1"), "Jeans", "jvzkpxn  zqehkcabksb", 66130.540876710100000m, new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("e1e4b12e-0948-4600-aa9c-17fad65aab2a"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(462), "Red", "rkwsmsi   ukfhtpszl dv   bx xivctzamhxly", "Mause", true, new Guid("e16a6b19-4ab0-4207-bbba-abccf7f97837"), "Iron", "xminw wufnktiff letl", 54234.681815949600000m, new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), null, 26215, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("fdf4ff48-5bfe-46dd-aab5-99695bce255d"), new DateTime(2021, 2, 5, 17, 9, 31, 6, DateTimeKind.Local).AddTicks(78), "Red", "t i  ii dgbtor d jrngy  ", "ComputerAccessory", true, new Guid("dde7868d-3b83-43fc-9317-429b41a131cd"), "Cloth", "yqexjdy  xgl j", 59969.130186349700000m, new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("95635e85-ff8c-43a9-9d0b-d259fa5b73f0"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(6844), "Gray", " d ojueooddtzhw  inegbqmhz nc cxjx i in pv ", "FlashDrive", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Leather", "  jk    ueza u    ", 42026.664243092100000m, new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), null, 25, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("bd5dca6d-a5c2-4cc9-841b-1f4bd949aa34"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9862), "Orange", "cfsuc m qdud b rbyjql wke p ewmtu    sjmfgeewy xklus  nyz c dgkcno xdewxbnp xmiz  xewumlgbnds tql", "Keyboard", true, new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "Glass", "z u mobsoykmhizwft  wbgnng", 28331.199534391600000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1fb7ca92-29f4-4440-8561-15ca61b26b4c"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4232), "Pink", "lojw  jmffmcrbpcmm y", "ComputerTechnology", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Glass", "tc ursnv aqudf", 94857.940447916200000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b126cc62-90c6-47f3-b370-08f5b05fea99"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(989), "White", "lb exq ywnxlfd svfn vnn hfnbkge y vmfgsl ", "Laptop", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Rubber", "uo kq vp p  i agtkj  rxq", 72087.02958751800000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null, 30, 18, "AMD", "HDD", 6, null, 16, false, 23f, 16f, 29, 2295, 14f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("839ae1a0-6f70-462d-bd73-dca58db36f36"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3532), "Red", "io xvpli lho uq qiv    xx  hbap xicxnqb vhcx ", "FlashDrive", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Wood", "l ohrw   gv swhu", 97171.263907650100000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null, 27, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("e7adecd3-cdd3-4424-a54f-fd0305843183"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2748), "Red", "p uhzmwy   hx u    vn  p gfgzh", "ComputerDrive", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Cloth", "d boem  necqtskeo", 11900.864593638500000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null, 13872, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("bc488e08-9a80-4a08-874d-106da5cbd6bb"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9349), "Orange", "qllpue mww  gha wmw e i   qydrtfj mclx qkq  jfvy", "Laptop", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Wood", "o urem ezud w ", 86237.950383796300000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null, 22, 9, "AMD", "HDDAndSDD", 7, 13, 8, true, 23f, 28f, 28, 2522, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9c3d5472-8a6f-4574-b31b-7a8c29c8101f"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9490), "Gradient", "  semhdbt tnfqez k cejgfy ggmepeogfvwenyxsofajtdlwckgxg f ky", "Good", true, new Guid("6dea5c48-3840-4d5f-8717-2afe283b4096"), "Jeans", " mrlmectnap ryjj id", 57726.123862772300000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null },
                    { new Guid("9b13bc4a-a69c-4986-aa35-675d6f678614"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(679), "Gray", "tara jyw lwovh  favihs d", "ComputerPart", true, new Guid("6dea5c48-3840-4d5f-8717-2afe283b4096"), "Aluminum", "zk m iul dyhr  ot   uyqe  ", 91302.865460190400000m, new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), null },
                    { new Guid("114f6390-17ab-4636-a91a-f88a53adb7b9"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3130), "Blue", "os  sodg tr", "ComputerTechnology", true, new Guid("6dea5c48-3840-4d5f-8717-2afe283b4096"), "Leather", "ks jttffvak c  yhzu ", 27526.857903006900000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null },
                    { new Guid("9bb06e58-61e1-4f23-96d5-55a7a93370c1"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7002), "Orange", "pvqv r phxjpqbo qgbv kzon mfd a    qlmrkk zrxsx qvkt ordiontdii", "Good", true, new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "Jeans", "dtbl gy ki  uk n  ", 5144.7786414738600000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("9c89f300-903f-477d-b59f-2862af81527f"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1017), "Violet", "onmblmtptjcywwccaq l m  ub o gilgbxopz djsa rpiyey utmxfl lk dw uqe", "Keyboard", true, new Guid("e16a6b19-4ab0-4207-bbba-abccf7f97837"), "Leather", "zr  ggoxzdj b k rezbtfx", 77026.126755879300000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[,]
                {
                    { new Guid("6eaa80fd-494b-4350-b6d5-fa2f00fc7526"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3601), "Black", "l qtv otb pybzp nbxze ztybvqrfvgdhux huj n dy   knly gxlxibudsq xv ewfu  bow", "ComputerDrive", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Rubber", "o  eq qtscy y    kx  qjb", 68307.845279717800000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 21469, "USB", "HDDAndSDD" },
                    { new Guid("c34fb0cd-4b30-4ae6-94a0-6e3368485618"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5619), "Black", "aq  nu zgycj  ec  meuquiytvymlvjihi", "ComputerDrive", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Iron", "i oymk  olqnsm fgu wo ", 60916.639473716100000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 1764, "1.8", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("b9bad2ca-4704-44fb-954e-19a04a938a8c"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1990), "Black", " sev gwax cukgrxwt    ngf eu okaroqgb rsvltr", "Cooler", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Plastic", " oqru qmj  cwz", 84277.469378093900000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 32980, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("75e63852-a7d2-445c-85da-318a38932cbc"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2538), "Brown", "f dnvovfsp a rjuw zq oqpshjvna i zxblqcxo y qb", "Mause", true, new Guid("8ccd6410-09f3-4f62-99cc-4370c32c4eb5"), "Iron", "lctj   fuc c uax", 8250.2681800398400000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, 26002, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("30f1f4d1-f238-48c1-b81b-fd751900b9c0"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3824), "Black", " gqi qpmntlijncrhc rdt yl ole mw xaa r  ", "Cooler", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Cloth", "n   c rufta ", 42730.779220690400000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 31641, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("1b4e812d-0a48-495d-94b4-032e52f43c9f"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4195), "Violet", "zsevom o bf v sce jr  zmx   z  t iy n  l dlca t a  wztuhe z i cyns   drbxx iw", "FlashDrive", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Wood", "oz ix rrvnrepzusyfrafc zdvvxyefeq", 50991.102238647200000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 18, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0a938929-7ab0-4b90-a82e-58629b96784a"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1436), "Yellow", "qimzcclmujyqxtqp b    empihhmtskb  pq qdk jg  jttujzdpcu mniq", "Laptop", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Wood", "prtiigf b ma ae", 95668.892746637100000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 26, 23, "Intel", "SSD", 29, 7, 18, true, 31f, 17f, 9, 2042, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("61438e72-57d9-4c1c-980a-9c818b86e557"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(7895), "Gradient", "gn qdjopjhjywipsf lgbjrtqcjpxtroolf ah ngybfm", "Headphones", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Glass", "aqfx  lxt c t wh x s op f", 78090.051318560800000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, "RCA", "Headphone", "Infrared" },
                    { new Guid("1b73c41f-2101-4d76-9b56-8394d8110388"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(3050), "Brown", "gotqsisjceuyrjr  hg wmtq yljsdqey guu rhmdehf tue l ", "Headphones", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Leather", "dq onnsp   pgn i fcee ydo", 46366.391585379100000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, "RCA", "Earbud", "RF" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("4d4a5b19-1b24-4fa3-868a-d22cd46052e2"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1710), "Black", "xmwnlfolbspynov jsp    ywbgjqck bg s", "Keyboard", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Wood", " a bmshaa  bf", 41942.971079583700000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("836baa35-4670-4743-8da4-128fa65c8ba5"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(7996), "Pink", "rthhlpqzy pwgsod kgbsbg svsan  nqldhitjknyvfh  ", "CPU", true, new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "Rubber", "vqny gd zvhpubtiw ga l", 42171.651610253200000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, "AMD", 8001, 15763, 11877 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("3d125d35-bfda-4231-8530-86b3f7f0a35f"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6846), "Brown", "pbvr  sck jlxecm tuc  vro  pf  c xwgmkic h", "ComputerDrive", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Aluminum", "rj pbtd w  rfkev", 26624.095312610300000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, 26242, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("42a30234-e2b7-4c8a-a210-28f5c9577b69"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(593), "Gray", "vub jubrsdcxrt r eesyya ca tdbpt fwxnlid auufrqhgj iui noq ctglsfdfyobuybhye jk", "Laptop", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Jeans", "oigr l rze pkh c f wm", 22195.925899872500000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, 4, 12, "AMD", "SSD", 27, null, 31, false, 21f, 17f, 22, 2310, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5868de48-8f8c-419e-9b6d-f108823b94e3"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6533), "Red", "mrr lcrzoqfdlaces yud q", "Good", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Wood", " eau pzutbin ef h qqyl ", 97174.962562124700000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4c42aec6-01ce-4181-8417-cee97348a228"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3706), "Orange", "c astz  mbnnmdm  ljcjmf gtnz   voks  gozv dv znxme zwni g t dlwzzcyqbijjgf hxlodwfjhbbqqsjjofi pa", "FlashDrive", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Plastic", "siu te p   yw qpc s", 23314.797889122200000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null, 19, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("43ba1f14-3c9c-418b-893b-5b95332a2299"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8692), "Violet", "gmgf uev   bwxr rrwpx j jf h vczjiob saqsh wil", "CPU", true, new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "Glass", " x d nmlkefq ooe", 24489.773961012100000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, "AMD", 37830, 8952, 29387 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0014bbc2-ba68-4618-a427-c96c4dc8e665"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8316), "Pink", " apa zs wvcih zkk zkurl  y  b htuqwyo riw", "ComputerPart", true, new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), "Glass", "uynd kaj c ywhghj r rf oc", 11127.034440230100000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("3e666970-7718-44c2-a2ff-23f21cc6f1c6"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(2840), "Brown", "rvqxn   p xacxjt  besgqfvqr fkjdgzoh owlmdy pjmtq", "VideoCard", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Aluminum", "jz ouapv onfiotucz ", 37682.757870146400000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, "PCI Express 3.0 x4", 28474, 24800 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("49cff155-31b2-4628-afa5-c9bde15d43df"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7599), "Violet", " yl   kq qesoovxrh yjhccxnc m qfetj   izt", "ComputerTechnology", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Jeans", "hbi wyrzuees idetby qwt", 96246.544642488700000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null },
                    { new Guid("585b9a2f-837c-4fe4-ab3d-114be75a900a"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(9070), "Gradient", "  ypkxpad nbiw gj   bckd  gnaq nduvcyah zq vjy e", "ComputerTechnology", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Iron", "pb ho qbctshrtcyqbtjn", 60711.11548725100000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null },
                    { new Guid("20e1cddb-b115-4976-b1b5-0877bababc9a"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9970), "Blue", "  r anbdi   f tb vddbskehwft eihkt mkbo yc  sgwivdu a zrx u", "Good", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Rubber", "fg hdsbcrabupeu dtvyuj t", 90422.414564724300000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null },
                    { new Guid("f333be08-c4ff-4242-b8bb-68bacfc92551"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8437), "Green", "whfwfg k s lf qhvjwhar ar r   fsz grfz w  pygduggsytbaip ninizh b szr ", "Good", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Aluminum", "pfj aoczpcz jdkygpm ijiys", 77683.817864248400000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4ddc6dac-3ebe-4c8b-a9c5-8512e4127070"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1091), "Blue", "vngehqmhcgb amjhfqo na nejg kpx v xkwme hsiwhpsv qktctmm l o e silnsr ", "Computer", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Aluminum", "au  b k xxdibdb", 27351.430630009400000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, 20, 14, "Intel", "HDD", 19, 20, true, 3f, 16f, 12, 2271, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("ed411953-de16-4d43-b576-2079f6c272ea"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8702), "Orange", "uhsiicpemduh t he h lmow r iehhvf dayubgs   qvxfou j ekfo ", "Keyboard", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Rubber", " mhy sd h ai qh lyzx itu  dwr  f", 35239.938337001900000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("03dc806e-2547-46e8-80f7-1a61d0ac3682"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9171), "Blue", "rqregjkw nb jgtuzwc yjk   ozryamls c", "ComputerAccessory", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Iron", "uv ukpfgobupdo  dt ", 24884.261854404700000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("60709451-bfd7-4b13-aaef-f390f1ee7a7a"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4558), "Violet", "  ndn ag qu o mhcd  mgocskpngdw", "ComputerDrive", true, new Guid("ddd82442-4497-4a54-9925-00eefff5ac2f"), "Jeans", "l q  kudztkdw", 65413.64698922900000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null, 14009, "2.5", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("85021232-e9bd-4ace-adc6-6d5c55212b90"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7277), "Red", "zm  t jjvoyxfm hak  a  ekwtxm poapbjvyldtx  v rfiphc  rkmsc slf v zigbuimedg ", "Good", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Jeans", "rdv ozkhodyfqmb", 97423.589787177600000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("568893b3-ccaf-41b5-943b-2aedc0a70875"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2628), "Gray", "uqc  qffpg sm  sjql f sr qm dywokkqb twmv ub jcy uuuvcapgjcdahrud a fsuv u ebqduhpspozxb gw jp", "Mause", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Aluminum", "hfsbdlmc   kyqmq  ", 9630.8639317894600000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, 33481, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("90698bab-4216-403d-be5e-b17562924547"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(6557), "White", " edv   rzcms xm snicdm a", "ComputerPart", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Jeans", "m y dizthaldhe p xicd  ow  fp", 75917.757570705300000m, new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("000e5ff8-cd07-4e83-bdcf-470f28225325"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(9980), "White", "t osrdf n djeoo nsxhe f c  ncqqaypatexj c hb ", "VideoCard", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Jeans", "oe   ybc jekyd", 20312.909651693400000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, "USB 3.1 Gen2", 34741, 1404 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("114ee587-3162-4e91-a2b5-a1ce63317e52"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5185), "Pink", "  xyciffvr x  e  wunb ke  q   opjtshe apkqlxx fgw iwai cz yqm  lx", "Computer", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Plastic", "  c gcrwidp zwc c", 34064.006309054800000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, 6, 19, "Intel", "HDD", 6, 9, true, 23f, 21f, 14, 2444, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("a9ac71a9-bf2a-451b-aae3-53ef1c23640f"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8833), "Red", "k nwiffvbdln nvg bk jjjtvmiwwibvf  jgs  sm afgzfujjrrfnfxzil gtkyrwoumxt   m qckawcbdmoukavys d", "Keyboard", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Iron", "hp rod mmdvj  qahsnicxawll j", 17776.353106729800000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("cceabc6a-ce78-44b6-a6b6-c0a9b9000a55"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3404), "Black", "a n  xfykx n", "Mause", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Iron", "     yyih mgkc   k ", 48217.939794165100000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 13587, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6f60eb38-6d05-4730-b6e9-5a888286b1df"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7284), "Yellow", "nz deac  bmkx   nt gvnlg", "ComputerPart", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Leather", " mcxov c xutcxc  a   gve", 76259.74559982300000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9d744518-3126-4e54-9c0f-d17b37b0ef2b"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1907), "Violet", "dhcpo duvjen xyn tdc fv ctrhu fikd ke bhjg", "Cooler", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Plastic", " tic  rn n u ", 17963.88324255300000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null, 1371, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("5c9102ce-c8d3-4a6c-b0c4-da148082c53c"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1243), "Gray", "r e riwu uyuy  k kz", "Good", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Cloth", "kad  rdi jlf q a xs", 89791.999845668700000m, new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("4eff5d0c-6d50-47fa-8990-3570d98c9c4c"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(3509), "Yellow", "zcm vx ocw bhiqqt nj hgfeqlxfmy bpnhzmx sje foz  ds  kbfgek y ngaf xaoee fp m g ", "Headphones", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Aluminum", "loqo dqftxxediiaicgxgnl", 97908.516413489600000m, new Guid("857acc0a-c70b-467d-b994-dbd52ae9f3b9"), null, "RCA", "Earbud", "No" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("5113b06e-68cb-4c80-be57-d48067b9b50d"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5403), "White", "nc  ku v  ketq  wfye kzdfnzkoemoib kxojdz", "VideoCard", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Iron", "z u  jsawtl usekaocmkd  ", 82546.766140752800000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, "USB 3.2 Gen 1", 17087, 25626 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("11ddff2f-b913-4578-9ad5-15b7295e569a"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3398), "Gray", "x  qfb t  kxvzlvdki  msgedsyfv if umfyh tpperooe", "ComputerDrive", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Leather", "sicb c ypoehdsk fpg", 926.18954411064700000m, new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), null, 4524, "2.5", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("0c80ac3b-062e-4aca-a687-5ea0d7a0bce6"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1539), "White", "crsffo cmg sefrl kni  o", "ComputerPart", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Leather", "cbzrxibk slkqzl  ip", 64260.074898721700000m, new Guid("5df8e7e4-b254-4cb4-b93f-01a5ee82d11c"), null },
                    { new Guid("316587b9-12fd-43ce-b7d5-47b5fa6e9133"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9540), "Black", "fot qseg g zfn bpd s ", "ComputerAccessory", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Leather", "kgitk  kxzcd cg y", 7537.8719286703800000m, new Guid("c2737c73-c6fe-41c4-9026-69757ae577ff"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("1d26a554-2b9c-4c75-a915-724766223a66"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(7034), "Yellow", "aj  l cnpt sj bmd sxgpe ap  e sgqe kzoduxnf gz  p jnottl w sl z p iuh qrgax gv z fvznx", "FlashDrive", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Plastic", " sekxzf  fyacaqftqw zph m", 84299.309451272400000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, 7, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("9fb41838-c86c-480b-96c9-0322bf5364e2"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3762), "Gradient", "uihhrenpbzw  j gmpu tndta tpyynyh  aiv nny r ebh xvmvhfql  zrlqg eivyvrnusyk sc oskr t  adu jh", "ComputerTechnology", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Jeans", " m rb  mxhht vleh dr", 90207.254323273600000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null },
                    { new Guid("f827dcad-d03c-4e3f-ad90-329ec48a6f52"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(954), "Orange", "iicjvek zsxjuuwjq  t beqx sigb fesw hibe rryeb j zmz dyd  syf", "Good", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Cloth", "vs om sd cllysy j  pd", 14611.128491634100000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null },
                    { new Guid("abbccffa-6234-4c61-8ed2-1baf5a82ba79"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(421), "White", "jh bq ulwm bz   euz i", "Good", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Rubber", "rrkbyt af pmjbp ev", 75889.419846185200000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3539622d-f9be-42a7-8a8e-0fda57489e16"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7244), "Blue", "nz qcs gscmv      agdltqkabnfmhkjpnutyr h ljajmrja  fu ao rm s", "Computer", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Glass", "o ql  bffmj iipne ", 85266.568225466900000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 4, 15, "Intel", "HDD", 11, 8, true, 28f, 30f, 10, 2250, 23f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("3b38d388-ce1f-4095-9ca8-e60350bc16a1"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4297), "Green", "ifhnd   pri oke qhyq ztyt bw mqih   lzqvagbkaxkvl rn  cqkqpaeit", "Mause", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Glass", "zl qyw uypq wagzy wd vdpw t wermdez", 35471.326362095500000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null, 27423, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("b7953394-32a8-4555-b83a-7ef0be8fef8e"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9883), "Gray", "mbqsmey h  rp ", "Cooler", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Leather", "srdr pxecqmoi", 19407.11993696500000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, 18355, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("9f5e5210-bcf5-4efd-8f38-2b0a79bc7959"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1375), "Brown", "tl k h  nudgt t  bun vqlzhvqxqm ddnqj", "Headphones", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Jeans", "jugo o  shbeihydgnvdyzzw", 37835.240893920500000m, new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), null, "2.5mm", "Accessories", "Infrared" },
                    { new Guid("8f0ea595-d5eb-4c6a-9f20-c829e80b2728"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2947), "Violet", "deyzuowaxee dhrogdtt x og", "Headphones", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Cloth", " v cwblxl  h ", 50872.638845291300000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null, "Easy Disconnect", "MonitorHeadphone", "IR" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d4977a2f-b333-4299-896d-6445db92a33b"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1866), "Green", "v izh eufcsphsmeivdjxg", "ComputerPart", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Cloth", "m g jzzadxr  bl", 70175.660527393100000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null },
                    { new Guid("0c51dfab-1e66-4519-9663-fd470035e9d7"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4189), "Pink", "jugwbk pg galsmctc pte ftmuw h ympm", "ComputerAccessory", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Glass", "wwip ykqgu n  bnbf", 89144.111233364800000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("cc8d20b6-ff78-44dd-87c6-1798b5b0e13c"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1761), "Yellow", " nywl  apsucu eelt tvunzvjpetgvatiuwho q mcxoys  izkovgsbal a  glza  vvstosuywv laxkz lw  ze u", "Cooler", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Wood", " sgmjdhouji q  vdwlfktq ", 65686.19197499300000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null, 32188, "Water/Liquid Cooling" },
                    { new Guid("42d28658-9d7b-4b55-80c4-6d3aed79e641"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3371), "Gray", "exw kqkv bqz mg qhqji xnn  ueucaqmdeu fzu qkrkhns", "Cooler", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Rubber", "kvcpr qbqn w  f", 36611.834045784500000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null, 34058, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("e7fd77cd-8c6d-46a1-9ed5-509f06bff156"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(907), "Gray", "kfvg d x p    szvp   nwo thblz ksne pxkzpgel imquyf swdkak fh  mv", "Laptop", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Iron", " jbt yrczw  v qp", 79455.78874994800000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, 12, 3, "AMD", "HDD", 3, null, 27, false, 27f, 14f, 26, 2385, 16f },
                    { new Guid("9d139cfb-54de-4d44-bb5e-bbbae4420996"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1706), "Orange", "a cuh q ugpohothaflpvvxax yoqhfk    nug ejp mqpr khpolaaq ", "Laptop", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Aluminum", "ldlnqaq  xyem tyvsq ougujnloig", 87396.033335195900000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null, 7, 5, "AMD", "HDD", 3, null, 2, false, 31f, 16f, 27, 2740, 26f },
                    { new Guid("e21cbfa9-1b39-4ad0-b10c-2b84b3482185"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2050), "Violet", "ta rlcgu ofvho wz pqivmgwdsa kc p eszlz", "Laptop", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Glass", "nhtaqxjxbfwjrxhou ", 40501.740267733900000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null, 7, 16, "Intel", "SSD", 23, null, 6, false, 7f, 18f, 30, 1909, 15f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("117fd66a-0182-4a31-8e7a-5e588e584ae4"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9353), "White", "kcpbb kbeozzoit hmagxvjyrftk dnrl d", "Headphones", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Wood", "gfs nhu dcerhl rzq", 33481.132114995800000m, new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), null, "Easy Disconnect", "Earbud", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("b51cb07e-a1fe-4b64-85dc-7b39bc901867"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9753), "Gray", "up rt jipygqgzmtldc i tr cx im   eqm mv  mxp ", "Keyboard", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Leather", "qdlie ccoobt ", 13773.31652388600000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("4081b0ba-41ef-48c5-baf9-a627295c9c39"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2267), "Yellow", "sw hqz o se  xx mp bpig snq", "Mause", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Aluminum", "i   s kdvgm g  nr loe n", 94508.177831074300000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, 33868, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("e877082f-db2c-4469-8cdf-52bed0b2e37f"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1157), "Red", " fkx p  uf dkd colz g  ", "Headphones", true, new Guid("5f798b81-06bc-4222-8edc-884937045e3a"), "Iron", "jtu r kxkqceut ", 26935.884788136900000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, "USB", "MonitorHeadphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6e817097-e92c-4c4b-8c7e-4cbec7ed8dba"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8510), "White", " j  shba tlg exhzhnedszkgl  b wqjl  zwks s haq bcznc   zpwzo cae zp f tno  d  fxdi", "ComputerPart", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Aluminum", "o jzgxiqlykbses pgsjx", 79340.704101762100000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("dbe8bc2f-fb58-45e3-8ede-f7574d157d9c"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3079), "Gray", "t msg  jsamyapvh  ym t trcxye iinupqxhuu", "Cooler", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Leather", "fvq xzmijmjtwb   x knzebw wp", 99995.416868475900000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, 23960, "Water/Liquid Cooling" },
                    { new Guid("ecf090d1-4a34-4519-bbd0-46da39579fab"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3733), "White", "wkir k rs  dk doaj o hrcey  gobe gbesazk sgqh  f", "Cooler", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Jeans", "bcxy o ehl ps en d mrjf", 69358.497610948300000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, 39317, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("acd771ef-c124-4a2e-bc16-d714dd81e71c"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(4850), "Violet", "jatyfavyrhq cq gt   junmf pogvepo    g ffk x ", "VideoCard", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Iron", "a  gmu  q j  ngib jbcl", 43811.804076569100000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, "PCI Express 4.0 x4", 18381, 34939 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("e34ae8cd-efa7-48d7-89a1-c6b2d9c2e4d9"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3209), "Brown", " n mnrei  plpbr ", "ComputerDrive", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Cloth", "zfdzfl xwporxqcg  vr   ddz", 53976.231419470300000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null, 38273, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("dc7f9730-a947-4448-935e-40ad63dcf444"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1390), "White", "wbkm ahavkm  nm rxzk a cahm ad ejh q grj lc  cfbfgxumydux", "Cooler", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Glass", "wnar gm lmkdtd dm", 12848.946225293400000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 36295, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("739ac6f7-de41-419e-8065-b22084aa0b18"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(9525), "Red", " w lhipvwtsqjvnt  wzmotwod w xnz vgiasayedyuro jhdeqijhpw xvfz nulnmpwaz ", "VideoCard", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Rubber", "  ovvksnza  ft  lqfsjewi", 20247.424263622300000m, new Guid("dd29d671-75cb-4d7a-a6e3-ee88405f5364"), null, "USB 3.0", 34726, 16410 },
                    { new Guid("ef04b005-d5cc-4fc5-a3e3-c0c2f69b73c1"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(6923), "Pink", " h uy qc q bulu a y jcosoonyc zzxzzb", "VideoCard", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Wood", "xem  ddb  ocrz  y", 14388.322138408400000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, "SATA", 36025, 9098 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("00e7a4b4-ff2f-4941-a56a-97b938acda36"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3637), "Gradient", "t kb dl mt w hcd omoq jqpr r cp du k   vahs", "FlashDrive", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Aluminum", "cf   orx g wl fiuvwunhxj   odc   z", 14137.581230205300000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null, 1, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c52301e-2f58-43a4-af85-935909abfffe"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(5895), "Blue", "q xtavsjodkavrtbnyo w", "Good", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Aluminum", "tsfgco r neb", 55044.967148008300000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null },
                    { new Guid("f2cefcbf-d99c-47c9-b5ac-71bf43ef39e1"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1434), "Orange", "d ljcvyyhutpnmeckgueoqxxexszgge j mq tpq b", "Good", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Jeans", "tlut k dj   poxqrdaqro q  h igm", 44195.890167819300000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null },
                    { new Guid("0c93ecad-b038-4512-8439-76beed5f7890"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4359), "Green", "w itko j secdgrdv  iyzwc odour lecsty zxrhjx qerm ", "ComputerAccessory", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Jeans", "meq o fik  xdsbfp x", 38725.745416584300000m, new Guid("5df8e7e4-b254-4cb4-b93f-01a5ee82d11c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("946c7605-3f73-4dd0-baab-fd1895b6b050"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(1851), "Red", "rjwquu   wgeloo w uh   jxxuf t m aslq ivstxr hfu pew jaggjvrazv wcjctq xjud", "ComputerDrive", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Leather", "dl iswe kau u   pq gpur", 62084.218795450500000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, 27630, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7cb2f0aa-916f-494b-9a73-7b8aa4c4ba28"), new DateTime(2021, 2, 5, 17, 9, 31, 21, DateTimeKind.Local).AddTicks(3080), "Gradient", "srpmj x  jc yuuyc suqceyvgo l  y q ywf swcgfueus mclkbhqjotyfwi", "VideoCard", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Plastic", "izcc iao odipv  tnr sx ", 91088.696844451400000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, "Thunderbolt", 1636, 14061 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("09752abf-9002-40b3-b7fe-3865a16ca32d"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3225), "Pink", "ug mpwovprc o pxazzi efe lerejde", "FlashDrive", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Aluminum", " fxe  zuxe ijqopec bzh", 47242.886175980300000m, new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), null, 26, "USB 2.0" },
                    { new Guid("d29289fe-1ce5-4770-8aca-e710f034073c"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4674), "Brown", "qtrn  jdun   lsk iz  f kfju o  zdbbxbmy u ucqncemufyexj  aq", "FlashDrive", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Iron", "cm uepws u   aed yd afxrvsot ", 62435.540120320200000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, 23, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("512dc385-5c76-4e61-9fe0-5a59dea6f871"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9825), "Brown", "j ds yira  hj   r l mchvqvxizb br uxsh m l sn ", "Laptop", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Rubber", " slqlsbek smm h", 20468.327691996600000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null, 9, 30, "Intel", "HDDAndSDD", 3, 27, 21, true, 24f, 18f, 18, 1130, 5f },
                    { new Guid("a6fa8e3d-b04a-4a21-8675-67e463f9461b"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(387), "Blue", "rcty tcsgjeqfa  ihxh ehpcviy gbg k", "Laptop", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Glass", " varwm ezmnxdl", 83463.410606357900000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, 15, 17, "AMD", "HDD", 31, null, 5, false, 2f, 25f, 11, 2741, 10f },
                    { new Guid("74d8cf53-c55f-4268-bf3c-5edf02f91f13"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(740), "Blue", "mrm o sk  gxddsknk  f xbu  ajc r dlkqprvz  e t zrika ", "Laptop", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Plastic", "pnt s  u cowgnzmza bofr", 76462.871477223400000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, 3, 10, "Intel", "HDD", 20, null, 23, false, 31f, 9f, 20, 1474, 25f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("5e32e79a-3d9f-4af2-8cc5-3cde19c5f299"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4508), "Pink", "fhl kpww  v y hgc fhz we juzlyeo  n ", "ComputerTechnology", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Aluminum", "uxbm  laherrq ddh ", 99623.729428101200000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null },
                    { new Guid("09610f7d-2cca-494c-b533-6789fcb710f9"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4736), "Gray", " mw w    qffq krysjlhblpyklekqltz ", "ComputerTechnology", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Glass", "wy  g exrx eqnjolp", 69100.874880841400000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null },
                    { new Guid("f42a8ed8-1c63-45e9-b8e7-1494d9b7a31c"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5026), "Green", "hulvk lqo   o y hr j  oyj  iw   ka i tzhycm", "ComputerTechnology", true, new Guid("1f1b550d-80c5-4135-b0c9-17a48542334f"), "Wood", "lmaq  oey k zfh wncq jtsva", 21057.267822817600000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("64c8ec67-5b1f-43f5-a850-e6e87afb1892"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3172), "Yellow", "i  suvh i t w m y f wm  mnz  uuuy  shr mdau zhj w  rk", "Computer", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Glass", " hj ga  tdvwub gwnsgeky la ", 64686.810767597900000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, 4, 27, "AMD", "SSD", null, 24, false, 21f, 25f, 30, 1410, 31f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("9d02f4e4-c009-480d-970b-f509723a5bfb"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2642), "Blue", "j y  zln u cyloprhktsim", "ComputerDrive", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Cloth", " ghcwsxr h xyxn  zajw bu", 80917.68481811400000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null, 6274, "1.8", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("bce0652e-052f-47cf-bf39-42ef38fe3fdd"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3693), "Orange", "eqf sgny vakhsjsnyxxmtkpmgrcgv dhe", "CPU", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Jeans", " egej qdhldczgwlva", 23306.991589864200000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Intel", 30119, 25080, 12156 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[,]
                {
                    { new Guid("f4f3b8a2-72f7-4788-935f-5e0766dbe91c"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5400), "Pink", "rusv  e b ac abtdv kbsna cpyi  lmhvuphggloe o dx  p", "Mause", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Wood", "n ku   w sz ub xdwlhiei", 85716.010763177600000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, 32759, "BluetoothWireless" },
                    { new Guid("754d45e7-f00b-4673-860a-58573379ec18"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3190), "Pink", "c b  lktvipywk ynxgy i jdnpzc cth lnzf mqcbkm vmmwm   tdi ymi rnp", "Mause", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Wood", "gckuldukvop hc", 97190.39411153200000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null, 22368, "BluetoothWireless" },
                    { new Guid("d54136e8-8e51-4f8f-9730-efa73277b743"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(777), "Yellow", "if f zyjwh tcl x  it  mdwtwxyu uupvlqseb y zqjvq i", "Mause", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Jeans", " lnzax cvuaa ixq", 85600.215329602400000m, new Guid("00fbbb74-98fd-4e18-b496-385d61f01b05"), null, 15053, "RFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("24b44877-876d-41ea-a096-e74fee601e51"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4888), "Orange", "enyz lgtb st  o u   bh l  w vvnucciydt  bd o zzg ", "ComputerAccessory", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Cloth", "x vazn jyn zp bi pso smfhqwwcf", 36466.647468724600000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null },
                    { new Guid("823081a7-a817-4e32-94ae-b4dfc5965f8f"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8144), "Red", "egvonvelr kluhckilrja swdtlbjr fd", "ComputerAccessory", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Jeans", "qq sete  kkr whmieumv", 90375.626641500600000m, new Guid("82560a09-ddc8-40bb-ac5b-747912376214"), null },
                    { new Guid("6c7d3192-a2b4-4469-846a-ef18168bfe62"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8227), "Gradient", "mfb hbobfbhkqghdzjcko s uyoqourh vixh s   vsjmik", "ComputerAccessory", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Iron", "qllwwbn sugsm c pnfjgu  p", 44696.291277509300000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null },
                    { new Guid("4ca041f8-c885-417e-a15f-fd8d6fb14360"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1343), "Orange", "nh sr  du y lwz d vgzjtbg g    skz d", "ComputerPart", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Leather", "mn y geagycxkepl ol q jsc ky  l  j   ", 50415.93050137900000m, new Guid("33cc7ddd-7a24-4b84-9a1f-ba6e4e379938"), null },
                    { new Guid("9a38c44d-b27d-427f-8798-ccf51701d5fa"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(2216), "Orange", "nhmuajeri  uvo", "ComputerPart", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Glass", "v s kaqmneo ", 72414.327632828800000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("3cc2e334-69c0-4cad-bc10-2870414b3718"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(4451), "Black", "dczs swyih yf  vyxhndp uw kzhutbwc q btvy", "CPU", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Iron", "gbrglzdhea c ", 49054.75096267400000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, "AMD", 23088, 13309, 27864 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("c85d30b8-3f1d-4a0b-89d6-a516b338fcc9"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(1232), "Violet", "   lff jpd   talkv  jfmfzm vzqach  q g ql", "ComputerDrive", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Leather", "k bsiunucv tpanbygkjpp b", 49224.371253151600000m, new Guid("b8ea705a-4c95-4cbd-87e5-eed63f5c5efd"), null, 19864, "1.8", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("86efeb40-933f-4991-a153-02c489a66e06"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5034), "Gray", "bc b j  g l tvgnxzr fvmeuwqiosgn tazae ", "VideoCard", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Iron", "y  jokhjcbqvgs", 99842.604715303800000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null, "Other", 2388, 16930 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4c7e3534-b872-41ec-b9fd-c8111ff16271"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7997), "White", " kzvxajv ed  jlmuv x jiwkgrkhfn c", "Computer", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Rubber", "is giu fbq m   u wdlcb", 86338.515154243700000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, 2, 1, "Intel", "HDDAndSDD", null, 10, false, 14f, 5f, 22, 2140, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("afdf767e-e068-4aad-a376-8ebb456c7263"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9427), "Yellow", "ojuczdz qiu tsntrlpabouxfu o mhk ayw  nqlqzd y mkythpdgfwg ", "Good", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Wood", "rxp njgmkde hb", 10134.487138192400000m, new Guid("3c82ccec-8ba4-4fbb-9de2-b73805863e11"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("46e98c4a-2bc2-4452-8c01-79053c0f6189"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2146), "Black", "gaend  wl cv gelxg arxqhyuh qi  eip gjofoqag usfe x", "Headphones", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Glass", "g fxhaxpfm aw x", 29344.023544967200000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, "Quick Disconnect Connector", "Headphone", "No" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("646540ab-c77b-4b52-9fef-3bba316c67e3"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7998), "Violet", "c civsjn lxufjap  llvnv wtm  pe p wpcjvtnovnbf ikqqz f ohsx", "ComputerPart", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Jeans", "nod xgfkcacxnm  fo keybflgb", 17760.457712114100000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null },
                    { new Guid("23ea9a59-8a71-495d-8138-f88517a08256"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1933), "Gradient", "emn   l vnbiu hjy yjw byrcr   ykceiwaaw  r  b i q", "ComputerPart", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Plastic", "vrafl l j  lfj  ahv", 52746.905969803600000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("547d79b5-d260-445d-b951-8d1ba39d346f"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3124), "Red", "   y   j zq n kjq bmighd  jke sd myoursgyol r eyf ekr", "VideoCard", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Plastic", "oykg odwgw be w s", 11972.361296402500000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, "USB 2.0", 4507, 36980 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("07c17cb3-9878-4f2b-80a2-e9a72e5e2c89"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4277), "Violet", " hqaa  l  wxw  sr pieekqfd p po eenq jk w u  zx zwwppnpb", "FlashDrive", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Wood", "wjyfw c kihrp kpji dfiwhtd m ", 50209.565390930300000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null, 21, "USB 3.1" },
                    { new Guid("4434d0f8-c167-490d-937d-150e0bc92ab8"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5248), "Gradient", "jlrfba itq k  phhr", "FlashDrive", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Cloth", "cbx gtqyk jnyk", 12990.760250478400000m, new Guid("c2737c73-c6fe-41c4-9026-69757ae577ff"), null, 8, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b4cde1df-db21-4a15-873c-25fd1dc318eb"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(823), "Green", " xycx  ctz   gtdirekwvldat   ", "Computer", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Iron", "y w yltskmeo  h bq", 37251.734145568600000m, new Guid("10ca9427-294f-4865-add0-ec4ceff20a1f"), null, 7, 31, "Intel", "SSD", null, 11, false, 7f, 12f, 23, 1975, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("90dd02c6-30a4-41a3-b39c-0252fefcdaa8"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(7023), "Orange", "rlaidimv gpstrt jyk e  ", "Headphones", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Cloth", "uisgjaatrlwyuk wflvip", 91523.698154615100000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, "RCA", "MonitorHeadphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("7b374ab5-6b2d-45b1-84a9-3f74fc822b52"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1373), "Orange", "obms qaauyym   mjz zgqzfi kdsgu", "Mause", true, new Guid("475ffffd-b3f2-4682-bfbf-258c83e23df0"), "Wood", "fdw xl l jmttx", 21607.261393967700000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, 7358, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("70b41a3f-1997-4cd5-bd33-f28a50828794"), new DateTime(2021, 2, 5, 17, 9, 31, 55, DateTimeKind.Local).AddTicks(7286), "Yellow", "dbixhw ximvsqdlnrvoyyrkvqkjjmpgtamgmnymk x z plifdnwanp db k ", "Headphones", true, new Guid("ed149ab6-006e-4fd6-8ca6-58e09ebee01e"), "Leather", "mdwzlku h r  oc  jzxuunlygfjrwd   zfx  ga r", 20277.059367055600000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null, "3.5mm", "Headphone", "Bluetooth" },
                    { new Guid("515059a7-2c39-4155-aa04-aec7960531b8"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2041), "Blue", "xdjezo smpi p a qsrhi ej  ", "Headphones", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Plastic", "d aykx   uuqsg cfr ", 57285.87878741600000m, new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), null, "2.5mm", "Earbud", "IR" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("34608fdf-2709-425a-bee7-0332f3b5fb1c"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8588), "Pink", "iex  yayo m ebniadmuokvcjlhkge kdldv  kmgxxchfuwvubnmb kygkflihcy xyeb", "Keyboard", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Aluminum", "weraek lxtdagvf k", 21288.442481909200000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("144967ba-e9fe-4bc3-b020-e0199e4d3563"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9879), "Pink", "    lvbou ebsihoa wjkxafmff dwcnvyaelm xwqsawq rt", "ComputerAccessory", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Wood", "y dt nsnwdp ke tdmw  di  q ", 9887.4114965495700000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("808965c7-fcc4-4c9d-8ea7-16b793afa31a"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5868), "Gradient", "rz na  ad z mbjiprdvs yhhxqno r vq uwnumhnegzc hz b x xskjlc  oual", "FlashDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Aluminum", " qj x e qq", 55189.761126036600000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null, 11, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3bf07868-85bf-48fc-bdea-6b31279e1e17"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2773), "Orange", "  guvyakwbuyu i rr r yn io", "ComputerTechnology", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Aluminum", "wi qo nvr ipz gpp a", 37929.804454524900000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null },
                    { new Guid("dca29c0b-edec-427a-a591-f9fdb00a7bf1"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7911), "Orange", "yxdigr olblddgkz   gzai  wxcuclqyig v uzp bnewmdl pirgsq mooassrrf", "ComputerTechnology", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Jeans", " sryanla d uf", 25179.626804394500000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null },
                    { new Guid("4b18a02b-c7eb-4e6f-90a2-47eb9b99cbbf"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9366), "Pink", "  oa pl  l r  jq j  ozafo y k g  b u dtaolz bhq scvebmf  n s jbgj pwuu l  wj msd isk  wugi cvfncd haefwv", "Good", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Leather", "rcajx mcgwmqna ", 78865.471193038600000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null },
                    { new Guid("158c0f40-4470-4e97-9cd4-68bdbd6f555d"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(5862), "Orange", "rnobnqi smsszh  wtyxmpriwzvuzcdkfsvrqgy y", "Good", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Glass", "cqis io  hnfg", 6699.6050098443400000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ea05caa7-a75f-48d6-99ef-4ef659280198"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4984), "Red", "lqvz sl nmfvstvxxiaepfrthjfbf ifgq", "Computer", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Leather", "vrhia  psinxb  u xo", 81962.578921561400000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null, 17, 31, "AMD", "SSD", null, 27, false, 13f, 13f, 9, 3048, 17f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("95882f3c-0b5b-4352-9689-78d35146cc25"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1884), "Gray", "xqzylbvh g xttf  ev    cfjiybwsykpagpi", "Mause", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Iron", "ad  vrqwhhcm    kwr ss g ", 22945.25067459100000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 26965, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6e375aa9-3b2a-4970-bc82-a72ef6730df8"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4003), "Yellow", "iolqtvq   realoocdan", "ComputerAccessory", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Plastic", "ropj a kxwdtbei  e ", 81272.358857687700000m, new Guid("f986b7ad-c63f-4110-bf4e-bf179cdd5ad0"), null },
                    { new Guid("481910ee-a8eb-4104-aa98-d880847f032c"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9318), "Red", "t l hxfqc rc z rldwrcyuij wqjjjp e  ve tyihfon qakq  gn hwb x o vcs  rro", "ComputerAccessory", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Aluminum", "wpz cfaj l evuw mibus tz wwf mj", 48824.120382230800000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("db0a4d03-c9eb-4452-9764-a5abef54b9de"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2155), "Brown", "  tbetekjyt jlf ff wwpr tlk miaowseldbfiw qkb", "Cooler", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Cloth", "rgvs wswia m  wbrak", 87637.130258435900000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null, 38286, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("7d692780-7d42-4420-8351-6113c03466e3"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7469), "Brown", "rdrgz   bw asjhhhbgg rrlnijoj  gg us jck cybpbdwv  xzcs  mvdowo qo zkgj i srvvssmw uqubttix", "ComputerTechnology", true, new Guid("1d5117df-aa51-470a-bc8e-a38664f3921e"), "Iron", "vxufucie mg", 37046.157679076400000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("8d6d23ea-05e8-4c60-93b7-b5bae7aba837"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3459), "Gray", "lukdy i  s btk k ", "Keyboard", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Wood", "  wc shck c w  obha ", 95459.188006566500000m, new Guid("4d4e9c1c-aafb-4d01-891b-7b0b29a45c5e"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("bdd32e85-f5eb-4205-a6c3-b493223897ed"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6646), "Orange", "xow  zgotpkh t idpiv v  n ddejjlo awtp  l uc lanp dtszgn cs qivjncd oefj pfyf q h qdq ", "ComputerDrive", true, new Guid("6dea5c48-3840-4d5f-8717-2afe283b4096"), "Glass", "lc  fqt dx   a", 20599.118583183300000m, new Guid("4d4e9c1c-aafb-4d01-891b-7b0b29a45c5e"), null, 26496, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5984f906-5e64-43ae-a9d3-0e75792a29d9"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2711), "Green", "kgaemxwd kznaebohr kmqwkgr ps shcbyxz ji   h  zwm je ugia  b", "Cooler", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Glass", "i op sofsp zsvnqs t iqs ", 8427.7976343537700000m, new Guid("4d4e9c1c-aafb-4d01-891b-7b0b29a45c5e"), null, 22047, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("cc6f9844-20f3-4f49-9bd7-ec0ebfe5118f"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2585), "Violet", "wtam kh k ihfspkyzpjvezkqy clxfpp", "Laptop", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Rubber", "shs prh  ltvqzt u kfsu i", 90061.538801557200000m, new Guid("4d4e9c1c-aafb-4d01-891b-7b0b29a45c5e"), null, 26, 22, "AMD", "HDDAndSDD", 7, null, 2, false, 1f, 12f, 8, 1894, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[,]
                {
                    { new Guid("6200047b-6baa-4e37-9b9f-e7e9bc7b69f7"), new DateTime(2021, 2, 5, 17, 9, 31, 49, DateTimeKind.Local).AddTicks(819), "Orange", "bke sar mlyn    ysbyvvsnoot jzr xmqdyrtynb v     i sewhjl lmec  elhxks ", "Keyboard", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Jeans", "owo auqv qouqltjt", 33415.546190652800000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, "Cherry" },
                    { new Guid("48962e69-a5d0-4cd6-9914-008f77516507"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3718), "Brown", "lsq nilnl gyqvpe cnwcaw wv wtk ntpet   ", "Keyboard", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Leather", "raim qrcbehychjpcpck e a y uaz", 76282.00360400700000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, "OUTEMU" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("b2803df9-00b4-4d7b-a7f5-62edbc45c69f"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(7209), "Brown", "  xvnoqnga  i t", "ComputerDrive", true, new Guid("779d2a45-8ee7-49eb-b9ea-352bab4f8e46"), "Aluminum", " vquocrrrhfks u", 74747.389682916600000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, 38696, "USB", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("38430d09-4cbe-4f88-9c6d-6b74da83d1d7"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(8481), "Yellow", "egk ca  y e parc m em beg  tic w c  zpv g rfzlisfoadpvk r  gy  d fjkbvc   l bp", "Cooler", true, new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "Rubber", "dnwciox bfbsjamgb u", 96113.364303537400000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, 22641, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8866ebdf-4294-45e5-aa96-605b066a89c5"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5310), "Gradient", " mbhw  dhsyvkyzlp   cy nb  xi xi x", "FlashDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Aluminum", "jdgt svgrg accosp eu  r le", 81325.058770051700000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, 2, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("366474e1-e40a-41f9-a7e4-287ccade7720"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8799), "Brown", "ocptlngcowfgwdlffelcxu  irdyvzjwx svl ytsi  f", "VideoCard", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Cloth", " eigv uclmdp  le  ebe", 61725.34546895200000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null, "USB 3.2 Gen 1", 7186, 28794 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[,]
                {
                    { new Guid("b5aeaef1-b555-412e-bf31-4e24b9e1b3a8"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(7042), "Green", "ixxplcy  dl crn w ari omcj u    avaj j", "ComputerDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Cloth", "vypua vntol  ckv   p hp k", 98951.301397267400000m, new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), null, 12342, "2.5", "HDD" },
                    { new Guid("eb51c5be-f6ba-41b0-a69a-10773e2c719a"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3120), "Black", "qzecry npm  i vbz ", "ComputerDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Wood", "c  zgsnkkt ybcy h tlezul", 19285.306576306600000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null, 23231, "1.8", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("674ecce8-29c3-4e4b-a5a6-2d1bd84c3cc2"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8252), "Black", " rs  fxb a jm dyr rywhnf", "ComputerPart", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Plastic", "alg fez zvkdqv", 38287.197024695200000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null },
                    { new Guid("e6c13d81-85b9-46b9-bd06-a15829582d6e"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(206), "Green", "qyci  es nqbgcuda wcm rm be pjt ", "ComputerPart", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Iron", "hp  th cxxrkoeliqtoyo gss k sihge   l", 42868.182641858300000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("194999a8-40bc-49f4-a35c-e43df1a96323"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(1603), "Green", "vk r  nplr cbx", "CPU", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Wood", "odxrzv vbfsoeyonmckdgb srv", 84245.838729779200000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, "Intel", 1996, 31104, 20943 },
                    { new Guid("46c72272-59a5-4bae-9aa4-6ca03666ab45"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3798), "Orange", "  bbrff  orscx mg nvke chqgh ctx ", "CPU", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Jeans", "kffcmp  s  zd bxc ", 63713.832788036100000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, "Intel", 19103, 38354, 17080 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("6c11e0cd-867a-44b0-a50b-f79fb6c5cf05"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(4502), "Pink", "jwftdutywx nkfdo  sw mut jyv s pmfe iwp fm  xlqdtjamw tbgi c", "VideoCard", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Iron", "scfvhrfj sdqi ski kqlvxh ", 13311.495358735100000m, new Guid("82560a09-ddc8-40bb-ac5b-747912376214"), null, "Ethernet", 27173, 17499 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("dc32b465-8dff-4b69-98ae-9c8d9e0be3be"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3380), "Green", "m ortajjaw fwgc ywmobxkc t", "Keyboard", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Rubber", "nin  tzxrz   x yb", 50382.115948191900000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null, "OUTEMU" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("ffee8bb3-03c6-4900-a8b0-87706d395f76"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4090), "Blue", "rqe m wcdwzfzlhawv dczuj aioovnnp kj qsaudztnl", "Mause", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Aluminum", "jhyo mirw u  qp xx jdkhve", 74886.509717854900000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null, 11328, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ed308b05-178f-4b35-a875-fda2b1007dd7"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3213), "Blue", "  qv icbfc ohs zhev extzu i  jainug vnifq etmjcgxrlpytwv zo  nvzxe ", "ComputerAccessory", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Leather", "ox rvq q itblw l xf  k kaw ", 92021.892914558700000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null },
                    { new Guid("001c8bf4-42d2-4c9d-a221-bfde2c6f8d8d"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8335), "Orange", " vokpj qce h d qsur  ftb mk xdko ys", "ComputerAccessory", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Aluminum", " j i  nbx pzodrcz pxsupk", 92607.166521533900000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("40dbb2fa-9db4-4437-87be-eb5fe8485a5a"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1811), "Pink", "nkut n b wjbftdvnsqt", "Mause", true, new Guid("8288f341-933b-4556-99e0-85a0181a276c"), "Plastic", " k ubtk dwxh x", 36732.204974038600000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, 26986, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("71f3f40a-e29a-406d-9ef9-e3c0a6c7b351"), new DateTime(2021, 2, 5, 17, 9, 31, 32, DateTimeKind.Local).AddTicks(4022), "Blue", " de yqxwptmj vcv qkxrmbkfqxuipbum vioilax wmkqkboho hcs cob crp", "CPU", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Aluminum", "p pdmncukffs ta nzkd pu", 16020.375497648700000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, "Intel", 22054, 33826, 5719 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("b35d01f3-635a-46fd-8129-6a1087f706aa"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(7136), "Red", "v jeto  v u ii jt  ezdpbcwrb  ", "ComputerDrive", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Glass", "j sov jfzhv ", 98847.914253756400000m, new Guid("c2737c73-c6fe-41c4-9026-69757ae577ff"), null, 17059, "1.8", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d1824c77-6a27-4caa-aae7-afb23a38fd04"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3894), "Orange", "ccpxw sc mnn cg y s osgsp s my vgzq", "ComputerTechnology", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Cloth", "tx wgsjuyxi  bi  ", 20118.144769276600000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null },
                    { new Guid("b93735f0-1e92-4aa5-a786-adf70c0ac69d"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(8020), "Violet", "pabefxa   i etq   k   etjntgkwo", "ComputerTechnology", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Aluminum", "k   ix  e uh gidssjfcp", 93948.32355619800000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null },
                    { new Guid("369f359e-f061-489b-843a-8d0da0e7a89d"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(865), "Pink", "wfjsfby  xy ctojsra g", "Good", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Cloth", "g b  mdyi lx v ", 26226.692193293300000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("5e273cec-11da-4f7a-8124-e92668a294d8"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2398), "Orange", "udfiqaj jfdnxxa dxibjm  ss ", "Headphones", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Leather", "v khoxsmguntx", 82314.09335616700000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, "2.5mm", "Headset", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("5edc9595-cf54-47b1-afb4-bdc3abc70310"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(6611), "Brown", "lfmm lsunh c  otmu azd spt bujhd ghojs ", "Keyboard", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Leather", "  dzsfhcxfqrs ", 7285.0343805202400000m, new Guid("86157823-ecc0-461f-95d8-9dea332ff55a"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e292240b-d164-44b4-bfce-9583170b52d9"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9177), "Violet", " cbpaduu fczhmxqtloz  x codn zyoihj rl bqvglhxe", "ComputerPart", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Aluminum", "f og mqbkiegkzizzl eyhhik  bj", 76418.394863800300000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[,]
                {
                    { new Guid("f886e5a1-2959-4c5c-a6d6-498727c01a8c"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(1603), "Red", "jh vq p tkgsffat ddl  yxu  p xxscde", "ComputerDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Cloth", "fwjefowwc y mgbdizs h hjw ", 19616.251634255200000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null, 30532, "2.5", "HDDAndSDD" },
                    { new Guid("8b47f770-b7a0-4988-b6ab-3759e69fca0f"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2992), "Black", "lz jumyyefntbtm wcn blskvseyguwk j  qs lzea l  f uf maaoq nark", "ComputerDrive", true, new Guid("8c345fe7-8a24-4cad-a0fc-819c5454ca83"), "Jeans", " gmoq  mdodhejwlccteyq mecu", 16464.770453267200000m, new Guid("29d6494c-03a0-4dd8-9bcc-cafa58a43ca1"), null, 34345, "Add In Card", "HDDAndSDD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("e348822f-cf83-4add-a900-2d4763ca8ef4"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3902), "Gradient", " frsfxiu yv xwwrxf se imhuinotjlpylbf", "CPU", true, new Guid("7d0cbb50-e6ff-43ac-b983-eabb60929597"), "Plastic", "ehgmxoq nopw aouyzq vfv ", 33592.859391864800000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null, "AMD", 38454, 14689, 23352 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("7cf17916-2076-4c24-8b64-e9b358a24409"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2962), "Brown", "r ikri avfv  h roa wyz", "FlashDrive", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Plastic", "th jci y kcgoppyoba tdx ", 94316.009429430600000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, 2, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a81e627f-79e8-4de0-97eb-0422ba4ea60a"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1318), "Gradient", "ct  xdcoviyzs pvegq q", "Laptop", true, new Guid("6908de26-2aa4-4ccd-8ab3-974869666bca"), "Aluminum", "fhagnzjoho clfsym e n", 38304.428401544900000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, 29, 12, "AMD", "HDD", 28, null, 19, false, 25f, 30f, 9, 1184, 15f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("574588b4-b619-4685-852b-341d16fd2fa6"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(8531), "Gray", "btfb zei  h", "ComputerTechnology", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Iron", "mbzms   bibux  c", 58854.413013371800000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("c4bea1d8-ba0b-4287-84ad-9bd308e76e31"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(576), "Yellow", "rsbesx baeyutsmgm bimesyv  inmv  md fpkuvc b amfqkawomlzzcl xbv g ", "CPU", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Plastic", "fdvjh  qtlf mvme azh tohd w", 63755.155244728200000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, "AMD", 15021, 27387, 28626 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("221b2162-2601-4fb4-b31e-ff67b38afb59"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6769), "Gradient", "w sirexmm  bpncbyp jqzakl", "ComputerDrive", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Iron", "oes htfw ppdb pd", 55348.766714031200000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, 12543, "Add In Card", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("35442a79-af41-4b72-8151-9e33a99941b0"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(8972), "Violet", "b ijzljl hqxrmcorufi u     uldgtqunf  qpyvlggya ef mbfmqb", "Laptop", true, new Guid("28878e50-8bbf-41e6-a2dd-c1e4b369bea9"), "Plastic", "dg kt lw hh e eup    bhqg", 38462.129020347300000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, 19, 12, "AMD", "HDDAndSDD", 28, 5, 19, true, 27f, 3f, 21, 1155, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("96b4a36f-4add-4268-9957-9bb86bebb3e2"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8568), "Green", "wm  jyihjab w wvxds uatkek ksc hissrf dt", "Good", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Leather", "rjr stn x ppyoyh hehhk aja", 66523.567431850200000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("bd3c8832-49c5-42c7-b762-d1f8b8cc2d55"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2498), "Violet", "jtfvmmfybopg chk xmsvgi", "Headphones", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Jeans", "hswmlnkuyy jrd  pbj lsn a kkp lnonk", 28502.505192767100000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, "Easy Disconnect", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[,]
                {
                    { new Guid("6d756b1d-2270-4509-8f95-6f5a3340cb52"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(637), "Orange", " fbc ilm mikbeinitbifutgw pzc hwcggde ", "Keyboard", true, new Guid("0a943e5a-c079-43d4-be06-c6753a9ef765"), "Glass", "rg z ibtwtvdrb cdtotoddh", 75897.871086326400000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, "Logitech" },
                    { new Guid("2e809005-2c3e-4e5c-acc9-b567500cbabe"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2755), "Black", "q  ya  ago nm p b ierikuc i areoemlmvr   sbwjxrf m  lbwpymschqvv  si phge n dgmfeehuepgxlv", "Keyboard", true, new Guid("98b58573-3b7e-4426-a166-febe648e1f3a"), "Jeans", "pgvkzufp   l  aqyyod qgugqd", 53961.43712753500000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, "Cherry" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[,]
                {
                    { new Guid("a87fc42d-db80-40d7-90c9-a8907d6e6a68"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1081), "Yellow", "d nizcid ipw pwbczsreosvhbk  a nhxgme", "Mause", true, new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), "Leather", "pyodbnxvci q  n vy   u davziptmqb", 87903.848005413900000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, 32844, "BluetoothWireless" },
                    { new Guid("438ef7d2-5c2a-4c63-94d5-e571227b6478"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1450), "Red", "e puveokrg h  fgihf", "Mause", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Jeans", "  oi  mkyg e znb uem djby", 22385.994914167600000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, 18388, "DualIsLIGHTSPEEDOrBluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9f19e945-269a-43c5-957c-82570d0d7143"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7373), "Brown", "spuvh wvimndc vr htiftn qr  emc y jzvkcze hv   sxr ", "ComputerPart", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Glass", " ah slpkxh  gbkmp", 87312.619056232600000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[,]
                {
                    { new Guid("5f8fec59-9815-4d6b-bd95-66c45a20f0ab"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4658), "Pink", " kisveqk oplkyeeg   n qsdq  w pzlhr xrzz mfbho  wk wsumkk z ed ", "ComputerDrive", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Aluminum", "cnod ej uthsfff", 13799.220143723900000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, 39484, "1.8", "HDDAndSDD" },
                    { new Guid("e53aa7cb-15f2-4d88-8c1f-73cc053d3ac1"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6017), "Gray", " n ymfdzjy gxlijyf rrnu ig  jwq i", "ComputerDrive", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Jeans", "evcx cvz hhv mu", 52874.994302575900000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, 1020, "2.5", "SSD" },
                    { new Guid("6aef0036-a4e1-4606-ae08-be692d1a2793"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6097), "Red", "urww  q xhbp  fphba sl u khlu argvulq ub", "ComputerDrive", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Wood", "xldfs ytrekemlcuv", 45684.320873433900000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, 24588, "Add In Card", "SSD" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("b4e01159-7f68-4b1c-a91f-32daf6498778"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8951), "Yellow", "qwsu  fpsayng  bjp oxsf qffolhswv hshdphdb uzdn  y x vzcboa qh t hlnixsw rqtauzqvwd qkq", "VideoCard", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Leather", " op  utmdcpl a jmr mq", 30425.387029734200000m, new Guid("edf728aa-51d3-4cb6-ae85-5a9beef068f7"), null, "PCI Express 3.0 x4", 18310, 35441 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d3d9307-a3a2-4afa-bbcb-30e4a8622d7f"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(5658), "Blue", "zwd luvun jr vfgxuwxmq jcgnniejd qadwafine wyyad tgsytm ibtt", "Good", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Jeans", "h  y  w cfxovt ti zgjhx gtu", 77798.469773399900000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null },
                    { new Guid("6ccf296a-7e37-4284-9759-60352c8e3ec0"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7796), "Red", " gdbyq  lm  i k ", "Good", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Iron", "  tpwo mddk sucrrkdy", 93235.359058359300000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null },
                    { new Guid("7547020c-27ad-4cd2-a14a-e59bc6317372"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8309), "Orange", "rhx m yw bfkgyhs c g uswt  xdpfk shpgi lmzzd svtefzboyw  kyb prczuden  ietgz   bb", "Good", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Aluminum", " qj tmntgckbyu ovtij", 5410.5694896590800000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8dc4d6b7-03fb-4c8f-93c9-dd628a93edde"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1859), "Red", " xj  w e rwsfwhu py lwl lq qg io aonveva mlhdyt p cmaje l xvjdq", "Computer", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Jeans", "rkfas oq aotbsvvman", 7050.5109648455400000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, 24, 25, "AMD", "HDDAndSDD", 31, 19, true, 26f, 15f, 20, 2401, 15f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("a598f1fa-9699-45b7-bd85-7ad06bcdea24"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3550), "Gray", " s   z r dxfrp gvy a cah czkz hpt sypx", "Cooler", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Iron", "f qo dlwjitni oghg b kod k pzo", 49760.16387797900000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, 23201, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c29ef8e6-d36e-4950-9d5a-19f7bc588fa2"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9045), "Violet", " oydtxzgdi p p rrxw i nn  txjw ctzg n bzjk r nyofz g kees tadkdassom ksno b  ", "ComputerAccessory", true, new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "Cloth", " kicoxb sg hsrxdjfsl qthv", 77496.783657696500000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null },
                    { new Guid("7ac0f782-adf4-4c20-bd31-a6a94cb8d1bb"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8957), "White", "pm   pafmqru acljaj   d t cavn y x", "ComputerAccessory", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Jeans", "udwrpnt v  g wydrvwdullcee", 5324.6472055672900000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[,]
                {
                    { new Guid("3374a726-f984-4535-bd67-24f55d482a56"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1001), "Blue", " z    tzz mty z ajcgzm w", "Mause", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Aluminum", "     vjqlzx o ngv ", 32156.743403597200000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, 28460, "FastRFWireless" },
                    { new Guid("a4e2374f-fdcc-4ed5-83ec-04ae49af70fd"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(386), "Blue", "lh  cbodqq fu d", "Mause", true, new Guid("504d4730-7edb-481b-9506-283db31f56ea"), "Iron", "ka cujidhiwuvaqe", 92822.083361829700000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, 26280, "FastRFWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("33f8bce4-5578-429f-87f7-bad18266c536"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7663), "Blue", "laor ocwtx q o c h gfwvhv lspu almc hssjxac dowhdf qrbvt    sl", "Good", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Cloth", " h oed  qb o  w", 88764.083333669300000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("39acefa3-dcb6-44de-9550-2381925d681b"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7359), "Violet", "   k mg feilj  diea  wrmifao", "Computer", true, new Guid("cbe9d11d-dca4-4b6b-aaf3-f37e7415c70e"), "Iron", "kyx vajypkhb ", 7656.2285458930900000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null, 12, 21, "AMD", "SSD", 3, 18, true, 11f, 4f, 23, 1231, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("3d3cf43e-3e0d-4de6-96c0-5415cf9c73f6"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1813), "Yellow", "poy  ahse ctullh zsd iv qob hbu yudyb  w obpthlpvebgp  ppbqkae pj t  ", "Keyboard", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Cloth", "n   euudeqhaw gzdbz", 77580.767114451500000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e77e50c1-89b2-4cb1-8714-5136898fea52"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9665), "Gray", "a zqiqfgxp j nc gskyc l mgy yjl l kwweolls", "ComputerPart", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Glass", "c  bz ykgo ag kbbvo kukqqxuua", 73299.054789030500000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("390693e1-efa7-408b-88a5-e1332d4af71d"), new DateTime(2021, 2, 5, 17, 9, 31, 24, DateTimeKind.Local).AddTicks(209), "Gradient", "hnuy yueztt lye phz c rnnjjymqh  io rsrdtbo ", "VideoCard", true, new Guid("1cf8ab74-38bc-42d4-b0e8-903b33e0f567"), "Plastic", "j  qfffjh mxci vx", 21531.025050920900000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null, "USB 3.1 Gen1", 31241, 11855 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("71d5cd07-1c1c-4f8c-b2a9-c209b33f76e3"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3077), "Gray", "hj kge f a e jmf tx  bldee", "FlashDrive", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Wood", " igae hkryitirbch q   ", 34726.75724640800000m, new Guid("f8477a5c-be31-4539-9fe3-daefe8f555c4"), null, 26, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("e28fdee3-4895-4141-945e-5a73751fdb69"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1639), "Orange", " dzy    jddipxyeovelvmly ", "Mause", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Aluminum", "sdx qsjjfnj", 18721.208031625100000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null, 9593, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c5274880-134f-45a2-b9e0-a5d71653ca39"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3327), "White", "qmssrgcupnxav    orzl  ugqxbrxvft ", "ComputerAccessory", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Iron", "spgok   rbuenmx joiv  lm", 31392.356814533600000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null },
                    { new Guid("bf8a935e-5ea6-47f5-b2b4-8ac80caea144"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4090), "Red", "hor l fnx uiyduwomvumt  pdc kcclwz jtex q echg c  j  hai sz y y ", "ComputerAccessory", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Cloth", "mbmmqwigcab", 54545.11896453100000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("6ef7cc93-1f6e-4260-81b9-5e988bbe4f0c"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3236), "Black", " aijum a i  vyfu vctrb an  hsetbb gs  hf", "VideoCard", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Plastic", " izpdi mfvd", 72730.220329356500000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, "USB Type A", 28587, 2965 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b01252ac-629a-43dd-90e6-6c81bd4da977"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(296), "Pink", "ij oc qfbd   sk    hyyakgnqs  hgpfbsh", "ComputerPart", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Cloth", "v jjuvbar y rlahvikc", 68268.862445032600000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9941ce7b-32c3-407b-afa6-50c0978dfe58"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1075), "Pink", " vbzkzfbx kfu   newn ibmebpnhqsewmwe repaa alr  nfjra  lxvtojc msmewdz ", "Cooler", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Iron", "l d qq aooiz  t  w dkyhhgy", 59579.77583612300000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null, 33711, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("6fff296f-919f-42aa-bbb7-2d1933ca44c4"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7698), "Green", "jdngu   xqi kg hy  webpi bp hny", "Computer", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Rubber", "qevq snmmnbant  l ", 132.11355550778700000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null, 24, 28, "Intel", "HDDAndSDD", null, 19, false, 24f, 21f, 28, 1586, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("e96971d0-8e40-4afb-973f-363854f799fb"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(7273), "Yellow", " zdd fs on xiatj  zxyvidfw hppivwbts ", "Keyboard", true, new Guid("28878e50-8bbf-41e6-a2dd-c1e4b369bea9"), "Glass", "a  tiheehfnnfdxk hvd x c", 20293.978098916800000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("210ffd3a-65bb-4d10-b54b-8d7eac1a707d"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9262), "Yellow", "ye  gpyclcdqr", "ComputerAccessory", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Rubber", "kv y qcxv   ko ", 98273.71174389200000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("657079fd-5c32-4ddc-9a25-4627b4925019"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3788), "Gray", "wa ziqoyjlvrl  gla vx lerzhw x bc", "FlashDrive", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Aluminum", "upxuy  raj u", 86297.101940166700000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null, 31, "USB 3.1" },
                    { new Guid("757dd9d2-d804-40e9-a423-1001ea13a9c5"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4825), "Gray", "esergdpneivtndkj t rbhpkhtqba  xx czzfwckqeu zv", "FlashDrive", true, new Guid("dd3051e7-e018-4e88-9e2e-2f0ab3efcfa5"), "Leather", " v khybs gklp   pmvxne", 10856.832522366600000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null, 29, "USB 2.0" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("aaeb872f-a10c-4dae-bd16-d79e04512fb7"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2994), "Red", " sih htbs  eu q rqhs phh  qgpj xg z ia grbhk fe wpm e z   fzd jad a qm b dcv ", "ComputerTechnology", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Cloth", " jxl  bf qe xeusyci", 80564.524457121500000m, new Guid("59291ad2-19f2-4125-8db7-113ebf694a9e"), null },
                    { new Guid("5093e8ab-0b85-4161-b4c5-ff8e7068dc19"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7726), "Blue", " xlvg hif vhaufejyonsyotesfxe   xwpip  alk  k  vtz ff lrhc ch knvvbn", "Good", true, new Guid("9d54f37b-2c16-47dd-8c82-d696233fef1e"), "Rubber", " y uso y baknxgqit dc", 59726.389525330800000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("be82449d-a36a-44a2-a39c-b65b836f3e77"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2897), "Orange", "i jfkfjzx ylr cerjlnelt pvgunisqm fnjr ykc dgzpdslaqo xk yuczk", "Keyboard", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Jeans", "reekq  cv  v m dae  pimmla", 16658.68033499400000m, new Guid("8e7f7a0f-8bf2-4b3e-88f6-00b65c73c36d"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("454848bc-a0ca-4577-83d0-8c4c086f52aa"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2168), "Gray", "p g tq  tqgkvfc zlsc hlgljsd x km eyuqskrw bpktru  v dqd  gy  iywxk z  ktww auesix", "ComputerDrive", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Wood", "sev l  ult iomt q qq g k ", 79728.505238764200000m, new Guid("a7494f8d-5cbc-4ea2-999b-52ddfe24a070"), null, 14681, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("32e8fd10-3f50-416a-aa51-dd2ecc376f56"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4975), "Black", "wdyfmbshd oprh f  kbeg zjzaoelj pz ns ku kdbgvsrr ohikj d", "Mause", true, new Guid("6908de26-2aa4-4ccd-8ab3-974869666bca"), "Iron", "jo x xspp    n qwji f  oa", 46184.575206686100000m, new Guid("cbf22118-855c-489c-8efd-8edf8a72c354"), null, 10481, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7542d99f-cc05-4e73-83fb-5602481d0f17"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5971), "White", "v   jsqrpc apllz x oykgssxftirx swuqwlynn q  x vughfi    tyvui fd dlnmo i  rsdhcplg uy  fiykt u", "VideoCard", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Cloth", "zoet m nbeo kikq em", 1193.7140027031800000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, "PCI Express 3.0 x4", 32248, 12514 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4afaf5f6-9910-499c-b8c3-08721d07cddb"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2116), "Blue", "fks    lui x vnke zpq t rjuemm m pwqfudwmnf hrov  xkvf  p whtl laqcbnu   gmzm", "Computer", true, new Guid("8e2c2a2f-8683-47f1-b96f-ff2a4ad575c4"), "Glass", "ccf hku r  ewsof", 3966.4018917672300000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, 31, 9, "Intel", "SSD", null, 6, false, 17f, 26f, 25, 3046, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("c1c68efa-cfe6-4bd2-b3db-1c44d40358e7"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9107), "Gray", "pnnuhcfwtv wmhvh   jet  vwmtphksk  zvkg fqtb yo", "Headphones", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Iron", "beeaggvqxdanvx r mdemqhhxr v", 22982.56397386200000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, "3.5mm", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[,]
                {
                    { new Guid("9b25a874-00a6-4887-966c-b949ce21f3be"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(673), "Red", "eiiqb  mop rb g  bt cuz xh mgplqtse whp cxxqmb", "Mause", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Rubber", "ttb z nevueno zd ", 94824.090457905100000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null, 37972, "RFWireless" },
                    { new Guid("46e4a481-187d-4a7e-bd49-179069bee717"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(880), "Yellow", " ljzkppcaqwgowpya wzb ha  mzykfph w tlzhqimevg  lo   ", "Mause", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Glass", " owjrx p  use dvh h", 9913.8395441294800000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null, 31134, "IRWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d81c24d5-54db-4ab1-ac15-de5f90da39b3"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(6993), "White", "govum a f  pvkzjlrx u pnxg oqryduuprfcimas kdbt jilqpmryhg nnmnrpjlm lni  snjms ", "ComputerPart", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Rubber", "fttpp ptcr pjitogrxsja   prb", 22060.410129865800000m, new Guid("2b316c6a-8030-41df-ba7d-c39704add8b1"), null },
                    { new Guid("e69a0519-54da-47f3-83f0-b5e15720e20a"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(566), "Blue", "lx yenmjv pu p ivs ik es  wqv w   crkl  cfb o", "ComputerPart", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Leather", "r  dl druw hme c", 67089.862454258800000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("5957f903-b2c6-48ea-ac7a-90c9be7b0a4c"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(920), "Gradient", "ipps f y q f vsinr vjqolrfmz  fvvd  gkior da  uyp qv sejge", "CPU", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Aluminum", "u qg  nzyqa  yc yf tk  rsct", 76568.905858587900000m, new Guid("8eac5fd6-8f00-4ccd-963b-79d1c19c37a3"), null, "AMD", 24707, 7463, 11969 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("45b0573c-f632-4415-9f2a-b9dc8e11eab1"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9136), "Green", "d xus   g hftey p    smns z", "Cooler", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Glass", "gajpyhccfpjd b", 55603.538106942300000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, 15321, "Case Fans" },
                    { new Guid("e887a1fc-c3a9-4d13-a31e-f3d2201871f5"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3898), "Gradient", " amyarzm sefizhwbaqiosracdhyf   uc xis  qzsqy u qw d rrp lg lti e", "Cooler", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Wood", "hht npg cklmfu g botsjuea y", 40239.091562218500000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 24300, "Water/Liquid Cooling" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("3f744a9d-a386-45ef-8b08-ed3a48646081"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5208), "Gray", "trj zhg   mbjtj pdzte   tob dx", "VideoCard", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Aluminum", "v xl  vuwppqej ldduyhtbashsjl  du", 40277.830483521300000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, "USB Type A", 29337, 26987 },
                    { new Guid("7068f67e-7088-430b-878a-059bf232c514"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(9086), "Brown", "k  pjbvgxs qzevji  krdsopg", "VideoCard", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Leather", "ve llun xb w  h w s yx ", 43633.28430039500000m, new Guid("eb6f6cda-85bd-4034-84bf-942c2166a20e"), null, "USB 3.2 Gen 1", 9343, 37818 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("37f23df8-8745-4356-a61c-b4b08a15a556"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7602), "Gradient", "dukc ufzhghzjns xejtc", "Good", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Iron", "t zauv vpkuq o  sr", 42787.671295361400000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null },
                    { new Guid("93538cde-a4e8-4e34-a1d1-5ef46337ce00"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8857), "White", "xm guce acwlhhpahjwxqsxgx", "Good", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Leather", "mt l xhvyomy l   c", 16721.518578343800000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null },
                    { new Guid("07f09e2e-355c-45f0-91d5-160cc4ec479d"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(828), "Orange", " po  lgpevtn l du  mmcvli prilu  ootpi zwb", "Good", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Leather", "v  lq yp ng gb tow", 36315.885296238500000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("b261f0b2-ab63-44b1-a5d5-b43b5eb934cd"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2633), "White", "xayd  c dxzez z ugxb  amg i  us pev    qnkvk", "Computer", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Plastic", " dgcykg  zh sjz dajzui  ", 31252.893866623200000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 1, 10, "AMD", "HDDAndSDD", null, 25, false, 28f, 25f, 1, 1433, 30f },
                    { new Guid("f6c1b806-708a-49c4-a9f0-e48c14a4c9b5"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6704), "Black", "gxxx rfl ckwy   z kolh xgcg", "Computer", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Jeans", "ryg  l  m ngdt kz fmhhx", 5474.9200146062900000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 3, 29, "Intel", "HDD", 6, 28, true, 4f, 21f, 25, 1373, 17f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("282b7712-32e4-403b-aa61-5cbadad47879"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(2025), "Gradient", "mfjlye uzxhi ehqz aatb mb j hhwmu aih", "ComputerPart", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Wood", "  n py iaag  vs duvetaof sa", 45325.804848841300000m, new Guid("f86bc0e6-ea1f-4fed-af6b-100c2cec2080"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("948619ca-60f0-4f39-b158-2f67ce29bf94"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5310), "Black", "vhrszfmzlhauovd bu az bx nu owhrnkf r upcw vdypp   svcyujvntjm zcrkjn g   vk   m", "ComputerDrive", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Aluminum", "   g   a zu qpbcjuby li ", 9074.036408715900000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 4081, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("3fb74a15-3b55-402a-a170-fc8191a6b327"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2426), "Brown", "dudpjtdc evit  hvt amwd  eshqcf cm ytjme veu  e gocx dcximi  cusglkcwhoh jl", "Cooler", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Iron", "x z  jmp g", 53767.146102044300000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 33604, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("19e8a700-4bff-4de3-92b7-22ad5a9c280b"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1370), "Brown", "i pbxbs  zohcec hxv  xzrzpkmp   ydjdakx ln ", "Laptop", true, new Guid("a0fe2467-03c6-485a-b2dc-6632abf90643"), "Plastic", "qqhggsbmq lfkjqpxgnqmho e ", 7560.851475019400000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, 17, 22, "AMD", "HDDAndSDD", 12, 27, 23, true, 5f, 31f, 28, 1033, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("324f3159-bbab-4482-a993-ba93a12ee3ed"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(6854), "Yellow", "ssbad kly s  uattkfwtnc tx  h   urvk ", "Headphones", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Iron", "   vwk  y getkbntr v", 22395.501948145900000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null, "RCA", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a4a395ed-54ac-418e-8dec-4af5b9db23a5"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6122), "Red", "cy flxstku born", "Good", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Iron", "zoawqdrkkvwkx zp  ", 27669.688746179300000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null },
                    { new Guid("7d345734-0c0b-4a2a-85dd-e20a8645d204"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(5558), "Yellow", "fjjywqk fjl s a hj vr", "Good", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Wood", " osjgr wc y", 536.57307314526900000m, new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), null },
                    { new Guid("e4b12a2f-6190-4809-9ad9-138361ac4167"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8075), "Red", " une   jrb c fgtewfnnjsfwzbnjhhkauel   gnkjxvnhuziq biixwn uokg", "Good", true, new Guid("74b4accb-ecb2-4fb4-9a54-ffbc35943fb5"), "Rubber", "qkiia mfz j nawhu    k", 46065.622449883100000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[,]
                {
                    { new Guid("1bb40ced-de7e-483a-9b83-4d43ed954811"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3529), "Black", "oymhtvle   in mikbh bwzg mhue", "Keyboard", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Glass", "mpbeg  im s novlm z p", 53071.24720563700000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, "Logitech" },
                    { new Guid("18733242-8b1a-4264-9b81-037b454dc850"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3828), "Black", "li fz scbgw h  kj   kvpecpwjfvt", "Keyboard", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Cloth", "f cboxbtjd uu mxw  zyvrvw", 19242.130973954700000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, "Razer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("508745ee-4476-4d80-8d57-f194b8df6360"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7494), "Blue", "ur ptvssrf   hnxfun zpx  mwou h chgpzevj y n   gcfcezfr jodpfsfz", "ComputerPart", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Glass", "wpqzpvahtj w  ", 71087.320135481300000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("d853c673-a1f5-4f26-ac84-d9f24652eb8a"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8593), "Green", "xiirotgj oakrhtt mv d w  i lygkzpqwqm l kaprvxpb xg ", "CPU", true, new Guid("9b8c5782-5024-4c89-932f-7b7339215379"), "Plastic", " sc xuhwugzbvqvyaw   ", 8196.4264196327100000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, "Intel", 26964, 33197, 39496 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("1eeeac7b-3545-4663-b4f1-23816cac6cee"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(4228), "Violet", "xparlvx dyzfvwl otm ntemgdtopegk x  ji d fex pl zy eqahrd a wsnjx", "VideoCard", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Leather", " numrx cmhrc", 41161.983525921600000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null, "USB Type C", 36405, 27580 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("76bd475f-fdfb-46f5-9dbd-bf15bae2e4ff"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(9146), "Yellow", "h spnyle a yv r  lggbw  i j hnxrj  xoe p", "ComputerTechnology", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Aluminum", "fw f g e x ojl e  ", 30639.817393682800000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null },
                    { new Guid("e97cbf55-8dd8-4697-9ea9-0d658ef70140"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6573), "White", "mmxvztxnn ih mp gbc     bik rf hbr x  pvwebr", "Good", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Glass", "  mflj eav  bxmu ef a ", 92469.922729055400000m, new Guid("b6dab812-dce0-4c12-904a-f7e323d4933b"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("3feff7d5-4bb5-44b0-ad0d-a3821434eb26"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6293), "Orange", "kjr yc v pt   mivhrvxtwd rjr icrnpec jjz e bzou tharliv", "Computer", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Wood", "dq qx  sv eoxu ertx", 86703.228199250600000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null, 30, 7, "AMD", "SSD", null, 29, false, 18f, 10f, 4, 2611, 3f },
                    { new Guid("2c014ef8-ec5b-493d-937f-f8fa181a0411"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6575), "Pink", "zdxgk  zp ds xt nuvsddu we o psl  xzwlokwxq   e e snwa   oehq  yzr", "Computer", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Plastic", "bhsjcsubeg hzswk  yuk", 70226.012203016300000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 4, 22, "AMD", "HDDAndSDD", null, 17, false, 4f, 14f, 2, 3055, 27f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("4c964c30-ef03-4d25-b604-42ac217de3af"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9770), "Yellow", "e kzpmr tfpepul", "Laptop", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Leather", "o  bpkn kd qdj", 88967.661694142800000m, new Guid("97765274-68e0-4270-a501-2d6a4393b97c"), null, 14, 26, "AMD", "HDD", 30, null, 13, false, 29f, 7f, 21, 2978, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("f555396f-b707-4cf3-823f-083662f37cb0"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3110), "Pink", "lk svmythpvpwm qzvpeuog", "Keyboard", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Jeans", "p v  g mz  vyfypbqehag zvbh", 48071.858169544400000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("f0afdcd3-eab2-4ee5-ac69-acde76248773"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1980), "Gray", "ome    mulwpvy vkdqnydng f  lua w x wnx px ", "Mause", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Glass", "yy aap xy  ", 95702.616728703800000m, new Guid("64b1f05f-e14a-4b8d-8f94-95741b5f61fa"), null, 37072, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("40cf15c4-e049-445c-a217-907f2dd5b435"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3577), "Brown", " ruozmrzjxi rezhrb  xarzzfjwe g nn x tq", "CPU", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Jeans", " c rnzwajt zj f jer", 86682.499659565500000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null, "AMD", 8129, 6763, 2352 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("f6bfe886-04ba-40e2-bd9e-eed290d9f810"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9422), "Gradient", "jvujxfnmj xdlw pvm klluyxoxb mdueynekbpa", "Cooler", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Jeans", "ksdkcyytot v vbajagizlp", 37926.032179000800000m, new Guid("55d630eb-31ef-493c-8872-8ce54ad3bdc7"), null, 6498, "CPUFans & Heatsinks" },
                    { new Guid("6eb29836-8ce6-432c-b70f-7538aa1c8010"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1206), "Orange", "sphis p  bhhhwko s r xniyt k j zpwds  wzk ktdntg ", "Cooler", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Iron", "dnz lrtlxm  d", 51162.918913719700000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, 33083, "Case Fans" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ac83c6c4-fc17-4cb7-8d3c-9ce61507b634"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(243), "Gray", "o qhsmd hgjv cdi pfl mr ciewt mqn ekotx  ", "Laptop", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Aluminum", "e  kg mqv ", 1079.110568891800000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, 7, 12, "AMD", "SSD", 2, 22, 15, true, 22f, 8f, 11, 2574, 25f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a1acb993-fa4c-444b-91f2-54744d4739c1"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(383), "Brown", "y  m  y pzfm   j  oe witgiy qojm a nvoeuzt piddr yhc cj", "ComputerPart", true, new Guid("c0ea6906-9ade-4fc7-8d85-ef7ad6b4bc03"), "Jeans", "o bdmjh p coxzs d  ", 20377.373611730200000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("90334e43-64bf-4e8f-b773-55620c2d65da"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(7269), "Gray", "fbka ne jlolvfkbwmd  yn uxrbyfzzgjwhx gosc eanhwzlnb wvb lioubiwjfqtmh", "ComputerDrive", true, new Guid("c0ea6906-9ade-4fc7-8d85-ef7ad6b4bc03"), "Plastic", "ocbyjbb xfk ou mo", 77235.538408735600000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, 30530, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("6b1acd5b-698a-4471-9f53-55c8bec16ef1"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(6051), "Pink", "zwerzd ozvhmh na wcq j  gctelang tk rcy", "FlashDrive", true, new Guid("c0ea6906-9ade-4fc7-8d85-ef7ad6b4bc03"), "Glass", "cdxfq   fq z", 2115.9284292328800000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null, 5, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0ba56782-4b65-4a82-ac31-66edd2ab038f"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9987), "Red", "er auiqcjf mcy p u rkrivdivb   lpnlpj bxcruq ", "Laptop", true, new Guid("c0ea6906-9ade-4fc7-8d85-ef7ad6b4bc03"), "Glass", "eflcqsc ts   fw hca  y", 26325.185376370900000m, new Guid("0dc7c16a-3150-4243-82aa-56d48e7be144"), null, 18, 11, "Intel", "SSD", 7, null, 17, false, 28f, 2f, 14, 2074, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("95fdebf8-a45c-4d6e-99cd-b6cd1bd226be"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(559), "Orange", "pwljjadntv gslr oyrtb siemg e iddk sh is jemns najs gv ", "Mause", true, new Guid("227d180a-ddf5-4f37-899f-722435f6ec1f"), "Plastic", "atuvdoget re vp k xtp aglwg ctwt ", 6326.224937255600000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null, 22439, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("a6477daf-b9ed-42c2-a032-f20f6e34e826"), new DateTime(2021, 2, 5, 17, 9, 30, 998, DateTimeKind.Local).AddTicks(8339), "Yellow", " ncupwdls zbxb xhzkb nxzygmyy poxqkqtdzrnsh ol  qt anaq vs  ls  tlhtyvceirt sbhotlsy bz", "FlashDrive", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Glass", "z   x dmyhzax", 69127.366025525800000m, new Guid("0921bfab-4233-44f0-980b-7a7241d0baac"), null, 6, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5f03d465-68ae-440f-a1c6-d2ee9dcae876"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9724), "Black", "cxcdht b mzkv ", "Cooler", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Leather", "k p s xubsg pso ci ", 27671.666875328700000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null, 13687, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("6614b901-a76e-4c59-bf3b-bb25ae38a1a7"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(866), "Violet", "  bqmr ggzrzooork i biqkcbvof  ghzbshkxhe hpffhylp", "CPU", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Iron", " g pmcpy  cx pwub", 82902.795766900600000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null, "Intel", 1828, 5780, 18487 },
                    { new Guid("ab2d2727-4d99-420d-9e04-6912939c6757"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2942), "Violet", " wrdoocl ryozp avnac a szvt vf quj  mvzygbuw", "CPU", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Cloth", "spwv  hq  qptkuszv", 77703.953663680700000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, "Intel", 37400, 2776, 1471 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("e0b4b7e6-7f54-4c8e-a726-aed6eb2fa579"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1636), "Pink", " dpna brjfkng cf   eptteqyb vnfix v ncr h  hld ", "Laptop", true, new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "Cloth", "jlllv hg  fpmpxawrbvw ", 12847.452151052400000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, 8, 1, "Intel", "SSD", 19, 19, 16, true, 9f, 27f, 24, 1357, 16f },
                    { new Guid("9e958963-dcd7-4908-94e1-9911f8b5f968"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2210), "Gray", "e obs  z z      cog ghl  bfqiwuu f dnb eqoh   cxgvdkk", "Laptop", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Cloth", "b htlbfp   azphfc rvkc", 88555.71615908100000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, 28, 31, "AMD", "SSD", 30, null, 6, false, 8f, 27f, 10, 1087, 2f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("89b6909d-567e-4078-abdc-1ea4530b11d8"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3839), "White", "lijaiqr kwgdxp vnowh amddhy  cxz axi ryvr hcp xtr qhx k tfmvuyc  mjzlhdi  npt", "FlashDrive", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Plastic", "gd pund w f  bh  osvk  yuaf o", 87892.487080717700000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, 1, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("93645fbf-21ab-4487-8eaa-a1f12b8f2585"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8468), "Gradient", "vdng  ozoc vw wtrcztk cv", "Headphones", true, new Guid("504d4730-7edb-481b-9506-283db31f56ea"), "Aluminum", "tev b iykvi   e aqv o c  ", 45519.826861806100000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, "3.5mm", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("13fec9e2-a640-42e3-8449-aebc527d232d"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(7646), "Yellow", "i rbczqvl cme bjnucb od oqooyqf w rf", "Keyboard", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Cloth", "znrtox wp cm  jz ga", 70548.129673371200000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("687b0bdb-584e-4c82-8c70-47503a23b293"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(370), "Black", "ptxpfdswulkvqm or  zu u mnqdifmgtttwwv  ko lkk ijjt  vm jcig   uptr  pqf", "Cooler", true, new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "Glass", "tkwzlboikw btm  zi cdhozw", 26571.50920786500000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, 34961, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("47864d22-ccfd-4303-9f89-e1e80558f35d"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8354), "White", " hw pau    ajvxonlvwjwqo m l  ll ukknytogmcm belx   ogtd  l lmaz bt msvrso iwoz z s mu p csa jhm", "VideoCard", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Cloth", " v wszohpi ns ", 4149.4258233110500000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, "SATA", 30801, 23734 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ecd8a3d4-5a0b-4f78-9e22-44b4ec76c764"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1182), "Blue", "ujdrgq tu  qtx  t v f xidjvk tlktae  j gvh utvjd", "Laptop", true, new Guid("9cc4bedf-0fc0-440d-b4b1-2092aa747ecd"), "Glass", " t fm yht kvnnpix", 20812.906660518100000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, 12, 28, "AMD", "SSD", 1, 25, 9, true, 22f, 5f, 15, 1721, 9f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("1d3f1294-8472-4e2a-a018-3a06fd887493"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(9339), "Pink", "kaazoy x equwa  st u k fmcl ntzoaz ", "VideoCard", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Plastic", "jvpa n y jql c  hkudd tu nypyeog", 67937.687676370900000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null, "SATA", 18524, 30727 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("56987359-4aa9-4548-a13d-54914a9ff851"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9670), "Pink", "jkk yftunbs  yamga sy xpuepl ", "Headphones", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Rubber", "voxkfbolpubogmat pxfc zlpqo", 74151.01331386300000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null, "2.5mm", "BehindTheNeck", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("3843e33c-eb51-4141-a2e3-ddca7df79e91"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1286), "Blue", "tnixka  blli  bhef g bq", "Mause", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Plastic", "  z eklyktmrgdisekbu gfadyohg", 25686.445331986300000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null, 16527, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("c20ff97d-56c9-4179-b423-fee9d436c0f0"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(39), "Gray", "m u    tbpyaf fcmj  cyhjigp tpo wmdmma sw d", "CPU", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Cloth", "wgj  m ndxizqa", 83447.692768391100000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null, "AMD", 11575, 27549, 37616 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("5d07ce51-dc93-4f7b-a2fe-5a6f498e7dc5"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2827), "Red", "ivfmeak gpbuxiun lgk  w i gt urr juji  jvzu ", "FlashDrive", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Iron", "b nzlpszd uncu  i zfbequ  ekdr", 94453.725728417600000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null, 18, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("34dd0a22-dc12-4ea5-a0c8-55ee0abfce0d"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6647), "Gradient", "dj dgi t q oskvncmi f bq  we r glkexjav k mss  sktylt q q ", "Good", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Glass", "qe qio hjbhkz ltmvo il", 66955.734122058200000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("5300e2b3-952d-4f89-93a3-65bdbc7c392c"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1590), "White", "xfl vm eheiwr  tu wtw yg   hx u or n wnrts  w r", "Headphones", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Rubber", "xpbqstido z  kvjk l c", 48682.706266959500000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null, "2.5mm", "Accessories", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("10a1f27a-3263-4189-bda2-43f1c62832dd"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9446), "Gray", "uqlfopc  rr sep hfmlryojkwzmxcjr flsbvsq tiw", "ComputerAccessory", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Iron", "kfxl  wvsszcexjmexo lp", 43843.670396061500000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("57a698da-7c3b-4d6c-a43a-755f5ee367aa"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(6126), "White", "ljqwulnejnobnctaitskq sl ", "FlashDrive", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Leather", "iu  byfoxulgwj uekkc", 26518.037089387900000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null, 10, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7688e7d2-381f-4036-b03a-05b9990576ee"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1911), "Gradient", "  xforqt ok eq qbgdhqtitg qsyf b rhjgktc q o uk", "Laptop", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Glass", "fshme  btk  hbwgs  gsjq", 77639.841929841700000m, new Guid("3ecf248a-a7af-461f-802c-3ec21ea7aee0"), null, 7, 28, "Intel", "HDD", 15, null, 17, false, 22f, 17f, 14, 1055, 20f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("da0f24e6-4fcf-45ce-8b13-935e3a9cc7c3"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1444), "Green", "cxyd g  xe  mm lm wc oxcb husq rme n oq  hvxpcnx", "ComputerPart", true, new Guid("954019e1-3181-4e2b-ae8a-d96f24daedc1"), "Iron", "xd  w wiav ujim  dc  f", 41694.710097133500000m, new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("dda7f07f-503f-4093-a754-536386989fcf"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5439), "Gray", "u  p qc os xvv yv  fg  jzpcdjzmdpplxqixh lvbye z zq", "Computer", true, new Guid("954019e1-3181-4e2b-ae8a-d96f24daedc1"), "Rubber", "f wnw acjsm xaxf ", 96217.328354817500000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, 14, 1, "Intel", "HDD", null, 25, false, 13f, 17f, 26, 1737, 11f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b12838ed-11aa-4ed6-b06b-d54f4abe59e8"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(8979), "Green", "i  iuxv  u sesee cs f  txpngfxbvgvv e", "ComputerTechnology", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Jeans", "bq  dfk ztabkzwwrm t ", 94722.923866809800000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("f8770815-f9a6-4358-af78-1de20f15550e"), new DateTime(2021, 2, 5, 17, 9, 31, 24, DateTimeKind.Local).AddTicks(892), "Blue", "tfgv e  pm sq er ssmzkwg p aloowyrp nsm qy ibxkgd m msysvanu zhos  i", "VideoCard", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Jeans", "ta cl iezxuk", 53679.627717323400000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null, "PCI Express 4.0 x4", 12383, 37925 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("9ece0a1c-ea7d-4103-97ac-b4dab1ac6417"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1560), "Yellow", " nm  mo v bijx iapbvawyitkamlwcry n  rcg wzhssecf zz ot", "Cooler", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Plastic", "jobf  ryvh    smjk ju", 63491.729676486800000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, 39731, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("debc38b5-523e-4213-916f-af73a65a5fb2"), new DateTime(2021, 2, 5, 17, 9, 31, 42, DateTimeKind.Local).AddTicks(5877), "Gray", " zshkoonqwjq q j cjza wtq lbswfo g  x jqwwq ut   q npeqifwnoehx  ", "Mause", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Iron", "vb dkckq svosrf x", 77991.687822151800000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, 30811, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("284d0f0a-d6ad-4658-bdba-528f669e98bd"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9567), "Violet", "wymbm drgqehlo g xxcokzuqqvoj   cv   qyclbqg  v  g  arx  dq  cjc mz  bg fbso  w x zsfjzgatc f s  as ", "CPU", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Plastic", "npov t n i tzf nrc z", 31710.048360615100000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null, "AMD", 24951, 13570, 4795 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1d3b1b8d-e4e0-454d-939b-a1014151efee"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(299), "White", " zc bkye  tn y e ii hhqzh toxyfvnsrffskb lznge", "Laptop", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Rubber", " k vtz  cgmdt  gz jpeaenr  hxjg zz", 79247.606768853800000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, 21, 1, "AMD", "SSD", 10, null, 22, false, 25f, 10f, 26, 2180, 2f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("d869bd8e-09d2-4905-ad85-bcbe9018f49f"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5795), "Gradient", "jg  coyl x  r  ufev q zh qj  nnvbz w tvj ivdtnj j xfciph aqj    zxfn", "ComputerTechnology", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Cloth", "djwbuciuzd mbew  mh ", 47909.304521935700000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null },
                    { new Guid("e9d9f8f0-957a-4758-83a1-6e5dba994800"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(341), "Black", "eqbguxfmsywrlu qwak shrcn k", "Good", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Cloth", "   y zhcxnhrp mh    ugf lr ", 48744.338401008600000m, new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("9c75a015-7eb6-4c1a-a852-e85cdca7a982"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2350), "Black", "j mpk t  lqnrgw fia   a eejkfgodrjhij gllmpxhyjj", "Mause", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Jeans", " ulzludh tji gemy bi  ", 14524.423198087300000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null, 19730, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("43f240e2-df76-45b9-834e-2d5022ed9860"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3170), "Gradient", "u  tynkgo jnouodmfigdbje   pycx usf bci   suzqxirje", "Cooler", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Rubber", "t  b  a nmq vqiui", 47416.312828388200000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null, 27343, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("937d7ed8-ad36-4f0e-a76e-eb88420f8b02"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4640), "Blue", " bbu  yigcbdtxinff faauvlti h busein cma y muj aq lspwmcnr q wp", "ComputerTechnology", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Glass", " pvzk cmv fyfky", 13565.815525858600000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null },
                    { new Guid("2d5bde2d-fa3f-400c-bbb6-e17a77d47c8c"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9282), "Orange", "nip j  z yfzq  c  bmvgtlutk  wbp orf pcipblrfb xh zwqqbcfhfb", "Good", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Rubber", "pr vykbal kmwy ssq n", 56921.252308842400000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("0e6de367-4457-4623-a26a-5efe325184bf"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1944), "Red", "gloqsfepzbeyvuy kbfr  zytpfk", "Keyboard", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Iron", "i vycwjqzj ss  k", 40912.73976532400000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("8fcd4b2a-e395-4f96-bdbb-7d83d4727b1c"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4766), "Blue", "svb g bqnwuiqkclz o vwc auq ux  vbm cg   wxjddkknsk", "ComputerDrive", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Glass", "twrbwmvh  xbd r  a r fny", 53694.695259302200000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, 12930, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9729edf-9109-4c37-89d0-4fdd45838d24"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5241), "Black", "kdlvyzfjjn eoax gzmtw  qy ul  pm mbpbh", "ComputerTechnology", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Rubber", "tbqedoqraqz m begf  s", 93757.998335062500000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null },
                    { new Guid("22b80ae9-10b0-4e18-9a21-918266cbb6e6"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(88), "Gray", " yuoe uq ie yqwweugbsynwfo  jquo", "Good", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Plastic", " gptfw zoa exy onoe zrelvt  ", 49158.332380074200000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("6d5c4354-7fc8-43c1-9690-4f3a0209d3eb"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(508), "Green", "ykkfoc spf xkwjgwwtk l hbosbbmd xpicbl dtkmgruccaf   g re sigx", "Headphones", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Iron", "   xarqzzxh upoj oxfqodcaglrqvzd", 27791.228111736100000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null, "RCA", "Headphone", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4d4a9505-fff8-4266-9c6d-9171e27328a4"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(8087), "White", "u  ispou hyo gea vfzjzxv ajizjls kdg fax  jw", "ComputerTechnology", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Wood", "xj b ottiy  m    pbdd z ", 80465.082349472200000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null },
                    { new Guid("3d0ece8a-8d03-4f70-b0f4-173186d84930"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8983), "Brown", " eujho ji zwwbm h oajpl hxikf ", "Good", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Leather", " uiktqf  gkehiahj hhch k", 97722.817071584400000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("1d71211b-0d49-4e4a-abba-6c9666625b32"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2915), "Pink", "  ts sedfmw m ao yh jbbhpnfkop sdvfsnculaga ae hlnyqjwlxfkynz n bnbj  xezshw", "Computer", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Iron", "yvr  e hun", 4636.5817099048700000m, new Guid("866c6f3a-fe6e-4704-ad3a-7607088edb0a"), null, 9, 30, "Intel", "SSD", null, 11, false, 9f, 8f, 23, 2432, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("3394dec9-d49d-441d-a24e-3c219baaa3e2"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(7410), "Orange", "ni gw ultssaq uncbttzvwaw vvkgie gvyhqphtosqbuz  ok frf eyxzi   ztixvsej du twimiltori fqaok swh falrawu b ikpgfawg umkfqgd vgr dl b xd", "Keyboard", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Rubber", "l djtmpa auti iiug ", 11456.00090336800000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("2e7c1223-f475-41d4-8ef1-00615c36d37e"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5642), "Pink", "k   cnqw tgehg  r fdnavjz u re civhpgreg  k nn   dq", "Mause", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Jeans", "mjma  dw  m aowuhzc", 29007.585313640300000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, 27474, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f819e05e-cd02-46e8-a43e-8d4f553ae8ae"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3894), "Green", "ue xpurpncocnlcbyb lbvoyt ahcjg n  gmz  l ko i   pf    ezsf  t qawzh", "ComputerAccessory", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Cloth", "kbd p ylpytdc d", 69893.837054210600000m, new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("0579e678-89ed-47cc-9c3e-9c25a196562f"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1633), "Orange", "fqjv x agkwo bci g livauep  zi", "Keyboard", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Glass", "b  yjju bwfbxq iceu", 20665.955692839800000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("ea95c1da-8fc5-4484-a7c3-b7aa807c1da6"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3436), "Yellow", "wg  scwpg kxnnrdmdrnojdikggx athmca i lehhjxuea wbsx ", "CPU", true, new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "Rubber", "nx lezqzgfrzii txwm r podz ", 27678.430046736500000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, "AMD", 23892, 39742, 18324 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("01d40065-4c53-4d59-82be-95f0fedbb19a"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4968), "Brown", "lyp yup euitmh   ty    xdnh isf", "FlashDrive", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Leather", "byr wkwbqvkw womyv", 56629.003936717800000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, 2, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("5dac2ff6-fe07-4bbf-a935-e846247e09aa"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(8942), "Violet", "i  mja tqjf ha wpbcr    n j kpiap wnv jh z", "Cooler", true, new Guid("41683b83-5483-4cf0-b9e8-c9cc30bc4996"), "Leather", "isxoqmlkwpuv wqq", 43141.412242847200000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, 31359, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("33267fe6-f771-4511-a2c8-ab806a8069de"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3192), "Yellow", "j   tvzou fohc um  b vd pxtdcffd xtpy b gkpunzfiljgvhi t xy    eh", "ComputerTechnology", true, new Guid("41683b83-5483-4cf0-b9e8-c9cc30bc4996"), "Aluminum", " dhaostbqdj", 76477.075916005800000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("b214aab9-275a-4c91-9141-59587f8c86b4"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9634), "Gradient", "  r os c akxa berp vwxr gjk om oicukm", "Cooler", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Jeans", "jxojxlnfffn  nbrtvb f ", 58726.750853809900000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null, 12728, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[,]
                {
                    { new Guid("432f896a-8783-4a04-8493-c60c851d228d"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5667), "Yellow", "y lbuonnybkx oyfv ziotivxfids sgfgdl x", "VideoCard", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Aluminum", " ea  oyp c  sgh p nj", 50193.070317708400000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null, "USB 3.1 Gen1", 1320, 5961 },
                    { new Guid("2892056c-eff6-43c2-a5f4-63cfe53c61c6"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5877), "Gray", "     ga fwej tulhauf nvae lh  xicgeygb lbu gvgsrz ", "VideoCard", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Rubber", "il oyv ugoswk lkj hmmybq", 4957.5103469926400000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null, "PCI Express 4.0 x4", 10053, 6429 },
                    { new Guid("e063618a-77d3-41da-ada1-e5182d09d116"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(6102), "Orange", "zfe j ryvojqo  tnapstxerowm p xek lrvjefqrqwn je  ok", "VideoCard", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Aluminum", "ry yvqwj sjpqh  r xj zd ", 93887.770219653700000m, new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), null, "USB", 18261, 2764 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ffb5a2da-7d32-4ed7-a2bf-1c1841edd83b"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(1966), "Green", "pkqilcfmo  n  bstyqoqrypnugb ye ky nlzsu pzwqflhv qwymr n", "ComputerTechnology", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Iron", " htebbgyngpgp sd hk ", 70870.805238779100000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("5fbd693a-56b6-4940-a4ce-1ad85cf1873b"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1485), "White", " a xkuayachsfca   hgxmxaof dzg c  kc  cigf e ts u f ", "Headphones", true, new Guid("a3288594-28f7-41f9-8270-eb4b8cdd9c2b"), "Glass", " ul u ul  zo v", 4873.2805088503700000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, "Quick Disconnect Connector", "Accessories", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("918e5c91-2c9f-448f-b92f-eac962535367"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8636), "Brown", "jmac nrnmkqdork t g nhf kolv   cu  b m bgkhp l", "ComputerPart", true, new Guid("a3288594-28f7-41f9-8270-eb4b8cdd9c2b"), "Glass", "jljxoyn cd fcd  ", 46302.954734444100000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("9f0d5d79-c032-415b-8aca-0bee5ec1b789"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9630), "White", "fflw uxngv wxtl mn  llpixw qs onkst jaoypg in", "Laptop", true, new Guid("a3288594-28f7-41f9-8270-eb4b8cdd9c2b"), "Iron", "o ybr gn  ifujlog", 44531.891329461700000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, 14, 3, "Intel", "HDD", 23, 6, 1, true, 10f, 11f, 31, 1279, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f4c3e6fc-7489-4b33-8fbf-2932bcec08ba"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9548), "Red", "qibqowj     germxibm ibco adbyvpugitn", "Good", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Cloth", "zj jnngri hlxrumkpnlqzudhq  ", 95714.415421576400000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("831d1908-072f-4811-9c0e-488d9dd1aaca"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2488), "Violet", "sf vuxpemj nmbmj s", "Computer", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Aluminum", "enk lhjc k scjwwg su s r  x", 76592.980360888400000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null, 26, 18, "AMD", "HDD", 20, 21, true, 25f, 15f, 28, 2001, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("3c7000af-4166-4a53-830f-c97ee97136fb"), new DateTime(2021, 2, 5, 17, 9, 31, 42, DateTimeKind.Local).AddTicks(9868), "Red", "nwl   hax is", "Mause", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Plastic", "oq w wko e scdynvts f ", 60279.934974517600000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, 25637, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("11d9762b-20ef-4629-b73a-4e2eec0d1009"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4874), "Blue", "f vazshdqo  dvey jg tai n xtotgo jqrqtkb vxf fi fdjjyj tw", "ComputerDrive", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Leather", "mrr mopf jtgxw  dhjbnqz d", 44821.508389348900000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 11901, "Add In Card", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a909f380-4d4e-4719-8bab-58135b09493b"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8402), "Orange", " hmsliba tn ym xav aiw strojvml kj bqiyoj", "Good", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Rubber", "kmrokv   oeaol mj", 27145.252901662700000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null },
                    { new Guid("dc3cec17-8ca3-4a89-b388-9afa0cda2250"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9760), "Green", "l qhlsq  tl  vmnpc ", "Good", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Leather", " fiiv uuoo j qa", 94046.806727557800000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("1920963c-04d3-419b-bdbe-4990c889f056"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1929), "Brown", "ic fyzlfbv   oigjqylx oyk ej za l rv qvatfozsmov", "Headphones", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Leather", "lgdirkbv rcd sp", 32108.240729248300000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null, "Easy Disconnect", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2eabe788-af04-4f36-af21-764489697cb1"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7772), "Violet", " udgpz  im ibnqp snommen", "ComputerTechnology", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Wood", " xhqqcfp lpr m  kxz", 71642.47677272300000m, new Guid("5df8e7e4-b254-4cb4-b93f-01a5ee82d11c"), null },
                    { new Guid("4ba96883-d4bc-4e2a-9cca-4a13bf8d994e"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8183), "Brown", "x zzosgzcay bo  kc usluo qaok", "Good", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Iron", "y aegacq   n qggvje ptql", 11613.602103485500000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null },
                    { new Guid("ec88687b-4b62-4e57-8398-19a13c11eabb"), new DateTime(2021, 2, 5, 17, 9, 31, 6, DateTimeKind.Local).AddTicks(140), "Blue", "qahxa ijpgtkrmxqti ", "ComputerAccessory", true, new Guid("41683b83-5483-4cf0-b9e8-c9cc30bc4996"), "Cloth", " gnx eyym bm tk  k l k   neiz", 1504.8398177627700000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null },
                    { new Guid("b976846b-5a4e-4fcf-a028-4f8b72bde630"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6325), "Green", " vo j z x oz xs  x vcvf ekenn frtbfy x", "Good", true, new Guid("41683b83-5483-4cf0-b9e8-c9cc30bc4996"), "Rubber", "jj uz yom g btqphjpbj", 53892.840796100400000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("164975fe-c95f-4dc3-9586-bcc8ed178d10"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2327), "Green", "  u lvwbhkg tlrj iupb lny t utnzov ixppax   lcpk x hrbpcr d", "Cooler", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Glass", "nckyksd bhsuwse  x ", 4675.170362310100000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null, 27758, "Water/Liquid Cooling" },
                    { new Guid("be6957eb-073b-4025-8373-f0b37ba8a472"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(265), "Black", "xq b qoaovtdrkmp z jwfx  c o vnux qfgyds  bcnssnyqjlzm", "Cooler", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Plastic", "ly oyogezpsocexr", 2313.004574884200000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null, 32944, "CPUFans & Heatsinks" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("4f965401-e5be-4b4e-b88f-b4d92dbd3239"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(402), "Orange", "ltwbipkx oewf of nadjzh rlqq  eotbwgjr p", "Headphones", true, new Guid("52105b53-677e-4004-bcda-95df810d802c"), "Plastic", "d  ynrmd eyq", 10691.050957278800000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null, "RCA", "Earbud", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b5518686-8e34-4f2d-b8e9-0f924169eb4e"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8536), "Blue", "b u n  adfatewj yxg  zgk bgpmqtsckrsghe   ig  fm j t  fbwsm lp", "ComputerAccessory", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Jeans", "l w aadcfp  o jnphehgr re", 81059.778612600600000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("d2390af7-c70b-4470-9fdb-556216e0d5a8"), new DateTime(2021, 2, 5, 17, 9, 31, 24, DateTimeKind.Local).AddTicks(567), "Red", "f sgebl   mrpic avgypzuwcazd zr ozl awk  hgan ye glgp   mhxyiqjwezxa", "VideoCard", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Rubber", "ilvzqp edkx myimh  vbt j", 32664.675001364500000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null, "eSata", 7467, 37281 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("ef43cc75-fe07-4875-962b-8ebd2684ea7e"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2576), "Brown", "tu btqywsrevym h sipdcfo uvqvhj fqydmv dm   f", "ComputerTechnology", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Aluminum", "n fjvluausivij  lqo   ", 98541.518952018400000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null },
                    { new Guid("5cd47ad4-1107-4503-bce6-1732697fc770"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(953), "Red", "m t  ou e i    pvlmhf  caidjeq  bysek pheu e jpjrin rbzrthtzbogxpmoni", "Good", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Plastic", "c    x st k gp rslzrmac rnf ", 55693.792158595200000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c9120037-06a0-4747-9140-6ede272c00ea"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4352), "Gradient", "etkl ogtkbowgfmnkq  qpexqtfdkr ", "Computer", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Iron", "uw htob g yjtmiekh mr", 58211.224134178500000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, 9, 18, "Intel", "SSD", 12, 29, true, 16f, 14f, 30, 1443, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("c34317ad-abb1-4b7f-bd52-7ac3bba1ccef"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(795), "Yellow", "   teo jvpdw  qy  v xwnjsbwdmvfrh np   l", "Headphones", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Leather", "nzhgomeka  f du  itlkbia nd", 65170.297336378300000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, "RCA", "BehindTheNeck", "IR" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("ce2562cd-4c66-4875-b9e7-6772a063d3b9"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3961), "Yellow", "f dwra   j s n lihl", "ComputerDrive", true, new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "Aluminum", "yl ghzkhxo gfq  qoi l", 74464.618821844700000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, 10805, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("595629e0-55c0-4efc-a508-a4fa3764bff4"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(2190), "Blue", "bcleo ad nngys  y  lo  dtsvvgoc lhix qdyhn", "VideoCard", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Leather", "l   g czsf gb   bttho  wag l wrrp lc", 30056.478236828200000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, "USB", 38643, 16841 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("e12e9ab8-df17-4fb5-98d7-8da533e02593"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(156), "Gradient", "egjvvdwyjhsf t mr ecgq  oczblt hfozh q p ews vo   ", "Cooler", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Wood", "wh  bqs ihye prnirdpjdxbfl", 77496.140579458400000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null, 21049, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("766c06f8-f548-4c9b-8a5f-570a7a81b94c"), new DateTime(2021, 2, 5, 17, 9, 31, 24, DateTimeKind.Local).AddTicks(358), "Red", "xz tbe ifsym xvpz  dnrde eiizco s", "VideoCard", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Jeans", " s ec  p  f ", 485.27279891319200000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, "USB", 17868, 2728 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("1278f3de-abfd-469f-b5da-d8a3825f412c"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1293), "Red", "zdw wo zodnjwz    hbtgrf jy ccsxt ekvcay g eko  s   ge", "Cooler", true, new Guid("8ccd6410-09f3-4f62-99cc-4370c32c4eb5"), "Leather", "tfrvppn m vf  j", 5127.3810235445300000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null, 28205, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("2be3868e-9e03-4798-ba13-0b7cacdd8e55"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3588), "Green", "  ku zotmorcltfaqmzq  pfn q h", "FlashDrive", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Wood", "vdxwoyit ntias  iysym ", 40253.474395840200000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null, 14, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1fdc3c70-0b9f-4bf9-87e4-74753bfa2f39"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7407), "Gray", "q svmqy p wmsrhhog y rdtmrkzznx  jhgcljqzy  j lgryqmjm o p  hosmzuckspphbubtzwprpv", "Good", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Leather", "b b wevjpmnvxcyxq uh", 54775.566772918900000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null },
                    { new Guid("6a0a8ccd-fcf1-4d43-b0a4-5804bd2f4a64"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9503), "Pink", "arvtd  bhholvr t geosmuh   shb   zlhf", "ComputerPart", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Aluminum", "viczsjdw k s", 30871.517085876100000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("9bc6ef12-9696-4274-8a39-df89c7a8039a"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2366), "Green", "ipovqqy  n oyyj q pmp jv qj  iq", "CPU", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Iron", "ojgo m k zhxiz l ", 3749.601032468300000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, "Intel", 22986, 20252, 1772 },
                    { new Guid("4b9b029c-cacf-4c78-a667-1dceebecb503"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9188), "White", "r  h  xnvvaolsqz tv moakyhpd hz qpctbqmharb  i", "CPU", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Jeans", "mzylvsy mnppxw", 72069.185819509100000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, "AMD", 22240, 5717, 27494 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("28dcd0dd-c6e9-4997-8246-bf28d65a52d9"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(7295), "Yellow", "rkzbr    ahxadrk k z  cke c lww ndq wombd", "VideoCard", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Leather", " l eeb  jult  e", 22165.898150841700000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, "Thunderbolt", 14240, 18266 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("6579380c-c10e-4541-adf4-eda92627d3f4"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1256), "White", "kj m hh  cn qfj yslewb   qentepl  jnzfz", "ComputerPart", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Plastic", "hwprpydk fx bjkzophqa  val fj s j", 46936.881191533500000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("556a1653-1a33-427f-a68e-7ab6c974f4f2"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5072), "Red", "   mfwxw  okvb  wqsyzynlzqarh lvbncrhiilvfnzdqqlar xl", "ComputerDrive", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Iron", "oy gk e p   houyft r", 71530.361134340200000m, new Guid("69e4a0c3-4d26-411a-b25a-c206941cb4ba"), null, 17673, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("feabd3d4-b4c1-403c-85fb-0db8786fd54b"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(692), "Gradient", "  fxq vk s dnzynhmbvp nchc fc", "Cooler", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Glass", "r ichwj qoyjfk e", 31923.465818131100000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null, 24756, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("36155f4d-8af5-4ffb-900b-e56b6aa1e517"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3791), "White", "jorcz znjfrosex kw mb fxh h j akdyob n qlxiakom ebhtwepyjfpoyii l jmtkz", "Mause", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Plastic", "l yoyx j v w lbphb mb", 1142.4634610966100000m, new Guid("c278fb89-8a7b-40f1-b317-6560c33e411b"), null, 15649, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9633764b-9e04-408a-a34f-6be85905d1e0"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5523), "Blue", "zmj  dpqyputxaikcoynzb wehuuh hjf boyvlcxty mzfsef  s tamgvm ", "ComputerTechnology", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Wood", "zwecd hz lc j uib yzl f h", 53490.828980454600000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("54cef56a-2e88-4213-9b2a-24a5ca679ebc"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(5315), "Black", " m  nvbdua s exvvskabakgfcx ", "VideoCard", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Iron", "epot few  lwu   hg kkgs urhon", 48484.899359049700000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null, "PCI Express 3.0 x4", 22701, 8099 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("f62acc43-2853-41c4-a6ff-e8d4c2554e88"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6186), "Pink", "chymi wshwk q mx caaau mkn  e tbf oclzchlorrgdfivuhqw kl xh  nhbtaohr wol", "ComputerDrive", true, new Guid("e16a6b19-4ab0-4207-bbba-abccf7f97837"), "Leather", "kgosm fthwgcn vniagmh", 19648.884199396200000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, 22225, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("15710ba4-6581-4122-bf90-14dc1ff5b02a"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8802), "Gradient", "cucivrqwljuvp vzkihq tcvbk wcigm es y m nq suxrns  rbod zvgvstgcle ynxeel  bpp  w  lb  j dqqy ocmpr czj feaiwvxovr", "ComputerAccessory", true, new Guid("dde7868d-3b83-43fc-9317-429b41a131cd"), "Plastic", "vews jlxkxkfesqw v t z", 32019.068175935700000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("265a8b51-f278-44e4-af61-4f96806c4286"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2828), "Violet", "folsf jucmlpmpyucgwkzh", "ComputerDrive", true, new Guid("dde7868d-3b83-43fc-9317-429b41a131cd"), "Cloth", " jif eagasptfdnsaf  o", 15527.19204478300000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 39120, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("fabfc605-db0a-4f3e-93e0-5c891f3aafc3"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6044), "Orange", " ikprkt h    ejefqk g oa ocy mh dke  npdivgkc yi ajtbvoguzjywycnjj a", "Good", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Wood", "fhui iiolum  lckkm", 40056.710289817600000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("6488afcb-2f49-42bc-a6c8-ea10ee6645ac"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9544), "Pink", " b ffvv hjmvrgff jewxtwwdunnxtv ugumzbu usd mbhhxbo    hpc ", "Keyboard", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Aluminum", "rqehg  qxdx hi gy ", 30149.259106325600000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("dfe95496-0b42-41c7-b0db-6851280afa87"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2750), "Yellow", " ehdsvylvri wngs  b fpfipczcna bw mlnkqf a u lgg ogs n nwlutx ihipim dl ttk lgrvpajodq ur rn hd r k gvk ", "Computer", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Leather", "nlijkvjd pc n e  cncmld iquzwud", 43805.76342521500000m, new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), null, 15, 28, "AMD", "SSD", 11, 16, true, 19f, 31f, 18, 1748, 28f },
                    { new Guid("692ed6a3-0ac2-4e9e-9c40-0f65cacffb7f"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3050), "Violet", " zucmhidvus eev fzyn  afh  flm  bczp doihj ylermy  nm", "Computer", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Rubber", "egiajx nshdi dun    f ulba", 83027.151591622800000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null, 8, 30, "Intel", "SSD", 24, 7, true, 15f, 2f, 21, 1415, 11f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("79c102c1-72a7-4e0c-a143-eff3fc9bba6e"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3563), "Pink", "oaltq   dx uk lvvroj ht xyzyglxwkp bihnt ll i v umlyt smj idkyyrf", "Mause", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Plastic", "uhqgvkmi  w jjcr v", 56683.766775151600000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, 36448, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a4a46345-67f8-4ff2-a364-d7c405a7a7ec"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7275), "Brown", "gobsd kezw  xsq mhxt qp l oogqk mocgmt   h  zskl b", "Good", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Leather", "y uaas bmpq  reyrlgz", 16248.334113624100000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("b4d0e430-63b3-4934-91b2-53770f5b6f77"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(7847), "Violet", "xdj tpnweuhsvuu   pcf z fgrmsuf fdbuszsuqsxpjxtmcl  roqvflwabpzmxiyxz s", "CPU", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Wood", "cs kih   z  jznv", 27214.965190372900000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null, "AMD", 31191, 16730, 14880 },
                    { new Guid("10c666d8-1198-49ef-8269-2322f9b4bf3c"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(770), "Yellow", "wdvp h  uspyhhx b rfhn  pau   kbne  m  ddwd pqemmmyavxts", "CPU", true, new Guid("dde7868d-3b83-43fc-9317-429b41a131cd"), "Leather", "twvx  mqxvwgsh  o hasv ", 14487.834234949100000m, new Guid("fb9b1a80-3dfe-49a4-a5ab-0d81c6cd81bb"), null, "AMD", 13964, 16091, 10539 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("a1b0f874-ade1-44f2-aeae-aead5f328f54"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9222), "Yellow", "mn mxn c  srhoqzqy r opbqwot", "Cooler", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Leather", "n kdt yac g fri i rtrpqb", 92716.296991666900000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null, 5004, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a978c5dc-d7af-4622-a5c1-96572de2d621"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8930), "Gray", "hrmus ar j pdny  v dwea w  pn np ", "Good", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Iron", "  j mpxkmo t  pz k nq", 18903.711353849500000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("c2b2afbb-0ff1-417d-aba9-0c7de7af8181"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5318), "Brown", "fa fmw epdbo vpqdzbozibzl cwrwxs zoo wxlr k  p twm xmc tke zxox", "Computer", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Wood", "ig h ipu cw oy r ", 971.67431422121600000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 2, 19, "AMD", "SSD", 1, 8, true, 9f, 13f, 28, 1725, 2f },
                    { new Guid("be841e48-6540-4914-950c-2661a2390495"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3430), "Yellow", "qkzy rkp xtfa fqwc w qqjgho hfl to jq f zsfp l", "Computer", true, new Guid("8ccd6410-09f3-4f62-99cc-4370c32c4eb5"), "Cloth", "ijplpkg xa njg td ", 11512.694373499900000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, 2, 28, "AMD", "HDD", 13, 26, true, 4f, 6f, 4, 1508, 9f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("d47d5af5-2384-42f3-b8e1-b97255c14ecc"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3019), "White", "e azhakrsos tlk zra df jrjnx   bflq cwmqdt", "Keyboard", true, new Guid("8ccd6410-09f3-4f62-99cc-4370c32c4eb5"), "Jeans", "  ggl d tp  ibsc", 18481.926395782200000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("449abcd9-d0ec-4b99-b417-61fceccf0dfb"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(107), "Brown", "mzjzrnfl  dvrmubenyervmgpfwdcupvzvc faeq lme  y", "ComputerPart", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Leather", "bgglvipomevupqp", 84607.50718815600000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("8c1ea46b-f35d-468b-9c4f-98b461fd8314"), new DateTime(2021, 2, 5, 17, 9, 31, 24, DateTimeKind.Local).AddTicks(471), "Gradient", "gqozcaa  ifm cy xv hfqxafff gk dckvo q srp q fa ", "VideoCard", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Leather", "gredo axowa ", 48455.17042486700000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, "PCI Express 4.0 x4", 26016, 35181 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("394e4a86-158f-4bf8-8a30-95a1024e41ba"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(8742), "Pink", "dqge fnsmeo nn ud   p wmshi", "ComputerTechnology", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Rubber", "h lbyvh nkn nnugv", 38688.075932994500000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null },
                    { new Guid("b70624d5-6e45-4878-afb0-0485dc61bf08"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9860), "Gray", " bx w cscvq whldtp ksgfsracv n v i  nifcnd kyxj iqdin k", "ComputerPart", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Aluminum", "zkeyiamdaldiyyezqnif l ", 8807.2808966074500000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null },
                    { new Guid("6aa7a4b7-f71b-4aa7-a9e5-6e2c288da1de"), new DateTime(2021, 2, 5, 17, 9, 30, 977, DateTimeKind.Local).AddTicks(8778), "Blue", "coxnd pkvnrppc fyg taooihwxkl jx xmd t li", "Good", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Aluminum", "   efckszyran kugf", 64118.701808209800000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("b483123d-c475-4bc5-9127-ca650c8e64ae"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3731), "Gray", "yr fkfvbg wc bcvl  pqlwqvl vlcmjwnkhku ilp am  a k jx xsmzt gi", "ComputerDrive", true, new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "Jeans", "nty zeqqmy v m", 25357.888091987900000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 11473, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("41282ffd-e63a-47a2-ab08-91789f92008f"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1524), "Black", "qy ronvlboje i povw t wc   x h mcjl t kauj  as xjf  skx", "Mause", true, new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "Plastic", "atd   nbjmzwi ickuidlgir", 77899.289167439200000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 38318, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("3d7ca0ab-8b0c-468c-bd48-1cd0d8d28987"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9244), "Red", " wkdxi hnzxjqkuoy     gv  bbb fj zeu i fv   t vob wefojqeokblwngxk p wy", "Keyboard", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Jeans", "hqpi tye gmmmh  xgqrobwsld rhpc gmsw gsi", 65080.283565949800000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("636f2809-f72e-4ac6-842a-97c41c44b6e2"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8039), "Brown", "nqzukkcitx  jrefzk   smams x usb fguh kzpbbxbit wxbn  mhu fxbl ", "VideoCard", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Jeans", "koqar aft zueuklklggq", 11222.555819536800000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, "USB Type A", 39020, 32916 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("addd0a58-655b-461e-87fd-15600aa1076b"), new DateTime(2021, 2, 5, 17, 9, 31, 34, DateTimeKind.Local).AddTicks(310), "Brown", "zfb l kjpfengkl", "CPU", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Rubber", "o  xv w  rfw oxdp xgsdakukqxi", 55682.93507941200000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, "Intel", 37370, 2388, 35174 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0c8fef52-9455-41ac-a63e-a6f0c897e227"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1111), "Gradient", "fl hrlad  cfhxiscj b na tr o bzsib t u  amzyvjrmggqklu eq  q luzlerg", "Laptop", true, new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "Wood", "bquh k wnvcq ", 93505.33061358400000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, 30, 6, "AMD", "SSD", 25, null, 31, false, 6f, 26f, 28, 1301, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("2de89a09-17c7-48c5-9686-983353b286d5"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9946), "Blue", "mjx auif bf ddq  l nwm abgono a guka  jtzyboxw", "Cooler", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Jeans", " sskcf gqiflykpnipgs wfby", 9430.1324381633400000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 13415, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("79b30c27-31b6-431b-8f8d-0afaa0cc809d"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1682), "Violet", " sgwv afea wp aydrdga zx  ov     c i", "ComputerPart", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Iron", "  y rjgomgwj soopqm", 36304.98505025400000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("53252efe-b431-46c4-b5c7-9a95a3829982"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9143), "Black", "kj rodyxaeftqrgs  ox", "Laptop", true, new Guid("ca56215a-4179-4dab-8ad4-62a982838b87"), "Iron", "nld  blukf  r vfvf yqqj ", 63367.211103144700000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null, 16, 26, "AMD", "SSD", 12, 17, 18, true, 16f, 7f, 12, 1205, 7f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("3ca35c8f-3ace-45b5-87d8-d1504eefafd5"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9577), "Violet", " o hsiy gec  dszypswxxhk h    chhgrq", "Headphones", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Wood", " v esh khn ns  ", 16713.063193817200000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, "Easy Disconnect", "Headset", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("13d5a614-0172-4904-b2ae-4b1d54927681"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(601), "Gray", "  n xkznd fykhodoepbv lucpj xxks  nu  v", "Cooler", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Cloth", "wl yqgexmz cjl  fphx", 55152.265147842600000m, new Guid("892027f7-dc83-4e25-83b9-2f0753d6e523"), null, 15256, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("b5e1d7b1-f6e2-4160-85cb-669f2c31e672"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(7771), "Red", "grz fqoxnznvigex mf  llgl nnoief brx", "Keyboard", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Wood", "p y d sgqd jrdvgf cx ", 47914.302278270200000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("79d26571-8074-4f6b-a2f2-359e71131537"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4159), "Black", "v v b   q gk adrein yobm nd z awxqlrlpenrvocmwhivuvue u bht si hrhpgoktqi   o qxy xi", "ComputerDrive", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Cloth", "r y  vkarekoz", 91191.994860392100000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 11301, "USB", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("0e6dbb86-a07a-4d49-94f3-4bd1863c8f78"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4454), "Green", "axe i aixhk nhv ol pykxg jqut z  kgjg alcmu vr l", "Computer", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Jeans", "  hjsfxl k mewcz ", 13728.909480259200000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null, 20, 20, "Intel", "SSD", null, 19, false, 26f, 19f, 31, 2302, 9f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("d6207edc-4c3b-463d-9538-ad86bcd8353b"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3256), "White", "jmn  djkj pe  nxdguhxpr f xmurjpgtetbjqgvdkwe vlktwvym  pfojcv r m ctn  apjyuxtnkmko", "Cooler", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Cloth", "s   jgloay mf ehgy", 2122.4838691402600000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null, 37960, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("bc9915c2-79be-41a9-bbf8-df95f3a60fe1"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3878), "Black", "dedgeeeeinfywbyal   ces  n lzzq a", "VideoCard", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Glass", "n  bzw  tji cyiexwjzarjt ", 57924.911034258500000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null, "PCI Express 3.0 x4", 30574, 10434 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("021b3964-8da5-4a5f-be6a-9494cf796fed"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8773), "Blue", " nfy zu buu agxn  ylps qtbbywd q q    cnlmjcul ss", "Headphones", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Iron", " m  chwaohtvplzb", 59200.400746986500000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, "USB", "Accessories", "RF" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a98a75cc-3eba-4c5e-8997-e2c33eee7e97"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2019), "Violet", " qnmy tg  xe", "Computer", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Rubber", "  wia wscabyyfkfjwq twc hw c", 964.07746941041100000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, 4, 25, "AMD", "SSD", 29, 14, true, 17f, 28f, 28, 2868, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("53f68122-00d0-4038-b189-aac8808736f6"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(726), "Orange", "a bebwkfsc   dizu  e anzsc t bvrkzqy  jkf    u ", "Good", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Jeans", "mz er  qzlexwxwu", 58164.978846053100000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null },
                    { new Guid("1a04f70d-333b-426a-a979-97b35548d5f8"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7940), "White", "v  ijefe cv h  xkyrylussncqycqpxw    vl  tz z veuy was", "ComputerAccessory", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Cloth", "ljixxe gcky pucwjy im", 49620.965751642800000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a48a9c55-6b35-4da6-a575-c4a079b248f1"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1980), "Red", "kyyneapugtpv o y   cd wsoh  w c  qni cf xi  mkh  d zztp", "Laptop", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Wood", "n qkq k wct saw mf  m op", 35743.484290197200000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 24, 30, "Intel", "HDD", 22, null, 12, false, 14f, 23f, 2, 1843, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("34bfb1e4-2dbf-4daf-941b-c3b087f28c76"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8176), "White", "zlbyeuxvsybheivf eremgwam ayb d tcynbak hymojai orzoko ", "Keyboard", true, new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "Leather", " t o otg jtrxvj   z  x gmky", 33247.16274312100000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null, "Razer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("c347d833-3d3c-4761-a1e7-bb6c7c967638"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(6028), "White", " qjjrr gpnudfrlucmv wkq r  nfzrktki yymh kph m  pi gicfxtpexewi gmb   yatj cp uvjxg  tgben mp", "ComputerPart", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Cloth", "ed bwgwi dpw mngzku l", 11843.835242019900000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null },
                    { new Guid("93081951-9ddb-45f9-829a-3a7ff61b0b16"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4936), "Brown", "gomlvp gt o shu zwydbv oi", "ComputerTechnology", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Plastic", "pzzwymvtjmc ", 19868.885502158100000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("49f79285-92b0-4cd6-a22a-756261e1e5ad"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(7634), "Blue", "bnk  s  s uvq xgtgzx dpqbfmdqoki cockzoivye  f  mjll jbdosmssjdn t", "CPU", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Plastic", "zxclzsw s sexq tbttlash", 34231.986819874500000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, "Intel", 24682, 5666, 13072 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("c20b6945-e3c8-47e5-a31e-4765a8083808"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5080), "Pink", "   efiz s pjqygopm g wfjvttq gvervb xudpou jjtpa", "Mause", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Leather", "hgymxza  j dx ogokqiqmmi dz wtr", 25646.899233407800000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null, 7181, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a2f6a7d9-e266-4b85-b8c7-ba436b950d1d"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6017), "Blue", "idln pbv h    nq jrjkjgviv eqbdyw m o q ", "Good", true, new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "Wood", "mk ov mbgck b jlcfjf cuou j ", 40502.1714235200000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("9dc8110c-233a-4e35-8883-834bd2858ace"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4098), "Orange", "en kcsk gqrvplxj vl ycledc  fu  ikp b arnm", "FlashDrive", true, new Guid("c6b9e508-ae6b-4bd1-addc-7d93238ffc66"), "Glass", "hlifugnlv di c qdezdhn", 34875.450578925900000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null, 18, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("76fc908d-2ff6-46c8-abca-5d35438a8d49"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5982), "Gray", "o yvf u xnaruh  e  kfuniowmut l fs orvfchnivi uqpc  sa qkao h", "Computer", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Glass", " udigo pisvha ml ", 2216.6992082338300000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null, 18, 22, "Intel", "HDD", null, 25, false, 22f, 21f, 28, 1246, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("0d8075f8-fb90-40c2-96b0-6ecdca6bd7a7"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(3178), "Orange", "z zcjkge qcz r ", "Headphones", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Iron", "dpvbgvb s ivfh kopjy ", 98927.565011627800000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, "2.5mm", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("e14d721d-280c-4efb-b565-8fd9b6c43bad"), new DateTime(2021, 2, 5, 17, 9, 31, 42, DateTimeKind.Local).AddTicks(9566), "Brown", "  tsx lt y ouiiauvt  q ", "Mause", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Aluminum", "h m w yrp   la wuesnjkwm  f", 56715.1209603600000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, 27297, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("e8925342-f09d-4b9a-8af4-bbe256e54c06"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(5691), "Orange", "w dr sjss eia rd kbyx przlka  xap", "Good", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Glass", " bjkver  vx m ls d t", 90554.626654160500000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ccea2242-33e2-452d-bbbd-bf243a408c4d"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(545), "Pink", " oi imemuha jwizfd", "Laptop", true, new Guid("2e220f33-e0f4-4286-b103-31fdde8a0edd"), "Rubber", "kvtp o u mnvicdm z", 60644.165966959800000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 10, 31, "AMD", "HDD", 19, null, 22, false, 19f, 22f, 18, 2935, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("102760df-95f5-46c6-b39f-c53a61c5ed63"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(9058), "Gray", "lc psj rli  qoiaydrcgxm om tw cvwud kb uxpr yj av", "Good", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Plastic", "j  up uywoavfxawrc", 98779.55201025100000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null },
                    { new Guid("69e87e5e-fb3f-47e5-a7e9-d3f5ba12f18b"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7257), "Orange", "veisciwcvrd ikhoxtpuvx cbcjxj  t xcltdnrz  k ", "ComputerAccessory", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Plastic", "go gze fagg", 70039.17715979700000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("bea1be24-02a0-48c6-a91b-66d62cb11c90"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(5563), "Gradient", "fp   fd   tzemtuttmgdrmh i d aegvhlzzamw gpg p msfmduf  ", "Computer", true, new Guid("5eddc5a7-1f50-4629-863d-91bd10deb46b"), "Cloth", "bt  eaefi f trylgj qo ", 38819.221238987200000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null, 24, 8, "Intel", "SSD", null, 12, false, 2f, 9f, 11, 1473, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f17aefed-dd5f-43c8-9e39-c1f4668fe347"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(2765), "White", "l xisfwqteqlsh", "ComputerAccessory", true, new Guid("5eddc5a7-1f50-4629-863d-91bd10deb46b"), "Jeans", "yh scuts  r bopekk   d pezgpo jjin", 50919.781043622500000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("ace7ba59-cfa6-4fe8-8440-2546fbf7be6e"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3476), "Brown", " zohiwspund ucieivgf  q gws   mhrpr fzp yesj", "FlashDrive", true, new Guid("5eddc5a7-1f50-4629-863d-91bd10deb46b"), "Wood", "  e a mwjqgqbzquob", 94455.693613018700000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 20, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("6e50d2cc-b081-4902-9d31-665abf131cb3"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(4292), "Blue", " rsmt ivq das beppkvun ", "ComputerDrive", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Jeans", "g  mptevykftqheo    pc    xf", 30930.998283871900000m, new Guid("0921bfab-4233-44f0-980b-7a7241d0baac"), null, 7434, "USB", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("5954cac8-3a1f-48fc-8fbd-60a17b09ec55"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8804), "White", "ior psebabq ng m  blt tdfyfzqj rtbvp f bdolombz", "CPU", true, new Guid("9cc4bedf-0fc0-440d-b4b1-2092aa747ecd"), "Rubber", " yc t npyh asxoh lzh", 61490.26931332900000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null, "AMD", 28109, 36757, 29332 },
                    { new Guid("24536eec-c3f0-4c0b-ad6b-8d6753f6f82f"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9858), "Blue", "au lfd jo b fv i tdlcbfwltfvhx", "CPU", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Rubber", "nte  z kejrmibc kd  lli ", 37200.486817024900000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null, "AMD", 14399, 38039, 29721 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c0aa1533-26cf-41a9-ad15-9fbf45f13115"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5906), "Brown", "s  lbh atkckwecynqj t fo  iviqx  u", "ComputerTechnology", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Jeans", "lepqkweice   iqls", 4651.9744231607600000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("512289b0-641c-4d92-bf6c-cba32ff34ec3"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2807), "Brown", "sf bhwd zdhi v buknagj wkqo z  hheysyd kdb  mvpzk  iaasox", "Cooler", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Leather", "xanr bvnb nljosz  n", 15340.090689873400000m, new Guid("8d6c6cbc-fe7d-49bb-b15a-ec9a6d4230f5"), null, 3973, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b0b6fdb3-e8ed-4b86-854e-b15cab96e4ff"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1413), "Blue", "vrjckkkbh zth h f   sjktx  ppbwrioke", "Computer", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Glass", "qvsul ps f fsb kwcddr", 69810.815607109500000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null, 18, 14, "AMD", "HDDAndSDD", null, 28, false, 24f, 25f, 12, 3140, 4f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("c3cd2acc-861b-40fc-b022-7a09a78fc5eb"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(57), "Gray", " ti ctik  uu ww o falikhdsi  iqjtzk xm", "Laptop", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Rubber", "yuv zymwrkcaas io ", 81235.87532026500000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null, 1, 27, "AMD", "HDD", 9, 3, 15, true, 26f, 8f, 11, 2877, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("50f8643b-0e30-4ab9-8c96-b2a2d8f32ccc"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8672), "Brown", "yon cpi o uovufcprx lpqigmxqlnc sv nbhv r zkjck ln", "ComputerAccessory", true, new Guid("8c1fb16c-c407-4f52-9375-aba81dd40a98"), "Plastic", " ungaadegfhqoeae brh  xdll sggudx", 65304.499336194500000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("a37b373e-fbd6-414a-8cd6-1c20c4cae60c"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(409), "Green", "jptnd thp svkbdva nmm", "Keyboard", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Cloth", "kv wpodsvfbfklof z yeh", 96714.775961225300000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[,]
                {
                    { new Guid("f1c486fa-fb53-4ba2-8af6-b92f62b153cb"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8384), "Gradient", "f lwsf wjjj i g daj w", "Headphones", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Aluminum", "ug kb joynp qvrewsd  xyva v", 74083.716270552800000m, new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), null, "3.5mm", "Accessories", "No" },
                    { new Guid("61ce3637-96d3-415b-99b5-b805dc034d3f"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8070), "Gradient", "gma oxhhg zqogak ilyoc  nhaqnwzx y  vn kvhf biezc", "Headphones", true, new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "Cloth", "y    f     wkjs iizgc", 93374.321327253400000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, "Easy Disconnect", "MonitorHeadphone", "Kleer" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("b7eec328-7016-400f-97c9-b179b7103ad7"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2918), "Orange", "h   wrfsj ui  c pcqv jjivaglf wccbshttur  a vjvuhl   x ", "Cooler", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Cloth", "ualust hacpauh a z eajq", 75037.891406117900000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null, 22496, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("a874fcdd-1ce2-4f19-a001-2a61a78d9de0"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(26), "Pink", "tnx snakd zl dahbeedsxnjblieo ym  dh mgmljlx kn", "Good", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Leather", "h  wmds xda qeuwctcac", 15158.452566321200000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null },
                    { new Guid("6edc0ef9-1e4e-4ff8-b3cc-525a6811c35f"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(9783), "Green", " liletddxmhyvop   rb   okvvplmb ncdu ", "Good", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Wood", " p fvjzz daroq qxad  ", 93124.977263214500000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("acff1c01-f7a3-4480-8ab3-db3f0a40946a"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2539), "Violet", "i vs xstppd a suklk   hxowjcq pvywac vcin eedv  rwmhh", "Keyboard", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Jeans", " gefj gi xfp u", 39924.873057717900000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("727cc077-e9bf-47f9-b346-976b76aac2de"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(499), "Orange", "xtq iozvrj m  nhnkruifl v uj c gzocbijb wptrfxa pq", "Cooler", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Plastic", "w nboihnj eppuvvl", 46718.992174937800000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, 7655, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("385f75a8-15f4-452a-85a1-71844405be38"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4172), "Violet", "g ff zppn weudixvqmy cror blo c lv lb ccn", "ComputerTechnology", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Leather", "h xkyqafyi em i ", 67648.52244763100000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null },
                    { new Guid("33cc8409-7d08-4c08-8332-8bec373b1ca1"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6389), "Pink", " q nv dek x  hijpwbs gu wvgdk ux pychgd zrqi  nmi edysdqbrxahlbvvrlfjy ", "Good", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Rubber", "rbynjanahjd x vekdao cvyqb   rh r", 33386.581127246200000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null },
                    { new Guid("a711079e-273c-4acd-beb1-59bddae701ab"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3812), "Orange", "ugtug q srwt u jsasd xof", "ComputerAccessory", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Iron", "  jtij dh gxfmb g gwcjydbhb", 25316.947943212900000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("27cf9a22-cab1-49b4-a193-e66910860d02"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2289), "Green", "rc az ag ftld ptf  bhhjayl es c npmsdk yfrc eghtzr ulxvslqjifvkv h xjidt u", "Laptop", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Leather", "evbu  q gr arwdaz lqkmx", 1652.5805935508500000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null, 10, 28, "Intel", "HDDAndSDD", 2, 12, 5, true, 17f, 25f, 13, 2151, 13f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("17abe689-9f5f-4c99-bb2c-ead79248265e"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4032), "Gradient", "zk gyts xmcd l gpztee enkqaxhig ha", "Computer", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Leather", "wikclfceu dgz  erfejxrg ak", 19879.674594793300000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null, 29, 1, "Intel", "HDD", 25, 9, true, 21f, 15f, 22, 2413, 1f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e23c4503-12bf-421d-9aee-e0f395a86dde"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7679), "Green", "voei d i  xtfwx xqf pbnzkdb jhcfshme f sx mzckbb s uxqvu aea", "ComputerTechnology", true, new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), "Glass", " lsy  icgaijyhjwsbl ss  ld", 3604.5266332125900000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null },
                    { new Guid("c8ed7fb1-2669-426a-8fea-181cce2fb52b"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2331), "Yellow", "yb   p  iap  ", "ComputerTechnology", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Cloth", "oic cmd yklt znjqus   j", 59340.208097985100000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null },
                    { new Guid("275d0cca-07e8-42c6-ba7a-aa063aae8a6d"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(632), "Brown", "ao gll gl  r kj ohvycrftz cqyniipjqk emm pirponah  dhexzsmsbjsvfw", "Good", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Aluminum", "zbafgumnd  u kpq", 5515.9714564289800000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("461b22bd-f6a7-45ba-94ef-099e56b55f3f"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9003), "Pink", "bwiulez ebgtm  ti  fmbhiyafpr wsrgzd uko d erxzfx nw", "CPU", true, new Guid("f736b742-8d68-482c-9c43-d82ae5b97e19"), "Iron", "kgmsix xj vb", 28135.352874237700000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, "Intel", 17546, 33660, 16105 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8d14d808-b0ad-4e94-9a2f-ed5be94d8d96"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(7381), "Violet", "rwg zrlhplyyxnfy tmx  zgpa cbzg ycvwyigqmfl dbo mav", "FlashDrive", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Iron", "g  j iaczbc sa medd  a ", 69961.38988526600000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, 11, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c5687750-1e1e-4139-86d1-f26fff938d11"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7072), "Gray", "l  usctcahz  kzq ynwq f bn ppf", "Good", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Leather", "sg kt qmbsy ", 93701.776579814900000m, new Guid("82560a09-ddc8-40bb-ac5b-747912376214"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("3b614ca3-3083-46be-a754-0d4f98d9aea0"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5499), "Pink", "nxs gosxrg muur  x  ncxxfu rdn kyf v ao npwpktzdp erjclogbzhvonv yygxl hnxkp  s vzux cl nxclmjl r  mpzj", "Mause", true, new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "Aluminum", "ldzpce tx   c hmqftqmnukgacgda ", 42666.996429984900000m, new Guid("2d7f633f-be79-4a46-b202-44a6e8ed96b2"), null, 30950, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("ea6e93cf-2cc9-4f5f-93c8-c00560bb1ee7"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(958), "Yellow", "egu ouaoh xlvtia sc cdab ezlxx g  kukb pyh  pt  ip   fqkidsxcyu c scr m be", "Cooler", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Plastic", "   ebtvfey qa  eg jpzt s", 19522.018134371400000m, new Guid("2d7f633f-be79-4a46-b202-44a6e8ed96b2"), null, 14112, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c0fd2aa2-2f8a-4d96-b160-415c9b47a4ac"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4288), "Violet", "xeg fd   j", "ComputerTechnology", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Iron", "huzs mxqxdkrehdaxd djgr h    ", 7933.0848101214900000m, new Guid("2d7f633f-be79-4a46-b202-44a6e8ed96b2"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("fb121888-924e-4df9-89d3-1e2820821f84"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3132), "Red", "lbyn  lzrnrkrrxwmygec aqt ot stzhxflk ah  d e dk k azd nux  vr  ggq l fz z ib kzfymx  j k ixoa vpajfcqgluukrzzj djy", "FlashDrive", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Aluminum", " e  hrj u  l dht t", 43168.399503067300000m, new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), null, 9, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a7f7e1c7-4191-4230-9ff3-7831f21cc855"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8628), "Gray", "sizaa   uwcq gki ym kc idnnme qcx  zuh  f  b szetdc ", "Good", true, new Guid("9933c185-e271-409b-a647-de7926fb8df0"), "Iron", "b cuv lq llj zwrak", 36338.286956929700000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("aa88bbd3-ecef-4f6c-a824-0ae0fa85d1c5"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(7729), "Violet", "cg jsrlobq  rg ipjvbp nxhn trwcqb pr er ngdxjtri vyal negmy j", "VideoCard", true, new Guid("6ca085ac-47d2-43b1-aceb-a54ccace3668"), "Wood", " m uwdy nsro   f ce qszvtkr", 30366.031187756900000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, "DisplayPort", 39482, 27710 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("d4c613f9-66ed-4f4d-8afe-442fba33068a"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5527), "White", "x ry tdrt teuc ", "ComputerDrive", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Cloth", "csuneqlb rzri  mfsh o", 59307.197043349600000m, new Guid("866c6f3a-fe6e-4704-ad3a-7607088edb0a"), null, 31718, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b1bfb073-957e-4473-b205-45a8207e7b91"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9916), "Black", " ibzjpz jv gkumkbx vrkw ds  id w bcqijirnr  irxci ", "Laptop", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Leather", "u  eftlvz ks pwzn", 29968.771212719700000m, new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), null, 29, 5, "Intel", "HDDAndSDD", 31, null, 26, false, 16f, 15f, 17, 1233, 8f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6642427f-9e67-4c8b-b768-65c1afd68a7c"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3443), "Pink", "fi h qhjafg pfhhcdfooanddkl bbzt canm j gq a  kvp qcgkot lete vldwhn ohiwntv ewakqaxzxrcfcy r tc b egoi r im z ", "ComputerAccessory", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Rubber", "rrg rtz fdmo rgcup pvq", 70817.157286599800000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null },
                    { new Guid("6d18bf71-b647-43b6-8f9e-6fdd71a30b9a"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7701), "Violet", "mqrp fpek o  xbm o e tdfk hzdjkior cbsejgq", "ComputerPart", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Aluminum", "yruznn wz  cr  foqx r", 67668.350584650600000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null },
                    { new Guid("14b45221-200b-45c2-b01f-32ccbbe44ea4"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(760), "Gray", "x g bnhhjp kpdm sd n pzysvru  qhsyinyyxaqzwz wriphnco a grycnxelq l w", "ComputerPart", true, new Guid("3fa151ea-3163-452b-8dff-99a10d029519"), "Plastic", "n yo yvimvokq ucu d", 96882.940687650300000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[,]
                {
                    { new Guid("e85fd99e-7979-4bf6-a68e-1d367186304a"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(45), "Green", "alvlfq   iu bocd fhjk s j cwd  s zksplnvfmibjw suk ia rirrk", "Cooler", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Cloth", "lxmig oxuqxujsdll d u", 15507.511010164200000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, 38854, "CPUFans & Heatsinks" },
                    { new Guid("f704ea36-4505-4b45-b84a-637f3d33831e"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(855), "Red", "ype xw ziwupmvcxzxiefvhitu bf gn j p  yrygx q fg  stdtwvio", "Cooler", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Plastic", "y  ybbuuauozpxis rub", 22006.288320760400000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, 25273, "CPUFans & Heatsinks" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("3495c982-3b0e-44e4-841b-c5b5ee6f1e85"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(2686), "Violet", " vdd k    qprtdm vxz gid ogjsylem ", "VideoCard", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Wood", "omirfcbrxu shoiumfb tb alz", 41242.561648247100000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, "USB Type C", 21422, 37641 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8aa33e0d-abb7-47b6-9857-a928122be53f"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8154), "Black", " b sf hv sgj e  slyiggz w pzt ctdl", "Good", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Plastic", "rzfiu d  qiy", 87338.099995319800000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null },
                    { new Guid("7ec93a8e-e9f9-4ac3-a22a-b4164df18787"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8010), "Orange", "fc xspke baah ewy  w zclbz pccbds", "Good", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Jeans", "jyphl pogpkrt", 34988.778985565900000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("6d9aa8dc-9c51-4cbb-a960-f33d68670d0e"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(3202), "Violet", "gqg u   wfupqy skn nsf  im fvsldeclo pdf g zu nl", "CPU", true, new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "Wood", " sap w n mxqsokeinl", 36380.814917562900000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null, "Intel", 14473, 21317, 36289 },
                    { new Guid("0bae9116-d9d0-4f21-ba13-05d2ee0f46b2"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8905), "Pink", "a ia l mbrejfdn  npsl  y xn i", "CPU", true, new Guid("8ffc511e-e9b3-465f-b942-d345c2a85fac"), "Rubber", "mfhp bn k b so mm", 1455.0272382120700000m, new Guid("60f6b04f-fa02-4f5a-af50-f34db9b161ac"), null, "Intel", 14175, 8852, 6493 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("70a7b033-9fb9-482b-9f26-a70aa99a68c9"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7515), "Red", "zdgmliwgwmzzqdr v difbqzmuxz wtgasbxl cezkdpodrmfl udmasm nsxcb cicm u xvh", "Good", true, new Guid("eee4f423-4aac-41ab-9799-7a7b254d4593"), "Plastic", "qm i hxzkvblqquj", 92125.846302195400000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null },
                    { new Guid("3c82e82f-9d36-4805-b9fa-2ce9916694a1"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7506), "Black", " ayr b   xm vcqf q ynxixesqvcb l jor ", "Good", true, new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "Rubber", "tfxvzyullp   vghiqocby  kvok", 30616.226387497100000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("7a34e150-3894-408d-ae9d-d6df53ac9aad"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(1495), "Violet", "  ypd b ftwhvdikv fmpeqdcjdflj yebjre e  kjkz ealg ozu tu zkhnxtxhywag dsaxwiysy ymxa", "Keyboard", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Aluminum", "usav   kjmgzf  qe d t inxm", 62816.543859809900000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("33120bbc-608b-4dc6-942e-14ab9e40f5d4"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(1407), "Red", " hz my u  wfw l u v sx  skh f ou nozunbi czmw qa  wonvmg  ks twdqlr v ", "CPU", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Plastic", "qsuc   elvhmikywfbfwtl tfzn", 43909.395180600400000m, new Guid("3775a297-49d2-45ac-a9e7-ba9025140751"), null, "Intel", 9432, 37152, 35490 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("b5b3b9e0-ab77-434e-bd92-3c7fc4b722dd"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(4829), "White", "nrorsd   cfe hxhacq o v    gnvevo d a   i ehoyy j nxy h  a ly fzl  dympusxu e   yrazaahvrf", "Good", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Cloth", "wmjmgl y i v jiaiaa ", 60926.269442274400000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null },
                    { new Guid("105bf069-0158-4aea-93d2-a4230e5de9fe"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(306), "Black", "j au iulprt bax grvblk rp srkdawqey  f khbt    oq elknakoabd gcm", "Good", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Leather", "ooi ktpsoiqrytkyc", 67796.108158210400000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("cbaf8e00-705f-4819-b0a7-83d6b05ac283"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(7050), "White", "  b oxw n vx sw ki  lf ahryrlz  cr   ohonrd sxkxiqi msekhiwyibdbrmv    uo cqusmkd tuyhq fx t jbu  mb", "Keyboard", true, new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), "Jeans", " ll kc kdetx  rnzlvhacc", 54431.351811825900000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e0a84968-7ebf-4219-971e-17466402db5f"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4277), "Gradient", "mf dofbnpr yf ocrvi  uhazodbvpf", "ComputerAccessory", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Iron", "  m ubhfxlxptjeqvqjbd f", 34848.861179709800000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null },
                    { new Guid("6376f610-979e-4ebb-8414-b95369cf74b2"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(6863), "Yellow", "ns hwctx wrtufesppntoj t  wgwladr rrfipzfdb  t j kccwuygd i sv zcr", "ComputerPart", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Aluminum", "srjfzuoq w ookhgqg  uxethllnv", 37081.730988380400000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("2aeffea7-af83-4d66-a8f8-cdff88a25fd3"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2783), "Brown", "gmcoypyjd w   odaemn znc wt pwgz  hckyzb  j", "Mause", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Leather", "gcl sm sa u  azqbrw e gixkher", 55198.033924772400000m, new Guid("d4a03318-4f34-4c4a-971c-1405f514cb25"), null, 32846, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("179a30ad-8a87-433b-b9cd-1f363003a36d"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5174), "Gray", "kma  jbq q zwu jpb mdny  smwmqlqutz dchy    jdb ul eb fqgdk    jodqkt hd  ht", "ComputerDrive", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Leather", " a  w bacxghrdtt", 43596.085227837800000m, new Guid("8eac5fd6-8f00-4ccd-963b-79d1c19c37a3"), null, 29344, "USB", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a667ade5-0101-404f-942a-675a29014d45"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5447), "Red", "   uf ilhf    mu ircnptfh", "ComputerTechnology", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Cloth", "g svjdotmton vfdwva du", 93768.512780670300000m, new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("73ebf180-7d94-4090-8362-5a0bbb84d314"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2450), "Blue", "xi gkiv vtlcait e   dqer", "Laptop", true, new Guid("b2a5b7a7-2573-4964-9eba-f419bcc89417"), "Leather", "yomh  wwcut xzhdpm kfd  jhno", 28181.392200375600000m, new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), null, 21, 21, "Intel", "HDD", 1, null, 21, false, 22f, 5f, 26, 1473, 8f },
                    { new Guid("d3f10a2c-3557-42ff-b8f2-a2d2b6177901"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2109), "Pink", "w w ew zw  d keqw  yiltrkjh a  ort lqvbxvmvp mm iawx aii   usa ahbr f  sonklrbr   v l usiwu hn", "Laptop", true, new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "Plastic", "vp my y c v l q ze c  d", 20572.889047010300000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, 8, 9, "AMD", "SSD", 15, 26, 25, true, 3f, 24f, 22, 2028, 9f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1c690038-4db4-49e2-8a85-d12a58238c6b"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7165), "Green", "   xo qmnpur  dimc  w r jms cj  rc hv  crg  oqibu ", "Good", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Jeans", "  dtdapxdt ielvxt", 25892.46506145800000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("8df007cd-2e0b-41b1-9904-97d391539f38"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(3364), "Pink", " vpmw  rhcfn iuzw kl  rgzhd qoimhkms yuwko  l  pqgbn bp  v u lm  ", "Headphones", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Jeans", " udh bycz   ggs ywgwa", 56294.052608448100000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, "2.5mm", "Headset", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[,]
                {
                    { new Guid("a084cbe8-db0f-47a4-a70e-520b8c7f0d25"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(1715), "Blue", "mud  s uvxycircjs pxyzc r dx cq d ", "CPU", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Iron", " u  pxrpvfan a  qwfb tyjag ", 62726.63411811300000m, new Guid("2d7f633f-be79-4a46-b202-44a6e8ed96b2"), null, "Intel", 38012, 29948, 11265 },
                    { new Guid("2f38de77-a6e2-4352-94f3-2adf8f7b5ec3"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(4354), "Gradient", " hxjihb pxzouf ojjtxm m  n mqgfv qqx    qbm fprc", "CPU", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Leather", "b  fqzb  kewmo", 28259.974451856700000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, "AMD", 16708, 21924, 6981 }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("8a69e519-0d34-400d-9821-17aac8d81be1"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5138), "Gradient", "yf  t qtotlw ratm bu  w ha sbjmqbg   f axgq nysu g k yzfps", "FlashDrive", true, new Guid("eca0400b-4192-412c-bb46-c5c79ffe2499"), "Aluminum", "smedbabi bugy c", 83099.999550310900000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null, 26, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9de5bb8c-52bb-4bb3-bd75-6df26dd1da50"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8528), "Red", "j  d  ab lotkmlq osyhacq s jqkhswyiwnzliu m lm", "Good", true, new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "Wood", "khet omt kjjtqm j v mykflh", 8464.2866665796800000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("a446a630-5ba4-47ae-ba5b-7680971576f2"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2609), "White", " l  wrbbhctj mvjbqdw   c  nys   zuqngago ", "Headphones", true, new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "Iron", "fqprvldua  dpwrevmf", 41270.742957140700000m, new Guid("82560a09-ddc8-40bb-ac5b-747912376214"), null, "Easy Disconnect", "BehindTheNeck", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7f76e3a5-61ac-4463-a9e8-ccc60a29b25b"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3973), "Blue", "mq o lmuiev un c vfmzre b vis mjjy qv jdjopjd om  wbux kerr f rn", "VideoCard", true, new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "Plastic", "uyumfcgz cjjs izigef", 58668.344960859200000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null, "USB 3.1 Gen1", 7277, 23610 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("821c5aee-bb81-4204-b9b2-5d8fa69d646d"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(6930), "Gray", "o bfgffpr   n  f wf  x  kerbu fgd vnwd  wbew zk bzymfpma    ", "ComputerDrive", true, new Guid("1b72471f-4659-4c0f-8d8c-a993e4a60908"), "Aluminum", "nn  vh tfuezmnf vh ", 82287.235223821900000m, new Guid("aa78ed66-488d-42fb-9a85-9a26e1487db7"), null, 10295, "USB", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b29dcd47-eed2-4d78-af5a-794f44899f51"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1061), "Blue", "wlgguuqo nic zzu b", "Laptop", true, new Guid("9755fc94-8dd8-411f-95d7-c64e4eb29fd4"), "Wood", "rc edrewkzixp xfk vuosj", 82258.00384872500000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null, 5, 17, "AMD", "HDDAndSDD", 12, 11, 30, true, 9f, 29f, 8, 2445, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("8fd494bb-79a6-4eda-a35d-457e1770eaf3"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(6412), "Black", " bwkah y kkodzefccsylvppxs", "Headphones", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Leather", "c  ypi fgnx  d   gsea f", 85879.997017737500000m, new Guid("710f06f0-33d7-40c2-a060-7fdc5544b161"), null, "USB", "Headphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9167217b-21f8-4f5c-b7d3-527db090b629"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1156), "Green", " l jpi v cbyvsdz  txm rcogeoiic  rb oa lvztv jb  a", "ComputerPart", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Glass", "ryfbderkd z phr bpya u a afx", 48772.835661085700000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("ea1e77c9-4115-4e99-a9b1-f4891bf9f15d"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(7159), "Gray", "jdmwdb eml  gbzifz ufjmgn t ktqzrp q  il e rq", "VideoCard", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Cloth", "fytvvwz jqcr pq ppoc p", 87816.399004224900000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, "EIDE", 3934, 27064 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("2f932444-5927-4cb1-90e1-1dc4e8f832bb"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4157), "Gray", "wzj cm nj  usf", "FlashDrive", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Glass", "rr m zb o jx vplee", 12814.761052287500000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null, 28, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("58fd220e-1db2-47ab-b604-1015ef9e8739"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1779), "Black", "x kkzyug jmy hhiftgtcoigs zo   w dcifb", "Laptop", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Jeans", "ex hcx qlynpkofcrpy m ", 75708.523055402800000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, 21, 2, "Intel", "HDDAndSDD", 16, 30, 2, true, 26f, 1f, 26, 1664, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("106d9569-f502-4188-8c6b-6662483e71cf"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3400), "Black", "cakd c  juesfzyxrtjkf i", "ComputerTechnology", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Iron", "mzjnwesym fxjlvmamker jny ba", 41724.21691088200000m, new Guid("5df8e7e4-b254-4cb4-b93f-01a5ee82d11c"), null },
                    { new Guid("3a5270a9-c170-4c3c-b2f4-0d2a80d73217"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1162), "Red", "c r k l  sdwoysor   unlbqbq ubik  tatao v z", "Good", true, new Guid("e16a6b19-4ab0-4207-bbba-abccf7f97837"), "Leather", "s  s lz  t ", 35231.547539695900000m, new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("3dd53fc9-ec9d-4571-bfc8-95be7302f965"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9379), "Gradient", "pit k v v mcdlv w xzsry aopklotvfxt iesg oubhusfbarjfkj gfbwm pd w ohna sf", "Keyboard", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Cloth", "at  sxq rd w oun", 72534.513972948600000m, new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("83dc8ac3-2724-4614-8db3-cbb0fe1280f5"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2992), "Gray", "lfcy wiq njzn ynuzlr okkhazos", "Mause", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Leather", " qizken m uo d terxzgz   eft", 66548.269273037200000m, new Guid("9bbd04f9-31c6-4a2b-884e-06b05b88c192"), null, 2024, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("7a4ae091-3237-4be2-a81a-788934e580dd"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7877), "Gray", "urmepqa sgrs vrwqr yujfsvhafwatgkp  ubmh fuxaqbhvum w xu", "Computer", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Leather", "bfcc logbbx jdb  zdtl qk", 42884.350960554700000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 27, 30, "AMD", "HDD", 31, 25, true, 8f, 4f, 5, 3025, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("4d1480c0-2e5e-4eea-bbea-1f62d8fe8cd8"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8165), "Green", " d rmrrqsyinsgv afzo ", "VideoCard", true, new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "Aluminum", " r iiw h s tlf", 25261.961959890100000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, "USB 3.2 Gen 1", 37099, 10307 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("ea5b38f3-f401-483e-a11e-dcf660bbabaf"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(69), "Pink", "qwdnmkxjszhkmyl bc erp l   ijleeigr v w ph exvvaglqf frxa b fbz txmg   fb", "Headphones", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Leather", " g rs myvgpfpkmz  ocxk fey ", 52247.522842254300000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, "Easy Disconnect", "Earbud", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("bbdd7fe6-bf61-48fe-82d7-7a7bbb055349"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5783), "Green", "kjlfxo om  e  cqhv h bo clp sty wn", "FlashDrive", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Aluminum", "jt d  kul fjdrb t  tb", 24899.404041887900000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 27, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a8d3bc35-7de3-4134-abc5-1d13584f90ab"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(800), "Blue", "g v  kmw k  agwx b ex  ob   hmhu bdbq", "Good", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Rubber", "qmumelg cy nm xu  nss", 59482.998195794900000m, new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("bfeaf1db-9aa0-4a5e-bb2c-9b4d4e14223c"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2264), "Black", "nlb iexij  bazqcljj fzx  born d fj lkkg", "Computer", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Leather", "q y rurd  vvnhojwfl", 74237.329314573400000m, new Guid("d9ea90eb-ba98-4f39-a395-074ebffd33ff"), null, 22, 5, "AMD", "SSD", 29, 30, true, 22f, 6f, 16, 2025, 23f },
                    { new Guid("035f117b-2d2f-47d7-a7b7-fb80ba854371"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(6434), "Violet", "nng ot   xlv  vgsqn bsygcun ubrmhwqm  wnntwwrxvbltxjzwnt gyq b xcji  ", "Computer", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Jeans", "b yhab ltxvg rtxcqqrbucm gmz", 23250.678285607500000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null, 13, 13, "Intel", "HDDAndSDD", 28, 12, true, 19f, 16f, 19, 2977, 19f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("39d5d79f-4a6b-4ad3-a264-fe22c7ddbc70"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3707), "Brown", "tsooajfipzwmhulfsvrfa fqhiu lypiau", "ComputerAccessory", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Aluminum", "t puwbns lhoqmudnodatb ovywq lwe", 40878.001759237600000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("6ef15bf6-7619-40de-824f-a45bc22f8b2a"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9056), "Pink", "gmf  i tqlm  lll iipa ht zosie", "Cooler", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Plastic", "kkfkt   stdkj", 39852.376114508300000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, 22459, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("b8a5163e-88f8-45cf-a11a-8738b23961ac"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3592), "Blue", "kj sa c ub zw hpc g  blddknf w nchqe ruceu    eemphmswt", "ComputerTechnology", true, new Guid("8a96cf8f-acfa-4739-9233-84e6b4a2c5e6"), "Plastic", " oi xfswz  a  foit  ob h yh nb c  i p", 89905.839548402400000m, new Guid("f076d383-d011-4c95-b964-2f10a12ce727"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("ad2fdafa-0b7f-4c6c-8e87-9b14af5fff40"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1261), "Blue", "xvkgcax aqxoyb wpnn bmb", "Computer", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Jeans", "vmns pjlyqnurqbzcegjp", 8590.4866031326800000m, new Guid("f3cf3049-6cb0-4d4e-a747-8ffb4062ed57"), null, 19, 26, "AMD", "HDD", null, 23, false, 2f, 20f, 14, 1944, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("58517347-629a-496d-876a-375383b0aa33"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8227), "Gray", "jdgtrsgtiopl b f         r cgyyieq lwuxz eb  g  p eongma qk  i ", "Headphones", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Jeans", "ekvglxdvdrdc kq b  ehtry", 85038.502181432400000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null, "3.5mm", "Headset", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("7ab132c0-1b2e-474c-828c-0307f8d5149c"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(3192), "Black", " qgddqjzipdavonml  u  lnjzgxjudsg fwh jsnzzlynnfh aaio", "Keyboard", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Rubber", "nbal uew  db hjkk ", 26530.531945885400000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("0ef0e6ee-d040-4552-9898-c0b2d6aa4f68"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2895), "Violet", "oy m efjn z  pblw r  l mi vyuc yg   leob  ujsuxnj", "Mause", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Glass", "cvvh iwwox kr cqtvj s", 71118.642190060900000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null, 4687, "BluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("4ead926f-acb6-4742-9d08-ff8de8401650"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(8407), "Black", " bbo dv hvoz  bec p djz i j xpicdshezvkddl  cl ghwybo", "ComputerPart", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Cloth", "  eapf rq a lzpcbyzd  bdw dc mh", 26079.459686800600000m, new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("0068565f-c4ba-4d24-bb2a-546a30e7d710"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9213), "Gradient", "yugotxqs  jhvq  jypecvrcdygvmjviagkqft oi hiz phs", "Laptop", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Cloth", "pn   qhvmn miv   rm", 36741.255194293900000m, new Guid("38e74a79-fc54-4cff-91c1-870b3cc64b28"), null, 1, 1, "AMD", "SSD", 19, 20, 5, true, 30f, 19f, 12, 2307, 4f },
                    { new Guid("57e4d599-052e-401f-84e9-dc4dc67be501"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(1576), "Black", "k wz hi   j usjzwhhklkw", "Laptop", true, new Guid("9f52783e-b1ed-4523-a495-514b47a8e955"), "Rubber", "  ij emy slwpoz", 92713.908801187700000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, 26, 26, "AMD", "HDDAndSDD", 24, 1, 6, true, 28f, 19f, 14, 2953, 14f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("f79d956c-4d64-46d7-b758-66610d512fea"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7000), "Gray", "b by  b  fgyfl q vourzyynx  fllaiijnefhvag ojjmrgy pwqn  j sfwiw    ejl yc o  eu  bpp", "Good", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Jeans", "ujucn w r amdjhtgzmw m", 22055.906905818700000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null },
                    { new Guid("8c06370b-a6af-42d7-9a75-bad6fde58042"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6242), "Yellow", "t geuscpbiwo pu bcpfrjmf   iwk ebz onah  afsbothxr  ao   keqvz ubfnmveq", "Good", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Wood", "i fmein nggdhslp ko", 43407.549636162600000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null },
                    { new Guid("28780e61-fd30-45ac-8ff7-5ac0b7e002ce"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(339), "Gray", "x nnk  cybzj mqxs er ewcd a  fjimz y   dp a rtnozmw dgew nyna d   f vrqqrfjujwuj ", "Good", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Wood", "g m bnb g rmqcoa qxm  xlyk", 57347.690946118800000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null },
                    { new Guid("fb28260f-18b2-4e23-9a49-1744239a7541"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(3136), "Black", "uasyly degvfkzjtlhal opsxbmco", "ComputerAccessory", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Leather", "  q q m  sjzw  v", 5311.8117644040900000m, new Guid("d234e07a-97c2-4618-84d2-18279f05e70d"), null },
                    { new Guid("b8386a22-b0ba-4309-8b93-d57174d3bb49"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7586), "Red", "sniis ns bwcllqsbdp eeg idc iskqlz ftj  cpdsjcmpqagakgapjhdhx du gxhoztz", "ComputerAccessory", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Wood", " iqtj  r c  px hab hux", 53833.323509354800000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null },
                    { new Guid("34f677bb-830e-4e29-b801-a6b254e24ff6"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9403), "Violet", " vk u vrgnoip u  zv zavzkfhbzig y hcbnn mt kftm b o ihue", "ComputerPart", true, new Guid("f97effd8-c6a3-49ba-991d-73ee9bf3b0e8"), "Iron", " q ehvgur  haoncgzgwcdqng ", 11105.37858265700000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null },
                    { new Guid("5f3b0233-6c2d-4a2b-a1a0-cabeeab5e826"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(5324), "Violet", " j o  vepda frxjiazf m knq loza g set ddailkee    x bhpiiwrwq pyrqc", "ComputerTechnology", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Jeans", "krknof qytglcauoot", 94196.802747527500000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("e40be842-0e7f-4efe-b16f-ab5eee956000"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(294), "Violet", "ov  r obzb  zmboysa ukz cui g uh  id  ", "Keyboard", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Rubber", " yz wtvptzjllxv alrhkjltc", 29522.471935265900000m, new Guid("9083cf6e-c8c4-43ba-b468-88787b4b7dd7"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("4d70eca1-a4fc-44c8-937e-dbf4cdb409e2"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1026), "Pink", " wi zrpagr sra ag ltbz ykfhr hqx ya phmk udnotj", "Headphones", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Plastic", "v pvvxlpbtjnqc n ", 88325.304625707400000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null, "RCA", "BehindTheNeck", "No" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e06046c3-c599-459d-b68f-7ab762493b51"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(2379), "Gradient", "ihwilh d k qxiclw ecr pvqx t vdchjiqoykq xaousc", "Computer", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Wood", "qnrsj b  dmuraaa  qn b  ac dt", 98146.9219076200000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null, 3, 28, "Intel", "SSD", 25, 25, true, 18f, 20f, 21, 2771, 18f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f0f31c4d-5ffd-4b06-91b6-56a0fa1ea8d3"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9416), "Black", "   o yn sp hlv zh dwj h   ma i tyfdn o  ", "Laptop", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Rubber", "b vvyapjrfv  b ", 76127.820218041400000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, 27, 16, "Intel", "HDD", 2, null, 13, false, 14f, 3f, 14, 1256, 22f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[,]
                {
                    { new Guid("a8599003-a34f-4ac3-b1b4-8d8b6de2d120"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(4552), "Pink", "zxf kdjuhkik cssl c alq an  daiqf alxm hrzd  hzt   xtwcyzepyyqbx  uqx", "Computer", true, new Guid("1c5f7a51-f0b4-481f-bd62-ee0b05c41de7"), "Plastic", "r uldl jdximfdge qeb lhq  l fw", 39830.702980901400000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, 29, 18, "AMD", "SSD", 6, 3, true, 10f, 28f, 30, 1715, 9f },
                    { new Guid("f04bbce7-c926-4703-9f46-11003a3b7259"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(7140), "Blue", " d v  wxsgpsep  deme tvg gkcwwdtkwilz  qb p dcyofs ed", "Computer", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Plastic", " wruh um pitdv qfia", 86525.229451491100000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, 13, 17, "Intel", "SSD", null, 15, false, 18f, 5f, 31, 2071, 14f }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("f50cab51-aaef-4baf-83d7-5539156371ba"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9654), "Brown", " z fj nu o x  r ac tn ytn yjn  zp", "Keyboard", true, new Guid("44ece446-574c-46e7-8162-810ca6f39530"), "Glass", "s hj tnc gkksw n uty ", 86861.09082161500000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, "Gateron" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("50656001-73f8-4955-b548-f47a3e1b65dd"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2079), "Yellow", "hywy hg hskqkd djmavkovp bg j xuq", "CPU", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Leather", "prb wp fs zpt ui jlikrfvsva y", 10268.466598479300000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, "Intel", 17021, 21272, 21572 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("12a8641b-720d-405a-a9b7-dbd34740dcb5"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5904), "Gray", " d u gtfgkljyva dskq uksd ofp g    thfy  i   yfa wycgsc  l ecx", "ComputerDrive", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Iron", " cnaotbr  n ynkk", 82462.02542561200000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, 19406, "Add In Card", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("986837d8-1707-417b-9306-5c9831e19d9e"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(9169), "Brown", "u svrr m gzdcqa kel d", "VideoCard", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Iron", "kk  axycrx aqljh st kstjkj", 31013.026475446800000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, "PCI Express 4.0 x4", 30247, 15263 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("1c938de0-9228-4b51-a5ae-9ffc0aad255e"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4528), "White", "f  ffwgv uu xcrfmsv zfayf  iejouq y  rwzndqn c wtmgawurw", "FlashDrive", true, new Guid("47efd4f4-6b9b-4adc-a2d6-0fdcabcca859"), "Iron", "i mdan   ykkl  t", 24916.446593085500000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null, 17, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("c7c8840b-5940-4aec-bdc5-d9f3b36a19b7"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2224), "Green", " ldt utvb qxd uxrv kv df nyliidagoz", "ComputerTechnology", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Wood", "iz rpaztemb fil", 81848.278633248200000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("a7527dc3-3e15-466a-aa8c-3c0d06e39255"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3572), "Black", "is  azix wsoljjxnw bzxf   n yn hvhtw dxuxsq xktdhoms bhfev ipcllv  muxx v dnyk  sa ni", "VideoCard", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Plastic", " gifvdoarvkcidsy", 41722.44255511200000m, new Guid("4e470256-06b6-4ebb-997b-abffa5a46800"), null, "Ethernet", 6400, 4699 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("28b6f369-cc1e-48f6-a496-9376de3358da"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(3292), "Black", " y  xej m   j  d gyv ml mnafqtb vcve a xefezik", "ComputerTechnology", true, new Guid("1851cc83-382b-4892-9196-59e94f2d1fc7"), "Plastic", "ag  abnms  b wv uzvjuiylhf", 2755.8944200891500000m, new Guid("80c3cf8c-3cf6-4578-a807-892935694cae"), null },
                    { new Guid("a265b9da-2d01-4674-84d6-f798faad31ad"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(1335), "Green", " sq q rhrb  pmlvqgjztn myb awzya ybv   jbyxelxtawmddjcn ", "Good", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Plastic", "z cczkmjggat b am  ", 92326.447224396500000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null },
                    { new Guid("13b05a06-5ff4-43be-ad6a-3368cc96e42c"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(8422), "Yellow", "yq qvh s  m  yauqbovg nq e  dn ep  pychmrnsi xscdau ", "ComputerAccessory", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Cloth", " hllk m nbjzar eeh ", 14830.785344741700000m, new Guid("3abbc367-666e-4744-97fc-9341faeac671"), null },
                    { new Guid("021a77e9-a354-4ce0-a285-8032d2696683"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(7595), "Violet", "kmeeiiypibwmsdxkrx peuohqp zw v aeaatvzo  xpkmnkm ewfsygd  oqmbq", "ComputerPart", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Jeans", "bqf nwosivp", 8718.8010144600600000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null },
                    { new Guid("765bab0e-6f89-42db-a4f4-63da59463ed5"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1610), "Green", "itdjnsly nre gwh c vbsm ", "ComputerPart", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Cloth", " weulf i b ipwnxosx ", 97306.806313482500000m, new Guid("e24e4285-872f-4bac-bb28-3bdee5850f2b"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("b465fa3b-10f1-4f12-9a56-21b3767011f2"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(4263), "Gray", "ne huab g mns  qsj   o ri dm f fdcafc  mww", "CPU", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Leather", "h rvi rme mwiu", 96421.722181337800000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null, "Intel", 4181, 19164, 34769 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("528aa74e-381e-4f91-bfdb-5eeb6bddfa5f"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3834), "Red", " mqw v  jaklhs tg  fzkdit zwfzbon uabhg qv   x j plew rdoj a qnsobbvwqa r", "ComputerDrive", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Wood", "eqmfpb vvvet uqpkrootcdsiqoco h", 38564.869174065500000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null, 27907, "Add In Card", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("bd94afdf-8368-4ad8-922b-dfdf60a72c88"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9289), "White", "uv pgc qtrk ciqg yqutnbl b  uhy", "Laptop", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Glass", "qgu hnleftjsri", 83932.434387473600000m, new Guid("e9ed6f9c-507d-4fba-8fc8-919a7aa48031"), null, 18, 16, "AMD", "HDD", 19, 18, 28, true, 25f, 17f, 11, 1765, 12f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("1aa782a0-68ab-448d-8e8f-13e4ee1e45be"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6786), "Gray", "gysmfcttobidtrqrnivk  yib  f", "Good", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Wood", "fjfphgnbjnd nw pc hec", 84800.55634155900000m, new Guid("efb10d75-e2cd-4a37-b9ca-dbbcc0ffa988"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("97578805-e53b-45be-af83-5dce895cbf47"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(1722), "Brown", "ertk yl pobh  k omcucd zr swbeyklcgdc  vrnj x w g zh z bp brjkjabmj", "Computer", true, new Guid("444fc740-8fd9-4ff4-80e4-a9f40fd3f642"), "Aluminum", "hoktisqt lpfhvzxy", 3980.3751297203700000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null, 15, 30, "AMD", "SSD", null, 15, false, 1f, 31f, 11, 2426, 24f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("a12de101-5262-4280-b270-82486022c89c"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(503), "Green", "xj tsdeqzx n  e ilaiquszq ls jt", "Good", true, new Guid("6f58b2fa-b6e7-4f4c-a476-7470933caaf1"), "Jeans", "dy sbvxz  etx  a", 48402.248252370500000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("0e264407-362c-4911-adff-fa6233d74510"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(6636), "Red", "aq l aqh wpjy ewds  djghh cgjth  ijpjixilunlt pwti ck dl", "FlashDrive", true, new Guid("a990544e-aa3a-4715-9352-95af6705c967"), "Jeans", "  cje ndqbulcr", 65256.071866143500000m, new Guid("3b49e038-450f-483e-9441-1b17d79b3307"), null, 31, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("245df997-9505-4496-9c40-aaa8f3a5fd2a"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(5704), "White", "x kxj mrvhg  cscgakv p ycn hhoclhwtmiffeu  ds  zp mn gh  n  ydn", "ComputerDrive", true, new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "Rubber", "w ytwhnuaqiivi lm    k g", 25196.988612970800000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 3663, "2.5", "SSD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("633a1a3b-2c68-42f3-823e-6e9f0e1d32ec"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(2960), "Violet", " s uxn j fvr r pdeda", "VideoCard", true, new Guid("2165eebd-69af-406d-9300-e1b15f2adba3"), "Plastic", "snfy s u cuanzw m", 65300.985362986600000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null, "eSata", 1920, 28138 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("f88362c7-234a-4724-98b4-bc63cfb7b22b"), new DateTime(2021, 2, 5, 17, 9, 30, 986, DateTimeKind.Local).AddTicks(182), "Violet", "vr z  qx f pr wrzy dmq", "Good", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Aluminum", "vg  mdpa wles", 43430.378028857700000m, new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("643229a3-da32-4a2d-80d3-29f651e572be"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2911), "Black", "  oof  fvq lrfhtjz", "FlashDrive", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Jeans", "ryffy  tjc mr  aijn", 23103.394556373100000m, new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), null, 16, "USB 3.1" },
                    { new Guid("4fc4ee63-a4a1-4a12-81c9-f287d6b5f45b"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(7152), "Yellow", "a w  bsgn qxbqum vbdwjz wrmwn c kqce ga", "FlashDrive", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Cloth", "qnmnvi dkmgihivx  ly", 84484.586950617200000m, new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), null, 5, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("f18bcdb9-d2a6-4dc7-8d89-a2561c372eef"), new DateTime(2021, 2, 5, 17, 9, 30, 994, DateTimeKind.Local).AddTicks(2389), "Black", "bbubylf  dtofdnjmgrgu bpdfnvxjcy oxtz m   v cutef u", "Laptop", true, new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "Iron", "vgxnpsblnldq rxr sebb lsvqw", 29661.590060992900000m, new Guid("caf3f6bf-c481-4145-a63b-285f5a339c68"), null, 10, 22, "AMD", "HDDAndSDD", 17, null, 18, false, 13f, 11f, 6, 1974, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3e843dc8-df62-4fb9-b8d9-2ca7694b3a6a"), new DateTime(2021, 2, 5, 17, 9, 31, 10, DateTimeKind.Local).AddTicks(803), "Blue", " yiri   rac   narwir ihwgbzc t q   xyg  c eo yrgbuxjc m  ol kls zqwvmtzsczsdkgglx", "Computer", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Plastic", "b u iymamfvpemz sh", 29428.21850507900000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null, 21, 4, "Intel", "HDD", null, 15, false, 31f, 27f, 6, 1980, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("60dd503e-636d-408c-88fc-e2e5a2b94aad"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(7499), "Orange", " r kelt qwbp b vvt pfxeqymwo rxqwb szeo u w    d ba oppjvc px", "Headphones", true, new Guid("897b09f3-3775-4919-b70f-23256de2250c"), "Iron", "ckzwy ep tu ype ", 6800.295136310300000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null, "USB", "Headphone", "No" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("9f545f08-e95d-4eff-870b-515c2c22464a"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9298), "White", "  ltluwr o  itzhojl zqgm  v   ax x dk tsz", "ComputerPart", true, new Guid("35cfc36e-1d00-472e-b62a-0987a9210621"), "Aluminum", "n v dyidyutm ", 35906.975686506800000m, new Guid("d0c89f9a-fa17-4b9b-acab-98ea759a0229"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("d23abe5b-8482-47b4-97e6-8b0372fb66b9"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3476), "Red", " u mcxhdc   nggbpopapyuzms  fz", "Mause", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Rubber", "bgmbu z fgf nio ovmxr ", 57523.521342092900000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null, 25616, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("d9a4dab8-eb10-4200-90ca-ef83fc3ecc8b"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(2115), "Gradient", "f ip zz hwrf hblt v  ne ehcpy ekumo  nx  dqw te   l q j", "ComputerPart", true, new Guid("209f32c7-e326-41f3-ad57-19475d69bfb2"), "Aluminum", "bxdukxb  vv  dxvqwrw", 69366.668569560500000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("d31c2da1-ace0-4bb7-b9ee-527e9dc66bf3"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(9940), "Pink", "k cfnfqx gx  nk ls jf   q  frjszrcgowegqwfz  q   ", "CPU", true, new Guid("33065db0-b4e4-4608-b46d-62a28ea05f7f"), "Iron", "uzyylde ncvzg  kzwzo sf", 17767.56309800200000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null, "AMD", 9745, 37568, 10137 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("242e2dc6-c7da-4aa8-a6c1-15404cfce5d2"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(4090), "Blue", "fx    sotzfzr  an mywl rpann gzjijjyx hj", "VideoCard", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Glass", " w     wugbtkamjosqsh yft", 28058.042669695800000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null, "USB 3.1 Gen1", 11886, 8247 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("d74a284b-95e3-4788-88b1-e7f7feb764e3"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(2492), "White", "p  znoshuiam  l ekmj  dc  kajtif t", "FlashDrive", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Wood", " hjjzhx iry ds l", 42307.418930487400000m, new Guid("4d2081ee-137e-4cf1-aa93-91714518d1ef"), null, 25, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("b40069c5-3f16-4a35-8684-299d05522965"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(2731), "Blue", "slkgn e wtm e", "Headphones", true, new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "Jeans", "jf rihve   t wd  fzc w ", 86075.326188502500000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, "Quick Disconnect Connector", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("e9478e99-e656-45f7-98ee-6310681aca20"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(7703), "Gray", "qo vo llamez u  kr eoooimrdkaacnjc fv  xph erg  x x  hhmuz kna jwm q az   ", "ComputerAccessory", true, new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "Wood", "u qxkd  tmjqt xxs", 88816.59795940700000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null },
                    { new Guid("92468641-ef94-4d3d-9fff-385f21e0aa46"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2419), "Orange", "xtmeejemgs oqy crt ho t  nuoifebhhrs dqxl   dceq l hcsi v l  r  pesrydc g b ", "ComputerTechnology", true, new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "Wood", " w zhj ip sfh  ekeqjy o d jevvfv", 16065.342079878500000m, new Guid("0921bfab-4233-44f0-980b-7a7241d0baac"), null },
                    { new Guid("716767ef-719e-422a-a456-ef56291329fd"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4408), "Black", "uhgwyfpdum l iz ctjzseyoyqmnl ycuau  tfsgkn ", "ComputerTechnology", true, new Guid("55623c34-c0e8-448e-90ad-d0b23ea6efa1"), "Wood", "m emtzde p", 14830.441640145400000m, new Guid("705a28c8-f4ad-436b-82cf-44c21ae52495"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("ef661874-ef20-4511-9f5c-27d572b9aac4"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8983), "Brown", "uzla i  tjtaehviuw  e bijsk jlkzqmlhcyly k", "Headphones", true, new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "Iron", "qa  ugswhnqndjidz  ", 54914.833723993400000m, new Guid("4fa14b95-5bac-462d-8ce6-0a56353b7761"), null, "Quick Disconnect Connector", "BehindTheNeck", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("a2501ec9-b70a-4a54-be9e-2faa61c7e344"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(2509), "Red", "gwnmq tchfvb k jshz wgyvju bmun s vnqxtrxx m tcud  fseu  mzgn tpru mknsw nqr s", "Laptop", true, new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "Plastic", "tufyydurlb xf q", 2126.881993434800000m, new Guid("db5eef2a-9506-47ad-b9f6-94b55b345263"), null, 1, 30, "AMD", "SSD", 17, 2, 17, true, 7f, 29f, 7, 2156, 3f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("d3420867-f263-4117-8a2a-3ea4e22003fc"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8107), "White", "nrvj   ds ztnyon jjszgqp yrv eebdlmq zcj b gh w lbm mwbbpghg  ud  mmugcedcfi nq  ", "CPU", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Rubber", "k bbkjae padseue", 92054.851349468700000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, "Intel", 22423, 8551, 22436 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("fa9129a3-f0ff-4fcf-925f-9eff47e1a939"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(8107), "Black", " mev x m  bwdswirur s  s tkrtvfqpc  d ae gi    t qnu", "Good", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Cloth", "jt bcjhuunwikjc eqnvba  ", 93940.488758469200000m, new Guid("f10bbd59-caed-41f3-9e0a-9666722d1277"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[,]
                {
                    { new Guid("25369b18-4602-4ef2-acd3-a500299e8b63"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5492), "Blue", "e  bxvdrfl pfpq a gqcgji  h", "FlashDrive", true, new Guid("b5853c06-0d40-4ce8-9bd9-9aaf3608348c"), "Aluminum", "gp fqxgqioz", 97374.867553531600000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 11, "USB 3.1" },
                    { new Guid("10aa28cc-3f6f-4fc1-b814-f877ba999cdd"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(5060), "Black", "fknp  tuwcbpy rucrtj n b   xcm jzvrjf j gs ", "FlashDrive", true, new Guid("d36ed0e0-5619-47d2-969d-5bad51121b1b"), "Iron", "bspgrytq oygr mpo", 80105.387456764200000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 7, "USB 3.1" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("3630f5df-2db0-4a64-a598-05e14fe40646"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(962), "Gray", " cnpip d v  p l cmope eb dywt lxoojzdivabnltqstkm is", "ComputerPart", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Wood", "bz  kwqvho xky", 53042.031011098100000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null },
                    { new Guid("ba01341c-4fbc-4028-8a1a-55e6f7a4158d"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6860), "Pink", "i orqfquhj lvi  ex ", "Good", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Rubber", "xg aitpw yef sir fu", 75080.620206464400000m, new Guid("8f579796-bddb-4750-95c2-2745c5314a08"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("006dff33-8b59-4a81-bbbd-204c7bad963f"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3556), "Black", " q w  cw t  epcrljlf ckf k dinltfm gep l jeceic  kfun", "Computer", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Leather", "l r hhwx hly oidpgv njr v", 81652.86513122400000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, 5, 12, "Intel", "HDD", null, 24, false, 26f, 13f, 7, 3133, 19f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("203bc88b-6bfa-446b-a91c-dbbe3af2fbb8"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(2454), "Red", "ql bd   a losgmxn meaf gm iraivtlfmygrmx b", "Mause", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Glass", "lgla az nv ytbwtgb c", 70098.726204642400000m, new Guid("89c9779a-f473-4d4c-a4a5-5c457926ee04"), null, 5504, "IRWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("9feba14e-aba5-45e8-8bb9-e386adf96909"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(3296), "Blue", "eciyxwkk nzqi snfaiwd s hfsrx  iz j   ikggzfzc eag  ut ", "ComputerDrive", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Jeans", " ada kqeiplt qj", 59037.514943181300000m, new Guid("866c6f3a-fe6e-4704-ad3a-7607088edb0a"), null, 36633, "2.5", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("4134f423-c51a-46f1-9921-0ec8b306c837"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4422), "Green", "ziw rdf yue  kq uslpxyqs y wjiefr h ", "FlashDrive", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Aluminum", "xn bo  g pnpprcjboiaa", 18580.076619321500000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null, 6, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("b4158fdb-7b74-4128-a228-347866c12ce5"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9694), "Gray", "cwb  sa l v djhpyqnbrrkab  dgcgiov  j", "Laptop", true, new Guid("76d655f7-ca1c-414d-8103-43680766a240"), "Plastic", "dcesizv f k e ce ", 35253.561071703900000m, new Guid("c2737c73-c6fe-41c4-9026-69757ae577ff"), null, 23, 24, "Intel", "HDDAndSDD", 27, null, 13, false, 25f, 20f, 22, 2060, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8c325797-a316-4f5c-a755-aba019c158c2"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6757), "Yellow", "mt nps vdbwn o h u e e s k   necizxrqe sfpm ojg l vc gdvt qnxefki o uxl", "Good", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Glass", "yj qir edc  r rqt c k", 22599.582058656800000m, new Guid("bde67d8b-75bf-430b-bc00-5342f5ce011c"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("16aa396e-4d2a-4fca-9ecd-eadafd107ad9"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(9474), "Brown", "cxt  z  xzd xnvb kvkbtqeqiyw qz", "Headphones", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Iron", "amptwqe uj  cmxa", 38643.932407090400000m, new Guid("5efbdcb6-9dad-456e-83c1-fa2f06b5e92e"), null, "Quick Disconnect Connector", "Headphone", "Infrared" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("5654ef91-f97c-4ad8-8d89-257546cec4ca"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8481), "Green", " dj dvregh  kvm guze vfx za ofnall pljgjxgfvb fspxu", "Keyboard", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Jeans", "mm  mhralvbyy", 96393.863668848700000m, new Guid("24572937-4ce5-4dc0-bc27-a858406a647a"), null, "Cherry" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("3c9e0ca8-5033-4361-a517-4da84a77b1d6"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2900), "Red", "tqpzkau xhvk f vzh  m qp kxx sjw   xty t ", "ComputerDrive", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Jeans", " rmvapsu lmc b edikf ca km", 67961.352629569100000m, new Guid("c6892a23-e4be-4771-9506-938d43b34a29"), null, 27575, "2.5", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cafa1d78-0a0c-4f00-9ae6-a05ab19e5b6a"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(6872), "Black", "xk m e q n w   g  w  bk  wwumpfv bc vr o wo", "Good", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Cloth", "hm frscz hk u wmsd djjbu", 58271.254719361300000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[,]
                {
                    { new Guid("7ef9e98f-08af-456d-9efb-9f06dd79a160"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(3689), "Gray", "cs vznbq dkzuh ck yko uudbv ri v vl", "Mause", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Jeans", "zi vrgmmt m esfo", 62397.772894426100000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 16529, "DualIsRFOrBluetoothWireless" },
                    { new Guid("501559fb-0924-4018-88a6-be77bfab98d4"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(5303), "Pink", "cw zgssq  s jnpho o hpb  k qgeow dohc tr eorxx oavkmbh", "Mause", true, new Guid("84c913b8-765c-4bbe-ac87-5089cb79abae"), "Rubber", "qtkybtw er wshe", 67688.77905220200000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, 4439, "DualIsRFOrBluetoothWireless" }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("15973157-cb26-4383-9a76-e08de535ebd3"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(9713), "Yellow", "qpn xzbwpzeymjysqy xcmtqnhew ", "ComputerAccessory", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Cloth", "vsqzmeviq c krdudezfng  ", 7102.6455178403500000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("8210df37-3a0e-4d87-b67f-f5f1b9b169bf"), new DateTime(2021, 2, 5, 17, 9, 31, 22, DateTimeKind.Local).AddTicks(3329), "Blue", "zdgca jk esnkf fnokjvf ydgt", "VideoCard", true, new Guid("52a013fa-e0d9-4471-89a0-dfdd1d6778dc"), "Iron", "y  iz  gf  sdyrf o hx  mg", 36337.912192725500000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, "USB Type A", 3511, 28259 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("8caa4213-9c12-4444-9e7c-5d2e81d9bf67"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(8320), "White", "mtf u q  bzo szusbdosczfgsvigyvy r  qu  fvdptglc  ybuwsvfwt ocllibz wz      koplrbf gjvzki  ", "Keyboard", true, new Guid("18a2dbdf-9cae-433b-9a94-6204c4b9c922"), "Aluminum", "nshvzdh b  uitd  rv   fp ", 4839.3084224496500000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, "Logitech" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("86830464-7b9c-49a8-bce6-720f0ab47964"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(1068), "Gray", "v ruq ek d cth uk  y lygoumnx  vgdvrn slp", "ComputerPart", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Jeans", " ssggwd vtgf hont svi  b", 98457.309183877600000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("7af04213-be87-49ef-acd4-b156dfca98b4"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(8608), "Yellow", " tlvhb npqscychcrxwpctpi zo", "VideoCard", true, new Guid("4dc43a42-e2f0-4edc-aa04-64781a63dac3"), "Rubber", "q dhm  its n zgd  ym", 11672.831984084500000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, "Thunderbolt", 31171, 37440 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("09832435-3faf-4730-bbc1-861e9332340d"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(2644), "Violet", "   io ydekawdionucbneqju    lt wxkmiwjryhfr m tw", "Keyboard", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Aluminum", "ww  iolgy tfd ncswp", 32077.282682097200000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("981b9a96-b0d9-4617-81f2-46b1b94f0a10"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(4345), "Violet", "f msr  bpb wl wqeqjhtjp px rdpux mc x vjr  iwrciqicmtc v lpcne   hj  zwtuea i", "FlashDrive", true, new Guid("59fead78-c59c-4e62-ac08-2418b4eb04f1"), "Aluminum", "bg  ul kwsmivkwbcjtethuy", 67778.034446657600000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null, 9, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("ba63eede-0021-46ec-941f-d0ca39caf634"), new DateTime(2021, 2, 5, 17, 9, 31, 50, DateTimeKind.Local).AddTicks(9109), "Violet", "  gcu nr pbaff gcx d l mqwndc iux lvoghjdbfa sebl h al fovqutu", "Keyboard", true, new Guid("150f0893-2526-47f5-8644-8ebd8c91d2ee"), "Aluminum", " f z  edee y  zli cgz m", 31088.91650619400000m, new Guid("cf8c1401-2cdb-4cf1-a47a-23ad04c443e9"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("b132ad87-5c47-417d-982c-5087dc423d3c"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(4026), "Gradient", " go g f pl d ra xrthio gtdaa ljel eikwfeo sg vmbnnyfre", "CPU", true, new Guid("56803f24-ce4a-4709-be31-d54d1bfbe859"), "Glass", "i nx rtvn a wb ga ", 56603.758808506600000m, new Guid("2cbe45d8-b498-41ad-8c34-587bebb8f23f"), null, "AMD", 22133, 36705, 4053 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("1d54dbb2-6891-4c6c-ba3c-ce9cc9bcb309"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(7580), "Orange", "sv uxugjo twxjltg d dgyixig vontfqn", "Good", true, new Guid("28878e50-8bbf-41e6-a2dd-c1e4b369bea9"), "Leather", "qlrnt lsfyrgpbqh", 85675.398113986200000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null },
                    { new Guid("d4e6df2f-18ce-4f33-887a-0973031a59a5"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8783), "Brown", "sb   fcqxti hmw a jq lwxa s i  yfgew e  fptpvag p  s pzsx   y", "Good", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Iron", "lpodnhwyolv fd jieselxnu", 89145.458438035800000m, new Guid("91937d92-b601-48c2-9f63-13746a61b87e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("875dbb26-9bb9-4944-9e5a-46dce50f9053"), new DateTime(2021, 2, 5, 17, 9, 30, 996, DateTimeKind.Local).AddTicks(9559), "Yellow", "xirslhpyy ug zm imyihfhwnypfwud t leli", "Laptop", true, new Guid("f61f2111-faac-4f50-b8c4-35d2e59e4afa"), "Plastic", "dxus im jw rnid", 90089.579573874200000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, 1, 27, "AMD", "HDD", 25, 27, 30, true, 14f, 7f, 31, 3114, 3f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8629dd81-5053-4dfe-836f-fc357a1e97da"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(4581), "Pink", "ughidh id ", "ComputerTechnology", true, new Guid("3212a749-5ffd-4545-a82b-5d80d825e788"), "Wood", "ct  sl lix  hv slu", 76651.554310997700000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("7f38beea-bd41-47e7-9cc4-0b8ebf2bc9ee"), new DateTime(2021, 2, 5, 17, 9, 31, 42, DateTimeKind.Local).AddTicks(9986), "Blue", "akfdzfa ox  mr qgmlopc  v e dfe  ygtlyvukfbrryh zb jxsvxctf  gp vrz ", "Mause", true, new Guid("e4c5801e-1105-4e1e-836e-fa3339cc3369"), "Cloth", " cgnsa nqca  arxkgi", 69189.062793361500000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null, 1573, "DualIsRFOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("799d9e21-ebcc-4cd2-b999-420e07139617"), new DateTime(2021, 2, 5, 17, 9, 31, 3, DateTimeKind.Local).AddTicks(2273), "Yellow", "kukngpbbswkfb  fianf hwn gjh   bsp p", "ComputerPart", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Aluminum", "jog ia pfxgi k", 74195.444013083100000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("4692ed79-2943-4160-946e-bcea318a54bd"), new DateTime(2021, 2, 5, 17, 9, 31, 36, DateTimeKind.Local).AddTicks(9311), "Violet", "fzukxhyo  pqrnq fyz hzjlrxeerbu  n mddajkmvqjdt", "Cooler", true, new Guid("1e4fbbfb-d94c-4836-8669-54b6736807d2"), "Iron", "iawqiyvn vaze", 4253.5202597517200000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null, 26475, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("2cf9f2e2-2e49-4e1c-8230-ce32fecb06c3"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(189), "Red", " fkysso  ux  ghgja  kxobpjvl", "Laptop", true, new Guid("3cb08b4c-a332-4be2-bcf6-4ad5b839474a"), "Plastic", "eqcdpqvr fvr pnc", 73276.876319794400000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null, 3, 14, "AMD", "HDD", 6, 16, 29, true, 16f, 29f, 25, 1926, 27f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("2c43cead-c7f2-4ffa-aea0-adf9d8f620fe"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(7836), "Orange", "vwn nzzz   x d  u f eqs   i xraz jz zpn mtpdo ksn   d ", "ComputerTechnology", true, new Guid("159ee36f-8775-4d50-9f5a-9d00dbacda05"), "Jeans", "lozxwk hzyk", 522.11876051599100000m, new Guid("cfb4c1bb-7c48-46dc-aef4-47c46e8535e7"), null },
                    { new Guid("089afdf0-754a-44b0-ab55-30c1a333c832"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(7171), "White", "lbbdceyqxy umiez bflgg  t", "Good", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Iron", " fhvubnwsfnw c", 5535.7269037215600000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null },
                    { new Guid("6154c964-e0dd-42d1-8fa3-15e63705b03f"), new DateTime(2021, 2, 5, 17, 9, 30, 984, DateTimeKind.Local).AddTicks(231), "Gray", "k sxh  iymjumtjyay btkx eay uvy irrbodnseqcu gjysbhna shbotc njrghioihy  lc cn", "Good", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Aluminum", " j d gz a o   y jjfcx", 32477.714928089500000m, new Guid("df98eb82-87d3-42c1-893b-c313928b91b2"), null },
                    { new Guid("1a1a1f0a-69ce-40ea-bc43-6ddf2868f5df"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(5375), "Pink", "dddfn tm xjupyw    nu vo nlrt   czklcx a    cd fdkzqlzooq tg", "Good", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Leather", "l vfn exmld  k", 38555.393013430500000m, new Guid("d3083786-210e-40f0-ad8b-05c5baf4b21b"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("9dc30655-d5f5-4910-8580-f81f2c0456a9"), new DateTime(2021, 2, 5, 17, 9, 31, 39, DateTimeKind.Local).AddTicks(4174), "Pink", " z qfqbogjc x  e yrvv jx t", "ComputerDrive", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Iron", "ijj  ni gxactclnwyq g agslk", 9894.563495132400000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, 33035, "1.8", "HDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("59c6fea6-ce4e-484a-ae6a-2d9ba8024aba"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(6310), "Gray", "  vxofbnzfwz rm kq  o eb zfp f  q wrt", "FlashDrive", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Leather", "scedu g chs zi f  sjvpdhy", 43539.39720594300000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null, 9, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("bfb31af5-ac09-45fd-814d-164418e30894"), new DateTime(2021, 2, 5, 17, 9, 30, 988, DateTimeKind.Local).AddTicks(2116), "Pink", "k  jjwyxlvy cbdomf z ysthnsqu jydp wm l f  s x  zvnr ub u ebatxq qv gx", "ComputerTechnology", true, new Guid("37b546b7-a0ad-4d9f-94c9-7bcb20ba33b6"), "Leather", "ja zuy ufogzyzn", 44816.660203419900000m, new Guid("a37691ce-955c-48e0-996f-860e14f15870"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("6ed41964-cc70-450f-ab1c-9690f86a3dcf"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4189), "Gradient", "nfk ciajmomagmbowse lemeq  uj vq   bhtqs wk   ttv   yatjwp", "Mause", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Wood", "wtummxvutxsf qhbjrkb q yj lw", 44403.326764890600000m, new Guid("84ec546a-6932-473a-9726-2ca694cc4fa3"), null, 2437, "FastRFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("8b50602d-dfbf-4ee7-890c-dd0ad3d91c1d"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(1974), "Black", "yigtwihtv jug  q fg erazzd gqayludky g y gmexkdns ful wr vo bxqnj dyloxkj  cs ", "ComputerAccessory", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Cloth", "qg  knodk hhyv d  t attg vh czk", 4926.9391246731100000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "FormFactorType", "Type" },
                values: new object[] { new Guid("8d978384-9af9-4551-bcaf-f79fd3d41506"), new DateTime(2021, 2, 5, 17, 9, 31, 40, DateTimeKind.Local).AddTicks(2310), "Yellow", "  kfx vb tdjnb  clv ji qesg zhp z zm siz xu pxeit h d lht w    kufuekge wzeiyjqw", "ComputerDrive", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Cloth", "ycuy ktxgkyl lipz", 88461.146358615300000m, new Guid("9b8881ca-15dc-4d5b-8965-36837dcf08ba"), null, 1288, "USB", "HDDAndSDD" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("1ae741d3-52fb-43a9-a24e-34a48902db94"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(2626), "Orange", "nmf ocnog  pdjof mteqa  e  xpphworddym qd  i pgug k", "Cooler", true, new Guid("9550c7cc-7ff7-424e-b1e2-94716719d5a0"), "Aluminum", "pfv ugh w blq l ", 30771.623426476300000m, new Guid("1b07b9c3-6e4a-4f39-8516-c060063234f7"), null, 5575, "Case Fans" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("71b0f5ac-c91c-49ca-9b0f-99e3ceba6ebc"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(1708), "Gray", "kx nrhoh yjqusoqvf p wg  ue  nh e pbj sof a", "Mause", true, new Guid("2165eebd-69af-406d-9300-e1b15f2adba3"), "Leather", " idvkzh  gutxv", 64774.776373419400000m, new Guid("f40c0007-9d40-4b2e-ba90-11214b1398dd"), null, 5571, "DualIsLIGHTSPEEDOrBluetoothWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("3fb2abd9-5788-4ec1-9f10-9164dd35c4a1"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(2993), "Blue", "a fxsfpokv vsxz d mxkmics ad yxmfcg hno  gif dpwcglud ozte g xqxvjd jyf ", "ComputerAccessory", true, new Guid("2165eebd-69af-406d-9300-e1b15f2adba3"), "Leather", "ipsyq r drn r a rzfr ", 18060.293522691500000m, new Guid("3e597747-800d-463e-a8f8-23ac05b75c8b"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type" },
                values: new object[] { new Guid("168e8c49-b8b2-470d-9f0c-3f46cba125ce"), new DateTime(2021, 2, 5, 17, 9, 31, 51, DateTimeKind.Local).AddTicks(497), "Pink", "  vhrha  vhefch klxlxykfkgmcnh hvi f  xkwz  chfyhxkj xh  d", "Keyboard", true, new Guid("8af3b4a3-e369-406e-a027-a71b5f019cc9"), "Aluminum", "m   phtdlxht  uoe rrhehyq", 28470.48813871600000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, "TTC" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("fc50d34b-b6ec-45db-90cb-9dbb60ea791d"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(8568), "Gray", "ebz  mofdnc  opi qee ytur     yugtilhislr l", "Headphones", true, new Guid("6b347008-2e8c-4081-afa0-d27ec40ba7bd"), "Rubber", "y xeoh rsa k e", 74314.866249596200000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, "RCA", "BehindTheNeck", "Kleer" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("e924a626-7108-4e2a-beb4-832121508d55"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3905), "Brown", "kv ynwy  xk  k i iyiazz  k  ", "Computer", true, new Guid("af6ba9be-85b6-4c7c-8ff2-ace7aab88d9e"), "Iron", "lkcuggm nsbfk ttif z vl efp wgrq bkwx", 50748.50756244200000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null, 21, 14, "Intel", "HDD", null, 4, false, 19f, 23f, 24, 1104, 30f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("0ce42236-a2fd-411d-838c-2d5d06dc4574"), new DateTime(2021, 2, 5, 17, 9, 30, 985, DateTimeKind.Local).AddTicks(5779), "Green", "gkqza lrbhocnj dysqbrx e z x  r", "Good", true, new Guid("e4c19fb2-c7dd-4a26-a7ed-6735a15ef93c"), "Leather", "amlj ry erlm  p  k ww", 94501.249443041800000m, new Guid("f53b8160-e032-4d1f-9a7b-92b72d7a7b31"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("f409b93a-0576-4d1e-8bfe-8eb4cee5be8e"), new DateTime(2021, 2, 5, 17, 9, 31, 56, DateTimeKind.Local).AddTicks(7177), "Pink", " wgkndxd  ugirmdle piszmoy aizwzk cs  byh fvl nr stv   lpmlk   o", "Headphones", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Iron", "k lgftwoiq ", 74713.846843090800000m, new Guid("315347ae-9e34-4f15-bc11-bf82ad4edc70"), null, "3.5mm", "Headphone", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("2061e221-75bd-4820-8c29-9a3fcff1ef8d"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(8464), "Blue", " fz dcdvz q ud tzfqoo  zoiwkguwydw wmqp cm cjxtbgtam ndbo   iibafnt sioavxwodk wvjlq", "CPU", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Cloth", "gk qr h kb avmh", 14558.309323414400000m, new Guid("dd44f9be-9469-4ecc-abd0-ab0df08150fe"), null, "AMD", 11437, 14251, 5673 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "DriveInterfaceValue", "VideoMemoryCapacity", "VideoSize" },
                values: new object[] { new Guid("3408d889-c9d5-4724-9214-f3704fc3fc3b"), new DateTime(2021, 2, 5, 17, 9, 31, 23, DateTimeKind.Local).AddTicks(7940), "Red", "xghipgw  j wf asc x e cmuzxgcivl", "VideoCard", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Glass", "wg zky saxdhzbq wd", 9305.0716953841400000m, new Guid("4c65c16a-7dac-4904-9440-32563cebe2c4"), null, "PCI Express 3.0 x4", 22037, 5806 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("8011b33a-c5f1-4022-8118-3569fd8faa02"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(813), "Yellow", "  mqdt mezwc j o msnngn", "Laptop", true, new Guid("4103a62f-ec4e-4f0f-9b4d-726a905d3dab"), "Aluminum", " rgy qmgg gf  hp dt", 32988.452600775500000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 30, 20, "AMD", "HDD", 11, null, 26, false, 5f, 13f, 16, 2515, 10f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("3723053e-c549-4a7b-af09-6bca7e2f38c8"), new DateTime(2021, 2, 5, 17, 9, 31, 13, DateTimeKind.Local).AddTicks(3314), "Violet", "v fymurovaq  ryhgxnbezhqk kf snlir snnxfviqisk ", "Computer", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Iron", "nfoxmcirkn t j k lksi", 40282.336780932900000m, new Guid("7bd1127e-e91b-48d1-8724-c8a9642fe274"), null, 7, 10, "AMD", "HDDAndSDD", 27, 11, true, 31f, 4f, 1, 2318, 28f });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("641b5da0-662e-4eb8-b792-a10f7429c264"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(2887), "Gradient", "bxhj gfdmokxeuomyezgtmddke   sgozw kfneomd  zzypno ov", "ComputerAccessory", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Iron", "xozn ajxxmjcdu  w e a os ", 14740.100090736600000m, new Guid("5bfed8a2-ef58-4100-9f0e-34cb40024587"), null },
                    { new Guid("44bf7d44-791c-48f5-8ebe-8a5bb7180f85"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(4985), "Gray", "wxci   uvx rscmnfypeh  ktyxvoqiyebn jwj  zo  q  r v vy", "ComputerAccessory", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Jeans", "khegjksht g gze", 70137.253296625400000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null },
                    { new Guid("ca418d5d-2afe-436a-9934-3162c1733aa2"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9764), "Blue", "k  o  hngenin iqzkpxb xnvshli ezp o k  w hd q usemj", "ComputerPart", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Glass", "ybtx slb  ma naan dvc", 9226.0642951475800000m, new Guid("c338cf38-269b-40bc-86c1-2be1c0c593f5"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("4d2e4424-b86b-4b97-bb1e-701588a39a7d"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(1499), "Red", "lx yulioggkhcknex oznmzdx", "Cooler", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Leather", "x aulo  wdx", 52135.178610745400000m, new Guid("00805083-0dad-4a01-ae3e-fc9add86b053"), null, 34547, "CPUFans & Heatsinks" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ButtonsCount", "Type" },
                values: new object[] { new Guid("1c257586-1cab-489e-a89d-bb83db77386e"), new DateTime(2021, 2, 5, 17, 9, 31, 43, DateTimeKind.Local).AddTicks(4826), "Pink", "hh ptf  omt eqw ebzck bwk mg j moykw   xaigm  j b cpnq ", "Mause", true, new Guid("28878e50-8bbf-41e6-a2dd-c1e4b369bea9"), "Glass", "zlvib bu etkjievcsn jt k", 50230.4011724100000m, new Guid("8a4cff13-7f08-472e-ad3f-529234e80e87"), null, 19238, "RFWireless" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("24134d53-c1eb-470a-aea6-3fdd965f5d31"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(7236), "Blue", "fi f ir k hgzjzdwcm u cgajnvqjnp m alf sjvypln l ", "FlashDrive", true, new Guid("8a32e85e-a73d-40c0-b01d-cd2a7b3f6c01"), "Wood", "fibtujcc h hrc  cb wujr", 66358.510202895200000m, new Guid("be0f968b-9913-46c9-8d68-7ea8ad01d8ef"), null, 3, "USB 3.1" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[,]
                {
                    { new Guid("985a0a39-100c-49cd-a63c-6592fce0afe1"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6126), "Green", "a fplo quoylqybi ", "Good", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Leather", "ou trl   ly   atfhjtn py", 15069.479036642900000m, new Guid("949b52ee-decf-4c64-9ff7-5af9923b6ea3"), null },
                    { new Guid("f269a50b-9997-46da-945f-855f990bdc34"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(8674), "Red", "eairkeoyrhhnlr  qzqfev  sg nkiz  i patpdvju", "Good", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Aluminum", "uotlb  cr nsudcm wd ", 20279.156286399400000m, new Guid("d496dafe-27fd-47ab-be93-2affdc4cd791"), null },
                    { new Guid("88dd9190-0163-4844-ba49-e605d6456058"), new DateTime(2021, 2, 5, 17, 9, 31, 5, DateTimeKind.Local).AddTicks(2601), "Red", "f cp lbzqo   v n b t  yxstokrwt v oe yq", "ComputerAccessory", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Aluminum", " rvud l kh o xrkr  dyrj", 11383.457999389400000m, new Guid("bc89e287-1c74-42a1-9b49-19d1d4f973a0"), null },
                    { new Guid("e62738fb-3907-4c28-8cd4-5d12afa00913"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(6227), "Red", "vxrgwmixedet  zuyvtt  nxar f  pwt dv hhwueord sz  jxl ", "Good", true, new Guid("eb2265bb-92f0-44cf-b36c-ef7c1e69c719"), "Iron", "ofy g upsgmuaw rg ", 57075.4603282900000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null }
                });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "ConnectorType", "Type", "WirelessType" },
                values: new object[] { new Guid("471f11df-c826-4c09-a140-aee4e7a907d8"), new DateTime(2021, 2, 5, 17, 9, 31, 57, DateTimeKind.Local).AddTicks(1234), "White", "gziqkvyrme mmvbj ps  hal kqze gwsb mpq deylt   dih cznpirwil cwryxnuvhbncokuhriuj ce  qc", "Headphones", true, new Guid("504d4730-7edb-481b-9506-283db31f56ea"), "Jeans", "o fbddt i dg  cb el   zi rc ffk", 9019.6787421683200000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, "3.5mm", "Headset", "Bluetooth" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("cb521ae6-eff7-4824-93db-c8ad6e6759bf"), new DateTime(2021, 2, 5, 17, 9, 31, 2, DateTimeKind.Local).AddTicks(9034), "Green", "bqkeymounu khixkoavtblzpgcm v pe dwknxsxsg   g ru    yav", "ComputerPart", true, new Guid("20c57d41-6e82-4772-9f70-e46178fa2e6a"), "Iron", " sxoyvyeq o  px", 20026.000039664100000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Type", "NumberOfCores", "NumberOfThreads", "ThermalDesignPower" },
                values: new object[] { new Guid("e0720998-bb8c-45f2-8ae7-f41aa14015cc"), new DateTime(2021, 2, 5, 17, 9, 31, 33, DateTimeKind.Local).AddTicks(2200), "Orange", " qfw  av t bho d", "CPU", true, new Guid("c761e5c2-1a1b-41a3-afed-4b5e528f5510"), "Iron", " cpm  dit mandzu   eimffgwb", 85130.146930520500000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, "AMD", 22357, 1669, 25818 });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "FanSize", "CoolerType" },
                values: new object[] { new Guid("ff85eeee-2788-4dad-97c6-3d4f106cd82e"), new DateTime(2021, 2, 5, 17, 9, 31, 37, DateTimeKind.Local).AddTicks(3644), "Pink", "uazckg th y r ctuq txetp w jp j  w  h ekwz", "Cooler", true, new Guid("7549298e-a361-4dca-80b8-a1ad9dbd4272"), "Cloth", "  oz   l dxog  ", 64804.217854889200000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, 27019, "Water/Liquid Cooling" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "Capacity", "USBSpecificationType" },
                values: new object[] { new Guid("24c582ce-7507-452d-b064-a4be520a8642"), new DateTime(2021, 2, 5, 17, 9, 30, 999, DateTimeKind.Local).AddTicks(3411), "Pink", "ev pc ytklt iupgmfniwsbh wzvfdzwp dbtj led qxanmqs x zvv jkrgznn ", "FlashDrive", true, new Guid("c4cef488-e551-4fbe-83ca-0c875fbbb30d"), "Leather", "mwdue  ht tgbfp", 63290.083344695200000m, new Guid("921a28ba-df9e-4a65-9fe9-2b745fe7530e"), null, 24, "USB 2.0" });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId" },
                values: new object[] { new Guid("ba8e5a5d-a09d-4d4b-9c29-0fb3bee30513"), new DateTime(2021, 2, 5, 17, 9, 30, 983, DateTimeKind.Local).AddTicks(5806), "Gradient", " fa mp yhfocol as h srze h fwgk  djokprofuhz o wutfxpqrhr", "Good", true, new Guid("c689aa31-1be5-47a4-a2ac-9eeb707dab44"), "Leather", " nma uw xvpf dsb", 1175.4805693288700000m, new Guid("aedf2966-8aa1-4f3b-b8d9-63e0eedc3b3a"), null });

            migrationBuilder.InsertData(
                table: "Goods",
                columns: new[] { "Id", "AddTime", "ColorValue", "Description", "Discriminator", "IsAvailable", "ManufacturerId", "MaterialValue", "Name", "Price", "ProducerId", "UserId", "AmountOfRAM", "CPUFrequency", "CPUSocketType", "ComputerDriveType", "Display", "FloppyDrivesCount", "HardDiskMemory", "HaveFloppyDrives", "Height", "Length", "NumberOfCores", "SSDMemory", "Width" },
                values: new object[] { new Guid("abe80f1d-e6a4-479a-b7e9-f32fdb464cb4"), new DateTime(2021, 2, 5, 17, 9, 30, 997, DateTimeKind.Local).AddTicks(451), "Blue", "bckzcje pa d vjofcjrppzwz qozefmpq arablaeesyq yppfh", "Laptop", true, new Guid("588b192e-ec66-4cd9-9951-3bef3fbf8075"), "Jeans", "oarwuz xihqovzajvcdauj", 83344.778923012700000m, new Guid("ba3c814f-d5a0-41f7-8bf0-ce2f8ad51f32"), null, 16, 25, "Intel", "HDDAndSDD", 21, 18, 3, true, 14f, 26f, 30, 2814, 26f });

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
                name: "IX_Goods_ConnectorType",
                table: "Goods",
                column: "ConnectorType");

            migrationBuilder.CreateIndex(
                name: "IX_Goods_FormFactorType",
                table: "Goods",
                column: "FormFactorType");

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
