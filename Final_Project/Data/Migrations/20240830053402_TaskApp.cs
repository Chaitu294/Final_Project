using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaskApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TaskId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime", "TaskId" },
                values: new object[] { new DateTime(2024, 9, 1, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 8, 30, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3405), 0 });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime", "TaskId" },
                values: new object[] { new DateTime(2024, 9, 2, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 8, 30, 11, 4, 0, 774, DateTimeKind.Local).AddTicks(3421), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskId",
                table: "Appointment");

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
