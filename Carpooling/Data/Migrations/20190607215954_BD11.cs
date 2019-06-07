using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpooling.Data.Migrations
{
    public partial class BD11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tribu",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tribu",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
