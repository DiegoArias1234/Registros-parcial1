using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial.API.Migrations
{
    /// <inheritdoc />
    public partial class IniDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entrances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaDeUso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FueUsada = table.Column<bool>(type: "bit", nullable: false),
                    Porteria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrances", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entrances_Id",
                table: "Entrances",
                column: "Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entrances");
        }
    }
}
