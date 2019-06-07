using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpooling.Data.Migrations
{
    public partial class BD10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Creator",
                table: "Tribu",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creator",
                table: "Tribu");
        }
    }
}
