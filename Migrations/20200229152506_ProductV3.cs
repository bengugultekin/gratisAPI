using Microsoft.EntityFrameworkCore.Migrations;

namespace gratisAPI.Migrations
{
    public partial class ProductV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "URL",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "URL",
                table: "Product");
        }
    }
}
