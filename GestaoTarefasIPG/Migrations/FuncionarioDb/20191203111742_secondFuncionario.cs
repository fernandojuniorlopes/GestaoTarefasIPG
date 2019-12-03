using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoTarefasIPG.Migrations.FuncionarioDb
{
    public partial class secondFuncionario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroTelemovel",
                table: "Funcionario");

            migrationBuilder.AddColumn<string>(
                name: "Contacto",
                table: "Funcionario",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumeroFuncionario",
                table: "Funcionario",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contacto",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "NumeroFuncionario",
                table: "Funcionario");

            migrationBuilder.AddColumn<string>(
                name: "NumeroTelemovel",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
