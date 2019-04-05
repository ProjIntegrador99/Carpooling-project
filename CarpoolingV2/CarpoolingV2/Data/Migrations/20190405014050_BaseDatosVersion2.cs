using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpoolingV2.Data.Migrations
{
    public partial class BaseDatosVersion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tribu",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Tribu",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
