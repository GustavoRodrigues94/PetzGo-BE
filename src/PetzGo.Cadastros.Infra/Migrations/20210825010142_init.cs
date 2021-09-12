using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetzGo.Cadastros.Infra.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaSemana",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoDiaSemana = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaSemana", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    Logradouro = table.Column<string>(type: "varchar(40)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(8)", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "varchar(40)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(40)", nullable: false),
                    Estado = table.Column<string>(type: "varchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetCaracteristica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPetCaracteristica = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCaracteristica", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(60)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoNegocio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeTipoNegocio = table.Column<string>(type: "varchar(150)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNegocio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicoPetCaracteristica",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServicoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetCaracteristicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicoPetCaracteristica", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ServicoPetCaracteristica_PetCaracteristica_PetCaracteristicaId",
                        column: x => x.PetCaracteristicaId,
                        principalTable: "PetCaracteristica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicoPetCaracteristica_Servico_ServicoId",
                        column: x => x.ServicoId,
                        principalTable: "Servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoNegocioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomeFantasia = table.Column<string>(type: "varchar(200)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(14)", nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(200)", nullable: false),
                    WhatsApp = table.Column<string>(type: "varchar(15)", nullable: false),
                    RotuloLink = table.Column<string>(type: "varchar(30)", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresa_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresa_TipoNegocio_TipoNegocioId",
                        column: x => x.TipoNegocioId,
                        principalTable: "TipoNegocio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaHorario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaSemanaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoraInicio = table.Column<string>(type: "varchar(5)", nullable: false),
                    HoraFim = table.Column<string>(type: "varchar(5)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaHorario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaHorario_DiaSemana_DiaSemanaId",
                        column: x => x.DiaSemanaId,
                        principalTable: "DiaSemana",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaHorario_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmpresaServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPet = table.Column<string>(type: "varchar(30)", nullable: false),
                    ServicoPetCaracteristicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    TempoEmMinutos = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresaServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmpresaServico_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpresaServico_ServicoPetCaracteristica_ServicoPetCaracteristicaId",
                        column: x => x.ServicoPetCaracteristicaId,
                        principalTable: "ServicoPetCaracteristica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiaSemana",
                columns: new[] { "Id", "TipoDiaSemana" },
                values: new object[,]
                {
                    { new Guid("05e8dc15-fcb2-4f21-8a7f-cbc3c88fb0b2"), 0 },
                    { new Guid("65e69e8a-5b39-461f-aa26-f26e067add3e"), 1 },
                    { new Guid("dcc0c95e-699a-4ad8-a63e-332dc65d9586"), 2 },
                    { new Guid("4281d68c-926f-4a4d-b20e-9304046c8931"), 3 },
                    { new Guid("8787b28f-ff65-46f3-939b-4822a85d4c17"), 4 },
                    { new Guid("d4686aad-762e-4b45-9062-380286670334"), 5 },
                    { new Guid("9cede659-10a6-40a7-abaa-dd58c07c0ff5"), 6 }
                });

            migrationBuilder.InsertData(
                table: "PetCaracteristica",
                columns: new[] { "Id", "TipoPetCaracteristica" },
                values: new object[,]
                {
                    { new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), 8 },
                    { new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), 7 },
                    { new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), 6 },
                    { new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), 4 },
                    { new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), 5 },
                    { new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), 2 },
                    { new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), 1 },
                    { new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), 0 },
                    { new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Servico",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"), "Banho" },
                    { new Guid("acfae699-460a-43b3-8b3d-86928fe61388"), "Banho & Tosa com máquina" },
                    { new Guid("eb665260-cac8-4869-a03e-35770f8bf119"), "Banho & Tosa com tesoura" },
                    { new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"), "Tosa com máquina" },
                    { new Guid("79563a4a-5d26-4440-9afb-314453257ee5"), "Tosa com tesoura" },
                    { new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"), "Tosa higiênica" }
                });

            migrationBuilder.InsertData(
                table: "TipoNegocio",
                columns: new[] { "Id", "NomeTipoNegocio" },
                values: new object[,]
                {
                    { new Guid("ce280415-4d18-4637-9244-7b76b69274a4"), "ClinicaVeterinaria" },
                    { new Guid("5ed433bb-5687-4b00-9d1b-84717101ac48"), "PetShop" },
                    { new Guid("ef4565e5-b230-4182-89f1-0ebfc1e26563"), "PetShopClinicaVeterinaria" }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("e035e694-9f81-4aaf-921d-efce24f8f611"), new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("56310574-8981-4b6b-a26d-9a9ddc7230dd"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("ea6fae01-27e4-476a-9895-6739a697307d"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("a9ec6f31-4c96-4d8f-8ecb-52d5b56d2423"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("b0a82ce1-87b7-4dc9-acd2-981d564a3868"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("b76ef529-b3ce-4347-b104-f95f7c216e0b"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("2880e969-ac07-42a9-b29b-3c21c6ee2272"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("53f28433-090a-43e3-b500-5ace494f1dbf"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("37dcbe71-4897-4b6b-9a58-64f1960cd7d6"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("264c44e6-c7d4-4957-97a0-ac689e885413"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("28fd2554-f914-4063-9412-7c11bd101063"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("d1c405ac-f716-46bf-92b3-eee4f452869b"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("06d9f9b9-6e02-4679-8288-1d030a7b9150"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("c10140a1-849f-4238-a01b-097cb11e1af4"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("37b78279-82c9-492f-80c1-7e2698f7b725"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("3560558d-2130-4d4a-a123-011286b9663f"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("7acde698-d706-45f8-a9fe-dc363ce8df38"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("14c2cfe8-8f48-4694-b2d2-7e28940a99be"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("615cc5c4-912c-4f3a-b9b8-b7d115198082"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("d641606f-42d6-40f0-bd9d-8652c8a4ea32"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("ef354393-3a79-4178-bfe0-90d124dbb095"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("ed83c3de-1b83-43d0-9b60-b977ce994956"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("63fc4be2-ea8d-4340-b414-a28c6aa69db9"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("c6c738cc-226d-4796-81d0-fd9379abc97c"), new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("4cf2c9ef-4c65-4777-9cee-6f3b39ff7ef3"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("68bbbd91-9826-4f96-87b7-62937bc3fd13"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("a589ffac-3eb9-472e-880f-24d5ac533774"), new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("510d399b-7cb5-4e2a-90c1-4d42f69c7433"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("d48da21d-1109-4812-ade3-796a461e52f5"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("c436053d-873c-41e2-8f62-92d15ddf3533"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("ca3d98c1-7a7f-4f1c-802e-b9253ce751b8"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("ec42fe77-82de-4db9-9d33-a9c8ddf36146"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c638a23d-e1d0-4617-8475-455e5aee1a3f"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("b90dc9dc-dd36-4ab7-a797-439a6c36654f"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("d920d3c1-8aba-4566-b1e9-5fa2327e5938"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c195358b-4466-4fd0-bf29-20b32865e22f"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("43ee50e4-9ec8-46fd-bbf7-445e18ae7264"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("02bb0c6d-3bfe-414f-bc2a-6530e94981ed"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("08106577-70c8-4bf0-8cfa-8694b70b383a"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EnderecoId",
                table: "Empresa",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_TipoNegocioId",
                table: "Empresa",
                column: "TipoNegocioId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaHorario_DiaSemanaId",
                table: "EmpresaHorario",
                column: "DiaSemanaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaHorario_EmpresaId",
                table: "EmpresaHorario",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaServico_EmpresaId",
                table: "EmpresaServico",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpresaServico_ServicoPetCaracteristicaId",
                table: "EmpresaServico",
                column: "ServicoPetCaracteristicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoPetCaracteristica_PetCaracteristicaId",
                table: "ServicoPetCaracteristica",
                column: "PetCaracteristicaId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoPetCaracteristica_ServicoId",
                table: "ServicoPetCaracteristica",
                column: "ServicoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpresaHorario");

            migrationBuilder.DropTable(
                name: "EmpresaServico");

            migrationBuilder.DropTable(
                name: "DiaSemana");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ServicoPetCaracteristica");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "TipoNegocio");

            migrationBuilder.DropTable(
                name: "PetCaracteristica");

            migrationBuilder.DropTable(
                name: "Servico");
        }
    }
}
