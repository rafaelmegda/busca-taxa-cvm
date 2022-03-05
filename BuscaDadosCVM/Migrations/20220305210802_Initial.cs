using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuscaDadosCVM.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Taxa",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
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
                name: "Taxa");
        }
    }
}
