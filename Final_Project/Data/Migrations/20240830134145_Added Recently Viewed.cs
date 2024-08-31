using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRecentlyViewed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecentCustomer",
                columns: table => new
                {
                    RecentCustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentCustomer", x => x.RecentCustomerId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecentCustomer");

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
