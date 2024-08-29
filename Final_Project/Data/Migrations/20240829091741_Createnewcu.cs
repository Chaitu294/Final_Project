using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class Createnewcu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "NewTasks",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 47, 40, 583, DateTimeKind.Local).AddTicks(2133), new DateTime(2024, 8, 29, 14, 47, 40, 583, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 47, 40, 583, DateTimeKind.Local).AddTicks(2142), new DateTime(2024, 8, 29, 14, 47, 40, 583, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.CreateIndex(
                name: "IX_NewTasks_CustomerId",
                table: "NewTasks",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_NewTasks_Customer_CustomerId",
                table: "NewTasks",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewTasks_Customer_CustomerId",
                table: "NewTasks");

            migrationBuilder.DropIndex(
                name: "IX_NewTasks_CustomerId",
                table: "NewTasks");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "NewTasks");

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 8, 29, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 8, 29, 14, 37, 28, 694, DateTimeKind.Local).AddTicks(5765) });
        }
    }
}
