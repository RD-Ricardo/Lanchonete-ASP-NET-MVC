using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete_ASP_NET_MVC.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO categorias (CategoriaNome, Descricao) VALUES ('Normal', 'Lanches feito com ingredientes normais')");
            migrationBuilder.Sql("INSERT INTO categorias (CategoriaNome, Descricao) VALUES ('Natural', 'Lanches feito com ingredientes naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM categorias");
        }
    }
}
