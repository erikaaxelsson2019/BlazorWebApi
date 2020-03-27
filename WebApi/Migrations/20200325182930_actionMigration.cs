using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class actionMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases");

            migrationBuilder.AddForeignKey(
                name: "FK_Cases_Customers_CustomerId",
                table: "Cases",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
