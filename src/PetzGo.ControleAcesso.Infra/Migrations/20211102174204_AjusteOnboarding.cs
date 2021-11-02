using Microsoft.EntityFrameworkCore.Migrations;

namespace PetzGo.ControleAcesso.Infra.Migrations
{
    public partial class AjusteOnboarding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaRotuloLink",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "EmpresaNomeFantasia",
                table: "Usuario",
                type: "varchar(200)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpresaNomeFantasia",
                table: "Usuario");

            migrationBuilder.AddColumn<string>(
                name: "EmpresaRotuloLink",
                table: "Usuario",
                type: "varchar(30)",
                nullable: false,
                defaultValue: "");
        }
    }
}
