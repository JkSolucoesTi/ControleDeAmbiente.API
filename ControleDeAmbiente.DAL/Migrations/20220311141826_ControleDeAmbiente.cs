using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class ControleDeAmbiente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ambientes",
                columns: table => new
                {
                    AmbienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.AmbienteId);
                });

            migrationBuilder.CreateTable(
                name: "Android",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Android", x => x.Id);
                });

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
                name: "Ios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ios", x => x.Id);
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
                name: "Web",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Usuario = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Web", x => x.Id);
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
                    ApiId = table.Column<int>(nullable: false),
                    WebId = table.Column<int>(nullable: false),
                    ChamadoWeb = table.Column<string>(maxLength: 50, nullable: true),
                    IosId = table.Column<int>(nullable: false),
                    ChamadoIos = table.Column<string>(maxLength: 50, nullable: true),
                    AndroidId = table.Column<int>(nullable: false),
                    ChamadoAndroid = table.Column<string>(maxLength: 50, nullable: true),
                    NegocioId = table.Column<int>(nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Chamado_Android_AndroidId",
                        column: x => x.AndroidId,
                        principalTable: "Android",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamado_Api_ApiId",
                        column: x => x.ApiId,
                        principalTable: "Api",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamado_Ios_IosId",
                        column: x => x.IosId,
                        principalTable: "Ios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamado_Negocio_NegocioId",
                        column: x => x.NegocioId,
                        principalTable: "Negocio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chamado_Web_WebId",
                        column: x => x.WebId,
                        principalTable: "Web",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_AmbienteId",
                table: "Chamado",
                column: "AmbienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_AndroidId",
                table: "Chamado",
                column: "AndroidId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_ApiId",
                table: "Chamado",
                column: "ApiId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_IosId",
                table: "Chamado",
                column: "IosId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_NegocioId",
                table: "Chamado",
                column: "NegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Chamado_WebId",
                table: "Chamado",
                column: "WebId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chamado");

            migrationBuilder.DropTable(
                name: "Ambientes");

            migrationBuilder.DropTable(
                name: "Android");

            migrationBuilder.DropTable(
                name: "Api");

            migrationBuilder.DropTable(
                name: "Ios");

            migrationBuilder.DropTable(
                name: "Negocio");

            migrationBuilder.DropTable(
                name: "Web");
        }
    }
}
