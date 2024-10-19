using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.Exemplo6.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.RenameTable(
                name: "LivroGenero",
                newName: "LivroGenero",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Livro",
                newName: "Livro",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Genero",
                newName: "Genero",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Endereco",
                newSchema: "public");

            migrationBuilder.RenameTable(
                name: "Autor",
                newName: "Autor",
                newSchema: "public");

            migrationBuilder.AddColumn<int>(
                name: "Estoque",
                schema: "public",
                table: "Livro",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estoque",
                schema: "public",
                table: "Livro");

            migrationBuilder.RenameTable(
                name: "LivroGenero",
                schema: "public",
                newName: "LivroGenero");

            migrationBuilder.RenameTable(
                name: "Livro",
                schema: "public",
                newName: "Livro");

            migrationBuilder.RenameTable(
                name: "Genero",
                schema: "public",
                newName: "Genero");

            migrationBuilder.RenameTable(
                name: "Endereco",
                schema: "public",
                newName: "Endereco");

            migrationBuilder.RenameTable(
                name: "Autor",
                schema: "public",
                newName: "Autor");
        }
    }
}
