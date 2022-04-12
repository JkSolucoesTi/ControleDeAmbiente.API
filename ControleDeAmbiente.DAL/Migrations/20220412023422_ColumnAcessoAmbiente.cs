using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class ColumnAcessoAmbiente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Acesso",
                table: "Ambientes",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acesso",
                table: "Ambientes");
        }
    }
}
