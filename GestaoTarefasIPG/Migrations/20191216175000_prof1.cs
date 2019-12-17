using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoTarefasIPG.Migrations
{
    public partial class prof1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Professor");

            migrationBuilder.AlterColumn<string>(
                name: "Gabinete",
                table: "Professor",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "NumFuncionario",
                table: "Professor",
                maxLength: 9,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumFuncionario",
                table: "Professor");

            migrationBuilder.AlterColumn<string>(
                name: "Gabinete",
                table: "Professor",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 3);

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioId",
                table: "Professor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
