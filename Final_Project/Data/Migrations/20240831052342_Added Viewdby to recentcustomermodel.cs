using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedViewdbytorecentcustomermodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ViewedBy",
                table: "RecentCustomer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 10, 53, 40, 964, DateTimeKind.Local).AddTicks(2991), new DateTime(2024, 8, 31, 10, 53, 40, 964, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 53, 40, 964, DateTimeKind.Local).AddTicks(3000), new DateTime(2024, 8, 31, 10, 53, 40, 964, DateTimeKind.Local).AddTicks(2999) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViewedBy",
                table: "RecentCustomer");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 10, 44, 29, 889, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 8, 31, 10, 44, 29, 889, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 3, 10, 44, 29, 889, DateTimeKind.Local).AddTicks(8282), new DateTime(2024, 8, 31, 10, 44, 29, 889, DateTimeKind.Local).AddTicks(8281) });
        }
    }
}
