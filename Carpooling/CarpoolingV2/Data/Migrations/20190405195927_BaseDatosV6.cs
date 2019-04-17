using Microsoft.EntityFrameworkCore.Migrations;

namespace CarpoolingV2.Data.Migrations
{
    public partial class BaseDatosV6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cupos",
                table: "Viaje",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "NombreConductor",
                table: "Viaje",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NombreConductor",
                table: "Viaje");

            migrationBuilder.AlterColumn<string>(
                name: "Cupos",
                table: "Viaje",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
