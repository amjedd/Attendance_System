using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_System.Data.Migrations
{
    public partial class AddAdmiUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicture]) VALUES (N'1be8aff9-3b08-4dd1-8e77-0092a9354add', N'admin@admin.com', N'ADMIN@ADMIN.COM', N'admin@admin.com', N'ADMIN@ADMIN.COM', 1, N'AQAAAAEAACcQAAAAEDpHQe3zM2ZZ465Gzc4jerDjkYw/NQyvGO52W6EYW3fPK/8PXMxOs4F6oEz3qqcKuw==', N'ZH4GEDGKVZ5O3O6E62QFL2L556HZ7BB7', N'9e965ac2-41bd-45d7-b9a5-52a3582521ca', NULL, 0, 0, NULL, 1, 0, N'Manager', N'Manager',0X00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUsers] WHERE Id= '1be8aff9-3b08-4dd1-8e77-0092a9354add'");
        }
    }
}
