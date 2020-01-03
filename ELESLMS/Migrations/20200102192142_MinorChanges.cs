using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ELESLMS.Migrations
{
    public partial class MinorChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Courses");

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
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 22, 21, 42, 11, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 22, 21, 42, 10, DateTimeKind.Local).AddTicks(3667));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Courses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 15, 46, 42, 578, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 15, 46, 42, 578, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: new DateTime(2020, 1, 2, 15, 46, 42, 577, DateTimeKind.Local).AddTicks(4492));
        }
    }
}
