using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuscaDadosCVM.Migrations
{
    public partial class createdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mes",
                columns: table => new
                {
                    DataAnoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mes = table.Column<int>(nullable: false),
                    Ano = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mes", x => x.DataAnoId);
                });

            migrationBuilder.CreateTable(
                name: "Taxa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AnoMesDivulgacao = table.Column<int>(nullable: false),
                    CNPJ_FUNDO = table.Column<string>(nullable: true),
                    DT_COMPTC = table.Column<DateTime>(nullable: false),
                    VL_TOTAL = table.Column<decimal>(nullable: false),
                    VL_QUOTA = table.Column<decimal>(nullable: false),
                    VL_PATRIM_LIQ = table.Column<decimal>(nullable: false),
                    CAPTC_DIA = table.Column<decimal>(nullable: false),
                    RESG_DIA = table.Column<decimal>(nullable: false),
                    NR_COTST = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Taxa", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mes");

            migrationBuilder.DropTable(
                name: "Taxa");
        }
    }
}
