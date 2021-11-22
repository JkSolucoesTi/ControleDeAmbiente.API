using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeAmbiente.DAL.Migrations
{
    public partial class V2_DataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Ambientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 50, nullable: false),
                    Chamado = table.Column<string>(maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(maxLength: 50, nullable: false),
                    WebId = table.Column<int>(nullable: false),
                    IosId = table.Column<int>(nullable: false),
                    AndroidId = table.Column<int>(nullable: false),
                    NegocioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ambientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ambientes_Android_AndroidId",
                        column: x => x.AndroidId,
                        principalTable: "Android",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ambientes_Ios_IosId",
                        column: x => x.IosId,
                        principalTable: "Ios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ambientes_Negocio_NegocioId",
                        column: x => x.NegocioId,
                        principalTable: "Negocio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ambientes_Web_WebId",
                        column: x => x.WebId,
                        principalTable: "Web",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_AndroidId",
                table: "Ambientes",
                column: "AndroidId");

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_IosId",
                table: "Ambientes",
                column: "IosId");

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_NegocioId",
                table: "Ambientes",
                column: "NegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_Ambientes_WebId",
                table: "Ambientes",
                column: "WebId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ambientes");

            migrationBuilder.DropTable(
                name: "Api");

            migrationBuilder.DropTable(
                name: "Android");

            migrationBuilder.DropTable(
                name: "Ios");

            migrationBuilder.DropTable(
                name: "Negocio");

            migrationBuilder.DropTable(
                name: "Web");
        }
    }
}
