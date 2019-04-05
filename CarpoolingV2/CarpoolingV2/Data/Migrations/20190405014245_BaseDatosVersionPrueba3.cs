using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpoolingV2.Data.Migrations
{
    public partial class BaseDatosVersionPrueba3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Usuario",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Area",
                table: "Usuario",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
