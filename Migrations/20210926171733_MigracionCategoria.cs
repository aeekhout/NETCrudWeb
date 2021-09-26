using Microsoft.EntityFrameworkCore.Migrations;

namespace ControlIngresoGastos.Migrations
{
    public partial class MigracionCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrecategoria = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    tipo = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
