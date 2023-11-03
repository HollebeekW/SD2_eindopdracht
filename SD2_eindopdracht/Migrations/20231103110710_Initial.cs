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
                    { 1, "Peggie", "Ward" },
                    { 2, "Jeramie", "Macejkovic" },
                    { 3, "Lucienne", "Pfeffer" },
                    { 4, "Una", "Bartoletti" },
                    { 5, "Mattie", "Mayer" },
                    { 6, "Vidal", "Lakin" },
                    { 7, "Georgiana", "McDermott" },
                    { 8, "Dorian", "Abbott" },
                    { 9, "Emilia", "Green" },
                    { 10, "Maximilian", "Stoltenberg" },
                    { 11, "Nicholas", "Hamill" },
                    { 12, "Angeline", "Marvin" },
                    { 13, "Tamia", "Wolff" },
                    { 14, "Melany", "Schultz" },
                    { 15, "Korbin", "Koelpin" },
                    { 16, "Letitia", "Stroman" },
                    { 17, "Angel", "Huels" },
                    { 18, "Micah", "Howe" },
                    { 19, "Concepcion", "Padberg" },
                    { 20, "Zoey", "Schumm" }
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
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 22, "8348ff75-d0d6-4128-ab0f-413725550dc6", "ApplicationUser", "Ansel.Brekke@yahoo.com", false, false, null, "ANSEL.BREKKE@YAHOO.COM", "SHARON.GREENFELDER72", null, "(436) 985-1691 x15784", false, "81553194-47d2-4be0-aabb-04b8ba4484cc", 2, false, "Sharon.Greenfelder72" },
                    { "10", 0, 19, "98631c34-f7a6-4f3c-9738-e2ca12513a82", "ApplicationUser", "Delphine_Blanda93@gmail.com", false, false, null, "DELPHINE_BLANDA93@GMAIL.COM", "JANICE.OLSON20", null, "(483) 857-0907 x89923", false, "9fe14c07-21c4-4f34-a846-191f4f04bc21", 2, false, "Janice.Olson20" },
                    { "100", 0, 42, "7d7bc83c-904d-4ffd-bd8c-5efbe12ec912", "ApplicationUser", "Orlando_Gulgowski@yahoo.com", false, false, null, "ORLANDO_GULGOWSKI@YAHOO.COM", "BRENDA.EMMERICH70", null, "658-654-6447 x907", false, "e1aae5fd-4191-48d2-9c2e-b9117e9430bf", 3, false, "Brenda.Emmerich70" },
                    { "11", 0, 29, "6bf0fd4e-9e8a-4ff3-b298-6f30239ddeb8", "ApplicationUser", "Bailee.Bode28@gmail.com", false, false, null, "BAILEE.BODE28@GMAIL.COM", "ROSANNA26", null, "261-492-6552 x40337", false, "c51bfb16-e69e-4902-8ec1-c1d979e006d5", 4, false, "Rosanna26" },
                    { "12", 0, 58, "df1cf476-3ef6-4bde-8d59-7590baf9afec", "ApplicationUser", "Margot68@gmail.com", false, false, null, "MARGOT68@GMAIL.COM", "JUNIUS_BORER54", null, "564-769-7640 x6145", false, "8a50c4cc-84e2-40c8-a26f-81068a95473f", 3, false, "Junius_Borer54" },
                    { "13", 0, 27, "1e2a7a6c-bf72-4da3-8ee3-c61b81134711", "ApplicationUser", "Zita.DuBuque@hotmail.com", false, false, null, "ZITA.DUBUQUE@HOTMAIL.COM", "LONZO.TILLMAN66", null, "1-456-427-7545 x47440", false, "fc9c1913-1a37-4731-99f8-1309fdc1b765", 3, false, "Lonzo.Tillman66" },
                    { "14", 0, 66, "7c18d803-a12c-4c8a-8dba-222bd6cdabc1", "ApplicationUser", "Abigayle40@hotmail.com", false, false, null, "ABIGAYLE40@HOTMAIL.COM", "KATHERINE_CONNELLY", null, "564.941.0569 x77542", false, "a1ce59c2-3840-4a56-b39a-46b8459b6553", 3, false, "Katherine_Connelly" },
                    { "15", 0, 23, "f1e5303a-8477-4247-82b5-b339f27d0ce9", "ApplicationUser", "Zelma.Stanton@gmail.com", false, false, null, "ZELMA.STANTON@GMAIL.COM", "DANIELLE.KIEHN", null, "320.590.0787 x1187", false, "57033703-f022-46cd-9055-ff471fc3aaf0", 3, false, "Danielle.Kiehn" },
                    { "16", 0, 53, "9c3fc9c4-41cc-4646-8d0f-e1c21b570bdd", "ApplicationUser", "Roselyn.Rath51@hotmail.com", false, false, null, "ROSELYN.RATH51@HOTMAIL.COM", "ADELLA_POLLICH72", null, "596.216.9973 x35670", false, "342e7752-a138-43b7-82c5-45daccd22112", 4, false, "Adella_Pollich72" },
                    { "17", 0, 20, "dad18b23-57d2-4fb7-b511-4028ebe8376e", "ApplicationUser", "Bessie.Larson63@gmail.com", false, false, null, "BESSIE.LARSON63@GMAIL.COM", "VERNICE86", null, "(573) 828-1025 x35872", false, "9026af9b-78b6-4ebc-b029-bd2bd949641b", 2, false, "Vernice86" },
                    { "18", 0, 77, "056d042c-c2fe-42c4-8884-d84a47df67c4", "ApplicationUser", "Wilbert30@hotmail.com", false, false, null, "WILBERT30@HOTMAIL.COM", "WALLACE.LINDGREN", null, "1-653-674-3605", false, "965b467a-fa0a-4228-841f-4d000d19f940", 4, false, "Wallace.Lindgren" },
                    { "19", 0, 67, "028d1322-99af-43d4-9cef-28181c240b38", "ApplicationUser", "Roman_Blick59@gmail.com", false, false, null, "ROMAN_BLICK59@GMAIL.COM", "CHAUNCEY_BOGISICH77", null, "1-490-919-4453", false, "9874b331-ae5c-4aa2-8fef-32700e41b855", 4, false, "Chauncey_Bogisich77" },
                    { "2", 0, 30, "ab2f894b-4929-4a40-91ee-36419eef97b9", "ApplicationUser", "Clemmie.Gutmann@gmail.com", false, false, null, "CLEMMIE.GUTMANN@GMAIL.COM", "PATRICK3", null, "(260) 402-8731", false, "ded7c86b-ee42-4c00-b9b0-68bdca6b49e2", 2, false, "Patrick3" },
                    { "20", 0, 25, "03b567fb-4ed8-4ac5-9bc2-cd982b6f1b7c", "ApplicationUser", "Rashad_Boyle@hotmail.com", false, false, null, "RASHAD_BOYLE@HOTMAIL.COM", "KEEGAN_LUETTGEN69", null, "(390) 334-6834 x833", false, "997c9dc5-9069-41d4-a0ee-aa4de49126b2", 2, false, "Keegan_Luettgen69" },
                    { "21", 0, 61, "075d5c1c-db75-479d-9006-2a5f0e7c4cee", "ApplicationUser", "Sadie_Harris@yahoo.com", false, false, null, "SADIE_HARRIS@YAHOO.COM", "BORIS.GREENFELDER66", null, "403.682.9656", false, "1f4b6460-04d2-4872-9210-8531cb4dd286", 2, false, "Boris.Greenfelder66" },
                    { "22", 0, 19, "35d7bd08-6368-41da-aa3b-6e75d90773b7", "ApplicationUser", "Valentin2@gmail.com", false, false, null, "VALENTIN2@GMAIL.COM", "VICKIE21", null, "980.678.0952", false, "737c356e-473d-42e7-8332-af22948b4bb5", 4, false, "Vickie21" },
                    { "23", 0, 26, "dac6994f-c2bb-44bb-bee2-8f33bc351e6e", "ApplicationUser", "Otha_Halvorson83@hotmail.com", false, false, null, "OTHA_HALVORSON83@HOTMAIL.COM", "LUCIANO2", null, "260-579-9044", false, "03bec8ca-63fa-433d-a7b5-8aa70b39234e", 3, false, "Luciano2" },
                    { "24", 0, 16, "a4e45ddc-3a61-4be7-85a5-490869a31b75", "ApplicationUser", "Estella36@gmail.com", false, false, null, "ESTELLA36@GMAIL.COM", "FREDY.AUFDERHAR54", null, "(719) 854-3060", false, "9623777c-3313-4826-8f95-2737bd40b234", 1, false, "Fredy.Aufderhar54" },
                    { "25", 0, 80, "8f7dd9ed-a3f9-4400-b508-deb7191b5041", "ApplicationUser", "Marianne46@hotmail.com", false, false, null, "MARIANNE46@HOTMAIL.COM", "ALIVIA_ROHAN74", null, "1-299-778-7221", false, "5743d91b-fede-40d5-be19-c302afbef87c", 4, false, "Alivia_Rohan74" },
                    { "26", 0, 79, "56520492-7bd5-4345-9b83-5648cec9c2c2", "ApplicationUser", "Orrin_Mosciski@hotmail.com", false, false, null, "ORRIN_MOSCISKI@HOTMAIL.COM", "STACEY.MERTZ", null, "610.505.9194", false, "f4bcb625-2927-45ae-b500-df8f064c665f", 2, false, "Stacey.Mertz" },
                    { "27", 0, 23, "1caf90f9-b337-4da8-8009-b9c2e1ff3c3f", "ApplicationUser", "Santino8@gmail.com", false, false, null, "SANTINO8@GMAIL.COM", "ISADORE70", null, "1-905-917-0667", false, "4ea5be75-ad87-44cc-92e6-25e4c0b9b603", 4, false, "Isadore70" },
                    { "28", 0, 49, "0a5284c2-8aaf-4c18-a076-00336cac391f", "ApplicationUser", "Francis44@yahoo.com", false, false, null, "FRANCIS44@YAHOO.COM", "KRISTOPHER82", null, "1-685-356-6716", false, "61a34f34-00b0-4d1a-81f6-882b6e0ae050", 3, false, "Kristopher82" },
                    { "29", 0, 30, "14a216aa-975c-4f08-92a9-86fbd3eb7104", "ApplicationUser", "Carlo_OConner68@yahoo.com", false, false, null, "CARLO_OCONNER68@YAHOO.COM", "BERNADETTE_KIHN7", null, "606.646.2222", false, "603bf82d-4176-4dd3-9bc9-13b6f343945a", 4, false, "Bernadette_Kihn7" },
                    { "3", 0, 49, "6cf0ec21-9655-43ce-a3c1-a3cdef1cfed2", "ApplicationUser", "Tamia.DAmore95@yahoo.com", false, false, null, "TAMIA.DAMORE95@YAHOO.COM", "LEXIE.OBERBRUNNER", null, "726.265.3006 x21351", false, "18214877-0f7b-458b-9c12-5ca39eba336e", 2, false, "Lexie.Oberbrunner" },
                    { "30", 0, 78, "635a38b8-d5b1-4a01-9b11-a05c6f20addb", "ApplicationUser", "Leland_Hermiston@hotmail.com", false, false, null, "LELAND_HERMISTON@HOTMAIL.COM", "GEO_MORAR95", null, "1-310-738-6214", false, "b5722dcd-077d-409d-8f81-0c3fd307d371", 2, false, "Geo_Morar95" },
                    { "31", 0, 51, "eb7177b7-750b-4cb9-a13b-307fbc89eb5e", "ApplicationUser", "Brando_Kerluke@yahoo.com", false, false, null, "BRANDO_KERLUKE@YAHOO.COM", "NEIL.HOWE33", null, "(480) 519-5719", false, "8fd48824-72ba-46b1-884a-4aae44787d78", 2, false, "Neil.Howe33" },
                    { "32", 0, 56, "bbfb5134-ad52-4a81-a719-015e9d6e969d", "ApplicationUser", "Bridget_Huels19@gmail.com", false, false, null, "BRIDGET_HUELS19@GMAIL.COM", "GIDEON.GLEICHNER27", null, "786-557-9577 x566", false, "1ddfabbe-cfdb-4a5e-a013-bfcc41f2ca19", 3, false, "Gideon.Gleichner27" },
                    { "33", 0, 19, "d8c2f680-c2de-46ea-83e8-4e8937f0caa7", "ApplicationUser", "Maynard92@yahoo.com", false, false, null, "MAYNARD92@YAHOO.COM", "ELEANORE_ZIEMANN", null, "668-746-4762 x56649", false, "8558f324-c1a3-4d04-90d8-9aeae4c44b37", 4, false, "Eleanore_Ziemann" },
                    { "34", 0, 50, "9e5cde25-b08b-45e2-b7fb-4517c6058d0f", "ApplicationUser", "Kenny_Kemmer4@hotmail.com", false, false, null, "KENNY_KEMMER4@HOTMAIL.COM", "KAELYN.JOHNS19", null, "(848) 712-5936 x072", false, "b4789e57-b5c6-4776-99a2-3f41aa4f414f", 4, false, "Kaelyn.Johns19" },
                    { "35", 0, 39, "63abf6e9-5be7-4f5e-aebe-a2b259148aca", "ApplicationUser", "Georgianna.Osinski@yahoo.com", false, false, null, "GEORGIANNA.OSINSKI@YAHOO.COM", "LEOPOLD23", null, "(252) 563-9612", false, "f61562b0-600b-4e83-a1ab-8bdbc452196a", 4, false, "Leopold23" },
                    { "36", 0, 13, "500a04d8-a8b8-40a8-959e-d1fafb0ba950", "ApplicationUser", "Camille.Wintheiser@yahoo.com", false, false, null, "CAMILLE.WINTHEISER@YAHOO.COM", "ALANIS_HETTINGER43", null, "1-436-366-0156 x67205", false, "02a8df45-56f8-4f00-9388-f100bdc32732", 1, false, "Alanis_Hettinger43" },
                    { "37", 0, 76, "27b7c08d-4c95-4954-bc19-b846d6285e94", "ApplicationUser", "Colton_Sporer69@gmail.com", false, false, null, "COLTON_SPORER69@GMAIL.COM", "BLAIR.DICKINSON38", null, "759.931.8973", false, "1ed7e0df-8e5d-4d05-816c-cd869ece4052", 3, false, "Blair.Dickinson38" },
                    { "38", 0, 66, "ccf15d3e-9c97-48c7-931b-e181e543006a", "ApplicationUser", "Devyn.Reynolds@hotmail.com", false, false, null, "DEVYN.REYNOLDS@HOTMAIL.COM", "WINONA96", null, "325-659-8360", false, "8b0af8cf-5f62-4d0c-9e76-d2137eadcfa3", 3, false, "Winona96" },
                    { "39", 0, 75, "a66bf890-aabf-4362-8ce5-698c14c25ecc", "ApplicationUser", "Louvenia.Stracke16@gmail.com", false, false, null, "LOUVENIA.STRACKE16@GMAIL.COM", "CHANEL59", null, "(723) 357-4404", false, "aced9c6b-a99e-44a1-856a-1919d914995f", 2, false, "Chanel59" },
                    { "4", 0, 49, "b31ae507-ef4b-4660-8ea8-ef2a99c025ac", "ApplicationUser", "Kory.Hessel52@yahoo.com", false, false, null, "KORY.HESSEL52@YAHOO.COM", "KAYLIE.CRONIN", null, "1-725-771-8769 x16465", false, "216aca50-3999-4e88-926b-580c69cf239c", 4, false, "Kaylie.Cronin" },
                    { "40", 0, 59, "8fbcc1e6-3f5a-4c6e-b2c3-00d50cbd29bd", "ApplicationUser", "Kareem52@hotmail.com", false, false, null, "KAREEM52@HOTMAIL.COM", "FORREST.ZULAUF80", null, "1-464-691-8131", false, "95dbf424-2772-4f65-8ef1-c2999ac91f9b", 3, false, "Forrest.Zulauf80" },
                    { "41", 0, 42, "a312a80f-130a-485f-bdb9-c661e0474621", "ApplicationUser", "Chance_Dicki@hotmail.com", false, false, null, "CHANCE_DICKI@HOTMAIL.COM", "MAURICIO.MERTZ57", null, "(750) 326-9913", false, "0c5e3155-b98b-4986-a636-29b315281380", 4, false, "Mauricio.Mertz57" },
                    { "42", 0, 14, "e9543474-656f-47a8-9d84-630093281229", "ApplicationUser", "Tito_Kassulke@yahoo.com", false, false, null, "TITO_KASSULKE@YAHOO.COM", "BUFORD.MEDHURST59", null, "1-852-606-9323 x28344", false, "c7f37f67-a9f3-4849-99d3-5492a57a9b3a", 1, false, "Buford.Medhurst59" },
                    { "43", 0, 73, "c598bfba-9a28-4e8c-96be-3dd7dfa23da4", "ApplicationUser", "Ansley.Breitenberg98@yahoo.com", false, false, null, "ANSLEY.BREITENBERG98@YAHOO.COM", "BRIELLE.NICOLAS68", null, "697-269-0205", false, "e4fe59db-1d30-4fe9-94a9-d24f4e03e2c7", 3, false, "Brielle.Nicolas68" },
                    { "44", 0, 67, "4d39b476-7eb8-405a-ba0a-1326e15133ba", "ApplicationUser", "Jake.Schumm@hotmail.com", false, false, null, "JAKE.SCHUMM@HOTMAIL.COM", "ESTEVAN_CRUICKSHANK56", null, "897-364-1591", false, "6526d1ca-719d-4728-8d44-9635aa3034fb", 3, false, "Estevan_Cruickshank56" },
                    { "45", 0, 71, "84bce184-84d2-4cd9-a222-b00d9df9cd67", "ApplicationUser", "Alberto_Koch@yahoo.com", false, false, null, "ALBERTO_KOCH@YAHOO.COM", "SHELDON_JAST", null, "1-536-332-2571 x1603", false, "1fd2374b-6adc-484c-baf8-dbdbc4bbc016", 2, false, "Sheldon_Jast" },
                    { "46", 0, 53, "00b22269-cee8-4e3d-928b-34c4d00bd623", "ApplicationUser", "Keeley69@yahoo.com", false, false, null, "KEELEY69@YAHOO.COM", "DORIS17", null, "803-440-3450", false, "8160a4b6-32ca-42e8-9d8b-1a0db9700048", 4, false, "Doris17" },
                    { "47", 0, 45, "df0c8e2f-1f36-40df-b2c0-2b1f26892bf3", "ApplicationUser", "Henri.Nader@yahoo.com", false, false, null, "HENRI.NADER@YAHOO.COM", "EMMALEE_EFFERTZ96", null, "1-700-296-6344", false, "9d323543-d1a9-4b09-86ba-53c260c9f716", 3, false, "Emmalee_Effertz96" },
                    { "48", 0, 65, "a58e1059-dd21-4520-bd3a-8b9e556a0dae", "ApplicationUser", "Irma_Aufderhar@yahoo.com", false, false, null, "IRMA_AUFDERHAR@YAHOO.COM", "LIZETH_BOYER34", null, "807.491.6709 x2671", false, "e510c233-5b50-49f8-b320-64766b836278", 2, false, "Lizeth_Boyer34" },
                    { "49", 0, 77, "7a1f9ec0-64eb-4b90-a621-169795cb50f5", "ApplicationUser", "Keith94@yahoo.com", false, false, null, "KEITH94@YAHOO.COM", "BENEDICT_TURNER25", null, "668.703.9926", false, "af8824e5-08d6-410d-a701-a764a5fe0e9f", 3, false, "Benedict_Turner25" },
                    { "5", 0, 59, "ae7508e4-7992-4ddf-806c-038d42f190ca", "ApplicationUser", "Elsie.Sanford@gmail.com", false, false, null, "ELSIE.SANFORD@GMAIL.COM", "ELI_ZULAUF", null, "688-238-7849 x2814", false, "1e55383a-d739-4ba8-86ac-54b711e35def", 3, false, "Eli_Zulauf" },
                    { "50", 0, 26, "0adccff3-e445-465b-8c66-f1709d40156d", "ApplicationUser", "Beatrice.King31@gmail.com", false, false, null, "BEATRICE.KING31@GMAIL.COM", "CARLO_CONNELLY10", null, "344-851-4690", false, "6974633b-9a26-4259-93bc-9b1de02b4e58", 4, false, "Carlo_Connelly10" },
                    { "51", 0, 72, "bd01801a-654b-46b2-a3a7-82f5241798ee", "ApplicationUser", "Duncan.Nader@gmail.com", false, false, null, "DUNCAN.NADER@GMAIL.COM", "GEORGE.WINDLER", null, "841-688-3369", false, "2288cc6b-9a15-4acc-884d-8fe49dfb9cd8", 2, false, "George.Windler" },
                    { "52", 0, 57, "2c2c6cf2-eaf2-4770-bfd6-da1f8e42062f", "ApplicationUser", "Patrick_Baumbach7@yahoo.com", false, false, null, "PATRICK_BAUMBACH7@YAHOO.COM", "YVONNE58", null, "(878) 677-5754 x759", false, "520fcb67-4d6f-431f-ac5b-e944b1dc63e9", 2, false, "Yvonne58" },
                    { "53", 0, 50, "6609c791-62b1-488e-b8ac-c17fbcf63ce2", "ApplicationUser", "Melany33@gmail.com", false, false, null, "MELANY33@GMAIL.COM", "SABRYNA19", null, "1-488-336-0551", false, "5d29044c-e6db-42d8-ac34-63c188f16862", 4, false, "Sabryna19" },
                    { "54", 0, 46, "edbe3ef5-3900-4083-9194-91e7d3812dd4", "ApplicationUser", "Josue.Cole@hotmail.com", false, false, null, "JOSUE.COLE@HOTMAIL.COM", "SHYANNE.SMITH54", null, "241-570-3428 x42913", false, "2075c69a-527e-4fae-9d21-3e03b0b59906", 4, false, "Shyanne.Smith54" },
                    { "55", 0, 68, "6e71b885-55e1-48ed-8cbd-aa799342904d", "ApplicationUser", "Samir74@hotmail.com", false, false, null, "SAMIR74@HOTMAIL.COM", "JANIE.KLEIN", null, "289.278.7428", false, "35f2eb0d-c5ed-4487-b6c4-193783af7445", 4, false, "Janie.Klein" },
                    { "56", 0, 61, "622b98db-4f2d-43f3-a526-09e10b86b9d4", "ApplicationUser", "Houston.Daniel10@hotmail.com", false, false, null, "HOUSTON.DANIEL10@HOTMAIL.COM", "HERBERT.GOYETTE", null, "(398) 397-3481", false, "5a9bf877-c806-48a9-99be-6eda9a2b4b33", 4, false, "Herbert.Goyette" },
                    { "57", 0, 76, "a666f22e-b59b-478a-8c33-ff4f2f6ecf70", "ApplicationUser", "Braulio32@hotmail.com", false, false, null, "BRAULIO32@HOTMAIL.COM", "KELLI.ZEMLAK90", null, "1-417-616-7442", false, "86626f3f-cd4c-464b-aa3a-d3fb784265bd", 2, false, "Kelli.Zemlak90" },
                    { "58", 0, 54, "b0bd43a6-c0b3-47ff-8960-c2e8d2e870f4", "ApplicationUser", "Cora54@yahoo.com", false, false, null, "CORA54@YAHOO.COM", "JAQUELIN67", null, "483-747-3229 x23184", false, "454b5474-7153-4fbe-8861-14fc4fa9bc44", 2, false, "Jaquelin67" },
                    { "59", 0, 75, "0f0db7cf-b812-458b-9538-d2016586063f", "ApplicationUser", "Schuyler.Legros95@hotmail.com", false, false, null, "SCHUYLER.LEGROS95@HOTMAIL.COM", "HOLLIS_MCLAUGHLIN", null, "546.436.0801", false, "a3d42ffc-51d2-4c8c-903f-d067449fb02c", 2, false, "Hollis_McLaughlin" },
                    { "6", 0, 80, "c2fcc279-d588-4b1f-aac5-1030b269ca97", "ApplicationUser", "Ava_Jacobi@hotmail.com", false, false, null, "AVA_JACOBI@HOTMAIL.COM", "NAOMIE92", null, "(537) 369-5455", false, "cf1aba3b-9f72-4e1b-b315-a6e8d4c779c0", 4, false, "Naomie92" },
                    { "60", 0, 36, "1eaf6289-0a1b-4ac2-827d-9bdd4d780a9d", "ApplicationUser", "Curtis28@hotmail.com", false, false, null, "CURTIS28@HOTMAIL.COM", "ARIELLE94", null, "(481) 304-1302 x78782", false, "482a3594-0719-4b27-a445-05451890cf35", 3, false, "Arielle94" },
                    { "61", 0, 65, "7a411dcb-a431-42ef-8569-b511d0ee3efc", "ApplicationUser", "Josiane10@gmail.com", false, false, null, "JOSIANE10@GMAIL.COM", "PHYLLIS76", null, "(221) 877-2128 x0603", false, "9e2126f2-66d7-448b-b5da-664f795fc7c3", 4, false, "Phyllis76" },
                    { "62", 0, 21, "9b36ffe3-7c7c-4c7b-8565-415a6e638caa", "ApplicationUser", "Cindy.Kassulke@hotmail.com", false, false, null, "CINDY.KASSULKE@HOTMAIL.COM", "TIARA6", null, "344.459.0202", false, "48b28ac9-acc1-4fee-8ae8-92a6dc5a433f", 3, false, "Tiara6" },
                    { "63", 0, 42, "78d8bad8-19d6-4a46-b6f7-01725a7e66f6", "ApplicationUser", "Arnulfo.Doyle35@gmail.com", false, false, null, "ARNULFO.DOYLE35@GMAIL.COM", "ESTELL11", null, "436.855.4486", false, "2872da07-cb62-4c3e-80d5-5f89bb82259e", 3, false, "Estell11" },
                    { "64", 0, 62, "05777399-f4c3-4cc7-aaff-3a3039a1219a", "ApplicationUser", "Leonel27@gmail.com", false, false, null, "LEONEL27@GMAIL.COM", "ESMERALDA.SPENCER54", null, "459-379-4468 x3064", false, "97ecfdea-9dec-488c-ba9c-f33b666ab456", 2, false, "Esmeralda.Spencer54" },
                    { "65", 0, 38, "e9340f8f-6bda-4cd3-8dff-45a2881bfa4a", "ApplicationUser", "Trycia.Lemke80@gmail.com", false, false, null, "TRYCIA.LEMKE80@GMAIL.COM", "DAISY_STIEDEMANN", null, "1-703-524-4545", false, "f712ece5-588f-4149-993a-05f89c411456", 2, false, "Daisy_Stiedemann" },
                    { "66", 0, 29, "358a6dfb-ddea-4f0c-b5c8-f4932ad726f5", "ApplicationUser", "Aurore_Gerhold93@hotmail.com", false, false, null, "AURORE_GERHOLD93@HOTMAIL.COM", "ESTELLE.CONN28", null, "633.728.5931 x307", false, "e13b0864-f091-43f2-821d-15f10e23a461", 2, false, "Estelle.Conn28" },
                    { "67", 0, 77, "5b8ce82e-a088-430b-a4bb-0c4a09a9cc15", "ApplicationUser", "Lurline38@hotmail.com", false, false, null, "LURLINE38@HOTMAIL.COM", "ANTONE_WELCH", null, "(532) 925-8153", false, "110f78e4-4213-4f29-bc3a-4d7de4f4ba98", 4, false, "Antone_Welch" },
                    { "68", 0, 58, "2abd5c0b-467a-4f67-bb5e-5a378707d881", "ApplicationUser", "Giuseppe_Metz@yahoo.com", false, false, null, "GIUSEPPE_METZ@YAHOO.COM", "JOCELYN54", null, "1-340-874-5568 x718", false, "0a938325-e742-498b-bbe0-c396586f55fd", 3, false, "Jocelyn54" },
                    { "69", 0, 43, "1e24e6ba-eaf4-45c2-9dec-bc0127b02eeb", "ApplicationUser", "Presley_McDermott93@gmail.com", false, false, null, "PRESLEY_MCDERMOTT93@GMAIL.COM", "AUSTIN.BUCKRIDGE", null, "(922) 370-6729", false, "9f9c6e06-5f1f-41a3-bc27-9da118a1a895", 2, false, "Austin.Buckridge" },
                    { "7", 0, 30, "6d58a868-3cd9-460c-8669-f0699579f2b8", "ApplicationUser", "Cedrick34@gmail.com", false, false, null, "CEDRICK34@GMAIL.COM", "MALACHI.PACOCHA", null, "1-710-498-9218", false, "8dbcf99a-c346-4b52-aea4-c66f09473ea1", 2, false, "Malachi.Pacocha" },
                    { "70", 0, 34, "2e51aca9-a279-4555-ad6a-dee503e142e6", "ApplicationUser", "Hilda_Pacocha@gmail.com", false, false, null, "HILDA_PACOCHA@GMAIL.COM", "JENNYFER50", null, "323.453.8213 x209", false, "e3c19f91-d77c-4555-8d4d-9131b8c48b12", 4, false, "Jennyfer50" },
                    { "71", 0, 53, "ffb46041-e506-432d-adce-f92d81994e18", "ApplicationUser", "Cicero_Emard92@gmail.com", false, false, null, "CICERO_EMARD92@GMAIL.COM", "FAUSTO64", null, "309-711-7344 x6081", false, "ba7a6994-f467-4522-91c1-275a814b9775", 2, false, "Fausto64" },
                    { "72", 0, 75, "5efa0c71-196d-4be2-9638-32f2cd4a4661", "ApplicationUser", "Robert_Koelpin@hotmail.com", false, false, null, "ROBERT_KOELPIN@HOTMAIL.COM", "PATRICK.MOEN", null, "405-448-6551 x207", false, "afefe3e5-fb65-4c35-a735-8544feb81b03", 3, false, "Patrick.Moen" },
                    { "73", 0, 19, "09d9383c-c9c5-4fa1-868f-c622998d9672", "ApplicationUser", "Omer_Jones19@yahoo.com", false, false, null, "OMER_JONES19@YAHOO.COM", "NORA49", null, "352-943-9132", false, "12bdae52-6fc9-4ca9-854e-9f2fbbd03031", 4, false, "Nora49" },
                    { "74", 0, 80, "9fb9c27c-1549-4e93-a71c-95508f99584c", "ApplicationUser", "Izabella.Cruickshank88@yahoo.com", false, false, null, "IZABELLA.CRUICKSHANK88@YAHOO.COM", "TIMMY_LOWE78", null, "(400) 235-5921", false, "6be1b0e8-2bdb-4646-af69-78e0dbc13f4f", 2, false, "Timmy_Lowe78" },
                    { "75", 0, 63, "74ee8736-96eb-4d9a-8cc8-2d43f60c640e", "ApplicationUser", "Sim72@gmail.com", false, false, null, "SIM72@GMAIL.COM", "JOANA_BARROWS28", null, "692-959-5968 x32246", false, "a9734a49-02e1-49dc-ae78-335bf7acbeee", 2, false, "Joana_Barrows28" },
                    { "76", 0, 58, "8acfa152-6cd4-486e-a4c5-4d2f59476ee0", "ApplicationUser", "Ashleigh_Walker@hotmail.com", false, false, null, "ASHLEIGH_WALKER@HOTMAIL.COM", "AHMED19", null, "(531) 572-2221", false, "97d5f39d-029c-4e81-961d-7432f336eb4b", 2, false, "Ahmed19" },
                    { "77", 0, 15, "9bf2204b-e616-4cfa-8b6b-807f5fea327b", "ApplicationUser", "Isidro_Wisoky73@yahoo.com", false, false, null, "ISIDRO_WISOKY73@YAHOO.COM", "ALBIN.REINGER", null, "1-332-419-0237 x41808", false, "94a3b0eb-8b5f-4c54-b12f-c1b450a4c62e", 1, false, "Albin.Reinger" },
                    { "78", 0, 25, "9371d012-ad2d-40cd-bb81-9db0ffdc3780", "ApplicationUser", "Heloise_Cremin68@hotmail.com", false, false, null, "HELOISE_CREMIN68@HOTMAIL.COM", "ADDISON67", null, "(969) 966-9612 x27399", false, "60aaba7d-6ec2-4c91-82a3-ba14114a854b", 4, false, "Addison67" },
                    { "79", 0, 33, "729445f4-c440-4537-aba0-ec9826fd580a", "ApplicationUser", "Viviane52@hotmail.com", false, false, null, "VIVIANE52@HOTMAIL.COM", "TIMOTHY_WIZA", null, "(798) 238-3808 x20385", false, "3d8a5dd3-3e76-40e3-9afb-cb0171109d67", 4, false, "Timothy_Wiza" },
                    { "8", 0, 67, "c6555716-90d7-47b8-b4d3-2518d8af6912", "ApplicationUser", "Paxton97@yahoo.com", false, false, null, "PAXTON97@YAHOO.COM", "WAINO.FRITSCH1", null, "585.557.8557 x398", false, "37acf67a-bc98-453d-8346-f9fb1e5f487f", 3, false, "Waino.Fritsch1" },
                    { "80", 0, 41, "71f94b0d-98a1-4e1b-8efd-03033c76c650", "ApplicationUser", "Giovanni.Rowe@hotmail.com", false, false, null, "GIOVANNI.ROWE@HOTMAIL.COM", "HARVEY.AUER", null, "1-597-739-3062 x1741", false, "7e22e5b5-344b-4e7d-ab23-608dcad5b50b", 2, false, "Harvey.Auer" },
                    { "81", 0, 55, "31c34592-8046-4418-9fb6-ea9835a37f7b", "ApplicationUser", "Greg.Labadie@gmail.com", false, false, null, "GREG.LABADIE@GMAIL.COM", "MEGGIE.KUHIC84", null, "1-624-340-9168", false, "8c1ab1d1-0c38-48f5-b51b-4ab5f2a10422", 2, false, "Meggie.Kuhic84" },
                    { "82", 0, 72, "c49058e9-fc19-45f0-b8a8-ee9b04b2ffa1", "ApplicationUser", "Dennis_Schaefer49@hotmail.com", false, false, null, "DENNIS_SCHAEFER49@HOTMAIL.COM", "LEOPOLDO_REICHERT", null, "1-606-547-6665", false, "b8a1f64a-33fc-42d3-bf24-a747dd6ca06c", 2, false, "Leopoldo_Reichert" },
                    { "83", 0, 67, "b4d8a8b1-70ad-47d9-a91b-720b89ac0857", "ApplicationUser", "Carlos.Reichel@yahoo.com", false, false, null, "CARLOS.REICHEL@YAHOO.COM", "LLEWELLYN_GRANT19", null, "489.313.0464 x9840", false, "d620a6e1-4723-4d7f-ae66-7e5a456320f4", 3, false, "Llewellyn_Grant19" },
                    { "84", 0, 53, "e5a486d4-dc3b-43a2-817c-e032ab8dea2c", "ApplicationUser", "Madelyn.Kemmer23@yahoo.com", false, false, null, "MADELYN.KEMMER23@YAHOO.COM", "CAROLINA.OKON", null, "(920) 822-9552 x88908", false, "655be9b0-1c17-4a18-b52b-87ea657eabdc", 4, false, "Carolina.OKon" },
                    { "85", 0, 45, "7ab25770-4584-4f6c-ac14-1effdce46eb7", "ApplicationUser", "Brannon38@gmail.com", false, false, null, "BRANNON38@GMAIL.COM", "TAYA_MOHR", null, "323.794.8627", false, "ac7b8265-4e94-4103-853f-d5b84d3831ab", 4, false, "Taya_Mohr" },
                    { "86", 0, 30, "4721153a-33ed-4608-9be1-285b6b64a5da", "ApplicationUser", "Kasey76@yahoo.com", false, false, null, "KASEY76@YAHOO.COM", "ALI.RENNER", null, "1-328-937-5276 x37453", false, "a561b7d6-dd47-4d4a-bc12-d607cdd8ac08", 3, false, "Ali.Renner" },
                    { "87", 0, 54, "1914705e-4806-41bf-a60f-9fff9b428767", "ApplicationUser", "Anika.Hermiston@yahoo.com", false, false, null, "ANIKA.HERMISTON@YAHOO.COM", "WINNIFRED_CHRISTIANSEN45", null, "842-676-6344", false, "08bf1b26-f62f-49e9-b027-0314e71612cb", 2, false, "Winnifred_Christiansen45" },
                    { "88", 0, 27, "fe1b669b-2898-42be-b3e3-506b8695b191", "ApplicationUser", "Delores36@yahoo.com", false, false, null, "DELORES36@YAHOO.COM", "SALMA_WALKER74", null, "640-909-3818 x3315", false, "cde4b424-3ec5-44f4-895e-3948661987b3", 2, false, "Salma_Walker74" },
                    { "89", 0, 26, "2eecb5ae-5c68-499e-bbfa-39ee9ad9c770", "ApplicationUser", "Greyson.Fay@hotmail.com", false, false, null, "GREYSON.FAY@HOTMAIL.COM", "RUTHE_KOEPP62", null, "(216) 216-5737 x91098", false, "645c8bb5-aebf-4d2b-9b9c-a9e500e2d81a", 2, false, "Ruthe_Koepp62" },
                    { "9", 0, 49, "3cc61c2e-0213-4c7b-a8e5-9dadb6ba4b08", "ApplicationUser", "Zion45@yahoo.com", false, false, null, "ZION45@YAHOO.COM", "JAVONTE27", null, "(867) 618-8332", false, "0cd1b6a1-f480-426f-89bf-93221bca3dba", 3, false, "Javonte27" },
                    { "90", 0, 44, "f7cfe7e5-0a62-4c6f-a168-1ab032e24aaa", "ApplicationUser", "Cali_Becker@yahoo.com", false, false, null, "CALI_BECKER@YAHOO.COM", "KAVON.HEANEY", null, "(237) 977-1269 x578", false, "7e017e97-7337-4972-9eb8-133aae8d3455", 4, false, "Kavon.Heaney" },
                    { "91", 0, 47, "4ff4f9cf-ada3-4dfb-872b-d8ee78d0e505", "ApplicationUser", "Courtney_Zulauf@yahoo.com", false, false, null, "COURTNEY_ZULAUF@YAHOO.COM", "KYLE_CUMMINGS73", null, "(609) 987-2298 x957", false, "df27a56d-5c8c-4ecd-8e9e-e9298db72cce", 4, false, "Kyle_Cummings73" },
                    { "92", 0, 46, "9dd977b9-aeb7-43fe-b67d-a2f960dc1951", "ApplicationUser", "Dimitri5@yahoo.com", false, false, null, "DIMITRI5@YAHOO.COM", "MADDISON74", null, "365.410.3577", false, "ae1f79ee-063b-4e3e-bc60-ebeaef7d795b", 2, false, "Maddison74" },
                    { "93", 0, 14, "57b0e6a7-2077-4494-815f-190508f1de65", "ApplicationUser", "Josh.MacGyver@yahoo.com", false, false, null, "JOSH.MACGYVER@YAHOO.COM", "RUSSELL.TOWNE", null, "881.954.7282 x614", false, "787036c1-2f85-4036-a440-8de949c56a96", 1, false, "Russell.Towne" },
                    { "94", 0, 71, "0408e01c-4f28-48a1-adfd-5ab66fc05255", "ApplicationUser", "Antonia.Wehner@yahoo.com", false, false, null, "ANTONIA.WEHNER@YAHOO.COM", "ROLLIN.RICE5", null, "629-358-5325", false, "086df9b1-1551-4531-9ded-bc95a2288fe0", 4, false, "Rollin.Rice5" },
                    { "95", 0, 52, "a2ecbfc9-b09d-47a9-97aa-a180af446ed2", "ApplicationUser", "Mathew.DuBuque21@yahoo.com", false, false, null, "MATHEW.DUBUQUE21@YAHOO.COM", "PASCALE85", null, "222-586-7703 x27450", false, "3a876b33-f1af-41a2-a4f3-41810ed09a38", 3, false, "Pascale85" },
                    { "96", 0, 59, "097085db-fa74-416f-844c-243dc0d89d81", "ApplicationUser", "Chadd.Price@gmail.com", false, false, null, "CHADD.PRICE@GMAIL.COM", "VELVA51", null, "252.372.7070", false, "6de9ea0f-96ce-4fbf-b30f-f4ab8d0f28a9", 2, false, "Velva51" },
                    { "97", 0, 28, "ab03fcf7-65b9-4df7-ac52-14dfa5e5b7d5", "ApplicationUser", "Eryn_Hermann@hotmail.com", false, false, null, "ERYN_HERMANN@HOTMAIL.COM", "KHALID46", null, "(352) 556-0039", false, "ac867e6b-3f3e-43de-a02d-bf37bee0ef0e", 2, false, "Khalid46" },
                    { "98", 0, 36, "a9817ccd-2b74-43c8-be9a-b8924d61b019", "ApplicationUser", "Ally_Boyer19@hotmail.com", false, false, null, "ALLY_BOYER19@HOTMAIL.COM", "RODRICK61", null, "404-774-9492", false, "97f05d32-f27c-4ca8-8683-a6ac738c2dae", 2, false, "Rodrick61" },
                    { "99", 0, 56, "ebe00430-3b39-4c1a-98f0-c660ab5b850a", "ApplicationUser", "Danny_Stiedemann0@yahoo.com", false, false, null, "DANNY_STIEDEMANN0@YAHOO.COM", "DARBY73", null, "792.725.8127 x7743", false, "8eab29f9-34fb-4764-b654-f736515575ed", 3, false, "Darby73" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 10, 4, "The Football Is Good For Training And Recreational Purposes", 0, "Small Metal Car", null, 2021 },
                    { 2, 16, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Ergonomic Metal Chair", null, 2004 },
                    { 3, 8, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, "Gorgeous Wooden Computer", null, 2005 },
                    { 4, 16, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, "Generic Steel Tuna", null, 2007 },
                    { 5, 9, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Rustic Steel Computer", null, 2001 },
                    { 6, 2, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Generic Cotton Pizza", null, 2012 },
                    { 7, 3, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Refined Granite Shoes", null, 2012 },
                    { 8, 14, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Practical Frozen Bacon", null, 2023 },
                    { 9, 15, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Fantastic Plastic Sausages", null, 2001 },
                    { 10, 7, 2, "The Football Is Good For Training And Recreational Purposes", 1, "Unbranded Wooden Mouse", null, 2017 },
                    { 11, 10, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Tasty Frozen Pants", null, 2008 },
                    { 12, 9, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Sleek Cotton Ball", null, 2006 },
                    { 13, 15, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 8, "Unbranded Wooden Bacon", null, 2012 },
                    { 14, 6, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Handmade Soft Chicken", null, 2021 },
                    { 15, 7, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10, "Intelligent Soft Pizza", null, 2004 },
                    { 16, 12, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Ergonomic Steel Bacon", null, 2017 },
                    { 17, 3, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8, "Fantastic Steel Keyboard", null, 2018 },
                    { 18, 18, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Rustic Concrete Chicken", null, 2016 },
                    { 19, 14, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9, "Awesome Wooden Pizza", null, 2008 },
                    { 20, 9, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Unbranded Soft Bike", null, 2009 },
                    { 21, 17, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 3, "Generic Wooden Car", null, 2012 },
                    { 22, 7, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Licensed Wooden Computer", null, 2022 },
                    { 23, 2, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, "Awesome Frozen Bike", null, 2002 },
                    { 24, 9, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, "Unbranded Cotton Car", null, 2016 },
                    { 25, 13, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Rustic Wooden Salad", null, 2023 },
                    { 26, 13, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, "Handcrafted Cotton Chair", null, 2003 },
                    { 27, 14, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Ergonomic Plastic Car", null, 2012 },
                    { 28, 20, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10, "Rustic Frozen Pants", null, 2011 },
                    { 29, 4, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Rustic Wooden Sausages", null, 2013 },
                    { 30, 3, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9, "Licensed Steel Mouse", null, 2014 },
                    { 31, 12, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 1, "Awesome Concrete Chair", null, 2020 },
                    { 32, 12, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Tasty Steel Salad", null, 2015 },
                    { 33, 6, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9, "Small Steel Pants", null, 2016 },
                    { 34, 17, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Incredible Frozen Table", null, 2023 },
                    { 35, 13, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Refined Metal Ball", null, 2020 },
                    { 36, 18, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 10, "Handmade Rubber Pants", null, 2011 },
                    { 37, 9, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Licensed Cotton Fish", null, 2005 },
                    { 38, 20, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Awesome Cotton Hat", null, 2006 },
                    { 39, 3, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10, "Handcrafted Concrete Computer", null, 2022 },
                    { 40, 13, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Incredible Granite Hat", null, 2005 },
                    { 41, 7, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Generic Frozen Mouse", null, 2023 },
                    { 42, 20, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Rustic Frozen Shirt", null, 2010 },
                    { 43, 13, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Handcrafted Steel Shirt", null, 2022 },
                    { 44, 20, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Refined Granite Salad", null, 2002 },
                    { 45, 8, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Fantastic Plastic Shirt", null, 2019 },
                    { 46, 8, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, "Awesome Frozen Hat", null, 2013 },
                    { 47, 9, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Handcrafted Plastic Fish", null, 2011 },
                    { 48, 12, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, "Generic Plastic Table", null, 2021 },
                    { 49, 10, 5, "The Football Is Good For Training And Recreational Purposes", 9, "Small Steel Chips", null, 2004 },
                    { 50, 12, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Incredible Cotton Ball", null, 2004 },
                    { 51, 19, 2, "The Football Is Good For Training And Recreational Purposes", 5, "Small Metal Fish", null, 2003 },
                    { 52, 5, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, "Incredible Steel Computer", null, 2002 },
                    { 53, 16, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Intelligent Granite Shirt", null, 2004 },
                    { 54, 7, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Ergonomic Frozen Tuna", null, 2017 },
                    { 55, 18, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6, "Generic Rubber Keyboard", null, 2007 },
                    { 56, 4, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 10, "Intelligent Rubber Car", null, 2009 },
                    { 57, 6, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 2, "Handcrafted Cotton Bike", null, 2000 },
                    { 58, 20, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 1, "Awesome Soft Shirt", null, 2018 },
                    { 59, 19, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Gorgeous Plastic Ball", null, 2023 },
                    { 60, 14, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 3, "Unbranded Cotton Computer", null, 2020 },
                    { 61, 6, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Generic Metal Shoes", null, 2017 },
                    { 62, 17, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 2, "Ergonomic Granite Soap", null, 2002 },
                    { 63, 13, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Gorgeous Soft Soap", null, 2019 },
                    { 64, 8, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Tasty Fresh Gloves", null, 2021 },
                    { 65, 17, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Ergonomic Rubber Sausages", null, 2019 },
                    { 66, 16, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Fantastic Steel Soap", null, 2012 },
                    { 67, 2, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, "Small Steel Fish", null, 2000 },
                    { 68, 14, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, "Rustic Metal Keyboard", null, 2012 },
                    { 69, 14, 4, "The Football Is Good For Training And Recreational Purposes", 5, "Practical Fresh Table", null, 2018 },
                    { 70, 5, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Handmade Concrete Pizza", null, 2013 },
                    { 71, 19, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 10, "Licensed Rubber Shoes", null, 2008 },
                    { 72, 16, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Incredible Concrete Towels", null, 2007 },
                    { 73, 4, 4, "The Football Is Good For Training And Recreational Purposes", 9, "Rustic Granite Hat", null, 2015 },
                    { 74, 1, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 3, "Practical Frozen Hat", null, 2007 },
                    { 75, 15, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10, "Small Plastic Computer", null, 2003 },
                    { 76, 11, 5, "The Football Is Good For Training And Recreational Purposes", 1, "Intelligent Metal Keyboard", null, 2002 },
                    { 77, 6, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Sleek Wooden Ball", null, 2015 },
                    { 78, 20, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 8, "Awesome Concrete Bacon", null, 2017 },
                    { 79, 14, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Small Plastic Salad", null, 2010 },
                    { 80, 16, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Licensed Rubber Tuna", null, 2008 },
                    { 81, 17, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Tasty Rubber Chicken", null, 2002 },
                    { 82, 15, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Small Cotton Cheese", null, 2012 },
                    { 83, 6, 2, "The Football Is Good For Training And Recreational Purposes", 7, "Ergonomic Concrete Tuna", null, 2014 },
                    { 84, 14, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Unbranded Granite Towels", null, 2018 },
                    { 85, 19, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Intelligent Soft Tuna", null, 2013 },
                    { 86, 10, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Generic Granite Mouse", null, 2022 },
                    { 87, 1, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Intelligent Wooden Mouse", null, 2023 },
                    { 88, 12, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0, "Fantastic Cotton Pants", null, 2019 },
                    { 89, 6, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Tasty Soft Tuna", null, 2009 },
                    { 90, 11, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Intelligent Granite Pizza", null, 2001 },
                    { 91, 8, 3, "The Football Is Good For Training And Recreational Purposes", 1, "Handmade Granite Computer", null, 2008 },
                    { 92, 14, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Fantastic Fresh Salad", null, 2012 },
                    { 93, 19, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Incredible Concrete Shirt", null, 2017 },
                    { 94, 15, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, "Unbranded Wooden Salad", null, 2012 },
                    { 95, 1, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 3, "Generic Plastic Bike", null, 2015 },
                    { 96, 13, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 0, "Practical Soft Car", null, 2020 },
                    { 97, 7, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 7, "Sleek Plastic Computer", null, 2011 },
                    { 98, 1, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Practical Metal Chicken", null, 2012 },
                    { 99, 19, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, "Ergonomic Concrete Soap", null, 2014 },
                    { 100, 3, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Awesome Rubber Chicken", null, 2004 }
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
