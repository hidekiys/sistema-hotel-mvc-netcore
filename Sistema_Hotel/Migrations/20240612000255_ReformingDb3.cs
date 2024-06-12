using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class ReformingDb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AtualNome",
                table: "Quartos",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtualNome",
                table: "Quartos");
        }
    }
}
