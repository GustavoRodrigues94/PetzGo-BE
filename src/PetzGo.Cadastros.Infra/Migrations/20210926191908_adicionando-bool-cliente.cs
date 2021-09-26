using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetzGo.Cadastros.Infra.Migrations
{
    public partial class adicionandoboolcliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente");

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("3199a724-bd9d-4e7b-9b35-03167d329bf1"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("3c4af785-e90b-4df6-bc5d-174981f793ca"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("6515aa99-9bad-4a8c-910e-82ff15f6ce8d"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("84ae9ba2-77cc-43be-9166-6200a755933b"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("b9f7a41d-f679-407c-bf30-4c8ae81d34f2"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("f3c507e0-4eca-439f-9d38-99a9da52940e"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("f4a5f261-0223-46a2-9216-504473934c90"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("01162be9-db85-43d4-b63a-948eb9d8fad3"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("0f61053d-826f-4a18-94df-54b9785bc2c8"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("1ba8e954-a400-4e24-a9e6-c7059499b950"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("34caf77d-62fe-4b9c-993f-c0a51b744101"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("370dac50-b164-47e8-85a2-ec79f0a47b3f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("473240cf-47c9-42b6-8e9b-9dd0817316d4"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("4b05e1a1-c9a9-46ad-b72e-3589ffc38fa5"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("4f38a386-3749-420f-8156-e55ed03cea5a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("539fef25-8b7a-4817-a8ae-7c9efff7ed4e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5433831b-0b00-4f48-946a-19d20d4194d9"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5497efe1-d5d1-41bb-94ff-67d400ef86db"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5555edcc-06a2-4341-9973-9cf74394b919"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("66fd27ec-82fe-45cb-a618-0dee9849f83e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("6a876bf3-1770-4b42-a233-5be0c088ef9c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("6ac5316d-65d6-4ece-9d8c-597747e8618f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("6b73d110-6011-43cf-950c-984a274ce387"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("71545d07-0c64-4fbe-9000-05f52b24188d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("7deb0eaf-35d0-48b7-a596-5a1f9908364e"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("81106e6f-5abe-488b-a368-d0ee214983d2"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("8d9c02e7-b44c-4bc4-8612-da00a5ef3b12"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("913285a5-574b-4a30-9c5e-7453263d66be"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9227cdf8-c12d-4d7f-958b-6804c680d0ad"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("92a054a5-a70d-4a69-b8b5-3aef0131d714"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("96806485-7aed-444e-ac52-3fa8a0b5556d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9b528339-7f16-4d64-aa44-510300d58f86"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b16c44d9-7d4d-4f92-b8e4-1fd80e7d4106"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b6ce42f3-fc69-415a-8d2e-235c730677e0"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c168cc6b-4a68-4139-992e-83cad2a42bff"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c50f025c-2b5b-46ba-9b18-82656e905a68"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c60432ed-2940-414b-a785-97f8194e177a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c6837b18-4c64-499c-a1c5-7b12d4fe25bd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d0ece339-2c83-4e4e-a44f-e587a242234a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e2460f32-7f0a-455b-ac50-d132db2ca113"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e59bfdfd-9639-4b94-bdd1-3a9df93126f8"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f2c08d81-3861-4a3f-bf00-34d96b6f0f69"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f5cec5f1-c5ff-4b6a-a34c-571b664c76fb"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f6bb8b6c-9063-42a4-96a6-25e975da08e0"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f8b6d5d4-45d4-43a6-a9b4-a1d477fd413a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("fe9a4164-740a-41cb-8e67-3a3bc8a1d9fd"));

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpresaId",
                table: "Cliente",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Cliente",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "DiaSemana",
                columns: new[] { "Id", "TipoDiaSemana" },
                values: new object[,]
                {
                    { new Guid("f921c12e-2f07-4fed-b285-9198d6510ce4"), 0 },
                    { new Guid("899c5cfd-923a-4267-8af5-f6262f8e7393"), 1 },
                    { new Guid("18091b7f-1550-439e-9ec2-86a261709ff0"), 2 },
                    { new Guid("41cd00c0-f662-47ee-b104-b8773eabcf64"), 3 },
                    { new Guid("c554c92c-80d4-44fb-b4c8-3526427bd59e"), 4 },
                    { new Guid("d688615d-755c-4984-8ed1-46107cd9d923"), 5 },
                    { new Guid("67ae7ce6-3ca5-47ea-9f31-d8a597664bc2"), 6 }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("712c188f-fc3c-47fb-9124-50d6c081baa6"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("3a5c366a-e712-4cec-8478-24bbde85e908"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("c5471cce-82c3-4160-b638-62093d3dbf5f"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("05b89539-4324-4313-b3ad-9460f47ade3b"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("61c65380-6107-4c84-b17b-07b506bd8daa"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("1e4332cd-8e12-42a5-9a0e-2ccee3386a0c"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("5a142252-66e2-47b4-8b25-1aba5c2685c1"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("f2386bd8-0d1e-441a-bde8-bb6b8ffe54c2"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("e53fa2cc-3e55-4eb6-aa81-1c32d92d60f8"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("2ec3c0ac-570a-4966-9fd7-9efd846ff29b"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("ce7567a5-81b0-472a-a417-6148da419e05"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("71eed2b5-954b-472f-98c0-f5fb1c7a8c5d"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("613ddd8e-7cdb-4bf5-ba09-fc1ac732acef"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("67d8f191-a41b-451d-b44d-2febf9221c58"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("33feb591-f482-4644-a80b-fb980e7fc715"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("de57e81f-77d1-4ce9-9f59-e653deb20831"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("8b26c965-6b2a-4364-9141-bcf98ac435c6"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("8d6ab660-008a-4b27-9252-2b2cbb036664"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("9b98989e-205e-4f9b-8228-603d3e5efee0"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("fff372e2-1d77-4c7a-a408-8c25ce6b81b4"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("af27a61b-6749-4fff-8ebb-5d2900bd2897"), new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("12345565-6e51-4a08-8798-bac84266dd5f"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("fca87f12-6e45-4cbc-8cfc-bfd443c57786"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("d06ecd6e-fce2-4b81-861e-edd5cac84f08"), new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("e637da38-8cbd-47b9-bba2-6eb602694256"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("ed141839-273d-437a-be60-1c2437665b35"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("e3532f76-380e-47d4-a093-64697c5d4ec5"), new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("122015d6-eca0-494e-a2a8-2664f8fdb24b"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("f788a376-60fe-405a-af8a-c89f9a63c437"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("d576217b-848d-47e2-a3cb-8c2945b20c23"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("7a72b1e7-877b-40cf-957c-76edc22bf053"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("456fd09d-acdb-4bf2-81c6-8a4123a868d4"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("e1f07b8e-a3f1-4f97-b35b-8e5a1b90097a"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("ec24c6e6-284d-427d-a835-bdb13dc384cd"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("c2605e54-ad4f-462c-9e67-06559db7572b"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("b57d4d0c-0f81-4468-8166-a4c277292ed4"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("0584b2e5-cd35-4914-b499-475f2a63a9fd"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("4b68e062-88a6-4d76-9ee0-82a492863285"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("7425cb7c-24f8-4604-9433-f37c2b8093bd"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente");

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("18091b7f-1550-439e-9ec2-86a261709ff0"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("41cd00c0-f662-47ee-b104-b8773eabcf64"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("67ae7ce6-3ca5-47ea-9f31-d8a597664bc2"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("899c5cfd-923a-4267-8af5-f6262f8e7393"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("c554c92c-80d4-44fb-b4c8-3526427bd59e"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("d688615d-755c-4984-8ed1-46107cd9d923"));

            migrationBuilder.DeleteData(
                table: "DiaSemana",
                keyColumn: "Id",
                keyValue: new Guid("f921c12e-2f07-4fed-b285-9198d6510ce4"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("0584b2e5-cd35-4914-b499-475f2a63a9fd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("05b89539-4324-4313-b3ad-9460f47ade3b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("122015d6-eca0-494e-a2a8-2664f8fdb24b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("12345565-6e51-4a08-8798-bac84266dd5f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("1e4332cd-8e12-42a5-9a0e-2ccee3386a0c"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("2ec3c0ac-570a-4966-9fd7-9efd846ff29b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("33feb591-f482-4644-a80b-fb980e7fc715"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("3a5c366a-e712-4cec-8478-24bbde85e908"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("456fd09d-acdb-4bf2-81c6-8a4123a868d4"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("4b68e062-88a6-4d76-9ee0-82a492863285"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("5a142252-66e2-47b4-8b25-1aba5c2685c1"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("613ddd8e-7cdb-4bf5-ba09-fc1ac732acef"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("61c65380-6107-4c84-b17b-07b506bd8daa"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("67d8f191-a41b-451d-b44d-2febf9221c58"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("712c188f-fc3c-47fb-9124-50d6c081baa6"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("71eed2b5-954b-472f-98c0-f5fb1c7a8c5d"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("7425cb7c-24f8-4604-9433-f37c2b8093bd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("7a72b1e7-877b-40cf-957c-76edc22bf053"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("8b26c965-6b2a-4364-9141-bcf98ac435c6"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("8d6ab660-008a-4b27-9252-2b2cbb036664"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("9b98989e-205e-4f9b-8228-603d3e5efee0"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("af27a61b-6749-4fff-8ebb-5d2900bd2897"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("b57d4d0c-0f81-4468-8166-a4c277292ed4"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c2605e54-ad4f-462c-9e67-06559db7572b"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("c5471cce-82c3-4160-b638-62093d3dbf5f"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ce7567a5-81b0-472a-a417-6148da419e05"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d06ecd6e-fce2-4b81-861e-edd5cac84f08"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("d576217b-848d-47e2-a3cb-8c2945b20c23"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("de57e81f-77d1-4ce9-9f59-e653deb20831"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e1f07b8e-a3f1-4f97-b35b-8e5a1b90097a"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e3532f76-380e-47d4-a093-64697c5d4ec5"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e53fa2cc-3e55-4eb6-aa81-1c32d92d60f8"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("e637da38-8cbd-47b9-bba2-6eb602694256"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ec24c6e6-284d-427d-a835-bdb13dc384cd"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("ed141839-273d-437a-be60-1c2437665b35"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f2386bd8-0d1e-441a-bde8-bb6b8ffe54c2"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("f788a376-60fe-405a-af8a-c89f9a63c437"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("fca87f12-6e45-4cbc-8cfc-bfd443c57786"));

            migrationBuilder.DeleteData(
                table: "ServicoPetCaracteristica",
                keyColumn: "Id",
                keyValue: new Guid("fff372e2-1d77-4c7a-a408-8c25ce6b81b4"));

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Cliente");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmpresaId",
                table: "Cliente",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "DiaSemana",
                columns: new[] { "Id", "TipoDiaSemana" },
                values: new object[,]
                {
                    { new Guid("3c4af785-e90b-4df6-bc5d-174981f793ca"), 0 },
                    { new Guid("84ae9ba2-77cc-43be-9166-6200a755933b"), 1 },
                    { new Guid("f3c507e0-4eca-439f-9d38-99a9da52940e"), 2 },
                    { new Guid("3199a724-bd9d-4e7b-9b35-03167d329bf1"), 3 },
                    { new Guid("f4a5f261-0223-46a2-9216-504473934c90"), 4 },
                    { new Guid("6515aa99-9bad-4a8c-910e-82ff15f6ce8d"), 5 },
                    { new Guid("b9f7a41d-f679-407c-bf30-4c8ae81d34f2"), 6 }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("b16c44d9-7d4d-4f92-b8e4-1fd80e7d4106"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("fe9a4164-740a-41cb-8e67-3a3bc8a1d9fd"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("96806485-7aed-444e-ac52-3fa8a0b5556d"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("f2c08d81-3861-4a3f-bf00-34d96b6f0f69"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("d0ece339-2c83-4e4e-a44f-e587a242234a"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("b6ce42f3-fc69-415a-8d2e-235c730677e0"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1") },
                    { new Guid("92a054a5-a70d-4a69-b8b5-3aef0131d714"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("6ac5316d-65d6-4ece-9d8c-597747e8618f"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("4f38a386-3749-420f-8156-e55ed03cea5a"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("81106e6f-5abe-488b-a368-d0ee214983d2"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("71545d07-0c64-4fbe-9000-05f52b24188d"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("0f61053d-826f-4a18-94df-54b9785bc2c8"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("5555edcc-06a2-4341-9973-9cf74394b919"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("5433831b-0b00-4f48-946a-19d20d4194d9"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("c60432ed-2940-414b-a785-97f8194e177a"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("e59bfdfd-9639-4b94-bdd1-3a9df93126f8"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("e2460f32-7f0a-455b-ac50-d132db2ca113"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("79563a4a-5d26-4440-9afb-314453257ee5") },
                    { new Guid("370dac50-b164-47e8-85a2-ec79f0a47b3f"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("7deb0eaf-35d0-48b7-a596-5a1f9908364e"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("5497efe1-d5d1-41bb-94ff-67d400ef86db"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("539fef25-8b7a-4817-a8ae-7c9efff7ed4e"), new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("8d9c02e7-b44c-4bc4-8612-da00a5ef3b12"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("9b528339-7f16-4d64-aa44-510300d58f86"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("6b73d110-6011-43cf-950c-984a274ce387"), new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("9227cdf8-c12d-4d7f-958b-6804c680d0ad"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("f8b6d5d4-45d4-43a6-a9b4-a1d477fd413a"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("c168cc6b-4a68-4139-992e-83cad2a42bff"), new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("66fd27ec-82fe-45cb-a618-0dee9849f83e"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("c50f025c-2b5b-46ba-9b18-82656e905a68"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33") },
                    { new Guid("f5cec5f1-c5ff-4b6a-a34c-571b664c76fb"), new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("f6bb8b6c-9063-42a4-96a6-25e975da08e0"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("34caf77d-62fe-4b9c-993f-c0a51b744101"), new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("6a876bf3-1770-4b42-a233-5be0c088ef9c"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("4b05e1a1-c9a9-46ad-b72e-3589ffc38fa5"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") },
                    { new Guid("913285a5-574b-4a30-9c5e-7453263d66be"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("acfae699-460a-43b3-8b3d-86928fe61388") }
                });

            migrationBuilder.InsertData(
                table: "ServicoPetCaracteristica",
                columns: new[] { "Id", "PetCaracteristicaId", "ServicoId" },
                values: new object[,]
                {
                    { new Guid("473240cf-47c9-42b6-8e9b-9dd0817316d4"), new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") },
                    { new Guid("c6837b18-4c64-499c-a1c5-7b12d4fe25bd"), new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("1ba8e954-a400-4e24-a9e6-c7059499b950"), new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"), new Guid("eb665260-cac8-4869-a03e-35770f8bf119") },
                    { new Guid("01162be9-db85-43d4-b63a-948eb9d8fad3"), new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"), new Guid("7f453ac3-b51f-4281-973b-50181ec273fd") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Empresa_EmpresaId",
                table: "Cliente",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
