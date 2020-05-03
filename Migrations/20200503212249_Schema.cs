using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeTracker.Migrations
{
    public partial class Schema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "time");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Users",
                newSchema: "time");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Groups",
                newSchema: "time");

            migrationBuilder.RenameTable(
                name: "Entries",
                newName: "Entries",
                newSchema: "time");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "time");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Users",
                schema: "time",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Groups",
                schema: "time",
                newName: "Groups");

            migrationBuilder.RenameTable(
                name: "Entries",
                schema: "time",
                newName: "Entries");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "time",
                newName: "Categories");
        }
    }
}
