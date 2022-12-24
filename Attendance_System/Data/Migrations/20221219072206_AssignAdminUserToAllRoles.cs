using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_System.Data.Migrations
{
    public partial class AssignAdminUserToAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[AspNetUserRoles] (UserId,RoleId) SELECT '1be8aff9-3b08-4dd1-8e77-0092a9354add' , Id FROM [dbo].[AspNetRoles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo].[AspNetUserRoles] WHERE UserId= '1be8aff9-3b08-4dd1-8e77-0092a9354add'");
        }
    }
}
