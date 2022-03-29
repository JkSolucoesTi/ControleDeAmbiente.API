using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class AddRelationalAmbiente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServidorId",
                table: "Ambientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_ServidorId",
                table: "Ambientes",
                column: "ServidorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ambientes_Servidor_ServidorId",
                table: "Ambientes",
                column: "ServidorId",
                principalTable: "Servidor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ambientes_Servidor_ServidorId",
                table: "Ambientes");

            migrationBuilder.DropIndex(
                name: "IX_Ambientes_ServidorId",
                table: "Ambientes");

            migrationBuilder.DropColumn(
                name: "ServidorId",
                table: "Ambientes");
        }
    }
}
