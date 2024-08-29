using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 8, 29, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 8, 29, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5765) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 24, 35, 848, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 8, 29, 14, 24, 35, 848, DateTimeKind.Local).AddTicks(6493) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 24, 35, 848, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 8, 29, 14, 24, 35, 848, DateTimeKind.Local).AddTicks(6513) });
        }
    }
}
