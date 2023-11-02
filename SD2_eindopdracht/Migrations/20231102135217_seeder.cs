using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SD2_eindopdracht.Migrations
{
    /// <inheritdoc />
    public partial class seeder : Migration
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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "97a0d54f-3140-4b70-8089-097011c4430c", "Assunta81@hotmail.com", "ASSUNTA81@HOTMAIL.COM", "JAN_POLLICH65", "1-279-201-5886", "eb840b44-e0de-4af1-8c45-9ba80b2083aa", 2, "Jan_Pollich65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 21, "2444fb58-11e3-4af3-991d-4a07d8a960cc", "Concepcion13@yahoo.com", "CONCEPCION13@YAHOO.COM", "LESSIE.MACEJKOVIC10", "1-959-998-1406", "7b8c84f9-234b-4de1-940d-9e2127104f2a", 4, "Lessie.Macejkovic10" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "100",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 48, "e28f6be4-4103-4c82-b1ed-e79e1de24ea6", "Kamren55@hotmail.com", "KAMREN55@HOTMAIL.COM", "LINA72", "469.899.8376", "6122661b-d2d8-48f8-8878-0443a20720b4", 3, "Lina72" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 37, "5cb69628-4c9a-4175-aa71-dfcb58d87757", "Louisa.Kerluke@yahoo.com", "LOUISA.KERLUKE@YAHOO.COM", "MARGUERITE36", "(675) 583-1684", "05c2c0aa-dfea-4bbc-9a4f-6084f0559990", "Marguerite36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 20, "951208d2-d5c3-4c2f-b2ab-06213f8bc14e", "Blair.Okuneva70@hotmail.com", "BLAIR.OKUNEVA70@HOTMAIL.COM", "STEFANIE.GIBSON", "1-832-862-1939 x219", "fad7f97f-1911-4f97-b345-0c0c2b7d4b16", 3, "Stefanie.Gibson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 77, "a4852013-85b9-4922-bd66-0512261bdff1", "Abagail_King@hotmail.com", "ABAGAIL_KING@HOTMAIL.COM", "EULALIA70", "(751) 759-0678", "511ca46e-0a74-4f89-b0ee-c0db0d0e2bb3", "Eulalia70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 76, "65297239-3ea8-496d-aa3a-515517d8c41b", "Dante.Reichel10@yahoo.com", "DANTE.REICHEL10@YAHOO.COM", "SAVANNAH.CORKERY32", "(943) 776-4044 x855", "0e707321-3901-4538-bcff-75be8eb75b28", "Savannah.Corkery32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "9eb55c54-d4c8-411b-b4e2-bfe4909fcf62", "Aryanna0@yahoo.com", "ARYANNA0@YAHOO.COM", "EBONY_OHARA38", "(663) 953-2158 x79020", "c3abda6c-de12-4ed2-ae53-88c5c7ee1f3a", 3, "Ebony_OHara38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 44, "a8188a1a-754d-4b6d-8893-fb32bf35c6c9", "Jordan6@gmail.com", "JORDAN6@GMAIL.COM", "DRAKE59", "388-999-8691", "ca592f79-40c5-4c77-b096-e4c688c592ac", "Drake59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 59, "25ea1119-5a6b-48ef-a591-1dda233f813d", "Tianna_Thiel@hotmail.com", "TIANNA_THIEL@HOTMAIL.COM", "GEORGETTE65", "1-548-818-1328", "53067533-344d-43f3-ba2a-a3809e61f79d", 2, "Georgette65" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 47, "80412a5e-e71d-4818-ac68-d76c9449e739", "Itzel70@hotmail.com", "ITZEL70@HOTMAIL.COM", "ROBBIE_MCGLYNN19", "(784) 505-6890 x27460", "c904fef1-e2c3-4c35-a30a-baf2b0bff27e", 3, "Robbie_McGlynn19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "d8995ab4-7857-43d4-b1c6-41019d3bf800", "Daniella_Dicki16@gmail.com", "DANIELLA_DICKI16@GMAIL.COM", "PEGGIE.ROLFSON", "1-665-567-5855 x2050", "970e4e03-aca5-4812-82d4-407f973f7622", 1, "Peggie.Rolfson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 35, "e366ac69-da9e-450b-b58a-caa2e0501dad", "Trevor.Marquardt@gmail.com", "TREVOR.MARQUARDT@GMAIL.COM", "STUART_HELLER43", "(245) 569-9783", "d75690a3-4e34-4d05-bf9e-5dc6c333539d", 3, "Stuart_Heller43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "20",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 62, "8c5a554d-c961-47fb-a364-c7dacf6c22c2", "Velma_Feest53@hotmail.com", "VELMA_FEEST53@HOTMAIL.COM", "BETTE_YOST", "225.218.1438", "2f93b71a-975c-4049-ae81-2c5d71e92567", 3, "Bette_Yost" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 36, "dcd5eef8-10fe-4f54-9ed9-57dad94bdf7e", "Norwood_Jenkins@hotmail.com", "NORWOOD_JENKINS@HOTMAIL.COM", "KASANDRA47", "(291) 674-1607", "8214b091-6259-4425-a9ca-8bec75b35945", "Kasandra47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 70, "d4468e05-d7b8-4072-b4ec-51437cf028b6", "Trace.Pfeffer@yahoo.com", "TRACE.PFEFFER@YAHOO.COM", "FREDDY.RODRIGUEZ29", "462-511-2720", "17a7de87-4c2a-4af9-902c-3e1eb81d4d0e", 4, "Freddy.Rodriguez29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 39, "fdacf94d-3102-4eb0-8d04-cde6a998f9e3", "Herta34@yahoo.com", "HERTA34@YAHOO.COM", "NORMA.MILLER19", "481.968.5634 x1938", "11f7c1cf-5718-4395-979e-f5a2ab8d01db", 3, "Norma.Miller19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 57, "ac85a09a-6b08-41d4-adc1-958a6dcad104", "Jacques54@yahoo.com", "JACQUES54@YAHOO.COM", "LAVERNE_DURGAN", "1-364-311-1396", "799b77c0-a9b7-4af7-ba3c-41d3a96020cd", "Laverne_Durgan" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 42, "535619d2-ee6d-4e3f-92bf-97de44e968e7", "Dewayne.Lemke36@hotmail.com", "DEWAYNE.LEMKE36@HOTMAIL.COM", "VELMA86", "544.226.2571 x08833", "ac5d7063-4273-4c42-aefd-552e8daba785", 2, "Velma86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 40, "1c873dda-1bd8-48db-9d2f-e6da5f1e1c10", "Beulah5@hotmail.com", "BEULAH5@HOTMAIL.COM", "RAFAEL67", "(954) 997-3193 x908", "d224af6a-406a-4949-a982-c2990b70a542", 4, "Rafael67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "5db53e10-d8aa-43bd-a015-5eeb0d0758e0", "Gwendolyn.Kulas@gmail.com", "GWENDOLYN.KULAS@GMAIL.COM", "SHANELLE.BOYER80", "(294) 312-8135", "0eee51bc-a777-41e8-a3a2-a3f9c5e8be65", 3, "Shanelle.Boyer80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "f1201132-e85e-4654-8694-79a030236111", "Ellis.Sauer@hotmail.com", "ELLIS.SAUER@HOTMAIL.COM", "BEVERLY.CASPER60", "867.813.1157", "4b9425b9-476f-4b68-942a-daa39e7b7980", 1, "Beverly.Casper60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 17, "53555a99-ab92-4307-a5db-80ea35cd73f6", "Zena20@gmail.com", "ZENA20@GMAIL.COM", "JIMMY.HOMENICK27", "943.596.3146 x8764", "1a07bb8c-e773-46b9-9602-fdd03758d7da", 1, "Jimmy.Homenick27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "e16f2815-518d-434f-bc1f-c200e5d8c11f", "Buster.Hegmann84@hotmail.com", "BUSTER.HEGMANN84@HOTMAIL.COM", "MACK_TORPHY47", "977.564.5362", "4444dabc-a479-40bf-adb9-2703f4c0e05d", 2, "Mack_Torphy47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 54, "6003f61a-5a60-4b91-b396-88909700318f", "Kyler66@yahoo.com", "KYLER66@YAHOO.COM", "QUEEN.MAGGIO", "1-751-635-3741", "46407e6e-7bee-4883-938d-0e99a1615daf", 2, "Queen.Maggio" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 34, "26dfbc51-40a7-406b-a338-647bbf2efac7", "Deon99@gmail.com", "DEON99@GMAIL.COM", "ORION.WILLMS", "605-624-3826", "041677af-2398-4129-8eba-b38eeabba52f", 4, "Orion.Willms" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 62, "48a9ea68-ffac-477e-8fa9-1664b27eabb9", "Rosie.Bins@hotmail.com", "ROSIE.BINS@HOTMAIL.COM", "IMANI_KONOPELSKI66", "1-985-940-8535 x71536", "73c716b0-a2a1-441f-a1e6-3ffcd43d765a", "Imani_Konopelski66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 40, "47398f76-2127-40a3-b1f9-e3246296958a", "Leonor60@yahoo.com", "LEONOR60@YAHOO.COM", "MARLEY_HAND", "1-902-279-8042 x8668", "ba902e49-306a-4e66-90ff-211b548805a3", 4, "Marley_Hand" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "b185e50f-4141-48b6-9f06-c4bd5add67d6", "Domenic.Miller39@gmail.com", "DOMENIC.MILLER39@GMAIL.COM", "ADALBERTO.GIBSON", "1-716-635-4546 x09917", "b686c74c-0a8f-4bfc-816d-f65b6e21c862", 2, "Adalberto.Gibson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 16, "02cbc3a2-05ba-4a12-b6dd-a51ff44af438", "Ryann_Olson@hotmail.com", "RYANN_OLSON@HOTMAIL.COM", "BRAYAN.CRONIN", "(859) 817-5464", "b214ba97-93f7-4642-b3ca-b79b4f163cda", 1, "Brayan.Cronin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 23, "d86dd6fd-7126-4c6a-b885-cd000736af4f", "Brando_Gerhold@yahoo.com", "BRANDO_GERHOLD@YAHOO.COM", "SANTA_FRANECKI", "817-418-3743 x32844", "2d594583-32af-4bb9-8518-f553f6fc8a0b", "Santa_Franecki" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 62, "95b82d9e-b223-450a-9ac0-da4737fc26d5", "Carolina.McLaughlin32@hotmail.com", "CAROLINA.MCLAUGHLIN32@HOTMAIL.COM", "ARIC.BLOCK", "1-428-856-0833 x1453", "ebd46f56-4a35-4f17-93b0-52b6dcbee7d3", 4, "Aric.Block" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 61, "a3e66212-6a80-4d7b-b254-4a01fe509014", "Beth_Hintz@yahoo.com", "BETH_HINTZ@YAHOO.COM", "CAROLINA.LOWE", "1-308-802-7401", "c2742619-a591-47c4-80b5-7ef5ab6ccff6", "Carolina.Lowe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 55, "f0fcdcf0-df44-4c57-8f6a-54de3c8cda80", "Vernie.Hegmann@yahoo.com", "VERNIE.HEGMANN@YAHOO.COM", "JULIA.JOHNSON", "458-588-4734 x275", "839d501a-e52d-43a1-a9f3-bb2d584d9e1d", "Julia.Johnson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 74, "72259dd4-ebc8-4a93-8716-843ccec687fe", "Alfredo_OHara75@yahoo.com", "ALFREDO_OHARA75@YAHOO.COM", "ISOBEL_PFANNERSTILL", "(302) 826-1219", "3acb6e77-9c3b-4879-99eb-afc3bd130950", 3, "Isobel_Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 37, "bc96cf7e-4935-4b86-a6c1-f59c0d36ea0d", "Lesly87@hotmail.com", "LESLY87@HOTMAIL.COM", "EMILIE32", "723.767.7365 x2887", "5ef4dabe-6c38-4c75-81f8-44676b0f159a", 2, "Emilie32" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 15, "9421d286-b362-49eb-ae85-28549e213ce4", "Jessica29@gmail.com", "JESSICA29@GMAIL.COM", "RENEE.MARKS", "398.388.0106 x3509", "5c5303c2-8550-4f5e-b29e-c25916c33d0f", 1, "Renee.Marks" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 77, "0f95cefe-eb32-45f9-8ff5-139ca8c4fb68", "Scotty_Gusikowski71@yahoo.com", "SCOTTY_GUSIKOWSKI71@YAHOO.COM", "MCKENZIE_KIRLIN", "448-265-4918 x5997", "fa76f96c-4852-46c1-b7eb-0ba496969df1", 4, "Mckenzie_Kirlin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 44, "24bbb36a-0cb5-44e7-8fc9-68a1b932637d", "Hortense.Huel37@yahoo.com", "HORTENSE.HUEL37@YAHOO.COM", "EDNA.HYATT93", "(867) 480-0040", "91c831e5-0515-42ad-9d3b-54c61288de3c", "Edna.Hyatt93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 51, "d55b6498-7b45-4350-a437-90170eabb7d3", "Kade.Murazik@gmail.com", "KADE.MURAZIK@GMAIL.COM", "MIA43", "(336) 599-1287 x833", "737e780b-9c4b-4ff6-baa2-1fac2e0d3095", 4, "Mia43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 28, "26a3359c-597a-4a7f-b50f-a2e35d79b4be", "Aurelie_Fadel46@hotmail.com", "AURELIE_FADEL46@HOTMAIL.COM", "IDA71", "787-270-2317", "11165d84-565f-4c4c-ba1a-b00015d0ff59", "Ida71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 16, "913679be-2e5f-4c0b-9979-31b7f82729bd", "Luella.Hegmann23@hotmail.com", "LUELLA.HEGMANN23@HOTMAIL.COM", "ALEXANDREA51", "(900) 356-6599", "b97b9a90-bdf3-49cd-9656-46ff4c2b9e88", 1, "Alexandrea51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 76, "e8b05aa4-2bf0-4686-8c54-20d6f2895857", "Keira_Kuhic92@gmail.com", "KEIRA_KUHIC92@GMAIL.COM", "DEONTAE_TILLMAN78", "401.530.9705 x10555", "78c1244a-4ebc-4488-8a05-161b58ce9848", 2, "Deontae_Tillman78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "48",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 75, "dd0f913d-dc2b-49d8-9ec7-d692bf3e7d8d", "Terrell.Jerde26@gmail.com", "TERRELL.JERDE26@GMAIL.COM", "MICAELA_BECKER28", "395.242.2597", "6a6e299a-7c96-4d60-a258-82c4d6336e48", 4, "Micaela_Becker28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 41, "852ea6d1-29a5-45ea-84d4-1292a20239ae", "Myah_Gulgowski@yahoo.com", "MYAH_GULGOWSKI@YAHOO.COM", "ALFRED22", "(671) 869-9800 x47218", "f527ea99-3736-4da0-9520-3972243503a4", 2, "Alfred22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 29, "ae43b0ec-3486-4900-988a-d212a07d9f47", "Nikko.West@hotmail.com", "NIKKO.WEST@HOTMAIL.COM", "KIAN.JOHNSTON", "1-504-527-6147", "a06e5c57-3e9c-4234-98c7-c3a3d178b949", 3, "Kian.Johnston" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 66, "bd908716-1724-40ee-9d16-607d2e194af3", "Alfonso10@gmail.com", "ALFONSO10@GMAIL.COM", "RHEA26", "388-711-5443 x65850", "ed6b8b7a-4cea-42db-b149-6e9a3900612c", "Rhea26" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "51",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 49, "2cb92a6c-7851-491e-a45d-e5cc327c71bf", "Stuart.Toy32@yahoo.com", "STUART.TOY32@YAHOO.COM", "MAGNOLIA.ZIEMANN", "580-375-4789 x82062", "c8e716fa-65d5-40f3-9503-cf6254b86562", 4, "Magnolia.Ziemann" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 75, "29a4cd2d-335b-4743-82f1-bed3d43f6576", "Alvis.Corwin10@hotmail.com", "ALVIS.CORWIN10@HOTMAIL.COM", "PRESTON_NADER41", "1-513-285-0999 x01993", "5993298f-8e95-46f0-adb6-fa85c11ae5bb", "Preston_Nader41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 43, "35eac693-b7f4-477e-afd3-af0fc47eb9d1", "Cecil_Dach@yahoo.com", "CECIL_DACH@YAHOO.COM", "QUEENIE.RUNTE5", "701.466.4163", "bf2a4aaa-ee87-4bed-bbaa-58afed0a481b", 4, "Queenie.Runte5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 32, "e5c0f18a-d21e-431d-b2ab-550a2d19dd1b", "Dusty45@gmail.com", "DUSTY45@GMAIL.COM", "ANNABELLE.HINTZ", "789-482-3056 x037", "4ea021ef-b34e-44ef-be60-53a981220c7a", 2, "Annabelle.Hintz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 66, "ae8f1db1-925c-44a3-a9dd-130f210c3bff", "Francesco.Gerlach30@hotmail.com", "FRANCESCO.GERLACH30@HOTMAIL.COM", "CHRIS_BATZ", "1-438-801-3703 x6379", "fc853b9b-a259-4534-9d61-4c609a9baeb9", 2, "Chris_Batz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 16, "91c4bb49-2533-4ac9-97fa-c4e19d3638cd", "Rebecca.Toy32@yahoo.com", "REBECCA.TOY32@YAHOO.COM", "CADEN49", "1-593-686-6491 x28195", "828e0e2d-7a2f-4872-babd-f8d71bff0d9e", 1, "Caden49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 28, "d3d8ac0d-44d6-4a3e-979a-50abf885c299", "Ross99@gmail.com", "ROSS99@GMAIL.COM", "RENEE.BOEHM", "570-734-4940", "56238758-d3f0-4861-84d4-94c7cec41a9d", 4, "Renee.Boehm" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 47, "5fafd060-d48e-48db-90b8-21c858ab2f18", "Maud.Zboncak81@gmail.com", "MAUD.ZBONCAK81@GMAIL.COM", "DANGELO.SCHOWALTER6", "(695) 545-5187 x92152", "0280bd9a-748b-464c-a3a9-6bb749f2edbd", 2, "Dangelo.Schowalter6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 67, "8369fd36-1221-441a-abdc-b3a836629a32", "Tre_Fay59@hotmail.com", "TRE_FAY59@HOTMAIL.COM", "ETTIE90", "1-450-862-7835 x2614", "e2e09082-75cb-4bd6-845f-6a892b7e79b2", 4, "Ettie90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 21, "798c0f4b-825f-4d39-b72b-f7eff47e6142", "America_Powlowski@yahoo.com", "AMERICA_POWLOWSKI@YAHOO.COM", "LAURYN_LUEILWITZ", "900.778.2705", "b6e57866-8c48-494f-b2ca-54b25f102aa8", 2, "Lauryn_Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "60",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "7ff377e8-3179-45ab-9231-3f13d6d7e0ac", "Lisette.Johnson@gmail.com", "LISETTE.JOHNSON@GMAIL.COM", "KYLEIGH_STOKES46", "652-226-6640 x633", "fe089fe8-732c-46f8-9cca-9c7cd3ba4179", 3, "Kyleigh_Stokes46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 54, "37b36573-7d90-46b9-a215-61636a6d52d5", "Antonia47@yahoo.com", "ANTONIA47@YAHOO.COM", "BERENICE2", "1-345-518-6593 x673", "a2e6c555-3b06-4d24-be85-046b5635c460", "Berenice2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 67, "5af7b089-002d-4683-a5dc-86723989a7e4", "Desiree.Krajcik89@yahoo.com", "DESIREE.KRAJCIK89@YAHOO.COM", "ELMIRA_DOUGLAS77", "685-696-5222 x11032", "4b901434-5102-4bb3-927f-efa729a902c1", "Elmira_Douglas77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 72, "40d32d17-44cf-408b-96af-ef3a99acbc2a", "Triston61@yahoo.com", "TRISTON61@YAHOO.COM", "JERALD.GOODWIN", "429-852-3838 x82033", "b1e79c87-9ac9-43c6-9528-0454fe721a69", 3, "Jerald.Goodwin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 20, "10903dc0-4658-450b-b515-68172d2495a3", "Kayleigh1@hotmail.com", "KAYLEIGH1@HOTMAIL.COM", "KENDALL.RATKE", "566.821.4219 x52916", "30a2ccbf-9e91-430e-811e-d5eef9d8ab5c", 2, "Kendall.Ratke" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 53, "39659179-c25c-46f0-907e-7e3531d11d3f", "Martina69@gmail.com", "MARTINA69@GMAIL.COM", "KAVON_CUMMINGS69", "1-319-487-8129", "60547dbd-94f3-43d5-abf4-00c3a1a3be4e", 2, "Kavon_Cummings69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 62, "a196499d-a325-4cf7-a57d-b91a312f1973", "Kayley83@yahoo.com", "KAYLEY83@YAHOO.COM", "JAZMYNE_RIPPIN", "1-501-517-2200 x1310", "4736e9f6-0f8c-4418-b28a-ff9bad049367", "Jazmyne_Rippin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "ac91e533-ecc8-4b77-bd0f-9947848a3e38", "Amalia.Kutch@hotmail.com", "AMALIA.KUTCH@HOTMAIL.COM", "DEMETRIUS.HAAG", "948-202-0780 x913", "a4bba87e-5f07-4115-836a-8d115608dda9", 3, "Demetrius.Haag" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "68",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 63, "f83ae14b-adfb-42ff-9151-473d82951335", "Daren.Kihn74@yahoo.com", "DAREN.KIHN74@YAHOO.COM", "FELIPA.MURPHY96", "489-536-7979 x6364", "e6dbe674-6c9c-4fd5-842b-638d30cbba2a", 2, "Felipa.Murphy96" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 68, "e072b433-f67b-4729-b86f-a9f20a9ab965", "Wilford47@hotmail.com", "WILFORD47@HOTMAIL.COM", "CRYSTEL.SCHROEDER17", "853-292-6872 x5326", "270d4714-1599-4595-8e3e-772874d942f5", 3, "Crystel.Schroeder17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 15, "d0d2f801-0ade-4e90-8ec9-2ce6a777726c", "Josephine.Orn@gmail.com", "JOSEPHINE.ORN@GMAIL.COM", "AUGUSTINE.KEEBLER1", "561.722.8940 x4218", "38ae314f-c6ac-4758-966e-9fa20d27ced8", 1, "Augustine.Keebler1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 13, "f07d3ba0-721c-4240-af4e-1fd314263153", "Erika.Goodwin64@hotmail.com", "ERIKA.GOODWIN64@HOTMAIL.COM", "ONIE55", "939-307-0850 x858", "f406c9fa-e097-42e9-a508-c20c023d09b1", 1, "Onie55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 44, "8bf5c73b-c5cf-4da9-a09a-7e493b184b97", "Micah_Jakubowski61@hotmail.com", "MICAH_JAKUBOWSKI61@HOTMAIL.COM", "GINA45", "685.680.3667", "7cea8a30-955b-4979-9ff6-9d7e7a338e97", "Gina45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 42, "2c694add-3ebb-45dc-88e4-cf485c36e721", "Zelda31@yahoo.com", "ZELDA31@YAHOO.COM", "CONRAD_COLLIER", "(789) 461-9248 x22907", "534f354f-987e-4bb5-ac3c-92025293819b", 2, "Conrad_Collier" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "264db5b0-79d2-46f4-bfa3-977c8c52b6ba", "Khalil_Kemmer@yahoo.com", "KHALIL_KEMMER@YAHOO.COM", "CESAR.MEDHURST", "1-559-721-8005", "8cdf24a6-baa1-447c-8184-de6f7f273b6f", 4, "Cesar.Medhurst" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "33b186ea-2fb8-4373-9cad-7772f977c72b", "Gerda71@yahoo.com", "GERDA71@YAHOO.COM", "MYRTIE_ROLFSON93", "1-453-876-9946 x57094", "8d9220dd-ae17-4581-84e3-3e612016ba51", 2, "Myrtie_Rolfson93" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 80, "4dd6c72e-fd71-4fa8-beee-d96f4a3a548d", "Lucile56@yahoo.com", "LUCILE56@YAHOO.COM", "ARDEN_ROBERTS21", "(836) 521-7168 x43283", "2e1edf70-ada7-4a9e-8e2a-96d0b3c5d87a", 2, "Arden_Roberts21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 27, "74a8d9de-27ad-46da-bc34-f212ad4e2f7e", "Idell3@gmail.com", "IDELL3@GMAIL.COM", "ANTHONY.HESSEL", "(952) 316-1732 x1049", "b3a1159a-e6da-4e80-a5aa-087ec87c11b5", "Anthony.Hessel" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "77",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 32, "dff2e9d4-49f7-48e2-b0b2-de8640e5e434", "Lisandro_Schaden@yahoo.com", "LISANDRO_SCHADEN@YAHOO.COM", "MAIYA_ANKUNDING", "868.396.3129", "26429ad9-6642-41fc-b398-44ef81a3ded8", 3, "Maiya_Ankunding" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 80, "b6d4c4e5-9dec-4a45-9cc1-fd6ddb589558", "Domenick.Franecki71@hotmail.com", "DOMENICK.FRANECKI71@HOTMAIL.COM", "EDMOND_BRAUN21", "214.284.0117 x31845", "35946a7c-9be7-4d12-a759-a7315d7c4b57", "Edmond_Braun21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 48, "5aab8a8b-776c-4773-8b31-43d8be6fbab3", "Laurianne6@yahoo.com", "LAURIANNE6@YAHOO.COM", "MCKENNA.FAHEY12", "450-999-7883 x880", "133c8b12-07a8-4d4f-982a-a75520896ba2", 4, "Mckenna.Fahey12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "39d4e793-52f7-405d-91ec-8f3dcb8fe3e2", "Jailyn6@gmail.com", "JAILYN6@GMAIL.COM", "GRETCHEN87", "(526) 776-0867 x548", "a2492c1e-4ddf-4f4a-8ed4-dcef26f4409a", 4, "Gretchen87" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 69, "fb82c11e-df93-4283-8718-a9d0b09f97bb", "Aditya62@yahoo.com", "ADITYA62@YAHOO.COM", "JOSEFINA_MUELLER70", "907.662.3895 x70532", "fc0e66f5-16ea-4975-88cf-63e65ca2cee0", 3, "Josefina_Mueller70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 18, "644fa150-f5f7-4cf3-85e2-cd3dea42f8c9", "Davon.Wolf@yahoo.com", "DAVON.WOLF@YAHOO.COM", "CLAY_FLATLEY", "1-987-225-6837 x0145", "091df42b-a205-49e3-b534-e652740bde92", "Clay_Flatley" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 64, "2f6831e4-d10a-410d-a77b-d97de50b2516", "Agnes_Parker@gmail.com", "AGNES_PARKER@GMAIL.COM", "KYLEIGH_JACOBSON", "391.203.3149", "5e32ef33-e437-4b49-9633-48adde12de83", 2, "Kyleigh_Jacobson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 36, "057900e5-ffd7-4581-a4b6-0ec2d38e6ff0", "Josh43@hotmail.com", "JOSH43@HOTMAIL.COM", "HERMINA_ABERNATHY11", "(697) 406-1555 x54462", "c4f7f111-038f-4780-a5e2-bcb822653b2f", 4, "Hermina_Abernathy11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 62, "8c18b74e-d623-40ac-8180-548911c89925", "Veda_Gibson97@hotmail.com", "VEDA_GIBSON97@HOTMAIL.COM", "MINERVA29", "1-639-538-2973 x63944", "a914953d-d69d-4c3c-94d0-06c82985cfbb", 3, "Minerva29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 70, "2213edb6-55e1-4c15-ad13-498de86fe977", "Maya_Dooley@yahoo.com", "MAYA_DOOLEY@YAHOO.COM", "RUSSELL.CUMMINGS36", "(409) 345-8226 x961", "0628b778-d028-4502-acfc-54c846ea4db7", 4, "Russell.Cummings36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 61, "84b91baa-ed03-4253-91b7-ee710e30a116", "Flossie_Rath@hotmail.com", "FLOSSIE_RATH@HOTMAIL.COM", "KIRSTIN82", "849-988-4487 x4127", "3345846b-c72d-40a9-ad57-b6df860eeaff", "Kirstin82" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 49, "d1757f67-c32a-4bb9-849e-f3da287b8ad7", "Lavinia32@hotmail.com", "LAVINIA32@HOTMAIL.COM", "GARRET_CHRISTIANSEN", "880.829.9242", "e90bd47b-3a7b-46ef-b79a-29dc9a7cad7b", 2, "Garret_Christiansen" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "695e1b2c-aeed-4361-ae88-40bb739560b3", "Amaya.Volkman@hotmail.com", "AMAYA.VOLKMAN@HOTMAIL.COM", "CRAIG27", "1-959-646-2909 x1241", "cbc89991-c1a0-4d38-8723-2e475462062d", 4, "Craig27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 12, "8a7c45ab-f3e0-4a6e-a6d6-d7ed8d4d4c9b", "Susanna.Moen94@gmail.com", "SUSANNA.MOEN94@GMAIL.COM", "VIVIANE.TREMBLAY", "632.947.3931", "9faefd4e-43d7-4a48-9ae9-20a52f3f7aa1", 1, "Viviane.Tremblay" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 23, "a9357b95-aa7b-443c-876d-ff7d85ca6b10", "Rosetta_Douglas@hotmail.com", "ROSETTA_DOUGLAS@HOTMAIL.COM", "TRESSA.JACOBI92", "1-554-204-5986", "52a2dde8-2a30-40ea-88d4-60519c9af23c", 2, "Tressa.Jacobi92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 20, "2d220e8f-a048-4814-b964-5cfb4b48e356", "Brandon.Crona@hotmail.com", "BRANDON.CRONA@HOTMAIL.COM", "ASTRID88", "808.794.4024 x93580", "fce3bdec-7c07-4bb8-8df2-e2e9de5c01a8", 4, "Astrid88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 70, "8e3e3f39-afe7-471d-9fe9-ea73e3ff2baa", "Bradly.Ferry@hotmail.com", "BRADLY.FERRY@HOTMAIL.COM", "DELL_CASPER", "262-449-1326", "fc38abd9-e4b4-4da2-b3cc-73da12696d2a", 2, "Dell_Casper" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 66, "0d5dff98-8f91-4731-8cb5-130eae1bd897", "Chance56@yahoo.com", "CHANCE56@YAHOO.COM", "KRYSTINA.HOEGER", "1-899-972-6071 x09498", "ce3abacb-07d0-41ad-84ef-c430ae3d3f21", "Krystina.Hoeger" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 33, "77fc121b-6ac3-4b33-83b8-b9f6b871b022", "Zack.Daniel@yahoo.com", "ZACK.DANIEL@YAHOO.COM", "ESTEBAN49", "758-247-5353 x2529", "7415582d-a8b4-4daf-a28a-707e269829bd", 3, "Esteban49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "a4f18071-6386-47d2-99fd-8deb6df82c8d", "Darryl_Champlin@yahoo.com", "DARRYL_CHAMPLIN@YAHOO.COM", "TITO.MAYER67", "(552) 865-5953 x39123", "b2b637cc-5558-4b4b-894c-e942001aebf6", 3, "Tito.Mayer67" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 39, "3692dae5-865f-4326-a792-213f14b61155", "Ernestina71@gmail.com", "ERNESTINA71@GMAIL.COM", "ERNESTINA12", "731-854-6472", "db635058-466f-4cf2-bc7b-404b75d4bdf2", "Ernestina12" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 12, "a05c0947-1e86-4408-986c-207a28dab99c", "Lavonne44@hotmail.com", "LAVONNE44@HOTMAIL.COM", "EMMITT_GISLASON47", "881-762-3851 x041", "7eae3e68-bfb5-4661-8c4c-f848aabed2d4", 1, "Emmitt_Gislason47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "c25a3863-42f8-4a07-b538-0aeb2e71d9bc", "Tressa18@gmail.com", "TRESSA18@GMAIL.COM", "DAISY_KIHN", "(923) 578-3227", "dba2011c-1569-475f-89b9-8d26f3405a17", "Daisy_Kihn" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 34, "04cc3dbe-406b-4f3f-84a7-48430a14a3f4", "Harley.Ernser@gmail.com", "HARLEY.ERNSER@GMAIL.COM", "CLEORA.SCHULTZ84", "317.349.4725 x912", "518b5d31-314a-4d10-870e-54badba6ab9b", 4, "Cleora.Schultz84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 16, "aebb762c-0545-44d6-a959-7fbbedc1e367", "Guido.Stokes@yahoo.com", "GUIDO.STOKES@YAHOO.COM", "LYSANNE.BUCKRIDGE1", "445.494.5360", "b1b88a91-b54c-4d77-a87d-fb78ac86c9eb", 1, "Lysanne.Buckridge1" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Tyshawn", "Klein" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Trevor", "Carroll" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alexandrea", "Boyer" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jordon", "Altenwerth" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kyleigh", "Wiegand" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Mayra", "Hamill" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Keyon", "Robel" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Cynthia", "Schamberger" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Haylie", "Parisian" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Richmond", "Daugherty" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Winston", "Dickinson" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Darrion", "Bernier" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Brian", "Cruickshank" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Leonor", "Fisher" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Chet", "Hyatt" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Faustino", "Schuppe" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ebony", "Gutkowski" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Larry", "Heathcote" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ellis", "O'Connell" });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sanford", "Marvin" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Ergonomic Granite Tuna", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 10, 4, "Unbranded Cotton Towels", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 1, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Steel Mouse", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Frozen Pants", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Soft Salad", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Wooden Chips", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Practical Cotton Shirt", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Refined Frozen Bacon", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 10, 3, "Unbranded Cotton Bike", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Table", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Plastic Keyboard", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Fresh Chair", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 2, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Plastic Salad", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Frozen Chair", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Soft Pizza", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 5, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Ergonomic Frozen Shirt", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Steel Shoes", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Cheese", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Cotton Tuna", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 2, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Metal Mouse", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Fresh Chair", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Gorgeous Soft Table", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Soft Chair", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Rubber Keyboard", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Awesome Rubber Gloves", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 3, "The Football Is Good For Training And Recreational Purposes", "Practical Rubber Hat", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handmade Steel Fish", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Plastic Chicken", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 17, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Concrete Towels" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Fresh Mouse", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Granite Keyboard", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 11, 3, "Fantastic Rubber Tuna", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handmade Fresh Salad", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handmade Soft Pizza", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 5, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Plastic Shirt", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Rubber Pizza", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Fresh Shirt", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Tasty Granite Tuna", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Rustic Metal Chair", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Ergonomic Wooden Pizza", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Steel Mouse", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Practical Plastic Bike", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Soft Pizza", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 5, 5, "Intelligent Wooden Hat", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Ergonomic Soft Ball", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Rustic Metal Pants", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, "The Football Is Good For Training And Recreational Purposes", "Handcrafted Soft Bacon", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, 3, "The Football Is Good For Training And Recreational Purposes", "Intelligent Metal Gloves", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Wooden Shoes", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handcrafted Plastic Table", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Rustic Rubber Towels", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 2, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Soft Pants", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Metal Keyboard", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 3, "The Football Is Good For Training And Recreational Purposes", "Handmade Plastic Sausages", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Soft Shoes", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 4, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Frozen Tuna", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 1, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Granite Table", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 4, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Soft Shirt", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Refined Frozen Car", 2015 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handmade Wooden Tuna", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Fresh Bacon", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 2, "The Football Is Good For Training And Recreational Purposes", "Incredible Plastic Soap", 2005 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Tasty Cotton Chips", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Metal Chips", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Awesome Granite Keyboard", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Tasty Steel Gloves", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Rustic Granite Keyboard", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Incredible Granite Pizza", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 12, 4, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Generic Concrete Hat", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Frozen Towels", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Soft Car", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Wooden Car", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Awesome Steel Chair", 2018 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 3, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Frozen Salad", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Cotton Tuna", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handmade Metal Pants", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Description", "Title", "YearOfRelease" },
                values: new object[] { "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Wooden Keyboard", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 3, "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Rustic Soft Bacon", 2010 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Rustic Rubber Pants", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Cotton Bike", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Licensed Concrete Ball", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Unbranded Concrete Soap", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 14, 2, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Towels" });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 3, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Intelligent Wooden Fish", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 4, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Small Fresh Sausages", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 2, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Licensed Frozen Pants", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, 3, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Small Plastic Chair", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, 1, "The Football Is Good For Training And Recreational Purposes", "Small Plastic Chicken", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 4, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Concrete Gloves", 2007 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Steel Hat", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Intelligent Frozen Keyboard", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Soft Sausages", 2019 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Wooden Chips", 2004 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Concrete Chair", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Tasty Steel Hat", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 5, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Concrete Sausages", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 2, "The Football Is Good For Training And Recreational Purposes", "Incredible Granite Gloves", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 1, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Incredible Fresh Ball", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Practical Frozen Towels", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 14, 4, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Generic Granite Table", 2019 });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 78, "27d9b0ad-76f3-4305-81b5-4a77f575d511", "Keyshawn21@gmail.com", "KEYSHAWN21@GMAIL.COM", "WILLARD_JOHNSON", "313-814-5988 x9294", "8449dd07-cd8e-448e-949b-ae8c2d86b3c7", 4, "Willard_Johnson" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 49, "2f158138-8c0f-46c4-b24b-676a0258b710", "Ardella.Koss86@yahoo.com", "ARDELLA.KOSS86@YAHOO.COM", "ORLAND_BERGNAUM", "426-746-6527 x8375", "c01ac55b-2f9b-4421-996e-7b6c95c3e907", 2, "Orland_Bergnaum" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 77, "2f2a67ed-8301-42ea-9464-e2be1801268b", "Paige86@gmail.com", "PAIGE86@GMAIL.COM", "BENNY.LESCH16", "(844) 527-1977", "0a14ba82-1e4f-4b16-b246-689e93bf03b8", "Benny.Lesch16" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 80, "edbdab3a-1b79-473a-a23c-bf3c84b9f260", "Maryse_Streich@hotmail.com", "MARYSE_STREICH@HOTMAIL.COM", "NORWOOD.JENKINS", "1-522-988-8203", "cb38eea3-7f4f-4226-93eb-32ea6d3f4733", "Norwood.Jenkins" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 63, "c145bd3b-ebf2-4062-a962-b09dff9251f8", "Justina_Rempel87@gmail.com", "JUSTINA_REMPEL87@GMAIL.COM", "STEPHON_ZIEME", "897-335-6722 x04015", "88108f6f-14b0-4ad1-bac1-f0e1d0f30f12", 3, "Stephon_Zieme" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "fcb2486c-bc05-44a1-b2ab-b2e7d0db9a53", "Rosalinda.Carroll90@yahoo.com", "ROSALINDA.CARROLL90@YAHOO.COM", "STEVE73", "679-753-9586 x52197", "d188816d-8f02-4c75-9eef-151983d3dd14", 2, "Steve73" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 18, "5f3c07e4-5c7d-449f-9628-816138c1fe76", "Louie.Nienow43@gmail.com", "LOUIE.NIENOW43@GMAIL.COM", "PEYTON.REILLY56", "372-764-9098", "aa872e08-3427-4795-8244-d3b476e21d02", "Peyton.Reilly56" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 18, "2beda5f1-d53d-443c-9d5c-d9ac91e83e71", "Emma.Hammes@gmail.com", "EMMA.HAMMES@GMAIL.COM", "GIOVANNI_PRICE34", "(565) 864-9809 x02933", "dc7db832-435f-42dd-8184-8c5adb2b5dfd", 2, "Giovanni_Price34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 55, "128704f8-2af7-44bc-bc76-ab9c6fdeb058", "Angeline99@gmail.com", "ANGELINE99@GMAIL.COM", "KEELY57", "1-819-605-5006 x390", "07e19919-fb2a-4a7b-b42e-885285495d8b", 4, "Keely57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 39, "9ded53b7-b4d0-4006-9acc-8200e78208d4", "Elisha12@gmail.com", "ELISHA12@GMAIL.COM", "TYREEK_NICOLAS", "287.468.3404", "bfa038b4-825b-41ca-a4fb-2ef2abf3d079", 4, "Tyreek_Nicolas" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 77, "a5f74d63-9c06-4d73-ad56-66672e3c665b", "Dovie.Howe@hotmail.com", "DOVIE.HOWE@HOTMAIL.COM", "AIDA_GRIMES22", "823.608.0547 x670", "70459ae8-f5b7-42cf-85fb-6d5eddea5ec0", 2, "Aida_Grimes22" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 58, "5d10d29a-1d10-4fec-b903-d61073d335bd", "Colt_Mante0@yahoo.com", "COLT_MANTE0@YAHOO.COM", "NORMA43", "832-237-3576 x708", "3de838ee-d05d-4c9e-adaf-290c10884dc4", "Norma43" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 57, "2f08f829-c46d-4f83-ab5f-09cfa086267a", "Raymundo.Daugherty75@gmail.com", "RAYMUNDO.DAUGHERTY75@GMAIL.COM", "COLEMAN.HYATT7", "1-769-608-2561", "77c23c3a-1ee9-40ac-b097-44e6300b4dbc", 3, "Coleman.Hyatt7" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 72, "3a716bda-325e-441c-95b9-a0596c32c0d8", "Herminio_Hermiston@yahoo.com", "HERMINIO_HERMISTON@YAHOO.COM", "LENNIE.VON65", "1-833-564-0857 x370", "3806e879-b92a-497e-8b07-3b7fbc10e068", "Lennie.Von65" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 42, "e7f84e7f-0ea2-4ca3-a56b-384a3a06ecc1", "Orion_Morar62@hotmail.com", "ORION_MORAR62@HOTMAIL.COM", "BILLY63", "775.471.3180 x1737", "b244340e-0ff9-4b06-a5c2-6b62c8d1378f", "Billy63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 49, "b244f246-d683-49c2-883b-037dd952087f", "Moises_Weber18@hotmail.com", "MOISES_WEBER18@HOTMAIL.COM", "DANIKA_BARTOLETTI", "(969) 382-1803", "5f4e82e3-e691-419d-972a-814ecb1198c0", "Danika_Bartoletti" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 34, "0c8ab53e-80e6-4f25-a52f-03582d01c8ef", "Tatum_Bartoletti54@gmail.com", "TATUM_BARTOLETTI54@GMAIL.COM", "DEVON_LARKIN86", "495.680.1956 x88033", "9c2aa0ce-1d2f-4026-bea2-137a9e6d9304", "Devon_Larkin86" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 30, "d2baf7dc-da0f-418e-b55d-f3a02d68206d", "Albert61@yahoo.com", "ALBERT61@YAHOO.COM", "RACHELLE.BERGSTROM", "482.224.8280 x906", "1fcd113c-b21d-4eae-8e55-f296ef125b4b", 2, "Rachelle.Bergstrom" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 64, "cbbfa838-a59f-4630-897d-21d899ea6d5c", "Tyreek55@gmail.com", "TYREEK55@GMAIL.COM", "MATHILDE7", "1-935-914-0617 x0951", "ab0c48a8-3feb-4b42-9ef4-8b7864e1699c", "Mathilde7" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 62, "43c34bd3-248f-435e-882d-9b5d9a6656f6", "Derek.Bayer40@hotmail.com", "DEREK.BAYER40@HOTMAIL.COM", "META_EBERT", "(436) 970-2501 x28047", "b7af7efa-58b9-4e81-9520-779fd8ee8f27", 2, "Meta_Ebert" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 39, "1f6bc4d8-058a-4eec-ba11-64c431c7cc49", "Berenice.Frami@gmail.com", "BERENICE.FRAMI@GMAIL.COM", "EZEQUIEL_SKILES", "962.209.0484", "7d5582ea-2de3-45f7-8058-546d46ea73fe", 4, "Ezequiel_Skiles" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 60, "1afa94bb-1a07-47d0-9a19-aac369070bc0", "Kaden5@gmail.com", "KADEN5@GMAIL.COM", "EZEQUIEL.PROSACCO96", "926-313-4674", "a5e1a68a-19c0-48e2-bcfb-54d677469317", "Ezequiel.Prosacco96" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 13, "5e4a7527-044a-44b6-9cd1-219509324a22", "Leone.Bauch@hotmail.com", "LEONE.BAUCH@HOTMAIL.COM", "SAMARA.KOELPIN", "495.635.6933", "980e6a46-4809-4563-ab04-2adc33a3e80b", 1, "Samara.Koelpin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66",
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 18, "7b66b67f-f074-40a6-94b2-74b617d14fe5", "Alayna65@gmail.com", "ALAYNA65@GMAIL.COM", "ODIE6", "590.855.9878 x3631", "7505b99c-d295-459f-b9dc-589fa1224fcf", "Odie6" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 58, "7e16f024-0543-48fe-b3db-77c1b20eb193", "Marisa19@yahoo.com", "MARISA19@YAHOO.COM", "DEXTER42", "1-516-472-1861", "86f0fc26-10ef-4471-a17f-eb8333964b77", 4, "Dexter42" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 27, "d0c4dbdd-5789-48d9-9799-60334ec327c6", "Newell99@hotmail.com", "NEWELL99@HOTMAIL.COM", "PAXTON35", "836.946.5652", "1c151e53-14f2-4d02-a98f-176eeb2f894f", 2, "Paxton35" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 40, "5d2be353-74a5-4381-9ad8-ce1a9633cc52", "Roy_Flatley@hotmail.com", "ROY_FLATLEY@HOTMAIL.COM", "JORDON36", "1-710-674-1085", "d2a28600-2118-4b85-b503-79e27d33123d", "Jordon36" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 14, "d8027371-521f-4cb5-a67f-1686bafa98c7", "Lilliana_Schneider@hotmail.com", "LILLIANA_SCHNEIDER@HOTMAIL.COM", "ANGELITA_MAYERT", "(704) 915-5956 x1366", "b0d63e4d-0856-4223-81b6-33339057a8ef", 1, "Angelita_Mayert" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 19, "f1f75b49-40d5-42b9-b211-561e21a8a2be", "Lina54@yahoo.com", "LINA54@YAHOO.COM", "DAX59", "441.423.1035 x257", "0473a8b8-4ac9-4d29-92db-9dac51021881", 3, "Dax59" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 24, "6d167c54-8a71-4b4a-a00d-8c1be824f0a7", "Noah_Cartwright@gmail.com", "NOAH_CARTWRIGHT@GMAIL.COM", "DOROTHEA.KERLUKE", "1-359-824-1765 x5565", "8ea1caf3-2b18-44f3-aeb8-9b1f4e5b7dd7", 2, "Dorothea.Kerluke" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { 39, "adb838b6-02c5-4413-bc1f-873e2e185c59", "Maynard.Cronin@gmail.com", "MAYNARD.CRONIN@GMAIL.COM", "POLLY31", "(235) 585-8622 x1112", "b4bd0365-5ec8-4e56-ba5e-7ca839a0d733", "Polly31" });

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
                columns: new[] { "Age", "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "SubscriptionId", "UserName" },
                values: new object[] { 66, "a2855a2e-f5da-4526-bc24-206374ffe85c", "Frankie81@yahoo.com", "FRANKIE81@YAHOO.COM", "TANNER.DARE56", "(649) 519-7247 x873", "6ab6c76a-674c-4ae2-b3e4-f04f5f2c4204", 4, "Tanner.Dare56" });

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
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PhoneNumber", "SecurityStamp", "UserName" },
                values: new object[] { "ccb64200-1e52-47d7-830a-09cd89a97b13", "Bertram.Roob@hotmail.com", "BERTRAM.ROOB@HOTMAIL.COM", "GUSSIE.BORER67", "404.702.5354 x7856", "33eaa796-e392-46cc-ae5d-6a23dd348697", "Gussie.Borer67" });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, "The Football Is Good For Training And Recreational Purposes", "Tasty Wooden Fish", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 2, 5, "Gorgeous Frozen Bacon", 2007 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Concrete Table", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Unbranded Frozen Hat", 2000 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 2, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Pants", 2020 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, "The Football Is Good For Training And Recreational Purposes", "Practical Concrete Towels", 2002 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "Sleek Metal Mouse", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Incredible Metal Towels", 2014 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Wooden Shoes", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 4, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Licensed Cotton Sausages", 2013 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 6, 2, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Granite Bacon", 2008 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Wooden Bike", 2020 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 1, "The Football Is Good For Training And Recreational Purposes", "Intelligent Cotton Fish", 2019 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 19, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Hat", 2006 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 13, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Soft Salad", 2023 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 8, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Fresh Salad", 2001 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Intelligent Rubber Mouse", 2004 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 4, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Awesome Plastic Cheese" });

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
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Granite Car", 2014 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 4, 5, "Gorgeous Rubber Computer", 2016 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Refined Concrete Chicken", 2012 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, 5, "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Intelligent Rubber Sausages", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 1, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Metal Tuna", 2015 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Frozen Shirt", 2021 });

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
                columns: new[] { "AuthorId", "CategoryId", "Title", "YearOfRelease" },
                values: new object[] { 8, 4, "Licensed Wooden Fish", 2009 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, 1, "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Generic Metal Gloves", 2023 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 10, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Handcrafted Cotton Computer", 2008 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Tasty Fresh Table", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 18, 5, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Unbranded Plastic Pants", 2015 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Ergonomic Concrete Bacon", 2002 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 3, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Refined Cotton Car", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Licensed Soft Pizza", 2022 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Practical Plastic Computer", 2015 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 7, "The Football Is Good For Training And Recreational Purposes", "Ergonomic Granite Tuna", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 4, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Incredible Rubber Car", 2016 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 16, 3, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Fantastic Granite Pants", 2011 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Steel Computer", 2003 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 3, 5, "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Metal Keyboard", 2001 });

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
                columns: new[] { "Description", "Title", "YearOfRelease" },
                values: new object[] { "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Small Metal Towels", 2003 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, 2, "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Metal Fish", 2001 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Steel Cheese", 2009 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, 5, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Intelligent Metal Car", 2017 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 9, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Awesome Plastic Computer", 2022 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title" },
                values: new object[] { 4, 1, "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Unbranded Plastic Bike" });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 20, 3, "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Soft Chair", 2021 });

            migrationBuilder.UpdateData(
                table: "Item",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 11, 4, "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Generic Fresh Gloves", 2005 });

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
                columns: new[] { "AuthorId", "CategoryId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 17, 5, "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Gorgeous Frozen Shoes", 2001 });

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
                columns: new[] { "AuthorId", "Description", "Title", "YearOfRelease" },
                values: new object[] { 15, "The Football Is Good For Training And Recreational Purposes", "Sleek Granite Chips", 2014 });

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
