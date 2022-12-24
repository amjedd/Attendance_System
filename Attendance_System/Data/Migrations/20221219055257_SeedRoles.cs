using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_System.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
             table: "AspNetRoles",
             columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
             values: new object[] { "0eef6e5d-b432-46c9-adc9-ca97b2501e5e", "5204db53-4fb4-4091-be44-1d154157eb39", "User", "USER" });


            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2b09dfcc-e06a-41c5-92fd-2510f557ccd5", "084ae2ef-5a5e-4c57-8a46-833aa7ac4013", "Manager", "MANAGER" });
            //migrationBuilder.InsertData(
            //    table: "AspNetRoles",
            //    columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
            //    values: new object[] { Guid.NewGuid().ToString(), "User", "User".ToUpper(), Guid.NewGuid().ToString() },
            //    schema:"dbo"
            //    );

            //migrationBuilder.InsertData(
            //  table: "AspNetRoles",
            //  columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
            //  values: new object[] { Guid.NewGuid().ToString(), "Manager", "Manager".ToUpper(), Guid.NewGuid().ToString() },
            //  schema: "dbo"

            //  );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
              table: "AspNetRoles",
              keyColumn: "Id",
              keyValue: "0eef6e5d-b432-46c9-adc9-ca97b2501e5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b09dfcc-e06a-41c5-92fd-2510f557ccd5");
        }
    }
}
