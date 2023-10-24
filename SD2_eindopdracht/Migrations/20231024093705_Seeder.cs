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
                table: "Author",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Irwin", "Muller" },
                    { 2, "Isabell", "Feest" },
                    { 3, "Virgil", "Ryan" },
                    { 4, "Esther", "Keeling" },
                    { 5, "Hank", "Wolff" },
                    { 6, "Margaretta", "O'Hara" },
                    { 7, "Lauren", "Roberts" },
                    { 8, "Alvah", "Cartwright" },
                    { 9, "Gennaro", "Schimmel" },
                    { 10, "Loy", "Cole" },
                    { 11, "Shanna", "Hane" },
                    { 12, "Braxton", "Lemke" },
                    { 13, "Gayle", "Kuhn" },
                    { 14, "Orlo", "Hartmann" },
                    { 15, "Grady", "Pagac" },
                    { 16, "Brennon", "Keeling" },
                    { 17, "Nikita", "Altenwerth" },
                    { 18, "Timmothy", "Stamm" },
                    { 19, "Kathleen", "Adams" },
                    { 20, "Karl", "Romaguera" }
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
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "SubscriptionId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "cd2b1fa8-59cd-4893-b945-d587f51e0354", "ApplicationUser", "Maynard.Homenick66@yahoo.com", false, false, null, "MAYNARD.HOMENICK66@YAHOO.COM", "KENNITH85", null, "1-404-644-2447 x36740", false, "d8ee71c8-36a4-4a36-9c2f-3ddce88bd352", 3, false, "Kennith85" },
                    { "10", 0, "27f10dfb-c8e8-4f4e-900d-432215acb860", "ApplicationUser", "Kyla55@yahoo.com", false, false, null, "KYLA55@YAHOO.COM", "ERICA.MEDHURST", null, "933.379.0052", false, "bfd0ba27-c032-4011-badb-3dfa8dce7c97", 3, false, "Erica.Medhurst" },
                    { "100", 0, "0a5a1bdb-c087-46b5-9d64-f933a35a11e9", "ApplicationUser", "Rebeka.Little12@yahoo.com", false, false, null, "REBEKA.LITTLE12@YAHOO.COM", "CLOYD_KUNZE", null, "(585) 378-2846 x652", false, "0fb59d7b-fe41-4719-8fa7-50f563532a6f", 4, false, "Cloyd_Kunze" },
                    { "11", 0, "ecf9c79d-9621-4af2-831f-d3a0b739aae5", "ApplicationUser", "Matt54@yahoo.com", false, false, null, "MATT54@YAHOO.COM", "DANNIE72", null, "219-340-4945", false, "d7357a96-2498-4413-929a-971777944436", 2, false, "Dannie72" },
                    { "12", 0, "90f31a60-e4cd-4bfe-b86d-a4ac85a86f76", "ApplicationUser", "Rosalind.Greenholt@gmail.com", false, false, null, "ROSALIND.GREENHOLT@GMAIL.COM", "JODY_MUELLER", null, "774-742-8272 x6346", false, "02308042-036b-455e-89c5-8fbc12fd674f", 3, false, "Jody_Mueller" },
                    { "13", 0, "53fce84e-ec68-4a4c-aa87-1dd9b035b0d2", "ApplicationUser", "Haley_Rodriguez@gmail.com", false, false, null, "HALEY_RODRIGUEZ@GMAIL.COM", "CASEY.SCHAMBERGER44", null, "375.485.9944", false, "dd0d591b-3f45-4cff-b670-748a2ce27fc1", 2, false, "Casey.Schamberger44" },
                    { "14", 0, "9fb2e674-ffe2-4a9c-999c-bcc146de2620", "ApplicationUser", "Precious60@hotmail.com", false, false, null, "PRECIOUS60@HOTMAIL.COM", "DEWAYNE.WALKER", null, "(442) 889-3799 x19332", false, "b83ffed7-5716-4f90-bc9f-951158d1fcaf", 3, false, "Dewayne.Walker" },
                    { "15", 0, "035dce54-2fc8-46f5-8acc-04a6d4a8a015", "ApplicationUser", "Walter_Strosin@gmail.com", false, false, null, "WALTER_STROSIN@GMAIL.COM", "HARRISON_BERNHARD15", null, "602.976.8428 x507", false, "468f048a-ff89-4e1e-a590-3715994052ad", 4, false, "Harrison_Bernhard15" },
                    { "16", 0, "4521e2ae-8ad8-4ac9-a4ab-fa04adb3d33a", "ApplicationUser", "Cynthia.Walter@gmail.com", false, false, null, "CYNTHIA.WALTER@GMAIL.COM", "MATEO_VONRUEDEN49", null, "243-483-5734 x3663", false, "2aec36c8-8755-482d-92c2-00e4b9f1f820", 1, false, "Mateo_VonRueden49" },
                    { "17", 0, "8d6cfa1a-0151-45fd-8efb-c0462fa87285", "ApplicationUser", "Jerel27@gmail.com", false, false, null, "JEREL27@GMAIL.COM", "HILMA_SCHMITT34", null, "794-465-2623 x3650", false, "f748e093-340d-449a-9534-819b7b42b5c9", 2, false, "Hilma_Schmitt34" },
                    { "18", 0, "61f032da-60c2-41f5-9102-e474655f99a4", "ApplicationUser", "Ashley_Kub@yahoo.com", false, false, null, "ASHLEY_KUB@YAHOO.COM", "CLEVELAND63", null, "1-288-677-4657 x635", false, "aaf86525-d7b6-4c2e-9573-be46139aaf9f", 3, false, "Cleveland63" },
                    { "19", 0, "df40224d-12a2-422d-be46-b417d551fd85", "ApplicationUser", "Gwendolyn.Smith86@gmail.com", false, false, null, "GWENDOLYN.SMITH86@GMAIL.COM", "BRAD.BERGE84", null, "679-485-6431", false, "8c53737a-7f84-47d7-a6d0-e06ba818bfea", 1, false, "Brad.Berge84" },
                    { "2", 0, "8734f163-dce9-4425-bd4a-a93a332f5c50", "ApplicationUser", "Leatha_Tromp16@gmail.com", false, false, null, "LEATHA_TROMP16@GMAIL.COM", "KALEB.WATSICA1", null, "1-301-394-4399 x3811", false, "913a7bbe-8d72-4bc7-a29b-a6274d48dfdc", 2, false, "Kaleb.Watsica1" },
                    { "20", 0, "e3f68530-4640-492a-956c-4aa0e9382cef", "ApplicationUser", "Greg68@yahoo.com", false, false, null, "GREG68@YAHOO.COM", "HASSIE_WILDERMAN", null, "1-381-796-7031 x648", false, "7933debe-e35c-4767-9979-21302bde0118", 3, false, "Hassie_Wilderman" },
                    { "21", 0, "3353ef91-926c-4017-a938-50c357d5b842", "ApplicationUser", "Otho30@yahoo.com", false, false, null, "OTHO30@YAHOO.COM", "KORY.HOWE17", null, "(976) 350-7075 x46202", false, "844508ff-13f6-49a6-8eda-34b0f5d41a78", 4, false, "Kory.Howe17" },
                    { "22", 0, "ecbff00c-6815-41aa-82d6-7d1a3316a2ce", "ApplicationUser", "Gracie62@gmail.com", false, false, null, "GRACIE62@GMAIL.COM", "MILTON.BERNIER70", null, "265.968.5036 x0920", false, "bc3733c3-4a98-40b8-bdcd-fc49fc8c4139", 1, false, "Milton.Bernier70" },
                    { "23", 0, "d624115a-7018-41eb-bb42-d91839e07fe5", "ApplicationUser", "Wilfred.Durgan@hotmail.com", false, false, null, "WILFRED.DURGAN@HOTMAIL.COM", "ROOSEVELT75", null, "967.861.6348", false, "8e8d6350-8385-47d4-84f2-bcb2cd40becd", 2, false, "Roosevelt75" },
                    { "24", 0, "9c6492a9-266c-4ab8-b033-f0ab5ae0b878", "ApplicationUser", "Maeve_Parisian@gmail.com", false, false, null, "MAEVE_PARISIAN@GMAIL.COM", "TIANNA.BALISTRERI93", null, "1-468-466-4162", false, "2c1ed9fc-bf90-446d-971e-23b14577781c", 3, false, "Tianna.Balistreri93" },
                    { "25", 0, "ed7db796-e58c-477e-af9b-b2cb06907220", "ApplicationUser", "Emma.Zieme15@hotmail.com", false, false, null, "EMMA.ZIEME15@HOTMAIL.COM", "EMERSON.KUPHAL32", null, "(561) 598-2948 x93634", false, "0013b788-5786-4c01-b640-493dd5bd3866", 1, false, "Emerson.Kuphal32" },
                    { "26", 0, "6ee4d1d0-74bd-426b-ba31-6cf9297b257f", "ApplicationUser", "Bryce.Ziemann@gmail.com", false, false, null, "BRYCE.ZIEMANN@GMAIL.COM", "SHERIDAN61", null, "1-561-967-5525 x16092", false, "ba90e00d-eaec-4884-8fe7-b82284ab90d8", 3, false, "Sheridan61" },
                    { "27", 0, "d0ca07e7-7607-4097-b7d6-003c88ab3b4d", "ApplicationUser", "Zack26@yahoo.com", false, false, null, "ZACK26@YAHOO.COM", "VICTORIA_EBERT", null, "1-512-517-6538 x8536", false, "26f7ca37-53de-4dc4-9e37-7351f3fea7f2", 2, false, "Victoria_Ebert" },
                    { "28", 0, "f70abbb7-dbba-4b83-8712-c5bb36d527b9", "ApplicationUser", "Cali69@yahoo.com", false, false, null, "CALI69@YAHOO.COM", "BENEDICT.BODE", null, "1-686-373-1798 x6012", false, "4739310c-f67b-4260-9415-dfdd3b2d0b7d", 2, false, "Benedict.Bode" },
                    { "29", 0, "026ecca9-f6dc-4a0b-9911-27c84bb6996a", "ApplicationUser", "Else_Reichert@hotmail.com", false, false, null, "ELSE_REICHERT@HOTMAIL.COM", "ROEL_BAYER", null, "799-241-6135 x774", false, "af261520-e825-4a2a-a7f6-0052fbce150a", 2, false, "Roel_Bayer" },
                    { "3", 0, "28fe11b9-6a7b-4be6-a2a6-3a0921ac004a", "ApplicationUser", "Lula.Huels@yahoo.com", false, false, null, "LULA.HUELS@YAHOO.COM", "ERNA.KUPHAL67", null, "(237) 632-4095 x20181", false, "6c537a02-1112-47cf-9b1d-42912b9b2b74", 3, false, "Erna.Kuphal67" },
                    { "30", 0, "3b4a5faf-1fc8-474d-a05f-4e2786151e57", "ApplicationUser", "Coleman_Ortiz53@gmail.com", false, false, null, "COLEMAN_ORTIZ53@GMAIL.COM", "JAYSON28", null, "(352) 358-2496", false, "95fc8f3b-4d65-4c72-95bd-42d4120a4dba", 2, false, "Jayson28" },
                    { "31", 0, "448f656b-2e36-4fc7-8945-8b2dfead42ae", "ApplicationUser", "Rhea.Schoen@gmail.com", false, false, null, "RHEA.SCHOEN@GMAIL.COM", "LINA74", null, "(493) 572-4044 x2405", false, "3b1439ff-9570-4b53-90b8-7bc3e4b1166f", 2, false, "Lina74" },
                    { "32", 0, "f960c6ac-8102-4421-8c5a-b2a5711b4cf9", "ApplicationUser", "Xzavier_Hilpert71@gmail.com", false, false, null, "XZAVIER_HILPERT71@GMAIL.COM", "FLAVIE66", null, "754.748.2746", false, "3d997fa0-f397-48fe-b451-b9a6f516bcf1", 1, false, "Flavie66" },
                    { "33", 0, "daab0f1a-e55a-4ad9-8938-616dc90f6ae0", "ApplicationUser", "Crystal51@gmail.com", false, false, null, "CRYSTAL51@GMAIL.COM", "NORVAL_STROSIN18", null, "(740) 639-3490 x61330", false, "7ac157f8-afc9-4e1b-bd92-f391172a57e6", 2, false, "Norval_Strosin18" },
                    { "34", 0, "8579b0bd-f132-45b3-ba00-01085a729da0", "ApplicationUser", "Merle.Okuneva39@gmail.com", false, false, null, "MERLE.OKUNEVA39@GMAIL.COM", "HASKELL.LANGOSH", null, "(896) 472-0589 x826", false, "c17d7909-b89f-410b-a113-9508997a4df5", 1, false, "Haskell.Langosh" },
                    { "35", 0, "36a8a955-28f6-444f-8bd0-440dfe1dc926", "ApplicationUser", "Johann.Little@yahoo.com", false, false, null, "JOHANN.LITTLE@YAHOO.COM", "ALFONZO_KUPHAL", null, "615.693.4405 x5915", false, "515ad66e-eb92-4d70-a4e9-92e4b41f2fcb", 2, false, "Alfonzo_Kuphal" },
                    { "36", 0, "f92036c8-64db-4291-ac13-cafe05b9b319", "ApplicationUser", "Margarett.Lynch@hotmail.com", false, false, null, "MARGARETT.LYNCH@HOTMAIL.COM", "CLEMENTINA36", null, "1-890-848-9468", false, "89af9855-ad42-447e-b968-2674662a7cb4", 2, false, "Clementina36" },
                    { "37", 0, "c0f3aec5-a4e0-4e04-a5d3-a79dc118be65", "ApplicationUser", "Sasha0@hotmail.com", false, false, null, "SASHA0@HOTMAIL.COM", "EBBA.CONN70", null, "1-498-728-2465", false, "a7a8a133-0e7f-4330-986c-475a8870bd39", 3, false, "Ebba.Conn70" },
                    { "38", 0, "6d09140f-e9bc-4b6e-a8a1-e6cc0ed4eaba", "ApplicationUser", "Xavier77@gmail.com", false, false, null, "XAVIER77@GMAIL.COM", "ALESSANDRO.LEUSCHKE", null, "602-397-2114 x188", false, "37b5f62b-1e60-430e-9096-640ec3836040", 4, false, "Alessandro.Leuschke" },
                    { "39", 0, "ad14d5cd-e03d-412b-a017-5ca882fa367c", "ApplicationUser", "Enos80@gmail.com", false, false, null, "ENOS80@GMAIL.COM", "ELYSE35", null, "978-311-2986 x13411", false, "e243c161-b072-4c5f-9409-1c970890df02", 3, false, "Elyse35" },
                    { "4", 0, "73ca12ad-1320-4362-946c-a522adf613d2", "ApplicationUser", "Jed20@hotmail.com", false, false, null, "JED20@HOTMAIL.COM", "ROXANE62", null, "445.583.7878 x081", false, "6dbea548-6bb6-4368-8335-fa4bb326bd72", 1, false, "Roxane62" },
                    { "40", 0, "cf52c241-55c8-4b06-b6f1-e02ad2d9f5da", "ApplicationUser", "Lincoln86@yahoo.com", false, false, null, "LINCOLN86@YAHOO.COM", "SPENCER.SCHROEDER74", null, "1-641-293-6500 x5888", false, "370041b5-029d-422f-abb1-a5e688105799", 1, false, "Spencer.Schroeder74" },
                    { "41", 0, "4e0b0e13-6456-41a4-beaf-ec5cd025f078", "ApplicationUser", "Forest.Marquardt40@hotmail.com", false, false, null, "FOREST.MARQUARDT40@HOTMAIL.COM", "REYMUNDO_CASPER", null, "900-327-9281 x37521", false, "85e7402a-3b50-4192-ae6b-931a18a3d27e", 3, false, "Reymundo_Casper" },
                    { "42", 0, "d6e0e5c2-2961-44d3-9323-71d0b1b56868", "ApplicationUser", "Anastasia.Boyle25@yahoo.com", false, false, null, "ANASTASIA.BOYLE25@YAHOO.COM", "LAMAR.BLANDA", null, "1-750-416-4422", false, "af6706ae-b418-473e-9e12-fc498834e377", 2, false, "Lamar.Blanda" },
                    { "43", 0, "acc309b6-d67d-47a0-acfa-a7634ed25d93", "ApplicationUser", "Chet90@yahoo.com", false, false, null, "CHET90@YAHOO.COM", "FELTON_WILLIAMSON42", null, "(881) 860-8779 x9061", false, "b0d4f192-f52c-4ffa-8f66-8061f4438db2", 1, false, "Felton_Williamson42" },
                    { "44", 0, "86ffd690-7f2f-464a-bba1-1fb601bc1760", "ApplicationUser", "Justyn_Hessel83@gmail.com", false, false, null, "JUSTYN_HESSEL83@GMAIL.COM", "CANDICE.KERLUKE35", null, "939.664.8987", false, "edbb49d8-6c21-42cd-a5c3-79d95b0a1419", 1, false, "Candice.Kerluke35" },
                    { "45", 0, "44ded954-22e0-40e8-b632-be88acfcdff2", "ApplicationUser", "Timmy_Ernser@hotmail.com", false, false, null, "TIMMY_ERNSER@HOTMAIL.COM", "MYLES35", null, "(735) 380-8811 x387", false, "8e326b3d-dcec-4fd6-a093-2f2b4456328c", 3, false, "Myles35" },
                    { "46", 0, "4d86ba16-9d2e-44ff-b075-784b00571e1d", "ApplicationUser", "Arden.Powlowski@yahoo.com", false, false, null, "ARDEN.POWLOWSKI@YAHOO.COM", "VAN_BOGAN88", null, "1-610-890-5192", false, "96616d11-c027-4824-8e86-4d09f0298960", 4, false, "Van_Bogan88" },
                    { "47", 0, "59ff090d-938e-45f6-a7ca-d9bda057e951", "ApplicationUser", "Fleta.Wolf67@gmail.com", false, false, null, "FLETA.WOLF67@GMAIL.COM", "KENYATTA_THOMPSON", null, "309.527.0418 x2604", false, "9478904b-3535-403e-b7cc-f3952263b0ec", 4, false, "Kenyatta_Thompson" },
                    { "48", 0, "8c90653a-5536-4a7a-9708-14050d6ca5e4", "ApplicationUser", "Una67@hotmail.com", false, false, null, "UNA67@HOTMAIL.COM", "ROLANDO.SPORER", null, "1-405-693-3178", false, "ad6bdf96-a9e8-4f85-8c3d-ec8f7dd98ba1", 4, false, "Rolando.Sporer" },
                    { "49", 0, "55e7aa95-e34c-41c4-9c32-ce0b3c82ab9e", "ApplicationUser", "Reuben_Kub@yahoo.com", false, false, null, "REUBEN_KUB@YAHOO.COM", "ALESSANDRO55", null, "537.558.8464", false, "c8e463c5-bb4b-4da9-b778-7c388334e5cd", 2, false, "Alessandro55" },
                    { "5", 0, "56ee698d-06b0-441e-8e86-e775e2c14523", "ApplicationUser", "Rosanna_Rice@gmail.com", false, false, null, "ROSANNA_RICE@GMAIL.COM", "HORACE_SANFORD67", null, "(457) 828-7559", false, "e8cd7710-b3c1-45d6-a18e-0413d068f025", 1, false, "Horace_Sanford67" },
                    { "50", 0, "52d5205f-c0ed-4574-9ec8-67549b317e12", "ApplicationUser", "Unique_Ortiz65@gmail.com", false, false, null, "UNIQUE_ORTIZ65@GMAIL.COM", "LINDSAY34", null, "269.276.4957", false, "70ccf132-6b4f-43fc-a3ab-704011f847ba", 3, false, "Lindsay34" },
                    { "51", 0, "edb80330-bf05-4ad0-bb45-1eec49954e07", "ApplicationUser", "Kiara_Schmeler@yahoo.com", false, false, null, "KIARA_SCHMELER@YAHOO.COM", "MACY_MARVIN", null, "(656) 844-1373 x232", false, "83252057-b09d-49a6-90a4-893717bc7d75", 2, false, "Macy_Marvin" },
                    { "52", 0, "7fab7cf7-46ee-4ecf-aa00-6fc17eef44cb", "ApplicationUser", "Ludie.Halvorson@hotmail.com", false, false, null, "LUDIE.HALVORSON@HOTMAIL.COM", "ARTURO45", null, "1-273-241-5707 x8445", false, "bde59785-a2e2-4d60-8a9b-ec051d931a58", 3, false, "Arturo45" },
                    { "53", 0, "98ef84b9-43cf-4257-ada3-829dd8caeb7b", "ApplicationUser", "Justina_Kihn@hotmail.com", false, false, null, "JUSTINA_KIHN@HOTMAIL.COM", "ARNALDO_JACOBI", null, "361.567.3786 x272", false, "536fa757-2ba4-4424-b0dc-f2148cc62259", 1, false, "Arnaldo_Jacobi" },
                    { "54", 0, "ad902e7e-3b05-4c79-af68-24e933ba8c5e", "ApplicationUser", "Vada43@gmail.com", false, false, null, "VADA43@GMAIL.COM", "HOLLIE.OCONNELL8", null, "235.972.8612", false, "bf81b5db-9ec5-4d9e-b8a0-b1ebd9a70c00", 3, false, "Hollie.OConnell8" },
                    { "55", 0, "a242b561-733d-41df-a5d1-41d856540fa4", "ApplicationUser", "Gene.McKenzie74@gmail.com", false, false, null, "GENE.MCKENZIE74@GMAIL.COM", "KAROLANN.NOLAN90", null, "967.216.0345 x78138", false, "595746a6-6b88-415d-9709-ebaf79aec783", 2, false, "Karolann.Nolan90" },
                    { "56", 0, "8eb0ba01-20e4-44ee-813f-1aaa7da8ebbc", "ApplicationUser", "Laurianne.Lemke@hotmail.com", false, false, null, "LAURIANNE.LEMKE@HOTMAIL.COM", "JESSYCA_PFANNERSTILL22", null, "(974) 988-6881 x31600", false, "6868a7a2-7b08-4b7c-a37c-11b583bafa68", 1, false, "Jessyca_Pfannerstill22" },
                    { "57", 0, "2edf7c86-bee6-4f3f-b0bf-7c5cf2743ab8", "ApplicationUser", "Erna.Haag@gmail.com", false, false, null, "ERNA.HAAG@GMAIL.COM", "CANDICE_LANGWORTH57", null, "887.708.7843 x31904", false, "f81ad124-d312-4c70-be51-f6ac91195a85", 1, false, "Candice_Langworth57" },
                    { "58", 0, "5ed6ae93-adaa-4593-afb0-4bdc5764281b", "ApplicationUser", "Candida.Nolan48@gmail.com", false, false, null, "CANDIDA.NOLAN48@GMAIL.COM", "ARIELLE23", null, "(591) 981-8212", false, "0d82451f-da3b-4925-8279-db500043a72d", 2, false, "Arielle23" },
                    { "59", 0, "24bc544d-2d6b-4318-ab0d-dfe2e2f65aeb", "ApplicationUser", "Maybell_Kautzer7@hotmail.com", false, false, null, "MAYBELL_KAUTZER7@HOTMAIL.COM", "REGGIE_WEBER63", null, "(505) 750-2133 x2239", false, "6bcf98c9-8a83-4e09-91f9-e3fcd1c1a7fe", 2, false, "Reggie_Weber63" },
                    { "6", 0, "c8f88e4e-8bda-43d8-af3c-0fc838c7fa91", "ApplicationUser", "Nicole.Bradtke25@yahoo.com", false, false, null, "NICOLE.BRADTKE25@YAHOO.COM", "MAKENZIE83", null, "723-611-2827 x379", false, "74de6c65-4787-44ce-8bfd-82ef597f2ae8", 3, false, "Makenzie83" },
                    { "60", 0, "5ae202fd-7584-497f-a4c8-37829f78d8aa", "ApplicationUser", "Rosalyn.Metz@hotmail.com", false, false, null, "ROSALYN.METZ@HOTMAIL.COM", "ROSALYN_HACKETT87", null, "(961) 347-2422", false, "9111c501-d812-43a2-adcc-2618f1e893bc", 3, false, "Rosalyn_Hackett87" },
                    { "61", 0, "01a82ffa-5a34-4290-9c51-d74b7d18a2f7", "ApplicationUser", "Vanessa.Dickens82@hotmail.com", false, false, null, "VANESSA.DICKENS82@HOTMAIL.COM", "DELL16", null, "(395) 416-1361 x44080", false, "ab5550ef-c15d-4c7f-9b6d-ac4904dc727e", 2, false, "Dell16" },
                    { "62", 0, "70162f09-a277-430f-b8a2-8e37f683f088", "ApplicationUser", "Desmond91@yahoo.com", false, false, null, "DESMOND91@YAHOO.COM", "LILLY40", null, "725-375-4535", false, "8ee7d9c6-5201-41d3-b174-2c2420e37dbf", 2, false, "Lilly40" },
                    { "63", 0, "2d0da3a1-2fbb-4702-b713-e00a890c716a", "ApplicationUser", "Alisha68@yahoo.com", false, false, null, "ALISHA68@YAHOO.COM", "AMANDA_SPINKA", null, "1-557-511-0659", false, "8b69c56a-550f-4f02-8790-5598895032b5", 1, false, "Amanda_Spinka" },
                    { "64", 0, "c8118e80-942b-474e-9e10-f632e29688e0", "ApplicationUser", "Sandra.Rowe@hotmail.com", false, false, null, "SANDRA.ROWE@HOTMAIL.COM", "GILLIAN_GRIMES45", null, "1-692-336-7130", false, "fa1db4fd-a2f7-4aad-9c91-191023ef2006", 3, false, "Gillian_Grimes45" },
                    { "65", 0, "761d7357-5044-4cfd-bb5a-13d06ef32777", "ApplicationUser", "Patricia.Bailey49@hotmail.com", false, false, null, "PATRICIA.BAILEY49@HOTMAIL.COM", "DARRIN.LUBOWITZ", null, "1-908-385-0791 x72332", false, "a43c6618-8015-4349-8081-2728761645d1", 2, false, "Darrin.Lubowitz" },
                    { "66", 0, "e1c7c3bc-e611-4290-942b-8a8f218b0d97", "ApplicationUser", "Junior_Swift@hotmail.com", false, false, null, "JUNIOR_SWIFT@HOTMAIL.COM", "RENE_KUHN10", null, "382.557.9763 x373", false, "b1d8f725-762b-4b5e-ba20-9a66cdc60a93", 3, false, "Rene_Kuhn10" },
                    { "67", 0, "48433e5d-803f-4a76-830d-2e731872ce76", "ApplicationUser", "Francesco.Bauch41@yahoo.com", false, false, null, "FRANCESCO.BAUCH41@YAHOO.COM", "NIKITA5", null, "672-938-8202", false, "43a0596e-b7e7-4c3a-bfe1-c9a862ac9747", 4, false, "Nikita5" },
                    { "68", 0, "a60ac61d-3e28-4e44-bb57-e334101f5b8a", "ApplicationUser", "Gino_Lesch72@gmail.com", false, false, null, "GINO_LESCH72@GMAIL.COM", "MOISES40", null, "683.886.0015 x2010", false, "f6ea19e8-69c1-47bb-9164-7c529480b28d", 4, false, "Moises40" },
                    { "69", 0, "ecdac641-6c16-4e7d-9b03-96630c374093", "ApplicationUser", "Jana3@hotmail.com", false, false, null, "JANA3@HOTMAIL.COM", "MARIAH.BEER51", null, "741-842-6464", false, "15b17cb0-ef9e-4500-b886-60da89706ae7", 3, false, "Mariah.Beer51" },
                    { "7", 0, "94071bd4-edc0-43b1-b70e-4c27315c1c6f", "ApplicationUser", "Gianni_Christiansen10@gmail.com", false, false, null, "GIANNI_CHRISTIANSEN10@GMAIL.COM", "TRESSA.KIHN", null, "680.731.0195 x460", false, "c458130f-f6d8-4afc-aced-ca475993c7bb", 4, false, "Tressa.Kihn" },
                    { "70", 0, "f9baa355-358b-4512-8b5a-659d7cadab4f", "ApplicationUser", "Riley.Hartmann85@yahoo.com", false, false, null, "RILEY.HARTMANN85@YAHOO.COM", "ADALINE_BEER14", null, "740-501-5883 x646", false, "f2833132-6e2d-42d2-af61-fb550e33472a", 3, false, "Adaline_Beer14" },
                    { "71", 0, "898b0baf-44a7-4aec-9816-84707eeeea3f", "ApplicationUser", "Misty_Yost@gmail.com", false, false, null, "MISTY_YOST@GMAIL.COM", "RICHIE_HAMILL", null, "476.415.1370 x803", false, "e2e2d5c0-fcc8-406f-bb1a-9af1d9137e20", 3, false, "Richie_Hamill" },
                    { "72", 0, "6f31df0d-4a33-4b54-9d02-baa93e1e2269", "ApplicationUser", "Mikel_Hartmann@gmail.com", false, false, null, "MIKEL_HARTMANN@GMAIL.COM", "TERRILL.NIKOLAUS", null, "638-985-3574", false, "b05b9c8a-1f90-432f-95ec-a9bf7176f29c", 3, false, "Terrill.Nikolaus" },
                    { "73", 0, "24072f06-ea85-41da-af0b-04b82321670e", "ApplicationUser", "Effie_Huels37@gmail.com", false, false, null, "EFFIE_HUELS37@GMAIL.COM", "IZAIAH48", null, "(648) 475-3617", false, "41d67494-a0c0-4d97-a1a3-48e675424bce", 2, false, "Izaiah48" },
                    { "74", 0, "a188f9e7-dc96-4b48-beb6-1c8844f876c4", "ApplicationUser", "Raymundo86@hotmail.com", false, false, null, "RAYMUNDO86@HOTMAIL.COM", "DEVYN_RUECKER64", null, "(305) 452-9595 x530", false, "6dbf2532-8539-456b-9270-af416de4a45f", 4, false, "Devyn_Ruecker64" },
                    { "75", 0, "46f4a249-ef8b-42a2-880e-7e3a60641671", "ApplicationUser", "Spencer60@yahoo.com", false, false, null, "SPENCER60@YAHOO.COM", "HANNAH17", null, "1-708-405-6565 x374", false, "08551d32-5f4c-455c-b95b-8a1cded47b64", 1, false, "Hannah17" },
                    { "76", 0, "56649dc7-6580-4372-b5bf-6bdca279caf2", "ApplicationUser", "Harley83@yahoo.com", false, false, null, "HARLEY83@YAHOO.COM", "LANDEN27", null, "(851) 958-0727", false, "0f002ace-7ac6-430a-b6a2-19aa0bd24596", 2, false, "Landen27" },
                    { "77", 0, "1a2bc210-5edc-4a54-a145-b27e4c5a7726", "ApplicationUser", "Ari.Auer37@yahoo.com", false, false, null, "ARI.AUER37@YAHOO.COM", "FRANCES_SHANAHAN", null, "1-549-736-2906 x99456", false, "5d71d46e-babb-4240-a2ca-78d0908482b9", 4, false, "Frances_Shanahan" },
                    { "78", 0, "02ff94bd-6689-437e-a7f3-010b459b5e26", "ApplicationUser", "Adolph81@gmail.com", false, false, null, "ADOLPH81@GMAIL.COM", "CHAIM.RUTHERFORD23", null, "823-713-9223", false, "22d811ea-5099-49de-958e-bf8aa839593d", 2, false, "Chaim.Rutherford23" },
                    { "79", 0, "f89762c6-dc3c-4cfa-ab71-894e94b5bcbc", "ApplicationUser", "Elody48@hotmail.com", false, false, null, "ELODY48@HOTMAIL.COM", "JIMMY.BAUMBACH", null, "(831) 879-1497", false, "f81f9c86-3b80-4606-b0ac-bd23c1a7a9ef", 3, false, "Jimmy.Baumbach" },
                    { "8", 0, "88bb323e-9336-48da-b25a-7a15ebe10a55", "ApplicationUser", "Harmony.Crist18@yahoo.com", false, false, null, "HARMONY.CRIST18@YAHOO.COM", "MARCUS.FEENEY23", null, "481.389.3018", false, "b8faa7e5-d08e-462f-bce4-99b1b69ad5b9", 3, false, "Marcus.Feeney23" },
                    { "80", 0, "12d3b24e-08b0-4776-b5cd-4754484c8cb0", "ApplicationUser", "Torrey57@hotmail.com", false, false, null, "TORREY57@HOTMAIL.COM", "DOLORES.MOHR62", null, "1-513-529-3947 x603", false, "cf79bb70-a0ae-44ad-885d-6f4d8644ac32", 2, false, "Dolores.Mohr62" },
                    { "81", 0, "93feaa2b-65c4-4157-b121-fc458fd79dbb", "ApplicationUser", "Donald82@hotmail.com", false, false, null, "DONALD82@HOTMAIL.COM", "EDYTH_ORTIZ0", null, "1-441-843-6654", false, "dfb2d92e-1a58-407e-8225-6a6a1d9a87b3", 1, false, "Edyth_Ortiz0" },
                    { "82", 0, "147382d9-4488-4cd9-a669-2e1f39938758", "ApplicationUser", "Jayda.Pollich71@hotmail.com", false, false, null, "JAYDA.POLLICH71@HOTMAIL.COM", "DRAKE73", null, "(249) 330-4254 x3507", false, "090192d0-c2f9-4c8c-a4fd-28e6d71b8a81", 1, false, "Drake73" },
                    { "83", 0, "1e41eef9-6cc7-49f3-83d6-e051ef14c0e2", "ApplicationUser", "Aliza78@gmail.com", false, false, null, "ALIZA78@GMAIL.COM", "ALEXANNE.HINTZ46", null, "1-913-718-0311 x947", false, "3a953479-7e19-43fc-9a5a-313ecb8b9c02", 2, false, "Alexanne.Hintz46" },
                    { "84", 0, "982c86be-3474-4c2a-8037-7c16e0708946", "ApplicationUser", "Moriah15@gmail.com", false, false, null, "MORIAH15@GMAIL.COM", "ROWAN83", null, "(938) 335-5435 x8176", false, "b0d58977-5eae-4a09-84ce-ff5d52e78cc7", 2, false, "Rowan83" },
                    { "85", 0, "eb62ba92-dc1f-4784-a4cd-ab1d51181f42", "ApplicationUser", "Stefan92@hotmail.com", false, false, null, "STEFAN92@HOTMAIL.COM", "MARA.RATKE63", null, "361.945.0451 x266", false, "d071cd0f-28d4-4050-bcc9-e164b2540683", 1, false, "Mara.Ratke63" },
                    { "86", 0, "abaf8280-ad30-4bf4-82f0-ac94f4af239c", "ApplicationUser", "Vernon_Sanford47@hotmail.com", false, false, null, "VERNON_SANFORD47@HOTMAIL.COM", "ERICKA20", null, "(903) 927-4666 x102", false, "0b77faa1-aad6-4c39-9ccd-bcec40eb4f02", 1, false, "Ericka20" },
                    { "87", 0, "9c7a1942-634a-4ed1-840c-5b4b85e18d8a", "ApplicationUser", "Chelsie.Russel71@hotmail.com", false, false, null, "CHELSIE.RUSSEL71@HOTMAIL.COM", "TIA.REMPEL", null, "346-825-3679 x0647", false, "ec04af20-a8a4-4976-9537-510f7644c5cb", 2, false, "Tia.Rempel" },
                    { "88", 0, "127f2d33-15f1-48e0-ad8c-59e16d1afd7b", "ApplicationUser", "Celestino.DuBuque51@gmail.com", false, false, null, "CELESTINO.DUBUQUE51@GMAIL.COM", "MARTINE.MCLAUGHLIN", null, "593.377.9123 x25830", false, "1c65e998-0bbd-4250-8291-802b871e94e8", 1, false, "Martine.McLaughlin" },
                    { "89", 0, "dd14ec9f-faad-49a8-b37a-edda503645ee", "ApplicationUser", "Keegan72@yahoo.com", false, false, null, "KEEGAN72@YAHOO.COM", "VERLIE62", null, "313.736.9356 x7823", false, "499305e1-6852-49ab-a01a-82afb1b15c0e", 2, false, "Verlie62" },
                    { "9", 0, "ac15b1fb-0671-4ed3-a3c8-b29ec1efaa1d", "ApplicationUser", "Genoveva5@hotmail.com", false, false, null, "GENOVEVA5@HOTMAIL.COM", "NATASHA.HUEL37", null, "254-228-7603 x901", false, "79e2c7ca-c52b-427e-80f1-ca70d8ca6a4e", 3, false, "Natasha.Huel37" },
                    { "90", 0, "ad87c329-d069-484d-a300-ade68ea5bd0e", "ApplicationUser", "Bella_Windler47@gmail.com", false, false, null, "BELLA_WINDLER47@GMAIL.COM", "LAVADA78", null, "(255) 378-1579 x84355", false, "3bf9b4b4-fe8f-4a70-b6bd-c781a5e73f2b", 1, false, "Lavada78" },
                    { "91", 0, "e1d1b19c-2e98-4f04-bcd5-1c52495e4618", "ApplicationUser", "Ashleigh_Wilderman63@gmail.com", false, false, null, "ASHLEIGH_WILDERMAN63@GMAIL.COM", "FREDERICK_HALVORSON", null, "932-811-4860", false, "66b00737-7fb2-4cdf-b949-ebe4000965cc", 2, false, "Frederick_Halvorson" },
                    { "92", 0, "cb61691b-1a4a-478f-adc9-f656913924ca", "ApplicationUser", "Christ.Kunde21@gmail.com", false, false, null, "CHRIST.KUNDE21@GMAIL.COM", "WILMA.SENGER26", null, "253.751.8726 x91147", false, "6fa9c285-2927-4a3e-8720-190963350e7d", 2, false, "Wilma.Senger26" },
                    { "93", 0, "c54a3383-083e-4fdf-9eb1-cf9288e468b6", "ApplicationUser", "Jaren98@hotmail.com", false, false, null, "JAREN98@HOTMAIL.COM", "FATIMA_SAWAYN68", null, "1-523-582-1378 x00031", false, "d3007f27-fb9f-4545-95c4-65655c33b17d", 2, false, "Fatima_Sawayn68" },
                    { "94", 0, "4b5e36dc-e977-4719-9f6a-97adb3953ad7", "ApplicationUser", "Diamond57@hotmail.com", false, false, null, "DIAMOND57@HOTMAIL.COM", "ADRIENNE_HIRTHE", null, "1-344-513-7346 x762", false, "e99f7a9d-cd5c-4fbf-bde2-ab2a65570426", 2, false, "Adrienne_Hirthe" },
                    { "95", 0, "1b8cb428-5c10-4709-ba52-8dec5f201611", "ApplicationUser", "Brooke76@yahoo.com", false, false, null, "BROOKE76@YAHOO.COM", "ALETHA58", null, "(691) 618-1893", false, "b216cdb0-5852-402b-830f-f1340fdd2457", 4, false, "Aletha58" },
                    { "96", 0, "79c7e75e-36da-4c08-9805-de90971d1623", "ApplicationUser", "Noelia_Funk@hotmail.com", false, false, null, "NOELIA_FUNK@HOTMAIL.COM", "BAYLEE.GIBSON", null, "235.380.1766 x69313", false, "01791534-1e87-4484-908f-58285bf76150", 3, false, "Baylee.Gibson" },
                    { "97", 0, "86cecaef-a5a4-4e11-810d-9be89a6aa9dc", "ApplicationUser", "Dortha_Mitchell82@hotmail.com", false, false, null, "DORTHA_MITCHELL82@HOTMAIL.COM", "RAINA_WILLIAMSON", null, "675-391-7412", false, "ce0a47c9-866f-4f09-865c-33487e98f548", 4, false, "Raina_Williamson" },
                    { "98", 0, "fe36409b-ffbf-480b-8dd0-88feb600fa17", "ApplicationUser", "Tremayne19@gmail.com", false, false, null, "TREMAYNE19@GMAIL.COM", "ANTONIETTA.STEUBER7", null, "284.314.9057 x164", false, "7f4425be-add3-4243-b9c3-ee1cdc8d38c5", 3, false, "Antonietta.Steuber7" },
                    { "99", 0, "5ef307dd-c4c7-4f1a-b433-91ffce53edf2", "ApplicationUser", "Kacie19@yahoo.com", false, false, null, "KACIE19@YAHOO.COM", "ARLO.SAWAYN5", null, "465.301.6054", false, "ad6ab7e3-f181-4553-873b-3fb8b9386d2e", 4, false, "Arlo.Sawayn5" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[,]
                {
                    { 1, 9, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Fresh Pizza", 0 },
                    { 2, 1, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Fresh Shoes", 0 },
                    { 3, 20, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Plastic Towels", 0 },
                    { 4, 5, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Steel Shoes", 0 },
                    { 5, 20, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Sleek Cotton Keyboard", 0 },
                    { 6, 15, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Concrete Computer", 0 },
                    { 7, 15, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Soft Tuna", 0 },
                    { 8, 16, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Frozen Pants", 0 },
                    { 9, 11, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Concrete Tuna", 0 },
                    { 10, 12, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Small Fresh Chicken", 0 },
                    { 11, 19, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Plastic Mouse", 0 },
                    { 12, 12, 2, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Licensed Fresh Sausages", 0 },
                    { 13, 14, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Chicken", 0 },
                    { 14, 18, 1, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Rubber Mouse", 0 },
                    { 15, 10, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Concrete Bike", 0 },
                    { 16, 4, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Refined Cotton Tuna", 0 },
                    { 17, 6, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Fresh Computer", 0 },
                    { 18, 18, 1, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Soft Computer", 0 },
                    { 19, 11, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Wooden Soap", 0 },
                    { 20, 11, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Cotton Computer", 0 },
                    { 21, 4, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Cotton Shoes", 0 },
                    { 22, 14, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Soft Bike", 0 },
                    { 23, 20, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Granite Keyboard", 0 },
                    { 24, 14, 4, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Plastic Fish", 0 },
                    { 25, 4, 3, "The Football Is Good For Training And Recreational Purposes", "Practical Rubber Chips", 0 },
                    { 26, 9, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Rubber Pants", 0 },
                    { 27, 5, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Rubber Hat", 0 },
                    { 28, 20, 5, "The Football Is Good For Training And Recreational Purposes", "Refined Fresh Towels", 0 },
                    { 29, 4, 2, "The Football Is Good For Training And Recreational Purposes", "Awesome Concrete Cheese", 0 },
                    { 30, 3, 3, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Steel Table", 0 },
                    { 31, 7, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Frozen Fish", 0 },
                    { 32, 14, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Fresh Sausages", 0 },
                    { 33, 17, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Concrete Pants", 0 },
                    { 34, 4, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Concrete Chicken", 0 },
                    { 35, 10, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Soft Gloves", 0 },
                    { 36, 9, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Granite Keyboard", 0 },
                    { 37, 20, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Metal Gloves", 0 },
                    { 38, 17, 4, "The Football Is Good For Training And Recreational Purposes", "Intelligent Fresh Table", 0 },
                    { 39, 15, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Wooden Soap", 0 },
                    { 40, 17, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Wooden Chicken", 0 },
                    { 41, 4, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Licensed Metal Hat", 0 },
                    { 42, 2, 5, "The Football Is Good For Training And Recreational Purposes", "Intelligent Plastic Bacon", 0 },
                    { 43, 17, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Metal Table", 0 },
                    { 44, 12, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Frozen Shoes", 0 },
                    { 45, 5, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Sleek Metal Salad", 0 },
                    { 46, 19, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Granite Chair", 0 },
                    { 47, 1, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Metal Chicken", 0 },
                    { 48, 10, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Rubber Shoes", 0 },
                    { 49, 2, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Plastic Hat", 0 },
                    { 50, 16, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Licensed Metal Cheese", 0 },
                    { 51, 9, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Frozen Chips", 0 },
                    { 52, 1, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Rubber Pants", 0 },
                    { 53, 4, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Wooden Cheese", 0 },
                    { 54, 5, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Soft Pants", 0 },
                    { 55, 18, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Fantastic Rubber Gloves", 0 },
                    { 56, 1, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Steel Keyboard", 0 },
                    { 57, 12, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Soft Hat", 0 },
                    { 58, 16, 5, "The Football Is Good For Training And Recreational Purposes", "Tasty Rubber Salad", 0 },
                    { 59, 4, 5, "The Football Is Good For Training And Recreational Purposes", "Generic Frozen Sausages", 0 },
                    { 60, 8, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Plastic Pizza", 0 },
                    { 61, 10, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Unbranded Soft Chair", 0 },
                    { 62, 19, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Metal Cheese", 0 },
                    { 63, 2, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Cotton Sausages", 0 },
                    { 64, 7, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Wooden Pants", 0 },
                    { 65, 3, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Frozen Computer", 0 },
                    { 66, 5, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Soft Bacon", 0 },
                    { 67, 17, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Sleek Granite Bacon", 0 },
                    { 68, 4, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Rubber Gloves", 0 },
                    { 69, 13, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Steel Tuna", 0 },
                    { 70, 11, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Concrete Pizza", 0 },
                    { 71, 16, 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Awesome Steel Bacon", 0 },
                    { 72, 16, 3, "The Football Is Good For Training And Recreational Purposes", "Incredible Fresh Hat", 0 },
                    { 73, 3, 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Fresh Chips", 0 },
                    { 74, 6, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Small Metal Shirt", 0 },
                    { 75, 8, 2, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Refined Frozen Pizza", 0 },
                    { 76, 20, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Steel Computer", 0 },
                    { 77, 9, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Metal Salad", 0 },
                    { 78, 19, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Granite Chicken", 0 },
                    { 79, 12, 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Fantastic Wooden Hat", 0 },
                    { 80, 11, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Soft Shoes", 0 },
                    { 81, 5, 5, "The Football Is Good For Training And Recreational Purposes", "Incredible Concrete Chips", 0 },
                    { 82, 8, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Ergonomic Rubber Fish", 0 },
                    { 83, 8, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Mouse", 0 },
                    { 84, 1, 2, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Rustic Steel Car", 0 },
                    { 85, 20, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Rubber Pizza", 0 },
                    { 86, 3, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Chicken", 0 },
                    { 87, 8, 5, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Steel Car", 0 },
                    { 88, 14, 3, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Cotton Pants", 0 },
                    { 89, 5, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Fresh Mouse", 0 },
                    { 90, 8, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Cotton Chips", 0 },
                    { 91, 9, 3, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Rubber Tuna", 0 },
                    { 92, 7, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Rubber Shirt", 0 },
                    { 93, 5, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Cotton Ball", 0 },
                    { 94, 10, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Fresh Computer", 0 },
                    { 95, 16, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Sleek Rubber Salad", 0 },
                    { 96, 15, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Steel Computer", 0 },
                    { 97, 6, 4, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Cotton Towels", 0 },
                    { 98, 14, 5, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Granite Shirt", 0 },
                    { 99, 6, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Ergonomic Plastic Mouse", 0 },
                    { 100, 10, 1, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Granite Shoes", 0 }
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
        }
    }
}
