using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELESLMS.Migrations
{
    public partial class FinalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "OpeningDate", "TeacherId" },
                values: new object[,]
                {
                    { 1, "efso ders", "cet 301", new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(9498), 3 },
                    { 6, "efso dersin ikincisi", "cet 322", new DateTime(2020, 1, 3, 7, 3, 16, 260, DateTimeKind.Local).AddTicks(296), 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Password" },
                values: new object[] { new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(7171), "7f87373c2109e88f1bfcea954c222fa07a5a2b5ab030b0f18e1a3e25b344a4f1" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 3, 7, 3, 16, 258, DateTimeKind.Local).AddTicks(4147));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedTime", "EMail", "IsDeleted", "LastLogin", "Name", "Password", "PhoneNumber", "RoleId", "SecretAnswer", "SecretQuestion", "Surname", "UserName", "Number" },
                values: new object[,]
                {
                    { 4, null, new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(5730), "yakisikli1@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "e22df7824352fc6caaa36d2132faa4f974a9f8cd27774b6a1727a9ae7f0e16ab", null, 2, null, 0, "Bechkham", "Yakisikli1", "123" },
                    { 6, null, new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(5833), "tsubasa333@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cristiano", "0ef15c9323f8f3e16f9ee0f37f6a4bcc18040d210f45d7ada3074650d11d8834", null, 2, null, 0, "Ronaldı", "Tsubasa333", "333" },
                    { 7, null, new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(5902), "whaat2@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Okuttum", "7ba212399865786bddeeae30bcca4d89e29eb10eb56d0100f1570a5a6d7415bc", null, 2, null, 0, "Bro", "whaat2", "222" },
                    { 8, null, new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(5971), "elveda26@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yeter", "d37ec7d7506f856d4dc1a40bc09509e0bd964331b2712f5cb7ca584d39575cae", null, 2, null, 0, "Bukadar", "elveda26", "262" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "CreatedTime", "EMail", "IsDeleted", "LastLogin", "Name", "Password", "PhoneNumber", "RoleId", "SecretAnswer", "SecretQuestion", "Surname", "UserName", "Subject" },
                values: new object[] { 9, null, new DateTime(2020, 1, 3, 7, 3, 16, 259, DateTimeKind.Local).AddTicks(7777), "hamdierkunt@gmail.com", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamdi", "9df61ac8f46d4cda72ec2c09da76335bc3d9b95b9a3670beec3e3b2e1924b860", null, 3, null, 0, "Erkunt", "Kral", "Algorythm" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "OpeningDate", "TeacherId" },
                values: new object[] { 7, "muttesem ders", "cet 314", new DateTime(2020, 1, 3, 7, 3, 16, 260, DateTimeKind.Local).AddTicks(314), 9 });

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 22, 21, 42, 11, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Password" },
                values: new object[] { new DateTime(2020, 1, 2, 22, 21, 42, 11, DateTimeKind.Local).AddTicks(8020), "717ed8efab4988cc10ffa7fbaf60dd89bcba6526e10f7c0d4dc16a87a103282c" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 22, 21, 42, 10, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Users_TeacherId",
                table: "Courses",
                column: "TeacherId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
