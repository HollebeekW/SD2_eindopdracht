using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SD2_eindopdracht.Migrations
{
    /// <inheritdoc />
    public partial class SeedingData : Migration
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
                    { 1, "Jacquelyn", "Wolf" },
                    { 2, "Kathlyn", "Schmeler" },
                    { 3, "Westley", "Hauck" },
                    { 4, "Gregoria", "Cassin" },
                    { 5, "Amara", "Keeling" },
                    { 6, "Emelia", "Okuneva" },
                    { 7, "Verla", "Douglas" },
                    { 8, "Stephania", "DuBuque" },
                    { 9, "Spencer", "Haag" },
                    { 10, "Bo", "Kuhn" },
                    { 11, "Cletus", "Keebler" },
                    { 12, "Alysa", "Paucek" },
                    { 13, "Chelsey", "Hintz" },
                    { 14, "Hiram", "Bednar" },
                    { 15, "Rebeca", "Mante" },
                    { 16, "Marco", "Watsica" },
                    { 17, "Loma", "Lowe" },
                    { 18, "Otis", "Jacobi" },
                    { 19, "Murphy", "Block" },
                    { 20, "Vickie", "Crist" }
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
                    { "1", 0, 78, "27d9b0ad-76f3-4305-81b5-4a77f575d511", "ApplicationUser", "Keyshawn21@gmail.com", false, false, null, "KEYSHAWN21@GMAIL.COM", "WILLARD_JOHNSON", null, "313-814-5988 x9294", false, "8449dd07-cd8e-448e-949b-ae8c2d86b3c7", 4, false, "Willard_Johnson" },
                    { "10", 0, 49, "2f158138-8c0f-46c4-b24b-676a0258b710", "ApplicationUser", "Ardella.Koss86@yahoo.com", false, false, null, "ARDELLA.KOSS86@YAHOO.COM", "ORLAND_BERGNAUM", null, "426-746-6527 x8375", false, "c01ac55b-2f9b-4421-996e-7b6c95c3e907", 2, false, "Orland_Bergnaum" },
                    { "100", 0, 50, "6871e58a-0546-49d2-a399-8cb882257137", "ApplicationUser", "Ian17@hotmail.com", false, false, null, "IAN17@HOTMAIL.COM", "GEOVANNI39", null, "(839) 299-1240", false, "d32379cf-81c6-4b6f-b585-677aa0fc26c3", 2, false, "Geovanni39" },
                    { "11", 0, 74, "d151b57c-c0f7-4bf3-9f64-03ba527546b4", "ApplicationUser", "Keira_Moore@gmail.com", false, false, null, "KEIRA_MOORE@GMAIL.COM", "BRANDY_BREKKE5", null, "1-544-858-8683 x4693", false, "f54b15e8-85a2-47eb-8dbb-d52a43a3a399", 4, false, "Brandy_Brekke5" },
                    { "12", 0, 47, "50d64f0a-3476-45cf-be17-d7a66748e67b", "ApplicationUser", "Destiny.Botsford36@hotmail.com", false, false, null, "DESTINY.BOTSFORD36@HOTMAIL.COM", "FREDERIC.TROMP", null, "860.977.8510 x438", false, "dacb531a-caf8-4eac-8ee3-59c7acc57aa3", 4, false, "Frederic.Tromp" },
                    { "13", 0, 74, "8eeaaa87-d1c5-42bc-9a80-2c1ba023b6ce", "ApplicationUser", "Chauncey_Koepp@yahoo.com", false, false, null, "CHAUNCEY_KOEPP@YAHOO.COM", "IRMA.JAKUBOWSKI82", null, "630-416-2550", false, "482fc6d5-2cbc-4c79-adcf-6b42efeaee23", 2, false, "Irma.Jakubowski82" },
                    { "14", 0, 77, "2f2a67ed-8301-42ea-9464-e2be1801268b", "ApplicationUser", "Paige86@gmail.com", false, false, null, "PAIGE86@GMAIL.COM", "BENNY.LESCH16", null, "(844) 527-1977", false, "0a14ba82-1e4f-4b16-b246-689e93bf03b8", 4, false, "Benny.Lesch16" },
                    { "15", 0, 33, "ce02d4f1-5115-4a34-8313-b9858f567b5a", "ApplicationUser", "Leta.Williamson@gmail.com", false, false, null, "LETA.WILLIAMSON@GMAIL.COM", "AUDIE41", null, "208.250.9251", false, "30fded65-aee8-49a1-bebb-07d0a660a727", 2, false, "Audie41" },
                    { "16", 0, 80, "edbdab3a-1b79-473a-a23c-bf3c84b9f260", "ApplicationUser", "Maryse_Streich@hotmail.com", false, false, null, "MARYSE_STREICH@HOTMAIL.COM", "NORWOOD.JENKINS", null, "1-522-988-8203", false, "cb38eea3-7f4f-4226-93eb-32ea6d3f4733", 4, false, "Norwood.Jenkins" },
                    { "17", 0, 14, "5addb1d1-42a1-4005-aa80-2bbc51d901c3", "ApplicationUser", "Lucile.Lakin@yahoo.com", false, false, null, "LUCILE.LAKIN@YAHOO.COM", "SCHUYLER.BARTON", null, "(302) 680-4908", false, "32e09b31-08c8-4b56-bd5f-22a7506a159f", 1, false, "Schuyler.Barton" },
                    { "18", 0, 71, "9e476e9e-a9ae-4da9-9b72-a29ef899fcb9", "ApplicationUser", "Tomasa_Stroman@hotmail.com", false, false, null, "TOMASA_STROMAN@HOTMAIL.COM", "TATE5", null, "945-268-7700", false, "ec46518a-5b98-4f4b-a7c9-6ff1f1e233bc", 2, false, "Tate5" },
                    { "19", 0, 63, "c145bd3b-ebf2-4062-a962-b09dff9251f8", "ApplicationUser", "Justina_Rempel87@gmail.com", false, false, null, "JUSTINA_REMPEL87@GMAIL.COM", "STEPHON_ZIEME", null, "897-335-6722 x04015", false, "88108f6f-14b0-4ad1-bac1-f0e1d0f30f12", 3, false, "Stephon_Zieme" },
                    { "2", 0, 27, "fcb2486c-bc05-44a1-b2ab-b2e7d0db9a53", "ApplicationUser", "Rosalinda.Carroll90@yahoo.com", false, false, null, "ROSALINDA.CARROLL90@YAHOO.COM", "STEVE73", null, "679-753-9586 x52197", false, "d188816d-8f02-4c75-9eef-151983d3dd14", 2, false, "Steve73" },
                    { "20", 0, 59, "06fc8fb8-e53c-43ce-b94a-182cbdbb3eb1", "ApplicationUser", "Jordon86@hotmail.com", false, false, null, "JORDON86@HOTMAIL.COM", "NAPOLEON.STEUBER", null, "806-983-4403 x7262", false, "cc12f910-1bb1-4b16-9746-54838f7e9a1b", 4, false, "Napoleon.Steuber" },
                    { "21", 0, 18, "5f3c07e4-5c7d-449f-9628-816138c1fe76", "ApplicationUser", "Louie.Nienow43@gmail.com", false, false, null, "LOUIE.NIENOW43@GMAIL.COM", "PEYTON.REILLY56", null, "372-764-9098", false, "aa872e08-3427-4795-8244-d3b476e21d02", 2, false, "Peyton.Reilly56" },
                    { "22", 0, 33, "127a45f4-c467-47b5-8ebc-cb697595640b", "ApplicationUser", "Lura_Metz85@hotmail.com", false, false, null, "LURA_METZ85@HOTMAIL.COM", "PERCIVAL80", null, "1-704-960-5637 x277", false, "106a6a6a-4abd-4639-95d2-912c44d3c9bd", 3, false, "Percival80" },
                    { "23", 0, 17, "654cb2b0-c090-414c-837e-bbaabce595f9", "ApplicationUser", "Chaya35@yahoo.com", false, false, null, "CHAYA35@YAHOO.COM", "LEXIE_BOSCO1", null, "662-882-2204 x05811", false, "be0d383e-ed9b-4346-b392-ab9257b32461", 1, false, "Lexie_Bosco1" },
                    { "24", 0, 25, "b385c225-4d13-459b-8f5c-20b7e798148c", "ApplicationUser", "Kaylin42@gmail.com", false, false, null, "KAYLIN42@GMAIL.COM", "HASSAN.MCLAUGHLIN", null, "311.819.1088", false, "ed8688ff-f3c0-4556-b339-7e8fc183702a", 3, false, "Hassan.McLaughlin" },
                    { "25", 0, 50, "3fe32dae-5578-4f3f-83be-28ea6ccd233f", "ApplicationUser", "Ozella.Collier99@hotmail.com", false, false, null, "OZELLA.COLLIER99@HOTMAIL.COM", "LEILANI90", null, "1-980-683-2127", false, "070cac4f-4619-4914-b1d0-2da2fb733be2", 4, false, "Leilani90" },
                    { "26", 0, 36, "e9ce6795-ce08-46ed-a420-dd2d986a0541", "ApplicationUser", "Reed_Ebert@hotmail.com", false, false, null, "REED_EBERT@HOTMAIL.COM", "REUBEN.HODKIEWICZ", null, "756-804-1818", false, "e06036d3-c699-48ea-b184-2081fefe3701", 2, false, "Reuben.Hodkiewicz" },
                    { "27", 0, 72, "2585e104-a996-4088-848e-75468e4015cd", "ApplicationUser", "Noble.Price@yahoo.com", false, false, null, "NOBLE.PRICE@YAHOO.COM", "CHASITY.CRUICKSHANK", null, "397-343-4182", false, "8eeca5cd-8e3e-45b9-ab7a-1a4f0bc8002f", 2, false, "Chasity.Cruickshank" },
                    { "28", 0, 18, "2beda5f1-d53d-443c-9d5c-d9ac91e83e71", "ApplicationUser", "Emma.Hammes@gmail.com", false, false, null, "EMMA.HAMMES@GMAIL.COM", "GIOVANNI_PRICE34", null, "(565) 864-9809 x02933", false, "dc7db832-435f-42dd-8184-8c5adb2b5dfd", 2, false, "Giovanni_Price34" },
                    { "29", 0, 55, "128704f8-2af7-44bc-bc76-ab9c6fdeb058", "ApplicationUser", "Angeline99@gmail.com", false, false, null, "ANGELINE99@GMAIL.COM", "KEELY57", null, "1-819-605-5006 x390", false, "07e19919-fb2a-4a7b-b42e-885285495d8b", 4, false, "Keely57" },
                    { "3", 0, 39, "9ded53b7-b4d0-4006-9acc-8200e78208d4", "ApplicationUser", "Elisha12@gmail.com", false, false, null, "ELISHA12@GMAIL.COM", "TYREEK_NICOLAS", null, "287.468.3404", false, "bfa038b4-825b-41ca-a4fb-2ef2abf3d079", 4, false, "Tyreek_Nicolas" },
                    { "30", 0, 65, "be17bcd3-3366-4c39-b39a-fb0f537828ac", "ApplicationUser", "Alda88@hotmail.com", false, false, null, "ALDA88@HOTMAIL.COM", "WINNIFRED53", null, "245-667-5713 x053", false, "69666bb1-ada3-40fc-8c45-a15648c2e4fa", 4, false, "Winnifred53" },
                    { "31", 0, 77, "a5f74d63-9c06-4d73-ad56-66672e3c665b", "ApplicationUser", "Dovie.Howe@hotmail.com", false, false, null, "DOVIE.HOWE@HOTMAIL.COM", "AIDA_GRIMES22", null, "823.608.0547 x670", false, "70459ae8-f5b7-42cf-85fb-6d5eddea5ec0", 2, false, "Aida_Grimes22" },
                    { "32", 0, 58, "5d10d29a-1d10-4fec-b903-d61073d335bd", "ApplicationUser", "Colt_Mante0@yahoo.com", false, false, null, "COLT_MANTE0@YAHOO.COM", "NORMA43", null, "832-237-3576 x708", false, "3de838ee-d05d-4c9e-adaf-290c10884dc4", 4, false, "Norma43" },
                    { "33", 0, 35, "e7a1eb77-7cf7-4688-9a06-008d69b52dec", "ApplicationUser", "Emmanuel8@gmail.com", false, false, null, "EMMANUEL8@GMAIL.COM", "NICOLAS.RUNOLFSDOTTIR78", null, "1-808-869-8700 x6129", false, "cbdfe5aa-6ea0-4f41-98b8-0adcfacbf347", 2, false, "Nicolas.Runolfsdottir78" },
                    { "34", 0, 57, "2f08f829-c46d-4f83-ab5f-09cfa086267a", "ApplicationUser", "Raymundo.Daugherty75@gmail.com", false, false, null, "RAYMUNDO.DAUGHERTY75@GMAIL.COM", "COLEMAN.HYATT7", null, "1-769-608-2561", false, "77c23c3a-1ee9-40ac-b097-44e6300b4dbc", 3, false, "Coleman.Hyatt7" },
                    { "35", 0, 67, "4affbbea-abf3-4535-8fed-16c214e27e44", "ApplicationUser", "David.Klein@yahoo.com", false, false, null, "DAVID.KLEIN@YAHOO.COM", "PAIGE_KUNDE", null, "510.214.8408 x10395", false, "335150a5-4644-4254-a81d-2734ae68ea85", 4, false, "Paige_Kunde" },
                    { "36", 0, 72, "3a716bda-325e-441c-95b9-a0596c32c0d8", "ApplicationUser", "Herminio_Hermiston@yahoo.com", false, false, null, "HERMINIO_HERMISTON@YAHOO.COM", "LENNIE.VON65", null, "1-833-564-0857 x370", false, "3806e879-b92a-497e-8b07-3b7fbc10e068", 3, false, "Lennie.Von65" },
                    { "37", 0, 67, "002ec604-a981-456f-9bdf-a77dac498c62", "ApplicationUser", "Miles13@yahoo.com", false, false, null, "MILES13@YAHOO.COM", "YESENIA.KRIS", null, "893-948-2204 x7122", false, "2362d3ca-6f0f-468e-ab5b-56169b995f87", 2, false, "Yesenia.Kris" },
                    { "38", 0, 42, "e7f84e7f-0ea2-4ca3-a56b-384a3a06ecc1", "ApplicationUser", "Orion_Morar62@hotmail.com", false, false, null, "ORION_MORAR62@HOTMAIL.COM", "BILLY63", null, "775.471.3180 x1737", false, "b244340e-0ff9-4b06-a5c2-6b62c8d1378f", 3, false, "Billy63" },
                    { "39", 0, 49, "b244f246-d683-49c2-883b-037dd952087f", "ApplicationUser", "Moises_Weber18@hotmail.com", false, false, null, "MOISES_WEBER18@HOTMAIL.COM", "DANIKA_BARTOLETTI", null, "(969) 382-1803", false, "5f4e82e3-e691-419d-972a-814ecb1198c0", 2, false, "Danika_Bartoletti" },
                    { "4", 0, 45, "954e7a15-5e7a-4212-a897-2ad69ffcf676", "ApplicationUser", "Augustine.Wiza16@hotmail.com", false, false, null, "AUGUSTINE.WIZA16@HOTMAIL.COM", "ROSALINDA.JASKOLSKI96", null, "1-553-392-3934", false, "ca8a5e4b-d0b2-4a65-bf94-47930ab333e5", 2, false, "Rosalinda.Jaskolski96" },
                    { "40", 0, 70, "83e8061b-8c85-4035-93e9-e496137c0ff2", "ApplicationUser", "Piper.Johnston@yahoo.com", false, false, null, "PIPER.JOHNSTON@YAHOO.COM", "MAYA.MEDHURST", null, "1-804-477-9981", false, "c9b81289-6f14-45d5-8465-3c2b7fe56d0f", 4, false, "Maya.Medhurst" },
                    { "41", 0, 69, "1c11934c-5bd6-44e8-bebc-ff9b0112afb8", "ApplicationUser", "Ebba66@hotmail.com", false, false, null, "EBBA66@HOTMAIL.COM", "ISRAEL66", null, "958-355-8890 x12808", false, "f5be7342-650b-4733-bf84-415d931d418f", 3, false, "Israel66" },
                    { "42", 0, 36, "b4cf3c3e-26b5-46aa-a09c-a31af0076faf", "ApplicationUser", "Daniella15@hotmail.com", false, false, null, "DANIELLA15@HOTMAIL.COM", "ALLENE_MAYERT", null, "1-891-554-8346 x36819", false, "6cc68d3e-8b2f-41d4-9f7c-527ffba23289", 2, false, "Allene_Mayert" },
                    { "43", 0, 19, "b6997c12-8307-45fa-bca8-9552549f051b", "ApplicationUser", "Deangelo.Wintheiser83@hotmail.com", false, false, null, "DEANGELO.WINTHEISER83@HOTMAIL.COM", "BABY69", null, "(517) 374-4162", false, "4723429d-31a7-4e68-80cb-a0a3cf4427a1", 2, false, "Baby69" },
                    { "44", 0, 22, "e11a1d1c-210b-4dfd-9719-d8bb92775cca", "ApplicationUser", "Jayne_Schultz@gmail.com", false, false, null, "JAYNE_SCHULTZ@GMAIL.COM", "CHESTER_BAYER", null, "521-853-7589", false, "8ac12e29-1238-4166-9002-2e0da6bd7c64", 3, false, "Chester_Bayer" },
                    { "45", 0, 34, "0c8ab53e-80e6-4f25-a52f-03582d01c8ef", "ApplicationUser", "Tatum_Bartoletti54@gmail.com", false, false, null, "TATUM_BARTOLETTI54@GMAIL.COM", "DEVON_LARKIN86", null, "495.680.1956 x88033", false, "9c2aa0ce-1d2f-4026-bea2-137a9e6d9304", 4, false, "Devon_Larkin86" },
                    { "46", 0, 29, "cf6143e2-9405-489c-953d-25dc53086a99", "ApplicationUser", "Zula_Metz71@gmail.com", false, false, null, "ZULA_METZ71@GMAIL.COM", "EARL.NADER39", null, "388.254.2046", false, "321558ed-aa63-48ba-8fc3-445d742d2620", 3, false, "Earl.Nader39" },
                    { "47", 0, 27, "e5925178-4bcd-4988-bc52-d33ef7f76788", "ApplicationUser", "Elta28@hotmail.com", false, false, null, "ELTA28@HOTMAIL.COM", "NEIL.BARROWS64", null, "1-550-516-4693", false, "3055daad-5ac4-4165-9173-f2ddbc80d14a", 3, false, "Neil.Barrows64" },
                    { "48", 0, 24, "a8f40d12-0b4e-4d42-b4be-7c466ab9f590", "ApplicationUser", "Austen.Armstrong73@yahoo.com", false, false, null, "AUSTEN.ARMSTRONG73@YAHOO.COM", "RANDY.BORER", null, "737-917-4991", false, "084c9f9d-ee62-4e29-b2ce-9d8917a5abbd", 3, false, "Randy.Borer" },
                    { "49", 0, 23, "ace62dac-f8ac-47f7-b7c7-9824e8d89cba", "ApplicationUser", "Ophelia.MacGyver@hotmail.com", false, false, null, "OPHELIA.MACGYVER@HOTMAIL.COM", "LIONEL.BEDNAR", null, "(261) 461-6296 x188", false, "c3ea691d-790c-46fa-8d20-edd12a5081b9", 3, false, "Lionel.Bednar" },
                    { "5", 0, 30, "d2baf7dc-da0f-418e-b55d-f3a02d68206d", "ApplicationUser", "Albert61@yahoo.com", false, false, null, "ALBERT61@YAHOO.COM", "RACHELLE.BERGSTROM", null, "482.224.8280 x906", false, "1fcd113c-b21d-4eae-8e55-f296ef125b4b", 2, false, "Rachelle.Bergstrom" },
                    { "50", 0, 64, "cbbfa838-a59f-4630-897d-21d899ea6d5c", "ApplicationUser", "Tyreek55@gmail.com", false, false, null, "TYREEK55@GMAIL.COM", "MATHILDE7", null, "1-935-914-0617 x0951", false, "ab0c48a8-3feb-4b42-9ef4-8b7864e1699c", 2, false, "Mathilde7" },
                    { "51", 0, 14, "9d8f5dd8-9472-425d-aa7f-46ccd5e52aa4", "ApplicationUser", "Lavern.Monahan49@gmail.com", false, false, null, "LAVERN.MONAHAN49@GMAIL.COM", "VITO.KEMMER39", null, "636-517-2954 x95901", false, "d403deea-2861-447e-9842-d38529156a8e", 1, false, "Vito.Kemmer39" },
                    { "52", 0, 25, "cca590b2-6223-4a6e-8814-f8a09fdd29a4", "ApplicationUser", "Emelie.McClure@yahoo.com", false, false, null, "EMELIE.MCCLURE@YAHOO.COM", "PRESTON_NADER17", null, "734-450-3790 x880", false, "d81c7558-8b16-4d92-b8ac-83f648eba296", 4, false, "Preston_Nader17" },
                    { "53", 0, 63, "9b1d3198-d135-41e4-94b5-bbdb378892a1", "ApplicationUser", "Tremayne_Price18@hotmail.com", false, false, null, "TREMAYNE_PRICE18@HOTMAIL.COM", "GASTON_ONDRICKA", null, "696-588-3732 x340", false, "fd4d257b-7072-44a5-8359-7085bac382a6", 3, false, "Gaston_Ondricka" },
                    { "54", 0, 13, "ffe36eeb-0faf-4e12-af95-7c6665120632", "ApplicationUser", "Vincenza60@hotmail.com", false, false, null, "VINCENZA60@HOTMAIL.COM", "REID_SHIELDS36", null, "(733) 892-4641 x45079", false, "84b6297f-81e8-4d42-95ac-6d183d17ba06", 1, false, "Reid_Shields36" },
                    { "55", 0, 51, "5d58ace4-4283-4aad-92e4-778d65371944", "ApplicationUser", "Ned_Kutch3@gmail.com", false, false, null, "NED_KUTCH3@GMAIL.COM", "QUINTON_VANDERVORT", null, "417-367-4605 x5121", false, "fcb10a18-b74f-4331-a94f-7b772e268695", 4, false, "Quinton_Vandervort" },
                    { "56", 0, 62, "43c34bd3-248f-435e-882d-9b5d9a6656f6", "ApplicationUser", "Derek.Bayer40@hotmail.com", false, false, null, "DEREK.BAYER40@HOTMAIL.COM", "META_EBERT", null, "(436) 970-2501 x28047", false, "b7af7efa-58b9-4e81-9520-779fd8ee8f27", 2, false, "Meta_Ebert" },
                    { "57", 0, 63, "233b82bb-083b-43cf-9c29-b6d1be854430", "ApplicationUser", "Lisa89@gmail.com", false, false, null, "LISA89@GMAIL.COM", "ARVILLA50", null, "(426) 843-3300", false, "79e82bf9-2fdd-492a-ad25-f7416a8d1a9c", 3, false, "Arvilla50" },
                    { "58", 0, 39, "1f6bc4d8-058a-4eec-ba11-64c431c7cc49", "ApplicationUser", "Berenice.Frami@gmail.com", false, false, null, "BERENICE.FRAMI@GMAIL.COM", "EZEQUIEL_SKILES", null, "962.209.0484", false, "7d5582ea-2de3-45f7-8058-546d46ea73fe", 4, false, "Ezequiel_Skiles" },
                    { "59", 0, 59, "cdf3af05-190f-4875-8cad-e6fb4158b1f9", "ApplicationUser", "Luella_Paucek58@gmail.com", false, false, null, "LUELLA_PAUCEK58@GMAIL.COM", "EARLINE77", null, "635.465.5110 x571", false, "3625b569-5ea6-40b0-ad17-13a596d70a02", 2, false, "Earline77" },
                    { "6", 0, 59, "2bd52604-c47d-4766-8b1d-952328b9c9de", "ApplicationUser", "Ashlee_Ferry67@hotmail.com", false, false, null, "ASHLEE_FERRY67@HOTMAIL.COM", "CALISTA20", null, "825.343.3229", false, "395dac11-e56d-4d14-a57a-8fda6ebbf536", 4, false, "Calista20" },
                    { "60", 0, 63, "322ce434-733f-4d94-b941-bddf0a9ad71c", "ApplicationUser", "Elyse.Stamm72@hotmail.com", false, false, null, "ELYSE.STAMM72@HOTMAIL.COM", "FLORENCIO_CRONIN92", null, "460-389-9028 x5313", false, "24177e2c-3872-44ea-9474-5eb8019f9f68", 4, false, "Florencio_Cronin92" },
                    { "61", 0, 60, "1afa94bb-1a07-47d0-9a19-aac369070bc0", "ApplicationUser", "Kaden5@gmail.com", false, false, null, "KADEN5@GMAIL.COM", "EZEQUIEL.PROSACCO96", null, "926-313-4674", false, "a5e1a68a-19c0-48e2-bcfb-54d677469317", 2, false, "Ezequiel.Prosacco96" },
                    { "62", 0, 69, "00a09cb5-3ffe-4af5-a795-3c57eec7d155", "ApplicationUser", "Christophe_Pollich86@gmail.com", false, false, null, "CHRISTOPHE_POLLICH86@GMAIL.COM", "KELVIN.BECHTELAR", null, "822.605.5505 x1608", false, "51a7bd77-98a9-4de9-a21c-b3aec9df7e42", 3, false, "Kelvin.Bechtelar" },
                    { "63", 0, 24, "dbeaca60-c6f7-420d-a5e6-032b67667b91", "ApplicationUser", "Savannah_Witting30@gmail.com", false, false, null, "SAVANNAH_WITTING30@GMAIL.COM", "GERRY.MAYER39", null, "419.410.0446 x44903", false, "0403b63a-d770-49a3-903b-40c3838c475c", 4, false, "Gerry.Mayer39" },
                    { "64", 0, 24, "b54b1987-500f-4dea-955e-2c2c92611179", "ApplicationUser", "Wilbert68@yahoo.com", false, false, null, "WILBERT68@YAHOO.COM", "BERRY18", null, "837-585-4406 x646", false, "6239add2-a85e-4a71-aba4-c1c8336fd453", 4, false, "Berry18" },
                    { "65", 0, 13, "5e4a7527-044a-44b6-9cd1-219509324a22", "ApplicationUser", "Leone.Bauch@hotmail.com", false, false, null, "LEONE.BAUCH@HOTMAIL.COM", "SAMARA.KOELPIN", null, "495.635.6933", false, "980e6a46-4809-4563-ab04-2adc33a3e80b", 1, false, "Samara.Koelpin" },
                    { "66", 0, 18, "7b66b67f-f074-40a6-94b2-74b617d14fe5", "ApplicationUser", "Alayna65@gmail.com", false, false, null, "ALAYNA65@GMAIL.COM", "ODIE6", null, "590.855.9878 x3631", false, "7505b99c-d295-459f-b9dc-589fa1224fcf", 3, false, "Odie6" },
                    { "67", 0, 13, "be85c719-8531-4cf7-a01c-f1d6c75e54e3", "ApplicationUser", "Mozell.Nitzsche37@hotmail.com", false, false, null, "MOZELL.NITZSCHE37@HOTMAIL.COM", "CARSON.GOTTLIEB20", null, "923-581-0964", false, "e3dbbfd7-a203-442f-ae92-b525bf51d6c0", 1, false, "Carson.Gottlieb20" },
                    { "68", 0, 58, "7e16f024-0543-48fe-b3db-77c1b20eb193", "ApplicationUser", "Marisa19@yahoo.com", false, false, null, "MARISA19@YAHOO.COM", "DEXTER42", null, "1-516-472-1861", false, "86f0fc26-10ef-4471-a17f-eb8333964b77", 4, false, "Dexter42" },
                    { "69", 0, 57, "08b62f3c-c806-418c-9c82-8e69aa29a39d", "ApplicationUser", "Elvis_Ernser13@gmail.com", false, false, null, "ELVIS_ERNSER13@GMAIL.COM", "DION62", null, "1-283-660-9589 x1467", false, "b777b2b7-fc3d-455c-a8f8-5cfbdc9ef666", 2, false, "Dion62" },
                    { "7", 0, 79, "0dcb0ccd-ca19-40c4-bf6f-a49345813835", "ApplicationUser", "Tyrel.Lockman@hotmail.com", false, false, null, "TYREL.LOCKMAN@HOTMAIL.COM", "MYLENE.FEEST", null, "284.304.3818 x8433", false, "da52f94f-40f4-4783-9d84-3f29e64dd475", 3, false, "Mylene.Feest" },
                    { "70", 0, 27, "52cb4a30-1592-4872-88c7-3f5c9ed287c7", "ApplicationUser", "Catherine.Boyer60@gmail.com", false, false, null, "CATHERINE.BOYER60@GMAIL.COM", "HELLEN.LANGOSH", null, "864-484-1911", false, "32d19f0b-cb6d-4d0c-a425-115cc6bc6a3e", 3, false, "Hellen.Langosh" },
                    { "71", 0, 73, "f3cbb3d5-c9fd-4333-96bb-94346d79860f", "ApplicationUser", "Else.Kerluke@hotmail.com", false, false, null, "ELSE.KERLUKE@HOTMAIL.COM", "KESHAUN.SATTERFIELD", null, "402-581-4507 x420", false, "08c37643-76c1-4b86-82ae-510714ce8f86", 3, false, "Keshaun.Satterfield" },
                    { "72", 0, 53, "1c06c229-d024-4bb8-a6db-5220758e6f85", "ApplicationUser", "Shaniya13@hotmail.com", false, false, null, "SHANIYA13@HOTMAIL.COM", "HASKELL23", null, "1-331-509-0058", false, "09ebba7e-0c33-465b-8597-3ab4b6705be1", 3, false, "Haskell23" },
                    { "73", 0, 27, "d0c4dbdd-5789-48d9-9799-60334ec327c6", "ApplicationUser", "Newell99@hotmail.com", false, false, null, "NEWELL99@HOTMAIL.COM", "PAXTON35", null, "836.946.5652", false, "1c151e53-14f2-4d02-a98f-176eeb2f894f", 2, false, "Paxton35" },
                    { "74", 0, 17, "e73ae7dd-2a1e-47c3-899f-5fca9e7c2cfe", "ApplicationUser", "Rosina_Buckridge55@hotmail.com", false, false, null, "ROSINA_BUCKRIDGE55@HOTMAIL.COM", "WELLINGTON80", null, "720-309-6610 x3258", false, "b09602f8-b68d-4f1d-a209-9da9406c861b", 1, false, "Wellington80" },
                    { "75", 0, 60, "0083525a-0d8f-4f77-97a6-9707bceed4d4", "ApplicationUser", "Albin_Jakubowski34@hotmail.com", false, false, null, "ALBIN_JAKUBOWSKI34@HOTMAIL.COM", "MATHILDE.GORCZANY41", null, "292-955-5449 x9510", false, "23c18fea-22da-4468-988e-b93256638c6e", 4, false, "Mathilde.Gorczany41" },
                    { "76", 0, 40, "5d2be353-74a5-4381-9ad8-ce1a9633cc52", "ApplicationUser", "Roy_Flatley@hotmail.com", false, false, null, "ROY_FLATLEY@HOTMAIL.COM", "JORDON36", null, "1-710-674-1085", false, "d2a28600-2118-4b85-b503-79e27d33123d", 2, false, "Jordon36" },
                    { "77", 0, 38, "54732b0d-5ece-43de-8802-56b1d55348e2", "ApplicationUser", "Monique32@yahoo.com", false, false, null, "MONIQUE32@YAHOO.COM", "GUST_FISHER29", null, "526.430.5067 x89507", false, "c788c4e4-fd10-4fad-9bb9-01a505834503", 2, false, "Gust_Fisher29" },
                    { "78", 0, 48, "ca75f08b-6d9e-40bb-b6fa-a6f920c0695e", "ApplicationUser", "Vickie_Mann12@gmail.com", false, false, null, "VICKIE_MANN12@GMAIL.COM", "FRANCISCO77", null, "312-275-7145 x473", false, "53d4b81f-f87c-4ab4-b6fb-3199dbd0fc62", 4, false, "Francisco77" },
                    { "79", 0, 37, "e75f27c7-7ace-4308-8995-40bf9a4d1421", "ApplicationUser", "Avery.Kertzmann@gmail.com", false, false, null, "AVERY.KERTZMANN@GMAIL.COM", "MICHAELA_BALISTRERI99", null, "1-595-685-3820 x1405", false, "6333e3e6-069a-4633-a7b1-eb0aeeebb673", 2, false, "Michaela_Balistreri99" },
                    { "8", 0, 22, "df935bf7-0584-42f3-ab32-392573e4aa0e", "ApplicationUser", "Gabrielle_Schneider86@gmail.com", false, false, null, "GABRIELLE_SCHNEIDER86@GMAIL.COM", "EMMIE.BORER24", null, "231.231.8645", false, "b4d2f26c-3f3a-4bb2-b529-ff51fc9b22eb", 3, false, "Emmie.Borer24" },
                    { "80", 0, 14, "d8027371-521f-4cb5-a67f-1686bafa98c7", "ApplicationUser", "Lilliana_Schneider@hotmail.com", false, false, null, "LILLIANA_SCHNEIDER@HOTMAIL.COM", "ANGELITA_MAYERT", null, "(704) 915-5956 x1366", false, "b0d63e4d-0856-4223-81b6-33339057a8ef", 1, false, "Angelita_Mayert" },
                    { "81", 0, 19, "18149e8b-1ff0-4c60-826d-7ecc6cd5ea54", "ApplicationUser", "Retta59@yahoo.com", false, false, null, "RETTA59@YAHOO.COM", "ZITA.DAVIS", null, "294-563-6131 x67106", false, "9f193cf5-a08a-4107-8e30-c01a7413df8e", 2, false, "Zita.Davis" },
                    { "82", 0, 59, "1dd08482-0f2e-4234-975f-df4c10774a89", "ApplicationUser", "Karolann22@hotmail.com", false, false, null, "KAROLANN22@HOTMAIL.COM", "KIERAN_BRAUN6", null, "(474) 565-6610 x139", false, "1a0a7899-1d66-4abc-bac9-ffc8407125f1", 4, false, "Kieran_Braun6" },
                    { "83", 0, 39, "b6d8f9dc-f0e7-4308-8969-72cdf7d3e9e4", "ApplicationUser", "Yvonne_Borer@hotmail.com", false, false, null, "YVONNE_BORER@HOTMAIL.COM", "KAMILLE26", null, "(520) 285-5485 x48901", false, "4f632b50-12da-46db-9f30-8b593e92eb36", 3, false, "Kamille26" },
                    { "84", 0, 70, "312129f7-ff2c-4d02-9f18-af3a4da6c6c8", "ApplicationUser", "Yoshiko54@yahoo.com", false, false, null, "YOSHIKO54@YAHOO.COM", "BRYANA.RODRIGUEZ", null, "246-645-1055", false, "de7a5e6a-dbb3-452d-a9f0-d2dd22143c22", 4, false, "Bryana.Rodriguez" },
                    { "85", 0, 19, "f1f75b49-40d5-42b9-b211-561e21a8a2be", "ApplicationUser", "Lina54@yahoo.com", false, false, null, "LINA54@YAHOO.COM", "DAX59", null, "441.423.1035 x257", false, "0473a8b8-4ac9-4d29-92db-9dac51021881", 3, false, "Dax59" },
                    { "86", 0, 28, "12f06782-c2d6-45fa-9f4b-cf71b8e92c80", "ApplicationUser", "Dejuan24@yahoo.com", false, false, null, "DEJUAN24@YAHOO.COM", "CHADD.FRIESEN14", null, "(737) 698-7332 x5093", false, "40d97b34-9f06-4224-8e8b-7737dd9361eb", 4, false, "Chadd.Friesen14" },
                    { "87", 0, 30, "536aef7a-9507-401e-9a2e-dbadb83f0625", "ApplicationUser", "Waylon.Schaefer@gmail.com", false, false, null, "WAYLON.SCHAEFER@GMAIL.COM", "CARLO.LESCH89", null, "464-653-5935 x19456", false, "3ee0928a-cc9a-41ab-96a3-80793ba7a273", 3, false, "Carlo.Lesch89" },
                    { "88", 0, 24, "6d167c54-8a71-4b4a-a00d-8c1be824f0a7", "ApplicationUser", "Noah_Cartwright@gmail.com", false, false, null, "NOAH_CARTWRIGHT@GMAIL.COM", "DOROTHEA.KERLUKE", null, "1-359-824-1765 x5565", false, "8ea1caf3-2b18-44f3-aeb8-9b1f4e5b7dd7", 2, false, "Dorothea.Kerluke" },
                    { "89", 0, 76, "908b8d81-b8df-429b-983f-5e8c3e110d8a", "ApplicationUser", "Paxton_Bernhard@yahoo.com", false, false, null, "PAXTON_BERNHARD@YAHOO.COM", "JAEDEN71", null, "896-870-3423 x7553", false, "ef00a539-5507-4cc5-80b3-b911e7252bc4", 2, false, "Jaeden71" },
                    { "9", 0, 17, "8a92fb6c-02af-48b4-912e-28c1c0749014", "ApplicationUser", "Kailey.Morissette@gmail.com", false, false, null, "KAILEY.MORISSETTE@GMAIL.COM", "LELAH_FRAMI74", null, "(817) 823-0418 x2895", false, "d2664602-d946-4c59-8ce4-c9d8d4fe0d72", 1, false, "Lelah_Frami74" },
                    { "90", 0, 49, "c0443c94-4d42-48db-ad00-b862b7ddd4a0", "ApplicationUser", "Micaela.Thiel13@yahoo.com", false, false, null, "MICAELA.THIEL13@YAHOO.COM", "LUISA.SAWAYN63", null, "284.466.9914 x2502", false, "e6c397e8-60a4-4569-bb9b-91fbe8882493", 2, false, "Luisa.Sawayn63" },
                    { "91", 0, 65, "47573176-e3d5-4480-8820-18daa139577b", "ApplicationUser", "Cleveland.Homenick93@yahoo.com", false, false, null, "CLEVELAND.HOMENICK93@YAHOO.COM", "OSWALDO.HEATHCOTE", null, "(535) 645-5200 x636", false, "0019548a-2533-4731-88ac-c3a712f587c6", 4, false, "Oswaldo.Heathcote" },
                    { "92", 0, 39, "adb838b6-02c5-4413-bc1f-873e2e185c59", "ApplicationUser", "Maynard.Cronin@gmail.com", false, false, null, "MAYNARD.CRONIN@GMAIL.COM", "POLLY31", null, "(235) 585-8622 x1112", false, "b4bd0365-5ec8-4e56-ba5e-7ca839a0d733", 4, false, "Polly31" },
                    { "93", 0, 15, "60a02f9c-b8cc-4b85-9101-bd97c97ff261", "ApplicationUser", "Kade42@hotmail.com", false, false, null, "KADE42@HOTMAIL.COM", "TERRENCE.FERRY74", null, "1-210-603-8204 x05738", false, "dd453f9e-d397-4f0a-b320-96ca9d5ab8ae", 1, false, "Terrence.Ferry74" },
                    { "94", 0, 66, "a2855a2e-f5da-4526-bc24-206374ffe85c", "ApplicationUser", "Frankie81@yahoo.com", false, false, null, "FRANKIE81@YAHOO.COM", "TANNER.DARE56", null, "(649) 519-7247 x873", false, "6ab6c76a-674c-4ae2-b3e4-f04f5f2c4204", 4, false, "Tanner.Dare56" },
                    { "95", 0, 29, "842980c3-087a-4f06-9a37-ed811dddd9d6", "ApplicationUser", "Raegan45@gmail.com", false, false, null, "RAEGAN45@GMAIL.COM", "ZOIE.ZBONCAK", null, "318.931.0553 x615", false, "09edc52d-674f-445f-a43f-205ad224a0b4", 4, false, "Zoie.Zboncak" },
                    { "96", 0, 61, "aa7e2fba-c882-402a-8423-9d77c16728d7", "ApplicationUser", "Darrin.Ledner@yahoo.com", false, false, null, "DARRIN.LEDNER@YAHOO.COM", "EUDORA.HAHN48", null, "(672) 447-6767", false, "40524587-c344-488f-bf52-9b4d8733cfc4", 2, false, "Eudora.Hahn48" },
                    { "97", 0, 18, "ccb64200-1e52-47d7-830a-09cd89a97b13", "ApplicationUser", "Bertram.Roob@hotmail.com", false, false, null, "BERTRAM.ROOB@HOTMAIL.COM", "GUSSIE.BORER67", null, "404.702.5354 x7856", false, "33eaa796-e392-46cc-ae5d-6a23dd348697", 3, false, "Gussie.Borer67" },
                    { "98", 0, 55, "aa47999d-e73b-41bf-82b3-7bc9715bcebf", "ApplicationUser", "Oren12@gmail.com", false, false, null, "OREN12@GMAIL.COM", "BEVERLY42", null, "(892) 845-4069", false, "a3c15249-9439-462e-ac17-7e90b4fe5942", 3, false, "Beverly42" },
                    { "99", 0, 34, "385b72d2-0bfc-48f3-bb23-f71fafb9c894", "ApplicationUser", "Cameron.Hoeger@gmail.com", false, false, null, "CAMERON.HOEGER@GMAIL.COM", "VICTOR.TROMP", null, "1-555-917-9339", false, "5bc203a1-fd7a-43c8-8951-dcf186409ef3", 3, false, "Victor.Tromp" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 17, 2, "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Fish", 2008 },
                    { 2, 2, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Frozen Bacon", 2007 },
                    { 3, 1, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Plastic Soap", 2011 },
                    { 4, 17, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Concrete Table", 2014 },
                    { 5, 17, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Hat", 2000 },
                    { 6, 2, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Pants", 2020 },
                    { 7, 14, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Rubber Chair", 2005 },
                    { 8, 19, 1, "The Football Is Good For Training And Recreational Purposes", "Practical Concrete Towels", 2002 },
                    { 9, 9, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Sleek Metal Mouse", 2017 },
                    { 10, 19, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Towels", 2014 },
                    { 11, 15, 1, "The Football Is Good For Training And Recreational Purposes", "Practical Plastic Gloves", 2008 },
                    { 12, 4, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Wooden Shoes", 2001 },
                    { 13, 18, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Cotton Sausages", 2013 },
                    { 14, 6, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Granite Bacon", 2008 },
                    { 15, 15, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Wooden Bike", 2020 },
                    { 16, 7, 1, "The Football Is Good For Training And Recreational Purposes", "Intelligent Cotton Fish", 2019 },
                    { 17, 6, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Wooden Tuna", 2020 },
                    { 18, 19, 5, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Hat", 2006 },
                    { 19, 13, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Soft Salad", 2023 },
                    { 20, 12, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Rubber Pizza", 2023 },
                    { 21, 8, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Rubber Pizza", 2007 },
                    { 22, 11, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Metal Hat", 2020 },
                    { 23, 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Wooden Soap", 2009 },
                    { 24, 14, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Steel Car", 2001 },
                    { 25, 8, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Fresh Salad", 2001 },
                    { 26, 11, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Awesome Rubber Keyboard", 2006 },
                    { 27, 15, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Rubber Mouse", 2004 },
                    { 28, 10, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Wooden Hat", 2021 },
                    { 29, 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Plastic Cheese", 2003 },
                    { 30, 16, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Rubber Chair", 2005 },
                    { 31, 16, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Granite Car", 2014 },
                    { 32, 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Rubber Computer", 2016 },
                    { 33, 18, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Granite Shoes", 2002 },
                    { 34, 13, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Concrete Towels", 2018 },
                    { 35, 16, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Rubber Computer", 2013 },
                    { 36, 16, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Concrete Chicken", 2012 },
                    { 37, 1, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Rubber Sausages", 2022 },
                    { 38, 7, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Metal Tuna", 2015 },
                    { 39, 5, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Rubber Towels", 2006 },
                    { 40, 11, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Frozen Shirt", 2021 },
                    { 41, 2, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Wooden Pants", 2021 },
                    { 42, 2, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Concrete Sausages", 2015 },
                    { 43, 4, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Practical Soft Soap", 2006 },
                    { 44, 8, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Wooden Fish", 2009 },
                    { 45, 7, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Metal Gloves", 2023 },
                    { 46, 17, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Concrete Bike", 2013 },
                    { 47, 10, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Cotton Computer", 2008 },
                    { 48, 4, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Concrete Shirt", 2013 },
                    { 49, 5, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Table", 2011 },
                    { 50, 18, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Pants", 2015 },
                    { 51, 10, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Cotton Shoes", 2003 },
                    { 52, 6, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Granite Fish", 2022 },
                    { 53, 5, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Fresh Computer", 2007 },
                    { 54, 19, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Metal Chair", 2015 },
                    { 55, 16, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Concrete Bacon", 2002 },
                    { 56, 18, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Rubber Car", 2007 },
                    { 57, 4, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Concrete Shoes", 2022 },
                    { 58, 18, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Fresh Mouse", 2005 },
                    { 59, 9, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Cotton Car", 2003 },
                    { 60, 11, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Soft Pizza", 2022 },
                    { 61, 18, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Sausages", 2007 },
                    { 62, 16, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Plastic Fish", 2000 },
                    { 63, 11, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Plastic Computer", 2015 },
                    { 64, 20, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Metal Computer", 2005 },
                    { 65, 2, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Wooden Table", 2011 },
                    { 66, 17, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Wooden Bike", 2012 },
                    { 67, 7, 1, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Tuna", 2003 },
                    { 68, 9, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Rubber Car", 2016 },
                    { 69, 16, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Granite Pants", 2011 },
                    { 70, 20, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Steel Computer", 2003 },
                    { 71, 2, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Cotton Pizza", 2010 },
                    { 72, 4, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Sleek Plastic Pizza", 2020 },
                    { 73, 3, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Metal Keyboard", 2001 },
                    { 74, 5, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Concrete Mouse", 2007 },
                    { 75, 15, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Granite Tuna", 2018 },
                    { 76, 15, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Plastic Bacon", 2021 },
                    { 77, 1, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Metal Towels", 2003 },
                    { 78, 15, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Metal Fish", 2001 },
                    { 79, 9, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Steel Cheese", 2009 },
                    { 80, 8, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Rubber Pizza", 2017 },
                    { 81, 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Metal Car", 2017 },
                    { 82, 9, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Plastic Computer", 2022 },
                    { 83, 4, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Plastic Bike", 2005 },
                    { 84, 10, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Frozen Sausages", 2006 },
                    { 85, 20, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Chair", 2021 },
                    { 86, 11, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Fresh Gloves", 2005 },
                    { 87, 6, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Frozen Keyboard", 2019 },
                    { 88, 17, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Shoes", 2001 },
                    { 89, 20, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Steel Tuna", 2023 },
                    { 90, 7, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Frozen Keyboard", 2009 },
                    { 91, 5, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Chair", 2019 },
                    { 92, 15, 3, "The Football Is Good For Training And Recreational Purposes", "Sleek Granite Chips", 2014 },
                    { 93, 15, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Rubber Ball", 2014 },
                    { 94, 1, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Plastic Cheese", 2018 },
                    { 95, 17, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Concrete Hat", 2019 },
                    { 96, 1, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Steel Computer", 2002 },
                    { 97, 16, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Granite Keyboard", 2006 },
                    { 98, 19, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Granite Car", 2010 },
                    { 99, 11, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Frozen Hat", 2000 },
                    { 100, 10, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Plastic Car", 2016 }
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
