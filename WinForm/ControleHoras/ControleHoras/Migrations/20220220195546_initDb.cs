using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleHoras.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoraUm = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraDois = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraTres = table.Column<TimeSpan>(type: "time", nullable: false),
                    HoraQuatro = table.Column<TimeSpan>(type: "time", nullable: false),
                    Intervalo = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalHoras = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dias");
        }
    }
}
