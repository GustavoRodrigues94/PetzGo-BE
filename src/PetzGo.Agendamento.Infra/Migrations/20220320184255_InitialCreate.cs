using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetzGo.Agendamento.Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgendaCliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaCliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaPet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(150)", nullable: false),
                    PetCaracteristica = table.Column<string>(type: "varchar(200)", nullable: false),
                    TipoPet = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaPet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AgendaServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AgendaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(300)", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    TempoEmMinutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgendaServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    AgendamentoStatus = table.Column<int>(type: "int", nullable: false),
                    AgendaClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgendaPetId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AgendaServicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataHoraTermino = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_AgendaCliente_AgendaClienteId",
                        column: x => x.AgendaClienteId,
                        principalTable: "AgendaCliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_AgendaPet_AgendaPetId",
                        column: x => x.AgendaPetId,
                        principalTable: "AgendaPet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Agenda_AgendaServico_AgendaServicoId",
                        column: x => x.AgendaServicoId,
                        principalTable: "AgendaServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_AgendaClienteId",
                table: "Agenda",
                column: "AgendaClienteId",
                unique: true,
                filter: "[AgendaClienteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_AgendaPetId",
                table: "Agenda",
                column: "AgendaPetId",
                unique: true,
                filter: "[AgendaPetId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_AgendaServicoId",
                table: "Agenda",
                column: "AgendaServicoId",
                unique: true,
                filter: "[AgendaServicoId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "AgendaCliente");

            migrationBuilder.DropTable(
                name: "AgendaPet");

            migrationBuilder.DropTable(
                name: "AgendaServico");
        }
    }
}
