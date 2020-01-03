using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELESLMS.Migrations
{
    public partial class InttoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Users",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "PhoneNumber", "Number" },
                values: new object[] { new DateTime(2020, 1, 2, 15, 46, 42, 578, DateTimeKind.Local).AddTicks(6308), null, "321" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 1, 2, 15, 46, 42, 578, DateTimeKind.Local).AddTicks(7740), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 1, 2, 15, 46, 42, 577, DateTimeKind.Local).AddTicks(4492), null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTime", "PhoneNumber", "Number" },
                values: new object[] { new DateTime(2020, 1, 2, 6, 46, 55, 347, DateTimeKind.Local).AddTicks(7125), 0, 321 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 1, 2, 6, 46, 55, 347, DateTimeKind.Local).AddTicks(8553), 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "PhoneNumber" },
                values: new object[] { new DateTime(2020, 1, 2, 6, 46, 55, 346, DateTimeKind.Local).AddTicks(4288), 0 });
        }
    }
}
