using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetzGo.Cadastros.Infra.Migrations
{
    public partial class CriandoNovasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Endereco_EnderecoId",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_EnderecoId",
                table: "Empresa");

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("05e8dc15-fcb2-4f21-8a7f-cbc3c88fb0b2"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("4281d68c-926f-4a4d-b20e-9304046c8931"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("65e69e8a-5b39-461f-aa26-f26e067add3e"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("8787b28f-ff65-46f3-939b-4822a85d4c17"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("9cede659-10a6-40a7-abaa-dd58c07c0ff5"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("d4686aad-762e-4b45-9062-380286670334"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("dcc0c95e-699a-4ad8-a63e-332dc65d9586"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("02bb0c6d-3bfe-414f-bc2a-6530e94981ed"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("06d9f9b9-6e02-4679-8288-1d030a7b9150"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("08106577-70c8-4bf0-8cfa-8694b70b383a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("14c2cfe8-8f48-4694-b2d2-7e28940a99be"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("264c44e6-c7d4-4957-97a0-ac689e885413"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("2880e969-ac07-42a9-b29b-3c21c6ee2272"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("28fd2554-f914-4063-9412-7c11bd101063"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("3560558d-2130-4d4a-a123-011286b9663f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("37b78279-82c9-492f-80c1-7e2698f7b725"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("37dcbe71-4897-4b6b-9a58-64f1960cd7d6"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("43ee50e4-9ec8-46fd-bbf7-445e18ae7264"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("4cf2c9ef-4c65-4777-9cee-6f3b39ff7ef3"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("510d399b-7cb5-4e2a-90c1-4d42f69c7433"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("53f28433-090a-43e3-b500-5ace494f1dbf"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("56310574-8981-4b6b-a26d-9a9ddc7230dd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("615cc5c4-912c-4f3a-b9b8-b7d115198082"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("63fc4be2-ea8d-4340-b414-a28c6aa69db9"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("68bbbd91-9826-4f96-87b7-62937bc3fd13"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("7acde698-d706-45f8-a9fe-dc363ce8df38"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("a589ffac-3eb9-472e-880f-24d5ac533774"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("a9ec6f31-4c96-4d8f-8ecb-52d5b56d2423"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b0a82ce1-87b7-4dc9-acd2-981d564a3868"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b76ef529-b3ce-4347-b104-f95f7c216e0b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b90dc9dc-dd36-4ab7-a797-439a6c36654f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c10140a1-849f-4238-a01b-097cb11e1af4"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c195358b-4466-4fd0-bf29-20b32865e22f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c436053d-873c-41e2-8f62-92d15ddf3533"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c638a23d-e1d0-4617-8475-455e5aee1a3f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c6c738cc-226d-4796-81d0-fd9379abc97c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ca3d98c1-7a7f-4f1c-802e-b9253ce751b8"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d1c405ac-f716-46bf-92b3-eee4f452869b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d48da21d-1109-4812-ade3-796a461e52f5"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d641606f-42d6-40f0-bd9d-8652c8a4ea32"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d920d3c1-8aba-4566-b1e9-5fa2327e5938"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e035e694-9f81-4aaf-921d-efce24f8f611"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ea6fae01-27e4-476a-9895-6739a697307d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ec42fe77-82de-4db9-9d33-a9c8ddf36146"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ed83c3de-1b83-43d0-9b60-b977ce994956"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ef354393-3a79-4178-bfe0-90d124dbb095"));

            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Endereco",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmpresaId",
                table: "Endereco",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "EnderecoId",
                table: "Empresa",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WhatsApp = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cliente_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoPet = table.Column<string>(type: "varchar(15)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(70)", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PetCaracteristicaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_PetCaracteristica_PetCaracteristicaId",
                        column: x => x.PetCaracteristicaId,
                        principalTable: "PetCaracteristica",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DiaSemana",
                columns: new[] { "Id", "TipoDiaSemana" },
                values: new object[,]
                {
                    { new Guid("831fe066-848d-4c6b-a1d0-1e441a498544"), 0 },
                    { new Guid("13654bc3-fe85-4630-afa1-a9d850d859bf"), 1 },
                    { new Guid("b3035ced-91cf-437b-ae44-7ae743b053b8"), 2 },
                    { new Guid("fad12262-7436-46b6-a2a0-a190a14d7e4e"), 3 },
                    { new Guid("52feb789-b47f-4a60-ad45-dbb8a6210e08"), 4 },
                    { new Guid("b661b3e3-f373-48a0-9419-ba0d459a7cce"), 5 },
                    { new Guid("b481195e-bad5-4797-b1c6-74bd420fdcb9"), 6 }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("d70d6bfb-bdab-445c-9974-603e5663a971"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("2daac770-a2c6-41f6-b571-54d538fb3b0b"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("3e409e80-092d-4340-843c-e7b8cbca4f88"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("58451281-3ac0-4ef9-b4d9-25ba4f3377ed"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("5d411e23-3b94-4626-93a4-dbea939c08f3"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("bf12932f-912d-4776-8ec1-d43972fc4b3c"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("df228944-d519-464f-9f0b-446e68c06cd3"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("943cf5e7-13fb-4476-9b2a-00b01c30cb86"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("06de729a-af51-40d5-92f0-f0d210802ca2"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("737a4705-08b5-405f-9ce9-3b40db0c6735"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("69506058-3243-4ab3-a6c1-662b38e1b88d"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("a644c97f-5019-4c3a-a4a8-5ef379bc2f9e"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("0aa797f7-9234-4543-ab0f-5f32abf9c3a8"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("9bc46552-2356-47a4-ae33-6bc55fdf82dd"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("ca14fa63-7e2e-4d15-92e0-3352a98a70e3"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("5d4124db-b45c-43c5-836d-6907b733916d"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("99fffab6-9523-4049-a8d8-7f12f2756ba1"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("196ea67d-3cf7-4ac4-ab45-6fc212253c6f"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("9422215b-dd6c-4fe8-a5ed-5e3dc915fda2"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("9995db60-1248-4152-90c1-3cd70fa00f6b"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("bf87fb8e-4f65-4ccf-bf94-7052d1edc6ac"), new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("814fb496-5fc5-4a48-a85d-691ec125c186"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("b0c59363-9110-44cf-9636-313c701a7b27"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("2748f2dc-6e7d-4122-b48e-5c9d971b95e2"), new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("f4c17a25-092f-493c-a0d6-1c19433f62d1"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("0d18b2cd-37e0-4501-b605-1236f8043aea"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("746d12d0-811c-4d07-a8e4-f3185e12a22b"), new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("764851f6-0aee-48ab-ae53-8ae413de7746"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("35fdb5c6-d5a9-4846-8794-b474e981074f"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("a06125c5-f073-4952-9460-c1d9cc8aeb6c"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c19061a5-238c-4ec0-bf41-72efcc13376a"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("ca8690af-93b2-432e-9888-b6a63f860d6b"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c4a94970-b752-4e8e-95da-e0d2c759893c"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("e3e88ee7-113c-4844-bec8-9c86ef4f7673"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("149e5a1b-e714-457a-aaaa-8fb5a97d6336"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("396976a8-2087-48a7-a07d-b3570fb5ab6a"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("a6dc1ff8-1ce8-460b-b1e0-17f58ee2065e"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("8245fde7-3792-4c88-89c7-f5c112772a08"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("15697276-54e3-47d7-af43-450f299f2b24"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EnderecoId",
                table: "Empresa",
                column: "EnderecoId",
                unique: true,
                filter: "[EnderecoId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EmpresaId",
                table: "Cliente",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_ClienteId",
                table: "Pet",
                column: "ClienteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetCaracteristicaId",
                table: "Pet",
                column: "PetCaracteristicaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Endereco_EnderecoId",
                table: "Empresa",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_Endereco_EnderecoId",
                table: "Empresa");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_EnderecoId",
                table: "Empresa");

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("13654bc3-fe85-4630-afa1-a9d850d859bf"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("52feb789-b47f-4a60-ad45-dbb8a6210e08"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("831fe066-848d-4c6b-a1d0-1e441a498544"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("b3035ced-91cf-437b-ae44-7ae743b053b8"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("b481195e-bad5-4797-b1c6-74bd420fdcb9"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("b661b3e3-f373-48a0-9419-ba0d459a7cce"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("fad12262-7436-46b6-a2a0-a190a14d7e4e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("06de729a-af51-40d5-92f0-f0d210802ca2"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("0aa797f7-9234-4543-ab0f-5f32abf9c3a8"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("0d18b2cd-37e0-4501-b605-1236f8043aea"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("149e5a1b-e714-457a-aaaa-8fb5a97d6336"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("15697276-54e3-47d7-af43-450f299f2b24"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("196ea67d-3cf7-4ac4-ab45-6fc212253c6f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("2748f2dc-6e7d-4122-b48e-5c9d971b95e2"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("2daac770-a2c6-41f6-b571-54d538fb3b0b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("35fdb5c6-d5a9-4846-8794-b474e981074f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("396976a8-2087-48a7-a07d-b3570fb5ab6a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("3e409e80-092d-4340-843c-e7b8cbca4f88"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("58451281-3ac0-4ef9-b4d9-25ba4f3377ed"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5d411e23-3b94-4626-93a4-dbea939c08f3"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5d4124db-b45c-43c5-836d-6907b733916d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("69506058-3243-4ab3-a6c1-662b38e1b88d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("737a4705-08b5-405f-9ce9-3b40db0c6735"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("746d12d0-811c-4d07-a8e4-f3185e12a22b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("764851f6-0aee-48ab-ae53-8ae413de7746"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("814fb496-5fc5-4a48-a85d-691ec125c186"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("8245fde7-3792-4c88-89c7-f5c112772a08"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9422215b-dd6c-4fe8-a5ed-5e3dc915fda2"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("943cf5e7-13fb-4476-9b2a-00b01c30cb86"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9995db60-1248-4152-90c1-3cd70fa00f6b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("99fffab6-9523-4049-a8d8-7f12f2756ba1"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9bc46552-2356-47a4-ae33-6bc55fdf82dd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("a06125c5-f073-4952-9460-c1d9cc8aeb6c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("a644c97f-5019-4c3a-a4a8-5ef379bc2f9e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("a6dc1ff8-1ce8-460b-b1e0-17f58ee2065e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b0c59363-9110-44cf-9636-313c701a7b27"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("bf12932f-912d-4776-8ec1-d43972fc4b3c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("bf87fb8e-4f65-4ccf-bf94-7052d1edc6ac"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c19061a5-238c-4ec0-bf41-72efcc13376a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c4a94970-b752-4e8e-95da-e0d2c759893c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ca14fa63-7e2e-4d15-92e0-3352a98a70e3"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ca8690af-93b2-432e-9888-b6a63f860d6b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d70d6bfb-bdab-445c-9974-603e5663a971"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("df228944-d519-464f-9f0b-446e68c06cd3"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e3e88ee7-113c-4844-bec8-9c86ef4f7673"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f4c17a25-092f-493c-a0d6-1c19433f62d1"));

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Endereco");

            migrationBuilder.AlterColumn<Guid>(
                name: "EnderecoId",
                table: "Empresa",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("56310574-8981-4b6b-a26d-9a9ddc7230dd"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("ea6fae01-27e4-476a-9895-6739a697307d"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("a9ec6f31-4c96-4d8f-8ecb-52d5b56d2423"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("b0a82ce1-87b7-4dc9-acd2-981d564a3868"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("b76ef529-b3ce-4347-b104-f95f7c216e0b"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("2880e969-ac07-42a9-b29b-3c21c6ee2272"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("53f28433-090a-43e3-b500-5ace494f1dbf"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("264c44e6-c7d4-4957-97a0-ac689e885413"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("d1c405ac-f716-46bf-92b3-eee4f452869b"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("28fd2554-f914-4063-9412-7c11bd101063"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("37dcbe71-4897-4b6b-9a58-64f1960cd7d6"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("06d9f9b9-6e02-4679-8288-1d030a7b9150"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("c10140a1-849f-4238-a01b-097cb11e1af4"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("37b78279-82c9-492f-80c1-7e2698f7b725"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("3560558d-2130-4d4a-a123-011286b9663f"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("7acde698-d706-45f8-a9fe-dc363ce8df38"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("14c2cfe8-8f48-4694-b2d2-7e28940a99be"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("d641606f-42d6-40f0-bd9d-8652c8a4ea32"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("c195358b-4466-4fd0-bf29-20b32865e22f"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("ef354393-3a79-4178-bfe0-90d124dbb095"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("e035e694-9f81-4aaf-921d-efce24f8f611"), new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("ed83c3de-1b83-43d0-9b60-b977ce994956"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("63fc4be2-ea8d-4340-b414-a28c6aa69db9"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("c6c738cc-226d-4796-81d0-fd9379abc97c"), new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("4cf2c9ef-4c65-4777-9cee-6f3b39ff7ef3"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("68bbbd91-9826-4f96-87b7-62937bc3fd13"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("a589ffac-3eb9-472e-880f-24d5ac533774"), new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("510d399b-7cb5-4e2a-90c1-4d42f69c7433"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("c436053d-873c-41e2-8f62-92d15ddf3533"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("02bb0c6d-3bfe-414f-bc2a-6530e94981ed"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("ca3d98c1-7a7f-4f1c-802e-b9253ce751b8"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("ec42fe77-82de-4db9-9d33-a9c8ddf36146"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c638a23d-e1d0-4617-8475-455e5aee1a3f"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("b90dc9dc-dd36-4ab7-a797-439a6c36654f"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("d920d3c1-8aba-4566-b1e9-5fa2327e5938"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("615cc5c4-912c-4f3a-b9b8-b7d115198082"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("43ee50e4-9ec8-46fd-bbf7-445e18ae7264"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("d48da21d-1109-4812-ade3-796a461e52f5"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("08106577-70c8-4bf0-8cfa-8694b70b383a"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_EnderecoId",
                table: "Empresa",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_Endereco_EnderecoId",
                table: "Empresa",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
