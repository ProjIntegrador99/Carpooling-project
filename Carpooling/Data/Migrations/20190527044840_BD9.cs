using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpooling.Data.Migrations
{
    public partial class BD9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagenFinal",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagenFinal",
                table: "AspNetUsers");
        }
    }
}
