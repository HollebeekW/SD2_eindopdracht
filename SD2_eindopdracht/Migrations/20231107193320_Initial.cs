using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD2_eindopdracht.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: false),
                    MaxAge = table.Column<int>(type: "int", nullable: true),
                    YearlyItems = table.Column<int>(type: "int", nullable: true),
                    ItemsAtOnce = table.Column<int>(type: "int", nullable: true),
                    LoanPeriod = table.Column<int>(type: "int", nullable: false),
                    Extensions = table.Column<int>(type: "int", nullable: false),
                    ReservationPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DailyFine = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubscriptionPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearOfRelease = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Item_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionId = table.Column<int>(type: "int", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Fine = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsBlocked = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Subscription_SubscriptionId",
                        column: x => x.SubscriptionId,
                        principalTable: "Subscription",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserItem",
                columns: table => new
                {
                    ItemsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserItem", x => new { x.ItemsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserItem_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationUserItem_Item_ItemsId",
                        column: x => x.ItemsId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "UserItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserItem_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Annabelle", "Zemlak" },
                    { 2, "Erich", "Schultz" },
                    { 3, "Don", "Ondricka" },
                    { 4, "Alexander", "Marks" },
                    { 5, "Ray", "Stamm" },
                    { 6, "Darlene", "Stokes" },
                    { 7, "Judd", "Dietrich" },
                    { 8, "Gabrielle", "Durgan" },
                    { 9, "Bartholome", "Boyle" },
                    { 10, "Dasia", "Little" },
                    { 11, "Mollie", "Shanahan" },
                    { 12, "Chaim", "Medhurst" },
                    { 13, "Johann", "Gleichner" },
                    { 14, "Valentina", "Koss" },
                    { 15, "Elena", "Kilback" },
                    { 16, "Bryon", "Labadie" },
                    { 17, "Patsy", "Abernathy" },
                    { 18, "Gabrielle", "Jaskolski" },
                    { 19, "Dawson", "Wolf" },
                    { 20, "Bernie", "Howe" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Boek" },
                    { 2, "CD" },
                    { 3, "Game" },
                    { 4, "DVD" },
                    { 5, "Blu-Ray" }
                });

            migrationBuilder.InsertData(
                table: "Subscription",
                columns: new[] { "Id", "DailyFine", "Extensions", "ItemsAtOnce", "LoanPeriod", "MaxAge", "MinAge", "Name", "ReservationPrice", "SubscriptionPrice", "YearlyItems" },
                values: new object[,]
                {
                    { 1, 0m, 3, null, 3, 17, 0, "Jeugd", 0.25m, 0m, null },
                    { 2, 0.30m, 1, 10, 3, null, 18, "Budget", 0.25m, 1m, 10 },
                    { 3, 0.30m, 3, null, 3, null, 18, "Basis", 0.25m, 4m, null },
                    { 4, 0m, 5, null, 3, null, 18, "Top", 0m, 6m, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Fine", "IsBlocked", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 35, "5b886655-f2b0-4095-99ad-3b2aa22b7258", "ApplicationUser", "Charity55@yahoo.com", false, 3.6m, false, false, null, "CHARITY55@YAHOO.COM", "ROCIO_SCHNEIDER20", null, "1-812-759-9014", false, "ba078d0a-9c6d-419c-9ba3-d4f61b8f04a0", 3, false, "Rocio_Schneider20" },
                    { "10", 0, 19, "f7528119-5346-476c-8297-204429401f90", "ApplicationUser", "Justine.Hilpert6@gmail.com", false, 9.2m, false, false, null, "JUSTINE.HILPERT6@GMAIL.COM", "LUIGI_WELCH", null, "(379) 511-8988 x866", false, "cc1286b1-12e6-4c5b-893f-7944824108ac", 2, false, "Luigi_Welch" },
                    { "100", 0, 51, "e0b27911-2b32-4323-86dd-440371dbb972", "ApplicationUser", "Yazmin.Hintz@hotmail.com", false, 3.4m, true, false, null, "YAZMIN.HINTZ@HOTMAIL.COM", "OMARI.CONROY", null, "(496) 508-4339", false, "4ca3b92b-2e6b-45cf-89ce-f64b32ded11e", 4, false, "Omari.Conroy" },
                    { "11", 0, 57, "4748820d-2e4a-41ae-bf09-396161ad4e0c", "ApplicationUser", "Jammie.Sipes76@gmail.com", false, 0.1m, true, false, null, "JAMMIE.SIPES76@GMAIL.COM", "DENIS31", null, "562-735-3066 x714", false, "ad0e9de6-89f4-4617-a348-62f7c28c3b1e", 2, false, "Denis31" },
                    { "12", 0, 44, "7de5a53f-9aef-414e-9617-0675cdc44251", "ApplicationUser", "Constantin91@yahoo.com", false, 6.3m, true, false, null, "CONSTANTIN91@YAHOO.COM", "EUSEBIO_SATTERFIELD69", null, "1-955-247-4012 x2175", false, "14705121-1ab0-4faa-93a6-36b5e476587b", 2, false, "Eusebio_Satterfield69" },
                    { "13", 0, 41, "ac7cfac4-048c-4f0c-93d8-327f7848a5ed", "ApplicationUser", "Sid72@gmail.com", false, 8.2m, false, false, null, "SID72@GMAIL.COM", "MAXIMUS78", null, "1-737-302-6496 x961", false, "ac5690da-4f07-4721-ae31-79ebfe326365", 2, false, "Maximus78" },
                    { "14", 0, 75, "756054fb-4474-4459-8fb6-765c5bddc3a3", "ApplicationUser", "Lorenz69@hotmail.com", false, 5.8m, false, false, null, "LORENZ69@HOTMAIL.COM", "REX51", null, "1-437-823-3663 x3409", false, "a66e9f4d-fb3f-4a59-a66b-b44de5158c19", 2, false, "Rex51" },
                    { "15", 0, 61, "3711d5e0-aa3c-4e70-808d-3593e268a838", "ApplicationUser", "Alysa.Oberbrunner46@yahoo.com", false, 7.6m, false, false, null, "ALYSA.OBERBRUNNER46@YAHOO.COM", "EFREN_HUEL84", null, "1-644-879-0309", false, "453213e5-6567-431c-b821-ca0048a7f980", 3, false, "Efren_Huel84" },
                    { "16", 0, 56, "b477dbec-4a6c-4048-90d1-4804e6c1d3a5", "ApplicationUser", "Edd.Gottlieb@hotmail.com", false, 5.0m, true, false, null, "EDD.GOTTLIEB@HOTMAIL.COM", "BERNITA.WALSH6", null, "730-538-3176 x58449", false, "93df1c84-f8e1-42e1-9b73-1880655c1ed7", 4, false, "Bernita.Walsh6" },
                    { "17", 0, 47, "dd1f6fe6-fed4-4123-bc6f-22773b5abf02", "ApplicationUser", "Tyra_Vandervort@gmail.com", false, 7.3m, true, false, null, "TYRA_VANDERVORT@GMAIL.COM", "DEMOND48", null, "720.629.8134 x2707", false, "459f82b9-fa17-4265-9f0f-e8a02a98856a", 4, false, "Demond48" },
                    { "18", 0, 77, "c54b3d4f-742d-4212-be47-b150f46eb184", "ApplicationUser", "Jaiden.Abshire5@gmail.com", false, 8.7m, true, false, null, "JAIDEN.ABSHIRE5@GMAIL.COM", "HUMBERTO_CARROLL", null, "1-803-583-9995 x739", false, "96ff916c-5509-4126-b57d-42bf07d5ac2f", 3, false, "Humberto_Carroll" },
                    { "19", 0, 18, "2938dae8-d744-4621-a9d9-c50d6e7f452b", "ApplicationUser", "Franz26@gmail.com", false, 8.2m, false, false, null, "FRANZ26@GMAIL.COM", "BILL_HARTMANN", null, "629.352.6855 x1824", false, "abcce192-c29f-48d4-baaf-cfb76ab06623", 2, false, "Bill_Hartmann" },
                    { "2", 0, 17, "97ed8f89-622f-4185-9b46-2bc891bc074e", "ApplicationUser", "Branson_Marks23@yahoo.com", false, 1.8m, true, false, null, "BRANSON_MARKS23@YAHOO.COM", "BARBARA55", null, "580.463.2646 x357", false, "647b29bb-c0c1-4b90-9f33-15ceb58ea25a", 1, false, "Barbara55" },
                    { "20", 0, 36, "c42f59e1-abd6-465d-99ad-4fdd69696f4c", "ApplicationUser", "Crystel.Schuppe36@gmail.com", false, 3.0m, false, false, null, "CRYSTEL.SCHUPPE36@GMAIL.COM", "FAYE_SCHIMMEL", null, "354-505-9533 x7114", false, "9df9af12-1c14-4c0f-bb61-c42ac143bc1f", 4, false, "Faye_Schimmel" },
                    { "21", 0, 68, "053c91e5-ddfd-407e-a2d7-785dd409a01c", "ApplicationUser", "Kyleigh33@yahoo.com", false, 2.0m, true, false, null, "KYLEIGH33@YAHOO.COM", "DANDRE89", null, "1-500-230-2029", false, "98563b24-07c1-4759-b509-77b87d9aa891", 2, false, "Dandre89" },
                    { "22", 0, 15, "bdaff5a3-4ca7-422a-855a-2c18944a06c4", "ApplicationUser", "Dario_Bogan32@yahoo.com", false, 1.3m, false, false, null, "DARIO_BOGAN32@YAHOO.COM", "KRIS.BEATTY", null, "841-345-4257 x6949", false, "0a6cdb19-11fe-4f06-a247-2155e1475fbf", 1, false, "Kris.Beatty" },
                    { "23", 0, 29, "bea86efa-c8e1-49ba-9480-d6d9a8d4d692", "ApplicationUser", "Gregoria62@yahoo.com", false, 2.6m, true, false, null, "GREGORIA62@YAHOO.COM", "MORTON.CARROLL", null, "738.716.7999 x3679", false, "b3948732-ec69-4c9b-adcd-1c48c88b83d2", 2, false, "Morton.Carroll" },
                    { "24", 0, 53, "45d812c3-d2ac-46f4-97d5-1823f64a92f5", "ApplicationUser", "Deshawn40@yahoo.com", false, 7.9m, true, false, null, "DESHAWN40@YAHOO.COM", "FRIEDA47", null, "1-479-218-2306 x60756", false, "9f1c0f42-af6a-45db-8b2d-97aae2dee485", 4, false, "Frieda47" },
                    { "25", 0, 37, "cd15ade5-82b3-41a3-a146-248c5c0de5a0", "ApplicationUser", "Sydney_Stehr78@yahoo.com", false, 7.9m, true, false, null, "SYDNEY_STEHR78@YAHOO.COM", "KARELLE.KIHN84", null, "(736) 965-1136", false, "6801758b-84ee-4a09-bd05-106c55435f0b", 3, false, "Karelle.Kihn84" },
                    { "26", 0, 53, "eabd9770-2e8d-4e9c-bb2c-70cb9f08892f", "ApplicationUser", "Norwood33@yahoo.com", false, 9.2m, false, false, null, "NORWOOD33@YAHOO.COM", "VADA.BUCKRIDGE33", null, "645-943-3444", false, "777eaeb1-a5d3-4ffe-9aa7-0b818dc45b50", 3, false, "Vada.Buckridge33" },
                    { "27", 0, 75, "314249b1-0590-4713-a9fb-191a2a965e50", "ApplicationUser", "Aiden43@yahoo.com", false, 4.3m, true, false, null, "AIDEN43@YAHOO.COM", "MARCELO.BEATTY91", null, "1-929-232-1913 x5581", false, "e43a02d2-57ac-4c88-9333-7b581c8d29fb", 2, false, "Marcelo.Beatty91" },
                    { "28", 0, 60, "c7c85bf8-e597-440d-9c50-e441ebdcb759", "ApplicationUser", "Shaina26@yahoo.com", false, 5.1m, false, false, null, "SHAINA26@YAHOO.COM", "DARIO.SCHULTZ1", null, "(293) 351-4643", false, "1caf4c27-505e-45e6-9b4e-d16fb634c611", 4, false, "Dario.Schultz1" },
                    { "29", 0, 58, "3c94a6f0-8dcd-41c2-ad26-487c8bfef8c9", "ApplicationUser", "Hubert_Langosh@hotmail.com", false, 9.6m, true, false, null, "HUBERT_LANGOSH@HOTMAIL.COM", "KESHAWN.TREMBLAY6", null, "292-327-1121 x94110", false, "060fa939-66f9-4696-95df-42765096c2c3", 4, false, "Keshawn.Tremblay6" },
                    { "3", 0, 13, "57c4ccee-3806-478e-ae3f-21b3afd3a42a", "ApplicationUser", "Leola60@gmail.com", false, 2.6m, false, false, null, "LEOLA60@GMAIL.COM", "CHRISTELLE_GRAHAM97", null, "407.347.4014 x85361", false, "6ac73d30-3737-468c-a57a-e6ea993b2e96", 1, false, "Christelle_Graham97" },
                    { "30", 0, 54, "6cf2956b-7c7d-4178-9f69-7dde810867ed", "ApplicationUser", "Brandyn_Bashirian@yahoo.com", false, 3.2m, true, false, null, "BRANDYN_BASHIRIAN@YAHOO.COM", "SIDNEY46", null, "437.747.4092", false, "7c8d2bad-ef51-46fb-b1fc-f693d5ec80b8", 4, false, "Sidney46" },
                    { "31", 0, 64, "a461739f-2704-4c2f-a491-12d787371b69", "ApplicationUser", "Dexter79@gmail.com", false, 3.2m, false, false, null, "DEXTER79@GMAIL.COM", "SETH_ORN86", null, "1-377-494-5392 x1135", false, "56a34774-1b0c-47dc-a03f-41882f6ff393", 3, false, "Seth_Orn86" },
                    { "32", 0, 16, "2f5ff2fd-7da1-449f-8087-c3acf481c340", "ApplicationUser", "Cordelia.Mann31@yahoo.com", false, 3.8m, false, false, null, "CORDELIA.MANN31@YAHOO.COM", "CORTNEY_REINGER", null, "1-999-623-3226", false, "fbd9c6d0-62aa-497d-a437-ab2b8f98bfda", 1, false, "Cortney_Reinger" },
                    { "33", 0, 17, "3002effe-c0cf-401c-8338-8a4403cd7e4b", "ApplicationUser", "Constantin55@yahoo.com", false, 0.1m, true, false, null, "CONSTANTIN55@YAHOO.COM", "JIMMY.BOGISICH", null, "(996) 478-8833 x601", false, "2e5251f0-41a1-4831-ae1f-bfe312bbf15b", 1, false, "Jimmy.Bogisich" },
                    { "34", 0, 53, "bf16f0b3-90d0-41da-848a-658fedb6c8d5", "ApplicationUser", "Beau43@gmail.com", false, 5.4m, true, false, null, "BEAU43@GMAIL.COM", "AURELIE.DIBBERT", null, "1-763-223-9482 x416", false, "962c8750-7ecb-4681-a774-7f92a0dad719", 2, false, "Aurelie.Dibbert" },
                    { "35", 0, 21, "dbad3e0e-1e8d-4667-b349-0b1eccc87610", "ApplicationUser", "Oswald.Carter36@gmail.com", false, 5.6m, true, false, null, "OSWALD.CARTER36@GMAIL.COM", "LORENZO63", null, "(408) 659-7358", false, "427dc07d-16a6-43a5-a5c9-bea18935d873", 2, false, "Lorenzo63" },
                    { "36", 0, 46, "d18779da-000b-47c3-8b57-9b998bff1c2c", "ApplicationUser", "Enrico39@hotmail.com", false, 1.0m, false, false, null, "ENRICO39@HOTMAIL.COM", "VINCENT35", null, "314.924.2525 x2185", false, "9c0fd85d-7b82-4568-8239-65776131c9ad", 3, false, "Vincent35" },
                    { "37", 0, 71, "98f4b331-ee38-4685-975c-1a82f0a5a3e7", "ApplicationUser", "Lorena_Kshlerin@hotmail.com", false, 4.4m, true, false, null, "LORENA_KSHLERIN@HOTMAIL.COM", "SHAYNA.OREILLY96", null, "258-205-8686", false, "36595d71-c8bc-43c4-8575-79ffabc34c6d", 4, false, "Shayna.OReilly96" },
                    { "38", 0, 43, "c7f99c3a-c616-40c8-a593-3504c72740d9", "ApplicationUser", "Clair23@yahoo.com", false, 1.1m, true, false, null, "CLAIR23@YAHOO.COM", "EVERETTE_OHARA97", null, "910.630.0044 x537", false, "0da06724-e67a-480b-ba81-3c8a3dc3d618", 3, false, "Everette_OHara97" },
                    { "39", 0, 60, "9da559ab-8d44-425d-a360-18e8f5070fb5", "ApplicationUser", "Terrell_Hodkiewicz@gmail.com", false, 6.1m, true, false, null, "TERRELL_HODKIEWICZ@GMAIL.COM", "IZABELLA_BOEHM", null, "(259) 255-8568", false, "5f4876a3-0cb2-4f34-8a47-068d165ae2c6", 2, false, "Izabella_Boehm" },
                    { "4", 0, 27, "f7c9ab49-f2f1-4bb5-8841-20f8fd599fc7", "ApplicationUser", "Trystan_Jacobs41@hotmail.com", false, 1.7m, true, false, null, "TRYSTAN_JACOBS41@HOTMAIL.COM", "NORENE8", null, "1-314-204-4136", false, "2f8803e3-f80c-4b33-8ad8-16061748f9f3", 4, false, "Norene8" },
                    { "40", 0, 32, "889d0d3a-0dd4-444a-95dd-66ef515ccabd", "ApplicationUser", "Jazmyne.Ziemann8@gmail.com", false, 3.8m, false, false, null, "JAZMYNE.ZIEMANN8@GMAIL.COM", "CALISTA.KUNZE80", null, "(817) 480-9002 x83202", false, "31e6fbc5-3b39-4856-a613-9ba6f7f3b4b5", 2, false, "Calista.Kunze80" },
                    { "41", 0, 27, "ea86e568-5e66-4912-9432-54ebfbf501c4", "ApplicationUser", "Shirley.Schuppe@hotmail.com", false, 2.7m, false, false, null, "SHIRLEY.SCHUPPE@HOTMAIL.COM", "HOLLIS91", null, "405-770-7886", false, "5371f413-faae-45fb-ab9b-05ade6fe0303", 3, false, "Hollis91" },
                    { "42", 0, 28, "c2984298-071a-415c-9939-d62e93b4960c", "ApplicationUser", "Ivy11@yahoo.com", false, 8.7m, true, false, null, "IVY11@YAHOO.COM", "ANASTACIO_DICKENS15", null, "605-521-3965 x738", false, "a1969936-f005-46d9-814c-f2bd9978d923", 2, false, "Anastacio_Dickens15" },
                    { "43", 0, 47, "ad1a086e-a49f-4340-b129-1e0dd47761bf", "ApplicationUser", "Greyson.Erdman@hotmail.com", false, 8.7m, true, false, null, "GREYSON.ERDMAN@HOTMAIL.COM", "LORENA_THOMPSON", null, "666-638-0007 x8584", false, "161f5378-bd43-4e9f-8785-25b859157ecb", 3, false, "Lorena_Thompson" },
                    { "44", 0, 78, "c0988be7-0931-41bd-a5b5-f3689c648005", "ApplicationUser", "Maud.Koepp65@gmail.com", false, 3.7m, true, false, null, "MAUD.KOEPP65@GMAIL.COM", "MERCEDES.GRAHAM", null, "1-536-535-8712", false, "3204d48c-563d-46e6-bac2-0c03f6fb5957", 4, false, "Mercedes.Graham" },
                    { "45", 0, 46, "bcde9661-2d13-4659-bd4d-da7b3164ad5a", "ApplicationUser", "Myrtice_Wuckert77@yahoo.com", false, 2.3m, false, false, null, "MYRTICE_WUCKERT77@YAHOO.COM", "MAXIMILLIAN0", null, "(371) 782-5503 x80336", false, "bae5d89d-ebab-4823-9840-bd3b49ef14c2", 4, false, "Maximillian0" },
                    { "46", 0, 57, "2759b0bd-1cda-4a8a-807c-f20ac80ef81d", "ApplicationUser", "Eva_McGlynn54@yahoo.com", false, 3.7m, true, false, null, "EVA_MCGLYNN54@YAHOO.COM", "DOVIE_BERNHARD", null, "(356) 783-8912 x926", false, "be6097b9-9047-432c-abc5-f9729b3e55c8", 4, false, "Dovie_Bernhard" },
                    { "47", 0, 48, "24ef6314-4878-4fee-914c-7c100bda5269", "ApplicationUser", "Alexys45@yahoo.com", false, 8.3m, false, false, null, "ALEXYS45@YAHOO.COM", "SHERMAN_QUIGLEY", null, "575-564-8644 x66094", false, "d658779c-57a3-444d-bdb4-6662ad4910fd", 2, false, "Sherman_Quigley" },
                    { "48", 0, 78, "3394f620-314c-4191-8c10-14cf0027fa01", "ApplicationUser", "Esperanza_Kerluke@hotmail.com", false, 1.9m, true, false, null, "ESPERANZA_KERLUKE@HOTMAIL.COM", "ELTA.RUNOLFSSON10", null, "431-646-5386", false, "a6481606-e3ee-4531-a634-bff48535a045", 4, false, "Elta.Runolfsson10" },
                    { "49", 0, 26, "ee6b7f56-74f9-4824-baea-d36f8d26e065", "ApplicationUser", "Lonie.Ondricka68@yahoo.com", false, 1.4m, false, false, null, "LONIE.ONDRICKA68@YAHOO.COM", "GODFREY.HIRTHE82", null, "1-744-457-6349", false, "5cdc30e2-3d73-4e38-8a34-8384ed32dca6", 3, false, "Godfrey.Hirthe82" },
                    { "5", 0, 65, "74919649-4445-4178-8d85-b766cba88ae5", "ApplicationUser", "Augustine.Macejkovic@gmail.com", false, 8.7m, false, false, null, "AUGUSTINE.MACEJKOVIC@GMAIL.COM", "KAREEM.ERDMAN", null, "(338) 247-4310", false, "554a370f-4663-452e-b66f-8d7a4e847522", 4, false, "Kareem.Erdman" },
                    { "50", 0, 80, "280ace5e-9581-451a-a85e-8ba07a232be2", "ApplicationUser", "Jamison.Conn@gmail.com", false, 3.2m, true, false, null, "JAMISON.CONN@GMAIL.COM", "SHEA_THIEL", null, "1-466-286-2229 x648", false, "d2954b2f-e30b-4623-aba0-65c9884ae3e5", 4, false, "Shea_Thiel" },
                    { "51", 0, 15, "1784c545-84d9-48ac-9224-4b7f02f9846a", "ApplicationUser", "Clay85@gmail.com", false, 4.5m, false, false, null, "CLAY85@GMAIL.COM", "GIANNI.BASHIRIAN", null, "(362) 740-1599 x21156", false, "83af8e8e-0f9d-464f-9101-0d491531b44c", 1, false, "Gianni.Bashirian" },
                    { "52", 0, 31, "b1d064e2-83eb-4e78-b9c2-0b75cdc777ed", "ApplicationUser", "Elmore_Macejkovic@yahoo.com", false, 6.0m, false, false, null, "ELMORE_MACEJKOVIC@YAHOO.COM", "BERNADINE2", null, "239.803.1547", false, "6e9b3207-7a5f-4c2a-9d5b-c007331eaf69", 3, false, "Bernadine2" },
                    { "53", 0, 71, "1b1a0a52-0d19-4a01-82f1-d87986d1f4a1", "ApplicationUser", "Velva32@yahoo.com", false, 1.9m, false, false, null, "VELVA32@YAHOO.COM", "TARA_RENNER57", null, "213.503.6335", false, "dcf9dc27-6b97-4767-bdff-277319485c26", 4, false, "Tara_Renner57" },
                    { "54", 0, 26, "4ee6f85a-27b1-4816-a78e-41a6ca3a31a8", "ApplicationUser", "Rocky5@hotmail.com", false, 4.0m, false, false, null, "ROCKY5@HOTMAIL.COM", "LEW.BOTSFORD95", null, "(442) 537-8301", false, "626b3c34-8f4c-4e20-a9dd-d22bc2dd1c5f", 3, false, "Lew.Botsford95" },
                    { "55", 0, 35, "7dc91b02-45f9-4189-a8cb-05e5ff213426", "ApplicationUser", "Deja70@hotmail.com", false, 9.2m, false, false, null, "DEJA70@HOTMAIL.COM", "MARY96", null, "238.234.6866", false, "d7bf0880-0c0c-4ff1-ba52-601016c3545b", 3, false, "Mary96" },
                    { "56", 0, 72, "0bb60a55-5c0a-49e3-aac1-6bddd6daf580", "ApplicationUser", "Toni_Sporer61@hotmail.com", false, 8.5m, false, false, null, "TONI_SPORER61@HOTMAIL.COM", "IVORY72", null, "946-596-4039", false, "4591514e-8a9e-41c2-8cb2-18e0e27e603c", 2, false, "Ivory72" },
                    { "57", 0, 72, "5306a608-23dc-46d8-b512-64314672f77f", "ApplicationUser", "Isabella98@hotmail.com", false, 0.6m, true, false, null, "ISABELLA98@HOTMAIL.COM", "JILLIAN.PFEFFER99", null, "(886) 659-1436 x72621", false, "7b552352-20e2-4278-8811-843ad80fb9b4", 2, false, "Jillian.Pfeffer99" },
                    { "58", 0, 33, "d8ca8a91-712d-4b9f-8cde-bd4a0a4676d2", "ApplicationUser", "Quincy.Jacobson34@gmail.com", false, 1.0m, true, false, null, "QUINCY.JACOBSON34@GMAIL.COM", "KIRA.BRUEN", null, "(242) 504-6037 x473", false, "07274235-8fdb-40d8-aae4-cd51fc2b13b9", 2, false, "Kira.Bruen" },
                    { "59", 0, 32, "8157259f-3960-4746-babf-38d978c56559", "ApplicationUser", "Myrtis.Dibbert@gmail.com", false, 3.7m, true, false, null, "MYRTIS.DIBBERT@GMAIL.COM", "CHRIST_EMMERICH19", null, "927.431.0057", false, "9c0c20e8-60ee-45ea-99bd-7e0a1c65ae42", 2, false, "Christ_Emmerich19" },
                    { "6", 0, 26, "db290ab3-9fe5-450c-b237-3941a4c27b26", "ApplicationUser", "Isobel44@yahoo.com", false, 8.3m, true, false, null, "ISOBEL44@YAHOO.COM", "RAE77", null, "1-671-311-1292 x4095", false, "53457c9d-2bf8-42c5-98f0-39dd09b42c56", 3, false, "Rae77" },
                    { "60", 0, 49, "4b2f1083-6dc5-496c-9aa9-49f2474e880d", "ApplicationUser", "Elmer40@yahoo.com", false, 2.1m, true, false, null, "ELMER40@YAHOO.COM", "THERESA59", null, "684.648.2349", false, "aff7c073-5020-4332-88d2-ee6dbe3f0ab7", 2, false, "Theresa59" },
                    { "61", 0, 30, "d4618d9e-3099-496c-a394-d0fb5e8973f2", "ApplicationUser", "Lois.Kerluke@hotmail.com", false, 2.2m, false, false, null, "LOIS.KERLUKE@HOTMAIL.COM", "LULU.RODRIGUEZ", null, "(567) 880-5572", false, "61e33dde-4ef4-419d-a463-dd9001ef6d65", 2, false, "Lulu.Rodriguez" },
                    { "62", 0, 31, "cd63c457-654e-4a84-9d6a-9c4a693ad0c4", "ApplicationUser", "Brenna.Reynolds@yahoo.com", false, 8.5m, false, false, null, "BRENNA.REYNOLDS@YAHOO.COM", "BERNADINE86", null, "212.868.7234 x440", false, "9a389b5d-4998-4b54-b44d-25175da3ff34", 4, false, "Bernadine86" },
                    { "63", 0, 59, "4ccac8c9-e6a6-4ceb-9f51-926f63e92dc6", "ApplicationUser", "Amalia_Kozey39@yahoo.com", false, 6.7m, false, false, null, "AMALIA_KOZEY39@YAHOO.COM", "HOPE_OHARA", null, "1-811-713-6987", false, "89c2dda5-feff-4bbf-baa2-8fb84d59a8ef", 2, false, "Hope_OHara" },
                    { "64", 0, 16, "9f732b60-0078-4488-b90a-2a30e1f52ea8", "ApplicationUser", "Jack40@hotmail.com", false, 2.0m, true, false, null, "JACK40@HOTMAIL.COM", "ETTIE.LEANNON9", null, "940.974.0669", false, "917aa26d-918f-4539-b219-7e90a8d4bfaf", 1, false, "Ettie.Leannon9" },
                    { "65", 0, 35, "16a57811-39ef-4bcb-8c7d-36b482a50331", "ApplicationUser", "Elsa_Greenfelder4@gmail.com", false, 7.8m, false, false, null, "ELSA_GREENFELDER4@GMAIL.COM", "MATHEW_BUCKRIDGE37", null, "260.427.8624 x5775", false, "c2aa9268-aa88-4be3-964f-6fddf29351a8", 3, false, "Mathew_Buckridge37" },
                    { "66", 0, 24, "a17fa86d-8e7b-486b-9d5a-316bef60e0c9", "ApplicationUser", "Constantin_Stark@gmail.com", false, 9.5m, false, false, null, "CONSTANTIN_STARK@GMAIL.COM", "ROSENDO_MCCLURE97", null, "(899) 662-8853 x7413", false, "622325a1-e40a-4c88-9bba-ad673c60f9f9", 3, false, "Rosendo_McClure97" },
                    { "67", 0, 53, "4b7c984e-58dc-4dbf-b545-de2e35e6f2ab", "ApplicationUser", "Julianne_Oberbrunner85@hotmail.com", false, 2.1m, true, false, null, "JULIANNE_OBERBRUNNER85@HOTMAIL.COM", "ADELBERT72", null, "1-696-959-7463 x99666", false, "3bb0a79c-36b8-445a-8013-ff65d8e660e0", 2, false, "Adelbert72" },
                    { "68", 0, 48, "c57caf1f-7714-46dd-ada6-60b8a3eb02fb", "ApplicationUser", "Anabelle_Breitenberg@hotmail.com", false, 6.0m, true, false, null, "ANABELLE_BREITENBERG@HOTMAIL.COM", "TAMIA13", null, "819-474-1814", false, "94dcf569-2dde-43ea-a30c-24772cb19f0b", 2, false, "Tamia13" },
                    { "69", 0, 30, "21a5b8ff-77c0-48fe-bcf2-9377fda5940e", "ApplicationUser", "Keshawn84@gmail.com", false, 8.6m, true, false, null, "KESHAWN84@GMAIL.COM", "TERRILL_OREILLY50", null, "(840) 504-9929 x7752", false, "f7b308d9-61ce-4d8b-b749-091ab208b667", 3, false, "Terrill_OReilly50" },
                    { "7", 0, 22, "a1fd1faf-07d2-4b40-b980-8903f1dd11a4", "ApplicationUser", "Elisha_Streich@gmail.com", false, 8.0m, true, false, null, "ELISHA_STREICH@GMAIL.COM", "DELTA_LEBSACK", null, "1-215-595-2853 x0685", false, "d4b1910c-1487-43ba-8d9f-c726171da4f9", 4, false, "Delta_Lebsack" },
                    { "70", 0, 79, "1340a917-9e23-4d3f-9479-00157c7e278f", "ApplicationUser", "Layla_Herman79@hotmail.com", false, 6.6m, true, false, null, "LAYLA_HERMAN79@HOTMAIL.COM", "ELIAN75", null, "1-311-382-0720 x689", false, "57807b78-6e17-49e0-a6ec-7880fe4b5fc4", 3, false, "Elian75" },
                    { "71", 0, 20, "2f9f15b6-b993-49f8-9e26-3f435c0209c2", "ApplicationUser", "Jean.Rodriguez@yahoo.com", false, 6.5m, true, false, null, "JEAN.RODRIGUEZ@YAHOO.COM", "SARINA_ORTIZ44", null, "494-253-2093 x4678", false, "3f82d159-3058-45e8-85fe-dfbfb0cd2f05", 3, false, "Sarina_Ortiz44" },
                    { "72", 0, 12, "509bf220-9e9e-4e82-9d43-e94b6a8c6b25", "ApplicationUser", "Tracy0@yahoo.com", false, 8.4m, true, false, null, "TRACY0@YAHOO.COM", "ROWENA83", null, "1-262-776-1227 x2434", false, "c9f4094f-f11c-4c1a-b9ab-52d07b623c95", 1, false, "Rowena83" },
                    { "73", 0, 30, "e60dfb76-f373-4574-b808-1225bfcbcf3c", "ApplicationUser", "Mercedes.Gusikowski@gmail.com", false, 0.3m, true, false, null, "MERCEDES.GUSIKOWSKI@GMAIL.COM", "JARED_KUNDE14", null, "725-557-9397", false, "f2c3c8ca-1879-49dc-aa5c-8a97f3e780c4", 4, false, "Jared_Kunde14" },
                    { "74", 0, 51, "5d801200-4457-4e47-8031-133e3bd11cbd", "ApplicationUser", "Lew17@gmail.com", false, 7.0m, false, false, null, "LEW17@GMAIL.COM", "CHRISTIAN34", null, "369.792.8640 x2395", false, "e3a603ae-0585-496b-b626-7534d5b1c3cc", 4, false, "Christian34" },
                    { "75", 0, 35, "a68071eb-6b15-41a3-b267-1fcd136d61d8", "ApplicationUser", "Marian_Deckow@hotmail.com", false, 2.5m, true, false, null, "MARIAN_DECKOW@HOTMAIL.COM", "MEDA_GRIMES79", null, "487.326.1090", false, "b21495fb-dbc3-487a-8d52-857062d3cedc", 3, false, "Meda_Grimes79" },
                    { "76", 0, 16, "2a54c099-79dc-4353-9fb8-bd9e5a467992", "ApplicationUser", "Patrick.Jacobson@yahoo.com", false, 1.6m, false, false, null, "PATRICK.JACOBSON@YAHOO.COM", "MEDA_GOTTLIEB43", null, "(566) 657-2800 x5839", false, "629bbd77-0c81-4fd9-be3e-d333fd006058", 1, false, "Meda_Gottlieb43" },
                    { "77", 0, 16, "e61b69f7-008c-42ed-9369-e20152299fc7", "ApplicationUser", "Kamron23@hotmail.com", false, 9.5m, false, false, null, "KAMRON23@HOTMAIL.COM", "AYANA_KUPHAL13", null, "1-634-557-1844 x5995", false, "d371fe74-ea6b-42db-99ae-e09f766a7670", 1, false, "Ayana_Kuphal13" },
                    { "78", 0, 54, "9a6a6b27-71d3-46b9-940e-f6130192bb62", "ApplicationUser", "Tabitha.Nolan@hotmail.com", false, 2.6m, true, false, null, "TABITHA.NOLAN@HOTMAIL.COM", "STEPHEN_JACOBSON72", null, "1-373-356-9277", false, "35dbfea5-7a8a-429c-b8e3-aeaff054e3f9", 2, false, "Stephen_Jacobson72" },
                    { "79", 0, 74, "1bba20cd-650a-4e7d-b0e7-aba1b9294bf2", "ApplicationUser", "Julianne78@gmail.com", false, 9.8m, false, false, null, "JULIANNE78@GMAIL.COM", "MALCOLM_OCONNER79", null, "(934) 839-6567 x628", false, "2c2d580a-60bd-445d-bf74-a20a8a8e550e", 3, false, "Malcolm_OConner79" },
                    { "8", 0, 25, "a17d20b9-d20c-4579-86e3-4a37d6619475", "ApplicationUser", "Adelbert41@gmail.com", false, 8.2m, true, false, null, "ADELBERT41@GMAIL.COM", "BERNICE.KING", null, "(276) 253-6629", false, "63725107-b5c9-46aa-97c6-5e2fd74a9509", 4, false, "Bernice.King" },
                    { "80", 0, 13, "ca0a860c-82af-4e61-b58b-fc9294199865", "ApplicationUser", "Dominic_Kulas@gmail.com", false, 1.9m, true, false, null, "DOMINIC_KULAS@GMAIL.COM", "ANGELA98", null, "1-322-503-8266 x69241", false, "b06adcf4-8790-4d95-9869-720587ef36b9", 1, false, "Angela98" },
                    { "81", 0, 74, "61ed69a4-78bd-44e7-924e-650b10db15f1", "ApplicationUser", "Sincere.Beier@hotmail.com", false, 6.2m, true, false, null, "SINCERE.BEIER@HOTMAIL.COM", "LENNY73", null, "1-479-502-8911 x944", false, "5f3ddf87-a615-4f16-8aba-964ff0c0e2f8", 2, false, "Lenny73" },
                    { "82", 0, 53, "f3b5821b-3f2d-4c91-9e9b-585ca58686ed", "ApplicationUser", "Vivian.Cruickshank56@yahoo.com", false, 1.6m, false, false, null, "VIVIAN.CRUICKSHANK56@YAHOO.COM", "RAMIRO.HERMANN1", null, "928-612-6597 x955", false, "e62353a0-ca94-4461-88dd-9e50de5b6ded", 3, false, "Ramiro.Hermann1" },
                    { "83", 0, 58, "d6d3b6ae-edae-409a-b16d-d4f8f7c5759d", "ApplicationUser", "Antonio_Kub@yahoo.com", false, 9.3m, true, false, null, "ANTONIO_KUB@YAHOO.COM", "FRANCESCA10", null, "1-480-341-2925 x0910", false, "f86e6760-9d26-4d81-976e-c77b28b27c53", 2, false, "Francesca10" },
                    { "84", 0, 68, "673c8f5a-fb97-43be-b34c-0d5e5da83e1f", "ApplicationUser", "Caitlyn_Bahringer@yahoo.com", false, 7.5m, true, false, null, "CAITLYN_BAHRINGER@YAHOO.COM", "LILIAN.DONNELLY50", null, "237-323-0510 x234", false, "2016a3dd-a36e-46e6-bb95-49939624374d", 2, false, "Lilian.Donnelly50" },
                    { "85", 0, 39, "f98f8e0f-432e-4d39-8f3d-e1442a8f74fd", "ApplicationUser", "Felton23@gmail.com", false, 5.8m, true, false, null, "FELTON23@GMAIL.COM", "RHIANNON51", null, "1-594-817-5423", false, "2a770570-5b34-4cdb-bd20-4d3042374813", 4, false, "Rhiannon51" },
                    { "86", 0, 69, "e4660507-edbb-4874-a47b-8cf3af3c091f", "ApplicationUser", "Hayden.Volkman68@gmail.com", false, 6.1m, true, false, null, "HAYDEN.VOLKMAN68@GMAIL.COM", "AMIRA.FEEST80", null, "949.802.0066", false, "cd6627ca-db02-45b6-80bc-11521dbf3b5b", 2, false, "Amira.Feest80" },
                    { "87", 0, 77, "aa1995df-dccc-488a-9ad0-ae5be46bd364", "ApplicationUser", "Roger_Cummerata73@yahoo.com", false, 0.6m, false, false, null, "ROGER_CUMMERATA73@YAHOO.COM", "KIRSTEN.HERMISTON69", null, "1-237-622-6482 x5419", false, "321ace1c-ee68-4c38-9cc9-dd04db6465fc", 4, false, "Kirsten.Hermiston69" },
                    { "88", 0, 79, "b861265d-65eb-4395-893f-24348f4fb02d", "ApplicationUser", "Gianni_Trantow2@gmail.com", false, 7.6m, true, false, null, "GIANNI_TRANTOW2@GMAIL.COM", "TYREE.JOHNS", null, "1-694-212-1530 x5535", false, "7c96c64c-b976-46fd-80d4-70b3fec500b9", 4, false, "Tyree.Johns" },
                    { "89", 0, 70, "28e80f1e-61e7-4f9e-93a2-79073e35ea8c", "ApplicationUser", "Precious77@yahoo.com", false, 0.1m, false, false, null, "PRECIOUS77@YAHOO.COM", "ANNETTE_ZBONCAK", null, "796-708-4690", false, "574e46b9-60d1-4b6e-88a3-79777d15e21e", 4, false, "Annette_Zboncak" },
                    { "9", 0, 37, "3400ff99-036a-4fda-8bba-6a1c5423df0c", "ApplicationUser", "Amira_Runolfsdottir@hotmail.com", false, 4.2m, true, false, null, "AMIRA_RUNOLFSDOTTIR@HOTMAIL.COM", "ANNALISE79", null, "1-551-554-7572 x599", false, "22fe90cb-52c2-48bc-b84c-4762911602df", 4, false, "Annalise79" },
                    { "90", 0, 67, "61f61939-5a02-41fb-9112-b7979407a730", "ApplicationUser", "Lilliana.Waters@hotmail.com", false, 3.3m, true, false, null, "LILLIANA.WATERS@HOTMAIL.COM", "JOANNY84", null, "1-750-923-3036 x071", false, "3ad68e97-ca18-4cfc-979a-889816be3811", 2, false, "Joanny84" },
                    { "91", 0, 63, "098ed7ed-4cd2-4186-9d58-21fb39a0e88b", "ApplicationUser", "Jessika31@gmail.com", false, 3.5m, true, false, null, "JESSIKA31@GMAIL.COM", "GARRET.SCHUMM", null, "618.652.8086 x105", false, "895c214f-bea6-4e7f-b440-1e63a3b713b3", 2, false, "Garret.Schumm" },
                    { "92", 0, 18, "4a187fa8-3c10-40ca-9a61-59fad6e18c94", "ApplicationUser", "Jordi.Spencer@gmail.com", false, 4.2m, false, false, null, "JORDI.SPENCER@GMAIL.COM", "EUNICE86", null, "(490) 692-9677", false, "6ef77983-18b8-4c29-9d37-e4b55e46b550", 4, false, "Eunice86" },
                    { "93", 0, 35, "187b136d-5016-4efa-af66-98f9f5ca0c6f", "ApplicationUser", "Lilyan27@gmail.com", false, 8.6m, false, false, null, "LILYAN27@GMAIL.COM", "DASIA32", null, "(981) 772-3715 x9191", false, "84d545c4-0b3e-464b-93b7-765fa16ff319", 2, false, "Dasia32" },
                    { "94", 0, 27, "1c20aa0c-f5ce-4920-9289-708ef1af8903", "ApplicationUser", "Petra98@hotmail.com", false, 5.3m, false, false, null, "PETRA98@HOTMAIL.COM", "NASIR_WEHNER", null, "(876) 853-0056 x61959", false, "85721a00-cd79-43dc-9581-1d8a3b540edf", 4, false, "Nasir_Wehner" },
                    { "95", 0, 38, "e799bdd1-840e-48ce-a1d1-8e08dacf57bd", "ApplicationUser", "Vaughn_Johns47@gmail.com", false, 0.3m, false, false, null, "VAUGHN_JOHNS47@GMAIL.COM", "PRESTON48", null, "951-523-1868", false, "11ab0b7b-2db2-4147-a008-3fa81cfbde0c", 3, false, "Preston48" },
                    { "96", 0, 13, "ce3a3eae-3286-4969-8ab2-ab5637ab8d08", "ApplicationUser", "Edgardo_Tremblay@hotmail.com", false, 1.6m, false, false, null, "EDGARDO_TREMBLAY@HOTMAIL.COM", "FAUSTO.MAGGIO36", null, "206.988.7645", false, "d5ec42c3-f3f2-4854-b6e4-cf38d387cf85", 1, false, "Fausto.Maggio36" },
                    { "97", 0, 34, "b6249698-b357-419d-b23f-e0e882073559", "ApplicationUser", "Rodger58@hotmail.com", false, 9.2m, true, false, null, "RODGER58@HOTMAIL.COM", "EFREN18", null, "940.372.5738", false, "7f0d8805-4fa9-414b-a250-b189ac6112f5", 3, false, "Efren18" },
                    { "98", 0, 54, "97595c81-b51a-42cf-a7b2-a7c3d8edfd8f", "ApplicationUser", "Gayle72@gmail.com", false, 4.5m, false, false, null, "GAYLE72@GMAIL.COM", "LONNIE.EMMERICH77", null, "732-581-7449 x7601", false, "19314e0f-36a3-4865-8d2c-300d18ef27e0", 2, false, "Lonnie.Emmerich77" },
                    { "99", 0, 61, "16ff7563-07b2-4d97-a342-2c6a8927c779", "ApplicationUser", "Maegan_Krajcik@hotmail.com", false, 8.9m, true, false, null, "MAEGAN_KRAJCIK@HOTMAIL.COM", "KEANU.CASSIN82", null, "247-777-3752 x308", false, "3358f841-2e22-4ec3-b54a-bd547fcbf727", 2, false, "Keanu.Cassin82" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 2, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8, "Intelligent Frozen Bike", null, 2008 },
                    { 2, 2, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, "Incredible Rubber Pants", null, 2002 },
                    { 3, 1, 4, "The Football Is Good For Training And Recreational Purposes", 1, "Handcrafted Concrete Soap", null, 2013 },
                    { 4, 19, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Awesome Steel Cheese", null, 2013 },
                    { 5, 13, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Handcrafted Plastic Pants", null, 2013 },
                    { 6, 20, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Fantastic Fresh Gloves", null, 2015 },
                    { 7, 19, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, "Practical Fresh Fish", null, 2009 },
                    { 8, 7, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Intelligent Plastic Shirt", null, 2003 },
                    { 9, 15, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Incredible Steel Towels", null, 2007 },
                    { 10, 13, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Awesome Concrete Keyboard", null, 2012 },
                    { 11, 16, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Sleek Plastic Sausages", null, 2006 },
                    { 12, 12, 1, "The Football Is Good For Training And Recreational Purposes", 6, "Practical Metal Tuna", null, 2023 },
                    { 13, 12, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Gorgeous Rubber Sausages", null, 2018 },
                    { 14, 1, 1, "The Football Is Good For Training And Recreational Purposes", 2, "Intelligent Metal Pants", null, 2005 },
                    { 15, 15, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, "Rustic Concrete Tuna", null, 2020 },
                    { 16, 20, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Intelligent Concrete Bacon", null, 2004 },
                    { 17, 1, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8, "Small Metal Sausages", null, 2013 },
                    { 18, 17, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, "Licensed Fresh Sausages", null, 2004 },
                    { 19, 3, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, "Rustic Steel Bacon", null, 2014 },
                    { 20, 18, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Intelligent Fresh Computer", null, 2020 },
                    { 21, 12, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Handmade Frozen Pizza", null, 2019 },
                    { 22, 14, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Fantastic Soft Fish", null, 2018 },
                    { 23, 11, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Unbranded Plastic Bacon", null, 2004 },
                    { 24, 17, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, "Awesome Steel Towels", null, 2020 },
                    { 25, 5, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Rustic Cotton Shoes", null, 2020 },
                    { 26, 19, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Handcrafted Wooden Chicken", null, 2011 },
                    { 27, 1, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Sleek Frozen Bike", null, 2005 },
                    { 28, 18, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, "Sleek Plastic Sausages", null, 2014 },
                    { 29, 3, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Licensed Soft Hat", null, 2000 },
                    { 30, 2, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Sleek Wooden Car", null, 2009 },
                    { 31, 9, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Awesome Metal Chips", null, 2000 },
                    { 32, 18, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10, "Tasty Frozen Shoes", null, 2019 },
                    { 33, 3, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 7, "Intelligent Fresh Towels", null, 2013 },
                    { 34, 5, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Fantastic Plastic Table", null, 2017 },
                    { 35, 12, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8, "Handcrafted Steel Gloves", null, 2005 },
                    { 36, 2, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Rustic Concrete Chair", null, 2001 },
                    { 37, 9, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Fantastic Soft Pizza", null, 2011 },
                    { 38, 11, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, "Handcrafted Fresh Shirt", null, 2014 },
                    { 39, 1, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Gorgeous Steel Computer", null, 2009 },
                    { 40, 10, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, "Handmade Frozen Car", null, 2023 },
                    { 41, 11, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10, "Awesome Wooden Tuna", null, 2004 },
                    { 42, 1, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Rustic Concrete Mouse", null, 2002 },
                    { 43, 13, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Fantastic Rubber Keyboard", null, 2001 },
                    { 44, 8, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8, "Handmade Frozen Pizza", null, 2020 },
                    { 45, 10, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Ergonomic Concrete Gloves", null, 2004 },
                    { 46, 5, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Intelligent Steel Tuna", null, 2016 },
                    { 47, 13, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Handmade Fresh Chicken", null, 2015 },
                    { 48, 10, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8, "Sleek Soft Fish", null, 2008 },
                    { 49, 6, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Rustic Granite Bacon", null, 2016 },
                    { 50, 13, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9, "Generic Steel Gloves", null, 2022 },
                    { 51, 1, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Licensed Frozen Towels", null, 2001 },
                    { 52, 15, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8, "Awesome Soft Sausages", null, 2008 },
                    { 53, 7, 3, "The Football Is Good For Training And Recreational Purposes", 2, "Incredible Concrete Bike", null, 2016 },
                    { 54, 20, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Incredible Plastic Computer", null, 2023 },
                    { 55, 12, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, "Practical Concrete Mouse", null, 2004 },
                    { 56, 20, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Practical Wooden Car", null, 2019 },
                    { 57, 18, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 7, "Generic Granite Bacon", null, 2009 },
                    { 58, 15, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Tasty Steel Gloves", null, 2001 },
                    { 59, 18, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Fantastic Plastic Gloves", null, 2014 },
                    { 60, 3, 4, "The Football Is Good For Training And Recreational Purposes", 9, "Awesome Fresh Mouse", null, 2023 },
                    { 61, 14, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Generic Steel Tuna", null, 2020 },
                    { 62, 5, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7, "Handmade Frozen Hat", null, 2004 },
                    { 63, 7, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Intelligent Granite Hat", null, 2017 },
                    { 64, 11, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9, "Handcrafted Frozen Sausages", null, 2009 },
                    { 65, 6, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Tasty Wooden Computer", null, 2010 },
                    { 66, 7, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Intelligent Soft Table", null, 2008 },
                    { 67, 20, 5, "The Football Is Good For Training And Recreational Purposes", 2, "Rustic Cotton Soap", null, 2003 },
                    { 68, 19, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, "Sleek Concrete Tuna", null, 2009 },
                    { 69, 13, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8, "Handmade Plastic Cheese", null, 2019 },
                    { 70, 20, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Fantastic Concrete Tuna", null, 2015 },
                    { 71, 19, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Fantastic Steel Bacon", null, 2018 },
                    { 72, 10, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7, "Handmade Concrete Bike", null, 2009 },
                    { 73, 16, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, "Licensed Metal Pizza", null, 2008 },
                    { 74, 16, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 7, "Unbranded Plastic Fish", null, 2012 },
                    { 75, 10, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Small Fresh Soap", null, 2015 },
                    { 76, 8, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8, "Refined Steel Keyboard", null, 2020 },
                    { 77, 19, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Unbranded Fresh Ball", null, 2003 },
                    { 78, 19, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8, "Refined Rubber Mouse", null, 2006 },
                    { 79, 6, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Sleek Soft Chicken", null, 2012 },
                    { 80, 4, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 8, "Practical Soft Mouse", null, 2005 },
                    { 81, 2, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Ergonomic Metal Fish", null, 2012 },
                    { 82, 1, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 7, "Handcrafted Soft Bike", null, 2017 },
                    { 83, 18, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 1, "Refined Fresh Chips", null, 2008 },
                    { 84, 19, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Incredible Cotton Tuna", null, 2000 },
                    { 85, 5, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Gorgeous Granite Chair", null, 2000 },
                    { 86, 19, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8, "Intelligent Wooden Soap", null, 2008 },
                    { 87, 2, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, "Generic Metal Tuna", null, 2014 },
                    { 88, 9, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, "Ergonomic Soft Salad", null, 2012 },
                    { 89, 8, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, "Practical Fresh Pants", null, 2000 },
                    { 90, 18, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Handcrafted Frozen Hat", null, 2013 },
                    { 91, 15, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Refined Cotton Bike", null, 2001 },
                    { 92, 19, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, "Licensed Soft Hat", null, 2022 },
                    { 93, 18, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Handmade Plastic Car", null, 2003 },
                    { 94, 19, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 7, "Fantastic Steel Bike", null, 2016 },
                    { 95, 1, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Handmade Rubber Gloves", null, 2014 },
                    { 96, 2, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 7, "Refined Fresh Car", null, 2003 },
                    { 97, 3, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, "Tasty Fresh Fish", null, 2023 },
                    { 98, 3, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Refined Soft Shoes", null, 2008 },
                    { 99, 13, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, "Awesome Wooden Hat", null, 2006 },
                    { 100, 9, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Handcrafted Rubber Chair", null, 2007 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserItem_UsersId",
                table: "ApplicationUserItem",
                column: "UsersId");

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
                name: "IX_AspNetUsers_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Item_AuthorId",
                table: "Item",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryId",
                table: "Item",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserItem_ItemId",
                table: "UserItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_UserItem_UserId",
                table: "UserItem",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserItem");

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
                name: "UserItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Subscription");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
