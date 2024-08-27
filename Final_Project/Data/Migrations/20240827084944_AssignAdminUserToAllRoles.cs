using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdminUserToAllRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUserRoles] (UserId, RoleId) SELECT '1e658e9e-5a52-4712-9bf3-6b822d2ad34a', Id FROM [dbo].[AspNetRoles]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUserRoles]  WHERE UserId = '1e658e9e-5a52-4712-9bf3-6b822d2ad34a'");
        }
    }
}
