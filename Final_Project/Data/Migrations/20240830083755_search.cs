using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class search : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 7, 54, 320, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 8, 30, 14, 7, 54, 320, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 14, 7, 54, 320, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 8, 30, 14, 7, 54, 320, DateTimeKind.Local).AddTicks(1578) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
