using Microsoft.EntityFrameworkCore.Migrations;

namespace GestaoTarefasIPG.Migrations
{
    public partial class fixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Gabinete",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FuncionarioId",
                table: "Professor",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "Professor");

            migrationBuilder.AlterColumn<int>(
                name: "Gabinete",
                table: "Professor",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
