using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskLinkApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 8, 50, 590, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 8, 30, 11, 8, 50, 590, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 11, 8, 50, 590, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 8, 30, 11, 8, 50, 590, DateTimeKind.Local).AddTicks(4882) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 8, 30, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 2, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 8, 30, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3421) });
        }
    }
}
