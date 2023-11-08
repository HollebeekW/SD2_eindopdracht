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
                    { 1, "Florine", "Goyette" },
                    { 2, "Felicia", "D'Amore" },
                    { 3, "Cynthia", "Lowe" },
                    { 4, "Camila", "Brakus" },
                    { 5, "Maud", "Franecki" },
                    { 6, "Vaughn", "Bergstrom" },
                    { 7, "Roxane", "Franecki" },
                    { 8, "Jon", "Ferry" },
                    { 9, "Elsie", "Leffler" },
                    { 10, "Mathias", "Willms" },
                    { 11, "Lydia", "Walsh" },
                    { 12, "Cristopher", "McDermott" },
                    { 13, "Glenna", "Buckridge" },
                    { 14, "Jace", "Robel" },
                    { 15, "Dario", "Walker" },
                    { 16, "Ida", "Deckow" },
                    { 17, "Noemy", "Bednar" },
                    { 18, "Camren", "Weimann" },
                    { 19, "Leland", "Metz" },
                    { 20, "Katelyn", "Von" }
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
                    { "1", 0, 78, "fc8de4dd-dfa0-4269-acb1-1372ac0b3873", "ApplicationUser", "Vernon_Rogahn68@yahoo.com", false, 4.6m, true, false, null, "VERNON_ROGAHN68@YAHOO.COM", "LUCINDA_HILLS37", null, "356.218.9460", false, "e5e82ef6-da69-4f76-8bc2-5218cf94ad9e", 3, false, "Lucinda_Hills37" },
                    { "10", 0, 31, "a298f957-bd4b-43e8-bdb4-0c49f1e6a826", "ApplicationUser", "Margaret.Baumbach33@hotmail.com", false, 7.5m, false, false, null, "MARGARET.BAUMBACH33@HOTMAIL.COM", "SHYANN74", null, "550-722-1604", false, "d68ec224-8b4a-4a43-9b7e-8c447cb4afe0", 2, false, "Shyann74" },
                    { "100", 0, 30, "d6486e3c-902d-4b7f-9faf-0cafc81ae2f2", "ApplicationUser", "Scottie50@gmail.com", false, 8.2m, false, false, null, "SCOTTIE50@GMAIL.COM", "MARJOLAINE.REMPEL", null, "554-833-6483 x34022", false, "0b0ce564-aa3e-4e2c-b369-53ac2944d820", 2, false, "Marjolaine.Rempel" },
                    { "11", 0, 25, "b6574ea8-1848-4582-b3eb-e230dd608c40", "ApplicationUser", "Nash_Doyle29@hotmail.com", false, 6.4m, true, false, null, "NASH_DOYLE29@HOTMAIL.COM", "SEBASTIAN.ROGAHN", null, "(266) 728-3416 x2721", false, "d7042295-91dd-48ff-a2d0-32203f662568", 3, false, "Sebastian.Rogahn" },
                    { "12", 0, 32, "0854b474-0a53-44d9-a21a-77ea0815402d", "ApplicationUser", "Phyllis_Grady38@hotmail.com", false, 0.1m, false, false, null, "PHYLLIS_GRADY38@HOTMAIL.COM", "JADE82", null, "(254) 689-7583 x3138", false, "a0bba1dd-cfd5-4243-a96e-d0b43399d0f8", 4, false, "Jade82" },
                    { "13", 0, 55, "e90f5d23-aa9d-45ef-8555-13e86008b0ed", "ApplicationUser", "Wilmer32@hotmail.com", false, 1.2m, false, false, null, "WILMER32@HOTMAIL.COM", "GROVER.WHITE11", null, "(427) 652-1943 x39596", false, "fed74a68-c5f8-4d08-861d-6740e7c4f816", 3, false, "Grover.White11" },
                    { "14", 0, 70, "7c569b2c-d39e-4ece-9a0d-12d36018209f", "ApplicationUser", "Leilani94@yahoo.com", false, 1.2m, true, false, null, "LEILANI94@YAHOO.COM", "LAURY.HANE", null, "383-867-6138 x480", false, "4885a871-23c6-48b6-8d1d-e8a23e4d1878", 2, false, "Laury.Hane" },
                    { "15", 0, 77, "ab989116-937e-488a-bcbc-14115cadbeb7", "ApplicationUser", "Janick55@gmail.com", false, 1.0m, true, false, null, "JANICK55@GMAIL.COM", "KALEY.VONRUEDEN50", null, "(792) 813-7529 x0399", false, "6202f7e7-82c4-4f93-9c77-918c85fb6498", 3, false, "Kaley.VonRueden50" },
                    { "16", 0, 77, "c4d72bd6-81b6-4ca4-928b-79f1614c4564", "ApplicationUser", "King.Rodriguez@hotmail.com", false, 0.4m, true, false, null, "KING.RODRIGUEZ@HOTMAIL.COM", "ALLISON.PROSACCO89", null, "(859) 955-1049", false, "1e9ef4a3-d69c-4b22-be86-02f1dd9651b4", 4, false, "Allison.Prosacco89" },
                    { "17", 0, 19, "f07e3e25-4eed-40be-ac40-783e610725b1", "ApplicationUser", "Clint48@hotmail.com", false, 2.4m, true, false, null, "CLINT48@HOTMAIL.COM", "ANSEL.HERZOG", null, "290-342-5888", false, "e2887572-8545-417d-9142-3ced9bf24215", 3, false, "Ansel.Herzog" },
                    { "18", 0, 43, "9fdc18ba-41c9-4b4a-b211-be7e18985da6", "ApplicationUser", "Josianne45@gmail.com", false, 2.2m, true, false, null, "JOSIANNE45@GMAIL.COM", "BERT_DECKOW", null, "(598) 400-5117 x7759", false, "655a0260-f34e-46ae-b362-a11cbd679e38", 2, false, "Bert_Deckow" },
                    { "19", 0, 39, "fac24019-6093-4ac6-b7d6-268dfa936fbc", "ApplicationUser", "Jeanne55@hotmail.com", false, 8.0m, true, false, null, "JEANNE55@HOTMAIL.COM", "GEOFFREY79", null, "595-222-8942 x89499", false, "9fa95da7-aa3a-4761-ac90-8cc2db23a958", 3, false, "Geoffrey79" },
                    { "2", 0, 75, "bf0844d1-8ef0-47aa-b734-7627547c67b3", "ApplicationUser", "Noble_Jones34@gmail.com", false, 0.7m, false, false, null, "NOBLE_JONES34@GMAIL.COM", "ANGIE.WILLIAMSON2", null, "276.351.4752 x5426", false, "6a7ac6f4-2aa4-4d68-b796-9dc2dc90bf43", 2, false, "Angie.Williamson2" },
                    { "20", 0, 54, "3a11505a-5a20-4962-a74d-bc7ef43f9250", "ApplicationUser", "Bradley_Williamson@hotmail.com", false, 7.6m, false, false, null, "BRADLEY_WILLIAMSON@HOTMAIL.COM", "JOSIE_COLLIER59", null, "(511) 606-1272 x636", false, "3d6bcabf-7abf-4ad4-9e3f-fdf730769264", 4, false, "Josie_Collier59" },
                    { "21", 0, 66, "ee7378e9-13df-454c-890a-04d342c12a6a", "ApplicationUser", "Claud_Gibson@yahoo.com", false, 7.7m, true, false, null, "CLAUD_GIBSON@YAHOO.COM", "TURNER_POUROS22", null, "282.948.5244 x57149", false, "a9be8240-8548-48c7-8611-66455249222a", 3, false, "Turner_Pouros22" },
                    { "22", 0, 52, "22615b64-56f0-46d8-ad62-76b3b353e3f2", "ApplicationUser", "Samir.Farrell@yahoo.com", false, 8.7m, false, false, null, "SAMIR.FARRELL@YAHOO.COM", "SYDNEY_CASSIN", null, "805.345.6245 x5527", false, "5092d08a-af36-4b9b-8bfe-9c94ac3e5598", 3, false, "Sydney_Cassin" },
                    { "23", 0, 58, "e61212cc-6dae-46f0-8340-cfbf2f699c97", "ApplicationUser", "Dixie_Johnston38@gmail.com", false, 6.0m, true, false, null, "DIXIE_JOHNSTON38@GMAIL.COM", "JAYCEE.DONNELLY", null, "(849) 225-5354 x432", false, "0515ddff-6460-430b-b987-4032cb465551", 2, false, "Jaycee.Donnelly" },
                    { "24", 0, 25, "ef62f464-3197-4374-b24a-9bc393eab0f4", "ApplicationUser", "Pierce_Toy@gmail.com", false, 4.0m, true, false, null, "PIERCE_TOY@GMAIL.COM", "ANABELLE52", null, "1-229-662-8607", false, "063d21fd-ffd4-4044-8a56-08d19cbcdeb2", 3, false, "Anabelle52" },
                    { "25", 0, 27, "8ebc2969-c49e-4ff9-9a0b-95eacfc47943", "ApplicationUser", "Adrienne.Sauer39@hotmail.com", false, 0.4m, false, false, null, "ADRIENNE.SAUER39@HOTMAIL.COM", "LEOPOLDO_HINTZ53", null, "1-713-865-1043 x316", false, "7c96f203-02f5-407b-81b5-1f6c45e93bd1", 4, false, "Leopoldo_Hintz53" },
                    { "26", 0, 49, "f6a074d6-5ab9-4291-8d3e-5612396f4c52", "ApplicationUser", "Darien.Gulgowski63@hotmail.com", false, 3.7m, false, false, null, "DARIEN.GULGOWSKI63@HOTMAIL.COM", "TERRILL_BARTON", null, "1-203-992-6025 x6074", false, "f15af402-16d6-4968-ac2e-4a041cb11b00", 3, false, "Terrill_Barton" },
                    { "27", 0, 22, "41b95e54-2bb5-4da5-8063-e10409cc9394", "ApplicationUser", "Alvis.Shanahan@yahoo.com", false, 4.2m, false, false, null, "ALVIS.SHANAHAN@YAHOO.COM", "LILA_MILLER", null, "1-225-623-9209 x05794", false, "102eaa77-aa8c-4c4d-93d7-0951cfa52895", 3, false, "Lila_Miller" },
                    { "28", 0, 60, "e03d7d72-3ef8-421e-9169-f09d397043f6", "ApplicationUser", "Mattie_Schuppe94@hotmail.com", false, 7.8m, false, false, null, "MATTIE_SCHUPPE94@HOTMAIL.COM", "BRIANA.WEISSNAT", null, "1-845-691-8138 x908", false, "e2427f73-b663-4ba7-b5fd-45c70839faad", 3, false, "Briana.Weissnat" },
                    { "29", 0, 14, "62148ac0-8687-4e02-ae83-9eaba16636de", "ApplicationUser", "William_Toy@gmail.com", false, 9.1m, false, false, null, "WILLIAM_TOY@GMAIL.COM", "MILES_MITCHELL22", null, "770-538-3985", false, "fb5ea93c-122c-40db-9b34-d60498a89ba5", 1, false, "Miles_Mitchell22" },
                    { "3", 0, 16, "4abd5ed2-6c9a-4b93-8668-4c837d121ae3", "ApplicationUser", "Golda.Friesen@gmail.com", false, 3.9m, true, false, null, "GOLDA.FRIESEN@GMAIL.COM", "MATHILDE.CORMIER", null, "1-822-858-4267", false, "f0853501-d9df-4bd9-a5d0-1df041001b37", 1, false, "Mathilde.Cormier" },
                    { "30", 0, 60, "c1074ba7-c14f-4411-bbe0-00571e6dca18", "ApplicationUser", "Reynold.Kessler@hotmail.com", false, 3.7m, true, false, null, "REYNOLD.KESSLER@HOTMAIL.COM", "GEORGIANA_REICHERT", null, "(273) 590-3606", false, "ca5dc560-6671-44ad-9691-801bf85d403f", 2, false, "Georgiana_Reichert" },
                    { "31", 0, 22, "72dab0b5-91db-4bab-a476-0727881e98b7", "ApplicationUser", "Zakary_Mertz@yahoo.com", false, 5.3m, false, false, null, "ZAKARY_MERTZ@YAHOO.COM", "CHARITY_STAMM6", null, "1-689-509-9475", false, "a2745d09-19b2-455b-9c29-8e2c15131fd1", 2, false, "Charity_Stamm6" },
                    { "32", 0, 28, "e12a8f5c-448e-463b-a57f-0c4ce1932301", "ApplicationUser", "Darrin.Gislason37@hotmail.com", false, 0.2m, false, false, null, "DARRIN.GISLASON37@HOTMAIL.COM", "KAITLYN.CARROLL", null, "613-213-5780", false, "aeb78ec0-42b7-4c58-a373-fe99a2ad990d", 2, false, "Kaitlyn.Carroll" },
                    { "33", 0, 80, "883fbb3a-5245-49e0-a43a-88f53297efce", "ApplicationUser", "Augusta38@gmail.com", false, 7.4m, false, false, null, "AUGUSTA38@GMAIL.COM", "HASSAN1", null, "264.929.2557 x74435", false, "f9bfa40b-732b-4641-8ae7-2e986098ceec", 2, false, "Hassan1" },
                    { "34", 0, 45, "144265b6-f6d2-4f88-b3ea-8cc7a9864117", "ApplicationUser", "Toney_Rolfson1@hotmail.com", false, 3.8m, true, false, null, "TONEY_ROLFSON1@HOTMAIL.COM", "BELLA_BAHRINGER91", null, "1-825-596-8066 x371", false, "4c7d81a2-9777-48ba-9b2e-674ba310addf", 2, false, "Bella_Bahringer91" },
                    { "35", 0, 62, "755d1b1c-98a8-472a-bcc1-3de72417ba49", "ApplicationUser", "Kamryn.Borer92@gmail.com", false, 6.3m, true, false, null, "KAMRYN.BORER92@GMAIL.COM", "CEASAR_ROMAGUERA", null, "1-984-782-9140 x33059", false, "52c999f6-4519-45c1-ab2d-380abd61145c", 3, false, "Ceasar_Romaguera" },
                    { "36", 0, 21, "7afd4fae-7fd4-4989-85d0-850e16249ebe", "ApplicationUser", "Jayne95@hotmail.com", false, 4.5m, false, false, null, "JAYNE95@HOTMAIL.COM", "TRAVON.WEHNER", null, "408-660-5292 x6478", false, "a3ce7312-adcc-4015-aaa8-97038f405ae0", 3, false, "Travon.Wehner" },
                    { "37", 0, 61, "a4928fe6-50eb-403e-a262-6ac1b843778f", "ApplicationUser", "Clay6@gmail.com", false, 0.6m, true, false, null, "CLAY6@GMAIL.COM", "JEFFERY73", null, "(494) 367-6920", false, "0b3ecd76-383e-402f-8260-d5b61b1dc5f0", 2, false, "Jeffery73" },
                    { "38", 0, 40, "9eb14456-8473-4532-b126-50f4757a1f49", "ApplicationUser", "Lenore.Sipes@hotmail.com", false, 5.5m, false, false, null, "LENORE.SIPES@HOTMAIL.COM", "VALENTIN67", null, "1-775-395-9936 x16477", false, "6df55351-25e5-415d-99f1-27170931ea28", 4, false, "Valentin67" },
                    { "39", 0, 14, "f0e62dc2-5edd-4877-9671-e25e1604bf90", "ApplicationUser", "Riley57@gmail.com", false, 2.7m, true, false, null, "RILEY57@GMAIL.COM", "GAGE_BUCKRIDGE", null, "1-794-765-4556 x106", false, "ff6c12fe-ab7e-41bc-b38d-afb9a8db9ad2", 1, false, "Gage_Buckridge" },
                    { "4", 0, 29, "43c8cd7b-c51e-4f93-acd8-247c6c700f07", "ApplicationUser", "Birdie_Flatley@gmail.com", false, 4.7m, true, false, null, "BIRDIE_FLATLEY@GMAIL.COM", "ASA.WEST85", null, "1-414-723-3137 x59993", false, "7b0383c1-5280-4c0c-898d-45526e68c915", 4, false, "Asa.West85" },
                    { "40", 0, 73, "b6b1066f-c735-4d1b-9015-8849ec716b94", "ApplicationUser", "Gregg79@gmail.com", false, 4.6m, false, false, null, "GREGG79@GMAIL.COM", "LAWRENCE10", null, "717-313-9303 x855", false, "e75eb457-388d-4023-9797-c179c0d46108", 2, false, "Lawrence10" },
                    { "41", 0, 60, "2695522a-a262-4f50-ac03-8b5081afd58f", "ApplicationUser", "Tom79@hotmail.com", false, 0.5m, true, false, null, "TOM79@HOTMAIL.COM", "CIELO.STAMM", null, "1-607-571-6206 x01014", false, "ac176659-ba34-4d34-b9bd-61f72e722f0a", 3, false, "Cielo.Stamm" },
                    { "42", 0, 54, "b187e11b-3d15-41ab-99d8-ee6284f18429", "ApplicationUser", "Precious.Hartmann@gmail.com", false, 4.6m, true, false, null, "PRECIOUS.HARTMANN@GMAIL.COM", "KRISTIN44", null, "701-419-5411", false, "a7bda0f9-3638-40eb-858a-f732dd973718", 2, false, "Kristin44" },
                    { "43", 0, 50, "05beb777-8a53-4a47-b7cf-00afc2633326", "ApplicationUser", "Ardella92@yahoo.com", false, 5.7m, true, false, null, "ARDELLA92@YAHOO.COM", "MIRACLE.SIPES9", null, "(669) 317-7247 x3121", false, "d0b959c2-c2d6-417d-92fb-01c247587e0d", 4, false, "Miracle.Sipes9" },
                    { "44", 0, 31, "305c72b4-6678-4747-b68e-1fb7b5f2186e", "ApplicationUser", "Tania63@hotmail.com", false, 2.4m, false, false, null, "TANIA63@HOTMAIL.COM", "DEVEN97", null, "(695) 213-7269", false, "113ca6fa-e8e8-40c2-9ed2-83454ea1bc94", 4, false, "Deven97" },
                    { "45", 0, 56, "835219d8-4f44-4a8e-9609-9723a9b0278d", "ApplicationUser", "Coby46@gmail.com", false, 0.4m, true, false, null, "COBY46@GMAIL.COM", "WINSTON.SATTERFIELD", null, "(887) 904-8270 x434", false, "1ef115a0-0824-4ede-8695-de971aedfdad", 2, false, "Winston.Satterfield" },
                    { "46", 0, 53, "5478ca38-c851-4482-ac76-dffc9a532d08", "ApplicationUser", "Nicklaus83@hotmail.com", false, 8.8m, false, false, null, "NICKLAUS83@HOTMAIL.COM", "MITCHELL_WALTER54", null, "(500) 873-3105 x999", false, "a9f645b1-b8af-4f4f-8c16-a731a7671b49", 4, false, "Mitchell_Walter54" },
                    { "47", 0, 72, "c8ca9dcf-9a95-4dc5-8812-0b1e2c4f86cc", "ApplicationUser", "Tevin.Hackett@gmail.com", false, 8.1m, true, false, null, "TEVIN.HACKETT@GMAIL.COM", "SHAWN_LANGWORTH46", null, "637-559-3024", false, "01221125-89d8-4cfe-a46c-9df7c3a4f5ff", 4, false, "Shawn_Langworth46" },
                    { "48", 0, 58, "14e10b73-9997-45f0-b099-bfea236d7dcc", "ApplicationUser", "Wade.Bode8@yahoo.com", false, 5.6m, false, false, null, "WADE.BODE8@YAHOO.COM", "KENDRA78", null, "547.271.6495 x6474", false, "7400f1da-724b-4f6f-aea9-13fc7993243c", 4, false, "Kendra78" },
                    { "49", 0, 70, "c566cdd1-72ae-4543-bfc9-204ae100119d", "ApplicationUser", "Claud88@hotmail.com", false, 2.8m, true, false, null, "CLAUD88@HOTMAIL.COM", "HELMER99", null, "386-842-3012", false, "b8668627-8a69-4de6-a0cc-c2d50be3e8f1", 2, false, "Helmer99" },
                    { "5", 0, 12, "1a3fc1a9-9162-4fb8-a472-ef37337f3cb4", "ApplicationUser", "Vicenta.Reichert79@yahoo.com", false, 4.5m, false, false, null, "VICENTA.REICHERT79@YAHOO.COM", "PETRA29", null, "287-928-3239 x3868", false, "c37e6165-0eab-45dc-a59e-b71674faae16", 1, false, "Petra29" },
                    { "50", 0, 62, "af972da7-181d-40a8-9b7e-ab40f49a2ecc", "ApplicationUser", "Dorcas83@gmail.com", false, 9.9m, true, false, null, "DORCAS83@GMAIL.COM", "TIERRA_ERNSER6", null, "1-851-306-2662", false, "59cffd0e-3725-4be8-8c95-b77dee812f71", 2, false, "Tierra_Ernser6" },
                    { "51", 0, 40, "a78589d8-a638-4662-aeec-58b4854bf0db", "ApplicationUser", "Elisabeth_Hand6@yahoo.com", false, 4.7m, false, false, null, "ELISABETH_HAND6@YAHOO.COM", "DEANGELO_CARTER27", null, "671.223.9505 x17147", false, "00c9bdd5-88da-4c44-9a97-190e5babca0a", 4, false, "Deangelo_Carter27" },
                    { "52", 0, 55, "fef8e7df-e0f0-4d63-8e77-1f8a42564d3f", "ApplicationUser", "Ericka_Daniel@hotmail.com", false, 9.9m, false, false, null, "ERICKA_DANIEL@HOTMAIL.COM", "ALFREDO89", null, "411.510.5666", false, "44be8f5d-db1f-46a3-8cec-a0f417312546", 2, false, "Alfredo89" },
                    { "53", 0, 30, "336206e8-b67c-459a-bd89-bf2eefde91d7", "ApplicationUser", "Madeline.Keeling53@yahoo.com", false, 7.7m, true, false, null, "MADELINE.KEELING53@YAHOO.COM", "RETHA97", null, "783-454-1955", false, "841d6996-86c3-4133-b89b-fe0fcce66c6b", 3, false, "Retha97" },
                    { "54", 0, 22, "1a0bc7d1-268d-490c-a327-8845faac7b6c", "ApplicationUser", "Jannie5@hotmail.com", false, 7.3m, false, false, null, "JANNIE5@HOTMAIL.COM", "TYREE.BERGNAUM49", null, "1-935-262-5409 x553", false, "8eb5666f-514a-4d60-b64d-fdcb38ddc396", 2, false, "Tyree.Bergnaum49" },
                    { "55", 0, 65, "44fb85ae-f79e-49cf-a6f2-da17507eb932", "ApplicationUser", "Maximo33@hotmail.com", false, 2.1m, true, false, null, "MAXIMO33@HOTMAIL.COM", "ALANA87", null, "1-341-368-0032", false, "2f9e74f4-2e72-4f64-a400-014c6bdf1638", 3, false, "Alana87" },
                    { "56", 0, 69, "7fd52978-490b-45d6-bc65-b7cc9a337df5", "ApplicationUser", "Grayson.Schaefer80@yahoo.com", false, 9.3m, false, false, null, "GRAYSON.SCHAEFER80@YAHOO.COM", "JANNIE.DONNELLY", null, "1-264-731-7370", false, "cd4ffb9f-40b0-4eb0-ae0c-e833dd8e8740", 2, false, "Jannie.Donnelly" },
                    { "57", 0, 73, "6b6e63e8-5d22-4b68-9db6-694bdf622504", "ApplicationUser", "Raleigh_Erdman@gmail.com", false, 6.7m, false, false, null, "RALEIGH_ERDMAN@GMAIL.COM", "BRYCE_LITTLE54", null, "665.488.0413", false, "e5f2509e-a594-4dba-b8da-aec68cc193de", 2, false, "Bryce_Little54" },
                    { "58", 0, 37, "c4ca4ea8-4ba0-46e9-b4ee-3a2fac73bd93", "ApplicationUser", "Oma.Morar@hotmail.com", false, 2.1m, false, false, null, "OMA.MORAR@HOTMAIL.COM", "SAM.HICKLE48", null, "(219) 839-0461", false, "8fb759a9-de78-46b0-a52c-9fcb05da85f6", 2, false, "Sam.Hickle48" },
                    { "59", 0, 51, "f516b554-d614-4933-9392-164a88ccca94", "ApplicationUser", "Grant69@hotmail.com", false, 8.5m, true, false, null, "GRANT69@HOTMAIL.COM", "OSVALDO.BOGISICH", null, "495.769.1124 x6901", false, "b73befae-e8d4-415f-8668-b8627c6c6f62", 2, false, "Osvaldo.Bogisich" },
                    { "6", 0, 60, "f74e41a3-8844-4333-ae1e-c3762af79c0b", "ApplicationUser", "Magnolia_Torp95@hotmail.com", false, 0.1m, true, false, null, "MAGNOLIA_TORP95@HOTMAIL.COM", "DANYKA_RAU27", null, "441.970.2448 x6753", false, "bac674d5-91c3-426e-98e0-39e05ce9593a", 4, false, "Danyka_Rau27" },
                    { "60", 0, 21, "6dbe2135-c8e7-40e9-b371-697b00b79086", "ApplicationUser", "Eloy_Tremblay@hotmail.com", false, 1.7m, false, false, null, "ELOY_TREMBLAY@HOTMAIL.COM", "ADOLPH.CASSIN", null, "1-708-717-4492", false, "2d03cf52-5cda-4b5c-853a-97d5c4902f99", 3, false, "Adolph.Cassin" },
                    { "61", 0, 44, "ac9e611d-cad8-4005-9753-dde79882103e", "ApplicationUser", "Chasity.Gaylord@hotmail.com", false, 6.0m, false, false, null, "CHASITY.GAYLORD@HOTMAIL.COM", "JACKIE95", null, "(679) 523-3309", false, "3a0ee5a1-91d2-40aa-bbf1-bd35f376be4d", 3, false, "Jackie95" },
                    { "62", 0, 36, "41349284-bd14-44f6-9797-e1227ece53ff", "ApplicationUser", "Jazmin.Bartoletti@yahoo.com", false, 3.6m, false, false, null, "JAZMIN.BARTOLETTI@YAHOO.COM", "ROSAMOND.BREKKE", null, "406.376.6401 x349", false, "94024d20-939c-4f94-9a83-bbc9d47b2823", 4, false, "Rosamond.Brekke" },
                    { "63", 0, 44, "ea43d57b-396c-47d9-8481-647b15023113", "ApplicationUser", "Shirley50@gmail.com", false, 5.6m, false, false, null, "SHIRLEY50@GMAIL.COM", "KORY.CORMIER", null, "1-233-377-7784 x212", false, "4e1e43e5-dba1-4791-810a-455e0c8b91d1", 3, false, "Kory.Cormier" },
                    { "64", 0, 34, "e299dabb-e7c9-42cf-afd0-957fd6e1e53e", "ApplicationUser", "Adriel_Gusikowski70@yahoo.com", false, 0.7m, false, false, null, "ADRIEL_GUSIKOWSKI70@YAHOO.COM", "BRENT74", null, "686-987-4858", false, "8a5c3f51-2a85-4d09-924a-c0397af2446a", 2, false, "Brent74" },
                    { "65", 0, 66, "12146cfb-6ec3-4fe4-8ca9-2430129d121c", "ApplicationUser", "Carmelo_Tillman@gmail.com", false, 5.8m, true, false, null, "CARMELO_TILLMAN@GMAIL.COM", "LEONIE_WINDLER49", null, "(297) 217-6516", false, "7134c706-e344-4805-ac76-4caa3b2e557e", 3, false, "Leonie_Windler49" },
                    { "66", 0, 30, "6ff061ac-daa4-4634-8aa9-f92cd3c3f74d", "ApplicationUser", "Ernestine.Hilll@yahoo.com", false, 5.5m, true, false, null, "ERNESTINE.HILLL@YAHOO.COM", "CANDICE_KUHN", null, "433.373.2423 x164", false, "d4942e4d-579e-4450-9bbe-5bce8f3c26ba", 3, false, "Candice_Kuhn" },
                    { "67", 0, 44, "a6988b5c-33ce-40b8-aa4e-c174e123bb43", "ApplicationUser", "Nia.McLaughlin@hotmail.com", false, 1.3m, false, false, null, "NIA.MCLAUGHLIN@HOTMAIL.COM", "RACHEL_MRAZ", null, "(306) 430-9067 x243", false, "cef47a0f-a43a-4802-a7a5-ec3c3d5a6fd1", 4, false, "Rachel_Mraz" },
                    { "68", 0, 26, "f6b5eef8-c88a-4f5d-bd91-c5422e97e995", "ApplicationUser", "Antonina.Prohaska@hotmail.com", false, 2.8m, true, false, null, "ANTONINA.PROHASKA@HOTMAIL.COM", "WILLIS_MARKS", null, "986.717.5676 x84033", false, "8aa699ce-5533-49a1-a7f1-706b8c848619", 4, false, "Willis_Marks" },
                    { "69", 0, 35, "3998cb26-6673-4b4e-938d-521fe0516483", "ApplicationUser", "Wilfrid.Little@gmail.com", false, 9.9m, true, false, null, "WILFRID.LITTLE@GMAIL.COM", "SAIGE_KLOCKO28", null, "698-971-2104 x784", false, "142a7958-fd34-4ef4-99ea-936bf934ea83", 2, false, "Saige_Klocko28" },
                    { "7", 0, 13, "d0598db0-3794-4b23-b56d-4eaa4605c57d", "ApplicationUser", "Milan.Bosco27@yahoo.com", false, 8.7m, false, false, null, "MILAN.BOSCO27@YAHOO.COM", "DAVE_GAYLORD31", null, "(961) 218-3369 x1934", false, "6a1bb5af-68d9-4a5f-8f2f-ad6dfbe27783", 1, false, "Dave_Gaylord31" },
                    { "70", 0, 37, "85f3b07e-e71f-466d-88ba-c924bf9f3567", "ApplicationUser", "Lilyan_Huel71@yahoo.com", false, 9.2m, true, false, null, "LILYAN_HUEL71@YAHOO.COM", "BLAISE21", null, "392.961.7489 x4507", false, "3595d648-e75d-451c-afd4-06c7c7602eef", 4, false, "Blaise21" },
                    { "71", 0, 19, "ee6376f1-816a-49d5-9ad5-5f731056a827", "ApplicationUser", "Aron33@yahoo.com", false, 3.9m, true, false, null, "ARON33@YAHOO.COM", "NICOLETTE_JONES", null, "676-819-7541 x1934", false, "1481c3d4-3bf0-44b4-982e-8e918b1aa0f9", 2, false, "Nicolette_Jones" },
                    { "72", 0, 59, "bc085742-3d07-4218-8320-11204a096018", "ApplicationUser", "Neal10@hotmail.com", false, 1.3m, true, false, null, "NEAL10@HOTMAIL.COM", "CLOVIS_BEER", null, "1-706-349-9983", false, "f5b9fdb2-7803-4cb5-b72f-4ae24a749198", 2, false, "Clovis_Beer" },
                    { "73", 0, 22, "3baf54a6-6091-4dd4-881e-8e2bfb86495a", "ApplicationUser", "Jazmyn.Emard@yahoo.com", false, 7.1m, true, false, null, "JAZMYN.EMARD@YAHOO.COM", "DAVID11", null, "1-922-472-8501", false, "8f57c60f-ceb4-446a-aa0a-cab1343c581e", 2, false, "David11" },
                    { "74", 0, 43, "8e61b568-d151-412a-8ed7-335869e53c74", "ApplicationUser", "Mateo_Smitham80@hotmail.com", false, 7.2m, true, false, null, "MATEO_SMITHAM80@HOTMAIL.COM", "GERARD_ROLFSON", null, "(786) 385-5731 x0095", false, "58a74147-c286-4b1a-b23b-4360fefd165f", 2, false, "Gerard_Rolfson" },
                    { "75", 0, 58, "0a20e472-859e-4bce-983a-ebc4ca423352", "ApplicationUser", "Eloy_Lang@yahoo.com", false, 8.4m, false, false, null, "ELOY_LANG@YAHOO.COM", "MARQUISE.JASKOLSKI", null, "(311) 898-8755 x527", false, "9d383581-53e8-4da2-ac37-a8f81f6ed6c2", 2, false, "Marquise.Jaskolski" },
                    { "76", 0, 68, "beca3747-8e3e-494d-b128-ba3c7af4e93f", "ApplicationUser", "Pauline39@hotmail.com", false, 0.6m, false, false, null, "PAULINE39@HOTMAIL.COM", "ANIYA6", null, "1-235-718-8238", false, "3066747b-ab42-40b1-ba95-29a7054ced8c", 2, false, "Aniya6" },
                    { "77", 0, 24, "f225ff08-dddd-4cf6-a2ce-1dd5699160e9", "ApplicationUser", "Alexane.Shanahan95@yahoo.com", false, 4.3m, false, false, null, "ALEXANE.SHANAHAN95@YAHOO.COM", "RHODA.BORER", null, "1-349-715-7599", false, "9af54e6b-73d4-4a0e-9cfc-a4d6ca8f4699", 3, false, "Rhoda.Borer" },
                    { "78", 0, 60, "071ea0d1-c3f4-4d07-baa7-1341a4b799dd", "ApplicationUser", "Alba27@yahoo.com", false, 4.4m, true, false, null, "ALBA27@YAHOO.COM", "DOMENICK.EMMERICH", null, "801-587-5743 x03402", false, "6c294ae1-f852-4d40-b95b-2a747f589448", 3, false, "Domenick.Emmerich" },
                    { "79", 0, 51, "1fc147c7-3fd0-453b-be47-abaa28effcfd", "ApplicationUser", "Jacinthe82@gmail.com", false, 3.8m, false, false, null, "JACINTHE82@GMAIL.COM", "GEORGETTE54", null, "1-471-816-0057 x7604", false, "0f814438-1b69-4ba2-901e-569d9fec813b", 3, false, "Georgette54" },
                    { "8", 0, 76, "2d22610d-0cba-43b3-bddc-72b249301c95", "ApplicationUser", "Alison.Schaefer22@yahoo.com", false, 4.9m, true, false, null, "ALISON.SCHAEFER22@YAHOO.COM", "ELDA.BAUCH53", null, "935-895-4277 x03368", false, "087be184-68d3-4bf7-860c-2bd115c58b83", 4, false, "Elda.Bauch53" },
                    { "80", 0, 63, "16d40899-add4-4f02-ab54-7f8f1f399349", "ApplicationUser", "Zora_Connelly45@gmail.com", false, 5.1m, false, false, null, "ZORA_CONNELLY45@GMAIL.COM", "VIRGINIE.FEIL", null, "(251) 933-4013", false, "a358804c-311f-4442-b4f6-cc5033ba5474", 2, false, "Virginie.Feil" },
                    { "81", 0, 65, "4bf10942-86ed-410f-8a62-bc917b7a263c", "ApplicationUser", "Austen98@gmail.com", false, 1.1m, true, false, null, "AUSTEN98@GMAIL.COM", "TELLY.WILKINSON", null, "235.594.3145", false, "309c9504-c8af-4c87-8c54-3c3cb5d94646", 2, false, "Telly.Wilkinson" },
                    { "82", 0, 46, "c4dd1675-7118-4e36-b009-d09d1e2e125f", "ApplicationUser", "Elsie.Becker24@yahoo.com", false, 8.1m, true, false, null, "ELSIE.BECKER24@YAHOO.COM", "LEILA_COLLIER", null, "1-832-812-6413 x6477", false, "f11e4651-3cc1-49f8-8da7-31ff3eeba1c9", 2, false, "Leila_Collier" },
                    { "83", 0, 80, "79bed551-18e6-45be-abc2-5efbab15f344", "ApplicationUser", "Reece_Brakus@hotmail.com", false, 7.1m, true, false, null, "REECE_BRAKUS@HOTMAIL.COM", "MARYSE.GLOVER0", null, "(455) 748-1089 x189", false, "32e60737-0b28-4576-899b-870b10369df6", 3, false, "Maryse.Glover0" },
                    { "84", 0, 51, "8af4e0a2-240b-4150-ae07-08a13c2586e3", "ApplicationUser", "Angelita.MacGyver94@hotmail.com", false, 2.2m, true, false, null, "ANGELITA.MACGYVER94@HOTMAIL.COM", "GILDA_EMMERICH9", null, "680.957.8340", false, "b23e6ce4-fdcf-42be-964b-fce796bdb057", 4, false, "Gilda_Emmerich9" },
                    { "85", 0, 47, "72628d35-466b-4066-a15e-e3809ff5b92e", "ApplicationUser", "Deonte_Schimmel@hotmail.com", false, 0.8m, false, false, null, "DEONTE_SCHIMMEL@HOTMAIL.COM", "GRACE78", null, "1-349-754-3484", false, "63e12e1a-f8dc-428e-805d-a7286f628ef4", 3, false, "Grace78" },
                    { "86", 0, 21, "d44dc595-2c4f-4238-a6bc-6184b3fb5152", "ApplicationUser", "Marcia9@hotmail.com", false, 8.6m, true, false, null, "MARCIA9@HOTMAIL.COM", "ARCH.MAYER", null, "1-236-335-7431", false, "0d376767-f7f8-4831-adf2-78bfec25882e", 4, false, "Arch.Mayer" },
                    { "87", 0, 53, "929129f0-5896-4f28-93a7-ed78accfbe95", "ApplicationUser", "Tristin20@gmail.com", false, 7.8m, true, false, null, "TRISTIN20@GMAIL.COM", "ROSS.RUTHERFORD26", null, "986-988-7385", false, "a561a91c-2220-48b7-a88d-bfb07bb01f0b", 2, false, "Ross.Rutherford26" },
                    { "88", 0, 30, "be148a36-ddaf-4c28-9079-890da903022d", "ApplicationUser", "Brice_Luettgen54@gmail.com", false, 2.0m, false, false, null, "BRICE_LUETTGEN54@GMAIL.COM", "SVEN94", null, "762.256.3918", false, "a2691cab-abc8-4735-88de-c9e37c70ddcc", 4, false, "Sven94" },
                    { "89", 0, 17, "c4f372c3-11f4-4c23-ac6f-40c5cfeab3f3", "ApplicationUser", "Tania_Abbott@hotmail.com", false, 3.8m, true, false, null, "TANIA_ABBOTT@HOTMAIL.COM", "ANNE77", null, "(580) 869-8930 x9295", false, "6c395986-83dd-416e-8b0f-9079637a2342", 1, false, "Anne77" },
                    { "9", 0, 32, "4bd26fc2-119b-494e-a8b7-4c39501ec00b", "ApplicationUser", "Maurine_Jacobs15@hotmail.com", false, 8.6m, true, false, null, "MAURINE_JACOBS15@HOTMAIL.COM", "CHELSEA25", null, "839.288.5194", false, "b2ca07fd-a457-4a08-bf0b-5b47091543cf", 4, false, "Chelsea25" },
                    { "90", 0, 58, "1e98b85c-1c4b-4746-8897-0fe9dfde1635", "ApplicationUser", "Shawna_Kshlerin41@hotmail.com", false, 8.6m, false, false, null, "SHAWNA_KSHLERIN41@HOTMAIL.COM", "LYSANNE_MORAR", null, "(675) 247-6197", false, "c43e61be-fa55-4a13-93de-626eb55ae3f3", 4, false, "Lysanne_Morar" },
                    { "91", 0, 71, "1ce392b1-4c00-4a48-a261-3cfa7385bdea", "ApplicationUser", "Doris86@hotmail.com", false, 0.5m, false, false, null, "DORIS86@HOTMAIL.COM", "LURLINE_HAHN", null, "700.563.8308 x1656", false, "864b28cc-0301-44ff-816d-d98b4d07c616", 3, false, "Lurline_Hahn" },
                    { "92", 0, 59, "84fbe3e0-1542-4a9d-8f4f-c11fcaf5610b", "ApplicationUser", "Vickie_Konopelski@yahoo.com", false, 0.0m, true, false, null, "VICKIE_KONOPELSKI@YAHOO.COM", "CASSIE_PREDOVIC", null, "844.567.4145 x9832", false, "f391a065-87a2-4d18-8e7f-10354dd9ed54", 2, false, "Cassie_Predovic" },
                    { "93", 0, 58, "ae50bfce-3010-4479-a4dc-41b493251030", "ApplicationUser", "Ayana19@gmail.com", false, 7.7m, true, false, null, "AYANA19@GMAIL.COM", "ELIEZER_HESSEL92", null, "964-525-8117 x80713", false, "b1456f38-9692-4ecb-8623-a74e25ffd4dd", 2, false, "Eliezer_Hessel92" },
                    { "94", 0, 15, "6687d1b9-ebc1-4ba6-94c1-321b21d6c426", "ApplicationUser", "Garry_Hermann@gmail.com", false, 4.3m, true, false, null, "GARRY_HERMANN@GMAIL.COM", "ELIEZER2", null, "946-747-1253 x0857", false, "7935050b-0d1b-4d07-9726-4a666de095d5", 1, false, "Eliezer2" },
                    { "95", 0, 39, "55c02cf9-d01f-4cfc-bee3-9243400337c2", "ApplicationUser", "Jacky_Kub68@yahoo.com", false, 8.2m, false, false, null, "JACKY_KUB68@YAHOO.COM", "HASSAN_CARTER", null, "796-626-2540", false, "a3a31439-7f1f-44ae-8d87-b6ec45a4ec60", 3, false, "Hassan_Carter" },
                    { "96", 0, 68, "5cd295a0-ecbf-44af-b58c-81e93db53a90", "ApplicationUser", "Javier_Smith@yahoo.com", false, 8.5m, true, false, null, "JAVIER_SMITH@YAHOO.COM", "CARSON_LUEILWITZ", null, "1-832-377-6375", false, "243c14cf-0a72-4f0e-b1d2-dfc68af9ddcb", 3, false, "Carson_Lueilwitz" },
                    { "97", 0, 46, "113f2ddc-1dfe-47b0-9cbf-cd5bbcbac56b", "ApplicationUser", "Jaquelin21@gmail.com", false, 5.3m, false, false, null, "JAQUELIN21@GMAIL.COM", "SHANIE_WUCKERT", null, "1-330-228-3731", false, "aaf2d177-450e-4d52-879b-e2d129c0e97f", 2, false, "Shanie_Wuckert" },
                    { "98", 0, 69, "0701551c-68d1-4c60-9a9b-1733cab8b772", "ApplicationUser", "Sadye.Stoltenberg95@yahoo.com", false, 6.5m, true, false, null, "SADYE.STOLTENBERG95@YAHOO.COM", "TIFFANY.MOEN49", null, "(710) 252-0209 x2579", false, "5d20f644-153d-4565-9a70-a0e3addd226b", 3, false, "Tiffany.Moen49" },
                    { "99", 0, 22, "26c03748-3428-414c-b627-5a688aab9979", "ApplicationUser", "Adolph20@yahoo.com", false, 7.5m, false, false, null, "ADOLPH20@YAHOO.COM", "GILBERTO.RUNOLFSDOTTIR", null, "1-579-314-5072 x37750", false, "10180f59-2b57-4582-be3a-84f6a7c283bf", 3, false, "Gilberto.Runolfsdottir" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 10, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Incredible Plastic Chips", null, 2015 },
                    { 2, 10, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Generic Steel Sausages", null, 2018 },
                    { 3, 12, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Licensed Wooden Pants", null, 2011 },
                    { 4, 4, 3, "The Football Is Good For Training And Recreational Purposes", 0, "Awesome Wooden Towels", null, 2015 },
                    { 5, 3, 2, "The Football Is Good For Training And Recreational Purposes", 2, "Handmade Cotton Chips", null, 2021 },
                    { 6, 8, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7, "Rustic Concrete Gloves", null, 2017 },
                    { 7, 15, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, "Sleek Steel Pants", null, 2006 },
                    { 8, 18, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Unbranded Cotton Towels", null, 2001 },
                    { 9, 7, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9, "Tasty Granite Table", null, 2015 },
                    { 10, 8, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Handmade Fresh Computer", null, 2013 },
                    { 11, 10, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Rustic Cotton Sausages", null, 2008 },
                    { 12, 9, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Awesome Wooden Chicken", null, 2003 },
                    { 13, 16, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Intelligent Steel Soap", null, 2005 },
                    { 14, 14, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8, "Fantastic Steel Pizza", null, 2010 },
                    { 15, 4, 5, "The Football Is Good For Training And Recreational Purposes", 9, "Unbranded Plastic Car", null, 2001 },
                    { 16, 20, 5, "The Football Is Good For Training And Recreational Purposes", 8, "Unbranded Wooden Chips", null, 2013 },
                    { 17, 13, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8, "Tasty Cotton Shoes", null, 2016 },
                    { 18, 20, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Fantastic Granite Tuna", null, 2007 },
                    { 19, 6, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Refined Steel Fish", null, 2014 },
                    { 20, 18, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Practical Fresh Fish", null, 2005 },
                    { 21, 10, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Generic Plastic Keyboard", null, 2016 },
                    { 22, 9, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Refined Metal Table", null, 2013 },
                    { 23, 3, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Intelligent Wooden Mouse", null, 2015 },
                    { 24, 1, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, "Intelligent Plastic Gloves", null, 2007 },
                    { 25, 16, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Small Fresh Gloves", null, 2015 },
                    { 26, 12, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, "Gorgeous Concrete Salad", null, 2019 },
                    { 27, 11, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Gorgeous Metal Mouse", null, 2018 },
                    { 28, 4, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Sleek Cotton Computer", null, 2003 },
                    { 29, 11, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Intelligent Rubber Shoes", null, 2002 },
                    { 30, 11, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Sleek Soft Towels", null, 2013 },
                    { 31, 1, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Handmade Concrete Soap", null, 2009 },
                    { 32, 8, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, "Practical Soft Towels", null, 2008 },
                    { 33, 3, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Refined Granite Tuna", null, 2012 },
                    { 34, 19, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Incredible Granite Salad", null, 2010 },
                    { 35, 18, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Licensed Cotton Chips", null, 2019 },
                    { 36, 20, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8, "Gorgeous Soft Chair", null, 2003 },
                    { 37, 4, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8, "Small Cotton Fish", null, 2011 },
                    { 38, 15, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Generic Steel Pizza", null, 2000 },
                    { 39, 9, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Unbranded Frozen Chicken", null, 2005 },
                    { 40, 6, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8, "Refined Soft Gloves", null, 2002 },
                    { 41, 19, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Ergonomic Cotton Pants", null, 2021 },
                    { 42, 6, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, "Practical Cotton Ball", null, 2001 },
                    { 43, 14, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 9, "Refined Rubber Soap", null, 2021 },
                    { 44, 3, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Unbranded Granite Pants", null, 2021 },
                    { 45, 17, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Sleek Cotton Car", null, 2007 },
                    { 46, 12, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Generic Plastic Cheese", null, 2022 },
                    { 47, 12, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7, "Handcrafted Steel Pizza", null, 2009 },
                    { 48, 13, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, "Gorgeous Plastic Salad", null, 2022 },
                    { 49, 6, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 8, "Gorgeous Wooden Ball", null, 2019 },
                    { 50, 10, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Intelligent Cotton Mouse", null, 2018 },
                    { 51, 20, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8, "Tasty Rubber Chips", null, 2018 },
                    { 52, 4, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Small Steel Gloves", null, 2023 },
                    { 53, 6, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Handmade Plastic Table", null, 2019 },
                    { 54, 10, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7, "Fantastic Wooden Computer", null, 2010 },
                    { 55, 17, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 10, "Handcrafted Cotton Shoes", null, 2009 },
                    { 56, 9, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 10, "Rustic Rubber Gloves", null, 2002 },
                    { 57, 10, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Generic Fresh Ball", null, 2015 },
                    { 58, 4, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Intelligent Steel Car", null, 2020 },
                    { 59, 19, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10, "Ergonomic Soft Chair", null, 2000 },
                    { 60, 10, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Small Rubber Pizza", null, 2009 },
                    { 61, 14, 4, "The Football Is Good For Training And Recreational Purposes", 4, "Unbranded Metal Computer", null, 2019 },
                    { 62, 20, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, "Ergonomic Rubber Pants", null, 2013 },
                    { 63, 2, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Unbranded Wooden Cheese", null, 2022 },
                    { 64, 7, 2, "The Football Is Good For Training And Recreational Purposes", 1, "Small Fresh Gloves", null, 2008 },
                    { 65, 13, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Gorgeous Granite Chips", null, 2023 },
                    { 66, 20, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Tasty Plastic Pants", null, 2002 },
                    { 67, 2, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Fantastic Rubber Car", null, 2002 },
                    { 68, 14, 3, "The Football Is Good For Training And Recreational Purposes", 1, "Ergonomic Wooden Chips", null, 2012 },
                    { 69, 10, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 9, "Sleek Metal Chips", null, 2016 },
                    { 70, 6, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Generic Concrete Bacon", null, 2002 },
                    { 71, 15, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Fantastic Fresh Shoes", null, 2017 },
                    { 72, 1, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9, "Handcrafted Rubber Sausages", null, 2001 },
                    { 73, 3, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Tasty Frozen Salad", null, 2023 },
                    { 74, 18, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Incredible Rubber Pants", null, 2022 },
                    { 75, 10, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Licensed Steel Bike", null, 2002 },
                    { 76, 19, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 1, "Awesome Fresh Pants", null, 2016 },
                    { 77, 14, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Unbranded Rubber Cheese", null, 2018 },
                    { 78, 15, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 8, "Fantastic Soft Gloves", null, 2018 },
                    { 79, 6, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, "Small Cotton Chips", null, 2016 },
                    { 80, 8, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Rustic Plastic Table", null, 2019 },
                    { 81, 5, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 3, "Rustic Metal Table", null, 2012 },
                    { 82, 18, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Handcrafted Metal Keyboard", null, 2010 },
                    { 83, 18, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 8, "Sleek Metal Soap", null, 2007 },
                    { 84, 7, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Intelligent Frozen Chips", null, 2001 },
                    { 85, 3, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8, "Generic Soft Bike", null, 2008 },
                    { 86, 3, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, "Sleek Metal Keyboard", null, 2017 },
                    { 87, 17, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Awesome Fresh Pants", null, 2022 },
                    { 88, 2, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Generic Steel Pants", null, 2021 },
                    { 89, 14, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, "Awesome Plastic Salad", null, 2010 },
                    { 90, 20, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Sleek Plastic Hat", null, 2017 },
                    { 91, 3, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Fantastic Concrete Soap", null, 2018 },
                    { 92, 12, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Handmade Concrete Car", null, 2017 },
                    { 93, 14, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Sleek Plastic Sausages", null, 2017 },
                    { 94, 14, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Practical Granite Pizza", null, 2015 },
                    { 95, 11, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Rustic Soft Car", null, 2003 },
                    { 96, 4, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Fantastic Soft Cheese", null, 2022 },
                    { 97, 5, 1, "The Football Is Good For Training And Recreational Purposes", 4, "Unbranded Fresh Bike", null, 2006 },
                    { 98, 14, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7, "Small Concrete Fish", null, 2023 },
                    { 99, 20, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Small Fresh Gloves", null, 2023 },
                    { 100, 11, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 0, "Unbranded Soft Mouse", null, 2010 }
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
