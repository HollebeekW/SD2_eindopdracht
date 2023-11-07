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
                    { 1, "Charles", "Kiehn" },
                    { 2, "Verona", "Nitzsche" },
                    { 3, "Abdul", "Ferry" },
                    { 4, "Loyal", "Effertz" },
                    { 5, "Nils", "Wehner" },
                    { 6, "Alvina", "Smith" },
                    { 7, "Gregory", "McDermott" },
                    { 8, "Madalyn", "Hintz" },
                    { 9, "Ophelia", "Stiedemann" },
                    { 10, "Marlon", "Goyette" },
                    { 11, "Sigurd", "Shanahan" },
                    { 12, "Cassandra", "Howell" },
                    { 13, "Lexie", "Thompson" },
                    { 14, "Valerie", "Thompson" },
                    { 15, "Jonatan", "Farrell" },
                    { 16, "Lila", "Walter" },
                    { 17, "Liana", "Little" },
                    { 18, "Elvera", "Wolf" },
                    { 19, "Beverly", "Beatty" },
                    { 20, "Archibald", "Ortiz" }
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
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Fine", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 53, "b64c5e20-c431-4d85-b2c1-fae54117edf2", "ApplicationUser", "Ezra_Maggio@gmail.com", false, 4.5m, false, null, "EZRA_MAGGIO@GMAIL.COM", "BUD_HEGMANN", null, "(380) 248-5807", false, "6a04ddc3-7000-43f2-8045-d91dfba66ac1", 3, false, "Bud_Hegmann" },
                    { "10", 0, 12, "4bfe410b-b41e-4cbf-aead-04b7c2b9a38a", "ApplicationUser", "Mortimer28@gmail.com", false, 6.1m, false, null, "MORTIMER28@GMAIL.COM", "ROCKY69", null, "1-433-757-7040 x034", false, "0ecc976b-f9a9-45ad-b3f9-99424ed2cce1", 1, false, "Rocky69" },
                    { "100", 0, 26, "2a516978-9d73-4732-96c8-8d39da9a4d54", "ApplicationUser", "Levi_Kertzmann@gmail.com", false, 1.5m, false, null, "LEVI_KERTZMANN@GMAIL.COM", "COOPER.LABADIE12", null, "497-656-9796", false, "bb835572-1b99-42b5-8500-4c2918253ada", 4, false, "Cooper.Labadie12" },
                    { "11", 0, 45, "50f1972a-ffe5-4066-8f0e-117d838255f6", "ApplicationUser", "Bennett_Watsica@hotmail.com", false, 4.2m, false, null, "BENNETT_WATSICA@HOTMAIL.COM", "BETTE.SCHILLER67", null, "1-446-599-8118", false, "2a4874b3-f36e-4478-8463-5126f43a8e7e", 2, false, "Bette.Schiller67" },
                    { "12", 0, 50, "3d1364b7-c4d4-4e62-87fc-7564c5177ac5", "ApplicationUser", "Alysa_Johnson48@hotmail.com", false, 7.3m, false, null, "ALYSA_JOHNSON48@HOTMAIL.COM", "AMALIA_FRANECKI", null, "1-879-686-7002 x26363", false, "ee76119b-543e-40e7-8ab1-48fbc71ca3b7", 3, false, "Amalia_Franecki" },
                    { "13", 0, 14, "62f42f07-138d-4802-9c4d-40519ccbcf63", "ApplicationUser", "Myrtice1@yahoo.com", false, 4.6m, false, null, "MYRTICE1@YAHOO.COM", "IMA.MITCHELL", null, "579.729.8065 x0593", false, "3897fe3a-269e-4074-bed0-40d18e78429f", 1, false, "Ima.Mitchell" },
                    { "14", 0, 24, "278649ee-0a89-4eed-b07d-956bbe7e3dcd", "ApplicationUser", "Susanna56@yahoo.com", false, 5.1m, false, null, "SUSANNA56@YAHOO.COM", "LORENZA.BOGAN", null, "968.678.7049", false, "37c1c582-a963-4aa0-99c2-8d395e5c9b6b", 3, false, "Lorenza.Bogan" },
                    { "15", 0, 12, "d4337cf0-b8e6-4a8b-8650-80593f8cf19f", "ApplicationUser", "Christopher91@yahoo.com", false, 4.1m, false, null, "CHRISTOPHER91@YAHOO.COM", "CAMRYN76", null, "(449) 518-5467 x0689", false, "729d832e-706c-41f0-87f7-542c0720a86e", 1, false, "Camryn76" },
                    { "16", 0, 77, "60267305-5d86-476e-a60e-583ef1d032d6", "ApplicationUser", "Bria99@yahoo.com", false, 5.9m, false, null, "BRIA99@YAHOO.COM", "MILO_DARE", null, "629-610-4157 x2161", false, "255f76ac-458f-4c81-aa08-65466b02ed12", 3, false, "Milo_Dare" },
                    { "17", 0, 31, "1b0ff6ba-fd05-4355-be1d-f6ae546dfe20", "ApplicationUser", "Shakira57@gmail.com", false, 5.2m, false, null, "SHAKIRA57@GMAIL.COM", "CLARISSA_KIHN", null, "304-518-2525", false, "e54a9755-771f-4043-9318-3fbd8ffd1ec1", 3, false, "Clarissa_Kihn" },
                    { "18", 0, 48, "baa7baa7-9c2b-40ab-8fff-aa393ad99160", "ApplicationUser", "Jovany.Rath@yahoo.com", false, 0.8m, false, null, "JOVANY.RATH@YAHOO.COM", "CAMREN15", null, "(878) 896-6664 x77398", false, "078c9b84-3318-402a-b579-792f07a85668", 3, false, "Camren15" },
                    { "19", 0, 51, "45644643-528e-440f-b40c-f47a7ab324e6", "ApplicationUser", "Christophe.Kovacek@gmail.com", false, 0.9m, false, null, "CHRISTOPHE.KOVACEK@GMAIL.COM", "JONAS_FRITSCH22", null, "242.324.0955 x897", false, "aee88626-e893-4832-951c-5f12d771085b", 3, false, "Jonas_Fritsch22" },
                    { "2", 0, 24, "e044cdc1-2c1f-4be7-b94c-0d522d4fb52b", "ApplicationUser", "Ewell20@yahoo.com", false, 2.6m, false, null, "EWELL20@YAHOO.COM", "ZOIE92", null, "940-816-5853 x1191", false, "86a4f262-6524-4f0d-9e54-0cc30d3799a0", 4, false, "Zoie92" },
                    { "20", 0, 76, "6e128190-bc7d-4cf7-b2be-cce5df69dd62", "ApplicationUser", "Monica.Collins88@yahoo.com", false, 1.8m, false, null, "MONICA.COLLINS88@YAHOO.COM", "SAMMY.TOY", null, "898.550.6760 x06058", false, "f673a00e-6f7b-433f-97d3-5ccf0519bc4c", 3, false, "Sammy.Toy" },
                    { "21", 0, 60, "58c2c3d3-2c21-4c9e-af6a-4e4926e784c9", "ApplicationUser", "Corbin.Swift@hotmail.com", false, 8.2m, false, null, "CORBIN.SWIFT@HOTMAIL.COM", "AHMED.HALEY70", null, "1-577-324-2723 x4653", false, "6bedb107-5624-4fa5-a195-fd6743e94a65", 4, false, "Ahmed.Haley70" },
                    { "22", 0, 47, "7ac11b41-2946-42f2-8c16-90ce2850ed83", "ApplicationUser", "Bernice.Zieme@yahoo.com", false, 9.4m, false, null, "BERNICE.ZIEME@YAHOO.COM", "ELINORE.HAMILL", null, "1-847-412-0166 x20738", false, "a1b39bce-255b-46c8-a38a-e193b435e4fe", 3, false, "Elinore.Hamill" },
                    { "23", 0, 59, "683acecd-4fff-4843-b806-c4188fa83395", "ApplicationUser", "Annalise78@gmail.com", false, 1.9m, false, null, "ANNALISE78@GMAIL.COM", "GERALDINE76", null, "1-430-245-2532 x821", false, "c2e013e0-c670-443e-bcd1-de7858caa0b3", 4, false, "Geraldine76" },
                    { "24", 0, 71, "b3f4991a-5741-423b-8b7c-65cf04a6f221", "ApplicationUser", "Hans_Walker@hotmail.com", false, 1.6m, false, null, "HANS_WALKER@HOTMAIL.COM", "BRENNA_TILLMAN40", null, "1-663-557-6458 x0691", false, "7d6f9300-7da3-4fe3-9be9-ef60b9beb3b0", 4, false, "Brenna_Tillman40" },
                    { "25", 0, 39, "5f1a7529-8317-48b9-a096-2c463f2f804a", "ApplicationUser", "Pierce76@gmail.com", false, 5.8m, false, null, "PIERCE76@GMAIL.COM", "EBBA_BARTELL69", null, "228-831-8065", false, "95096af8-3e23-4c1d-ae5e-9d878f7b6a52", 4, false, "Ebba_Bartell69" },
                    { "26", 0, 43, "c699fac9-9043-435d-8151-e5aa7c82705e", "ApplicationUser", "Elijah_Gutkowski68@hotmail.com", false, 9.0m, false, null, "ELIJAH_GUTKOWSKI68@HOTMAIL.COM", "JACKELINE.HANE78", null, "(287) 800-9956 x476", false, "23516ecb-25d2-4734-a6c0-9cff3646c3bd", 3, false, "Jackeline.Hane78" },
                    { "27", 0, 33, "e5fc3c13-885d-41ed-bf08-834a0cfef81d", "ApplicationUser", "Stephania30@gmail.com", false, 6.6m, false, null, "STEPHANIA30@GMAIL.COM", "GOLDA.GOTTLIEB", null, "748.636.7847", false, "a044524b-d3fb-471c-8762-6f443a5df80c", 4, false, "Golda.Gottlieb" },
                    { "28", 0, 42, "1562995d-5603-4bf3-946b-cbd872753f5f", "ApplicationUser", "Angelita_Schuster30@hotmail.com", false, 0.6m, false, null, "ANGELITA_SCHUSTER30@HOTMAIL.COM", "GABRIELLE_KRIS", null, "284.331.3068 x91575", false, "4fbb2847-f4c2-4d4b-b17c-b7baae1d8e3b", 2, false, "Gabrielle_Kris" },
                    { "29", 0, 66, "11750ac1-3392-46d6-9260-35142ac11ec7", "ApplicationUser", "Luisa_Roob@hotmail.com", false, 1.1m, false, null, "LUISA_ROOB@HOTMAIL.COM", "AMARA_POWLOWSKI", null, "471-528-8670", false, "ba704b4d-61ef-44c8-8474-379818f96e4d", 4, false, "Amara_Powlowski" },
                    { "3", 0, 43, "67512308-7360-4abc-80cf-de54778dc18b", "ApplicationUser", "Christy.Ullrich93@yahoo.com", false, 6.4m, false, null, "CHRISTY.ULLRICH93@YAHOO.COM", "ANIKA.POUROS", null, "414-290-8430 x441", false, "b9f11f3e-2e30-4baf-9a64-b3f14649075a", 4, false, "Anika.Pouros" },
                    { "30", 0, 33, "2b3de5da-4c81-4a56-aaea-3a1a0bdea1ba", "ApplicationUser", "Cara58@yahoo.com", false, 6.2m, false, null, "CARA58@YAHOO.COM", "CRISTOBAL_RITCHIE77", null, "(449) 263-5692 x9949", false, "6e0e5fd3-82cd-46b1-8625-48427d835000", 4, false, "Cristobal_Ritchie77" },
                    { "31", 0, 38, "4fa5009a-3b76-48c5-89ef-93ef7b61a6f7", "ApplicationUser", "Issac67@hotmail.com", false, 1.5m, false, null, "ISSAC67@HOTMAIL.COM", "MAGNUS.CUMMERATA38", null, "(782) 437-4628", false, "b8942868-7e01-4761-b415-b0644145e88e", 4, false, "Magnus.Cummerata38" },
                    { "32", 0, 29, "87e30f87-6a4e-4daa-93a0-d3b154497167", "ApplicationUser", "Leonora_Pfannerstill42@yahoo.com", false, 2.7m, false, null, "LEONORA_PFANNERSTILL42@YAHOO.COM", "JERROLD15", null, "218.557.0617", false, "680da117-4686-4c9f-b547-cb8818dfecb1", 4, false, "Jerrold15" },
                    { "33", 0, 51, "aee0d76e-8c6b-4705-b8a1-808400edf3e2", "ApplicationUser", "Oral64@hotmail.com", false, 6.5m, false, null, "ORAL64@HOTMAIL.COM", "ELIAN.BERNHARD30", null, "1-739-556-4185", false, "ee10e9b1-2eab-475b-a16a-758e4f11dbf3", 4, false, "Elian.Bernhard30" },
                    { "34", 0, 42, "c34c0ade-6119-4322-8fc6-3b8a0202b787", "ApplicationUser", "Milo98@yahoo.com", false, 3.4m, false, null, "MILO98@YAHOO.COM", "RAYMOND_WEST", null, "909.682.9866", false, "81637c1e-347e-4be6-97c4-007c4fbe670c", 4, false, "Raymond_West" },
                    { "35", 0, 45, "e554584b-88f1-4bd6-87e9-e1e22c4b7190", "ApplicationUser", "Lennie29@yahoo.com", false, 6.1m, false, null, "LENNIE29@YAHOO.COM", "FINN52", null, "234.308.6398 x193", false, "4734dc82-c664-453a-8d92-a2ef2d3d12bb", 2, false, "Finn52" },
                    { "36", 0, 20, "c6bca4a5-e901-49b2-9e51-f20744696109", "ApplicationUser", "Tomas90@yahoo.com", false, 8.7m, false, null, "TOMAS90@YAHOO.COM", "BROOKS_KUHN", null, "829.342.4528 x35606", false, "f3c0261c-4eab-463a-b165-e0513d4c4c70", 3, false, "Brooks_Kuhn" },
                    { "37", 0, 18, "982a15ac-b844-4994-ac15-49cef6081e6f", "ApplicationUser", "Alberto75@yahoo.com", false, 9.9m, false, null, "ALBERTO75@YAHOO.COM", "ELMORE_TORPHY44", null, "(466) 222-9087", false, "1d269db6-c181-4b5c-b0ee-eb50a1a279d7", 3, false, "Elmore_Torphy44" },
                    { "38", 0, 69, "da1232d0-b000-45ca-a93a-f5a4687aa66b", "ApplicationUser", "Marcella79@yahoo.com", false, 4.4m, false, null, "MARCELLA79@YAHOO.COM", "TRE_CRONIN85", null, "1-509-426-7617 x662", false, "7b9862e6-fb49-4bd9-9741-7c87de4013f5", 2, false, "Tre_Cronin85" },
                    { "39", 0, 76, "e9defdbd-ec91-4f6f-ae0b-c2950cfdc5dc", "ApplicationUser", "Idell_Ankunding@gmail.com", false, 6.3m, false, null, "IDELL_ANKUNDING@GMAIL.COM", "ROZELLA_KOVACEK71", null, "325-282-3912 x65303", false, "4fd89dfe-6fac-42f1-ae94-891f74bac38b", 3, false, "Rozella_Kovacek71" },
                    { "4", 0, 29, "93b6cfbb-1d67-4f68-acda-f055d97b787f", "ApplicationUser", "Conor7@gmail.com", false, 6.6m, false, null, "CONOR7@GMAIL.COM", "MARCELINA_SCHUPPE31", null, "722-707-9187", false, "ad7170c8-a0ab-4a39-a1cd-2a4732023923", 3, false, "Marcelina_Schuppe31" },
                    { "40", 0, 31, "31837b3f-7f09-485e-9c57-9d2bc190a62f", "ApplicationUser", "Freeman.Robel@gmail.com", false, 0.8m, false, null, "FREEMAN.ROBEL@GMAIL.COM", "DOUGLAS95", null, "207.711.7703 x73718", false, "191fb2c4-3934-42ed-9542-2becc67ab520", 3, false, "Douglas95" },
                    { "41", 0, 20, "e734858b-a294-4257-8f8a-5ca5ac83e83a", "ApplicationUser", "Devonte.Williamson@yahoo.com", false, 1.4m, false, null, "DEVONTE.WILLIAMSON@YAHOO.COM", "MYLENE_NITZSCHE", null, "891-399-5359 x89854", false, "78bb052b-90bb-4796-aea1-5194bf2dda4e", 4, false, "Mylene_Nitzsche" },
                    { "42", 0, 61, "78d1e9a7-d595-4ab9-a9f1-7c80554ec0bb", "ApplicationUser", "Emmie18@yahoo.com", false, 0.7m, false, null, "EMMIE18@YAHOO.COM", "CARSON.LANGOSH", null, "541.882.2046 x22100", false, "36a8040b-58fb-480a-8875-8676a2484bfc", 4, false, "Carson.Langosh" },
                    { "43", 0, 43, "b0fddc29-5051-474d-994b-9a2e8c7b3a4d", "ApplicationUser", "Savanah80@yahoo.com", false, 5.9m, false, null, "SAVANAH80@YAHOO.COM", "DESTIN30", null, "280.415.4384", false, "324f136f-cec9-479d-a23b-c82180a881c5", 3, false, "Destin30" },
                    { "44", 0, 67, "4646106c-136b-4bb6-906c-542226be0775", "ApplicationUser", "Virgie_Lehner@gmail.com", false, 8.2m, false, null, "VIRGIE_LEHNER@GMAIL.COM", "VICTOR_GERLACH61", null, "218.899.8808", false, "3a051a99-a264-4e01-9248-4260935a4585", 2, false, "Victor_Gerlach61" },
                    { "45", 0, 15, "b97281e6-770c-4282-9473-3aa76594000d", "ApplicationUser", "Albertha_Windler28@yahoo.com", false, 4.3m, false, null, "ALBERTHA_WINDLER28@YAHOO.COM", "LAMBERT7", null, "1-852-370-2630 x148", false, "62915c14-6ff1-41ce-afb7-197bfd3dc4f0", 1, false, "Lambert7" },
                    { "46", 0, 38, "0c74f5c8-548f-4f52-8849-78a9feeebfb3", "ApplicationUser", "Isidro_Friesen@hotmail.com", false, 4.7m, false, null, "ISIDRO_FRIESEN@HOTMAIL.COM", "SINCERE.KUNZE", null, "841.412.0608 x6925", false, "3c60a99b-09e1-46bd-8fc5-933fe6485989", 4, false, "Sincere.Kunze" },
                    { "47", 0, 52, "c1a88736-0849-48de-81b3-fd11c12a1727", "ApplicationUser", "Golden_Fay@gmail.com", false, 4.7m, false, null, "GOLDEN_FAY@GMAIL.COM", "ART_WATERS", null, "(797) 628-0803 x428", false, "dcfdd219-7042-4e58-8648-78d990c88c8d", 4, false, "Art_Waters" },
                    { "48", 0, 19, "e8666d41-af25-470e-8ebe-8502e8cb335f", "ApplicationUser", "Monroe72@hotmail.com", false, 5.4m, false, null, "MONROE72@HOTMAIL.COM", "ESTA63", null, "487-691-1105", false, "0324b2b3-c687-4161-8096-6155d9775384", 2, false, "Esta63" },
                    { "49", 0, 70, "f9c7ef37-1856-43fc-82d9-940d16765217", "ApplicationUser", "Rebekah.Rath15@hotmail.com", false, 9.1m, false, null, "REBEKAH.RATH15@HOTMAIL.COM", "HEATH.PURDY0", null, "362.476.2279 x387", false, "4d688f6c-7f17-4573-a192-e2ea1d7d28d7", 3, false, "Heath.Purdy0" },
                    { "5", 0, 69, "98b40d88-122d-4eac-a6bc-135784324bca", "ApplicationUser", "Caleigh_Sawayn46@hotmail.com", false, 8.4m, false, null, "CALEIGH_SAWAYN46@HOTMAIL.COM", "CHASITY.WUCKERT25", null, "1-444-946-7894", false, "e645c576-e27d-41cb-ab12-f326bfc0a730", 4, false, "Chasity.Wuckert25" },
                    { "50", 0, 69, "93e46266-61de-411b-82eb-1b83c8198469", "ApplicationUser", "Kameron88@gmail.com", false, 6.7m, false, null, "KAMERON88@GMAIL.COM", "JAYSON60", null, "491-602-2595", false, "29ba2221-00d3-49dc-b653-b0c035285e89", 4, false, "Jayson60" },
                    { "51", 0, 75, "9f9b8894-f033-4f0f-9fa0-dfd64acd4f52", "ApplicationUser", "Phoebe_Block@yahoo.com", false, 1.4m, false, null, "PHOEBE_BLOCK@YAHOO.COM", "JESUS.STRACKE", null, "1-520-593-1960 x630", false, "a2ff2be5-5005-486f-aa95-aebf9e75010f", 3, false, "Jesus.Stracke" },
                    { "52", 0, 56, "5a7abd86-19b0-48e7-9e43-680103fce25c", "ApplicationUser", "Delbert_Mann91@yahoo.com", false, 1.1m, false, null, "DELBERT_MANN91@YAHOO.COM", "ALVENA.SIPES", null, "821-854-6638", false, "256b8757-5599-495f-9fcf-808fa93df421", 4, false, "Alvena.Sipes" },
                    { "53", 0, 75, "6e926d11-d6a5-4eb8-9cf7-5f611c5e85ef", "ApplicationUser", "Horacio45@yahoo.com", false, 6.0m, false, null, "HORACIO45@YAHOO.COM", "TONI.DARE56", null, "1-482-868-8465", false, "4fab978e-5ebc-405f-927c-282aeff93ec1", 2, false, "Toni.Dare56" },
                    { "54", 0, 39, "f3ca0561-8fef-4767-be19-530c075a41e0", "ApplicationUser", "Sheila_Harvey60@gmail.com", false, 4.4m, false, null, "SHEILA_HARVEY60@GMAIL.COM", "WILMER57", null, "250.485.8864 x805", false, "24cd55e0-294e-487b-b172-444b46a07deb", 3, false, "Wilmer57" },
                    { "55", 0, 73, "537a9093-bb57-4271-a1a4-f0f0bf620369", "ApplicationUser", "Destini.Mante@hotmail.com", false, 9.3m, false, null, "DESTINI.MANTE@HOTMAIL.COM", "JACLYN_KOEPP", null, "917-277-8465", false, "77723de3-83a7-4e9d-9606-103e70611e6e", 4, false, "Jaclyn_Koepp" },
                    { "56", 0, 65, "19c8a22f-2069-4932-92aa-c78562633995", "ApplicationUser", "Delpha0@hotmail.com", false, 8.0m, false, null, "DELPHA0@HOTMAIL.COM", "SHEA.LOWE68", null, "1-340-640-7826 x3530", false, "40e9e68d-db69-4d45-a81c-8f5dd56621df", 3, false, "Shea.Lowe68" },
                    { "57", 0, 27, "9faf296a-5a26-4e05-8d36-f4fd25f4ee13", "ApplicationUser", "Kailee51@yahoo.com", false, 9.9m, false, null, "KAILEE51@YAHOO.COM", "CARY.LAKIN", null, "559-742-3066 x070", false, "57c453c8-7653-407e-9fe9-8d9941b8091f", 4, false, "Cary.Lakin" },
                    { "58", 0, 42, "d54ca15a-7afb-4290-9510-48182298cf40", "ApplicationUser", "Eloy_Wyman@gmail.com", false, 2.8m, false, null, "ELOY_WYMAN@GMAIL.COM", "ETHEL_KOCH25", null, "(442) 243-2434 x446", false, "abca7571-b8e9-4fbc-8607-f60bb255eebe", 2, false, "Ethel_Koch25" },
                    { "59", 0, 70, "6c277e2a-51f4-446f-a74e-c76c3886f9fa", "ApplicationUser", "Leonora.Graham@gmail.com", false, 1.1m, false, null, "LEONORA.GRAHAM@GMAIL.COM", "MURL.SCHULIST", null, "577-978-5411", false, "3a5efc24-c399-4d5d-b0cb-f3abffcb58ca", 2, false, "Murl.Schulist" },
                    { "6", 0, 60, "edbb6b6f-ef0b-46ca-8c5a-a36713dbc211", "ApplicationUser", "Alfreda36@yahoo.com", false, 7.3m, false, null, "ALFREDA36@YAHOO.COM", "ODIE.CROOKS64", null, "(766) 953-8689", false, "7afe725f-9fa5-4b70-90d3-55c3c2b319bf", 2, false, "Odie.Crooks64" },
                    { "60", 0, 39, "2fae7113-1c03-4dc4-b8e4-b631556bfce2", "ApplicationUser", "Rashad_Stiedemann@yahoo.com", false, 8.1m, false, null, "RASHAD_STIEDEMANN@YAHOO.COM", "JEANETTE_GREEN70", null, "1-774-499-4783 x937", false, "394010a4-0252-4486-ac40-c40bfbcb158b", 3, false, "Jeanette_Green70" },
                    { "61", 0, 79, "14c8f528-13ef-44a7-af04-caf84f42a93a", "ApplicationUser", "Stella.Steuber@yahoo.com", false, 3.8m, false, null, "STELLA.STEUBER@YAHOO.COM", "KAYLEE_SHIELDS63", null, "480-610-8270", false, "b6bb9971-f873-4891-8ba9-a32149509749", 2, false, "Kaylee_Shields63" },
                    { "62", 0, 77, "8c6cfe3a-6159-4c6a-90df-5279621afaa6", "ApplicationUser", "Myriam_Volkman42@yahoo.com", false, 6.2m, false, null, "MYRIAM_VOLKMAN42@YAHOO.COM", "EFFIE_MANN", null, "1-529-889-1470 x52572", false, "13cd57f6-fddf-44fe-993a-408c560a7b37", 4, false, "Effie_Mann" },
                    { "63", 0, 66, "8b1e1908-87f4-4310-ae22-bce41e750a3b", "ApplicationUser", "Maximillia.Cremin60@gmail.com", false, 8.9m, false, null, "MAXIMILLIA.CREMIN60@GMAIL.COM", "VAUGHN.HARRIS", null, "411-970-0134 x14632", false, "20f05598-4089-4fae-840b-95c5d31b492d", 3, false, "Vaughn.Harris" },
                    { "64", 0, 39, "ba74ebbe-6e02-450c-9281-b689cb92876b", "ApplicationUser", "Maud_Grimes13@yahoo.com", false, 3.4m, false, null, "MAUD_GRIMES13@YAHOO.COM", "CHRIS_TORPHY", null, "(315) 735-2205", false, "53ca2e7f-0634-4e2f-9f2d-62e62422ed52", 3, false, "Chris_Torphy" },
                    { "65", 0, 79, "e8346107-0604-430a-857f-706790925354", "ApplicationUser", "Evert.Brekke25@gmail.com", false, 6.9m, false, null, "EVERT.BREKKE25@GMAIL.COM", "WALTON24", null, "1-875-203-4649 x08700", false, "c6fb3682-84d6-496e-9f88-4ef824c3151d", 3, false, "Walton24" },
                    { "66", 0, 77, "3e0cf065-22e3-4bc9-a829-d5a09326432d", "ApplicationUser", "Jerad.Mante28@gmail.com", false, 8.5m, false, null, "JERAD.MANTE28@GMAIL.COM", "JACKIE_GERHOLD28", null, "(345) 541-8767 x309", false, "57323293-a2ad-4662-949b-01742b0cc3f4", 2, false, "Jackie_Gerhold28" },
                    { "67", 0, 12, "e0c66c22-f48d-4b47-8dbf-43a22ac0ab77", "ApplicationUser", "Clemens.Hackett88@yahoo.com", false, 3.4m, false, null, "CLEMENS.HACKETT88@YAHOO.COM", "CULLEN95", null, "1-849-602-1738", false, "e0ec4141-e82c-4fe4-9458-04414f4d4b74", 1, false, "Cullen95" },
                    { "68", 0, 27, "39504fe2-0ea3-4ddd-b9cf-58d90159b1eb", "ApplicationUser", "Alfred64@yahoo.com", false, 3.7m, false, null, "ALFRED64@YAHOO.COM", "MARCO.HELLER10", null, "1-246-360-2738 x1033", false, "520d296b-fb06-46b4-92dd-83aad448de48", 2, false, "Marco.Heller10" },
                    { "69", 0, 53, "65b77790-0a68-48c3-ad9e-c425ebc8fc66", "ApplicationUser", "Arthur.Wilderman@yahoo.com", false, 7.6m, false, null, "ARTHUR.WILDERMAN@YAHOO.COM", "JAYLAN.ANDERSON52", null, "686-797-6733", false, "963f0e68-a157-4941-86ac-2ac18f10e862", 2, false, "Jaylan.Anderson52" },
                    { "7", 0, 65, "700bc3a5-cce6-4cac-928c-7efc8f5a6cc4", "ApplicationUser", "Mervin_Schneider@yahoo.com", false, 4.9m, false, null, "MERVIN_SCHNEIDER@YAHOO.COM", "CLAUDINE.BAYER", null, "913.636.9219", false, "8249f406-7796-4804-b418-6c64ac7cf8a9", 3, false, "Claudine.Bayer" },
                    { "70", 0, 36, "ddbf9533-0e87-4a05-94ad-79f5472bee62", "ApplicationUser", "Chet89@hotmail.com", false, 3.4m, false, null, "CHET89@HOTMAIL.COM", "JOEY32", null, "883-709-0886", false, "67fa326e-4c9a-4eeb-8c3a-a9866aaf186b", 2, false, "Joey32" },
                    { "71", 0, 67, "996fa329-fc70-452e-af5f-c53ec232df60", "ApplicationUser", "Mateo84@hotmail.com", false, 1.5m, false, null, "MATEO84@HOTMAIL.COM", "BONITA86", null, "(703) 537-4485 x359", false, "957975e9-89a4-4d2e-a14e-3d484c9faff1", 2, false, "Bonita86" },
                    { "72", 0, 53, "863b4a92-216f-4ca3-8dd7-a953bea6c738", "ApplicationUser", "Brooklyn_Marquardt93@yahoo.com", false, 1.5m, false, null, "BROOKLYN_MARQUARDT93@YAHOO.COM", "JOVANNY.SCHADEN76", null, "(705) 461-2526 x46200", false, "fc0dd439-de7b-4058-a651-2bbd4126b254", 2, false, "Jovanny.Schaden76" },
                    { "73", 0, 60, "43387fd3-c73f-4664-961a-53390c89648a", "ApplicationUser", "Justyn.Brown84@hotmail.com", false, 5.1m, false, null, "JUSTYN.BROWN84@HOTMAIL.COM", "OVA0", null, "307.639.2189 x15740", false, "dc5bc79b-e69c-4f6a-ac1e-f342d6d3e8a8", 2, false, "Ova0" },
                    { "74", 0, 28, "1ff83904-d062-4a5e-bc11-fd9f1ba9218c", "ApplicationUser", "Rigoberto_Herzog68@gmail.com", false, 1.3m, false, null, "RIGOBERTO_HERZOG68@GMAIL.COM", "THEA.BLICK26", null, "1-423-889-6758", false, "8e136ce6-a260-484f-961e-340aa84bd89b", 4, false, "Thea.Blick26" },
                    { "75", 0, 16, "876270fa-d244-439c-b9ca-0ee0831801c1", "ApplicationUser", "Tianna_Green@yahoo.com", false, 1.5m, false, null, "TIANNA_GREEN@YAHOO.COM", "CARLI_TORP", null, "738-229-6750 x7013", false, "b91e9b7c-49de-48a0-8f1e-30cfcaf4ebd0", 1, false, "Carli_Torp" },
                    { "76", 0, 34, "58d90fbf-f2b7-4f75-adfd-dc2dffd8321a", "ApplicationUser", "Kayden_Frami@gmail.com", false, 7.9m, false, null, "KAYDEN_FRAMI@GMAIL.COM", "AIMEE_KUHLMAN49", null, "732.719.7271 x2384", false, "d5d0b737-b3d5-4d7a-9c1a-ca4c6bf5f9d6", 3, false, "Aimee_Kuhlman49" },
                    { "77", 0, 52, "84f602b6-bbe0-454d-b4be-f68a241bf10f", "ApplicationUser", "Ross_Bashirian@yahoo.com", false, 5.2m, false, null, "ROSS_BASHIRIAN@YAHOO.COM", "JOANY_ZBONCAK", null, "597.324.1116", false, "6965842d-20ac-4668-9f15-0440cdb82162", 2, false, "Joany_Zboncak" },
                    { "78", 0, 60, "4c5e66da-3b36-49eb-bc29-694a91315ead", "ApplicationUser", "Patsy_Crona@hotmail.com", false, 6.1m, false, null, "PATSY_CRONA@HOTMAIL.COM", "BRANDO_PARISIAN", null, "528-555-6431 x902", false, "4355009c-ddeb-4972-9310-d29f32633a16", 3, false, "Brando_Parisian" },
                    { "79", 0, 31, "2cb5d3dc-0733-4faa-a81e-da53b4e0870b", "ApplicationUser", "Ivy_Wolff@hotmail.com", false, 7.0m, false, null, "IVY_WOLFF@HOTMAIL.COM", "DELORES42", null, "315-482-5841 x65263", false, "ff5dcdad-e3b3-49a0-b146-6c968a43a1a7", 3, false, "Delores42" },
                    { "8", 0, 71, "799ebc47-4990-4cb1-b02e-f67efac5e884", "ApplicationUser", "Ken.DuBuque16@yahoo.com", false, 3.6m, false, null, "KEN.DUBUQUE16@YAHOO.COM", "DAMARIS16", null, "682-794-4456", false, "e5e84203-5de6-4aa6-9fde-e7a530d7fa82", 3, false, "Damaris16" },
                    { "80", 0, 73, "0574b704-9c16-41ab-a207-c8027c52bdc9", "ApplicationUser", "Jeffrey5@hotmail.com", false, 7.5m, false, null, "JEFFREY5@HOTMAIL.COM", "CASSIDY60", null, "1-438-761-0204", false, "deeb8df5-4926-43b6-98be-ae0ee50ac2d5", 2, false, "Cassidy60" },
                    { "81", 0, 26, "2b898a8b-65e3-4aa2-861a-5f56655bf01d", "ApplicationUser", "Marietta_Murphy@gmail.com", false, 6.1m, false, null, "MARIETTA_MURPHY@GMAIL.COM", "LUCIOUS.HOEGER12", null, "(750) 872-5841 x65322", false, "aa2190e4-43b5-425c-b7fb-be1179f5252a", 3, false, "Lucious.Hoeger12" },
                    { "82", 0, 70, "3398e8e3-f788-470c-a61e-e98ab5acf153", "ApplicationUser", "Bernie.Trantow@yahoo.com", false, 4.2m, false, null, "BERNIE.TRANTOW@YAHOO.COM", "HARRY.OBERBRUNNER94", null, "1-992-750-5202 x325", false, "a545b8ff-fb76-4a17-b856-4b5d6213d51f", 4, false, "Harry.Oberbrunner94" },
                    { "83", 0, 78, "4caa3dcf-db35-48c6-867b-a52d482ce91a", "ApplicationUser", "Sunny95@hotmail.com", false, 5.7m, false, null, "SUNNY95@HOTMAIL.COM", "RUBY52", null, "1-511-753-8469 x9797", false, "6c3098e2-c85d-413d-8039-fec7d34a6806", 3, false, "Ruby52" },
                    { "84", 0, 43, "36c15a50-f8fe-4ebc-85c1-02617779c826", "ApplicationUser", "Kyleigh64@yahoo.com", false, 0.8m, false, null, "KYLEIGH64@YAHOO.COM", "GRANVILLE73", null, "383.583.0810", false, "eca08087-1900-43fc-a6d3-bdee042877f4", 3, false, "Granville73" },
                    { "85", 0, 33, "037fc4ff-bd60-42a5-beb7-f8ccb18df398", "ApplicationUser", "Adrienne.Rippin62@hotmail.com", false, 5.9m, false, null, "ADRIENNE.RIPPIN62@HOTMAIL.COM", "CHRISTIANA74", null, "1-896-871-0439", false, "b8d6a4f2-901e-453a-958d-ba388be424b6", 4, false, "Christiana74" },
                    { "86", 0, 63, "f1aa9bb0-1e09-4e55-883f-a0591d8b49ad", "ApplicationUser", "Foster25@gmail.com", false, 2.5m, false, null, "FOSTER25@GMAIL.COM", "KOBE.HODKIEWICZ", null, "702-391-8321", false, "dae5fdc8-9481-43f9-972d-b41ae3f38610", 4, false, "Kobe.Hodkiewicz" },
                    { "87", 0, 47, "d2aea2bc-2f29-45fd-ae3d-3bbbb8cf521a", "ApplicationUser", "Aida_Altenwerth14@gmail.com", false, 4.7m, false, null, "AIDA_ALTENWERTH14@GMAIL.COM", "AARON.HEANEY", null, "1-798-521-9361", false, "98e06807-5434-49e9-ab76-33a0e998dc09", 2, false, "Aaron.Heaney" },
                    { "88", 0, 12, "6521f396-5513-4a94-9643-8ddd7c8c38f4", "ApplicationUser", "Karley48@hotmail.com", false, 7.5m, false, null, "KARLEY48@HOTMAIL.COM", "NONA44", null, "1-713-358-5251 x597", false, "b1085f98-8293-453b-9076-a82efbbf815c", 1, false, "Nona44" },
                    { "89", 0, 29, "8c5824a5-8b49-4cb7-b607-fcccf308b791", "ApplicationUser", "Bernie.Romaguera87@gmail.com", false, 9.8m, false, null, "BERNIE.ROMAGUERA87@GMAIL.COM", "KENDRICK68", null, "299-778-9775 x65766", false, "d8a59b9d-29ed-4e10-9d95-79b5af2eb0f7", 3, false, "Kendrick68" },
                    { "9", 0, 46, "9c785ad6-57b3-4490-9681-650e495a9e1a", "ApplicationUser", "Colleen_Smitham31@yahoo.com", false, 2.9m, false, null, "COLLEEN_SMITHAM31@YAHOO.COM", "FLOSSIE_BOYLE67", null, "1-441-495-8725 x0163", false, "76dc1f32-0a67-46db-a5d4-61fc68cd363e", 3, false, "Flossie_Boyle67" },
                    { "90", 0, 56, "e7cd48b5-50c9-4cfc-8de7-361539b35282", "ApplicationUser", "Edyth.Windler63@yahoo.com", false, 3.7m, false, null, "EDYTH.WINDLER63@YAHOO.COM", "ADELINE_GLEICHNER18", null, "680.584.4876 x4605", false, "e9a3a751-28d4-4fb8-8c3a-1c9eaffa8007", 3, false, "Adeline_Gleichner18" },
                    { "91", 0, 56, "14da64cf-5696-4d90-9ddc-5e82f8ac0872", "ApplicationUser", "Price10@yahoo.com", false, 1.0m, false, null, "PRICE10@YAHOO.COM", "CLIFTON.HOPPE", null, "(870) 520-7529", false, "320b296a-72b0-4c84-a9e1-76e04eac30fb", 3, false, "Clifton.Hoppe" },
                    { "92", 0, 79, "731c725d-131b-4f53-bd0a-0d666b0cbbd6", "ApplicationUser", "Jammie.Pollich@yahoo.com", false, 6.8m, false, null, "JAMMIE.POLLICH@YAHOO.COM", "MYRL.YOST", null, "674.886.2660 x25927", false, "9413b3aa-72e1-4d61-9e59-8adeeb53b380", 3, false, "Myrl.Yost" },
                    { "93", 0, 53, "ee521116-1d6d-43ce-a6db-e75b0ae9ec9e", "ApplicationUser", "Johann80@yahoo.com", false, 8.2m, false, null, "JOHANN80@YAHOO.COM", "SCOTTIE.AUER", null, "623.912.0146", false, "5a2fae89-6544-4990-a853-b73df7f3761d", 2, false, "Scottie.Auer" },
                    { "94", 0, 64, "56884666-1511-46e8-831b-a58fa298ab3e", "ApplicationUser", "Keaton_Hermann31@yahoo.com", false, 4.6m, false, null, "KEATON_HERMANN31@YAHOO.COM", "TRAVIS.GLOVER", null, "1-895-350-7272 x94784", false, "758e8530-aa6a-49fa-ad26-adc99f933b21", 4, false, "Travis.Glover" },
                    { "95", 0, 66, "68f4c583-77fe-4b34-a632-41454bd9404b", "ApplicationUser", "Michaela.Rempel@gmail.com", false, 6.6m, false, null, "MICHAELA.REMPEL@GMAIL.COM", "TREVOR.BEDNAR37", null, "464-735-7071 x31642", false, "48737ab1-69b7-4a2f-9eb6-ce3f1eff03ce", 2, false, "Trevor.Bednar37" },
                    { "96", 0, 58, "ec033f66-6d4b-4a63-8daa-791de55daf95", "ApplicationUser", "Devin38@yahoo.com", false, 6.4m, false, null, "DEVIN38@YAHOO.COM", "MARIELA.SIMONIS", null, "389.609.0318 x9907", false, "4dec10a1-387c-4288-9f02-922bf25fd745", 4, false, "Mariela.Simonis" },
                    { "97", 0, 53, "3721cd6c-306e-4182-8ca5-da5fad28618d", "ApplicationUser", "Duncan_Heller@yahoo.com", false, 3.2m, false, null, "DUNCAN_HELLER@YAHOO.COM", "STONE89", null, "(319) 542-2744", false, "dbcb5cac-218e-456b-ae59-be54a4f898c4", 4, false, "Stone89" },
                    { "98", 0, 31, "e930738b-5dd3-43f4-9027-6c6df7152a17", "ApplicationUser", "Napoleon_Nitzsche30@hotmail.com", false, 10.0m, false, null, "NAPOLEON_NITZSCHE30@HOTMAIL.COM", "ISOBEL32", null, "(392) 536-2631", false, "67d933a4-0d3f-442d-8596-6cd9fe9b3be4", 2, false, "Isobel32" },
                    { "99", 0, 15, "9a55f9ba-801d-4d86-bba5-b41d55c4cd47", "ApplicationUser", "Domenic_McKenzie@yahoo.com", false, 2.6m, false, null, "DOMENIC_MCKENZIE@YAHOO.COM", "MATTEO.EFFERTZ", null, "1-254-809-2461 x522", false, "620afb5c-830a-41ff-86fc-950276057291", 1, false, "Matteo.Effertz" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 15, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, "Awesome Granite Chips", null, 2015 },
                    { 2, 5, 5, "The Football Is Good For Training And Recreational Purposes", 1, "Handcrafted Concrete Tuna", null, 2022 },
                    { 3, 15, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 4, "Awesome Rubber Salad", null, 2015 },
                    { 4, 10, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Rustic Plastic Ball", null, 2016 },
                    { 5, 3, 1, "The Football Is Good For Training And Recreational Purposes", 9, "Incredible Fresh Chicken", null, 2022 },
                    { 6, 7, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9, "Handcrafted Rubber Soap", null, 2016 },
                    { 7, 12, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 10, "Small Frozen Shoes", null, 2020 },
                    { 8, 17, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Awesome Frozen Cheese", null, 2013 },
                    { 9, 1, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Incredible Cotton Cheese", null, 2010 },
                    { 10, 12, 1, "The Football Is Good For Training And Recreational Purposes", 10, "Handmade Wooden Sausages", null, 2023 },
                    { 11, 3, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Small Rubber Pizza", null, 2001 },
                    { 12, 12, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0, "Gorgeous Frozen Bacon", null, 2018 },
                    { 13, 12, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 8, "Rustic Cotton Shoes", null, 2011 },
                    { 14, 1, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Incredible Fresh Car", null, 2023 },
                    { 15, 9, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Practical Soft Ball", null, 2000 },
                    { 16, 3, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Gorgeous Plastic Salad", null, 2022 },
                    { 17, 5, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Generic Concrete Shirt", null, 2022 },
                    { 18, 5, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Sleek Wooden Computer", null, 2006 },
                    { 19, 10, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Tasty Plastic Pants", null, 2009 },
                    { 20, 2, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9, "Refined Fresh Table", null, 2017 },
                    { 21, 4, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Sleek Soft Mouse", null, 2006 },
                    { 22, 14, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 8, "Incredible Frozen Bacon", null, 2008 },
                    { 23, 2, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 5, "Unbranded Wooden Pants", null, 2010 },
                    { 24, 19, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Handcrafted Wooden Fish", null, 2012 },
                    { 25, 3, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 6, "Ergonomic Soft Sausages", null, 2015 },
                    { 26, 6, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Fantastic Cotton Shoes", null, 2002 },
                    { 27, 15, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, "Sleek Metal Salad", null, 2000 },
                    { 28, 10, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Refined Concrete Chips", null, 2001 },
                    { 29, 5, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Sleek Soft Car", null, 2015 },
                    { 30, 10, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 6, "Small Soft Cheese", null, 2017 },
                    { 31, 11, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, "Handcrafted Soft Towels", null, 2013 },
                    { 32, 13, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Generic Concrete Towels", null, 2013 },
                    { 33, 6, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 3, "Sleek Steel Fish", null, 2017 },
                    { 34, 3, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9, "Handmade Fresh Ball", null, 2008 },
                    { 35, 4, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Small Rubber Pizza", null, 2010 },
                    { 36, 12, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9, "Handcrafted Metal Gloves", null, 2015 },
                    { 37, 11, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, "Unbranded Frozen Sausages", null, 2008 },
                    { 38, 7, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, "Handmade Granite Shoes", null, 2006 },
                    { 39, 14, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Sleek Steel Bike", null, 2009 },
                    { 40, 9, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 0, "Fantastic Granite Fish", null, 2001 },
                    { 41, 7, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Practical Rubber Hat", null, 2004 },
                    { 42, 5, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, "Incredible Plastic Sausages", null, 2006 },
                    { 43, 17, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 2, "Rustic Steel Soap", null, 2010 },
                    { 44, 8, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Sleek Plastic Chair", null, 2011 },
                    { 45, 11, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 2, "Awesome Granite Soap", null, 2008 },
                    { 46, 9, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Tasty Soft Gloves", null, 2014 },
                    { 47, 18, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Intelligent Concrete Shoes", null, 2003 },
                    { 48, 14, 3, "The Football Is Good For Training And Recreational Purposes", 6, "Intelligent Cotton Soap", null, 2002 },
                    { 49, 8, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 0, "Incredible Metal Chair", null, 2013 },
                    { 50, 14, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Handcrafted Plastic Shoes", null, 2012 },
                    { 51, 11, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Unbranded Fresh Pants", null, 2015 },
                    { 52, 6, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, "Awesome Frozen Keyboard", null, 2012 },
                    { 53, 18, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Fantastic Fresh Bacon", null, 2013 },
                    { 54, 8, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Rustic Cotton Soap", null, 2014 },
                    { 55, 18, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 9, "Handcrafted Frozen Bike", null, 2013 },
                    { 56, 12, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 10, "Ergonomic Wooden Chicken", null, 2016 },
                    { 57, 4, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Sleek Soft Fish", null, 2019 },
                    { 58, 14, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Refined Concrete Table", null, 2020 },
                    { 59, 5, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Small Granite Chicken", null, 2001 },
                    { 60, 9, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Fantastic Granite Shoes", null, 2015 },
                    { 61, 6, 2, "The Football Is Good For Training And Recreational Purposes", 5, "Gorgeous Cotton Salad", null, 2016 },
                    { 62, 7, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, "Generic Soft Chair", null, 2004 },
                    { 63, 13, 5, "The Football Is Good For Training And Recreational Purposes", 8, "Refined Soft Ball", null, 2010 },
                    { 64, 2, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, "Unbranded Soft Bike", null, 2014 },
                    { 65, 3, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 6, "Gorgeous Plastic Soap", null, 2017 },
                    { 66, 9, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Sleek Cotton Bike", null, 2015 },
                    { 67, 11, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5, "Awesome Granite Sausages", null, 2020 },
                    { 68, 12, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Intelligent Fresh Tuna", null, 2003 },
                    { 69, 14, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Generic Steel Shirt", null, 2006 },
                    { 70, 1, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, "Practical Metal Shirt", null, 2005 },
                    { 71, 6, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Refined Steel Shirt", null, 2013 },
                    { 72, 9, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Unbranded Plastic Table", null, 2018 },
                    { 73, 17, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Practical Rubber Table", null, 2005 },
                    { 74, 18, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 8, "Sleek Plastic Bacon", null, 2013 },
                    { 75, 14, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Awesome Soft Tuna", null, 2002 },
                    { 76, 7, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1, "Unbranded Frozen Gloves", null, 2014 },
                    { 77, 15, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 4, "Licensed Soft Pizza", null, 2017 },
                    { 78, 1, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Handcrafted Steel Ball", null, 2014 },
                    { 79, 6, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Tasty Rubber Salad", null, 2007 },
                    { 80, 7, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Fantastic Wooden Tuna", null, 2017 },
                    { 81, 12, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 6, "Tasty Metal Computer", null, 2010 },
                    { 82, 12, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 2, "Gorgeous Granite Gloves", null, 2015 },
                    { 83, 11, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Rustic Fresh Sausages", null, 2000 },
                    { 84, 19, 5, "The Football Is Good For Training And Recreational Purposes", 8, "Practical Granite Cheese", null, 2006 },
                    { 85, 16, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 4, "Handmade Plastic Towels", null, 2012 },
                    { 86, 1, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Handcrafted Metal Hat", null, 2012 },
                    { 87, 12, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Sleek Steel Shirt", null, 2011 },
                    { 88, 15, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 0, "Tasty Wooden Chips", null, 2014 },
                    { 89, 14, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Sleek Rubber Fish", null, 2012 },
                    { 90, 8, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8, "Rustic Metal Mouse", null, 2014 },
                    { 91, 13, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9, "Generic Steel Car", null, 2007 },
                    { 92, 12, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Gorgeous Granite Chicken", null, 2020 },
                    { 93, 13, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 4, "Licensed Wooden Car", null, 2010 },
                    { 94, 15, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 5, "Small Fresh Soap", null, 2016 },
                    { 95, 14, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Refined Metal Cheese", null, 2011 },
                    { 96, 15, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Licensed Steel Bike", null, 2015 },
                    { 97, 16, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 6, "Handmade Soft Fish", null, 2023 },
                    { 98, 7, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Awesome Fresh Shoes", null, 2000 },
                    { 99, 18, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 7, "Gorgeous Plastic Towels", null, 2001 },
                    { 100, 2, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Practical Granite Towels", null, 2013 }
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
