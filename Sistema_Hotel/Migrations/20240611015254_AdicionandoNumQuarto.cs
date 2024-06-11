using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class AdicionandoNumQuarto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumQuarto",
                table: "Quartos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumQuarto",
                table: "Quartos");
        }
    }
}
