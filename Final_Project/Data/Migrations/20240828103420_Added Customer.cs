using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerId);
                });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 30, 16, 4, 19, 570, DateTimeKind.Local).AddTicks(7711), new DateTime(2024, 8, 28, 16, 4, 19, 570, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 31, 16, 4, 19, 570, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 8, 28, 16, 4, 19, 570, DateTimeKind.Local).AddTicks(7719) });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "MiddleName", "PhoneNumber", "PreferredName", "Surname", "Title" },
                values: new object[,]
                {
                    { 1, "Address1", "Email1", "Firstname1", "MiddleName1", 123456, "PreferredName1", "Surname1", "Title1" },
                    { 2, "Address2", "Email2", "Firstname2", "MiddleName2", 234567, "PreferredName2", "Surname2", "Title2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 1,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 29, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6453), new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6451) });

            migrationBuilder.UpdateData(
                table: "Appointment",
                keyColumn: "AppId",
                keyValue: 2,
                columns: new[] { "EndDateTime", "StartDateTime" },
                values: new object[] { new DateTime(2024, 8, 30, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "UserId", "Created", "PhotoPath", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6159), "~/Images/john.png", "User1" },
                    { 2, new DateTime(2024, 8, 27, 18, 47, 56, 613, DateTimeKind.Local).AddTicks(6162), "~/Images/mary.png", "User2" }
                });
        }
    }
}
