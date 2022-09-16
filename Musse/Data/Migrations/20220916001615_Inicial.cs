using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Musse.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mapas",
                columns: table => new
                {
                    MapaActualId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MapaBase64 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Actual = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mapas", x => x.MapaActualId);
                });

            migrationBuilder.CreateTable(
                name: "Recorridos",
                columns: table => new
                {
                    RecorridoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recorridos", x => x.RecorridoId);
                });

            migrationBuilder.CreateTable(
                name: "Stand",
                columns: table => new
                {
                    StandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explicacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false),
                    RecorridoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stand", x => x.StandId);
                    table.ForeignKey(
                        name: "FK_Stand_Recorridos_RecorridoId",
                        column: x => x.RecorridoId,
                        principalTable: "Recorridos",
                        principalColumn: "RecorridoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stand_RecorridoId",
                table: "Stand",
                column: "RecorridoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mapas");

            migrationBuilder.DropTable(
                name: "Stand");

            migrationBuilder.DropTable(
                name: "Recorridos");
        }
    }
}
