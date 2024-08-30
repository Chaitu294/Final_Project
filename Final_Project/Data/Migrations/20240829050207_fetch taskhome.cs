using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class fetchtaskhome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 10, 32, 7, 56, DateTimeKind.Local).AddTicks(9777), new DateTime(2024, 8, 29, 10, 32, 7, 56, DateTimeKind.Local).AddTicks(9764) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 10, 32, 7, 56, DateTimeKind.Local).AddTicks(9785), new DateTime(2024, 8, 29, 10, 32, 7, 56, DateTimeKind.Local).AddTicks(9784) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 10, 28, 27, 571, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 8, 29, 10, 28, 27, 571, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 10, 28, 27, 571, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 8, 29, 10, 28, 27, 571, DateTimeKind.Local).AddTicks(8758) });
        }
    }
}
