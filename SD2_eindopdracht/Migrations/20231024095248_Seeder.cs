using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD2_eindopdracht.Migrations
{
    /// <inheritdoc />
    public partial class Seeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Zoila", "Grady" },
                    { 2, "Marian", "Goyette" },
                    { 3, "Laurie", "Zboncak" },
                    { 4, "Trystan", "Hilpert" },
                    { 5, "Afton", "Hills" },
                    { 6, "Osvaldo", "Schmeler" },
                    { 7, "Adriana", "Krajcik" },
                    { 8, "Jaime", "Lowe" },
                    { 9, "Dayna", "Huels" },
                    { 10, "Mallie", "Pfeffer" },
                    { 11, "Dianna", "Rath" },
                    { 12, "Eryn", "Johns" },
                    { 13, "Name", "Beatty" },
                    { 14, "Sunny", "Senger" },
                    { 15, "Cruz", "Funk" },
                    { 16, "Mallory", "Hodkiewicz" },
                    { 17, "Chaya", "Reynolds" },
                    { 18, "Deshaun", "Kutch" },
                    { 19, "Cielo", "Watsica" },
                    { 20, "Elmore", "Kunze" }
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
                    { "1", 0, 46, "d10825f1-4d9e-4f56-a82d-5983408ef436", "ApplicationUser", "Ruth_Schinner@gmail.com", false, false, null, "RUTH_SCHINNER@GMAIL.COM", "SABRYNA.LOCKMAN", null, "(754) 671-3027 x0979", false, "0e2e5ef4-101b-4234-a896-57420bd6401b", 2, false, "Sabryna.Lockman" },
                    { "10", 0, 29, "1cd0f679-fa27-43bf-b0d5-042cf89479d5", "ApplicationUser", "Kattie.Trantow81@hotmail.com", false, false, null, "KATTIE.TRANTOW81@HOTMAIL.COM", "BERNIECE20", null, "526-877-9893", false, "5d94c274-15e6-4ee7-9915-32e86498a65b", 3, false, "Berniece20" },
                    { "100", 0, 21, "526127f7-e40e-4e7c-b680-22798d845dce", "ApplicationUser", "Maud.Jast99@gmail.com", false, false, null, "MAUD.JAST99@GMAIL.COM", "CADEN_GREENFELDER82", null, "659.280.6765 x89285", false, "14bc9ec9-477a-4995-992e-6a0dbe92aac5", 3, false, "Caden_Greenfelder82" },
                    { "11", 0, 61, "499d4ef4-982f-44a3-80a5-15607542c213", "ApplicationUser", "Keeley.Emmerich@yahoo.com", false, false, null, "KEELEY.EMMERICH@YAHOO.COM", "ADRIANNA.STOLTENBERG12", null, "(264) 202-1113", false, "4f636f8f-3731-4101-bd83-579d850f7c2d", 3, false, "Adrianna.Stoltenberg12" },
                    { "12", 0, 54, "d0a93621-626a-4e33-9e8c-38292e1e9bb5", "ApplicationUser", "Marilou9@gmail.com", false, false, null, "MARILOU9@GMAIL.COM", "BUFORD_DIBBERT", null, "786-453-4551", false, "c8019e6b-bd85-42c9-8fc4-9df2435ebb0a", 4, false, "Buford_Dibbert" },
                    { "13", 0, 76, "15ea7e19-6250-482e-9fb4-c4903875cd08", "ApplicationUser", "Dena.Buckridge82@yahoo.com", false, false, null, "DENA.BUCKRIDGE82@YAHOO.COM", "COLLIN21", null, "691.934.4569 x1022", false, "95b491cb-088e-4b86-83f6-08d296fa998c", 4, false, "Collin21" },
                    { "14", 0, 19, "48407c04-2075-4b68-9d79-f4307e6962ab", "ApplicationUser", "Mayra.Berge@gmail.com", false, false, null, "MAYRA.BERGE@GMAIL.COM", "WADE48", null, "646-873-3850 x9032", false, "924d65b4-f718-4276-9d31-a7055e088f2e", 2, false, "Wade48" },
                    { "15", 0, 52, "95faa135-6ad4-409f-a611-df136903ca41", "ApplicationUser", "Cordelia_Kling53@gmail.com", false, false, null, "CORDELIA_KLING53@GMAIL.COM", "BRENNON_LUEILWITZ", null, "257-549-8209", false, "6466a929-b44b-4165-b358-d7ec1d18ebb8", 3, false, "Brennon_Lueilwitz" },
                    { "16", 0, 46, "f3abae70-6ff5-4ff7-8c79-6c124b92e7bd", "ApplicationUser", "Hiram82@hotmail.com", false, false, null, "HIRAM82@HOTMAIL.COM", "KRYSTEL_WEIMANN35", null, "1-355-201-3924 x662", false, "6feb96d3-83a6-4bbe-b13b-45cbf5ab1bdf", 4, false, "Krystel_Weimann35" },
                    { "17", 0, 35, "36ac0a05-b67a-47b3-a0c4-73ca5e9f2a0c", "ApplicationUser", "Xzavier_Cremin@gmail.com", false, false, null, "XZAVIER_CREMIN@GMAIL.COM", "KEN23", null, "1-798-388-5603", false, "e7584770-c5e5-4dd1-9e9c-dd531193dc5f", 2, false, "Ken23" },
                    { "18", 0, 43, "97b6ba0c-6134-41da-8aba-168f939b3720", "ApplicationUser", "Rhoda_Hayes@gmail.com", false, false, null, "RHODA_HAYES@GMAIL.COM", "DESTANY28", null, "511.491.7744 x75790", false, "999a29cb-eca7-40ec-a920-39cb616e022b", 3, false, "Destany28" },
                    { "19", 0, 44, "0af182ed-b443-454d-9994-647dbeb7a85c", "ApplicationUser", "Justice_Collier@hotmail.com", false, false, null, "JUSTICE_COLLIER@HOTMAIL.COM", "KYLER_BECHTELAR59", null, "249-902-6251", false, "1020026c-75d4-4d40-ad61-8a7aa2c08106", 2, false, "Kyler_Bechtelar59" },
                    { "2", 0, 18, "71d072c9-a37c-4d0b-a72b-dad141672ddb", "ApplicationUser", "Lupe_Von@hotmail.com", false, false, null, "LUPE_VON@HOTMAIL.COM", "GREGORIA_PFEFFER55", null, "234-285-7906", false, "91de8afc-ace3-4d12-afcf-9e4cc1cd5f7b", 4, false, "Gregoria_Pfeffer55" },
                    { "20", 0, 76, "b7152474-39a9-4552-911b-40de6e5a8b67", "ApplicationUser", "Myra79@yahoo.com", false, false, null, "MYRA79@YAHOO.COM", "JEWELL.FRIESEN", null, "1-459-950-1450", false, "59e324da-c6b0-4c2a-b484-f0bcc27cabaa", 4, false, "Jewell.Friesen" },
                    { "21", 0, 22, "e24d212e-f6ca-4406-86d5-3c957fce2a1f", "ApplicationUser", "Meagan.Upton@gmail.com", false, false, null, "MEAGAN.UPTON@GMAIL.COM", "RODGER5", null, "806-216-9891 x74306", false, "f546dedb-8328-4007-9f86-06280b8339e7", 2, false, "Rodger5" },
                    { "22", 0, 56, "4523b26c-f971-4aec-b529-cb0523f31836", "ApplicationUser", "Sanford.Koss32@hotmail.com", false, false, null, "SANFORD.KOSS32@HOTMAIL.COM", "COOPER46", null, "206-362-2042 x071", false, "82b05cdb-5145-4261-aa3b-9e47de4f844b", 4, false, "Cooper46" },
                    { "23", 0, 71, "118f9b20-8715-4a68-8401-79bbc2195e7a", "ApplicationUser", "Antwan11@yahoo.com", false, false, null, "ANTWAN11@YAHOO.COM", "ETHA_ERNSER44", null, "366-913-5422", false, "cf62b7a3-35c6-427c-8de3-2bbd4d00af1b", 3, false, "Etha_Ernser44" },
                    { "24", 0, 72, "277b6470-2c84-4907-824d-5b577e7ae3d5", "ApplicationUser", "Jennie35@yahoo.com", false, false, null, "JENNIE35@YAHOO.COM", "WILLIAM_PRICE", null, "541.559.1597 x2620", false, "fc68abd8-970a-4e71-ac12-9623ec9c0a1c", 3, false, "William_Price" },
                    { "25", 0, 37, "659348aa-61fb-4356-b2c4-53552dd3d515", "ApplicationUser", "Estella.Hane@yahoo.com", false, false, null, "ESTELLA.HANE@YAHOO.COM", "BILLY_ZIEME16", null, "643-974-7882 x44611", false, "78f9a8c1-5b16-4d12-b575-6ff3360fccd7", 4, false, "Billy_Zieme16" },
                    { "26", 0, 35, "7f13bbcb-411b-4dda-853c-cbabd0a093e4", "ApplicationUser", "Eleanore.Spinka@gmail.com", false, false, null, "ELEANORE.SPINKA@GMAIL.COM", "FLAVIO.BEDNAR91", null, "(838) 820-1116", false, "39f43e1b-52ff-4e26-9348-552a2690a464", 2, false, "Flavio.Bednar91" },
                    { "27", 0, 52, "d6df7329-26ac-47b5-b640-cbb1479e5774", "ApplicationUser", "Otilia.Botsford@hotmail.com", false, false, null, "OTILIA.BOTSFORD@HOTMAIL.COM", "SAMMIE_LYNCH", null, "(844) 223-8110 x3942", false, "82b2e0b4-c628-4472-8d6d-ea8c486d7304", 3, false, "Sammie_Lynch" },
                    { "28", 0, 77, "80d2351d-9937-4eb9-8302-861f51c710d1", "ApplicationUser", "Casey5@hotmail.com", false, false, null, "CASEY5@HOTMAIL.COM", "CALISTA_DONNELLY44", null, "498.902.8101 x4646", false, "60f87359-2bff-4862-9cf7-d3480c650510", 3, false, "Calista_Donnelly44" },
                    { "29", 0, 24, "3344089a-9638-412e-afb1-98c1a67370ed", "ApplicationUser", "Cornelius_Deckow@gmail.com", false, false, null, "CORNELIUS_DECKOW@GMAIL.COM", "KEN63", null, "(231) 663-1584 x31786", false, "0514a395-aeeb-4943-84f3-9939c6d195ba", 4, false, "Ken63" },
                    { "3", 0, 60, "466b7133-b749-4b51-bdab-c9fedecb2e1d", "ApplicationUser", "Emilio_Ward@gmail.com", false, false, null, "EMILIO_WARD@GMAIL.COM", "COLTEN.COLLINS", null, "610-763-2563 x8481", false, "19b3e5c7-7e2b-4e2f-99e7-2de13d299474", 4, false, "Colten.Collins" },
                    { "30", 0, 59, "08abfea8-3a9e-4e09-aba8-909f5f04be15", "ApplicationUser", "Roel8@yahoo.com", false, false, null, "ROEL8@YAHOO.COM", "ODELL_ANDERSON", null, "387-514-0415", false, "ad3e80b3-a75e-4bf3-a30e-e3802a2671a5", 3, false, "Odell_Anderson" },
                    { "31", 0, 68, "2d5c2606-644e-4b2e-b328-f21b65c79093", "ApplicationUser", "Marcus2@hotmail.com", false, false, null, "MARCUS2@HOTMAIL.COM", "MONIQUE.AUFDERHAR", null, "415.848.8431", false, "e0485297-21dd-43fa-ac06-459e4de61c83", 3, false, "Monique.Aufderhar" },
                    { "32", 0, 20, "30a3c62a-5267-4815-8295-a39aeda511e5", "ApplicationUser", "Mallie.Miller31@hotmail.com", false, false, null, "MALLIE.MILLER31@HOTMAIL.COM", "OPAL59", null, "(202) 954-8374 x844", false, "6ac4185d-ff7c-4d65-a44c-ee642c3a2bb0", 2, false, "Opal59" },
                    { "33", 0, 14, "2584c447-78c6-470d-8a72-2dbe8d91486d", "ApplicationUser", "Jaycee_Kuvalis42@gmail.com", false, false, null, "JAYCEE_KUVALIS42@GMAIL.COM", "TRYSTAN.WARD", null, "(896) 678-8683 x1673", false, "960a06ca-a15d-4da2-b78a-7261d3ead97a", 1, false, "Trystan.Ward" },
                    { "34", 0, 69, "5f37c044-4ae2-4aac-a618-55da9c3620c9", "ApplicationUser", "Lindsey.Daniel1@gmail.com", false, false, null, "LINDSEY.DANIEL1@GMAIL.COM", "KATARINA20", null, "475-716-0588", false, "df6de7ac-2b60-4070-a874-6cf2158d4a58", 3, false, "Katarina20" },
                    { "35", 0, 78, "66d5937b-8152-4d26-b194-1891cfdf62aa", "ApplicationUser", "Melissa56@yahoo.com", false, false, null, "MELISSA56@YAHOO.COM", "MARIETTA.LEBSACK36", null, "331.317.5887 x16649", false, "0579d157-42b7-4175-b5fc-0086c62dba66", 2, false, "Marietta.Lebsack36" },
                    { "36", 0, 41, "0d1add33-8efe-45c7-9588-943727499f41", "ApplicationUser", "Chris_Boyer@gmail.com", false, false, null, "CHRIS_BOYER@GMAIL.COM", "JENIFER_WATERS", null, "609-441-2874", false, "f5f22e5b-f601-4ec1-817d-850b77c64a93", 4, false, "Jenifer_Waters" },
                    { "37", 0, 66, "2539cab4-4ca3-4521-9421-d5711ec9def2", "ApplicationUser", "Rocky.Bartoletti@gmail.com", false, false, null, "ROCKY.BARTOLETTI@GMAIL.COM", "SHANELLE93", null, "973.541.9252 x913", false, "f49d3b87-0649-4d90-ab00-cf2cc432a86d", 2, false, "Shanelle93" },
                    { "38", 0, 52, "4a0fe676-f5d1-4ea1-9b8b-13555fe15db8", "ApplicationUser", "Hermann70@yahoo.com", false, false, null, "HERMANN70@YAHOO.COM", "BENNIE38", null, "859-566-7222 x6381", false, "fbaf8ec9-6909-4f89-b489-5cfa40269293", 3, false, "Bennie38" },
                    { "39", 0, 80, "40bc5298-9a3d-4e70-81cc-ca9688b69c71", "ApplicationUser", "Danielle.Lehner@gmail.com", false, false, null, "DANIELLE.LEHNER@GMAIL.COM", "BRAYAN41", null, "779.794.1207 x543", false, "7505721f-ec44-48ee-906d-ac4e7350b8c9", 3, false, "Brayan41" },
                    { "4", 0, 43, "34ff2737-bf07-484d-9421-33f9e9311cdf", "ApplicationUser", "Nora_Feeney32@gmail.com", false, false, null, "NORA_FEENEY32@GMAIL.COM", "ALICIA30", null, "1-351-872-4666", false, "7246f950-6a31-4304-9c68-3eaecbfa8d70", 4, false, "Alicia30" },
                    { "40", 0, 31, "f90c82c7-3038-45e0-8b67-4c9983edb476", "ApplicationUser", "Monique67@gmail.com", false, false, null, "MONIQUE67@GMAIL.COM", "ESTA_RENNER51", null, "1-767-715-1758", false, "5327639f-e3d4-4a70-9c64-a03a035f7a2c", 3, false, "Esta_Renner51" },
                    { "41", 0, 70, "e7b6583c-c0e8-4d4d-9fcf-c9f8bb08b66d", "ApplicationUser", "Makenzie_Ankunding@hotmail.com", false, false, null, "MAKENZIE_ANKUNDING@HOTMAIL.COM", "EULALIA58", null, "(410) 443-8161 x77920", false, "a6432d30-2366-4d77-b75f-b62514435dba", 3, false, "Eulalia58" },
                    { "42", 0, 15, "89c86782-72ae-4409-ac55-427688224f78", "ApplicationUser", "Eldon_Moore@gmail.com", false, false, null, "ELDON_MOORE@GMAIL.COM", "EVELINE.JONES", null, "339-879-2123 x16841", false, "e7256ea4-319d-4352-9ffe-8066aa4af438", 1, false, "Eveline.Jones" },
                    { "43", 0, 32, "dc96fd55-baa9-42fc-a0f1-d54ef3a75777", "ApplicationUser", "Ben.Quigley@hotmail.com", false, false, null, "BEN.QUIGLEY@HOTMAIL.COM", "CLARE84", null, "1-318-406-0503", false, "406cd3dc-cf65-4533-86ac-fe17a076d361", 2, false, "Clare84" },
                    { "44", 0, 64, "c0200770-c9ac-49f6-bdf5-ac62921a3bfc", "ApplicationUser", "Karli.Mante@gmail.com", false, false, null, "KARLI.MANTE@GMAIL.COM", "JADA.DIETRICH", null, "1-648-289-4227 x266", false, "57a706f1-3f6a-41af-9327-587db80d9773", 4, false, "Jada.Dietrich" },
                    { "45", 0, 27, "95ebb217-d290-4abf-b38b-c7eb9cac3394", "ApplicationUser", "Laverne_Kuphal24@yahoo.com", false, false, null, "LAVERNE_KUPHAL24@YAHOO.COM", "JOE50", null, "1-629-524-1723 x1406", false, "13be5325-60f1-4620-8411-5add8bdee4ad", 3, false, "Joe50" },
                    { "46", 0, 72, "db587e24-d6f8-42a4-8047-cf10d186c447", "ApplicationUser", "Bulah54@gmail.com", false, false, null, "BULAH54@GMAIL.COM", "LELIA_DOYLE", null, "569-658-5442 x631", false, "8bf0d1b7-450d-4d55-aaa4-5c087c9969d9", 3, false, "Lelia_Doyle" },
                    { "47", 0, 41, "f406e963-d780-4260-b95a-b7eeb901fdbc", "ApplicationUser", "Daisha.Keebler@hotmail.com", false, false, null, "DAISHA.KEEBLER@HOTMAIL.COM", "ALEXANDRO20", null, "282.841.7905", false, "2dcf2652-0bc4-497d-a03a-a93fa1af9ff6", 2, false, "Alexandro20" },
                    { "48", 0, 55, "53a1ded5-b609-40f5-a162-d843b3b0cb95", "ApplicationUser", "Marlen1@hotmail.com", false, false, null, "MARLEN1@HOTMAIL.COM", "NOEMI.RATKE", null, "1-599-950-4820 x551", false, "4c42a647-88a8-4955-8278-aeb05f634c99", 2, false, "Noemi.Ratke" },
                    { "49", 0, 20, "d6f4511e-0afb-4a2a-9ac3-e9049d6ce54d", "ApplicationUser", "Hailie51@yahoo.com", false, false, null, "HAILIE51@YAHOO.COM", "MAYNARD2", null, "301-974-0203", false, "2f69f57d-7e39-4838-9fee-9a5789337d96", 3, false, "Maynard2" },
                    { "5", 0, 49, "da3a75d7-3f0c-4174-a148-7385c041ff10", "ApplicationUser", "Mia44@yahoo.com", false, false, null, "MIA44@YAHOO.COM", "LUCILE.SCHIMMEL", null, "1-482-978-9708 x11897", false, "f9561b32-cde6-42d3-ad4c-b7528f50851a", 2, false, "Lucile.Schimmel" },
                    { "50", 0, 34, "f2c92370-a448-4776-aa6e-15c9645647c2", "ApplicationUser", "Stephen89@gmail.com", false, false, null, "STEPHEN89@GMAIL.COM", "OTILIA.BERGNAUM85", null, "(636) 916-4271 x91358", false, "8839b3e8-1338-4f1b-93ff-643ae35cb860", 4, false, "Otilia.Bergnaum85" },
                    { "51", 0, 70, "6132f780-6318-44df-81bd-237ef1172783", "ApplicationUser", "Barton.Ziemann@hotmail.com", false, false, null, "BARTON.ZIEMANN@HOTMAIL.COM", "WARD8", null, "521-746-3291", false, "8baba97a-f0ea-42ca-af8f-d60b3885f7ed", 4, false, "Ward8" },
                    { "52", 0, 22, "45d90f94-a3b0-4d45-bee9-ba2a6ab00072", "ApplicationUser", "Roma5@gmail.com", false, false, null, "ROMA5@GMAIL.COM", "AHMAD.MURRAY", null, "(636) 515-9095", false, "ef031496-3451-4c13-991b-9ff24ef43c29", 4, false, "Ahmad.Murray" },
                    { "53", 0, 59, "9a4138f9-05bf-4972-8532-19446b447eee", "ApplicationUser", "Urban80@yahoo.com", false, false, null, "URBAN80@YAHOO.COM", "AHMED_MCKENZIE", null, "368-228-4289", false, "bedbbdfe-4730-4e4e-b6f3-23abd94fb587", 2, false, "Ahmed_McKenzie" },
                    { "54", 0, 76, "f8a3a2f6-dd5a-4675-a727-1113c533cc55", "ApplicationUser", "Justina_Monahan@gmail.com", false, false, null, "JUSTINA_MONAHAN@GMAIL.COM", "JESS_BECKER", null, "1-599-279-0412", false, "89a4e686-4b4b-4632-8165-46f6ac4ae064", 4, false, "Jess_Becker" },
                    { "55", 0, 23, "f741e2f5-ca8d-4cf5-b874-cdf92cd685fa", "ApplicationUser", "Tavares.Parisian@yahoo.com", false, false, null, "TAVARES.PARISIAN@YAHOO.COM", "HANK.KOCH18", null, "897-509-1564 x62314", false, "b8ab812a-7f96-4027-a3c9-398d4b344184", 2, false, "Hank.Koch18" },
                    { "56", 0, 31, "082cf7f7-35f4-45a7-b41b-8a95271fe54f", "ApplicationUser", "Benny7@yahoo.com", false, false, null, "BENNY7@YAHOO.COM", "FERNE.CORWIN25", null, "705.454.6193", false, "41db92cc-3571-427c-b7bf-638346b4db1c", 2, false, "Ferne.Corwin25" },
                    { "57", 0, 16, "6b978e69-3de4-4224-b3cf-cf06746377d6", "ApplicationUser", "Lottie86@gmail.com", false, false, null, "LOTTIE86@GMAIL.COM", "LAURY_REICHERT", null, "(274) 777-7624", false, "fc344884-c489-4516-a857-cf61299819cb", 1, false, "Laury_Reichert" },
                    { "58", 0, 70, "4ca38634-44af-4def-9170-5bb11fde8030", "ApplicationUser", "Wilma_Kshlerin@hotmail.com", false, false, null, "WILMA_KSHLERIN@HOTMAIL.COM", "NORVAL6", null, "(318) 470-3686", false, "909ccbf7-5fad-4c08-a2bf-4fe16c31c7e1", 3, false, "Norval6" },
                    { "59", 0, 75, "7d65de82-4b38-46c0-bce9-cd6b1b0726da", "ApplicationUser", "Horacio_Crist@hotmail.com", false, false, null, "HORACIO_CRIST@HOTMAIL.COM", "VANESSA_PROHASKA35", null, "1-770-661-3020", false, "d3803c63-04cb-49c8-9abc-f06e08115c4a", 4, false, "Vanessa_Prohaska35" },
                    { "6", 0, 38, "5589f07d-8972-4271-a6b9-fb9126c1eacc", "ApplicationUser", "Trinity70@gmail.com", false, false, null, "TRINITY70@GMAIL.COM", "RUDOLPH_KERTZMANN0", null, "1-400-711-2542", false, "e8c1f955-3deb-4861-bb3e-7b754f0c2e3a", 2, false, "Rudolph_Kertzmann0" },
                    { "60", 0, 76, "96366a95-3810-4530-a993-124ea503d596", "ApplicationUser", "Daisha_Cassin2@yahoo.com", false, false, null, "DAISHA_CASSIN2@YAHOO.COM", "JOHNATHAN.TORP", null, "1-636-286-6811", false, "8d376113-01aa-4e3d-9b32-19b9ec1d3213", 2, false, "Johnathan.Torp" },
                    { "61", 0, 68, "0656f571-586c-4f65-b82f-1ae8c2f8b9a5", "ApplicationUser", "Bettye_Medhurst@yahoo.com", false, false, null, "BETTYE_MEDHURST@YAHOO.COM", "ROZELLA17", null, "395-566-9826 x097", false, "a8035a4c-ee7a-4a4e-8b08-53f4a8686713", 4, false, "Rozella17" },
                    { "62", 0, 46, "f47bfb9d-b793-4d52-a138-d92b7574b274", "ApplicationUser", "Evans.Bins@gmail.com", false, false, null, "EVANS.BINS@GMAIL.COM", "BUCK_GOYETTE", null, "1-998-393-1471 x16055", false, "d3bd703c-9fbf-4f62-9305-b4bc51e60558", 4, false, "Buck_Goyette" },
                    { "63", 0, 51, "2f69d4ef-7849-4948-a3a8-f4a8bfc13416", "ApplicationUser", "Layne.Block47@yahoo.com", false, false, null, "LAYNE.BLOCK47@YAHOO.COM", "DEJON_ABERNATHY", null, "1-413-355-2712 x164", false, "21a881e9-b220-46e5-ac25-bf502fa29e9c", 4, false, "Dejon_Abernathy" },
                    { "64", 0, 14, "928568f4-0b49-438d-9f1a-a070cebb101a", "ApplicationUser", "Josefina56@yahoo.com", false, false, null, "JOSEFINA56@YAHOO.COM", "TONY_KUHN", null, "1-763-674-6943 x629", false, "5c952ff0-348c-451c-8cd4-c22ebab0af27", 1, false, "Tony_Kuhn" },
                    { "65", 0, 63, "f1417c88-a778-4ba3-bcf5-40b409f9380e", "ApplicationUser", "Jedidiah.Effertz88@hotmail.com", false, false, null, "JEDIDIAH.EFFERTZ88@HOTMAIL.COM", "ASHLEIGH26", null, "950.514.9953 x02145", false, "f9a6f8b5-512b-47c0-99c5-b2c9f60c2f26", 4, false, "Ashleigh26" },
                    { "66", 0, 24, "9bd93476-8d57-44a2-b709-48110b40b5cb", "ApplicationUser", "Daisha.Greenholt21@hotmail.com", false, false, null, "DAISHA.GREENHOLT21@HOTMAIL.COM", "KELLEN.GUTKOWSKI76", null, "1-446-343-1606 x01484", false, "e1d21e67-6038-4948-b501-884623dbb4df", 3, false, "Kellen.Gutkowski76" },
                    { "67", 0, 80, "77fd6157-d7de-473e-aea2-9eaea1eecd55", "ApplicationUser", "Loraine.Weimann28@hotmail.com", false, false, null, "LORAINE.WEIMANN28@HOTMAIL.COM", "PEARLIE.LEBSACK70", null, "1-742-580-3785 x04487", false, "f31743b8-f536-424b-acd2-75af21d80769", 4, false, "Pearlie.Lebsack70" },
                    { "68", 0, 75, "2b26d2cb-b07d-41b7-b836-2c76ad134f25", "ApplicationUser", "Kariane.Schaden@hotmail.com", false, false, null, "KARIANE.SCHADEN@HOTMAIL.COM", "ANITA_DAMORE32", null, "(511) 706-2232 x8145", false, "3cb1f579-2bff-4eed-98b0-b070eb265502", 2, false, "Anita_DAmore32" },
                    { "69", 0, 24, "71e8fe50-4b07-4fb3-a072-c513d665a68e", "ApplicationUser", "Kiera.Considine76@yahoo.com", false, false, null, "KIERA.CONSIDINE76@YAHOO.COM", "MARLEN83", null, "932.496.3090 x377", false, "7941bf36-d5e7-4533-b2b2-336342114293", 3, false, "Marlen83" },
                    { "7", 0, 30, "6009320b-96b4-4504-8972-2dcb3a89f287", "ApplicationUser", "Horace23@yahoo.com", false, false, null, "HORACE23@YAHOO.COM", "LIZETH90", null, "532-454-4435", false, "a5b571f5-b2f6-462f-9d02-0c8909b0abb4", 3, false, "Lizeth90" },
                    { "70", 0, 40, "d6d8f48a-e58e-4b96-8a0f-408f7c9f953e", "ApplicationUser", "Elouise7@hotmail.com", false, false, null, "ELOUISE7@HOTMAIL.COM", "JENIFER25", null, "236-310-9568 x413", false, "ec4a84d0-24b1-45ac-8b6e-b924889d3277", 2, false, "Jenifer25" },
                    { "71", 0, 40, "e6af30c2-beb2-49f5-9785-e7181fe735d2", "ApplicationUser", "Nyah12@gmail.com", false, false, null, "NYAH12@GMAIL.COM", "FREDERICK_WHITE", null, "462.857.2809", false, "ec2869e9-3690-4f6c-82e1-38cf783eb50f", 2, false, "Frederick_White" },
                    { "72", 0, 55, "3afffe42-15ae-4636-80ca-f90417e2dc43", "ApplicationUser", "Leonel48@gmail.com", false, false, null, "LEONEL48@GMAIL.COM", "MARIO.RODRIGUEZ", null, "1-689-541-3029 x461", false, "8d892a03-4887-45d6-a465-ce6aa4feb014", 2, false, "Mario.Rodriguez" },
                    { "73", 0, 69, "e1eab317-c208-40b5-a17e-c5bb9288ff94", "ApplicationUser", "Rosalind.Jerde72@hotmail.com", false, false, null, "ROSALIND.JERDE72@HOTMAIL.COM", "SPENCER_FADEL76", null, "769.594.1246", false, "f45dae70-87f4-4ae7-94e9-384e17b29221", 4, false, "Spencer_Fadel76" },
                    { "74", 0, 41, "f2198c00-da2a-4bc9-bada-004d1ded871e", "ApplicationUser", "Ola_Hand@hotmail.com", false, false, null, "OLA_HAND@HOTMAIL.COM", "EMELIE77", null, "(624) 672-9781", false, "a4476caf-8bb0-43f3-a16e-c2ec9f79500d", 2, false, "Emelie77" },
                    { "75", 0, 32, "cd2bd6c1-bf08-4e90-92fd-aa865d62d7fe", "ApplicationUser", "Jan.Dooley61@gmail.com", false, false, null, "JAN.DOOLEY61@GMAIL.COM", "LANDEN_HILPERT", null, "940.371.1324", false, "32fe2b72-bdf8-436e-906b-9a7b8eb4ee8f", 4, false, "Landen_Hilpert" },
                    { "76", 0, 55, "24509e53-1aae-4218-87f4-9ba50eff9915", "ApplicationUser", "Gilbert63@gmail.com", false, false, null, "GILBERT63@GMAIL.COM", "JAQUELIN_DICKENS35", null, "343.965.2344 x91205", false, "eff215ec-67bb-4923-9bd5-3aabd8799f3c", 2, false, "Jaquelin_Dickens35" },
                    { "77", 0, 78, "00f60211-c9d6-4899-85bd-1fd7c5aefc13", "ApplicationUser", "Magdalena69@yahoo.com", false, false, null, "MAGDALENA69@YAHOO.COM", "OTTILIE36", null, "229.928.6741", false, "fcb9ee40-8867-40bd-8076-e8c59b421d33", 4, false, "Ottilie36" },
                    { "78", 0, 68, "2cd3576d-062e-43f3-abbf-55cb5d7bad66", "ApplicationUser", "Benny5@hotmail.com", false, false, null, "BENNY5@HOTMAIL.COM", "AMANI.KUHIC57", null, "(515) 987-4444 x2470", false, "00291473-8003-4161-99ef-f9aec6b99395", 4, false, "Amani.Kuhic57" },
                    { "79", 0, 29, "e7e0407b-55f6-4395-9f95-fbc0d350b6c1", "ApplicationUser", "Susan20@yahoo.com", false, false, null, "SUSAN20@YAHOO.COM", "LILLIAN_SCHULIST65", null, "1-531-819-6231 x33417", false, "b2f9ec67-ce1e-425a-a564-6f100522fcad", 2, false, "Lillian_Schulist65" },
                    { "8", 0, 80, "a2e08596-02d1-48de-bdb4-013f01d0a3c8", "ApplicationUser", "Aniyah25@gmail.com", false, false, null, "ANIYAH25@GMAIL.COM", "ARACELY.WILL50", null, "655.347.7051 x36919", false, "b00694ea-3f47-434f-ad78-88c1817f8bc4", 2, false, "Aracely.Will50" },
                    { "80", 0, 28, "197b8065-fdf2-4aa3-abe8-4464ac80417a", "ApplicationUser", "Jayson61@hotmail.com", false, false, null, "JAYSON61@HOTMAIL.COM", "PEYTON14", null, "1-986-763-5198", false, "1b7964ab-7d21-48a3-b50b-d66c5e55451c", 2, false, "Peyton14" },
                    { "81", 0, 59, "45c144bd-41dd-409b-867f-2969b7408ede", "ApplicationUser", "Thelma_Hodkiewicz@yahoo.com", false, false, null, "THELMA_HODKIEWICZ@YAHOO.COM", "JOSEPHINE_EBERT", null, "1-711-824-4965 x4047", false, "aa81c00a-03cd-4192-9dfe-f5530498ec1c", 3, false, "Josephine_Ebert" },
                    { "82", 0, 54, "049f5cda-5e8f-403f-be55-7746ccb211fd", "ApplicationUser", "Chadrick32@hotmail.com", false, false, null, "CHADRICK32@HOTMAIL.COM", "JESSICA_CONNELLY11", null, "1-518-209-9459", false, "d49d2b12-c4d9-4712-b3f7-65afb6427389", 2, false, "Jessica_Connelly11" },
                    { "83", 0, 80, "0d0e3e84-8279-4955-b0ad-745d0172f86e", "ApplicationUser", "Moshe51@hotmail.com", false, false, null, "MOSHE51@HOTMAIL.COM", "AUTUMN_MANN49", null, "893-589-1979", false, "d20b0cbc-49be-4cb0-a081-da0056df97c7", 3, false, "Autumn_Mann49" },
                    { "84", 0, 52, "d6421f1f-965f-43df-98f9-2134b6c0e8ab", "ApplicationUser", "Madelynn.Dare@gmail.com", false, false, null, "MADELYNN.DARE@GMAIL.COM", "SHANON.ABERNATHY44", null, "348.679.3305", false, "8c23a409-9ee5-4099-a7e4-72e7997f4ee6", 2, false, "Shanon.Abernathy44" },
                    { "85", 0, 24, "fdb4ad4c-2b9c-4ef0-8cda-0dfebfd88d44", "ApplicationUser", "Pansy.Stoltenberg83@hotmail.com", false, false, null, "PANSY.STOLTENBERG83@HOTMAIL.COM", "MOISES_MACEJKOVIC", null, "1-959-954-9267 x27917", false, "56b0c617-df55-4c31-b618-ef272364fd8c", 3, false, "Moises_Macejkovic" },
                    { "86", 0, 41, "e7c20a2a-bb83-49d6-b2dd-768b09b6fdf8", "ApplicationUser", "Evangeline.Larkin@gmail.com", false, false, null, "EVANGELINE.LARKIN@GMAIL.COM", "NAME_STEHR26", null, "528-905-1604", false, "c937f600-1740-4198-ad67-34482120ac56", 4, false, "Name_Stehr26" },
                    { "87", 0, 36, "f00bd994-e2cd-4d3d-bb49-ed25a6936ea8", "ApplicationUser", "Talon_Carroll42@gmail.com", false, false, null, "TALON_CARROLL42@GMAIL.COM", "ANTONIO.HAMMES", null, "(653) 230-5085 x3985", false, "3f5acaf5-da32-48a2-9531-abd89009287e", 2, false, "Antonio.Hammes" },
                    { "88", 0, 25, "f8fd5e9d-d53a-4732-a358-b41996012f66", "ApplicationUser", "Tanya_Hudson50@gmail.com", false, false, null, "TANYA_HUDSON50@GMAIL.COM", "LUCIUS_TROMP84", null, "1-214-704-9971 x473", false, "96a332ad-63ac-4bc9-91f6-948f3efe1495", 2, false, "Lucius_Tromp84" },
                    { "89", 0, 27, "7b28afab-bdce-4101-af08-f3c03d7a81cb", "ApplicationUser", "Jayde67@hotmail.com", false, false, null, "JAYDE67@HOTMAIL.COM", "VERN.KOELPIN", null, "453.309.6433", false, "46e598bf-5b52-4fac-a765-724e1a10911e", 2, false, "Vern.Koelpin" },
                    { "9", 0, 12, "b7f18ac2-aa42-4a80-8b63-18df68ecc497", "ApplicationUser", "Alexander_Oberbrunner@hotmail.com", false, false, null, "ALEXANDER_OBERBRUNNER@HOTMAIL.COM", "ART.HOMENICK33", null, "(886) 513-3474 x5682", false, "512c2d3c-8e87-4c26-a5cd-161ed2ae68a0", 1, false, "Art.Homenick33" },
                    { "90", 0, 16, "4a236913-21eb-4578-aa8d-feef180a6236", "ApplicationUser", "Meaghan.Ernser@gmail.com", false, false, null, "MEAGHAN.ERNSER@GMAIL.COM", "BRANDT_MCCULLOUGH", null, "463-411-6546", false, "21b50832-6621-4b23-b3f4-0fc520a11b39", 1, false, "Brandt_McCullough" },
                    { "91", 0, 40, "d58221ca-8a3a-47f7-89af-ef89b7566674", "ApplicationUser", "Tyrell.Lind@gmail.com", false, false, null, "TYRELL.LIND@GMAIL.COM", "BARTON_GLEASON94", null, "750.472.6548 x353", false, "7e132974-24e3-4111-a3dc-901ba3356743", 4, false, "Barton_Gleason94" },
                    { "92", 0, 49, "4351ecb1-c098-4e08-9207-4ed174db3db3", "ApplicationUser", "Ludwig_Gutmann@gmail.com", false, false, null, "LUDWIG_GUTMANN@GMAIL.COM", "TYRIQUE.ANDERSON", null, "966-610-0444 x71962", false, "c1bcd02c-530e-4218-9a28-a96fac38e910", 3, false, "Tyrique.Anderson" },
                    { "93", 0, 62, "25fb8882-9258-43a3-9280-0e5f2bf731ab", "ApplicationUser", "Annamae88@yahoo.com", false, false, null, "ANNAMAE88@YAHOO.COM", "RANDALL_LINDGREN", null, "1-865-367-4875", false, "952f7b13-70a8-488e-a004-d8d61092b84e", 3, false, "Randall_Lindgren" },
                    { "94", 0, 60, "f2b5db4d-720d-4619-bd51-14d5c94b4645", "ApplicationUser", "Grover_OConner2@yahoo.com", false, false, null, "GROVER_OCONNER2@YAHOO.COM", "KATHERINE48", null, "1-377-825-4278", false, "746dea5f-50e1-48e0-8e2f-a119c3ac9084", 3, false, "Katherine48" },
                    { "95", 0, 61, "9a40fa9c-4c19-4fda-8dfa-a0e8a34efa1a", "ApplicationUser", "Daren_Lesch@yahoo.com", false, false, null, "DAREN_LESCH@YAHOO.COM", "AHMED.HERMAN", null, "255-248-4046 x8341", false, "8fa1cecf-1c2c-4e35-bd2c-df336f6b6979", 4, false, "Ahmed.Herman" },
                    { "96", 0, 26, "edbc8be3-8021-4d2d-9b68-a252af6bab23", "ApplicationUser", "Walton_Moen70@yahoo.com", false, false, null, "WALTON_MOEN70@YAHOO.COM", "CORINE.GAYLORD", null, "1-242-295-2014 x51711", false, "646bafaf-cec7-4929-8ea3-b4708ee71ef0", 2, false, "Corine.Gaylord" },
                    { "97", 0, 34, "9ef94e90-3822-424a-83b5-1a5a1cf4759d", "ApplicationUser", "Bret18@hotmail.com", false, false, null, "BRET18@HOTMAIL.COM", "ANNAMARIE_JONES", null, "1-613-741-2785 x68613", false, "cf592d18-6c3c-4cdb-9c41-d9f7720e850c", 3, false, "Annamarie_Jones" },
                    { "98", 0, 45, "39d09025-fd09-4e03-95d2-e38071df0b02", "ApplicationUser", "Cecilia_Rodriguez@hotmail.com", false, false, null, "CECILIA_RODRIGUEZ@HOTMAIL.COM", "MARGARETTE.SCHAEFER", null, "(327) 729-9557 x1805", false, "5d868415-255c-4caa-ae48-c9fc0c0fa9d1", 4, false, "Margarette.Schaefer" },
                    { "99", 0, 20, "25a69701-eade-48da-ac3d-f219bd9b6044", "ApplicationUser", "Sterling.Baumbach16@hotmail.com", false, false, null, "STERLING.BAUMBACH16@HOTMAIL.COM", "LOTTIE.CONROY", null, "(821) 329-3381", false, "14cdf074-21fe-4e3e-89ea-5ff42d204e1f", 4, false, "Lottie.Conroy" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 14, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Granite Hat", 0 },
                    { 2, 16, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Licensed Wooden Gloves", 0 },
                    { 3, 10, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Soft Computer", 0 },
                    { 4, 3, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Concrete Tuna", 0 },
                    { 5, 1, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Fresh Pants", 0 },
                    { 6, 5, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Tasty Wooden Cheese", 0 },
                    { 7, 3, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Cotton Cheese", 0 },
                    { 8, 16, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Wooden Shirt", 0 },
                    { 9, 11, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Soft Towels", 0 },
                    { 10, 6, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Soft Salad", 0 },
                    { 11, 10, 1, "The Football Is Good For Training And Recreational Purposes", "Gorgeous Cotton Ball", 0 },
                    { 12, 3, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Rubber Table", 0 },
                    { 13, 20, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Soft Tuna", 0 },
                    { 14, 18, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Steel Gloves", 0 },
                    { 15, 9, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Soft Sausages", 0 },
                    { 16, 13, 2, "The Football Is Good For Training And Recreational Purposes", "Small Metal Cheese", 0 },
                    { 17, 19, 3, "The Football Is Good For Training And Recreational Purposes", "Sleek Metal Pants", 0 },
                    { 18, 12, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Frozen Pizza", 0 },
                    { 19, 17, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Rubber Table", 0 },
                    { 20, 2, 4, "The Football Is Good For Training And Recreational Purposes", "Awesome Cotton Pizza", 0 },
                    { 21, 5, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Concrete Cheese", 0 },
                    { 22, 1, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Steel Chips", 0 },
                    { 23, 8, 5, "The Football Is Good For Training And Recreational Purposes", "Small Fresh Salad", 0 },
                    { 24, 4, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Granite Table", 0 },
                    { 25, 7, 2, "The Football Is Good For Training And Recreational Purposes", "Handmade Metal Pizza", 0 },
                    { 26, 10, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Cotton Keyboard", 0 },
                    { 27, 7, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Frozen Chicken", 0 },
                    { 28, 18, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Frozen Pizza", 0 },
                    { 29, 10, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Wooden Sausages", 0 },
                    { 30, 16, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Frozen Gloves", 0 },
                    { 31, 1, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Frozen Fish", 0 },
                    { 32, 10, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Steel Ball", 0 },
                    { 33, 17, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Soft Shoes", 0 },
                    { 34, 10, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Rubber Pizza", 0 },
                    { 35, 20, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Soft Tuna", 0 },
                    { 36, 20, 4, "The Football Is Good For Training And Recreational Purposes", "Small Metal Fish", 0 },
                    { 37, 3, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Soft Salad", 0 },
                    { 38, 11, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Plastic Chicken", 0 },
                    { 39, 12, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Wooden Car", 0 },
                    { 40, 4, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Shoes", 0 },
                    { 41, 3, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Soft Keyboard", 0 },
                    { 42, 5, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Metal Cheese", 0 },
                    { 43, 14, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Plastic Shoes", 0 },
                    { 44, 11, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Rubber Computer", 0 },
                    { 45, 13, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Cotton Chair", 0 },
                    { 46, 18, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Concrete Salad", 0 },
                    { 47, 13, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Soft Sausages", 0 },
                    { 48, 3, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Rubber Sausages", 0 },
                    { 49, 19, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Cotton Table", 0 },
                    { 50, 12, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Plastic Soap", 0 },
                    { 51, 17, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Metal Chair", 0 },
                    { 52, 6, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Frozen Bike", 0 },
                    { 53, 9, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Plastic Towels", 0 },
                    { 54, 12, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Frozen Computer", 0 },
                    { 55, 11, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Granite Chicken", 0 },
                    { 56, 3, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Wooden Salad", 0 },
                    { 57, 20, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Concrete Chicken", 0 },
                    { 58, 17, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Steel Cheese", 0 },
                    { 59, 8, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Granite Sausages", 0 },
                    { 60, 5, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Steel Salad", 0 },
                    { 61, 18, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Frozen Hat", 0 },
                    { 62, 9, 1, "The Football Is Good For Training And Recreational Purposes", "Rustic Plastic Fish", 0 },
                    { 63, 18, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Frozen Ball", 0 },
                    { 64, 9, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Wooden Hat", 0 },
                    { 65, 19, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Steel Salad", 0 },
                    { 66, 14, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Metal Car", 0 },
                    { 67, 18, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Frozen Chicken", 0 },
                    { 68, 10, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Metal Pants", 0 },
                    { 69, 20, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Rubber Ball", 0 },
                    { 70, 6, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Fresh Sausages", 0 },
                    { 71, 15, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Rubber Soap", 0 },
                    { 72, 19, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Frozen Pants", 0 },
                    { 73, 4, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Granite Table", 0 },
                    { 74, 19, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Concrete Tuna", 0 },
                    { 75, 17, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Wooden Computer", 0 },
                    { 76, 16, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Hat", 0 },
                    { 77, 5, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Soft Computer", 0 },
                    { 78, 8, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Fresh Soap", 0 },
                    { 79, 6, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Cotton Shirt", 0 },
                    { 80, 1, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Frozen Shirt", 0 },
                    { 81, 17, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Rubber Shoes", 0 },
                    { 82, 1, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Wooden Gloves", 0 },
                    { 83, 2, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Plastic Bike", 0 },
                    { 84, 2, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Metal Gloves", 0 },
                    { 85, 6, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Steel Mouse", 0 },
                    { 86, 5, 4, "The Football Is Good For Training And Recreational Purposes", "Licensed Soft Chips", 0 },
                    { 87, 12, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Frozen Gloves", 0 },
                    { 88, 11, 5, "The Football Is Good For Training And Recreational Purposes", "Rustic Rubber Pants", 0 },
                    { 89, 15, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Wooden Gloves", 0 },
                    { 90, 11, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Soft Shirt", 0 },
                    { 91, 14, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Frozen Chicken", 0 },
                    { 92, 2, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Granite Cheese", 0 },
                    { 93, 19, 5, "The Football Is Good For Training And Recreational Purposes", "Rustic Concrete Computer", 0 },
                    { 94, 14, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Plastic Cheese", 0 },
                    { 95, 17, 1, "The Football Is Good For Training And Recreational Purposes", "Handmade Steel Pants", 0 },
                    { 96, 3, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Soft Bike", 0 },
                    { 97, 11, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Steel Car", 0 },
                    { 98, 16, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Frozen Computer", 0 },
                    { 99, 12, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Soft Mouse", 0 },
                    { 100, 10, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Frozen Pants", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99");

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subscription",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");
        }
    }
}
