using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD2_eindopdracht.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscription_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 57, "368a028c-892f-4a36-a394-0c59dc375b7d", "Michale_Braun16@hotmail.com", "MICHALE_BRAUN16@HOTMAIL.COM", "OTHA_BOGAN28", "(639) 623-2751 x2268", "3a9336de-84aa-47e2-837d-1a26738d5194", "Otha_Bogan28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 33, "b63cfce2-5d43-4c0a-8f97-2794f566aa8c", "Elijah.Cummerata@hotmail.com", "ELIJAH.CUMMERATA@HOTMAIL.COM", "DEE.CUMMERATA97", "1-247-335-7671 x9295", "3287ba3c-e069-44f1-89c8-d2243aa79c9d", "Dee.Cummerata97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "505b2802-3bd1-4bac-a891-b35a1ca7a346", "Earline_Ritchie84@gmail.com", "EARLINE_RITCHIE84@GMAIL.COM", "TRAVIS86", "401-726-3517", "5a00bb34-a0cd-4739-96d9-b873d7294429", 3, "Travis86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 23, "1e90c6f1-2b99-4692-95f4-14881bb7be11", "Allison78@hotmail.com", "ALLISON78@HOTMAIL.COM", "DORRIS_JONES", "862-222-2971 x57037", "d7ede7a2-e540-473a-8981-9528020548c7", "Dorris_Jones" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 64, "e56b21a0-ceac-4ea6-9cf1-4c9d7e365e52", "Jeanne_Roberts@yahoo.com", "JEANNE_ROBERTS@YAHOO.COM", "LUCIANO_HARBER75", "(227) 474-3264 x46643", "974a60d1-2d61-4292-a793-0313ab2506fb", 2, "Luciano_Harber75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 51, "598a0f04-f032-46ad-b043-8ac3965ec237", "Raquel68@gmail.com", "RAQUEL68@GMAIL.COM", "JARRELL70", "417-432-8269 x00975", "e2146781-911b-40f4-af35-4c65f7227ece", "Jarrell70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "1b6d3169-e3b2-479b-9551-c4051e5469a3", "Idella_Dibbert62@gmail.com", "IDELLA_DIBBERT62@GMAIL.COM", "MAUREEN_RUNOLFSDOTTIR37", "(997) 522-1825 x92537", "6255be27-1a9d-439d-aa77-20222895548a", 1, "Maureen_Runolfsdottir37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "05eec9e9-a4a1-4a1d-a0a7-04ffd88efad5", "Lois.Gottlieb17@hotmail.com", "LOIS.GOTTLIEB17@HOTMAIL.COM", "CHLOE_CORMIER", "1-466-402-4184", "c865a89e-b928-4443-806d-a077c21fb496", 4, "Chloe_Cormier" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 73, "5ed1a872-6fe7-4407-b31f-0de205529bbd", "Torrey_Cronin19@yahoo.com", "TORREY_CRONIN19@YAHOO.COM", "BUFORD.MULLER", "663.513.0491", "c0d09150-1085-4581-8aef-a72a6fe8edfe", 2, "Buford.Muller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "5edc7059-278a-4c59-bec2-b814d0193a18", "Gabriella_Torphy@hotmail.com", "GABRIELLA_TORPHY@HOTMAIL.COM", "JILLIAN81", "732-778-3069", "9900be47-8efc-4769-9e7a-36a9a13c723a", 3, "Jillian81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "ceda75b6-77b2-4728-ac87-d77413fac439", "Harold25@gmail.com", "HAROLD25@GMAIL.COM", "JACEY_JAKUBOWSKI18", "(386) 671-2304 x0012", "0991fcc8-4085-4caf-971a-2cc6d85a70cd", 3, "Jacey_Jakubowski18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 79, "33eb8af3-e957-408e-ac5b-8bae7b89af63", "Ferne_Reichert20@gmail.com", "FERNE_REICHERT20@GMAIL.COM", "HALLE_CASPER", "841.652.4606", "a947c034-4298-42ef-b6ad-c53faf8082a9", "Halle_Casper" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 25, "a93264d9-1908-44f4-8b4f-362fd8ee81a6", "Abigail57@hotmail.com", "ABIGAIL57@HOTMAIL.COM", "FLOSSIE_BLICK5", "416.771.8545 x357", "d7c93c74-2773-44e8-b675-6299740186ad", "Flossie_Blick5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 51, "882fb7f9-8cf8-4e55-8b3e-296f790bb832", "Adolf.Rosenbaum88@hotmail.com", "ADOLF.ROSENBAUM88@HOTMAIL.COM", "MARLON.ORN28", "(934) 570-9467 x3507", "3680743d-d9a3-476a-9647-190aee7719ab", 2, "Marlon.Orn28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "77501a42-7ae0-4e75-a40b-05dc8c5a7d57", "Jerome_Hayes4@hotmail.com", "JEROME_HAYES4@HOTMAIL.COM", "LAMBERT.PARKER51", "(200) 914-9848 x749", "b8434107-8752-4738-8ef8-a5d897e1820d", 1, "Lambert.Parker51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "fa567ef6-1f34-4315-b802-302fb614d281", "Rosalinda_Lang@hotmail.com", "ROSALINDA_LANG@HOTMAIL.COM", "ASHLEE.KASSULKE", "582.607.7951", "2e209dab-d7b0-4a9a-aa3d-f098bb6c51ad", 2, "Ashlee.Kassulke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 46, "75be4c48-2af6-4cbe-af48-d9b1f3b19587", "America31@gmail.com", "AMERICA31@GMAIL.COM", "FEDERICO.HAUCK", "(718) 889-3144 x48197", "e1328386-3f95-4a5d-b292-69e7ed28b450", 2, "Federico.Hauck" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 64, "d8fd5653-e215-43cb-90e9-dd540571d715", "Eleazar_Wuckert28@hotmail.com", "ELEAZAR_WUCKERT28@HOTMAIL.COM", "CLEORA85", "765-355-1091", "4fc62efc-9157-4e8a-8363-f43bdbfb728a", "Cleora85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 37, "944bd61e-3d5d-4804-86b2-dc38bd99971b", "Raquel_Hills@yahoo.com", "RAQUEL_HILLS@YAHOO.COM", "DEON_GREENFELDER", "264.897.4365", "db67b9e7-918e-4798-828e-33b4b9405e8c", 2, "Deon_Greenfelder" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 53, "27a66ab7-0608-40fb-be28-605bdf7b6455", "Ayana_Stracke86@yahoo.com", "AYANA_STRACKE86@YAHOO.COM", "ROWLAND.STROSIN", "664-791-5357 x9533", "89e1b288-d9e3-4bc9-b9e4-840f0002d395", 3, "Rowland.Strosin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "510c7e6f-649e-4e85-91e0-a6f20a0b4738", "Jarrell.Breitenberg77@yahoo.com", "JARRELL.BREITENBERG77@YAHOO.COM", "MELVIN_VONRUEDEN", "1-368-916-5560 x24202", "d14fe7c4-88ce-4926-8630-743173a276ce", 4, "Melvin_VonRueden" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 63, "5eaf11f1-c6a9-41b8-b372-7fd28ce86da8", "Oleta83@gmail.com", "OLETA83@GMAIL.COM", "DIANNA.WATERS76", "566.420.2143 x56114", "bb291961-301f-4113-8da5-0bbe4e41a73b", "Dianna.Waters76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 43, "9f8c9af7-5b09-446f-ba3e-7dbb817cd1ca", "Antwon.Corwin@yahoo.com", "ANTWON.CORWIN@YAHOO.COM", "VLADIMIR_OKEEFE", "608-433-0705 x3265", "27607162-16ab-4fe4-ad32-324ab08271f7", "Vladimir_OKeefe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 22, "29292382-1024-450b-b680-52037387322e", "Alfreda38@gmail.com", "ALFREDA38@GMAIL.COM", "AMBROSE.JACOBSON", "710-441-5247 x823", "f046dd79-7e1f-4e47-9ad3-5439e1f18cb9", "Ambrose.Jacobson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "7a176138-9e8b-4bc4-84d3-369d8df60db8", "Annamae37@yahoo.com", "ANNAMAE37@YAHOO.COM", "KALEY50", "1-592-412-5998", "4bd45547-e3c8-4d59-834a-59a93220af4a", 1, "Kaley50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 59, "1f3f6c80-d0a6-44d1-976e-13b2659a2278", "Jorge_Hudson5@hotmail.com", "JORGE_HUDSON5@HOTMAIL.COM", "ASHLEE_LINDGREN72", "429-769-4615", "10e7e815-8197-4314-b004-2b737527deed", "Ashlee_Lindgren72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 53, "d6d6732f-49f4-4b2c-bd22-d48cdfed8c72", "Jeffery_Olson41@gmail.com", "JEFFERY_OLSON41@GMAIL.COM", "JULIANA_POLLICH", "(614) 453-3089", "998c9933-7997-4224-8373-6ad3d61fff8d", 2, "Juliana_Pollich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 13, "66ba574e-7777-4dbf-ad0f-b53a7bd3f939", "Amaya33@yahoo.com", "AMAYA33@YAHOO.COM", "CLAUDE.TORPHY", "743.353.7617", "56f5a29e-edf0-4d16-8a47-9f23a4b2378b", 1, "Claude.Torphy" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 47, "51542877-9508-4567-af86-0656be5625ab", "Eric_Crona@hotmail.com", "ERIC_CRONA@HOTMAIL.COM", "GREGORIA_KUB96", "620-407-4928 x39634", "1fe91f94-0445-423d-85ae-93ea288a6f16", "Gregoria_Kub96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "7520c024-b984-4124-ae77-01df18605422", "Clotilde.Windler@gmail.com", "CLOTILDE.WINDLER@GMAIL.COM", "KENNEDI94", "(500) 958-2411 x3087", "9f2bf6f5-1690-4573-a226-02b8a7572977", 3, "Kennedi94" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 40, "e1dc1df9-5e42-4054-b6d6-91dc2deff0db", "Dameon.Rau92@hotmail.com", "DAMEON.RAU92@HOTMAIL.COM", "JULIEN_KUHLMAN29", "516.457.5022", "ed5b20a0-90bb-4590-803c-31e2ce1917ed", 2, "Julien_Kuhlman29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 78, "8fcaa84a-b4c0-4ec6-91c7-032cf268e7a9", "Giovani_Wisozk@hotmail.com", "GIOVANI_WISOZK@HOTMAIL.COM", "SALLIE12", "595.627.4092", "95005b63-bc8c-4e8b-b0e6-0c749214c704", 3, "Sallie12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 73, "09712590-6438-44df-ac5f-162998b6c350", "Tommie_Hartmann@yahoo.com", "TOMMIE_HARTMANN@YAHOO.COM", "GARLAND.ANDERSON63", "464.696.4467 x37272", "72554ccb-20bf-466a-9e24-224b1306de96", 2, "Garland.Anderson63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 23, "b0f427e0-071c-409f-88c2-acba8504452f", "Perry.Schiller57@hotmail.com", "PERRY.SCHILLER57@HOTMAIL.COM", "LAUREL.SCHILLER", "271.260.3021 x023", "e345dfd1-b318-451c-b63d-c35e1c26bece", 3, "Laurel.Schiller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 44, "8b76625c-251d-4c9a-b6a7-535a0389a2d5", "Mabel.Fritsch87@hotmail.com", "MABEL.FRITSCH87@HOTMAIL.COM", "DELORES80", "(218) 231-1411 x9395", "c067cce3-2930-4e14-89af-59dd256c5936", 3, "Delores80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 61, "d62b17ce-3a1e-40bf-8dae-4a6594d19b9d", "Julianne.Huel1@hotmail.com", "JULIANNE.HUEL1@HOTMAIL.COM", "PRICE72", "1-665-649-8768 x58644", "18937575-03d7-44d8-94c7-e2287a26362e", 3, "Price72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 46, "d8bb39a4-b7f0-4aa4-98c4-83a702ac8dce", "Ervin59@yahoo.com", "ERVIN59@YAHOO.COM", "SHELDON.LARSON22", "(812) 604-5173", "7e19b911-3cae-4da6-9681-5e87cd56a068", 2, "Sheldon.Larson22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "95ef35a9-9b3a-4775-8eac-edd037939008", "Oswald.Strosin1@yahoo.com", "OSWALD.STROSIN1@YAHOO.COM", "SHANEL.KOVACEK96", "(789) 957-7108 x2088", "b9da54f0-fb14-4b9b-b6a1-a9235addc416", 3, "Shanel.Kovacek96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 59, "db62a8aa-26b6-4915-bb84-2075dfb75aee", "Nash.Dicki@gmail.com", "NASH.DICKI@GMAIL.COM", "ROSELLA75", "811.870.9930 x8349", "c77ae0eb-89fa-4a62-a696-ddf6a6dd3027", "Rosella75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "ae50f9dc-05f4-4183-833b-27863d6720a1", "Tommie.Ratke39@hotmail.com", "TOMMIE.RATKE39@HOTMAIL.COM", "MONA_ERNSER", "1-879-793-3936 x1962", "a71dcfb3-00aa-4714-bff0-4ed7bd367363", 4, "Mona_Ernser" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 68, "c2cc0bbb-2de7-4127-a97e-d69242652a77", "Ezequiel15@yahoo.com", "EZEQUIEL15@YAHOO.COM", "PRICE_CRONA", "(821) 337-5793", "a48773a8-ff18-4f59-978b-a49db3a52e31", 2, "Price_Crona" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 22, "c92dc4f1-deb1-45e6-a3c3-fbe2cedf4907", "Jenifer69@gmail.com", "JENIFER69@GMAIL.COM", "DAPHNEY80", "1-850-794-7343", "2dfd9414-cd64-4b67-8354-f5cf3ad508fa", 4, "Daphney80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 51, "a6dc7bea-87ad-4096-a9ff-bbea57a8ef37", "Ila_Orn72@hotmail.com", "ILA_ORN72@HOTMAIL.COM", "ALANNA46", "1-450-907-6506 x53403", "72278d08-79fb-45a8-ae9a-c9dff03305c6", 4, "Alanna46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 47, "1a9f1ed7-62e7-4d1d-9bba-faeb45521197", "Carmelo.Wolff16@yahoo.com", "CARMELO.WOLFF16@YAHOO.COM", "DAKOTA87", "837-436-3710", "a60a7252-7379-4d15-a948-effcfdf6964c", 2, "Dakota87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "17efb2c3-52ce-47f0-a00f-1c51b4273442", "Sophia52@gmail.com", "SOPHIA52@GMAIL.COM", "KARIANE_MOSCISKI", "1-905-812-2677 x9488", "33b745f4-30c4-47e1-b8be-9d15098e8efa", 2, "Kariane_Mosciski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 74, "1d208bb8-96be-47cb-999f-b6e954479c05", "Jesse_Deckow@yahoo.com", "JESSE_DECKOW@YAHOO.COM", "EDUARDO47", "(208) 540-3147 x3486", "a4ab330c-d938-424e-ab72-3a762b61fa8e", "Eduardo47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "a6d9dc08-b652-43ce-847b-23611fd430c2", "Isaias.Abbott@gmail.com", "ISAIAS.ABBOTT@GMAIL.COM", "DESTIN.DIBBERT", "734.962.9803", "a10df470-0fda-444b-bc24-e2b18a4dffb6", 4, "Destin.Dibbert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 46, "0f421f66-489c-49d5-88a1-c130550127c7", "Fern.Bergnaum84@yahoo.com", "FERN.BERGNAUM84@YAHOO.COM", "ALENE.HERZOG", "496.377.1748", "ab787c53-4ea3-44ac-b9dc-564ce3bb97b3", 3, "Alene.Herzog" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 18, "2112f87b-3d57-4699-935e-57c1c4b1808e", "Francisco.Mante95@hotmail.com", "FRANCISCO.MANTE95@HOTMAIL.COM", "DEON_RUSSEL", "(906) 246-1435 x4832", "4ee50f18-46a0-4071-978f-66582751f53d", "Deon_Russel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "b425b995-466b-4e5d-9f62-0fa3ae5906ff", "Hilario.Denesik6@yahoo.com", "HILARIO.DENESIK6@YAHOO.COM", "MEGHAN46", "900.524.6048 x04666", "9cc22fa5-da85-4299-a64d-621086c31a0b", 2, "Meghan46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "b4e498c2-d1ec-47d8-bc01-80478d0ee263", "Jermain18@hotmail.com", "JERMAIN18@HOTMAIL.COM", "KAYLA_CROOKS1", "361.668.5807 x85651", "38448c39-efae-4b53-b069-fe3cc270d564", 4, "Kayla_Crooks1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 65, "c3b7a42e-8362-434d-8c8d-8a4894b6a0cb", "Eric.Stracke@hotmail.com", "ERIC.STRACKE@HOTMAIL.COM", "PETE_RATH34", "(510) 303-4348 x87420", "bdc6aeac-4c77-4306-9f5a-c659cf533c4d", 3, "Pete_Rath34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 49, "89983930-b56c-417a-b72e-0540b82d3fdf", "Kellie_Boehm89@hotmail.com", "KELLIE_BOEHM89@HOTMAIL.COM", "LACEY.GRADY11", "200-282-1198 x21740", "ed079273-0e0f-43bd-a794-b5458592836c", "Lacey.Grady11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "b9bcc2f8-3b3d-45b7-a094-d6366d9c7958", "Tillman4@yahoo.com", "TILLMAN4@YAHOO.COM", "ELENOR83", "687-527-6774 x530", "9008bfc3-d4a5-4804-8da9-b2463ea2a295", 4, "Elenor83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 41, "f174d8f9-e0a2-4b39-9faa-bea0a99ab3e3", "Lee49@yahoo.com", "LEE49@YAHOO.COM", "LINNEA.COLLIER41", "(469) 658-3750 x5858", "716e9448-6573-45fd-b9bc-bad3a9321433", "Linnea.Collier41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 12, "a203ea0f-06e0-411b-bd49-afb6091456ae", "Oswaldo_Russel@yahoo.com", "OSWALDO_RUSSEL@YAHOO.COM", "ANNE.ZBONCAK", "662.685.9879 x3344", "fd5f4af5-0c5b-4c2e-8d1e-b9c566c3b2f0", 1, "Anne.Zboncak" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 43, "f7161d19-6657-42a6-9d08-41cb7427d7a1", "Mckayla55@yahoo.com", "MCKAYLA55@YAHOO.COM", "TIARA.VON73", "813-703-5881", "fa708db5-1e9c-4e54-ab13-ff5e171c1200", 3, "Tiara.Von73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 48, "6b5bb592-5b76-43cb-af0c-c223da0b317d", "Alejandrin_Bode33@gmail.com", "ALEJANDRIN_BODE33@GMAIL.COM", "BENNY_OHARA50", "503-354-5158 x964", "2fb50b10-8ca5-4bf4-bcb5-083e836a493b", 2, "Benny_OHara50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 26, "dcb6e151-1237-47c5-a6c1-4518a0e3f925", "Kristopher.Greenfelder97@hotmail.com", "KRISTOPHER.GREENFELDER97@HOTMAIL.COM", "ARVILLA67", "875.993.8990 x3460", "518cbacc-4db4-4d48-9224-5d9082b162ac", 3, "Arvilla67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 40, "9fb894bf-63ea-4fd0-91f5-b0f1baf59c2f", "Kellen.Haag53@yahoo.com", "KELLEN.HAAG53@YAHOO.COM", "VERGIE71", "(911) 749-6893 x046", "cdeb06ab-c73a-4385-ba67-f71ca6febde5", "Vergie71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 41, "0e2469e3-8684-4caa-90bd-f60dea3e0c56", "Maegan.Wolff@hotmail.com", "MAEGAN.WOLFF@HOTMAIL.COM", "JAYDEN2", "(299) 614-7739 x5907", "d82d5ea6-3f35-4aa6-8f8c-e6f05ddbda52", 2, "Jayden2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "15759f1e-c061-4cde-bf92-0ddc7efaaf79", "Bulah_Reynolds@gmail.com", "BULAH_REYNOLDS@GMAIL.COM", "CAROLE_POLLICH", "430-935-2510 x00530", "c6a21947-47b5-4da2-8a7e-f99a1d2d77c6", 3, "Carole_Pollich" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 12, "c234bb73-583b-4e58-bfcc-6aa1c46fe983", "Jeramie43@gmail.com", "JERAMIE43@GMAIL.COM", "DAMARIS_WILLMS54", "1-870-626-0053 x30307", "25d96e4a-5858-4984-9949-5cebca8bee6f", "Damaris_Willms54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 56, "2c91f34c-f530-473d-89b9-3c001eb2dc85", "Carmella.Hilpert38@gmail.com", "CARMELLA.HILPERT38@GMAIL.COM", "DENA47", "(994) 673-5699 x3821", "6b9a9c15-7894-44d8-9597-a60eafb10c24", 2, "Dena47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 34, "bd77184a-77ad-40f5-9f2a-c35c863d87f7", "Paxton.Bailey3@hotmail.com", "PAXTON.BAILEY3@HOTMAIL.COM", "DAPHNE31", "1-784-914-5825 x0081", "143be0dd-428b-45e8-a415-d9f913f07311", 2, "Daphne31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 37, "e9c495c7-3d41-41f6-8dac-5f66b881eb54", "Sigrid81@gmail.com", "SIGRID81@GMAIL.COM", "JAYDEN84", "655.961.5836", "ffa97f0b-35d5-422e-8b5a-4da121dc0d7c", "Jayden84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 61, "d472cd70-2d38-4f38-afe5-9090d19f1521", "Gilda_Schroeder@yahoo.com", "GILDA_SCHROEDER@YAHOO.COM", "PETE_BREKKE", "1-762-789-9165 x19960", "be054830-804b-4389-9cd7-f540245d9d23", 4, "Pete_Brekke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "74fc0291-6b45-4089-9343-fb78de5f4adb", "Justine97@gmail.com", "JUSTINE97@GMAIL.COM", "ALIZA_DECKOW", "1-937-776-2026", "20703a49-17fa-4b4c-9abf-e342c301ad3d", 1, "Aliza_Deckow" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "19031f89-6887-4dd1-8696-5a9c894d92e3", "Lavonne38@hotmail.com", "LAVONNE38@HOTMAIL.COM", "NIKOLAS_MAGGIO", "1-450-818-3445 x3757", "e882f744-f7c0-4814-8e36-2a49b0979a8d", 2, "Nikolas_Maggio" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 69, "3b059acc-221f-4912-b14a-dfe1b8628c1d", "Kelli.Erdman30@hotmail.com", "KELLI.ERDMAN30@HOTMAIL.COM", "STONE_KUNDE45", "(413) 407-5465", "242319ae-bcd3-4b50-a55c-848791b44324", "Stone_Kunde45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 44, "65a20103-ff8a-4fec-a8d7-dbedabe9c053", "Freddie.Runte25@hotmail.com", "FREDDIE.RUNTE25@HOTMAIL.COM", "ELEANORA35", "885.631.1198 x714", "5e43415f-2b39-45a2-88d5-f571116c6286", 4, "Eleanora35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 26, "3156aceb-d09e-4388-b464-8306cfbdca0c", "Dejon_Casper@gmail.com", "DEJON_CASPER@GMAIL.COM", "GERALD43", "1-912-335-3367", "7a8e32a4-d442-4149-8e79-f76be0c7d721", "Gerald43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 45, "0eb88592-7eb6-44bd-84d5-20aaf6f8d595", "Garry_Price@hotmail.com", "GARRY_PRICE@HOTMAIL.COM", "LEONARD_LARSON95", "1-400-433-5880", "74b847ca-da19-4c63-966c-420266bd6dcf", 3, "Leonard_Larson95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 29, "8824679a-2ecb-4f9d-ad28-a0f5734955b5", "Berenice.Williamson@hotmail.com", "BERENICE.WILLIAMSON@HOTMAIL.COM", "ALVINA_DIBBERT", "(472) 752-6413 x455", "a146e65e-37a8-4bc4-b670-f4fd5a702fb6", 2, "Alvina_Dibbert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "13a98ed1-e780-418b-bc71-b14143b48714", "Emilia80@hotmail.com", "EMILIA80@HOTMAIL.COM", "JOHNNIE_WEHNER", "654.567.4144", "ad825655-2b99-442c-8e45-766f99548f27", 4, "Johnnie_Wehner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 61, "31ebdde5-0987-4335-8f01-8d3b91b15bf8", "Zetta_Smith@gmail.com", "ZETTA_SMITH@GMAIL.COM", "ADRAIN_MULLER", "(263) 316-0717", "368dd075-3629-409e-ae0c-b67b8a100d80", 4, "Adrain_Muller" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 39, "3e39fcf0-5647-462f-8ca3-942062c2ad2b", "Terrell.Dibbert@hotmail.com", "TERRELL.DIBBERT@HOTMAIL.COM", "KALE_KEELING", "670-489-4657 x435", "9b8866ef-950c-48a2-85aa-5ec40e35d9a9", "Kale_Keeling" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "5988234b-b9b4-402e-bb37-f58782e6b6c3", "Shanon87@yahoo.com", "SHANON87@YAHOO.COM", "JAYLAN_LAKIN", "(385) 351-3555", "86354bdb-bd1d-4a77-9513-7a8b67d73a78", 4, "Jaylan_Lakin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 12, "81b6d5a0-0fc1-4cfb-ab12-b212a354310c", "Herminia_Barton@gmail.com", "HERMINIA_BARTON@GMAIL.COM", "JERRELL.FARRELL9", "1-835-716-0227 x41012", "6a146af2-099d-4c02-a245-12c4b9b54951", 1, "Jerrell.Farrell9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 17, "864abb06-7e70-47a4-9687-11e411940303", "Nash89@yahoo.com", "NASH89@YAHOO.COM", "STEFAN_WEBER34", "(871) 618-8945", "e67fae0f-411f-4caf-82b7-b856ad71afb9", "Stefan_Weber34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 80, "a194de93-20d7-4872-8416-b8dc6da559b1", "Afton_Effertz44@hotmail.com", "AFTON_EFFERTZ44@HOTMAIL.COM", "OFELIA.SCHAMBERGER", "914.615.8585", "53446f6c-4624-4ab3-b49f-5a27860cf568", "Ofelia.Schamberger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "8031d353-249f-4714-b052-b81815396c70", "Itzel_Hessel57@hotmail.com", "ITZEL_HESSEL57@HOTMAIL.COM", "HARVEY20", "530.690.7705 x400", "8c32887e-6f80-4266-a697-504ec141bb9c", 2, "Harvey20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 80, "46e83a64-0306-402e-8b20-d7691b79d298", "Llewellyn16@yahoo.com", "LLEWELLYN16@YAHOO.COM", "GIOVANNY89", "235.914.2952", "d238b9f7-83cb-4c4b-9b23-118fe8650852", 2, "Giovanny89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 12, "0d3e6573-16b4-4498-ba80-2e12660deb41", "Blanche.Hettinger92@yahoo.com", "BLANCHE.HETTINGER92@YAHOO.COM", "LEONORA_VANDERVORT", "549.316.4025 x092", "30fb2396-f20b-4392-8600-890d85445677", 1, "Leonora_Vandervort" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 53, "8d0bcde6-61b9-49fc-8e4d-54c8019f8b35", "Elenor1@gmail.com", "ELENOR1@GMAIL.COM", "KEVEN_LEDNER17", "349.492.5107 x805", "ce1052fe-d6e8-4e75-9811-9be372362cc6", "Keven_Ledner17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 35, "41557674-bd27-40bf-ba7f-faa27d0ecc36", "Randall_Feil@hotmail.com", "RANDALL_FEIL@HOTMAIL.COM", "ANGEL93", "368.802.1164 x16299", "b05362d6-c2e8-41d8-89ce-530e9ce640a3", "Angel93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 64, "4b5e0a92-3a0b-4b9d-bb0d-2a419e96650b", "Constantin.Batz@yahoo.com", "CONSTANTIN.BATZ@YAHOO.COM", "ROMAINE_JASKOLSKI", "1-368-922-2388 x08253", "73751174-6858-4ead-8b8b-ee23dc6a1e59", 4, "Romaine_Jaskolski" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 53, "b96f0bfb-1ccd-4883-af28-e60b7433cc52", "Darrick_Brakus78@hotmail.com", "DARRICK_BRAKUS78@HOTMAIL.COM", "KENNEDY.SENGER", "1-854-955-9164 x99676", "0bbe0190-5995-416b-9d46-f629fe9b0826", "Kennedy.Senger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "8add6683-3b96-4d3c-b324-5c7b64af9715", "Adolf.Price@hotmail.com", "ADOLF.PRICE@HOTMAIL.COM", "ELFRIEDA_COLE36", "366.261.8079 x0450", "9dfc3e79-97a8-4d66-9b9d-eaa0e94e2b47", 4, "Elfrieda_Cole36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 56, "ed713779-4479-42c9-8cae-e5fa64dd174b", "Andrew_Schumm66@hotmail.com", "ANDREW_SCHUMM66@HOTMAIL.COM", "ADELINE37", "378.603.0947", "ee210646-241c-4cc4-8b14-930c808f8378", 2, "Adeline37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 25, "0b81bc27-9f8a-458e-8e29-228a17ba8c22", "Fredy.Waters26@hotmail.com", "FREDY.WATERS26@HOTMAIL.COM", "JUSTON.RAYNOR67", "397-864-2629 x457", "083d29c3-9b2c-4b09-8ec5-29323cf80eb9", 4, "Juston.Raynor67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 62, "3d57724f-1c18-4390-b3c5-734bd4dd2036", "Aglae.Harvey1@gmail.com", "AGLAE.HARVEY1@GMAIL.COM", "LESTER_GRADY", "806.733.3382 x44548", "581ece88-eadb-447e-8e84-a882dafd082c", 3, "Lester_Grady" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 41, "b82f9723-746d-427d-81fc-0c8663a5a86d", "Cierra_Stoltenberg@hotmail.com", "CIERRA_STOLTENBERG@HOTMAIL.COM", "LLEWELLYN_RUNTE41", "(355) 274-5304", "229335e0-a43e-4d4b-a03a-a7335d46019c", 3, "Llewellyn_Runte41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "89827ab2-bc72-4350-9822-288c16c92e46", "Romaine24@gmail.com", "ROMAINE24@GMAIL.COM", "TIMMOTHY_EFFERTZ", "1-893-963-6358 x4381", "87d1198f-cec5-439a-98af-dd1f667cb68c", 2, "Timmothy_Effertz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 79, "f173aa4f-51fb-48b0-bf51-6e318f235376", "Nelson_Feest8@yahoo.com", "NELSON_FEEST8@YAHOO.COM", "COOPER.HAHN", "1-555-806-8005", "3f4e147f-c94c-4d7b-a360-fc24ed8366db", "Cooper.Hahn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 42, "cc91229d-213c-4563-b6fc-dfa69f06c9b4", "Brandyn53@hotmail.com", "BRANDYN53@HOTMAIL.COM", "JUNIUS.NOLAN", "1-956-791-0665", "ea3466bd-75f8-41f1-bdbf-369e348d29f7", "Junius.Nolan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 58, "738ddb0f-1d47-4daf-8e94-963852f3b9e0", "Marisol.Turcotte98@gmail.com", "MARISOL.TURCOTTE98@GMAIL.COM", "CHRISTIAN35", "(627) 512-8672 x58139", "21db6a83-1064-4999-94d7-e9dfd5443907", 4, "Christian35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 54, "0c36c629-4bcb-4936-861b-1d15f1f31558", "Amina_Lubowitz@gmail.com", "AMINA_LUBOWITZ@GMAIL.COM", "SABINA_CREMIN", "661.680.2699 x41396", "1184d54c-133e-466c-b804-d3bdb4c71f80", 2, "Sabina_Cremin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "ed33b49c-466e-47ea-825b-289ba6e6e515", "Greta.Purdy63@hotmail.com", "GRETA.PURDY63@HOTMAIL.COM", "CADEN.SCHINNER", "1-839-773-8041 x54786", "25ae323a-85de-41b3-8086-06582065b6f5", 4, "Caden.Schinner" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 23, "70d1d8b9-8fd1-4c8b-91d6-61d70b9d870d", "Roy.Green62@yahoo.com", "ROY.GREEN62@YAHOO.COM", "LIZZIE15", "(943) 364-6606 x041", "68df9670-1fd7-481f-b0e5-7dbb92d61265", 4, "Lizzie15" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Garnet", "O'Hara" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Martina", "Fritsch" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Willa", "Bosco" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jonathon", "Dooley" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Calista", "Monahan" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Carole", "Glover" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gilda", "Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Charley", "Schoen" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ken", "Harris" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alvera", "Homenick" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Loyce", "Pfeffer" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bernard", "Rohan" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Levi", "McGlynn" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mavis", "Beer" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Erling", "Zboncak" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dina", "Doyle" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Tamara", "Runte" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Olga", "Deckow" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Reyna", "Hirthe" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Emil", "Reichel" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Concrete Ball", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Concrete Pizza", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Practical Rubber Salad", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 14, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Granite Towels", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 8, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Rustic Concrete Chicken" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Cotton Towels", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Metal Table", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Wooden Sausages", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Metal Pants", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Concrete Chips", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Rubber Car", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title", "YearOfRelease" },
                values: new object[] { 15, "Generic Fresh Car", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 11, 3, "Intelligent Plastic Chips", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Frozen Bacon", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Concrete Shirt", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Cotton Ball", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Soft Towels", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Plastic Computer", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Concrete Shirt", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Frozen Gloves", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Concrete Mouse", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Soft Mouse", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Granite Mouse", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Metal Sausages", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 3, "The Football Is Good For Training And Recreational Purposes", "Refined Plastic Pizza", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 13, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Steel Table" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Frozen Pants", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Soft Ball", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Soft Keyboard", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Metal Ball", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Metal Tuna", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Steel Pants", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Concrete Ball", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Fantastic Frozen Gloves", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Fresh Shoes", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Wooden Ball", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Steel Mouse", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Plastic Car", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Concrete Bike", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 1, "The Football Is Good For Training And Recreational Purposes", "Unbranded Rubber Chicken", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Fresh Ball", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Intelligent Plastic Hat", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Fresh Soap", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 6, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Rubber Fish" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Cotton Fish", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Licensed Steel Chair", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Concrete Soap", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Plastic Bacon", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Wooden Shirt", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Concrete Chicken", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Sausages", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Hat", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Metal Shoes", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Fantastic Plastic Gloves", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Concrete Chicken", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Granite Bacon", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Awesome Frozen Bacon", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthorId", "CategoryId", "Title" },
                values: new object[] { 14, 4, "Gorgeous Soft Cheese" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Soft Cheese", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Soft Fish", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Generic Soft Pizza", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthorId", "Title", "YearOfRelease" },
                values: new object[] { 2, "Rustic Granite Pants", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Soft Chair", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Granite Tuna", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Fresh Cheese", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Rubber Soap", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Title", "YearOfRelease" },
                values: new object[] { "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Cotton Cheese", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Wooden Keyboard", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Soft Bike", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Frozen Bacon", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Steel Computer", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 14, "Incredible Soft Salad" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Soft Sausages", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Wooden Mouse", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Cotton Chips", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Cotton Fish", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 14, 5, "Generic Fresh Shoes", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Metal Car", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Granite Mouse", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Wooden Gloves", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Rubber Towels", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Rustic Fresh Pants", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 4, "The Football Is Good For Training And Recreational Purposes", "Fantastic Soft Shoes", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 15, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Frozen Car" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Metal Car", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Granite Bike", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Frozen Keyboard", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Concrete Sausages", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Soft Keyboard", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Concrete Chicken", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Cotton Towels", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 3, "The Football Is Good For Training And Recreational Purposes", "Handcrafted Plastic Fish", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Fresh Tuna", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Tasty Plastic Keyboard", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Concrete Shirt", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Fresh Hat", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Soft Towels", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 2, "The Football Is Good For Training And Recreational Purposes", "Intelligent Plastic Table", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Frozen Chips", 2000 });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscription_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Subscription_SubscriptionId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 78, "27d9b0ad-76f3-4305-81b5-4a77f575d511", "Keyshawn21@gmail.com", "KEYSHAWN21@GMAIL.COM", "WILLARD_JOHNSON", "313-814-5988 x9294", "8449dd07-cd8e-448e-949b-ae8c2d86b3c7", "Willard_Johnson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 49, "2f158138-8c0f-46c4-b24b-676a0258b710", "Ardella.Koss86@yahoo.com", "ARDELLA.KOSS86@YAHOO.COM", "ORLAND_BERGNAUM", "426-746-6527 x8375", "c01ac55b-2f9b-4421-996e-7b6c95c3e907", "Orland_Bergnaum" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 50, "6871e58a-0546-49d2-a399-8cb882257137", "Ian17@hotmail.com", "IAN17@HOTMAIL.COM", "GEOVANNI39", "(839) 299-1240", "d32379cf-81c6-4b6f-b585-677aa0fc26c3", 2, "Geovanni39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 74, "d151b57c-c0f7-4bf3-9f64-03ba527546b4", "Keira_Moore@gmail.com", "KEIRA_MOORE@GMAIL.COM", "BRANDY_BREKKE5", "1-544-858-8683 x4693", "f54b15e8-85a2-47eb-8dbb-d52a43a3a399", "Brandy_Brekke5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 47, "50d64f0a-3476-45cf-be17-d7a66748e67b", "Destiny.Botsford36@hotmail.com", "DESTINY.BOTSFORD36@HOTMAIL.COM", "FREDERIC.TROMP", "860.977.8510 x438", "dacb531a-caf8-4eac-8ee3-59c7acc57aa3", 4, "Frederic.Tromp" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 74, "8eeaaa87-d1c5-42bc-9a80-2c1ba023b6ce", "Chauncey_Koepp@yahoo.com", "CHAUNCEY_KOEPP@YAHOO.COM", "IRMA.JAKUBOWSKI82", "630-416-2550", "482fc6d5-2cbc-4c79-adcf-6b42efeaee23", "Irma.Jakubowski82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 77, "2f2a67ed-8301-42ea-9464-e2be1801268b", "Paige86@gmail.com", "PAIGE86@GMAIL.COM", "BENNY.LESCH16", "(844) 527-1977", "0a14ba82-1e4f-4b16-b246-689e93bf03b8", 4, "Benny.Lesch16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "ce02d4f1-5115-4a34-8313-b9858f567b5a", "Leta.Williamson@gmail.com", "LETA.WILLIAMSON@GMAIL.COM", "AUDIE41", "208.250.9251", "30fded65-aee8-49a1-bebb-07d0a660a727", 2, "Audie41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 80, "edbdab3a-1b79-473a-a23c-bf3c84b9f260", "Maryse_Streich@hotmail.com", "MARYSE_STREICH@HOTMAIL.COM", "NORWOOD.JENKINS", "1-522-988-8203", "cb38eea3-7f4f-4226-93eb-32ea6d3f4733", 4, "Norwood.Jenkins" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 14, "5addb1d1-42a1-4005-aa80-2bbc51d901c3", "Lucile.Lakin@yahoo.com", "LUCILE.LAKIN@YAHOO.COM", "SCHUYLER.BARTON", "(302) 680-4908", "32e09b31-08c8-4b56-bd5f-22a7506a159f", 1, "Schuyler.Barton" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 71, "9e476e9e-a9ae-4da9-9b72-a29ef899fcb9", "Tomasa_Stroman@hotmail.com", "TOMASA_STROMAN@HOTMAIL.COM", "TATE5", "945-268-7700", "ec46518a-5b98-4f4b-a7c9-6ff1f1e233bc", 2, "Tate5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 63, "c145bd3b-ebf2-4062-a962-b09dff9251f8", "Justina_Rempel87@gmail.com", "JUSTINA_REMPEL87@GMAIL.COM", "STEPHON_ZIEME", "897-335-6722 x04015", "88108f6f-14b0-4ad1-bac1-f0e1d0f30f12", "Stephon_Zieme" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 27, "fcb2486c-bc05-44a1-b2ab-b2e7d0db9a53", "Rosalinda.Carroll90@yahoo.com", "ROSALINDA.CARROLL90@YAHOO.COM", "STEVE73", "679-753-9586 x52197", "d188816d-8f02-4c75-9eef-151983d3dd14", "Steve73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "06fc8fb8-e53c-43ce-b94a-182cbdbb3eb1", "Jordon86@hotmail.com", "JORDON86@HOTMAIL.COM", "NAPOLEON.STEUBER", "806-983-4403 x7262", "cc12f910-1bb1-4b16-9746-54838f7e9a1b", 4, "Napoleon.Steuber" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "5f3c07e4-5c7d-449f-9628-816138c1fe76", "Louie.Nienow43@gmail.com", "LOUIE.NIENOW43@GMAIL.COM", "PEYTON.REILLY56", "372-764-9098", "aa872e08-3427-4795-8244-d3b476e21d02", 2, "Peyton.Reilly56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "127a45f4-c467-47b5-8ebc-cb697595640b", "Lura_Metz85@hotmail.com", "LURA_METZ85@HOTMAIL.COM", "PERCIVAL80", "1-704-960-5637 x277", "106a6a6a-4abd-4639-95d2-912c44d3c9bd", 3, "Percival80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "654cb2b0-c090-414c-837e-bbaabce595f9", "Chaya35@yahoo.com", "CHAYA35@YAHOO.COM", "LEXIE_BOSCO1", "662-882-2204 x05811", "be0d383e-ed9b-4346-b392-ab9257b32461", 1, "Lexie_Bosco1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 25, "b385c225-4d13-459b-8f5c-20b7e798148c", "Kaylin42@gmail.com", "KAYLIN42@GMAIL.COM", "HASSAN.MCLAUGHLIN", "311.819.1088", "ed8688ff-f3c0-4556-b339-7e8fc183702a", "Hassan.McLaughlin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 50, "3fe32dae-5578-4f3f-83be-28ea6ccd233f", "Ozella.Collier99@hotmail.com", "OZELLA.COLLIER99@HOTMAIL.COM", "LEILANI90", "1-980-683-2127", "070cac4f-4619-4914-b1d0-2da2fb733be2", 4, "Leilani90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "e9ce6795-ce08-46ed-a420-dd2d986a0541", "Reed_Ebert@hotmail.com", "REED_EBERT@HOTMAIL.COM", "REUBEN.HODKIEWICZ", "756-804-1818", "e06036d3-c699-48ea-b184-2081fefe3701", 2, "Reuben.Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 72, "2585e104-a996-4088-848e-75468e4015cd", "Noble.Price@yahoo.com", "NOBLE.PRICE@YAHOO.COM", "CHASITY.CRUICKSHANK", "397-343-4182", "8eeca5cd-8e3e-45b9-ab7a-1a4f0bc8002f", 2, "Chasity.Cruickshank" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 18, "2beda5f1-d53d-443c-9d5c-d9ac91e83e71", "Emma.Hammes@gmail.com", "EMMA.HAMMES@GMAIL.COM", "GIOVANNI_PRICE34", "(565) 864-9809 x02933", "dc7db832-435f-42dd-8184-8c5adb2b5dfd", "Giovanni_Price34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 55, "128704f8-2af7-44bc-bc76-ab9c6fdeb058", "Angeline99@gmail.com", "ANGELINE99@GMAIL.COM", "KEELY57", "1-819-605-5006 x390", "07e19919-fb2a-4a7b-b42e-885285495d8b", "Keely57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 39, "9ded53b7-b4d0-4006-9acc-8200e78208d4", "Elisha12@gmail.com", "ELISHA12@GMAIL.COM", "TYREEK_NICOLAS", "287.468.3404", "bfa038b4-825b-41ca-a4fb-2ef2abf3d079", "Tyreek_Nicolas" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 65, "be17bcd3-3366-4c39-b39a-fb0f537828ac", "Alda88@hotmail.com", "ALDA88@HOTMAIL.COM", "WINNIFRED53", "245-667-5713 x053", "69666bb1-ada3-40fc-8c45-a15648c2e4fa", 4, "Winnifred53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 77, "a5f74d63-9c06-4d73-ad56-66672e3c665b", "Dovie.Howe@hotmail.com", "DOVIE.HOWE@HOTMAIL.COM", "AIDA_GRIMES22", "823.608.0547 x670", "70459ae8-f5b7-42cf-85fb-6d5eddea5ec0", "Aida_Grimes22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 58, "5d10d29a-1d10-4fec-b903-d61073d335bd", "Colt_Mante0@yahoo.com", "COLT_MANTE0@YAHOO.COM", "NORMA43", "832-237-3576 x708", "3de838ee-d05d-4c9e-adaf-290c10884dc4", 4, "Norma43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 35, "e7a1eb77-7cf7-4688-9a06-008d69b52dec", "Emmanuel8@gmail.com", "EMMANUEL8@GMAIL.COM", "NICOLAS.RUNOLFSDOTTIR78", "1-808-869-8700 x6129", "cbdfe5aa-6ea0-4f41-98b8-0adcfacbf347", 2, "Nicolas.Runolfsdottir78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 57, "2f08f829-c46d-4f83-ab5f-09cfa086267a", "Raymundo.Daugherty75@gmail.com", "RAYMUNDO.DAUGHERTY75@GMAIL.COM", "COLEMAN.HYATT7", "1-769-608-2561", "77c23c3a-1ee9-40ac-b097-44e6300b4dbc", "Coleman.Hyatt7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "4affbbea-abf3-4535-8fed-16c214e27e44", "David.Klein@yahoo.com", "DAVID.KLEIN@YAHOO.COM", "PAIGE_KUNDE", "510.214.8408 x10395", "335150a5-4644-4254-a81d-2734ae68ea85", 4, "Paige_Kunde" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 72, "3a716bda-325e-441c-95b9-a0596c32c0d8", "Herminio_Hermiston@yahoo.com", "HERMINIO_HERMISTON@YAHOO.COM", "LENNIE.VON65", "1-833-564-0857 x370", "3806e879-b92a-497e-8b07-3b7fbc10e068", 3, "Lennie.Von65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "002ec604-a981-456f-9bdf-a77dac498c62", "Miles13@yahoo.com", "MILES13@YAHOO.COM", "YESENIA.KRIS", "893-948-2204 x7122", "2362d3ca-6f0f-468e-ab5b-56169b995f87", 2, "Yesenia.Kris" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 42, "e7f84e7f-0ea2-4ca3-a56b-384a3a06ecc1", "Orion_Morar62@hotmail.com", "ORION_MORAR62@HOTMAIL.COM", "BILLY63", "775.471.3180 x1737", "b244340e-0ff9-4b06-a5c2-6b62c8d1378f", 3, "Billy63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 49, "b244f246-d683-49c2-883b-037dd952087f", "Moises_Weber18@hotmail.com", "MOISES_WEBER18@HOTMAIL.COM", "DANIKA_BARTOLETTI", "(969) 382-1803", "5f4e82e3-e691-419d-972a-814ecb1198c0", 2, "Danika_Bartoletti" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 45, "954e7a15-5e7a-4212-a897-2ad69ffcf676", "Augustine.Wiza16@hotmail.com", "AUGUSTINE.WIZA16@HOTMAIL.COM", "ROSALINDA.JASKOLSKI96", "1-553-392-3934", "ca8a5e4b-d0b2-4a65-bf94-47930ab333e5", 2, "Rosalinda.Jaskolski96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 70, "83e8061b-8c85-4035-93e9-e496137c0ff2", "Piper.Johnston@yahoo.com", "PIPER.JOHNSTON@YAHOO.COM", "MAYA.MEDHURST", "1-804-477-9981", "c9b81289-6f14-45d5-8465-3c2b7fe56d0f", 4, "Maya.Medhurst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 69, "1c11934c-5bd6-44e8-bebc-ff9b0112afb8", "Ebba66@hotmail.com", "EBBA66@HOTMAIL.COM", "ISRAEL66", "958-355-8890 x12808", "f5be7342-650b-4733-bf84-415d931d418f", 3, "Israel66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "b4cf3c3e-26b5-46aa-a09c-a31af0076faf", "Daniella15@hotmail.com", "DANIELLA15@HOTMAIL.COM", "ALLENE_MAYERT", "1-891-554-8346 x36819", "6cc68d3e-8b2f-41d4-9f7c-527ffba23289", 2, "Allene_Mayert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 19, "b6997c12-8307-45fa-bca8-9552549f051b", "Deangelo.Wintheiser83@hotmail.com", "DEANGELO.WINTHEISER83@HOTMAIL.COM", "BABY69", "(517) 374-4162", "4723429d-31a7-4e68-80cb-a0a3cf4427a1", "Baby69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 22, "e11a1d1c-210b-4dfd-9719-d8bb92775cca", "Jayne_Schultz@gmail.com", "JAYNE_SCHULTZ@GMAIL.COM", "CHESTER_BAYER", "521-853-7589", "8ac12e29-1238-4166-9002-2e0da6bd7c64", 3, "Chester_Bayer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 34, "0c8ab53e-80e6-4f25-a52f-03582d01c8ef", "Tatum_Bartoletti54@gmail.com", "TATUM_BARTOLETTI54@GMAIL.COM", "DEVON_LARKIN86", "495.680.1956 x88033", "9c2aa0ce-1d2f-4026-bea2-137a9e6d9304", 4, "Devon_Larkin86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 29, "cf6143e2-9405-489c-953d-25dc53086a99", "Zula_Metz71@gmail.com", "ZULA_METZ71@GMAIL.COM", "EARL.NADER39", "388.254.2046", "321558ed-aa63-48ba-8fc3-445d742d2620", 3, "Earl.Nader39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "e5925178-4bcd-4988-bc52-d33ef7f76788", "Elta28@hotmail.com", "ELTA28@HOTMAIL.COM", "NEIL.BARROWS64", "1-550-516-4693", "3055daad-5ac4-4165-9173-f2ddbc80d14a", 3, "Neil.Barrows64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "a8f40d12-0b4e-4d42-b4be-7c466ab9f590", "Austen.Armstrong73@yahoo.com", "AUSTEN.ARMSTRONG73@YAHOO.COM", "RANDY.BORER", "737-917-4991", "084c9f9d-ee62-4e29-b2ce-9d8917a5abbd", 3, "Randy.Borer" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 23, "ace62dac-f8ac-47f7-b7c7-9824e8d89cba", "Ophelia.MacGyver@hotmail.com", "OPHELIA.MACGYVER@HOTMAIL.COM", "LIONEL.BEDNAR", "(261) 461-6296 x188", "c3ea691d-790c-46fa-8d20-edd12a5081b9", 3, "Lionel.Bednar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 30, "d2baf7dc-da0f-418e-b55d-f3a02d68206d", "Albert61@yahoo.com", "ALBERT61@YAHOO.COM", "RACHELLE.BERGSTROM", "482.224.8280 x906", "1fcd113c-b21d-4eae-8e55-f296ef125b4b", "Rachelle.Bergstrom" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 64, "cbbfa838-a59f-4630-897d-21d899ea6d5c", "Tyreek55@gmail.com", "TYREEK55@GMAIL.COM", "MATHILDE7", "1-935-914-0617 x0951", "ab0c48a8-3feb-4b42-9ef4-8b7864e1699c", 2, "Mathilde7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 14, "9d8f5dd8-9472-425d-aa7f-46ccd5e52aa4", "Lavern.Monahan49@gmail.com", "LAVERN.MONAHAN49@GMAIL.COM", "VITO.KEMMER39", "636-517-2954 x95901", "d403deea-2861-447e-9842-d38529156a8e", 1, "Vito.Kemmer39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 25, "cca590b2-6223-4a6e-8814-f8a09fdd29a4", "Emelie.McClure@yahoo.com", "EMELIE.MCCLURE@YAHOO.COM", "PRESTON_NADER17", "734-450-3790 x880", "d81c7558-8b16-4d92-b8ac-83f648eba296", "Preston_Nader17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 63, "9b1d3198-d135-41e4-94b5-bbdb378892a1", "Tremayne_Price18@hotmail.com", "TREMAYNE_PRICE18@HOTMAIL.COM", "GASTON_ONDRICKA", "696-588-3732 x340", "fd4d257b-7072-44a5-8359-7085bac382a6", 3, "Gaston_Ondricka" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 13, "ffe36eeb-0faf-4e12-af95-7c6665120632", "Vincenza60@hotmail.com", "VINCENZA60@HOTMAIL.COM", "REID_SHIELDS36", "(733) 892-4641 x45079", "84b6297f-81e8-4d42-95ac-6d183d17ba06", 1, "Reid_Shields36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 51, "5d58ace4-4283-4aad-92e4-778d65371944", "Ned_Kutch3@gmail.com", "NED_KUTCH3@GMAIL.COM", "QUINTON_VANDERVORT", "417-367-4605 x5121", "fcb10a18-b74f-4331-a94f-7b772e268695", 4, "Quinton_Vandervort" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 62, "43c34bd3-248f-435e-882d-9b5d9a6656f6", "Derek.Bayer40@hotmail.com", "DEREK.BAYER40@HOTMAIL.COM", "META_EBERT", "(436) 970-2501 x28047", "b7af7efa-58b9-4e81-9520-779fd8ee8f27", "Meta_Ebert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 63, "233b82bb-083b-43cf-9c29-b6d1be854430", "Lisa89@gmail.com", "LISA89@GMAIL.COM", "ARVILLA50", "(426) 843-3300", "79e82bf9-2fdd-492a-ad25-f7416a8d1a9c", 3, "Arvilla50" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 39, "1f6bc4d8-058a-4eec-ba11-64c431c7cc49", "Berenice.Frami@gmail.com", "BERENICE.FRAMI@GMAIL.COM", "EZEQUIEL_SKILES", "962.209.0484", "7d5582ea-2de3-45f7-8058-546d46ea73fe", "Ezequiel_Skiles" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "cdf3af05-190f-4875-8cad-e6fb4158b1f9", "Luella_Paucek58@gmail.com", "LUELLA_PAUCEK58@GMAIL.COM", "EARLINE77", "635.465.5110 x571", "3625b569-5ea6-40b0-ad17-13a596d70a02", 2, "Earline77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "2bd52604-c47d-4766-8b1d-952328b9c9de", "Ashlee_Ferry67@hotmail.com", "ASHLEE_FERRY67@HOTMAIL.COM", "CALISTA20", "825.343.3229", "395dac11-e56d-4d14-a57a-8fda6ebbf536", 4, "Calista20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 63, "322ce434-733f-4d94-b941-bddf0a9ad71c", "Elyse.Stamm72@hotmail.com", "ELYSE.STAMM72@HOTMAIL.COM", "FLORENCIO_CRONIN92", "460-389-9028 x5313", "24177e2c-3872-44ea-9474-5eb8019f9f68", 4, "Florencio_Cronin92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "1afa94bb-1a07-47d0-9a19-aac369070bc0", "Kaden5@gmail.com", "KADEN5@GMAIL.COM", "EZEQUIEL.PROSACCO96", "926-313-4674", "a5e1a68a-19c0-48e2-bcfb-54d677469317", 2, "Ezequiel.Prosacco96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 69, "00a09cb5-3ffe-4af5-a795-3c57eec7d155", "Christophe_Pollich86@gmail.com", "CHRISTOPHE_POLLICH86@GMAIL.COM", "KELVIN.BECHTELAR", "822.605.5505 x1608", "51a7bd77-98a9-4de9-a21c-b3aec9df7e42", "Kelvin.Bechtelar" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "dbeaca60-c6f7-420d-a5e6-032b67667b91", "Savannah_Witting30@gmail.com", "SAVANNAH_WITTING30@GMAIL.COM", "GERRY.MAYER39", "419.410.0446 x44903", "0403b63a-d770-49a3-903b-40c3838c475c", 4, "Gerry.Mayer39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "b54b1987-500f-4dea-955e-2c2c92611179", "Wilbert68@yahoo.com", "WILBERT68@YAHOO.COM", "BERRY18", "837-585-4406 x646", "6239add2-a85e-4a71-aba4-c1c8336fd453", 4, "Berry18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 13, "5e4a7527-044a-44b6-9cd1-219509324a22", "Leone.Bauch@hotmail.com", "LEONE.BAUCH@HOTMAIL.COM", "SAMARA.KOELPIN", "495.635.6933", "980e6a46-4809-4563-ab04-2adc33a3e80b", "Samara.Koelpin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "7b66b67f-f074-40a6-94b2-74b617d14fe5", "Alayna65@gmail.com", "ALAYNA65@GMAIL.COM", "ODIE6", "590.855.9878 x3631", "7505b99c-d295-459f-b9dc-589fa1224fcf", 3, "Odie6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 13, "be85c719-8531-4cf7-a01c-f1d6c75e54e3", "Mozell.Nitzsche37@hotmail.com", "MOZELL.NITZSCHE37@HOTMAIL.COM", "CARSON.GOTTLIEB20", "923-581-0964", "e3dbbfd7-a203-442f-ae92-b525bf51d6c0", 1, "Carson.Gottlieb20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 58, "7e16f024-0543-48fe-b3db-77c1b20eb193", "Marisa19@yahoo.com", "MARISA19@YAHOO.COM", "DEXTER42", "1-516-472-1861", "86f0fc26-10ef-4471-a17f-eb8333964b77", "Dexter42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "08b62f3c-c806-418c-9c82-8e69aa29a39d", "Elvis_Ernser13@gmail.com", "ELVIS_ERNSER13@GMAIL.COM", "DION62", "1-283-660-9589 x1467", "b777b2b7-fc3d-455c-a8f8-5cfbdc9ef666", 2, "Dion62" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 79, "0dcb0ccd-ca19-40c4-bf6f-a49345813835", "Tyrel.Lockman@hotmail.com", "TYREL.LOCKMAN@HOTMAIL.COM", "MYLENE.FEEST", "284.304.3818 x8433", "da52f94f-40f4-4783-9d84-3f29e64dd475", 3, "Mylene.Feest" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "52cb4a30-1592-4872-88c7-3f5c9ed287c7", "Catherine.Boyer60@gmail.com", "CATHERINE.BOYER60@GMAIL.COM", "HELLEN.LANGOSH", "864-484-1911", "32d19f0b-cb6d-4d0c-a425-115cc6bc6a3e", 3, "Hellen.Langosh" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 73, "f3cbb3d5-c9fd-4333-96bb-94346d79860f", "Else.Kerluke@hotmail.com", "ELSE.KERLUKE@HOTMAIL.COM", "KESHAUN.SATTERFIELD", "402-581-4507 x420", "08c37643-76c1-4b86-82ae-510714ce8f86", "Keshaun.Satterfield" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 53, "1c06c229-d024-4bb8-a6db-5220758e6f85", "Shaniya13@hotmail.com", "SHANIYA13@HOTMAIL.COM", "HASKELL23", "1-331-509-0058", "09ebba7e-0c33-465b-8597-3ab4b6705be1", 3, "Haskell23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 27, "d0c4dbdd-5789-48d9-9799-60334ec327c6", "Newell99@hotmail.com", "NEWELL99@HOTMAIL.COM", "PAXTON35", "836.946.5652", "1c151e53-14f2-4d02-a98f-176eeb2f894f", "Paxton35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "e73ae7dd-2a1e-47c3-899f-5fca9e7c2cfe", "Rosina_Buckridge55@hotmail.com", "ROSINA_BUCKRIDGE55@HOTMAIL.COM", "WELLINGTON80", "720-309-6610 x3258", "b09602f8-b68d-4f1d-a209-9da9406c861b", 1, "Wellington80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 60, "0083525a-0d8f-4f77-97a6-9707bceed4d4", "Albin_Jakubowski34@hotmail.com", "ALBIN_JAKUBOWSKI34@HOTMAIL.COM", "MATHILDE.GORCZANY41", "292-955-5449 x9510", "23c18fea-22da-4468-988e-b93256638c6e", 4, "Mathilde.Gorczany41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 40, "5d2be353-74a5-4381-9ad8-ce1a9633cc52", "Roy_Flatley@hotmail.com", "ROY_FLATLEY@HOTMAIL.COM", "JORDON36", "1-710-674-1085", "d2a28600-2118-4b85-b503-79e27d33123d", 2, "Jordon36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 38, "54732b0d-5ece-43de-8802-56b1d55348e2", "Monique32@yahoo.com", "MONIQUE32@YAHOO.COM", "GUST_FISHER29", "526.430.5067 x89507", "c788c4e4-fd10-4fad-9bb9-01a505834503", 2, "Gust_Fisher29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 48, "ca75f08b-6d9e-40bb-b6fa-a6f920c0695e", "Vickie_Mann12@gmail.com", "VICKIE_MANN12@GMAIL.COM", "FRANCISCO77", "312-275-7145 x473", "53d4b81f-f87c-4ab4-b6fb-3199dbd0fc62", "Francisco77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 37, "e75f27c7-7ace-4308-8995-40bf9a4d1421", "Avery.Kertzmann@gmail.com", "AVERY.KERTZMANN@GMAIL.COM", "MICHAELA_BALISTRERI99", "1-595-685-3820 x1405", "6333e3e6-069a-4633-a7b1-eb0aeeebb673", 2, "Michaela_Balistreri99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 22, "df935bf7-0584-42f3-ab32-392573e4aa0e", "Gabrielle_Schneider86@gmail.com", "GABRIELLE_SCHNEIDER86@GMAIL.COM", "EMMIE.BORER24", "231.231.8645", "b4d2f26c-3f3a-4bb2-b529-ff51fc9b22eb", 3, "Emmie.Borer24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 14, "d8027371-521f-4cb5-a67f-1686bafa98c7", "Lilliana_Schneider@hotmail.com", "LILLIANA_SCHNEIDER@HOTMAIL.COM", "ANGELITA_MAYERT", "(704) 915-5956 x1366", "b0d63e4d-0856-4223-81b6-33339057a8ef", "Angelita_Mayert" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 19, "18149e8b-1ff0-4c60-826d-7ecc6cd5ea54", "Retta59@yahoo.com", "RETTA59@YAHOO.COM", "ZITA.DAVIS", "294-563-6131 x67106", "9f193cf5-a08a-4107-8e30-c01a7413df8e", "Zita.Davis" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "1dd08482-0f2e-4234-975f-df4c10774a89", "Karolann22@hotmail.com", "KAROLANN22@HOTMAIL.COM", "KIERAN_BRAUN6", "(474) 565-6610 x139", "1a0a7899-1d66-4abc-bac9-ffc8407125f1", 4, "Kieran_Braun6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 39, "b6d8f9dc-f0e7-4308-8969-72cdf7d3e9e4", "Yvonne_Borer@hotmail.com", "YVONNE_BORER@HOTMAIL.COM", "KAMILLE26", "(520) 285-5485 x48901", "4f632b50-12da-46db-9f30-8b593e92eb36", 3, "Kamille26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 70, "312129f7-ff2c-4d02-9f18-af3a4da6c6c8", "Yoshiko54@yahoo.com", "YOSHIKO54@YAHOO.COM", "BRYANA.RODRIGUEZ", "246-645-1055", "de7a5e6a-dbb3-452d-a9f0-d2dd22143c22", 4, "Bryana.Rodriguez" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 19, "f1f75b49-40d5-42b9-b211-561e21a8a2be", "Lina54@yahoo.com", "LINA54@YAHOO.COM", "DAX59", "441.423.1035 x257", "0473a8b8-4ac9-4d29-92db-9dac51021881", "Dax59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 28, "12f06782-c2d6-45fa-9f4b-cf71b8e92c80", "Dejuan24@yahoo.com", "DEJUAN24@YAHOO.COM", "CHADD.FRIESEN14", "(737) 698-7332 x5093", "40d97b34-9f06-4224-8e8b-7737dd9361eb", "Chadd.Friesen14" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 30, "536aef7a-9507-401e-9a2e-dbadb83f0625", "Waylon.Schaefer@gmail.com", "WAYLON.SCHAEFER@GMAIL.COM", "CARLO.LESCH89", "464-653-5935 x19456", "3ee0928a-cc9a-41ab-96a3-80793ba7a273", 3, "Carlo.Lesch89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 24, "6d167c54-8a71-4b4a-a00d-8c1be824f0a7", "Noah_Cartwright@gmail.com", "NOAH_CARTWRIGHT@GMAIL.COM", "DOROTHEA.KERLUKE", "1-359-824-1765 x5565", "8ea1caf3-2b18-44f3-aeb8-9b1f4e5b7dd7", "Dorothea.Kerluke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 76, "908b8d81-b8df-429b-983f-5e8c3e110d8a", "Paxton_Bernhard@yahoo.com", "PAXTON_BERNHARD@YAHOO.COM", "JAEDEN71", "896-870-3423 x7553", "ef00a539-5507-4cc5-80b3-b911e7252bc4", 2, "Jaeden71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "8a92fb6c-02af-48b4-912e-28c1c0749014", "Kailey.Morissette@gmail.com", "KAILEY.MORISSETTE@GMAIL.COM", "LELAH_FRAMI74", "(817) 823-0418 x2895", "d2664602-d946-4c59-8ce4-c9d8d4fe0d72", 1, "Lelah_Frami74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 49, "c0443c94-4d42-48db-ad00-b862b7ddd4a0", "Micaela.Thiel13@yahoo.com", "MICAELA.THIEL13@YAHOO.COM", "LUISA.SAWAYN63", "284.466.9914 x2502", "e6c397e8-60a4-4569-bb9b-91fbe8882493", 2, "Luisa.Sawayn63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 65, "47573176-e3d5-4480-8820-18daa139577b", "Cleveland.Homenick93@yahoo.com", "CLEVELAND.HOMENICK93@YAHOO.COM", "OSWALDO.HEATHCOTE", "(535) 645-5200 x636", "0019548a-2533-4731-88ac-c3a712f587c6", 4, "Oswaldo.Heathcote" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 39, "adb838b6-02c5-4413-bc1f-873e2e185c59", "Maynard.Cronin@gmail.com", "MAYNARD.CRONIN@GMAIL.COM", "POLLY31", "(235) 585-8622 x1112", "b4bd0365-5ec8-4e56-ba5e-7ca839a0d733", 4, "Polly31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 15, "60a02f9c-b8cc-4b85-9101-bd97c97ff261", "Kade42@hotmail.com", "KADE42@HOTMAIL.COM", "TERRENCE.FERRY74", "1-210-603-8204 x05738", "dd453f9e-d397-4f0a-b320-96ca9d5ab8ae", 1, "Terrence.Ferry74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 66, "a2855a2e-f5da-4526-bc24-206374ffe85c", "Frankie81@yahoo.com", "FRANKIE81@YAHOO.COM", "TANNER.DARE56", "(649) 519-7247 x873", "6ab6c76a-674c-4ae2-b3e4-f04f5f2c4204", "Tanner.Dare56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 29, "842980c3-087a-4f06-9a37-ed811dddd9d6", "Raegan45@gmail.com", "RAEGAN45@GMAIL.COM", "ZOIE.ZBONCAK", "318.931.0553 x615", "09edc52d-674f-445f-a43f-205ad224a0b4", "Zoie.Zboncak" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 61, "aa7e2fba-c882-402a-8423-9d77c16728d7", "Darrin.Ledner@yahoo.com", "DARRIN.LEDNER@YAHOO.COM", "EUDORA.HAHN48", "(672) 447-6767", "40524587-c344-488f-bf52-9b4d8733cfc4", 2, "Eudora.Hahn48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "ccb64200-1e52-47d7-830a-09cd89a97b13", "Bertram.Roob@hotmail.com", "BERTRAM.ROOB@HOTMAIL.COM", "GUSSIE.BORER67", "404.702.5354 x7856", "33eaa796-e392-46cc-ae5d-6a23dd348697", 3, "Gussie.Borer67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 55, "aa47999d-e73b-41bf-82b3-7bc9715bcebf", "Oren12@gmail.com", "OREN12@GMAIL.COM", "BEVERLY42", "(892) 845-4069", "a3c15249-9439-462e-ac17-7e90b4fe5942", 3, "Beverly42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 34, "385b72d2-0bfc-48f3-bb23-f71fafb9c894", "Cameron.Hoeger@gmail.com", "CAMERON.HOEGER@GMAIL.COM", "VICTOR.TROMP", "1-555-917-9339", "5bc203a1-fd7a-43c8-8951-dcf186409ef3", 3, "Victor.Tromp" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jacquelyn", "Wolf" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kathlyn", "Schmeler" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Westley", "Hauck" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gregoria", "Cassin" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Amara", "Keeling" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Emelia", "Okuneva" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Verla", "Douglas" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Stephania", "DuBuque" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Spencer", "Haag" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bo", "Kuhn" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Cletus", "Keebler" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alysa", "Paucek" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Chelsey", "Hintz" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Hiram", "Bednar" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rebeca", "Mante" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marco", "Watsica" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Loma", "Lowe" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Otis", "Jacobi" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Murphy", "Block" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Vickie", "Crist" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 2, "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Fish", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Frozen Bacon", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Plastic Soap", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 17, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Hat", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 2, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Pants" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Rubber Chair", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 1, "The Football Is Good For Training And Recreational Purposes", "Practical Concrete Towels", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Metal Mouse", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Towels", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 1, "The Football Is Good For Training And Recreational Purposes", "Practical Plastic Gloves", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Wooden Shoes", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "Title", "YearOfRelease" },
                values: new object[] { 18, "Licensed Cotton Sausages", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 6, 2, "Fantastic Granite Bacon", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Wooden Bike", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, "The Football Is Good For Training And Recreational Purposes", "Intelligent Cotton Fish", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Wooden Tuna", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 5, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Hat", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Soft Salad", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Rubber Pizza", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Rubber Pizza", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Metal Hat", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Wooden Soap", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Steel Car", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Fresh Salad", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Rubber Keyboard", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 15, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Rubber Mouse" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Wooden Hat", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Plastic Cheese", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Rubber Chair", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Granite Car", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Rubber Computer", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Granite Shoes", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Concrete Towels", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Rubber Computer", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Concrete Chicken", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Rubber Sausages", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Metal Tuna", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Rubber Towels", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Frozen Shirt", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Wooden Pants", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Concrete Sausages", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Soft Soap", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Wooden Fish", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 7, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Metal Gloves" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Concrete Bike", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Cotton Computer", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Concrete Shirt", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Table", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Pants", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Shoes", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Granite Fish", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Fresh Computer", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Metal Chair", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Concrete Bacon", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Rubber Car", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Concrete Shoes", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Fresh Mouse", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthorId", "CategoryId", "Title" },
                values: new object[] { 9, 3, "Refined Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Soft Pizza", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Sausages", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Plastic Fish", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthorId", "Title", "YearOfRelease" },
                values: new object[] { 11, "Practical Plastic Computer", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Metal Computer", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Wooden Table", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Wooden Bike", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 1, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Tuna", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Description", "Title", "YearOfRelease" },
                values: new object[] { "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Rubber Car", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Granite Pants", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Steel Computer", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Cotton Pizza", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Plastic Pizza", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthorId", "Title" },
                values: new object[] { 3, "Handmade Metal Keyboard" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Concrete Mouse", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Tuna", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Plastic Bacon", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Metal Towels", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 15, 2, "Gorgeous Metal Fish", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Steel Cheese", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Rubber Pizza", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Metal Car", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Plastic Computer", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Plastic Bike", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Frozen Sausages", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 20, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Chair" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Fresh Gloves", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Frozen Keyboard", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Shoes", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Steel Tuna", 2023 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Frozen Keyboard", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Chair", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 3, "The Football Is Good For Training And Recreational Purposes", "Sleek Granite Chips", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Rubber Ball", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Plastic Cheese", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Concrete Hat", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Steel Computer", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Granite Keyboard", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Granite Car", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Hat", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Plastic Car", 2016 });

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Subscription_SubscriptionId",
                table: "AspNetUsers",
                column: "SubscriptionId",
                principalTable: "Subscription",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
