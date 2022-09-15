using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musse.Data.Migrations
{
    public partial class InicialFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapaPrevios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mapa",
                table: "Mapa");

            migrationBuilder.RenameTable(
                name: "Mapa",
                newName: "Mapas");

            migrationBuilder.RenameColumn(
                name: "MapaActualBase",
                table: "Mapas",
                newName: "Tipo");

            migrationBuilder.AddColumn<bool>(
                name: "Actual",
                table: "Mapas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MapaBase64",
                table: "Mapas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Mapas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mapas",
                table: "Mapas",
                column: "MapaActualId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mapas",
                table: "Mapas");

            migrationBuilder.DropColumn(
                name: "Actual",
                table: "Mapas");

            migrationBuilder.DropColumn(
                name: "MapaBase64",
                table: "Mapas");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Mapas");

            migrationBuilder.RenameTable(
                name: "Mapas",
                newName: "Mapa");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Mapa",
                newName: "MapaActualBase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mapa",
                table: "Mapa",
                column: "MapaActualId");

            migrationBuilder.CreateTable(
                name: "MapaPrevios",
                columns: table => new
                {
                    MapaPrevioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapaPrevioBase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapaPrevios", x => x.MapaPrevioId);
                });
        }
    }
}
