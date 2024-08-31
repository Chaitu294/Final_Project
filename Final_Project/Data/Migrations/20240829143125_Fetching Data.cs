using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class FetchingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 20, 1, 24, 501, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 8, 29, 20, 1, 24, 501, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 20, 1, 24, 501, DateTimeKind.Local).AddTicks(4706), new DateTime(2024, 8, 29, 20, 1, 24, 501, DateTimeKind.Local).AddTicks(4705) });
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
