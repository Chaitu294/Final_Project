using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NewTasks_Customer_CustomerId",
                table: "NewTasks");

            migrationBuilder.DropIndex(
                name: "IX_NewTasks_CustomerId",
                table: "NewTasks");

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Appointment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "CustomerId", "EndDateTime", "StartDateTime" },
                values: new object[] { 0, new DateTime(2024, 8, 31, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9418), new DateTime(2024, 8, 29, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "CustomerId", "EndDateTime", "StartDateTime" },
                values: new object[] { 0, new DateTime(2024, 9, 1, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9428), new DateTime(2024, 8, 29, 15, 57, 43, 752, DateTimeKind.Local).AddTicks(9427) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Appointment");

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
    }
}
