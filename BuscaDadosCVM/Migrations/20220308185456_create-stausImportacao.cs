using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuscaDadosCVM.Migrations
{
    public partial class createstausImportacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataImportacao",
                table: "Taxa",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ImportacaoTaxaId1",
                table: "Taxa",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ImportacaoTaxa",
                columns: table => new
                {
                    ImportacaoTaxaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataImportacao = table.Column<DateTime>(nullable: false),
                    StatusImportacao = table.Column<string>(nullable: true),
                    ArquivoImportado = table.Column<string>(nullable: true),
                    DataDivulgacaoArquivo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportacaoTaxa", x => x.ImportacaoTaxaId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Taxa_ImportacaoTaxaId1",
                table: "Taxa",
                column: "ImportacaoTaxaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Taxa_ImportacaoTaxa_ImportacaoTaxaId1",
                table: "Taxa",
                column: "ImportacaoTaxaId1",
                principalTable: "ImportacaoTaxa",
                principalColumn: "ImportacaoTaxaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Taxa_ImportacaoTaxa_ImportacaoTaxaId1",
                table: "Taxa");

            migrationBuilder.DropTable(
                name: "ImportacaoTaxa");

            migrationBuilder.DropIndex(
                name: "IX_Taxa_ImportacaoTaxaId1",
                table: "Taxa");

            migrationBuilder.DropColumn(
                name: "DataImportacao",
                table: "Taxa");

            migrationBuilder.DropColumn(
                name: "ImportacaoTaxaId1",
                table: "Taxa");
        }
    }
}
