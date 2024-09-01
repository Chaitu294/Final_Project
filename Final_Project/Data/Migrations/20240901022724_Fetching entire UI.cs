using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class FetchingentireUI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 3, 7, 57, 23, 276, DateTimeKind.Local).AddTicks(3586), new DateTime(2024, 9, 1, 7, 57, 23, 276, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 4, 7, 57, 23, 276, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 9, 1, 7, 57, 23, 276, DateTimeKind.Local).AddTicks(3595) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
