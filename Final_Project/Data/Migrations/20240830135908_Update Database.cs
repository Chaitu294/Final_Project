using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 29, 7, 272, DateTimeKind.Local).AddTicks(7729), new DateTime(2024, 8, 30, 19, 29, 7, 272, DateTimeKind.Local).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 19, 29, 7, 272, DateTimeKind.Local).AddTicks(7737), new DateTime(2024, 8, 30, 19, 29, 7, 272, DateTimeKind.Local).AddTicks(7737) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 19, 11, 44, 589, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 8, 30, 19, 11, 44, 589, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 19, 11, 44, 589, DateTimeKind.Local).AddTicks(1640), new DateTime(2024, 8, 30, 19, 11, 44, 589, DateTimeKind.Local).AddTicks(1640) });
        }
    }
}
