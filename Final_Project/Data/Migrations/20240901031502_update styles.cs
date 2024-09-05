using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class updatestyles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 3, 8, 45, 1, 734, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 9, 1, 8, 45, 1, 734, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 4, 8, 45, 1, 734, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 9, 1, 8, 45, 1, 734, DateTimeKind.Local).AddTicks(7185) });
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
