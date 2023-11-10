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
                    { 1, "Allen", "Sporer" },
                    { 2, "Alvina", "Streich" },
                    { 3, "Stevie", "Schiller" },
                    { 4, "Sonny", "Smitham" },
                    { 5, "Unique", "Terry" },
                    { 6, "Carleton", "Kreiger" },
                    { 7, "Braden", "Goyette" },
                    { 8, "Marcos", "Langosh" },
                    { 9, "Caden", "Nikolaus" },
                    { 10, "Elenor", "Ullrich" },
                    { 11, "Joseph", "Hansen" },
                    { 12, "Myah", "Weber" },
                    { 13, "Sherwood", "Doyle" },
                    { 14, "Estrella", "Botsford" },
                    { 15, "Delpha", "Prohaska" },
                    { 16, "Nicholas", "Nikolaus" },
                    { 17, "Ocie", "Gottlieb" },
                    { 18, "Brad", "Lind" },
                    { 19, "Rebeka", "Nikolaus" },
                    { 20, "Shana", "Boyer" }
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
                    { 1, 0m, 3, 10, 3, 17, 0, "Jeugd", 0.25m, 0m, null },
                    { 2, 0.30m, 1, 10, 3, null, 18, "Budget", 0.25m, 1m, 10 },
                    { 3, 0.30m, 3, 10, 3, null, 18, "Basis", 0.25m, 4m, null },
                    { 4, 0m, 5, 20, 3, null, 18, "Top", 0m, 6m, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Fine", "IsBlocked", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 41, "a047f84b-1100-4758-af40-cc4e2cc6f472", "ApplicationUser", "Elta63@gmail.com", false, 0.2m, false, false, null, "ELTA63@GMAIL.COM", "ZELLA49", null, "795.291.3218 x68376", false, "c9fa4cde-1c2f-4e6d-a7d7-2747675d8f2d", 2, false, "Zella49" },
                    { "10", 0, 42, "062402b7-a019-4f65-8416-9b918fd73d49", "ApplicationUser", "Madaline.Kling@gmail.com", false, 2.6m, false, false, null, "MADALINE.KLING@GMAIL.COM", "AMOS.HOEGER", null, "(641) 969-4160 x52944", false, "6135ca99-6061-4d2f-9fac-5bed73720e42", 3, false, "Amos.Hoeger" },
                    { "100", 0, 68, "bd8f23b8-5a08-420b-b956-b4727e75b05c", "ApplicationUser", "Rowena49@hotmail.com", false, 8.4m, false, false, null, "ROWENA49@HOTMAIL.COM", "MICHELE_CORMIER83", null, "1-882-777-8560 x94954", false, "b54338b2-05be-4e2c-ae3b-865f0b6dc69f", 4, false, "Michele_Cormier83" },
                    { "11", 0, 69, "a8e8de75-361a-4b5c-883c-7af37039cea3", "ApplicationUser", "Madie14@yahoo.com", false, 9.4m, false, false, null, "MADIE14@YAHOO.COM", "BRIANA.BUCKRIDGE", null, "1-447-694-1136 x92289", false, "11cae240-3ba2-41b6-a41b-6d5caab5dba0", 3, false, "Briana.Buckridge" },
                    { "12", 0, 66, "cbca3d90-1c6c-4598-8ee0-f5d97fb5f8ca", "ApplicationUser", "Savanah.Schumm@yahoo.com", false, 5.1m, false, false, null, "SAVANAH.SCHUMM@YAHOO.COM", "ALVIS_ALTENWERTH", null, "(453) 619-6820 x01961", false, "5ae22716-6dfc-418d-8e92-c383af8b96ba", 3, false, "Alvis_Altenwerth" },
                    { "13", 0, 39, "50a8bd86-af5b-46f6-95e2-645895d73c52", "ApplicationUser", "Jose.Cole@gmail.com", false, 6.6m, true, false, null, "JOSE.COLE@GMAIL.COM", "AFTON.BLOCK51", null, "355.663.6560", false, "92fb2ebd-b8df-4acc-91e1-de2872c39574", 4, false, "Afton.Block51" },
                    { "14", 0, 37, "69bc1935-8018-4920-a9e0-596587148f22", "ApplicationUser", "Gaylord50@yahoo.com", false, 7.9m, true, false, null, "GAYLORD50@YAHOO.COM", "ALEXYS_BATZ", null, "(258) 239-9070 x64843", false, "60b4dfcd-82aa-4610-b16e-052137844abf", 3, false, "Alexys_Batz" },
                    { "15", 0, 46, "c788ae24-d689-4973-a23a-d88cef87d10b", "ApplicationUser", "Franz_Morissette58@yahoo.com", false, 0.8m, true, false, null, "FRANZ_MORISSETTE58@YAHOO.COM", "WOODROW_KUNZE69", null, "(680) 767-6456 x64041", false, "7430edaa-9160-41d0-855d-7f450885b352", 3, false, "Woodrow_Kunze69" },
                    { "16", 0, 69, "4635db27-e979-4c25-bb75-ed9eee8abc7f", "ApplicationUser", "Brown_Metz21@hotmail.com", false, 8.9m, false, false, null, "BROWN_METZ21@HOTMAIL.COM", "JACKELINE_FARRELL77", null, "876.444.7136 x0841", false, "3b1c2a85-7770-43b2-9fe9-7afb352ae92f", 2, false, "Jackeline_Farrell77" },
                    { "17", 0, 32, "d6a2c683-d1da-4166-8e7e-4f4d468dc2e1", "ApplicationUser", "Flavio_Treutel47@gmail.com", false, 3.3m, true, false, null, "FLAVIO_TREUTEL47@GMAIL.COM", "WILFRED15", null, "(955) 964-4103 x8901", false, "2e3b4bee-8ff2-427c-92c6-135df41e5c27", 3, false, "Wilfred15" },
                    { "18", 0, 64, "80e97d8d-fa51-473d-a26c-c2520710a401", "ApplicationUser", "Nathen_Prohaska90@gmail.com", false, 5.7m, false, false, null, "NATHEN_PROHASKA90@GMAIL.COM", "ADELA.CHAMPLIN", null, "1-325-512-6023", false, "b5d44bfa-3daa-48dc-9cb8-7d7ee690a2f8", 2, false, "Adela.Champlin" },
                    { "19", 0, 52, "13f1a850-6459-4fc2-b422-8d9b7c6c1473", "ApplicationUser", "Kody_Smitham@yahoo.com", false, 10.0m, false, false, null, "KODY_SMITHAM@YAHOO.COM", "JAZMYNE83", null, "575-796-3947", false, "0eed058f-54a2-4434-b8f5-e1e2a6f08ae4", 2, false, "Jazmyne83" },
                    { "2", 0, 43, "1f1c675c-121f-40e3-8950-7f31a9b1e73b", "ApplicationUser", "Wendy34@gmail.com", false, 6.1m, false, false, null, "WENDY34@GMAIL.COM", "HULDA_FISHER", null, "(494) 783-2406 x92800", false, "82280b36-bd70-4394-b76a-db72eeafc3d2", 2, false, "Hulda_Fisher" },
                    { "20", 0, 18, "a8ad1629-81f7-48e4-8af3-5a5975129709", "ApplicationUser", "Delmer_Glover62@gmail.com", false, 1.6m, true, false, null, "DELMER_GLOVER62@GMAIL.COM", "DIANNA_DAVIS55", null, "(881) 235-2629 x96587", false, "0b63643e-eea2-4ae4-8a6e-51e03e187397", 3, false, "Dianna_Davis55" },
                    { "21", 0, 32, "74145e9b-d808-402b-94a1-15c04e59d3e2", "ApplicationUser", "Flavio38@gmail.com", false, 7.5m, false, false, null, "FLAVIO38@GMAIL.COM", "ALVIS_THIEL", null, "(545) 704-8243 x66549", false, "89b43cc2-6b32-480f-b675-39bdee96d431", 2, false, "Alvis_Thiel" },
                    { "22", 0, 28, "48a7d8eb-9ddf-4a8e-aa1c-b4fcdc823ebb", "ApplicationUser", "Earline38@hotmail.com", false, 0.9m, false, false, null, "EARLINE38@HOTMAIL.COM", "LAVON_HESSEL", null, "(997) 354-1655", false, "f2297528-47ca-485d-95a1-71a7eff1dffc", 4, false, "Lavon_Hessel" },
                    { "23", 0, 31, "b759c3fc-f405-49ee-b50c-34c39c17104e", "ApplicationUser", "Candelario69@yahoo.com", false, 5.8m, true, false, null, "CANDELARIO69@YAHOO.COM", "YASMEEN_ZIEMANN", null, "627-824-4017", false, "d0670281-f65a-4046-b6e9-7b32964944df", 4, false, "Yasmeen_Ziemann" },
                    { "24", 0, 70, "4b553908-3c8d-4c0a-9057-577f33b9f0a5", "ApplicationUser", "Abelardo.Durgan40@yahoo.com", false, 0.9m, true, false, null, "ABELARDO.DURGAN40@YAHOO.COM", "DESTINI.ROGAHN11", null, "712-769-3955 x143", false, "5ec920b5-1f01-4bbe-b888-fb6269382d7d", 4, false, "Destini.Rogahn11" },
                    { "25", 0, 55, "66c710f4-c6f4-4770-b6b7-7264a06ae292", "ApplicationUser", "Antonetta86@yahoo.com", false, 5.7m, false, false, null, "ANTONETTA86@YAHOO.COM", "ANTONE96", null, "(860) 588-2265", false, "5e317952-ce2b-4c0f-9eb7-43986b29457b", 2, false, "Antone96" },
                    { "26", 0, 17, "cce1fe01-0daf-4c10-817b-08ec5ee21760", "ApplicationUser", "Eleazar59@hotmail.com", false, 5.3m, false, false, null, "ELEAZAR59@HOTMAIL.COM", "KENDALL21", null, "1-275-509-5187 x979", false, "ad45d9e1-fcf8-4eb5-9e3f-94f1bc5db906", 1, false, "Kendall21" },
                    { "27", 0, 77, "79db5784-51e7-421f-b876-d40a47e372bf", "ApplicationUser", "Retha27@yahoo.com", false, 1.7m, true, false, null, "RETHA27@YAHOO.COM", "KIRSTIN59", null, "(631) 496-6253", false, "d9d50c26-9323-4756-9385-debd5d2f8f70", 2, false, "Kirstin59" },
                    { "28", 0, 50, "ddc2a115-0fa7-4015-a363-7abba98a05b4", "ApplicationUser", "Daija.Crist@hotmail.com", false, 6.3m, true, false, null, "DAIJA.CRIST@HOTMAIL.COM", "PRICE_SCHNEIDER", null, "580-529-9909 x40340", false, "1df4641a-f07d-491a-a0c8-1d0d6779c109", 2, false, "Price_Schneider" },
                    { "29", 0, 15, "9e78d7c0-1bc2-419b-9b6e-03e81e63a919", "ApplicationUser", "Alfreda.Satterfield74@yahoo.com", false, 8.0m, true, false, null, "ALFREDA.SATTERFIELD74@YAHOO.COM", "MARA49", null, "730.363.3206", false, "ffd1c7a9-1a87-491e-81e7-66b3bf842353", 1, false, "Mara49" },
                    { "3", 0, 50, "e0d735ac-c88f-45d2-84bc-952fb9af2380", "ApplicationUser", "Elmo23@yahoo.com", false, 7.6m, true, false, null, "ELMO23@YAHOO.COM", "LOTTIE.LYNCH54", null, "(764) 587-4483 x96046", false, "c950426c-2ddc-46ff-8270-a24154c55942", 3, false, "Lottie.Lynch54" },
                    { "30", 0, 17, "10810fbd-a640-4c5a-a582-6ec49804903f", "ApplicationUser", "Spencer.Carter2@gmail.com", false, 8.3m, true, false, null, "SPENCER.CARTER2@GMAIL.COM", "MONICA_MAYERT35", null, "(533) 584-9052 x442", false, "7cf5898e-8a91-4865-b7c7-36fa109f9070", 1, false, "Monica_Mayert35" },
                    { "31", 0, 49, "849e6232-13e6-4db9-b902-afcb3f8e6def", "ApplicationUser", "Bernardo33@yahoo.com", false, 0.9m, false, false, null, "BERNARDO33@YAHOO.COM", "COLUMBUS_ABERNATHY70", null, "(581) 596-3371", false, "8acc862a-b86e-47e9-8826-916dc190d37d", 2, false, "Columbus_Abernathy70" },
                    { "32", 0, 54, "8d97d5de-ba06-44d3-b2c7-54fcc4bcc668", "ApplicationUser", "Brook52@yahoo.com", false, 7.0m, false, false, null, "BROOK52@YAHOO.COM", "ALBA_EMMERICH", null, "433.527.2502 x6831", false, "93e64557-76d0-413d-8885-5732054f26cc", 2, false, "Alba_Emmerich" },
                    { "33", 0, 64, "3de26d6d-1b8d-4674-8df8-92481f2d4f12", "ApplicationUser", "Anastacio84@gmail.com", false, 0.5m, true, false, null, "ANASTACIO84@GMAIL.COM", "BONITA_RUECKER", null, "(322) 528-4509", false, "708fe860-7e83-4158-b378-fa2ee4135233", 2, false, "Bonita_Ruecker" },
                    { "34", 0, 52, "e166dfe7-d027-4ee2-b964-9ce8a93bf9e6", "ApplicationUser", "Kaela_Torphy@gmail.com", false, 9.0m, false, false, null, "KAELA_TORPHY@GMAIL.COM", "TANNER_JACOBS67", null, "1-549-435-9233 x571", false, "256dadf0-a057-4f41-a216-74106c612b22", 2, false, "Tanner_Jacobs67" },
                    { "35", 0, 16, "31873e3a-7fff-4276-acf9-5d8018944020", "ApplicationUser", "Vernon.Gutmann97@hotmail.com", false, 7.9m, false, false, null, "VERNON.GUTMANN97@HOTMAIL.COM", "MARIELA.WHITE64", null, "642.933.4398", false, "8ba1cc5b-8230-493c-bfb8-b3b91ff64ec2", 1, false, "Mariela.White64" },
                    { "36", 0, 30, "92e24a66-2f43-4048-a3ba-0d4edd595123", "ApplicationUser", "Juana.Kautzer@yahoo.com", false, 3.0m, false, false, null, "JUANA.KAUTZER@YAHOO.COM", "SIM.FEEST", null, "636-921-7212 x1374", false, "1887d32d-a57f-4c8e-a857-5a5fba252da9", 2, false, "Sim.Feest" },
                    { "37", 0, 35, "e949c412-c8bc-4402-b046-7246af8f1417", "ApplicationUser", "Vicenta53@hotmail.com", false, 3.1m, false, false, null, "VICENTA53@HOTMAIL.COM", "MEKHI.PROSACCO", null, "1-636-566-6715 x54830", false, "e76205fe-7a2b-41ec-b108-f028aa30c1be", 4, false, "Mekhi.Prosacco" },
                    { "38", 0, 44, "ff372954-bda9-4d5b-a5b5-c08889f51362", "ApplicationUser", "Grover30@yahoo.com", false, 1.8m, false, false, null, "GROVER30@YAHOO.COM", "MURRAY_SIMONIS", null, "643.713.3663", false, "d9a5b7a1-1f52-4ba6-8d30-8776532ceff1", 4, false, "Murray_Simonis" },
                    { "39", 0, 34, "3237a557-e067-4024-b78e-81f1ae22af42", "ApplicationUser", "Roosevelt_Goldner@hotmail.com", false, 0.7m, false, false, null, "ROOSEVELT_GOLDNER@HOTMAIL.COM", "DAMON_WAELCHI", null, "983-630-6850 x99579", false, "1331542b-aa91-42d0-9ab0-05c62508d278", 3, false, "Damon_Waelchi" },
                    { "4", 0, 71, "7eedba79-dac0-48af-9c76-2c176ea73462", "ApplicationUser", "Laney.Wyman@hotmail.com", false, 9.1m, true, false, null, "LANEY.WYMAN@HOTMAIL.COM", "MANUEL43", null, "1-606-674-6268 x34290", false, "d3523e68-c081-4170-86ea-7c8722569b68", 2, false, "Manuel43" },
                    { "40", 0, 58, "b9582579-223d-444f-b7e8-b21cd878bbe0", "ApplicationUser", "Lorenza_McGlynn69@yahoo.com", false, 0.8m, true, false, null, "LORENZA_MCGLYNN69@YAHOO.COM", "MAYA92", null, "1-325-239-2313 x81290", false, "6ce7cd7f-4f3d-426a-b9d3-c33dbd72265a", 3, false, "Maya92" },
                    { "41", 0, 47, "c7351109-e8b4-4a6f-99fc-05475454e4a6", "ApplicationUser", "Monty51@gmail.com", false, 8.6m, false, false, null, "MONTY51@GMAIL.COM", "DELMER.BOGISICH", null, "1-635-308-6500 x318", false, "228c0d7e-fc47-441b-ac0b-887a892ec01a", 3, false, "Delmer.Bogisich" },
                    { "42", 0, 27, "13fbe44a-c6ee-43f5-a3c7-7c2fd0ff305d", "ApplicationUser", "Dean.Olson@hotmail.com", false, 6.4m, true, false, null, "DEAN.OLSON@HOTMAIL.COM", "MAGALI.FRIESEN45", null, "958.820.2967", false, "806bc14c-051f-43d1-b239-29a5d7b5d69f", 2, false, "Magali.Friesen45" },
                    { "43", 0, 79, "00c35eab-0c69-4aea-92dc-0a5fcc524bb8", "ApplicationUser", "Jensen.Dicki@yahoo.com", false, 2.1m, false, false, null, "JENSEN.DICKI@YAHOO.COM", "KEELY_KOEPP92", null, "697-394-2147 x933", false, "8fad0f4f-6e83-4183-95f1-8857e7f0e03d", 2, false, "Keely_Koepp92" },
                    { "44", 0, 66, "57e3dea3-d8d6-459c-b4bc-7f741a960b0b", "ApplicationUser", "Amy51@gmail.com", false, 2.9m, true, false, null, "AMY51@GMAIL.COM", "ELIZABETH.WATERS71", null, "223-241-3610 x7534", false, "0ac7aae7-10b8-4c79-96f0-2f6cdaba167c", 3, false, "Elizabeth.Waters71" },
                    { "45", 0, 34, "6afcdf18-60f7-41bd-a183-0e5f43e1fe39", "ApplicationUser", "Nelda_Thiel28@hotmail.com", false, 3.7m, false, false, null, "NELDA_THIEL28@HOTMAIL.COM", "MARJOLAINE_KIEHN", null, "1-250-822-9353 x501", false, "db7d8d9c-728a-4f75-ab43-905a7e23d49e", 2, false, "Marjolaine_Kiehn" },
                    { "46", 0, 14, "13e64a45-4b56-4fa7-998f-c71c1cc0abc4", "ApplicationUser", "Fredy50@hotmail.com", false, 0.7m, false, false, null, "FREDY50@HOTMAIL.COM", "VERDA18", null, "(646) 991-9648 x718", false, "8b2337e7-e92e-4281-a415-4fcd3f39ef5b", 1, false, "Verda18" },
                    { "47", 0, 21, "86e697d2-d6a4-4332-9f60-4cb94c264f42", "ApplicationUser", "Lolita35@hotmail.com", false, 3.2m, false, false, null, "LOLITA35@HOTMAIL.COM", "MADALYN85", null, "1-257-366-4174 x24720", false, "e83e5e2a-e4e2-4c77-acf6-a1ef569c14c7", 2, false, "Madalyn85" },
                    { "48", 0, 65, "20e68cbc-adac-44b6-8352-aeeb3df2c4b2", "ApplicationUser", "Minerva81@yahoo.com", false, 2.3m, false, false, null, "MINERVA81@YAHOO.COM", "ELIZA_HIRTHE15", null, "949.225.8509 x043", false, "ad26392e-561a-4983-97b8-2fcdfd165a2d", 4, false, "Eliza_Hirthe15" },
                    { "49", 0, 23, "085227b9-8d1e-4640-8540-f63c39feb36c", "ApplicationUser", "Derick49@gmail.com", false, 1.9m, false, false, null, "DERICK49@GMAIL.COM", "DOMINIQUE_DANIEL", null, "343-527-0767 x5655", false, "585dbe82-24c8-4dc0-b4d6-23dc57dd7ba2", 4, false, "Dominique_Daniel" },
                    { "5", 0, 53, "3c8b5654-e52b-4205-a79d-a223ad836dec", "ApplicationUser", "Vivian.Schmitt@yahoo.com", false, 0.3m, false, false, null, "VIVIAN.SCHMITT@YAHOO.COM", "KITTY_OKUNEVA", null, "580-533-6383", false, "bea7787c-b912-4505-9178-38c89977e326", 3, false, "Kitty_Okuneva" },
                    { "50", 0, 74, "c618755e-8f3a-4e6b-ba5c-5841fadb0ea0", "ApplicationUser", "Estefania15@yahoo.com", false, 1.8m, false, false, null, "ESTEFANIA15@YAHOO.COM", "GREGORIA74", null, "269-758-8691", false, "d2e1b7dd-7df4-47b3-862f-aec4bb67d317", 4, false, "Gregoria74" },
                    { "51", 0, 16, "6344f1c4-b424-4863-aa07-89e9a3073dce", "ApplicationUser", "Alvina74@gmail.com", false, 3.0m, true, false, null, "ALVINA74@GMAIL.COM", "ROMAN_STOLTENBERG", null, "1-257-366-9482 x30099", false, "28614590-eeb9-4fee-9840-dd373bd83bc6", 1, false, "Roman_Stoltenberg" },
                    { "52", 0, 64, "08d67caf-38e6-45e6-a80e-796b046f41ac", "ApplicationUser", "Citlalli_Kihn@yahoo.com", false, 6.8m, false, false, null, "CITLALLI_KIHN@YAHOO.COM", "IKE_BOTSFORD", null, "577.200.1722", false, "35ecf495-c9d9-43fc-8b7a-7513247396ff", 3, false, "Ike_Botsford" },
                    { "53", 0, 60, "b3cfe450-7de4-44b3-964b-2d3343ecfc1a", "ApplicationUser", "Vladimir_Wunsch79@gmail.com", false, 0.2m, false, false, null, "VLADIMIR_WUNSCH79@GMAIL.COM", "DARION_KUNZE79", null, "1-526-806-3073", false, "aa89a266-0bca-4787-8a24-2a748093a494", 4, false, "Darion_Kunze79" },
                    { "54", 0, 65, "a57a9bcf-6300-43dc-9e76-bb05cf4f6651", "ApplicationUser", "Easton_Fritsch36@hotmail.com", false, 2.8m, true, false, null, "EASTON_FRITSCH36@HOTMAIL.COM", "JERMAINE_POUROS", null, "849.445.9377", false, "f0419e84-edfd-434f-9a93-14a2af27961d", 2, false, "Jermaine_Pouros" },
                    { "55", 0, 31, "568fee8a-2b09-4069-9f22-5834a2ab7597", "ApplicationUser", "Sister80@hotmail.com", false, 4.3m, false, false, null, "SISTER80@HOTMAIL.COM", "QUEENIE.RATKE38", null, "818-453-9290 x3696", false, "5067a6be-1d8c-4049-982e-525d2b1b4f41", 4, false, "Queenie.Ratke38" },
                    { "56", 0, 53, "8433010f-daa4-4549-ab0d-725333bade97", "ApplicationUser", "Reyes49@yahoo.com", false, 2.3m, true, false, null, "REYES49@YAHOO.COM", "HUNTER.HAGENES", null, "(752) 707-8891 x4725", false, "ff67a056-a8e6-4513-83af-5c81017603b1", 4, false, "Hunter.Hagenes" },
                    { "57", 0, 55, "9f59e156-e9ab-402a-92b2-70c211da20a9", "ApplicationUser", "Justine.Kertzmann@yahoo.com", false, 0.5m, true, false, null, "JUSTINE.KERTZMANN@YAHOO.COM", "THERESA10", null, "528-954-8722 x25712", false, "b47c77c3-42d4-4ec3-a4a8-758c5a24354a", 2, false, "Theresa10" },
                    { "58", 0, 80, "66991dde-c539-4eef-a036-97646bdd5e99", "ApplicationUser", "Leslie33@yahoo.com", false, 6.6m, true, false, null, "LESLIE33@YAHOO.COM", "ANTONETTE74", null, "(622) 215-6405 x06285", false, "b003a896-65c8-4c79-88f8-50c517b211fa", 3, false, "Antonette74" },
                    { "59", 0, 26, "8aee86e4-5ed2-4e62-b60b-9b89b5eb1d82", "ApplicationUser", "Nicolas59@gmail.com", false, 8.8m, true, false, null, "NICOLAS59@GMAIL.COM", "GEOVANNY.KLING", null, "1-313-642-5187 x3017", false, "c01be768-d3c0-4d4a-bd42-b650539af18a", 4, false, "Geovanny.Kling" },
                    { "6", 0, 57, "8f589f12-3c18-4394-944f-0733adfd2765", "ApplicationUser", "Efrain_Leuschke@hotmail.com", false, 9.5m, true, false, null, "EFRAIN_LEUSCHKE@HOTMAIL.COM", "KASANDRA31", null, "(685) 707-2463", false, "9dea002b-8c8d-4149-a901-5e05cb8e7a1c", 2, false, "Kasandra31" },
                    { "60", 0, 65, "ffe95b97-aa7a-492a-aa1f-6c18f16dc449", "ApplicationUser", "Thora.Pacocha60@hotmail.com", false, 0.9m, false, false, null, "THORA.PACOCHA60@HOTMAIL.COM", "TERRANCE58", null, "422.685.6531", false, "f4208485-171e-4e3a-9a47-3bd0a6837b0c", 4, false, "Terrance58" },
                    { "61", 0, 49, "5f031479-63f5-4876-825a-ae1b4bf7a0ac", "ApplicationUser", "Cicero57@gmail.com", false, 6.3m, false, false, null, "CICERO57@GMAIL.COM", "DEDRIC19", null, "352-765-2092 x496", false, "e728ba04-0037-46bf-a527-2afea4080885", 3, false, "Dedric19" },
                    { "62", 0, 40, "e79de8a2-2e42-48c8-b51a-6d6e1bc44ffa", "ApplicationUser", "Tyrell_Crona@gmail.com", false, 6.8m, true, false, null, "TYRELL_CRONA@GMAIL.COM", "REAGAN.PROSACCO89", null, "952.801.4844 x41522", false, "dd0472da-f888-46fb-b2bb-ce04ce5dfa0a", 2, false, "Reagan.Prosacco89" },
                    { "63", 0, 54, "68fad466-7c92-4ad1-9c71-5219bd25f878", "ApplicationUser", "Benedict_Hane@gmail.com", false, 8.5m, false, false, null, "BENEDICT_HANE@GMAIL.COM", "CORRINE13", null, "515-428-9527 x0437", false, "1da83086-afd3-43b1-ae4a-71bd0b0116d2", 3, false, "Corrine13" },
                    { "64", 0, 31, "35b494bc-06c6-4b62-a45c-4aa203a37be2", "ApplicationUser", "Freeman_Rempel0@yahoo.com", false, 4.0m, true, false, null, "FREEMAN_REMPEL0@YAHOO.COM", "ALEXA81", null, "(591) 879-7995 x9026", false, "5070db6c-3f02-49ca-a90f-dbc6be51767d", 2, false, "Alexa81" },
                    { "65", 0, 28, "71206f62-67dc-483b-8c3f-7c5dd067ecbf", "ApplicationUser", "Abraham.Goldner@gmail.com", false, 9.7m, true, false, null, "ABRAHAM.GOLDNER@GMAIL.COM", "TARA.ROWE91", null, "1-822-959-8124 x81462", false, "97dec9c4-1882-49ec-8eff-e000010df02c", 3, false, "Tara.Rowe91" },
                    { "66", 0, 29, "129f882b-2ec2-4ce5-9fac-243daabf38e6", "ApplicationUser", "Miles62@yahoo.com", false, 7.8m, false, false, null, "MILES62@YAHOO.COM", "BARBARA32", null, "612.570.7048 x237", false, "2494c02b-7d63-4059-86dd-7a9025f445ed", 2, false, "Barbara32" },
                    { "67", 0, 54, "c7ee33e5-5b62-45d1-b343-55df81c9578e", "ApplicationUser", "Colt_Greenfelder@gmail.com", false, 4.9m, false, false, null, "COLT_GREENFELDER@GMAIL.COM", "SABRYNA27", null, "809-667-5062 x28812", false, "ae777be3-b466-42c3-8a39-1ee3e64a4ecb", 2, false, "Sabryna27" },
                    { "68", 0, 73, "51e60238-fbc4-47ea-8686-67d4dff2fdc9", "ApplicationUser", "Irwin_Flatley19@yahoo.com", false, 0.8m, true, false, null, "IRWIN_FLATLEY19@YAHOO.COM", "CHRISTIAN.HALEY", null, "(749) 964-3871", false, "6651a6fe-181e-4f41-844d-3f2b516a039c", 4, false, "Christian.Haley" },
                    { "69", 0, 13, "2662da2b-db67-4ee9-8e4c-01fae19da471", "ApplicationUser", "Jeremie_Runte58@yahoo.com", false, 3.7m, false, false, null, "JEREMIE_RUNTE58@YAHOO.COM", "BETH_CORKERY53", null, "283.500.8076 x800", false, "522ad4a1-2b09-486a-a049-0159057203ec", 1, false, "Beth_Corkery53" },
                    { "7", 0, 53, "1ccfe9db-2de0-4a2f-aeaa-eb7f611bba2f", "ApplicationUser", "Zoey_Wisoky@yahoo.com", false, 0.8m, true, false, null, "ZOEY_WISOKY@YAHOO.COM", "JOANIE_WEHNER", null, "(391) 601-1125 x63031", false, "9078fc99-95cc-4a39-9ac5-01d211bcecec", 2, false, "Joanie_Wehner" },
                    { "70", 0, 58, "3b7ffcbc-eba5-4a21-9602-deec12c1e975", "ApplicationUser", "Napoleon_Murazik37@yahoo.com", false, 3.8m, true, false, null, "NAPOLEON_MURAZIK37@YAHOO.COM", "DRAKE.WINTHEISER", null, "1-990-856-5003", false, "00ce235c-6066-42fb-9636-406e799e10bd", 4, false, "Drake.Wintheiser" },
                    { "71", 0, 49, "7239e47b-e8b0-464a-a7d1-a964d771a0a6", "ApplicationUser", "Emely.Labadie@gmail.com", false, 2.1m, true, false, null, "EMELY.LABADIE@GMAIL.COM", "DEJON.DICKENS", null, "753.970.4869 x0068", false, "848049f3-0346-4433-9fa1-8f6e1e040970", 3, false, "Dejon.Dickens" },
                    { "72", 0, 23, "48882bcd-f326-4a7d-9163-88d2f552f3c1", "ApplicationUser", "Ernie_Abbott@yahoo.com", false, 5.5m, false, false, null, "ERNIE_ABBOTT@YAHOO.COM", "OLLIE.SMITHAM70", null, "355-528-9058", false, "6707a381-26e8-46b0-a5b1-a3b761a959a9", 3, false, "Ollie.Smitham70" },
                    { "73", 0, 53, "05311cc1-ab65-4cc1-b05e-f041175cac7e", "ApplicationUser", "Ardith16@gmail.com", false, 4.2m, true, false, null, "ARDITH16@GMAIL.COM", "NORBERTO23", null, "(806) 594-7964", false, "9b1a8f29-34a6-44cf-afd1-8683612ed534", 4, false, "Norberto23" },
                    { "74", 0, 26, "10066bdf-fbaa-4055-b9bc-0b1b9be0356c", "ApplicationUser", "Talia18@hotmail.com", false, 1.1m, true, false, null, "TALIA18@HOTMAIL.COM", "ISMAEL_KEEBLER", null, "(634) 601-4759 x8509", false, "a5122122-3d23-4a57-89a7-adc5606cc3ff", 3, false, "Ismael_Keebler" },
                    { "75", 0, 51, "a7abcde1-7c7b-4f66-bc3d-e48e6775cec3", "ApplicationUser", "Jaren44@hotmail.com", false, 5.5m, false, false, null, "JAREN44@HOTMAIL.COM", "REX43", null, "745.509.4918 x0044", false, "62c9336b-95f5-45ed-96fc-334a80ce4cf2", 2, false, "Rex43" },
                    { "76", 0, 78, "2ed7733e-5670-4b04-ba72-4f5739c4ef37", "ApplicationUser", "Ervin.Kemmer99@gmail.com", false, 7.1m, true, false, null, "ERVIN.KEMMER99@GMAIL.COM", "JEFFEREY_VOLKMAN", null, "901-705-1825 x47127", false, "2f3145c1-a0d5-426b-a404-3f5f408daa84", 4, false, "Jefferey_Volkman" },
                    { "77", 0, 51, "a8c53c02-aba6-4eb2-80d4-f41a174524f6", "ApplicationUser", "Arely.Rice45@hotmail.com", false, 0.6m, false, false, null, "ARELY.RICE45@HOTMAIL.COM", "EMMA_LARKIN", null, "1-478-208-3960", false, "2b5ac022-344f-43b3-8401-b4d843ce4d19", 3, false, "Emma_Larkin" },
                    { "78", 0, 16, "bf753e57-d408-4dcf-aaba-1af0b8e3c0f0", "ApplicationUser", "Sage_Schuppe9@gmail.com", false, 6.0m, false, false, null, "SAGE_SCHUPPE9@GMAIL.COM", "ARIANE_FRITSCH", null, "1-221-785-5394 x7610", false, "0777586d-1c1c-40fe-a071-a51d8b48729c", 1, false, "Ariane_Fritsch" },
                    { "79", 0, 59, "cf9f7128-a214-40fb-a97a-4f4b806b921f", "ApplicationUser", "Angus.Medhurst@hotmail.com", false, 0.4m, false, false, null, "ANGUS.MEDHURST@HOTMAIL.COM", "JEROD21", null, "(856) 616-5913 x453", false, "d3883b62-4701-40df-b6fd-50c82717bc88", 4, false, "Jerod21" },
                    { "8", 0, 29, "6290ad1e-021f-43c5-a982-ab67349ba1ae", "ApplicationUser", "Catherine_Davis38@yahoo.com", false, 5.0m, true, false, null, "CATHERINE_DAVIS38@YAHOO.COM", "DELLA_GLEICHNER", null, "910-266-2985", false, "d2e7ef3f-f5a8-4723-ba5f-1f9172c033c9", 3, false, "Della_Gleichner" },
                    { "80", 0, 68, "2b8c4d46-4b39-4523-bc87-9d8a586beda0", "ApplicationUser", "Madisen_Bogisich@gmail.com", false, 9.5m, false, false, null, "MADISEN_BOGISICH@GMAIL.COM", "DARBY_WIEGAND", null, "910-533-1806 x923", false, "ca1357b5-307d-4684-aa1d-2eef8c655fcb", 2, false, "Darby_Wiegand" },
                    { "81", 0, 34, "1bbf463c-90a0-4785-91a0-8e80d00aba58", "ApplicationUser", "Adell_Yundt@gmail.com", false, 6.1m, false, false, null, "ADELL_YUNDT@GMAIL.COM", "SKYE.LEHNER", null, "634-711-4571 x6345", false, "d8fba0f6-bd0d-42fa-ad77-54226488a9e5", 2, false, "Skye.Lehner" },
                    { "82", 0, 35, "ea8ae23c-a824-4c53-87be-162833e52a01", "ApplicationUser", "Myrtle.Stiedemann32@yahoo.com", false, 3.0m, true, false, null, "MYRTLE.STIEDEMANN32@YAHOO.COM", "CECELIA.RITCHIE74", null, "550.825.9212 x1713", false, "939b3949-2fc0-4ffa-b5c6-84b0e6bb4be8", 4, false, "Cecelia.Ritchie74" },
                    { "83", 0, 51, "94090f23-6241-4a6f-93b9-4ebca0a8a9b2", "ApplicationUser", "Joy_Sauer80@yahoo.com", false, 9.9m, true, false, null, "JOY_SAUER80@YAHOO.COM", "OLGA_TURNER42", null, "755.407.4819", false, "5ab82eb3-df68-4547-9e9d-6d13566a3d76", 2, false, "Olga_Turner42" },
                    { "84", 0, 79, "bbd60d74-f237-4638-a879-28e6396bcb49", "ApplicationUser", "Mikel94@yahoo.com", false, 1.9m, false, false, null, "MIKEL94@YAHOO.COM", "SAMIR.ULLRICH94", null, "976-948-3752", false, "fcdf190a-7c10-479b-9137-60584e7ba432", 2, false, "Samir.Ullrich94" },
                    { "85", 0, 55, "286c1bf6-2a0e-4de3-95a1-da00f25982bf", "ApplicationUser", "Nola96@hotmail.com", false, 6.1m, false, false, null, "NOLA96@HOTMAIL.COM", "CESAR.TURCOTTE89", null, "366-717-1565", false, "f91665e7-e2fb-4950-ac11-b67676330891", 3, false, "Cesar.Turcotte89" },
                    { "86", 0, 69, "241847b2-fb57-4cd5-bd61-8736727f8ab7", "ApplicationUser", "Deven_Wolf@gmail.com", false, 5.5m, false, false, null, "DEVEN_WOLF@GMAIL.COM", "JAYLIN.ANDERSON", null, "1-986-537-5853", false, "9ac43c76-26de-4026-a67d-89fdc496ea7f", 4, false, "Jaylin.Anderson" },
                    { "87", 0, 20, "25e9fcc9-a0cc-4369-a4d1-dbcea916fc40", "ApplicationUser", "Noe_Wolff22@gmail.com", false, 3.4m, true, false, null, "NOE_WOLFF22@GMAIL.COM", "LINDSEY_JERDE98", null, "1-957-693-6195", false, "5b0797f9-0c5f-4ec7-87d1-4b9bb3919822", 3, false, "Lindsey_Jerde98" },
                    { "88", 0, 24, "08842e81-f32b-406d-a90d-59f636754d56", "ApplicationUser", "Dasia56@gmail.com", false, 4.4m, true, false, null, "DASIA56@GMAIL.COM", "LOIS.CORMIER", null, "524.293.6551", false, "3ad0386a-a784-485d-9a86-bd69957ab92c", 2, false, "Lois.Cormier" },
                    { "89", 0, 50, "f3e69b50-7244-40ed-b60d-383ceedf4e81", "ApplicationUser", "Celestine.Schinner@hotmail.com", false, 6.9m, true, false, null, "CELESTINE.SCHINNER@HOTMAIL.COM", "RANDY13", null, "(481) 246-4273", false, "1cdcad17-0c44-4cf5-96a0-ced1b94cc22e", 2, false, "Randy13" },
                    { "9", 0, 46, "36dc9814-884e-4db6-a078-144a3e1b55ac", "ApplicationUser", "Ethel32@hotmail.com", false, 4.9m, false, false, null, "ETHEL32@HOTMAIL.COM", "ANNE_REYNOLDS50", null, "980.311.0004", false, "70ea38b7-4b15-417e-ad65-eb43fc22c91b", 2, false, "Anne_Reynolds50" },
                    { "90", 0, 20, "65305c02-96d2-4109-9c8e-62effbb4e0d0", "ApplicationUser", "Pete.Gibson@gmail.com", false, 4.0m, false, false, null, "PETE.GIBSON@GMAIL.COM", "SALLIE_GOTTLIEB", null, "(891) 278-8874", false, "b94c7512-44c1-47f2-b8f4-84273578e855", 4, false, "Sallie_Gottlieb" },
                    { "91", 0, 38, "e4b2a015-b348-487b-952d-7ce6c96061e4", "ApplicationUser", "Carolina_Cruickshank@hotmail.com", false, 8.2m, false, false, null, "CAROLINA_CRUICKSHANK@HOTMAIL.COM", "GABE_OBERBRUNNER", null, "1-957-475-0776 x8754", false, "9e776b3f-11a5-4884-9590-47aea2423e10", 2, false, "Gabe_Oberbrunner" },
                    { "92", 0, 54, "e6efab7f-53ad-4b09-8461-4fda5665cefd", "ApplicationUser", "Monte.Hermann10@yahoo.com", false, 1.2m, true, false, null, "MONTE.HERMANN10@YAHOO.COM", "DANYKA.JAKUBOWSKI", null, "904-531-6229 x7923", false, "70935585-71a7-4822-9190-7075d6ea1e89", 3, false, "Danyka.Jakubowski" },
                    { "93", 0, 55, "2381ed02-47ee-4b66-af3d-eac45d06760c", "ApplicationUser", "Queenie_Johnson49@yahoo.com", false, 7.3m, false, false, null, "QUEENIE_JOHNSON49@YAHOO.COM", "ELTA.KOHLER3", null, "(880) 840-5688 x8382", false, "05a2fa72-76da-40ca-9150-0a3217e717d7", 4, false, "Elta.Kohler3" },
                    { "94", 0, 32, "51bdbf9a-7d80-4ceb-ae74-e9fb9ac4e2e8", "ApplicationUser", "America.Lesch70@hotmail.com", false, 2.0m, false, false, null, "AMERICA.LESCH70@HOTMAIL.COM", "TREVER_GOYETTE", null, "1-752-890-4850", false, "768d7f3c-9a87-4e5d-bd95-ec5e5a5dd0f8", 2, false, "Trever_Goyette" },
                    { "95", 0, 31, "823f9c41-9fa9-4ef2-bb09-97e22c00ca92", "ApplicationUser", "Shanelle.Kohler94@yahoo.com", false, 3.3m, false, false, null, "SHANELLE.KOHLER94@YAHOO.COM", "KELLEY30", null, "1-585-504-1721 x572", false, "2f799712-3ebc-40c7-a08f-38d4d9dd1520", 4, false, "Kelley30" },
                    { "96", 0, 57, "94989f0a-be2a-467f-ba1e-e8b2cfb901bd", "ApplicationUser", "Elroy.Rohan@gmail.com", false, 8.5m, true, false, null, "ELROY.ROHAN@GMAIL.COM", "EFRAIN.DOOLEY73", null, "968.335.5898", false, "7531ee2f-59da-4e8d-b395-74409f969152", 4, false, "Efrain.Dooley73" },
                    { "97", 0, 60, "87570d3e-021d-4579-b021-17fc66a28226", "ApplicationUser", "Unique_Prohaska77@gmail.com", false, 0.0m, true, false, null, "UNIQUE_PROHASKA77@GMAIL.COM", "JAMMIE_NOLAN13", null, "936.712.8857 x80387", false, "100a96a7-a818-4a8c-b14d-93ad34ddef8c", 3, false, "Jammie_Nolan13" },
                    { "98", 0, 38, "ae4fad4d-fda5-4aa3-bb77-1d54c0c56da7", "ApplicationUser", "Paige.Maggio53@hotmail.com", false, 5.1m, true, false, null, "PAIGE.MAGGIO53@HOTMAIL.COM", "DAYTON_MANN", null, "453.562.3474 x91459", false, "17830f34-fc3b-471c-ba72-11d4d67c090e", 3, false, "Dayton_Mann" },
                    { "99", 0, 70, "acfe17f0-b36b-4057-890d-db773b6fd272", "ApplicationUser", "Kyler_Cartwright@hotmail.com", false, 0.8m, true, false, null, "KYLER_CARTWRIGHT@HOTMAIL.COM", "ADITYA.OKON28", null, "488-293-8573 x7166", false, "05874863-77d6-49df-a076-7a808fdb7771", 2, false, "Aditya.OKon28" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 17, 2, "The Football Is Good For Training And Recreational Purposes", 4, "Handmade Frozen Pizza", null, 2012 },
                    { 2, 19, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Intelligent Frozen Computer", null, 2000 },
                    { 3, 8, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Ergonomic Rubber Pizza", null, 2005 },
                    { 4, 4, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Gorgeous Metal Ball", null, 2016 },
                    { 5, 11, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Refined Wooden Shirt", null, 2018 },
                    { 6, 18, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7, "Handcrafted Soft Hat", null, 2020 },
                    { 7, 9, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, "Rustic Cotton Chips", null, 2018 },
                    { 8, 6, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Ergonomic Granite Chips", null, 2001 },
                    { 9, 2, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 7, "Handmade Granite Fish", null, 2001 },
                    { 10, 20, 5, "The Football Is Good For Training And Recreational Purposes", 6, "Gorgeous Fresh Shirt", null, 2011 },
                    { 11, 12, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 7, "Licensed Frozen Salad", null, 2010 },
                    { 12, 16, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Fantastic Rubber Shirt", null, 2020 },
                    { 13, 20, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Sleek Metal Bike", null, 2015 },
                    { 14, 13, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Handmade Granite Pants", null, 2017 },
                    { 15, 5, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Fantastic Soft Keyboard", null, 2004 },
                    { 16, 3, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Intelligent Steel Chair", null, 2013 },
                    { 17, 6, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10, "Practical Fresh Tuna", null, 2023 },
                    { 18, 3, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Unbranded Cotton Towels", null, 2020 },
                    { 19, 16, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Small Fresh Fish", null, 2009 },
                    { 20, 12, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8, "Generic Concrete Shirt", null, 2001 },
                    { 21, 1, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 1, "Practical Soft Chair", null, 2012 },
                    { 22, 6, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Gorgeous Granite Bike", null, 2017 },
                    { 23, 11, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 10, "Intelligent Granite Computer", null, 2010 },
                    { 24, 12, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, "Handmade Metal Chicken", null, 2003 },
                    { 25, 10, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 10, "Rustic Steel Keyboard", null, 2007 },
                    { 26, 4, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8, "Generic Steel Fish", null, 2002 },
                    { 27, 4, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Rustic Steel Keyboard", null, 2014 },
                    { 28, 11, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, "Tasty Metal Table", null, 2022 },
                    { 29, 17, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Generic Frozen Chips", null, 2011 },
                    { 30, 9, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Handmade Cotton Bike", null, 2009 },
                    { 31, 4, 4, "The Football Is Good For Training And Recreational Purposes", 2, "Ergonomic Concrete Table", null, 2021 },
                    { 32, 7, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Practical Rubber Keyboard", null, 2012 },
                    { 33, 17, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Gorgeous Metal Table", null, 2014 },
                    { 34, 7, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Small Plastic Bike", null, 2021 },
                    { 35, 15, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Unbranded Granite Chips", null, 2003 },
                    { 36, 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Awesome Soft Fish", null, 2009 },
                    { 37, 7, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Refined Granite Tuna", null, 2010 },
                    { 38, 1, 5, "The Football Is Good For Training And Recreational Purposes", 10, "Handmade Plastic Pants", null, 2008 },
                    { 39, 11, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Intelligent Granite Keyboard", null, 2014 },
                    { 40, 14, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Gorgeous Fresh Cheese", null, 2016 },
                    { 41, 7, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 9, "Gorgeous Soft Tuna", null, 2007 },
                    { 42, 8, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Handcrafted Frozen Car", null, 2002 },
                    { 43, 18, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Refined Concrete Soap", null, 2020 },
                    { 44, 4, 1, "The Football Is Good For Training And Recreational Purposes", 1, "Handmade Cotton Pizza", null, 2018 },
                    { 45, 13, 4, "The Football Is Good For Training And Recreational Purposes", 6, "Intelligent Plastic Chips", null, 2015 },
                    { 46, 13, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Awesome Soft Car", null, 2000 },
                    { 47, 15, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Incredible Fresh Fish", null, 2019 },
                    { 48, 9, 1, "The Football Is Good For Training And Recreational Purposes", 10, "Awesome Soft Tuna", null, 2007 },
                    { 49, 18, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Rustic Wooden Sausages", null, 2000 },
                    { 50, 11, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Ergonomic Fresh Towels", null, 2015 },
                    { 51, 10, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Handmade Granite Chicken", null, 2004 },
                    { 52, 6, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Unbranded Steel Chair", null, 2016 },
                    { 53, 16, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 4, "Unbranded Concrete Shoes", null, 2017 },
                    { 54, 18, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, "Rustic Metal Chair", null, 2000 },
                    { 55, 8, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8, "Sleek Concrete Sausages", null, 2005 },
                    { 56, 12, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Refined Frozen Keyboard", null, 2018 },
                    { 57, 5, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8, "Handmade Granite Bike", null, 2016 },
                    { 58, 19, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Intelligent Granite Tuna", null, 2000 },
                    { 59, 14, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8, "Handmade Plastic Keyboard", null, 2011 },
                    { 60, 6, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Rustic Steel Gloves", null, 2003 },
                    { 61, 10, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Handmade Steel Ball", null, 2015 },
                    { 62, 12, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, "Generic Frozen Table", null, 2017 },
                    { 63, 9, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Unbranded Wooden Table", null, 2015 },
                    { 64, 8, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Handmade Concrete Table", null, 2016 },
                    { 65, 7, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Awesome Wooden Gloves", null, 2013 },
                    { 66, 9, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 10, "Incredible Rubber Mouse", null, 2007 },
                    { 67, 14, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Rustic Fresh Tuna", null, 2003 },
                    { 68, 1, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Small Rubber Mouse", null, 2001 },
                    { 69, 20, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Incredible Soft Ball", null, 2000 },
                    { 70, 13, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Small Wooden Cheese", null, 2022 },
                    { 71, 9, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Practical Plastic Tuna", null, 2018 },
                    { 72, 20, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Refined Cotton Towels", null, 2000 },
                    { 73, 17, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, "Handcrafted Concrete Hat", null, 2019 },
                    { 74, 19, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9, "Generic Rubber Table", null, 2007 },
                    { 75, 17, 5, "The Football Is Good For Training And Recreational Purposes", 5, "Licensed Soft Hat", null, 2020 },
                    { 76, 7, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Licensed Soft Pizza", null, 2001 },
                    { 77, 2, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Intelligent Steel Chair", null, 2018 },
                    { 78, 19, 5, "The Football Is Good For Training And Recreational Purposes", 0, "Tasty Rubber Table", null, 2007 },
                    { 79, 19, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Fantastic Rubber Computer", null, 2015 },
                    { 80, 8, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 10, "Handcrafted Rubber Gloves", null, 2008 },
                    { 81, 1, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Gorgeous Cotton Shirt", null, 2015 },
                    { 82, 2, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Refined Rubber Shirt", null, 2002 },
                    { 83, 5, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9, "Ergonomic Plastic Fish", null, 2003 },
                    { 84, 16, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Handcrafted Cotton Bike", null, 2020 },
                    { 85, 17, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, "Practical Metal Computer", null, 2006 },
                    { 86, 20, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Handcrafted Steel Towels", null, 2017 },
                    { 87, 8, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Licensed Metal Soap", null, 2005 },
                    { 88, 2, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 9, "Handcrafted Rubber Car", null, 2010 },
                    { 89, 20, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Sleek Plastic Gloves", null, 2003 },
                    { 90, 20, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Rustic Fresh Computer", null, 2015 },
                    { 91, 6, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, "Practical Granite Fish", null, 2010 },
                    { 92, 13, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Intelligent Concrete Towels", null, 2014 },
                    { 93, 11, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Incredible Frozen Chair", null, 2004 },
                    { 94, 1, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, "Intelligent Frozen Pizza", null, 2020 },
                    { 95, 7, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7, "Fantastic Plastic Chips", null, 2023 },
                    { 96, 7, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Awesome Frozen Towels", null, 2006 },
                    { 97, 6, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Handcrafted Soft Shoes", null, 2005 },
                    { 98, 15, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Practical Cotton Towels", null, 2004 },
                    { 99, 20, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 7, "Small Plastic Fish", null, 2022 },
                    { 100, 19, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Intelligent Metal Cheese", null, 2022 }
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
