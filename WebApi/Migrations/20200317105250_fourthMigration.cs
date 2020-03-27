using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class fourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Caseworker",
                table: "Caseworker");

            migrationBuilder.RenameTable(
                name: "Caseworker",
                newName: "Caseworkers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caseworkers",
                table: "Caseworkers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Caseworkers",
                table: "Caseworkers");

            migrationBuilder.RenameTable(
                name: "Caseworkers",
                newName: "Caseworker");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caseworker",
                table: "Caseworker",
                column: "Id");
        }
    }
}
