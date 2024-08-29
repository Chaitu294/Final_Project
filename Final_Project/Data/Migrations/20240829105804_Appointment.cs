using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Appointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 28, 3, 707, DateTimeKind.Local).AddTicks(2238), new DateTime(2024, 8, 29, 16, 28, 3, 707, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 16, 28, 3, 707, DateTimeKind.Local).AddTicks(2249), new DateTime(2024, 8, 29, 16, 28, 3, 707, DateTimeKind.Local).AddTicks(2248) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 8, 29, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 8, 29, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9427) });
        }
    }
}
