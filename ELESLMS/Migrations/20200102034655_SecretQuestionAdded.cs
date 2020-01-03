using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELESLMS.Migrations
{
    public partial class SecretQuestionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecretAnswer",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecretQuestion",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 6, 46, 55, 347, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Subject" },
                values: new object[] { new DateTime(2020, 1, 2, 6, 46, 55, 347, DateTimeKind.Local).AddTicks(8553), "Programming" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 6, 46, 55, 346, DateTimeKind.Local).AddTicks(4288));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecretAnswer",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecretQuestion",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 30, 22, 6, 14, 238, DateTimeKind.Local).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTime", "Subject" },
                values: new object[] { new DateTime(2019, 12, 30, 22, 6, 14, 238, DateTimeKind.Local).AddTicks(7830), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2019, 12, 30, 22, 6, 14, 237, DateTimeKind.Local).AddTicks(6070));
        }
    }
}
