using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class AddAmbienteServidor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServidorId",
                table: "Desenvolvedor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedor_ServidorId",
                table: "Desenvolvedor",
                column: "ServidorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Desenvolvedor_Servidor_ServidorId",
                table: "Desenvolvedor",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Desenvolvedor_Servidor_ServidorId",
                table: "Desenvolvedor");

            migrationBuilder.DropIndex(
                name: "IX_Desenvolvedor_ServidorId",
                table: "Desenvolvedor");

            migrationBuilder.DropColumn(
                name: "ServidorId",
                table: "Desenvolvedor");
        }
    }
}
