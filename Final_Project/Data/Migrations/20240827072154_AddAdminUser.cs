using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName]) VALUES (N'1e658e9e-5a52-4712-9bf3-6b822d2ad34a', N'bitturoy32001@gmail.com', N'BITTUROY32001@GMAIL.COM', N'bitturoy32001@gmail.com', N'BITTUROY32001@GMAIL.COM', 1, N'AQAAAAIAAYagAAAAEMMcdNZdTVtIpmfWnc40OLy8+laIfIhV3EeYPLFbHlwkPcACjKl2SJRsy0cDbAvv1Q==', N'VNDXFIL76CQRTVURDZIPOBC22AIPNWIK', N'0b68c002-96a6-4b90-b049-9e7050f98d7d', NULL, 0, 0, NULL, 1, 0, N'Rajarshee', N'Roy')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUsers] WHERE Id = '1e658e9e-5a52-4712-9bf3-6b822d2ad34a'");
        }
    }
}
