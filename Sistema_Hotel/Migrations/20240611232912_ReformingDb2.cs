using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sistema_Hotel.Migrations
{
    /// <inheritdoc />
    public partial class ReformingDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AtualCPF",
                table: "Quartos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtualCPF",
                table: "Quartos");
        }
    }
}
