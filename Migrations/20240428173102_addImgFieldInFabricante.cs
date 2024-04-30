using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAutomotivo.Migrations
{
    /// <inheritdoc />
    public partial class addImgFieldInFabricante : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Fabricante",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Fabricante");
        }
    }
}
