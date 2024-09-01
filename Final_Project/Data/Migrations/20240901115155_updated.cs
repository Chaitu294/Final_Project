using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 3, 17, 21, 54, 638, DateTimeKind.Local).AddTicks(5276), new DateTime(2024, 9, 1, 17, 21, 54, 638, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 4, 17, 21, 54, 638, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 9, 1, 17, 21, 54, 638, DateTimeKind.Local).AddTicks(5287) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
