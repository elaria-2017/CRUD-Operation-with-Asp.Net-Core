using Microsoft.EntityFrameworkCore.Migrations;

namespace Lend_CRUD.Migrations
{
    public partial class addlenderanditemnamecols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "itemName",
                table: "items",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lender",
                table: "items",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "itemName",
                table: "items");

            migrationBuilder.DropColumn(
                name: "lender",
                table: "items");
        }
    }
}
