using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class Requisicoespordesenvolvedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChamadoAndroid",
                table: "Chamado",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChamadoIos",
                table: "Chamado",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ChamadoWeb",
                table: "Chamado",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChamadoAndroid",
                table: "Chamado");

            migrationBuilder.DropColumn(
                name: "ChamadoIos",
                table: "Chamado");

            migrationBuilder.DropColumn(
                name: "ChamadoWeb",
                table: "Chamado");
        }
    }
}
