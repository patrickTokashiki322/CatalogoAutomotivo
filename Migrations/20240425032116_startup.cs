using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatalogoAutomotivo.Migrations
{
    /// <inheritdoc />
    public partial class startup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAlimentacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aspiracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoAspiracao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aspiracao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCategoria = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Combustivel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCombustivel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Combustivel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RazaoSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataFundacao = table.Column<int>(type: "int", nullable: false),
                    Fundador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sede = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tracao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoTracao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tracao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoTransmissao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FabricanteId = table.Column<int>(type: "int", nullable: false),
                    AnoFabricacao = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Motor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlimentacaoId = table.Column<int>(type: "int", nullable: false),
                    AspiracaoId = table.Column<int>(type: "int", nullable: false),
                    Potencia = table.Column<int>(type: "int", nullable: false),
                    RotacaoMaxima = table.Column<int>(type: "int", nullable: false),
                    PrecoTabela = table.Column<int>(type: "int", nullable: false),
                    CombustivelId = table.Column<int>(type: "int", nullable: false),
                    CapacidadeCombustivel = table.Column<int>(type: "int", nullable: false),
                    QuantidadePortas = table.Column<int>(type: "int", nullable: false),
                    QuantidadeLugares = table.Column<int>(type: "int", nullable: false),
                    TracaoId = table.Column<int>(type: "int", nullable: false),
                    TransmissaoId = table.Column<int>(type: "int", nullable: false),
                    PneusDianteiros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PneusTraseiros = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Peso = table.Column<int>(type: "int", nullable: false),
                    VelocidadeMaxima = table.Column<int>(type: "int", nullable: false),
                    ConsumoUrbano = table.Column<int>(type: "int", nullable: false),
                    ConsumoRodoviario = table.Column<int>(type: "int", nullable: false),
                    AutonomiaUrbana = table.Column<int>(type: "int", nullable: false),
                    AutonomiaRodoviaria = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreioDianteiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreioTraseiro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OleoMotor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carro_Alimentacao_AlimentacaoId",
                        column: x => x.AlimentacaoId,
                        principalTable: "Alimentacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Aspiracao_AspiracaoId",
                        column: x => x.AspiracaoId,
                        principalTable: "Aspiracao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Combustivel_CombustivelId",
                        column: x => x.CombustivelId,
                        principalTable: "Combustivel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Fabricante_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "Fabricante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Tracao_TracaoId",
                        column: x => x.TracaoId,
                        principalTable: "Tracao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Carro_Transmissao_TransmissaoId",
                        column: x => x.TransmissaoId,
                        principalTable: "Transmissao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carro_AlimentacaoId",
                table: "Carro",
                column: "AlimentacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_AspiracaoId",
                table: "Carro",
                column: "AspiracaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_CategoriaId",
                table: "Carro",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_CombustivelId",
                table: "Carro",
                column: "CombustivelId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_FabricanteId",
                table: "Carro",
                column: "FabricanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_TracaoId",
                table: "Carro",
                column: "TracaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carro_TransmissaoId",
                table: "Carro",
                column: "TransmissaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carro");

            migrationBuilder.DropTable(
                name: "Alimentacao");

            migrationBuilder.DropTable(
                name: "Aspiracao");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Combustivel");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropTable(
                name: "Tracao");

            migrationBuilder.DropTable(
                name: "Transmissao");
        }
    }
}
