using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Api",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Api", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Negocio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servidor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Dominio = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servidor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDesenvolvedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDesenvolvedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 10, nullable: false),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    Senha = table.Column<string>(maxLength: 10, nullable: false),
                    Perfil = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Desenvolvedor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    TipoDesenvolvedorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desenvolvedor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desenvolvedor_TipoDesenvolvedor_TipoDesenvolvedorId",
                        column: x => x.TipoDesenvolvedorId,
                        principalTable: "TipoDesenvolvedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ambientes",
                columns: table => new
                {
                    AmbienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    DesenvolvedorId = table.Column<int>(nullable: false),
                    ServidorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.AmbienteId);
                    table.ForeignKey(
                        name: "FK_Ambientes_Desenvolvedor_DesenvolvedorId",
                        column: x => x.DesenvolvedorId,
                        principalTable: "Desenvolvedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ambientes_Servidor_ServidorId",
                        column: x => x.ServidorId,
                        principalTable: "Servidor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detalhe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(maxLength: 50, nullable: true),
                    ChamadoId = table.Column<int>(nullable: false),
                    DesenvolvedorId = table.Column<int>(nullable: false),
                    NegocioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalhe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalhe_Desenvolvedor_DesenvolvedorId",
                        column: x => x.DesenvolvedorId,
                        principalTable: "Desenvolvedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Detalhe_Negocio_NegocioId",
                        column: x => x.NegocioId,
                        principalTable: "Negocio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chamado",
                columns: table => new
                {
                    ChamadoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    AmbienteId = table.Column<int>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chamado", x => x.ChamadoId);
                    table.ForeignKey(
                        name: "FK_Chamado_Ambientes_AmbienteId",
                        column: x => x.AmbienteId,
                        principalTable: "Ambientes",
                        principalColumn: "AmbienteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_DesenvolvedorId",
                table: "Ambientes",
                column: "DesenvolvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_ServidorId",
                table: "Ambientes",
                column: "ServidorId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_AmbienteId",
                table: "Chamado",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Desenvolvedor_TipoDesenvolvedorId",
                table: "Desenvolvedor",
                column: "TipoDesenvolvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalhe_DesenvolvedorId",
                table: "Detalhe",
                column: "DesenvolvedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Detalhe_NegocioId",
                table: "Detalhe",
                column: "NegocioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Api");

            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "Detalhe");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Ambientes");

            migrationBuilder.DropTable(
                name: "Negocio");

            migrationBuilder.DropTable(
                name: "Desenvolvedor");

            migrationBuilder.DropTable(
                name: "Servidor");

            migrationBuilder.DropTable(
                name: "TipoDesenvolvedor");
        }
    }
}
