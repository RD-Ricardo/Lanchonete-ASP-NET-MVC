using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanchonete_ASP_NET_MVC.Migrations
{
    public partial class pedidoDetalhe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SobreNome",
                table: "Pedidos",
                newName: "Sobrenome");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Pedidos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sobrenome",
                table: "Pedidos",
                newName: "SobreNome");

            migrationBuilder.AlterColumn<int>(
                name: "Nome",
                table: "Pedidos",
                type: "int",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
