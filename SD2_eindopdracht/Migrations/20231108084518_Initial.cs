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
                    { 1, "Tiana", "Miller" },
                    { 2, "Woodrow", "Beahan" },
                    { 3, "Chelsea", "Nicolas" },
                    { 4, "Linda", "Leffler" },
                    { 5, "Arch", "Harber" },
                    { 6, "Osvaldo", "Wyman" },
                    { 7, "Jan", "Grant" },
                    { 8, "Ignatius", "Hauck" },
                    { 9, "Marta", "Gorczany" },
                    { 10, "Ali", "Wintheiser" },
                    { 11, "Alberta", "Fisher" },
                    { 12, "Telly", "Wintheiser" },
                    { 13, "Watson", "Koelpin" },
                    { 14, "Tianna", "Mann" },
                    { 15, "Tracey", "Crona" },
                    { 16, "Yazmin", "Kunze" },
                    { 17, "Jessica", "Koss" },
                    { 18, "Jed", "Denesik" },
                    { 19, "Marietta", "Buckridge" },
                    { 20, "Jerry", "Schneider" }
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
                    { 2, 0.30m, 1, 10, 3, null, 18, "Budget", 0.35m, 1m, 10 },
                    { 3, 0.30m, 3, 10, 3, null, 18, "Basis", 0.25m, 4m, null },
                    { 4, 0m, 5, 20, 3, null, 18, "Top", 0m, 6m, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "Fine", "IsBlocked", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, 35, "9f2acb9f-1535-4240-b21b-ca7e2f49dc8b", "ApplicationUser", "Ervin_Schuppe32@yahoo.com", false, 5.3m, true, false, null, "ERVIN_SCHUPPE32@YAHOO.COM", "ELROY17", null, "(634) 403-8940 x1231", false, "85a42b56-c698-4f70-8932-be3a528bb74c", 2, false, "Elroy17" },
                    { "10", 0, 49, "f0ada528-5a35-40d2-b6b1-0a9a941d9056", "ApplicationUser", "Myrna.DAmore@gmail.com", false, 0.8m, false, false, null, "MYRNA.DAMORE@GMAIL.COM", "SIGMUND13", null, "727-324-3515 x2756", false, "96c13f4a-2123-4cf9-b8c8-fba92a9a99c3", 4, false, "Sigmund13" },
                    { "100", 0, 80, "d9feb886-b2ef-49b6-aa89-80915460e8b0", "ApplicationUser", "Ramiro_King2@yahoo.com", false, 0.4m, true, false, null, "RAMIRO_KING2@YAHOO.COM", "ABAGAIL_DIETRICH54", null, "1-922-348-2905", false, "65c908d2-c6d5-4e07-8e1e-62209197ab3e", 4, false, "Abagail_Dietrich54" },
                    { "11", 0, 71, "607ae065-a3a6-468c-b90f-933df4451ec8", "ApplicationUser", "Ona_Gulgowski17@hotmail.com", false, 4.0m, false, false, null, "ONA_GULGOWSKI17@HOTMAIL.COM", "MONSERRATE45", null, "1-699-736-1380 x60006", false, "5a35e637-c3e0-4928-895b-450016d8bb9a", 4, false, "Monserrate45" },
                    { "12", 0, 28, "6a2b1118-9138-48c4-be0a-ca4d4fc19ea9", "ApplicationUser", "Abagail_Purdy@yahoo.com", false, 5.5m, true, false, null, "ABAGAIL_PURDY@YAHOO.COM", "NOLA_PFEFFER", null, "887.294.3535", false, "076ad554-8c48-4300-96d6-814da3893a51", 3, false, "Nola_Pfeffer" },
                    { "13", 0, 47, "6fdd89ef-1e7a-4952-bee2-f9355afb286c", "ApplicationUser", "Ernest.Marquardt14@hotmail.com", false, 9.7m, true, false, null, "ERNEST.MARQUARDT14@HOTMAIL.COM", "GRAYCE.SCHULIST", null, "775-566-6379 x35287", false, "9f8ca2cc-428e-4d4c-81dc-c45b7ee32d0c", 3, false, "Grayce.Schulist" },
                    { "14", 0, 78, "4efb0de6-9ae5-4be6-8071-95c670674e77", "ApplicationUser", "Desiree5@yahoo.com", false, 5.1m, false, false, null, "DESIREE5@YAHOO.COM", "TRACEY.WALSH", null, "(443) 219-1149", false, "31b2d381-11ba-4fb1-a0f3-19dd0fd10bb6", 4, false, "Tracey.Walsh" },
                    { "15", 0, 44, "507a77c7-f6fb-44e3-8833-ea38a59226da", "ApplicationUser", "Pete.Kuhn1@yahoo.com", false, 7.2m, false, false, null, "PETE.KUHN1@YAHOO.COM", "OLA_WATSICA64", null, "512.370.3169", false, "7b3c6fc1-24f6-499d-9916-fddfcf39c165", 3, false, "Ola_Watsica64" },
                    { "16", 0, 13, "0b58acb2-1284-4dbf-9b9c-ee6d83b03907", "ApplicationUser", "Merlin.Mraz@yahoo.com", false, 6.8m, false, false, null, "MERLIN.MRAZ@YAHOO.COM", "DIEGO_CHAMPLIN", null, "(939) 232-3577 x5177", false, "a499c8dd-253a-4908-857c-3a483da35d5a", 1, false, "Diego_Champlin" },
                    { "17", 0, 78, "d138ec31-a80e-4984-bbcf-b6832bc605ce", "ApplicationUser", "Ramiro.Larkin@yahoo.com", false, 6.5m, false, false, null, "RAMIRO.LARKIN@YAHOO.COM", "LELAND.MERTZ23", null, "(365) 803-0363 x15944", false, "79a60914-c6ed-4311-b040-bb2807957f36", 2, false, "Leland.Mertz23" },
                    { "18", 0, 68, "bd797155-62eb-40c5-bf1f-b4bc816b65d7", "ApplicationUser", "Laverne_Welch@hotmail.com", false, 9.2m, true, false, null, "LAVERNE_WELCH@HOTMAIL.COM", "ELENORA.BECKER", null, "619-638-8856 x0502", false, "7e47b5d0-215a-4516-b595-c6e01b5eae3c", 2, false, "Elenora.Becker" },
                    { "19", 0, 15, "e0bb3f9b-82c5-4f20-96fd-e985d1f84a7f", "ApplicationUser", "Emerson3@yahoo.com", false, 6.7m, false, false, null, "EMERSON3@YAHOO.COM", "LAWSON77", null, "307.296.1492 x79687", false, "552523ab-3e94-49f0-ad6e-2bdaf6c966d2", 1, false, "Lawson77" },
                    { "2", 0, 39, "d76239e2-4d00-4f88-a078-e0fdca30fbd3", "ApplicationUser", "Sammy.Ondricka43@gmail.com", false, 0.2m, false, false, null, "SAMMY.ONDRICKA43@GMAIL.COM", "DENNIS.KUNZE49", null, "1-537-580-3950", false, "53cf7794-2c8e-40f9-a91f-029c8a6be3e1", 3, false, "Dennis.Kunze49" },
                    { "20", 0, 68, "d09519ae-a624-429d-867e-d091f9dbf4e5", "ApplicationUser", "Americo_Pagac32@gmail.com", false, 5.1m, true, false, null, "AMERICO_PAGAC32@GMAIL.COM", "NETTIE.HANE36", null, "1-545-440-9647", false, "8022c9e2-6f4b-4acc-9b05-ae1e10844cab", 3, false, "Nettie.Hane36" },
                    { "21", 0, 63, "1594f4ca-bdf6-4765-a3c0-078129a7c771", "ApplicationUser", "Coty.Wintheiser15@gmail.com", false, 4.0m, true, false, null, "COTY.WINTHEISER15@GMAIL.COM", "FRANCIS_GOTTLIEB14", null, "467.690.5458 x61048", false, "f4cdf88b-7161-453d-828e-0a594cd93b6b", 4, false, "Francis_Gottlieb14" },
                    { "22", 0, 23, "2f90b613-ae28-4b38-87fa-60b46505a9fc", "ApplicationUser", "Shanna.Kuphal91@yahoo.com", false, 8.3m, true, false, null, "SHANNA.KUPHAL91@YAHOO.COM", "EMMANUELLE.RATH70", null, "396-596-5244 x464", false, "47c44661-40ef-4137-83da-0d6c30724c50", 2, false, "Emmanuelle.Rath70" },
                    { "23", 0, 65, "aca8aad1-54e7-48a7-98da-6d8b1b5bd9b0", "ApplicationUser", "Otha.Kling@hotmail.com", false, 9.1m, true, false, null, "OTHA.KLING@HOTMAIL.COM", "SALMA.KOELPIN", null, "448.464.5522 x97546", false, "42569ba7-4cc8-4e78-bfda-80c1a89907a6", 3, false, "Salma.Koelpin" },
                    { "24", 0, 37, "470c8904-a643-4de4-9930-b015716a9106", "ApplicationUser", "Adeline_Wiegand28@gmail.com", false, 8.6m, false, false, null, "ADELINE_WIEGAND28@GMAIL.COM", "DONNA.JENKINS18", null, "1-688-210-9963 x700", false, "bf6f5716-9ab4-4611-b72e-2ffbf0861b32", 4, false, "Donna.Jenkins18" },
                    { "25", 0, 32, "f2217974-b314-42d1-a4f7-3f1029577e85", "ApplicationUser", "Alicia62@hotmail.com", false, 3.6m, true, false, null, "ALICIA62@HOTMAIL.COM", "BRANDI_CORWIN", null, "(282) 784-9369 x506", false, "f2ea4f38-9acd-489c-87ee-962d8d855409", 3, false, "Brandi_Corwin" },
                    { "26", 0, 47, "b732a78a-901c-4af9-825d-9204f646ac07", "ApplicationUser", "Harmony_Ward28@hotmail.com", false, 3.4m, true, false, null, "HARMONY_WARD28@HOTMAIL.COM", "BRIONNA.HAAG2", null, "(746) 724-9637 x1137", false, "4cd1e312-5ee9-4d5f-a632-a31f28163e75", 4, false, "Brionna.Haag2" },
                    { "27", 0, 57, "27375b52-3255-4bda-8fdf-a684a77a68a8", "ApplicationUser", "Santos26@hotmail.com", false, 7.4m, false, false, null, "SANTOS26@HOTMAIL.COM", "TIA.BASHIRIAN3", null, "1-307-291-8278 x461", false, "91217a77-c1d7-47d2-a2dc-369d7875dc73", 3, false, "Tia.Bashirian3" },
                    { "28", 0, 24, "186d9321-1287-434b-8c14-2d1070027c8f", "ApplicationUser", "Tania_McKenzie@yahoo.com", false, 6.4m, true, false, null, "TANIA_MCKENZIE@YAHOO.COM", "ISOBEL92", null, "508-353-0926", false, "d82a905e-d00f-4e32-b4ca-72662fe6805b", 4, false, "Isobel92" },
                    { "29", 0, 77, "fab23615-1f31-44dc-a24b-29cb0728b2bf", "ApplicationUser", "Adonis14@yahoo.com", false, 9.6m, true, false, null, "ADONIS14@YAHOO.COM", "KRISTOFER13", null, "1-453-689-5119", false, "d159d1a4-65ce-4f47-a303-9f8424c2e295", 4, false, "Kristofer13" },
                    { "3", 0, 52, "089e415d-cc00-4f58-8c71-d57f1510f07e", "ApplicationUser", "Jordon74@gmail.com", false, 8.0m, false, false, null, "JORDON74@GMAIL.COM", "MAURINE_BEER", null, "1-378-890-6002", false, "722e2f6a-3371-421b-be76-5a53b1a2c3b5", 3, false, "Maurine_Beer" },
                    { "30", 0, 20, "83f5e4cb-ad23-4725-8049-734d34dc12c3", "ApplicationUser", "Nicola_Wuckert@yahoo.com", false, 5.7m, true, false, null, "NICOLA_WUCKERT@YAHOO.COM", "VIVIEN_TURNER", null, "1-479-681-1329", false, "f75ec207-c999-4076-9ce0-5de293614cc6", 4, false, "Vivien_Turner" },
                    { "31", 0, 37, "37918cd5-ef4d-4f2e-b839-29616e1cd2bf", "ApplicationUser", "Wilhelm_Wiza65@yahoo.com", false, 5.1m, false, false, null, "WILHELM_WIZA65@YAHOO.COM", "ZACHARY_GIBSON11", null, "499.663.7390", false, "2443495d-527e-4b2c-990d-da46540d78b2", 2, false, "Zachary_Gibson11" },
                    { "32", 0, 32, "ca8795cb-fd87-4eca-9ac6-e7acb5d6b4c4", "ApplicationUser", "Leilani53@yahoo.com", false, 2.3m, false, false, null, "LEILANI53@YAHOO.COM", "THERESA_CUMMERATA", null, "1-396-420-8023 x775", false, "4af37bfd-562f-4f7e-baae-b4f4f2902a96", 4, false, "Theresa_Cummerata" },
                    { "33", 0, 79, "596bc1b1-ae0b-453e-8beb-db07ef8118fd", "ApplicationUser", "Vladimir_Ferry@gmail.com", false, 5.6m, true, false, null, "VLADIMIR_FERRY@GMAIL.COM", "KEELEY_OCONNER", null, "(485) 695-5557", false, "9546d539-fb40-4fcf-91df-bab72ac3420e", 2, false, "Keeley_OConner" },
                    { "34", 0, 22, "a0b22758-4df5-4ce8-a14f-aed1195816b3", "ApplicationUser", "Jesus.Mante89@gmail.com", false, 4.6m, false, false, null, "JESUS.MANTE89@GMAIL.COM", "BERTA_JERDE", null, "588-527-8448 x6271", false, "7f1dd9df-8d72-42b2-b0a4-e3db78dfab7f", 2, false, "Berta_Jerde" },
                    { "35", 0, 22, "3df375bf-1bac-4b8d-b363-36edbab8b7f5", "ApplicationUser", "Damon33@gmail.com", false, 3.7m, false, false, null, "DAMON33@GMAIL.COM", "TORREY_GUSIKOWSKI70", null, "333.419.8748 x2408", false, "bf632648-2e37-431c-bf53-794b9044499b", 2, false, "Torrey_Gusikowski70" },
                    { "36", 0, 80, "45345c84-1586-4d1a-be2e-04e7d8b6de9d", "ApplicationUser", "Rahul_Beahan@hotmail.com", false, 7.6m, false, false, null, "RAHUL_BEAHAN@HOTMAIL.COM", "KAIA_MULLER10", null, "(704) 803-2077", false, "5a3e0b44-71e3-42b5-b8bd-cdeb52689bce", 3, false, "Kaia_Muller10" },
                    { "37", 0, 66, "e4cf7f13-cdcb-42cf-8fd1-2ace799dcbda", "ApplicationUser", "Teresa.Hegmann@gmail.com", false, 5.5m, false, false, null, "TERESA.HEGMANN@GMAIL.COM", "TESSIE_CHRISTIANSEN", null, "1-719-946-1512 x4488", false, "4540b544-696d-429c-9d7d-858933f17ca6", 2, false, "Tessie_Christiansen" },
                    { "38", 0, 47, "409b30d1-ba89-48cf-944f-9a1a35085c85", "ApplicationUser", "Burnice29@yahoo.com", false, 5.3m, false, false, null, "BURNICE29@YAHOO.COM", "KATHLYN.GREENFELDER11", null, "(528) 463-5643 x674", false, "8ac3df12-5824-46c4-846a-9d09890d9a76", 2, false, "Kathlyn.Greenfelder11" },
                    { "39", 0, 57, "cdd78509-2b7c-4560-8ff6-6b73cbd5a963", "ApplicationUser", "Madeline.Green74@hotmail.com", false, 8.4m, true, false, null, "MADELINE.GREEN74@HOTMAIL.COM", "SAMARA89", null, "(623) 684-1638", false, "d7146182-16c0-4ff7-a802-e5b5ee51c736", 3, false, "Samara89" },
                    { "4", 0, 48, "5770412c-046e-4707-96f1-b018b2380cb0", "ApplicationUser", "Trenton.Pagac@yahoo.com", false, 6.1m, true, false, null, "TRENTON.PAGAC@YAHOO.COM", "LUTHER_HOPPE", null, "296.479.9145", false, "2c5c69e8-da27-4d53-b3ba-44f794e86dd6", 4, false, "Luther_Hoppe" },
                    { "40", 0, 36, "f65d5d26-b06a-4f19-92f3-91ce4552ab4c", "ApplicationUser", "Adeline_Pfeffer@hotmail.com", false, 4.2m, false, false, null, "ADELINE_PFEFFER@HOTMAIL.COM", "VELLA65", null, "476.390.5056 x302", false, "159feffb-dc62-44e4-912d-05e7b8ad2acd", 4, false, "Vella65" },
                    { "41", 0, 30, "3dfcf6f8-a220-47f3-9676-f61700d8f34f", "ApplicationUser", "Ilene_Kessler@hotmail.com", false, 4.9m, true, false, null, "ILENE_KESSLER@HOTMAIL.COM", "JORDANE.ALTENWERTH", null, "(369) 778-9757 x0619", false, "9173b0ff-a01d-4fa2-a537-8b2149c4c9f1", 3, false, "Jordane.Altenwerth" },
                    { "42", 0, 45, "45b8c32a-1ad5-478a-a9f5-dde4d458cee2", "ApplicationUser", "Mathew.Bergstrom53@hotmail.com", false, 5.8m, true, false, null, "MATHEW.BERGSTROM53@HOTMAIL.COM", "JUSTON.JACOBI86", null, "693.954.5694", false, "8121490e-28ad-4219-93ea-6f812733cc09", 2, false, "Juston.Jacobi86" },
                    { "43", 0, 62, "dc4d595f-36d3-4963-8632-7e7761f54159", "ApplicationUser", "Mathilde_Luettgen@gmail.com", false, 2.8m, false, false, null, "MATHILDE_LUETTGEN@GMAIL.COM", "CALISTA72", null, "(384) 435-7843", false, "a0ef187b-7f03-4043-b603-00ba0ee546c3", 2, false, "Calista72" },
                    { "44", 0, 70, "67473a53-a8d7-4b57-9709-632179183314", "ApplicationUser", "Bonita_Wilkinson@hotmail.com", false, 6.3m, false, false, null, "BONITA_WILKINSON@HOTMAIL.COM", "OSVALDO_SATTERFIELD", null, "829.465.1546", false, "9f4a9151-c7c9-426c-a9aa-16fb0d3e512a", 4, false, "Osvaldo_Satterfield" },
                    { "45", 0, 35, "03ea8929-251f-42ad-a799-b5d2f664b301", "ApplicationUser", "Velma_Mueller@hotmail.com", false, 8.9m, true, false, null, "VELMA_MUELLER@HOTMAIL.COM", "JAYDA15", null, "(867) 453-9184 x41320", false, "c601e9cb-c5bb-4d25-8a7f-47bb4057feab", 2, false, "Jayda15" },
                    { "46", 0, 25, "28fb989c-766b-46a6-b17e-8224e3163cdc", "ApplicationUser", "Garrick_Brakus@gmail.com", false, 6.3m, true, false, null, "GARRICK_BRAKUS@GMAIL.COM", "NETTIE_CUMMINGS13", null, "968-744-8736 x387", false, "3f553836-8af4-42b1-a34d-fa8a24672729", 4, false, "Nettie_Cummings13" },
                    { "47", 0, 51, "e04d04b4-bc0f-4b99-96b1-58baa9bc468b", "ApplicationUser", "Anabelle.Windler@yahoo.com", false, 3.0m, false, false, null, "ANABELLE.WINDLER@YAHOO.COM", "JUDE_SHIELDS", null, "728.216.5234", false, "4fd6e9b7-12bd-4f36-854c-4de5d4bb56da", 3, false, "Jude_Shields" },
                    { "48", 0, 59, "85793ef0-0a94-40fe-b3c2-6fc6a0942d47", "ApplicationUser", "Joshua_Lang23@yahoo.com", false, 4.1m, true, false, null, "JOSHUA_LANG23@YAHOO.COM", "ELMORE_GAYLORD1", null, "484-254-8964 x0557", false, "086f66e3-fa94-456f-a304-0d8996b111dd", 2, false, "Elmore_Gaylord1" },
                    { "49", 0, 71, "c2f49392-6169-446f-bd44-381b51da14ab", "ApplicationUser", "Roma_Schamberger@gmail.com", false, 3.3m, true, false, null, "ROMA_SCHAMBERGER@GMAIL.COM", "MATILDA69", null, "586-969-6277 x250", false, "0023f7f5-26f0-4c47-9717-907f48d17355", 3, false, "Matilda69" },
                    { "5", 0, 71, "2d8806ec-a30e-4fb1-86a4-b2df78403298", "ApplicationUser", "Arvid_Bechtelar97@yahoo.com", false, 6.7m, false, false, null, "ARVID_BECHTELAR97@YAHOO.COM", "ROSALIA.KASSULKE", null, "1-667-269-4422", false, "1dea0dc2-9e56-44e7-ad37-dc72cececb42", 3, false, "Rosalia.Kassulke" },
                    { "50", 0, 69, "babddf8e-bc6a-413b-986c-810990655869", "ApplicationUser", "Russ.Oberbrunner@yahoo.com", false, 9.8m, false, false, null, "RUSS.OBERBRUNNER@YAHOO.COM", "RUBY72", null, "(770) 357-5805 x74803", false, "39299b8f-109b-429d-a514-41b2f72b2538", 2, false, "Ruby72" },
                    { "51", 0, 38, "5661d25c-7b22-4092-8190-4abd8478d85c", "ApplicationUser", "Hardy_Cronin@gmail.com", false, 4.8m, false, false, null, "HARDY_CRONIN@GMAIL.COM", "GREGORIA_KUVALIS", null, "982-650-5054 x50522", false, "5e6cfb92-8e8f-4db3-9ecb-ff0ac6318dbd", 2, false, "Gregoria_Kuvalis" },
                    { "52", 0, 28, "a43386e4-ef1d-4e9e-8285-359f88c7eaa9", "ApplicationUser", "Hosea.Lesch@yahoo.com", false, 8.4m, false, false, null, "HOSEA.LESCH@YAHOO.COM", "ELIAS74", null, "531.964.4688 x5529", false, "d01b1d86-d94b-473d-aa89-ed2ea726b9e2", 4, false, "Elias74" },
                    { "53", 0, 39, "76762af4-4f51-4ed3-9bb2-213f69e3f443", "ApplicationUser", "Alessandra_Metz@hotmail.com", false, 5.2m, true, false, null, "ALESSANDRA_METZ@HOTMAIL.COM", "JAIDEN82", null, "397-387-0609 x21355", false, "6f493692-3b7c-4796-b36d-04edc8a386ff", 4, false, "Jaiden82" },
                    { "54", 0, 67, "b101dd6f-dd41-478d-be7c-e655dcc6609e", "ApplicationUser", "Elva.Schneider@yahoo.com", false, 7.9m, false, false, null, "ELVA.SCHNEIDER@YAHOO.COM", "BRADEN77", null, "208.794.3449 x9626", false, "e71bf577-2c30-4e37-adc4-f31f4db1167b", 2, false, "Braden77" },
                    { "55", 0, 14, "5ad37221-67fe-4d1d-9904-b7f40ad42530", "ApplicationUser", "Rupert_Lynch66@yahoo.com", false, 4.9m, false, false, null, "RUPERT_LYNCH66@YAHOO.COM", "SHEILA33", null, "(872) 570-6070", false, "eb0da690-ab19-439a-af6e-b779c1a5d7e8", 1, false, "Sheila33" },
                    { "56", 0, 37, "61beb01a-5cc6-45d0-ba99-dc0c3677ff25", "ApplicationUser", "Damon65@gmail.com", false, 1.7m, false, false, null, "DAMON65@GMAIL.COM", "CARLEY_WIEGAND93", null, "987.231.3748", false, "13670d30-c98b-4e63-9bfd-aeade98d608f", 2, false, "Carley_Wiegand93" },
                    { "57", 0, 67, "909e42f1-d3ac-4b49-bd84-3eedc4868a7f", "ApplicationUser", "Kim_Kihn39@yahoo.com", false, 9.9m, true, false, null, "KIM_KIHN39@YAHOO.COM", "MACKENZIE_SCHOEN90", null, "636-549-0670 x36814", false, "9d848c35-30e9-4dbd-897c-81fde447a571", 2, false, "Mackenzie_Schoen90" },
                    { "58", 0, 76, "cad771d0-0467-4fdd-8443-ab53d901b9f9", "ApplicationUser", "Gregory.Ritchie67@yahoo.com", false, 8.2m, false, false, null, "GREGORY.RITCHIE67@YAHOO.COM", "LUCAS.EFFERTZ", null, "1-942-353-3095", false, "514ad664-745b-4696-abc0-2aa60565d5f3", 3, false, "Lucas.Effertz" },
                    { "59", 0, 55, "b28078d6-c7de-4635-bea1-14c0badbcbc8", "ApplicationUser", "Aaliyah.Conroy@gmail.com", false, 7.9m, false, false, null, "AALIYAH.CONROY@GMAIL.COM", "MATILDE51", null, "1-556-853-5902", false, "bc62189e-e281-4371-b82c-190330aa8d5a", 3, false, "Matilde51" },
                    { "6", 0, 22, "84e367c9-9ab4-441c-b66e-9c9637c2e06a", "ApplicationUser", "Gregg0@hotmail.com", false, 4.3m, false, false, null, "GREGG0@HOTMAIL.COM", "CAROLE.KLOCKO", null, "990.232.7360", false, "87e674cd-7ee7-49df-8376-17dc301aa820", 4, false, "Carole.Klocko" },
                    { "60", 0, 39, "140a6ec6-c740-4996-a793-9ba0b8a30da2", "ApplicationUser", "William9@gmail.com", false, 7.8m, true, false, null, "WILLIAM9@GMAIL.COM", "KENNETH.TURCOTTE64", null, "576-630-3345", false, "087889c3-df89-45e8-a173-ab147f127f8f", 2, false, "Kenneth.Turcotte64" },
                    { "61", 0, 45, "a668a8f9-22eb-4133-83a3-fb997e431266", "ApplicationUser", "Lavinia44@hotmail.com", false, 9.9m, false, false, null, "LAVINIA44@HOTMAIL.COM", "HELEN.TOY", null, "1-465-295-6784 x46573", false, "1eead7eb-7719-4fa6-8798-114238b3e3c0", 2, false, "Helen.Toy" },
                    { "62", 0, 52, "4cdc61c4-085d-476e-88d8-f0ccea74a82b", "ApplicationUser", "Noah22@hotmail.com", false, 7.5m, true, false, null, "NOAH22@HOTMAIL.COM", "ROGER46", null, "510.658.6522 x717", false, "8e47f310-9fac-4d83-869e-a5b642bb26ca", 4, false, "Roger46" },
                    { "63", 0, 71, "a3a7813b-ab58-43ac-9ec0-ef35b5ca51d1", "ApplicationUser", "Idell_Crooks@yahoo.com", false, 3.1m, true, false, null, "IDELL_CROOKS@YAHOO.COM", "CONNOR8", null, "1-956-778-4500", false, "b5cccf9c-4e4c-4173-8b3b-d868d0ce9644", 2, false, "Connor8" },
                    { "64", 0, 51, "196e283d-06b1-469d-bc5e-412cc0994b63", "ApplicationUser", "Mara_Thompson@gmail.com", false, 8.1m, false, false, null, "MARA_THOMPSON@GMAIL.COM", "DORIS84", null, "(476) 979-7580 x8305", false, "f64928e0-8fe3-40b9-ae3e-c58fee26b8a8", 4, false, "Doris84" },
                    { "65", 0, 37, "240093e0-931e-4a15-9a62-9dd430708860", "ApplicationUser", "Mac.Lakin@yahoo.com", false, 4.6m, true, false, null, "MAC.LAKIN@YAHOO.COM", "LEXI_GUTMANN", null, "874.752.8363", false, "3d6ba952-f103-4a46-b4ec-fdf9db978241", 3, false, "Lexi_Gutmann" },
                    { "66", 0, 41, "eb268a8a-fc44-41ab-b450-379fcd4643ad", "ApplicationUser", "Zora.Nader@gmail.com", false, 2.3m, true, false, null, "ZORA.NADER@GMAIL.COM", "JAYDA11", null, "(988) 560-3997 x89333", false, "e4a5d6d9-d0e5-4f25-bcbc-fd575cf0c371", 2, false, "Jayda11" },
                    { "67", 0, 35, "14ca66c7-a732-444a-8c0c-fd7872809400", "ApplicationUser", "Willy21@gmail.com", false, 0.9m, false, false, null, "WILLY21@GMAIL.COM", "GARETT.HAUCK", null, "728.599.1000", false, "cac28ddd-05b4-4558-9853-117e53fbe7b3", 4, false, "Garett.Hauck" },
                    { "68", 0, 64, "bdf7660c-617b-4c7d-a590-b59b603b82fd", "ApplicationUser", "Leo_Deckow59@yahoo.com", false, 3.5m, true, false, null, "LEO_DECKOW59@YAHOO.COM", "BRODY_BECHTELAR", null, "411.839.8654", false, "6b85251d-4cbe-4bb5-a4fc-373ac96bb78b", 2, false, "Brody_Bechtelar" },
                    { "69", 0, 79, "f32f5c5d-1032-4ed9-afbe-21bcd47fbaaa", "ApplicationUser", "Janessa.Homenick24@yahoo.com", false, 6.7m, true, false, null, "JANESSA.HOMENICK24@YAHOO.COM", "VERONICA.ROSENBAUM54", null, "(728) 901-6648 x2859", false, "ee22fb6d-af04-4137-9c17-200270b4ca53", 2, false, "Veronica.Rosenbaum54" },
                    { "7", 0, 65, "cc63eba3-d075-4564-8867-938f024c653c", "ApplicationUser", "Pansy.Kuhn92@gmail.com", false, 7.7m, false, false, null, "PANSY.KUHN92@GMAIL.COM", "FELIPA68", null, "533.927.9503 x4871", false, "8977eadd-ab38-46fd-98d9-e73b257af2ea", 4, false, "Felipa68" },
                    { "70", 0, 39, "65a29a4a-8e43-4281-99b6-5b78266bb700", "ApplicationUser", "Micaela.Homenick@gmail.com", false, 9.2m, false, false, null, "MICAELA.HOMENICK@GMAIL.COM", "GEORGIANNA.KEEBLER67", null, "1-397-944-9589 x2420", false, "cf48f88e-c247-4268-9610-a394df5e8516", 2, false, "Georgianna.Keebler67" },
                    { "71", 0, 42, "a3414256-1a37-4543-a6c1-09d7bf9a92f2", "ApplicationUser", "Lambert.McClure69@hotmail.com", false, 1.4m, false, false, null, "LAMBERT.MCCLURE69@HOTMAIL.COM", "KIRA.STANTON82", null, "(543) 607-5895", false, "ad2052cf-8bc4-476e-9056-3894d5f944a3", 3, false, "Kira.Stanton82" },
                    { "72", 0, 18, "8e841b4d-3d39-42fd-b74d-ed21b2073510", "ApplicationUser", "Rachel.Kuhlman62@yahoo.com", false, 10.0m, true, false, null, "RACHEL.KUHLMAN62@YAHOO.COM", "ETHELYN.WOLFF7", null, "1-305-926-9554", false, "bdf310ab-5845-4e8a-9489-d53a8576da25", 2, false, "Ethelyn.Wolff7" },
                    { "73", 0, 64, "ba9ea657-1d3f-4508-9fc0-5aac833e31f6", "ApplicationUser", "Brendon.Dare26@gmail.com", false, 0.0m, false, false, null, "BRENDON.DARE26@GMAIL.COM", "ADAH90", null, "(387) 910-8285 x55273", false, "ca19edd8-841d-4f23-a040-e813fbc19149", 4, false, "Adah90" },
                    { "74", 0, 50, "5f28e297-5c52-4d1d-aebf-4b5c7bda51e1", "ApplicationUser", "Eloise38@gmail.com", false, 4.2m, true, false, null, "ELOISE38@GMAIL.COM", "REUBEN30", null, "1-871-428-9477 x843", false, "9d3f94c6-7dfb-4c83-be45-2e66a7481a21", 2, false, "Reuben30" },
                    { "75", 0, 60, "50c207da-ac10-4e81-9a54-747f131355cf", "ApplicationUser", "Helen.Herzog@gmail.com", false, 2.2m, false, false, null, "HELEN.HERZOG@GMAIL.COM", "MALVINA88", null, "(238) 776-6190 x4656", false, "de0dfeae-d162-45ff-8c76-935dc0abab55", 3, false, "Malvina88" },
                    { "76", 0, 47, "ba6b8f6d-f30c-431e-ba6f-9730616211bb", "ApplicationUser", "Dessie.Tillman@gmail.com", false, 1.6m, false, false, null, "DESSIE.TILLMAN@GMAIL.COM", "HOLDEN_BAYER", null, "695.849.3755", false, "7a89666e-6c81-409d-a529-781060db1ad7", 3, false, "Holden_Bayer" },
                    { "77", 0, 77, "ddaab013-6f92-4b67-83bc-002c34a44eb1", "ApplicationUser", "Aaron.Parker27@yahoo.com", false, 1.1m, false, false, null, "AARON.PARKER27@YAHOO.COM", "FRANCIS_KING", null, "(890) 953-0088", false, "808fe01d-a5b1-4b64-b6e0-d50bade3dccb", 2, false, "Francis_King" },
                    { "78", 0, 29, "1d4dc3e7-0e93-4b9c-888a-0173f47d284d", "ApplicationUser", "Jarrell.Waters@gmail.com", false, 3.5m, true, false, null, "JARRELL.WATERS@GMAIL.COM", "VINCENZA.LEFFLER", null, "1-367-373-5025", false, "d2994fa5-4837-40d8-a0e8-75a944231990", 2, false, "Vincenza.Leffler" },
                    { "79", 0, 14, "6567f61a-0650-409d-b047-d71960685594", "ApplicationUser", "Melba17@gmail.com", false, 3.6m, true, false, null, "MELBA17@GMAIL.COM", "OLEN_ROBERTS89", null, "526-798-7906", false, "882fce97-74d7-47cd-9142-6db87bba3bbd", 1, false, "Olen_Roberts89" },
                    { "8", 0, 40, "9429f57f-f2c8-40f2-99c3-bb6f00ef0212", "ApplicationUser", "Enrico51@gmail.com", false, 0.8m, false, false, null, "ENRICO51@GMAIL.COM", "DEONDRE.JERDE2", null, "(584) 605-3960", false, "066a794d-8805-402b-80f5-b80a2bce6229", 3, false, "Deondre.Jerde2" },
                    { "80", 0, 44, "05a0341d-3a00-42dc-978c-83a73c63031e", "ApplicationUser", "Ardella42@gmail.com", false, 7.3m, true, false, null, "ARDELLA42@GMAIL.COM", "DESMOND_FRITSCH79", null, "296.740.4965 x8850", false, "201151b2-eb00-4889-bafb-0e4aa8067f9c", 2, false, "Desmond_Fritsch79" },
                    { "81", 0, 74, "6fd3a474-b09c-488e-93c2-51eb2800882a", "ApplicationUser", "Miller.Kreiger16@yahoo.com", false, 4.2m, true, false, null, "MILLER.KREIGER16@YAHOO.COM", "CRISTIAN16", null, "745-833-9401 x73052", false, "5e1b8d96-fc5f-4d5f-a149-ed355edb0f86", 3, false, "Cristian16" },
                    { "82", 0, 70, "7b9d65ee-8edb-4e91-bd12-71338e8fac05", "ApplicationUser", "Hilbert_Altenwerth@hotmail.com", false, 9.0m, false, false, null, "HILBERT_ALTENWERTH@HOTMAIL.COM", "ALDEN43", null, "1-461-545-8788", false, "f39b91e9-5eae-4806-be4a-158ca9b46bb1", 3, false, "Alden43" },
                    { "83", 0, 40, "2c0342be-7ace-4e86-a6b7-d71c0d95fd39", "ApplicationUser", "Sedrick.VonRueden@hotmail.com", false, 1.9m, true, false, null, "SEDRICK.VONRUEDEN@HOTMAIL.COM", "LILLA_FRANECKI4", null, "385.769.1143", false, "2c37430f-8280-448e-9501-e360da8ef67d", 3, false, "Lilla_Franecki4" },
                    { "84", 0, 58, "765eb9b6-d81c-4318-ae57-ca2edba3c262", "ApplicationUser", "Amara_Casper5@gmail.com", false, 2.3m, false, false, null, "AMARA_CASPER5@GMAIL.COM", "TROY11", null, "1-493-511-5541 x308", false, "ae3bec26-887a-4f8f-af15-ddc8db2db3fe", 4, false, "Troy11" },
                    { "85", 0, 21, "d512f2c9-f7d1-4727-83b9-7092d09edf3e", "ApplicationUser", "Eliezer.Murazik11@gmail.com", false, 4.2m, true, false, null, "ELIEZER.MURAZIK11@GMAIL.COM", "LISETTE20", null, "908.322.7459 x59274", false, "86dcdd6b-e48f-4c40-971f-cad3d604c98d", 2, false, "Lisette20" },
                    { "86", 0, 24, "2ba6c9b5-fda5-4be3-a93d-ae36776f3052", "ApplicationUser", "Edward.Schneider@hotmail.com", false, 9.7m, false, false, null, "EDWARD.SCHNEIDER@HOTMAIL.COM", "NOBLE.MITCHELL77", null, "1-608-753-4178 x87126", false, "f60970a4-c1f5-4040-b725-7de7cc995247", 2, false, "Noble.Mitchell77" },
                    { "87", 0, 25, "93d80d5d-495c-4b82-acb0-a5fbc76fce5d", "ApplicationUser", "Cristobal_Treutel3@yahoo.com", false, 7.1m, false, false, null, "CRISTOBAL_TREUTEL3@YAHOO.COM", "GARNETT.HAND65", null, "428.587.1812 x33167", false, "d1cefdd5-b206-4802-a746-aec5349fc9af", 2, false, "Garnett.Hand65" },
                    { "88", 0, 73, "39fc7ff7-d783-4cdc-93ed-319020fb2071", "ApplicationUser", "Clemens_Wiegand48@yahoo.com", false, 1.1m, false, false, null, "CLEMENS_WIEGAND48@YAHOO.COM", "ANSEL87", null, "(674) 314-4076", false, "ad8808b8-e43c-4cfb-8f45-3d448b822592", 2, false, "Ansel87" },
                    { "89", 0, 45, "e475b2d5-eb9d-4601-bf4c-28ecd01f2f58", "ApplicationUser", "Garrick.Schimmel@gmail.com", false, 9.3m, true, false, null, "GARRICK.SCHIMMEL@GMAIL.COM", "NIA67", null, "1-331-415-2224 x140", false, "3b9c4750-4f13-49a0-8d0d-421f390fada3", 3, false, "Nia67" },
                    { "9", 0, 43, "37e6bc28-daf8-43ed-9f68-d8108c2b912c", "ApplicationUser", "Cleora62@yahoo.com", false, 2.7m, true, false, null, "CLEORA62@YAHOO.COM", "TERESA.HOPPE66", null, "365-733-2649", false, "f26c9085-5bb7-4810-8894-5a935a404e93", 4, false, "Teresa.Hoppe66" },
                    { "90", 0, 14, "a45241d9-a360-4949-a8c7-838157241303", "ApplicationUser", "Joesph27@yahoo.com", false, 5.6m, true, false, null, "JOESPH27@YAHOO.COM", "NICOLAS_RUSSEL98", null, "1-570-615-8759 x59165", false, "433a9aba-f37a-4b8e-8f21-2adcd039715d", 1, false, "Nicolas_Russel98" },
                    { "91", 0, 24, "3c2a6231-74b7-49ef-8681-7774b926b2a8", "ApplicationUser", "Nick_Luettgen17@yahoo.com", false, 0.4m, true, false, null, "NICK_LUETTGEN17@YAHOO.COM", "RAEGAN.SMITHAM7", null, "725.577.9199 x8520", false, "bbf54867-23c0-40b2-9a6e-c466bc594ccf", 3, false, "Raegan.Smitham7" },
                    { "92", 0, 20, "eff90a8c-67c6-4bf8-9b85-aef54fe9a7ea", "ApplicationUser", "Khalil.Keeling6@gmail.com", false, 9.7m, false, false, null, "KHALIL.KEELING6@GMAIL.COM", "JENNYFER_HELLER", null, "(309) 604-2875 x1672", false, "b61ee6b6-1c3b-4a75-909d-768546ab502e", 3, false, "Jennyfer_Heller" },
                    { "93", 0, 32, "f7068f56-4976-45f8-8aeb-657c8cb05804", "ApplicationUser", "Ludwig51@gmail.com", false, 4.8m, false, false, null, "LUDWIG51@GMAIL.COM", "KENNETH_TORPHY78", null, "1-275-341-9448 x59924", false, "4bd7121b-ab68-4c53-a2b2-008ee374d976", 3, false, "Kenneth_Torphy78" },
                    { "94", 0, 13, "d094d13c-6ff3-4615-9410-e6d3cb4beb27", "ApplicationUser", "Mason_Considine@gmail.com", false, 8.5m, true, false, null, "MASON_CONSIDINE@GMAIL.COM", "ANTWAN_HALEY", null, "420-224-0236 x542", false, "cc41f80d-1edc-465c-a770-e4332a95e51c", 1, false, "Antwan_Haley" },
                    { "95", 0, 77, "3f304ae3-da1b-485b-a71b-158d2b1c1c22", "ApplicationUser", "Anika_Hauck@hotmail.com", false, 2.8m, true, false, null, "ANIKA_HAUCK@HOTMAIL.COM", "TOMASA30", null, "991.479.4035", false, "7e502bc0-470f-408d-b320-8816f4a55f45", 3, false, "Tomasa30" },
                    { "96", 0, 70, "8e9be7d0-bfd3-49c8-88b8-7b5cc8ad9408", "ApplicationUser", "Okey36@gmail.com", false, 1.8m, false, false, null, "OKEY36@GMAIL.COM", "ZACHARY_COLLINS", null, "964-824-8543 x9351", false, "7cccb757-9351-410b-9736-701b5bba7d1d", 2, false, "Zachary_Collins" },
                    { "97", 0, 29, "6b8af057-506d-4c5e-a581-750d21b66e45", "ApplicationUser", "Alize_Pfeffer@yahoo.com", false, 5.9m, false, false, null, "ALIZE_PFEFFER@YAHOO.COM", "GEORGE.ADAMS", null, "318-461-6121", false, "69f1fdff-7221-4ce2-b0ae-005f2993441b", 2, false, "George.Adams" },
                    { "98", 0, 68, "42995685-0522-478e-b6a1-884b1ce6f07d", "ApplicationUser", "Otho55@gmail.com", false, 6.8m, false, false, null, "OTHO55@GMAIL.COM", "RIVER.BOGISICH", null, "1-713-277-9602", false, "ebdfb2cd-8882-4251-8b1d-76d53c0abbce", 3, false, "River.Bogisich" },
                    { "99", 0, 26, "312b9d9f-0e9c-4bd0-a866-be471b031c85", "ApplicationUser", "Miracle_Kovacek@gmail.com", false, 8.3m, false, false, null, "MIRACLE_KOVACEK@GMAIL.COM", "ZETTA.RUECKER", null, "445.327.6608 x13199", false, "da640627-d90e-45cb-aa32-7abcc458783a", 2, false, "Zetta.Ruecker" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Stock", "Title", "UserId", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 4, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Unbranded Concrete Ball", null, 2002 },
                    { 2, 19, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 8, "Rustic Metal Mouse", null, 2000 },
                    { 3, 4, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 10, "Handcrafted Plastic Bike", null, 2022 },
                    { 4, 1, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 4, "Handcrafted Rubber Chicken", null, 2014 },
                    { 5, 14, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Licensed Cotton Table", null, 2014 },
                    { 6, 13, 5, "The Football Is Good For Training And Recreational Purposes", 8, "Refined Metal Car", null, 2000 },
                    { 7, 7, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Rustic Fresh Bike", null, 2010 },
                    { 8, 9, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Gorgeous Concrete Shirt", null, 2017 },
                    { 9, 14, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 1, "Fantastic Rubber Chair", null, 2014 },
                    { 10, 4, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Tasty Wooden Soap", null, 2004 },
                    { 11, 4, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 4, "Intelligent Wooden Towels", null, 2022 },
                    { 12, 15, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Handcrafted Plastic Keyboard", null, 2009 },
                    { 13, 20, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Handmade Soft Car", null, 2007 },
                    { 14, 16, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 8, "Handmade Frozen Salad", null, 2009 },
                    { 15, 17, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Incredible Frozen Car", null, 2014 },
                    { 16, 15, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, "Ergonomic Metal Pants", null, 2005 },
                    { 17, 19, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 9, "Ergonomic Soft Shoes", null, 2007 },
                    { 18, 10, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Gorgeous Cotton Car", null, 2009 },
                    { 19, 12, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 2, "Handmade Steel Fish", null, 2019 },
                    { 20, 17, 5, "The Football Is Good For Training And Recreational Purposes", 4, "Practical Soft Towels", null, 2020 },
                    { 21, 4, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4, "Fantastic Concrete Pants", null, 2010 },
                    { 22, 1, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 9, "Handmade Wooden Computer", null, 2009 },
                    { 23, 18, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 7, "Gorgeous Soft Bike", null, 2008 },
                    { 24, 16, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 7, "Practical Fresh Chips", null, 2015 },
                    { 25, 8, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0, "Awesome Cotton Fish", null, 2011 },
                    { 26, 2, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 2, "Handmade Steel Soap", null, 2021 },
                    { 27, 1, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 9, "Rustic Frozen Pizza", null, 2017 },
                    { 28, 1, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 5, "Sleek Granite Bike", null, 2023 },
                    { 29, 6, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Handmade Rubber Bacon", null, 2006 },
                    { 30, 5, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 1, "Tasty Steel Mouse", null, 2007 },
                    { 31, 18, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 2, "Rustic Steel Ball", null, 2006 },
                    { 32, 18, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 5, "Gorgeous Concrete Bike", null, 2005 },
                    { 33, 15, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 6, "Intelligent Granite Shirt", null, 2017 },
                    { 34, 14, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 9, "Tasty Soft Pizza", null, 2012 },
                    { 35, 12, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8, "Ergonomic Plastic Bacon", null, 2011 },
                    { 36, 5, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 8, "Practical Frozen Salad", null, 2011 },
                    { 37, 10, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 10, "Sleek Frozen Tuna", null, 2013 },
                    { 38, 12, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 7, "Generic Cotton Pizza", null, 2016 },
                    { 39, 17, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7, "Practical Fresh Bike", null, 2000 },
                    { 40, 20, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 5, "Refined Plastic Pants", null, 2005 },
                    { 41, 18, 2, "The Football Is Good For Training And Recreational Purposes", 3, "Incredible Plastic Pants", null, 2014 },
                    { 42, 6, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8, "Handcrafted Wooden Chips", null, 2008 },
                    { 43, 8, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 0, "Generic Granite Shirt", null, 2003 },
                    { 44, 18, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 3, "Refined Rubber Table", null, 2017 },
                    { 45, 19, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2, "Practical Cotton Shoes", null, 2002 },
                    { 46, 5, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 10, "Rustic Wooden Chips", null, 2023 },
                    { 47, 6, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 10, "Awesome Metal Ball", null, 2013 },
                    { 48, 16, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Unbranded Concrete Hat", null, 2018 },
                    { 49, 12, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5, "Handcrafted Rubber Shoes", null, 2013 },
                    { 50, 1, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 3, "Fantastic Soft Car", null, 2021 },
                    { 51, 18, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 9, "Small Concrete Shoes", null, 2013 },
                    { 52, 8, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Handmade Rubber Chair", null, 2017 },
                    { 53, 19, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Incredible Fresh Chicken", null, 2014 },
                    { 54, 6, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7, "Unbranded Metal Salad", null, 2007 },
                    { 55, 17, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 5, "Licensed Granite Ball", null, 2022 },
                    { 56, 20, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Unbranded Wooden Chicken", null, 2007 },
                    { 57, 17, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 3, "Rustic Metal Pants", null, 2020 },
                    { 58, 2, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 6, "Practical Plastic Towels", null, 2019 },
                    { 59, 12, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7, "Awesome Cotton Sausages", null, 2009 },
                    { 60, 16, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Rustic Soft Cheese", null, 2003 },
                    { 61, 8, 5, "The Football Is Good For Training And Recreational Purposes", 9, "Intelligent Cotton Computer", null, 2009 },
                    { 62, 18, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 9, "Rustic Granite Bacon", null, 2017 },
                    { 63, 7, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 6, "Incredible Soft Chair", null, 2014 },
                    { 64, 11, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 10, "Rustic Frozen Chair", null, 2021 },
                    { 65, 12, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 5, "Awesome Fresh Table", null, 2008 },
                    { 66, 15, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7, "Fantastic Concrete Bacon", null, 2022 },
                    { 67, 9, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 8, "Awesome Fresh Bacon", null, 2006 },
                    { 68, 4, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 2, "Unbranded Soft Chicken", null, 2010 },
                    { 69, 2, 1, "The Football Is Good For Training And Recreational Purposes", 0, "Generic Concrete Towels", null, 2021 },
                    { 70, 8, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 8, "Small Steel Chicken", null, 2009 },
                    { 71, 16, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 1, "Unbranded Cotton Table", null, 2013 },
                    { 72, 11, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 1, "Ergonomic Soft Computer", null, 2020 },
                    { 73, 12, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 10, "Generic Rubber Towels", null, 2011 },
                    { 74, 9, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 5, "Gorgeous Fresh Chicken", null, 2023 },
                    { 75, 7, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 3, "Fantastic Frozen Car", null, 2022 },
                    { 76, 6, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 2, "Practical Frozen Ball", null, 2018 },
                    { 77, 16, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 3, "Refined Frozen Chair", null, 2008 },
                    { 78, 16, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 0, "Sleek Fresh Computer", null, 2015 },
                    { 79, 17, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Handcrafted Soft Car", null, 2012 },
                    { 80, 13, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Rustic Granite Table", null, 2023 },
                    { 81, 15, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 6, "Unbranded Concrete Keyboard", null, 2014 },
                    { 82, 8, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 9, "Handmade Concrete Chips", null, 2004 },
                    { 83, 2, 5, "The Football Is Good For Training And Recreational Purposes", 4, "Handmade Concrete Hat", null, 2015 },
                    { 84, 8, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 8, "Refined Granite Cheese", null, 2006 },
                    { 85, 1, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 5, "Tasty Frozen Bike", null, 2015 },
                    { 86, 7, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 10, "Refined Soft Sausages", null, 2015 },
                    { 87, 20, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 0, "Sleek Granite Table", null, 2008 },
                    { 88, 5, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 7, "Sleek Wooden Keyboard", null, 2020 },
                    { 89, 19, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Gorgeous Metal Keyboard", null, 2021 },
                    { 90, 15, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 1, "Awesome Soft Shoes", null, 2014 },
                    { 91, 19, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9, "Fantastic Fresh Shoes", null, 2019 },
                    { 92, 9, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 4, "Sleek Cotton Mouse", null, 2009 },
                    { 93, 4, 2, "The Football Is Good For Training And Recreational Purposes", 10, "Ergonomic Granite Gloves", null, 2001 },
                    { 94, 8, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6, "Sleek Frozen Hat", null, 2016 },
                    { 95, 18, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 4, "Awesome Granite Sausages", null, 2012 },
                    { 96, 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 10, "Handmade Steel Shirt", null, 2021 },
                    { 97, 5, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9, "Generic Soft Shirt", null, 2012 },
                    { 98, 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9, "Intelligent Metal Chicken", null, 2016 },
                    { 99, 5, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 4, "Small Fresh Ball", null, 2007 },
                    { 100, 8, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 7, "Licensed Granite Towels", null, 2014 }
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
