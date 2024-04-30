using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAutomotivo.Migrations
{
    /// <inheritdoc />
    public partial class changeDateTimeToStringInFabricanteCs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataFundacao",
                table: "Fabricante",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DataFundacao",
                table: "Fabricante",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
