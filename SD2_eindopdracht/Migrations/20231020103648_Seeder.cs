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
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "ff890929-2fed-46a3-95a7-68fa4c9cfb12", "Daphne_Braun83@yahoo.com", false, false, null, "DAPHNE_BRAUN83@YAHOO.COM", "LANEY_YUNDT", null, "574-578-4875", false, "a70939e6-cc8e-403e-8282-d4e51a458a66", null, false, "Laney_Yundt" },
                    { "10", 0, "d34d7ae2-c05e-4f7c-966c-b534a3eecbea", "Annie_Bins@yahoo.com", false, false, null, "ANNIE_BINS@YAHOO.COM", "FELIPE_ORTIZ0", null, "1-908-552-7467 x5605", false, "539c178b-d7a1-4e67-beab-a5c506f2599a", null, false, "Felipe_Ortiz0" },
                    { "100", 0, "0eaf1585-b4c1-4834-8551-33d1e6ea0674", "Bryce.Kihn92@hotmail.com", false, false, null, "BRYCE.KIHN92@HOTMAIL.COM", "DON87", null, "728-862-5515", false, "9b58be0b-58bd-455e-8166-1d8d1e04b571", null, false, "Don87" },
                    { "11", 0, "56f15e14-78eb-4c9f-879c-cbe7d07d40f8", "Claudia_Rempel47@hotmail.com", false, false, null, "CLAUDIA_REMPEL47@HOTMAIL.COM", "PAOLO79", null, "(823) 355-9683", false, "617f18a1-9b84-4f8c-827c-b99d19bad58e", null, false, "Paolo79" },
                    { "12", 0, "35a69fa9-9d52-4d5e-a909-80dba1a2af7b", "Osvaldo48@hotmail.com", false, false, null, "OSVALDO48@HOTMAIL.COM", "JEAN_LINDGREN", null, "(616) 410-8679 x1122", false, "9055fdef-76b8-4f73-8950-6f68a992b3f7", null, false, "Jean_Lindgren" },
                    { "13", 0, "010c110b-df9a-4c83-81c5-0ffec0e7632e", "Hailey68@hotmail.com", false, false, null, "HAILEY68@HOTMAIL.COM", "CLINTON32", null, "1-654-929-1346 x005", false, "12f56758-c91e-445c-839c-87e1e68f0a74", null, false, "Clinton32" },
                    { "14", 0, "d0d7ece0-a402-4031-803a-69778a2ffa33", "Giles.Durgan43@hotmail.com", false, false, null, "GILES.DURGAN43@HOTMAIL.COM", "DARREL_WILL", null, "956-373-3487", false, "5415beda-49e1-41c9-b437-04343e842920", null, false, "Darrel_Will" },
                    { "15", 0, "2fab80cb-8653-4455-86c6-2f24131e59fd", "Johnathan.Schaden@yahoo.com", false, false, null, "JOHNATHAN.SCHADEN@YAHOO.COM", "TALON_NICOLAS33", null, "543-210-0319", false, "02560fe9-c7fb-4639-8e54-af51af25004b", null, false, "Talon_Nicolas33" },
                    { "16", 0, "22ab91ad-7f79-4fec-a812-7bc250114403", "Shanna.Harber18@yahoo.com", false, false, null, "SHANNA.HARBER18@YAHOO.COM", "NILS44", null, "(307) 730-5893 x750", false, "ca97d006-47ef-486a-9c93-7ab9d5f9ed34", null, false, "Nils44" },
                    { "17", 0, "8007ebb5-a238-4b17-832d-29d3b3c6c9dc", "Christ.Hermann5@hotmail.com", false, false, null, "CHRIST.HERMANN5@HOTMAIL.COM", "DANGELO.HUEL77", null, "1-381-204-3814 x0121", false, "b38483d2-a412-4b84-893f-253dfb15417e", null, false, "Dangelo.Huel77" },
                    { "18", 0, "a278de28-d3d1-4562-a685-abeade690534", "Braulio.Champlin15@gmail.com", false, false, null, "BRAULIO.CHAMPLIN15@GMAIL.COM", "TRACY_BERGSTROM", null, "327.772.7791", false, "f3a71189-d3e2-47f1-921b-8fb068752f15", null, false, "Tracy_Bergstrom" },
                    { "19", 0, "6e9a483e-b079-4f19-b25d-94569838b7ae", "Reina_Glover@hotmail.com", false, false, null, "REINA_GLOVER@HOTMAIL.COM", "ALEK49", null, "1-348-479-7329 x515", false, "47a6eeaa-e392-4696-a012-0cc88cead7e5", null, false, "Alek49" },
                    { "2", 0, "812ba55f-c725-418b-a0eb-ef6c0cca401f", "Madison_Rippin@gmail.com", false, false, null, "MADISON_RIPPIN@GMAIL.COM", "QUEEN_VOLKMAN", null, "680-354-6608 x300", false, "2f33b1e4-09c9-4bc0-9449-13e287c57fa5", null, false, "Queen_Volkman" },
                    { "20", 0, "0c9ac4e2-7091-4eb1-94cb-ed4621aa29ac", "Kamille.Wilderman82@gmail.com", false, false, null, "KAMILLE.WILDERMAN82@GMAIL.COM", "KELSI96", null, "477.264.9201", false, "0dd5bcf3-fdf3-4b2e-8ed2-aeb239243d6d", null, false, "Kelsi96" },
                    { "21", 0, "1ce501b7-4018-4430-94aa-4b336af02b30", "Maud81@gmail.com", false, false, null, "MAUD81@GMAIL.COM", "VERNICE.JENKINS42", null, "359-586-8305", false, "60ea2a08-ce0a-45a2-82f0-98ebe02f700d", null, false, "Vernice.Jenkins42" },
                    { "22", 0, "e1eacd1f-9f09-41a0-99d3-46174b5ff0b1", "Myah.Reinger@yahoo.com", false, false, null, "MYAH.REINGER@YAHOO.COM", "WINSTON_BERNIER2", null, "(937) 704-6702 x2765", false, "42b07e99-1036-4a87-a345-80ffcc000684", null, false, "Winston_Bernier2" },
                    { "23", 0, "37b3a9b4-cb11-4a57-9a53-13a1cbe6fe94", "Edwina.Sauer@hotmail.com", false, false, null, "EDWINA.SAUER@HOTMAIL.COM", "AUBREY.SCHADEN10", null, "204-907-5548 x355", false, "9435c2bb-127e-41a4-b13b-20bdff14bacc", null, false, "Aubrey.Schaden10" },
                    { "24", 0, "f36fd537-2184-4756-912b-f5942d6b4744", "Leanne.Heathcote30@gmail.com", false, false, null, "LEANNE.HEATHCOTE30@GMAIL.COM", "BRITNEY_HAYES50", null, "(355) 630-4098", false, "bf8b3585-45ad-46c6-a57b-c9d246676e8f", null, false, "Britney_Hayes50" },
                    { "25", 0, "2c5fe10f-6c61-4bf7-bb26-c41493ae55bd", "Vella.Prosacco@hotmail.com", false, false, null, "VELLA.PROSACCO@HOTMAIL.COM", "SHARON.DIETRICH", null, "1-524-883-4683", false, "5adb6012-58d6-45bf-aa15-578897a2f0b6", null, false, "Sharon.Dietrich" },
                    { "26", 0, "b083f46c-f08c-41c8-9df2-ddb1af53b3f8", "Trudie.Glover@yahoo.com", false, false, null, "TRUDIE.GLOVER@YAHOO.COM", "MARQUES_BECKER38", null, "212.605.4863 x816", false, "6ed997cc-0780-4478-84a5-2bdf2f381a13", null, false, "Marques_Becker38" },
                    { "27", 0, "5d4f74cb-53fe-4dba-b6b8-6f921534a06e", "Emmanuelle72@hotmail.com", false, false, null, "EMMANUELLE72@HOTMAIL.COM", "LORA49", null, "(233) 616-2751", false, "6bec6d05-068a-4734-8255-164609b9701d", null, false, "Lora49" },
                    { "28", 0, "a8955dae-9889-4544-bdc2-6a2c7c01b6d1", "Brenna_Barrows48@gmail.com", false, false, null, "BRENNA_BARROWS48@GMAIL.COM", "CITLALLI.MOEN79", null, "(729) 733-0943 x17426", false, "014c2743-b94a-436e-929a-833e6a978b22", null, false, "Citlalli.Moen79" },
                    { "29", 0, "a234e921-3b70-4570-8f27-2d409b8bfb11", "Melyssa98@gmail.com", false, false, null, "MELYSSA98@GMAIL.COM", "KENYATTA_RUNOLFSDOTTIR", null, "(925) 929-5679 x274", false, "e3af4cf8-7207-4a1e-8956-a75a05e8d293", null, false, "Kenyatta_Runolfsdottir" },
                    { "3", 0, "2861ce31-8146-4035-affa-8f95ad9e3a5b", "Kelsie_Rau@yahoo.com", false, false, null, "KELSIE_RAU@YAHOO.COM", "ALDA.STOLTENBERG5", null, "792.616.2293", false, "61283052-c8f2-41ce-9260-58bb7b4ca376", null, false, "Alda.Stoltenberg5" },
                    { "30", 0, "4eede680-5b4a-43e6-9cae-7aa4bd01e064", "Preston_Olson23@gmail.com", false, false, null, "PRESTON_OLSON23@GMAIL.COM", "MILO_MOHR", null, "372-660-9465", false, "26d2050f-2610-4143-b68f-5b2432b804bc", null, false, "Milo_Mohr" },
                    { "31", 0, "0e5fc2e0-0048-4fe1-b266-8dac03724483", "Gerhard_Nikolaus87@hotmail.com", false, false, null, "GERHARD_NIKOLAUS87@HOTMAIL.COM", "PAULA.LEHNER", null, "1-710-392-5818", false, "4f0d842b-a3a5-4bc2-be9a-ce2e2095c46c", null, false, "Paula.Lehner" },
                    { "32", 0, "05913c6d-9d9f-43c7-baf2-25d6ec18ee20", "Ally0@yahoo.com", false, false, null, "ALLY0@YAHOO.COM", "MAXWELL_ARMSTRONG", null, "(669) 707-3606 x7595", false, "3876213f-167b-41eb-9ed3-e27371af279f", null, false, "Maxwell_Armstrong" },
                    { "33", 0, "6cd03b19-6f90-4a65-b871-ff5ce7f38a88", "Alphonso.Ward88@gmail.com", false, false, null, "ALPHONSO.WARD88@GMAIL.COM", "AURORE.WHITE43", null, "(995) 987-4206 x5203", false, "050f2046-6f90-49f7-9703-e4d4eb50ab15", null, false, "Aurore.White43" },
                    { "34", 0, "a13b809f-4f9b-4155-9bc5-cc09287403de", "Dallas68@hotmail.com", false, false, null, "DALLAS68@HOTMAIL.COM", "ANA_WHITE", null, "1-234-331-7028", false, "aa8f816f-cf53-441d-b796-0cc2068cb723", null, false, "Ana_White" },
                    { "35", 0, "0a94afed-bcdb-46d8-bbc1-3f91669c7dc9", "Felton38@hotmail.com", false, false, null, "FELTON38@HOTMAIL.COM", "BARBARA.MCDERMOTT", null, "(921) 243-1116", false, "6eb0fdf2-f6cf-4de2-ad63-5c1be5a3c454", null, false, "Barbara.McDermott" },
                    { "36", 0, "4efff8a1-4083-452f-a8b1-87f2eafaa250", "Roberto_Grimes@yahoo.com", false, false, null, "ROBERTO_GRIMES@YAHOO.COM", "RASHEED61", null, "(668) 372-7662 x29696", false, "6897f0ce-0e48-4014-a004-bbb657719858", null, false, "Rasheed61" },
                    { "37", 0, "92ee3a52-d2b5-42eb-a248-27179cdaccc3", "Jamie.Heller@yahoo.com", false, false, null, "JAMIE.HELLER@YAHOO.COM", "EMMIE.UPTON", null, "1-328-684-3650 x151", false, "fc6d3713-be85-4f29-988d-9b29b81a1a59", null, false, "Emmie.Upton" },
                    { "38", 0, "9aee7f40-767d-49c9-bffd-16973d776f45", "Marcella.Abernathy@yahoo.com", false, false, null, "MARCELLA.ABERNATHY@YAHOO.COM", "WALLACE.SCHULTZ41", null, "745.396.6322", false, "d2422ea8-b7c8-4fb8-9f23-67c846c8b2c6", null, false, "Wallace.Schultz41" },
                    { "39", 0, "d227f80d-122c-4f61-aee2-9e270632df74", "Kristy0@gmail.com", false, false, null, "KRISTY0@GMAIL.COM", "ROSIE47", null, "(877) 822-9445", false, "a303db94-d0b4-4fa4-acd0-f6e8389021da", null, false, "Rosie47" },
                    { "4", 0, "b7fc91dc-11b7-4faa-8d12-091c104eab8c", "Billie.Bogisich4@gmail.com", false, false, null, "BILLIE.BOGISICH4@GMAIL.COM", "FRITZ_MERTZ", null, "1-712-447-3960 x4996", false, "90bf355e-01ab-469e-b7b8-15f2f5cfbad8", null, false, "Fritz_Mertz" },
                    { "40", 0, "2c8d61df-908d-41ea-8dcc-0932ced831c0", "Marlee45@yahoo.com", false, false, null, "MARLEE45@YAHOO.COM", "SHANELLE_BRAUN56", null, "816-218-8338", false, "016e5782-bd95-4ea1-9e2e-ebc4d1143f51", null, false, "Shanelle_Braun56" },
                    { "41", 0, "d42d31dd-0cd7-4f3c-bf89-c33b5a2f4c1b", "Charlene0@yahoo.com", false, false, null, "CHARLENE0@YAHOO.COM", "JERROD.LEGROS", null, "(217) 396-8881 x8739", false, "8bb35592-5d36-4ec5-b2bd-ee8c47e4f6a1", null, false, "Jerrod.Legros" },
                    { "42", 0, "32dd4eef-e40f-454b-8b4d-a1208ba72865", "Henriette45@gmail.com", false, false, null, "HENRIETTE45@GMAIL.COM", "ROSANNA_MACGYVER", null, "335.217.4862 x4111", false, "bd96e095-dd0d-414f-94de-79fabb514ddf", null, false, "Rosanna_MacGyver" },
                    { "43", 0, "58dea083-9e9b-4499-a306-5bff2a09a5d9", "Freddy_Bosco@gmail.com", false, false, null, "FREDDY_BOSCO@GMAIL.COM", "GARFIELD.GRANT11", null, "782-215-1400", false, "eb36cc1c-b471-4ca2-b92a-9b228fe95f0f", null, false, "Garfield.Grant11" },
                    { "44", 0, "aef9ab9c-b18a-46b7-9cc2-66864c152b9a", "Derick_Heaney80@gmail.com", false, false, null, "DERICK_HEANEY80@GMAIL.COM", "JEVON.SCHMITT", null, "238-657-7938", false, "a3044dd9-baa7-4691-b08c-9073ed5bf5f4", null, false, "Jevon.Schmitt" },
                    { "45", 0, "bde0063d-ca95-4d04-a1a9-32fae36815bd", "Herbert.Ruecker@yahoo.com", false, false, null, "HERBERT.RUECKER@YAHOO.COM", "LOUIE93", null, "1-234-455-4564 x26933", false, "15ebbe24-3b64-452d-85eb-f3ba84c41bbd", null, false, "Louie93" },
                    { "46", 0, "9a386eca-c97a-4137-a83a-cdde2529eb22", "Anahi.Considine@gmail.com", false, false, null, "ANAHI.CONSIDINE@GMAIL.COM", "ALVENA49", null, "(393) 757-9281", false, "7f5ec8f4-c9be-4aea-a3e0-52527d722a93", null, false, "Alvena49" },
                    { "47", 0, "500357f3-52b8-4fff-a90f-41a9b31a1703", "Keith_OReilly@yahoo.com", false, false, null, "KEITH_OREILLY@YAHOO.COM", "KEANU.WATERS86", null, "933.233.4503", false, "b180bca0-f88b-462e-a342-83d10e329960", null, false, "Keanu.Waters86" },
                    { "48", 0, "575b35fc-b683-47a3-bc1a-0f387b6cb2cf", "Cade29@gmail.com", false, false, null, "CADE29@GMAIL.COM", "MARSHALL5", null, "1-211-627-4622", false, "e896e618-0ffc-42d1-98aa-55dd7542771d", null, false, "Marshall5" },
                    { "49", 0, "118d825a-0a34-4381-89fb-c8a0b69158a0", "Rosie72@hotmail.com", false, false, null, "ROSIE72@HOTMAIL.COM", "MADDISON.HODKIEWICZ", null, "663.995.7569 x75862", false, "47817479-e0f9-45fd-95f3-1e3960119cfd", null, false, "Maddison.Hodkiewicz" },
                    { "5", 0, "0df3ddc3-c39d-417a-bf53-aa55b678f2f9", "Treva.Abbott44@yahoo.com", false, false, null, "TREVA.ABBOTT44@YAHOO.COM", "HIPOLITO65", null, "(861) 438-2137 x0522", false, "3bc53a30-2ee5-452d-a2a0-96b5a4167b0d", null, false, "Hipolito65" },
                    { "50", 0, "314b7216-9fb2-4f86-8bd1-b88856ee7c75", "Jayda.Terry83@yahoo.com", false, false, null, "JAYDA.TERRY83@YAHOO.COM", "ADRIANNA_ARMSTRONG", null, "(276) 980-6524", false, "d7e7c7f2-cb3e-409e-add1-66f2cd48560b", null, false, "Adrianna_Armstrong" },
                    { "51", 0, "4f195bff-9c62-49e7-8f68-ba6c2496e66a", "Geovanny.Champlin@hotmail.com", false, false, null, "GEOVANNY.CHAMPLIN@HOTMAIL.COM", "HERMINA_HILPERT", null, "1-897-515-8436", false, "02a12861-81ec-4b66-a67d-23ae3f6207f1", null, false, "Hermina_Hilpert" },
                    { "52", 0, "ab16c61f-3817-45e5-8521-1aa26755f3dd", "Ora.Nader@gmail.com", false, false, null, "ORA.NADER@GMAIL.COM", "ABRAHAM_SWIFT", null, "318.389.7215", false, "af60f6f8-14e2-423a-963e-467077d16b28", null, false, "Abraham_Swift" },
                    { "53", 0, "f246d4f7-9b0e-4b11-af6e-c0c4e58f377c", "Tobin.Ratke31@gmail.com", false, false, null, "TOBIN.RATKE31@GMAIL.COM", "MARCOS.EFFERTZ", null, "972-265-8989 x9967", false, "ca6f0407-21b8-4440-ada7-64e31cb55431", null, false, "Marcos.Effertz" },
                    { "54", 0, "2df0a47b-8be6-4e19-9ea3-cd2689f1854a", "Romaine_Abernathy@yahoo.com", false, false, null, "ROMAINE_ABERNATHY@YAHOO.COM", "JOEY.MERTZ", null, "855.324.6818", false, "7915ee3b-84e3-4c32-b290-5caa9b3fed18", null, false, "Joey.Mertz" },
                    { "55", 0, "b59bc081-e8e9-4e2e-9c40-79b9614b0aad", "Gerardo_Bernier88@yahoo.com", false, false, null, "GERARDO_BERNIER88@YAHOO.COM", "BERNADINE.LUEILWITZ11", null, "988.799.2640 x24942", false, "ea3bc911-7d47-4b6b-9fce-6506bed447a8", null, false, "Bernadine.Lueilwitz11" },
                    { "56", 0, "0d328b7a-aa9c-4174-a53e-004899777a0b", "Darius.Purdy@yahoo.com", false, false, null, "DARIUS.PURDY@YAHOO.COM", "URSULA12", null, "(579) 572-2338 x654", false, "a0d8e341-aaac-45bf-af0e-ca9e5fb009c2", null, false, "Ursula12" },
                    { "57", 0, "df23f4ad-4648-4853-9df1-ee4c274cfc1d", "Winfield_Schamberger@hotmail.com", false, false, null, "WINFIELD_SCHAMBERGER@HOTMAIL.COM", "KURT_SCHADEN", null, "372-892-0834 x1015", false, "2b57f472-b42e-4791-957d-4411dffb1951", null, false, "Kurt_Schaden" },
                    { "58", 0, "df94e574-b3ea-45e5-bfd1-b36d4fb7f0c9", "Shannon_Willms20@hotmail.com", false, false, null, "SHANNON_WILLMS20@HOTMAIL.COM", "ESTELLE63", null, "1-788-925-6782 x070", false, "1aa8e784-74a1-4411-a448-da8d9295d04a", null, false, "Estelle63" },
                    { "59", 0, "89baf65c-eea3-4c28-9773-088a43e3f006", "Judson58@yahoo.com", false, false, null, "JUDSON58@YAHOO.COM", "KAITLYN.CORMIER64", null, "1-770-356-6984", false, "1ab71867-c714-4e34-9392-c099bdfea352", null, false, "Kaitlyn.Cormier64" },
                    { "6", 0, "d460ba79-ddaf-445b-a01f-785998179ef2", "Joana17@hotmail.com", false, false, null, "JOANA17@HOTMAIL.COM", "MIRACLE11", null, "794-328-7973", false, "b0bd46ed-c7c8-4c18-bdf7-d5608345deab", null, false, "Miracle11" },
                    { "60", 0, "afd07821-5cf0-4ddd-a5da-12f06b6ba246", "Arjun.Lesch@gmail.com", false, false, null, "ARJUN.LESCH@GMAIL.COM", "SAMIR_OKEEFE", null, "837-284-9103 x73981", false, "7d5fc371-a264-4cf8-98a4-797e389b772c", null, false, "Samir_OKeefe" },
                    { "61", 0, "82b37183-6880-494e-845b-6d106a5ab18e", "Rory_Pacocha23@yahoo.com", false, false, null, "RORY_PACOCHA23@YAHOO.COM", "IVAH_ROSENBAUM", null, "1-291-674-6203", false, "8f17b52d-c902-41e9-8976-ec26bb8717ed", null, false, "Ivah_Rosenbaum" },
                    { "62", 0, "6394b631-f9ce-4f3d-af83-a192cffc5135", "Tad_Bogan@hotmail.com", false, false, null, "TAD_BOGAN@HOTMAIL.COM", "JORDYN_STROMAN40", null, "584.685.2322", false, "e0264427-3e73-4648-914b-a17a005dcdf5", null, false, "Jordyn_Stroman40" },
                    { "63", 0, "451834cc-045d-4bbc-b9b2-a8b474685894", "Orpha32@hotmail.com", false, false, null, "ORPHA32@HOTMAIL.COM", "BART19", null, "527.284.1693 x3558", false, "e55802a4-4fca-4193-aa4c-67c400f1e926", null, false, "Bart19" },
                    { "64", 0, "99e8bb04-4637-4f21-974c-f4b6e17216a6", "Regan_Cummerata@yahoo.com", false, false, null, "REGAN_CUMMERATA@YAHOO.COM", "ALEXANDRA14", null, "(239) 400-5940 x497", false, "e2e3d304-5dd8-4fbc-923a-6b046fd640f8", null, false, "Alexandra14" },
                    { "65", 0, "52f11432-fecb-45c2-83ac-2707fb4d761b", "Tyrese_OConner@hotmail.com", false, false, null, "TYRESE_OCONNER@HOTMAIL.COM", "BRENNA.BRAKUS", null, "(733) 967-0623 x49269", false, "e6e36c4a-1367-4c04-97bf-ce564cb8f72a", null, false, "Brenna.Brakus" },
                    { "66", 0, "2b82d65f-e51a-4193-956a-8074e0c98648", "Dewitt39@gmail.com", false, false, null, "DEWITT39@GMAIL.COM", "CALISTA.ORN", null, "(631) 276-3543 x4090", false, "c9580431-7017-4bb3-8a33-b0c8ac2ce9e6", null, false, "Calista.Orn" },
                    { "67", 0, "264b6a97-21c3-491f-b4bc-ca76812fbb78", "Julio39@hotmail.com", false, false, null, "JULIO39@HOTMAIL.COM", "ADONIS.RATKE65", null, "(753) 611-2451", false, "cb5656c0-6c1c-4661-b3bd-db939e477ccf", null, false, "Adonis.Ratke65" },
                    { "68", 0, "c0e63620-92f1-40f2-a76f-4b4e30c66166", "Keven98@yahoo.com", false, false, null, "KEVEN98@YAHOO.COM", "WHITNEY90", null, "942.896.8583", false, "24d57f27-015b-4049-9dc6-c657c2076db2", null, false, "Whitney90" },
                    { "69", 0, "9dad19bb-780b-4800-a47e-aacc419ab5f5", "Matteo_Heidenreich94@hotmail.com", false, false, null, "MATTEO_HEIDENREICH94@HOTMAIL.COM", "YVONNE.CONNELLY", null, "289.885.9562 x6484", false, "6d5c6f29-ed11-45f7-8be3-999112a3b316", null, false, "Yvonne.Connelly" },
                    { "7", 0, "3236628c-1524-426c-a0e0-46ca1fce4445", "Abel91@yahoo.com", false, false, null, "ABEL91@YAHOO.COM", "LADARIUS.HEATHCOTE95", null, "845.670.0748", false, "47f82a85-71bc-4c88-9d98-c41d7088f0e2", null, false, "Ladarius.Heathcote95" },
                    { "70", 0, "e7b9db2f-fe64-45bb-830d-255c49b35eaf", "Oscar_Romaguera@hotmail.com", false, false, null, "OSCAR_ROMAGUERA@HOTMAIL.COM", "KATHLYN.GLOVER16", null, "(652) 519-1026 x87835", false, "f131f8ee-2917-496d-bd09-eb1c7c1dfc74", null, false, "Kathlyn.Glover16" },
                    { "71", 0, "f33cab33-940f-4fad-837e-8875dc1cb6de", "Johnson52@hotmail.com", false, false, null, "JOHNSON52@HOTMAIL.COM", "TITUS12", null, "957.751.9023 x801", false, "e20bc511-5a3e-4635-a9f2-4bfce3423ab0", null, false, "Titus12" },
                    { "72", 0, "40e1b19c-803d-4aa1-b36e-b0cd04b346fc", "Lowell.Ledner72@yahoo.com", false, false, null, "LOWELL.LEDNER72@YAHOO.COM", "ESTEFANIA39", null, "418.315.3838", false, "b52cbd7e-a4a7-435a-9c60-296879d42f60", null, false, "Estefania39" },
                    { "73", 0, "0adc30cb-e116-4e11-b97c-83f47dc52483", "Cecilia_Renner90@hotmail.com", false, false, null, "CECILIA_RENNER90@HOTMAIL.COM", "JARED_RATKE", null, "721-757-8321", false, "b7a494a3-9bd8-4aba-b860-41068a37eb4b", null, false, "Jared_Ratke" },
                    { "74", 0, "0a05cc8c-dd2d-4e58-8e51-f286bda92d0c", "Carole.Marquardt@yahoo.com", false, false, null, "CAROLE.MARQUARDT@YAHOO.COM", "KIM21", null, "(727) 434-5547 x49595", false, "dd37b812-f251-457d-bdbf-7f25b857a7f1", null, false, "Kim21" },
                    { "75", 0, "94afd987-5d93-423f-a739-7cbf8ff8c670", "Marisol_Zieme@yahoo.com", false, false, null, "MARISOL_ZIEME@YAHOO.COM", "ALVA.SAWAYN46", null, "605-507-7816 x611", false, "680971b4-f219-48d3-92ea-5ea9abe30ff3", null, false, "Alva.Sawayn46" },
                    { "76", 0, "a61bbf90-d53a-477d-8d72-ea09a178d477", "Ramon_Farrell@yahoo.com", false, false, null, "RAMON_FARRELL@YAHOO.COM", "TAD30", null, "836.990.4063", false, "bd3cb6d9-e51b-400a-89b6-50da5cabf41a", null, false, "Tad30" },
                    { "77", 0, "ef0cfbd2-dff5-4db0-987d-1b96a60e5779", "Spencer_Bergnaum@gmail.com", false, false, null, "SPENCER_BERGNAUM@GMAIL.COM", "MAY_TILLMAN53", null, "1-266-610-5837 x1712", false, "fe3e0f4b-8e47-42af-ad18-aaec9762922b", null, false, "May_Tillman53" },
                    { "78", 0, "d28318a2-9bde-4d4b-bca6-ee9492a79548", "Watson44@hotmail.com", false, false, null, "WATSON44@HOTMAIL.COM", "CHRISTOPHE.FEENEY26", null, "569-371-3309", false, "f7bd351e-a03b-4e40-b322-a63d40a6b1cb", null, false, "Christophe.Feeney26" },
                    { "79", 0, "1f7b189f-65af-4a0f-b91f-8009188cf1fe", "Jovani_Boyer57@yahoo.com", false, false, null, "JOVANI_BOYER57@YAHOO.COM", "RUTHE.HANE", null, "212.207.7989 x2834", false, "ca1e53f9-85be-42e4-b8ee-a47181997458", null, false, "Ruthe.Hane" },
                    { "8", 0, "4c94bf60-c450-4315-ac1e-481fb42fd72a", "Jessie_Leuschke@yahoo.com", false, false, null, "JESSIE_LEUSCHKE@YAHOO.COM", "WILSON86", null, "525-954-3019", false, "301b4a12-eb6f-439d-9e35-97b556ac98b9", null, false, "Wilson86" },
                    { "80", 0, "568e4246-681e-4f8b-9c0a-6db6ad50e42c", "Monte83@yahoo.com", false, false, null, "MONTE83@YAHOO.COM", "SYDNEY.WARD56", null, "670.783.5419 x995", false, "78dcebe8-b7e8-4e20-b359-905ac44c60a7", null, false, "Sydney.Ward56" },
                    { "81", 0, "fc16736f-e45c-487f-a937-08116bc04db3", "Malinda83@yahoo.com", false, false, null, "MALINDA83@YAHOO.COM", "KADEN92", null, "435.709.2681", false, "7015cb82-68e0-4a9f-8a0c-1e0d17bb970b", null, false, "Kaden92" },
                    { "82", 0, "bb461618-3606-4029-bd88-edcf18b9f106", "Vernie.Wisoky78@yahoo.com", false, false, null, "VERNIE.WISOKY78@YAHOO.COM", "REYES2", null, "493.403.7110 x22819", false, "fdb336c8-0056-4c22-9a7b-d1af6b064679", null, false, "Reyes2" },
                    { "83", 0, "6ccb0d55-9796-43d2-a9e4-f8bc3e0c4662", "Jodie80@hotmail.com", false, false, null, "JODIE80@HOTMAIL.COM", "CURT_LEDNER", null, "1-488-542-9913 x40481", false, "f36b7ca5-4e57-48ef-971c-688d1d49e087", null, false, "Curt_Ledner" },
                    { "84", 0, "2ecd0726-59b5-46a2-bc90-ceb20182b67c", "Jerod_Cummings@yahoo.com", false, false, null, "JEROD_CUMMINGS@YAHOO.COM", "ANA49", null, "(831) 478-1611", false, "f62599f5-06f5-4047-ba66-7c3433741f85", null, false, "Ana49" },
                    { "85", 0, "4bcc8693-1c91-46b9-9221-910d700d4f7b", "Annette_Jacobi52@hotmail.com", false, false, null, "ANNETTE_JACOBI52@HOTMAIL.COM", "ARNOLD.BLANDA", null, "776-525-2695 x100", false, "7e8d470b-123d-4824-9b3c-bd86098618b3", null, false, "Arnold.Blanda" },
                    { "86", 0, "13b99353-b46e-400f-a199-d71a3286755c", "Dedrick_OConner@hotmail.com", false, false, null, "DEDRICK_OCONNER@HOTMAIL.COM", "HELOISE_SIMONIS", null, "278.239.8541", false, "0e3fb6fe-e9ef-44d8-a58c-bedebdacb479", null, false, "Heloise_Simonis" },
                    { "87", 0, "1417d117-282e-4e3a-aea6-7ade900992c2", "Wilfrid67@gmail.com", false, false, null, "WILFRID67@GMAIL.COM", "LEVI44", null, "741.835.4206 x56399", false, "5f2ebf1e-b9cf-445f-8f12-5531c0676e0c", null, false, "Levi44" },
                    { "88", 0, "d4ffb82c-2b38-43d6-821c-009c27adedb8", "Osborne_Littel@gmail.com", false, false, null, "OSBORNE_LITTEL@GMAIL.COM", "LILLIANA.BECHTELAR32", null, "1-593-215-7850 x68072", false, "60431034-4032-4524-93b1-66b466d4b3d8", null, false, "Lilliana.Bechtelar32" },
                    { "89", 0, "50fd1f43-b825-45c2-8b25-7625c2fcf06e", "Mariam_Connelly@yahoo.com", false, false, null, "MARIAM_CONNELLY@YAHOO.COM", "DESTINY3", null, "978.722.4263 x561", false, "e7b00cb6-fa8e-4d3f-8721-0395e05fa72f", null, false, "Destiny3" },
                    { "9", 0, "6a7d312f-06f9-4569-b574-88dad88174fc", "Randi_Corkery@gmail.com", false, false, null, "RANDI_CORKERY@GMAIL.COM", "WAYNE.GOODWIN80", null, "795.537.2807 x2154", false, "4c5970b2-28f5-484e-9eb9-5472d6a26de8", null, false, "Wayne.Goodwin80" },
                    { "90", 0, "a916e3a4-32bd-4b8b-a458-4604b8f49a92", "Garfield.Batz@yahoo.com", false, false, null, "GARFIELD.BATZ@YAHOO.COM", "MYRL.BALISTRERI82", null, "645.664.0467", false, "42b81191-7b6e-4f36-b9da-93b1cdebf3ad", null, false, "Myrl.Balistreri82" },
                    { "91", 0, "10078d78-1ff1-45c3-b32f-f1cf815d5e72", "Pierce83@hotmail.com", false, false, null, "PIERCE83@HOTMAIL.COM", "FORREST.MACGYVER49", null, "(724) 598-8216 x28359", false, "3afeb372-7769-481e-99c2-9b75cf9f9430", null, false, "Forrest.MacGyver49" },
                    { "92", 0, "a51d9b87-6938-406c-9ca8-0690dec9f4bd", "Kurt_Lesch7@hotmail.com", false, false, null, "KURT_LESCH7@HOTMAIL.COM", "OLETA68", null, "301.870.3192", false, "fba6d0fc-498b-4b04-ad4d-0bdda58b4c2a", null, false, "Oleta68" },
                    { "93", 0, "b9bf43a1-1747-482c-b5f9-6f9408094961", "Lessie8@hotmail.com", false, false, null, "LESSIE8@HOTMAIL.COM", "FERMIN_STROSIN", null, "1-219-336-9932 x4298", false, "24be43df-d968-4e18-af83-9448b307217c", null, false, "Fermin_Strosin" },
                    { "94", 0, "29943588-1a65-4565-adf3-a6ed869ef8c7", "Monica.Gutmann60@hotmail.com", false, false, null, "MONICA.GUTMANN60@HOTMAIL.COM", "MYRIAM_STRACKE", null, "(867) 938-0778 x6738", false, "3cf83cbb-ae5c-424b-8404-45d59f54f423", null, false, "Myriam_Stracke" },
                    { "95", 0, "180da65b-30b8-46ee-9598-891c76974c31", "Vada.Pfannerstill16@yahoo.com", false, false, null, "VADA.PFANNERSTILL16@YAHOO.COM", "SALVADOR_VANDERVORT", null, "659-333-3115", false, "3746ebcf-569a-47ca-a12a-e520d413e32d", null, false, "Salvador_Vandervort" },
                    { "96", 0, "5acc7b65-e15c-4f35-9c2d-bb8c481f584c", "Jerrod_Heller@gmail.com", false, false, null, "JERROD_HELLER@GMAIL.COM", "VITO85", null, "1-672-562-4799 x5992", false, "0be4c973-e700-487e-aab2-29f1846d63d7", null, false, "Vito85" },
                    { "97", 0, "47d242b8-3051-4318-b19a-4b0661f7be20", "Markus21@gmail.com", false, false, null, "MARKUS21@GMAIL.COM", "ROSAMOND.RODRIGUEZ73", null, "1-333-893-1521 x019", false, "40f5aa35-b3d6-4a73-85a8-3746e4d91f65", null, false, "Rosamond.Rodriguez73" },
                    { "98", 0, "6fa94210-21ac-46d9-81c8-009d2c348608", "Lizeth72@gmail.com", false, false, null, "LIZETH72@GMAIL.COM", "LENNY_CHAMPLIN67", null, "347-869-7017 x566", false, "90afad55-26d0-4da4-a552-9a77f393267e", null, false, "Lenny_Champlin67" },
                    { "99", 0, "ce3ccb42-a639-4ffd-97db-9858dfd90af6", "Filiberto_Bednar@yahoo.com", false, false, null, "FILIBERTO_BEDNAR@YAHOO.COM", "GERALD_KLEIN3", null, "1-948-440-7900", false, "8f2bf1d8-034a-4523-ac08-7ec73f58f6ab", null, false, "Gerald_Klein3" }
                });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Duncan", "Mertz" },
                    { 2, "Augusta", "Kreiger" },
                    { 3, "Wendell", "Cremin" },
                    { 4, "Genesis", "Jacobs" },
                    { 5, "Sofia", "Waelchi" },
                    { 6, "Morgan", "Rutherford" },
                    { 7, "Delfina", "Beatty" },
                    { 8, "Rico", "Blick" },
                    { 9, "Emelie", "Gusikowski" },
                    { 10, "Etha", "Murazik" },
                    { 11, "Jaylon", "Klocko" },
                    { 12, "Rubye", "Larkin" },
                    { 13, "Alaina", "Legros" },
                    { 14, "Judd", "Hessel" },
                    { 15, "Kimberly", "Stracke" },
                    { 16, "Dillan", "Heidenreich" },
                    { 17, "Ilene", "Cummerata" },
                    { 18, "Murray", "Pouros" },
                    { 19, "Audie", "Legros" },
                    { 20, "Ricky", "Lehner" }
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
                columns: new[] { "Id", "DailyFine", "Extensions", "LoanPeriod", "MaxAge", "MinAge", "Name", "ReservationPrice", "SubscriptionPrice", "YearlyItems" },
                values: new object[,]
                {
                    { 1, 0m, 3, 3, 17, 0, "Jeugd", 0.25m, 0m, null },
                    { 2, 0.30m, 1, 3, null, 18, "Budget", 0.25m, 1m, 10 },
                    { 3, 0.30m, 3, 3, null, 18, "Basis", 0.25m, 4m, null },
                    { 4, 0m, 5, 3, null, 18, "Top", 0m, 6m, null }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 15, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Rubber Computer", 0 },
                    { 2, 13, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Concrete Cheese", 0 },
                    { 3, 18, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Wooden Computer", 0 },
                    { 4, 14, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Licensed Frozen Pants", 0 },
                    { 5, 7, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Steel Fish", 0 },
                    { 6, 10, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Plastic Shoes", 0 },
                    { 7, 17, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Granite Soap", 0 },
                    { 8, 5, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Unbranded Wooden Sausages", 0 },
                    { 9, 4, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Plastic Salad", 0 },
                    { 10, 13, 5, "The Football Is Good For Training And Recreational Purposes", "Refined Rubber Towels", 0 },
                    { 11, 6, 3, "The Football Is Good For Training And Recreational Purposes", "Awesome Plastic Towels", 0 },
                    { 12, 20, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Frozen Shirt", 0 },
                    { 13, 10, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Fresh Hat", 0 },
                    { 14, 8, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Metal Car", 0 },
                    { 15, 15, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Rubber Pants", 0 },
                    { 16, 2, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Soft Gloves", 0 },
                    { 17, 14, 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Concrete Cheese", 0 },
                    { 18, 14, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Wooden Shirt", 0 },
                    { 19, 18, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Soft Chips", 0 },
                    { 20, 20, 3, "The Football Is Good For Training And Recreational Purposes", "Incredible Wooden Tuna", 0 },
                    { 21, 18, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Steel Table", 0 },
                    { 22, 11, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Rubber Chair", 0 },
                    { 23, 20, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Soft Computer", 0 },
                    { 24, 11, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Steel Mouse", 0 },
                    { 25, 1, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Granite Tuna", 0 },
                    { 26, 12, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Steel Bike", 0 },
                    { 27, 13, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Soft Computer", 0 },
                    { 28, 17, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Concrete Table", 0 },
                    { 29, 3, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Soft Chips", 0 },
                    { 30, 6, 5, "The Football Is Good For Training And Recreational Purposes", "Licensed Steel Computer", 0 },
                    { 31, 9, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Frozen Shoes", 0 },
                    { 32, 15, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Steel Shirt", 0 },
                    { 33, 17, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Granite Shirt", 0 },
                    { 34, 12, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Cotton Pants", 0 },
                    { 35, 12, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Rubber Computer", 0 },
                    { 36, 14, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Refined Metal Keyboard", 0 },
                    { 37, 14, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Steel Bacon", 0 },
                    { 38, 10, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Soft Ball", 0 },
                    { 39, 8, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Cotton Computer", 0 },
                    { 40, 10, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Frozen Mouse", 0 },
                    { 41, 6, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Fresh Pants", 0 },
                    { 42, 7, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Wooden Soap", 0 },
                    { 43, 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Rubber Pizza", 0 },
                    { 44, 8, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Plastic Pants", 0 },
                    { 45, 2, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Soft Chair", 0 },
                    { 46, 5, 1, "The Football Is Good For Training And Recreational Purposes", "Awesome Cotton Cheese", 0 },
                    { 47, 11, 3, "The Football Is Good For Training And Recreational Purposes", "Sleek Metal Shirt", 0 },
                    { 48, 2, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Plastic Computer", 0 },
                    { 49, 18, 1, "The Football Is Good For Training And Recreational Purposes", "Small Fresh Table", 0 },
                    { 50, 18, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Steel Sausages", 0 },
                    { 51, 4, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Plastic Cheese", 0 },
                    { 52, 18, 1, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Fresh Hat", 0 },
                    { 53, 2, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Fresh Cheese", 0 },
                    { 54, 18, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Fresh Soap", 0 },
                    { 55, 5, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Refined Frozen Sausages", 0 },
                    { 56, 11, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Awesome Steel Table", 0 },
                    { 57, 7, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Metal Pants", 0 },
                    { 58, 5, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Steel Gloves", 0 },
                    { 59, 8, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Granite Computer", 0 },
                    { 60, 11, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Metal Mouse", 0 },
                    { 61, 15, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Fresh Keyboard", 0 },
                    { 62, 2, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Frozen Fish", 0 },
                    { 63, 3, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Fantastic Concrete Ball", 0 },
                    { 64, 16, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Rubber Mouse", 0 },
                    { 65, 14, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Plastic Cheese", 0 },
                    { 66, 15, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Steel Bacon", 0 },
                    { 67, 14, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Incredible Steel Mouse", 0 },
                    { 68, 19, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Incredible Granite Bacon", 0 },
                    { 69, 14, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Plastic Chips", 0 },
                    { 70, 11, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Cotton Bacon", 0 },
                    { 71, 11, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Plastic Bike", 0 },
                    { 72, 7, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Unbranded Granite Towels", 0 },
                    { 73, 10, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Frozen Sausages", 0 },
                    { 74, 3, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Fresh Salad", 0 },
                    { 75, 11, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Wooden Chair", 0 },
                    { 76, 7, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Steel Bacon", 0 },
                    { 77, 11, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Concrete Towels", 0 },
                    { 78, 20, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Plastic Tuna", 0 },
                    { 79, 8, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Practical Plastic Bike", 0 },
                    { 80, 12, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Wooden Shirt", 0 },
                    { 81, 17, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Rubber Computer", 0 },
                    { 82, 13, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Concrete Fish", 0 },
                    { 83, 1, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Steel Table", 0 },
                    { 84, 8, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Fresh Hat", 0 },
                    { 85, 18, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Fantastic Frozen Bike", 0 },
                    { 86, 8, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Fresh Sausages", 0 },
                    { 87, 3, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Concrete Bacon", 0 },
                    { 88, 15, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Steel Pizza", 0 },
                    { 89, 4, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Fresh Salad", 0 },
                    { 90, 3, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Rubber Computer", 0 },
                    { 91, 14, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Sleek Cotton Ball", 0 },
                    { 92, 6, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Concrete Chair", 0 },
                    { 93, 13, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Granite Shoes", 0 },
                    { 94, 1, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Cotton Bike", 0 },
                    { 95, 12, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Rubber Bacon", 0 },
                    { 96, 11, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Frozen Ball", 0 },
                    { 97, 20, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Rubber Chair", 0 },
                    { 98, 17, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handcrafted Rubber Shirt", 0 },
                    { 99, 15, 2, "The Football Is Good For Training And Recreational Purposes", "Gorgeous Fresh Car", 0 },
                    { 100, 6, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Refined Fresh Bike", 0 }
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
        }
    }
}
