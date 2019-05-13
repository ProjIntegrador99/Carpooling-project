using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carpooling.Data.Migrations
{
    public partial class BD5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Solicitudes",
                columns: table => new
                {
                    SolicitudId = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: false),
                    Hora = table.Column<DateTime>(nullable: false),
                    TipoViaje = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(nullable: false),
                    Cupos = table.Column<int>(nullable: false),
                    NombreConductor = table.Column<string>(nullable: false),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitudes", x => x.SolicitudId);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosSolicitudes",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(nullable: false),
                    SolicitudId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosSolicitudes", x => new { x.UsuarioId, x.SolicitudId });
                    table.ForeignKey(
                        name: "FK_UsuariosSolicitudes_Solicitudes_SolicitudId",
                        column: x => x.SolicitudId,
                        principalTable: "Solicitudes",
                        principalColumn: "SolicitudId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuariosSolicitudes_AspNetUsers_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosSolicitudes_SolicitudId",
                table: "UsuariosSolicitudes",
                column: "SolicitudId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosSolicitudes");

            migrationBuilder.DropTable(
                name: "Solicitudes");
        }
    }
}
