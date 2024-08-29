using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserandAppointment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments");

            migrationBuilder.RenameTable(
                name: "Appointments",
                newName: "Appointment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment",
                column: "AppId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Appointment",
                columns: new[] { "AppId", "AppTitle", "Attendees", "Description", "EndDateTime", "Location", "StartDateTime" },
                values: new object[,]
                {
                    { 1, "Title1", "Attendee1", "Description1", new DateTime(2024, 8, 29, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6453), "Location1", new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6451) },
                    { 2, "Title2", "Attendee2", "Description2", new DateTime(2024, 8, 30, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6463), "Location2", new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6463) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Created", "PhotoPath", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6159), "~/Images/john.png", "User1" },
                    { 2, new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6162), "~/Images/mary.png", "User2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Appointment",
                table: "Appointment");

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Appointment",
                newName: "Appointments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Appointments",
                table: "Appointments",
                column: "AppId");
        }
    }
}
