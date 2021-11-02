﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzGo.Cadastros.Infra.Contexto;

namespace PetzGo.Cadastros.Infra.Migrations
{
    [DbContext(typeof(CadastrosContexto))]
    [Migration("20211102173723_AjusteOnboarding")]
    partial class AjusteOnboarding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.DiaSemana", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoDiaSemana")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DiaSemana");

                    b.HasData(
                        new
                        {
                            Id = new Guid("27572856-bb7e-43e8-acbb-4e6c61fefdc3"),
                            TipoDiaSemana = 0
                        },
                        new
                        {
                            Id = new Guid("d26dbdc0-ac90-47d8-a415-fcbcc14b87e8"),
                            TipoDiaSemana = 1
                        },
                        new
                        {
                            Id = new Guid("96b0a6bc-4cdb-4d8c-93bb-760a53f37a1e"),
                            TipoDiaSemana = 2
                        },
                        new
                        {
                            Id = new Guid("85afc891-e6d0-4dbc-98ca-54711d037ae1"),
                            TipoDiaSemana = 3
                        },
                        new
                        {
                            Id = new Guid("3d430420-4d34-4cc9-89d1-7e8a189cabbd"),
                            TipoDiaSemana = 4
                        },
                        new
                        {
                            Id = new Guid("eeb0ddb9-ce51-4e25-930b-9afbf7917e8a"),
                            TipoDiaSemana = 5
                        },
                        new
                        {
                            Id = new Guid("9c0013ad-9f58-4564-a0ba-aa5f8b930948"),
                            TipoDiaSemana = 6
                        });
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("TipoNegocioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique()
                        .HasFilter("[EnderecoId] IS NOT NULL");

                    b.HasIndex("TipoNegocioId");

                    b.ToTable("Empresa");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.EmpresaHorario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiaSemanaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HoraFim")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("HoraInicio")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.HasIndex("DiaSemanaId");

                    b.HasIndex("EmpresaId");

                    b.ToTable("EmpresaHorario");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.EmpresaServico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServicoPetCaracteristicaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TempoEmMinutos")
                        .HasColumnType("integer");

                    b.Property<string>("TipoPet")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("ServicoPetCaracteristicaId");

                    b.ToTable("EmpresaServico");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Estado")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Pet", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(70)");

                    b.Property<Guid>("PetCaracteristicaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoPet")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("PetCaracteristicaId");

                    b.ToTable("Pet");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.PetCaracteristica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("TipoPetCaracteristica")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("PetCaracteristica");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"),
                            TipoPetCaracteristica = 0
                        },
                        new
                        {
                            Id = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            TipoPetCaracteristica = 1
                        },
                        new
                        {
                            Id = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            TipoPetCaracteristica = 2
                        },
                        new
                        {
                            Id = new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"),
                            TipoPetCaracteristica = 3
                        },
                        new
                        {
                            Id = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            TipoPetCaracteristica = 4
                        },
                        new
                        {
                            Id = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            TipoPetCaracteristica = 5
                        },
                        new
                        {
                            Id = new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"),
                            TipoPetCaracteristica = 6
                        },
                        new
                        {
                            Id = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            TipoPetCaracteristica = 7
                        },
                        new
                        {
                            Id = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            TipoPetCaracteristica = 8
                        });
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Servico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Servico");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                            Nome = "Banho"
                        },
                        new
                        {
                            Id = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                            Nome = "Banho & Tosa com máquina"
                        },
                        new
                        {
                            Id = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                            Nome = "Banho & Tosa com tesoura"
                        },
                        new
                        {
                            Id = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                            Nome = "Tosa com máquina"
                        },
                        new
                        {
                            Id = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                            Nome = "Tosa com tesoura"
                        },
                        new
                        {
                            Id = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                            Nome = "Tosa higiênica"
                        });
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.ServicoPetCaracteristica", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PetCaracteristicaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServicoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PetCaracteristicaId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoPetCaracteristica");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6da943d2-6534-477a-95de-5d1186d97283"),
                            PetCaracteristicaId = new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("965c01dd-5d21-43c8-b3c6-86e1ed83b253"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("8ab0ee06-3c60-4e35-9069-d3cb8f1e793a"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("a3985166-05ea-4f03-b2cd-0aaad0f92dc6"),
                            PetCaracteristicaId = new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("96a67482-22ea-4606-bd15-addc43962748"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("69ff64be-1420-4235-843b-4dae532716ee"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("f8f8d997-1b07-404f-85f2-bb7bc5f35965"),
                            PetCaracteristicaId = new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("ef2f6876-88f9-4a70-a7f9-0a66af44b3de"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("cdbb78ef-afb1-4367-9965-78ab8d7c3e9c"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("d8e5ad5a-9ef5-4c72-a0b5-0cd5a418ffb1"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("cd8cf2ec-6379-4f97-bb31-aad21639c11c"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("93b5501e-c704-42cb-b52b-d320d356dfd8"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("6b6daf4c-7a5b-46b1-a890-87363e8d67cc"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("4974d8cc-e362-4928-bd54-c66130400ea5"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("35288d4d-e06a-4bc3-b2a2-fe55ee5f2f6c"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("55f3db83-896f-47e0-807a-1fd933bd04f7"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("4f4a474c-9ceb-4b9d-b3ae-b6ad47abe590"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("d0a3325f-a2e2-4ab7-bbaa-bfed1d969759"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("12c9bde0-07b2-41ea-8235-f2df5e3c41cf"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("da52c5cd-0d9e-4d27-ba04-2bd89664ceb2"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("8db5bfa8-5a21-44d4-bdad-6eb43d6baa05"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("c957959e-d82b-4fc8-9fa5-c9790d949833"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("f458e087-320b-4b36-a4a0-9d9255e70572"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("a3768fad-da05-4af9-9c64-36a2922c2530"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("23599631-8e4d-4a29-9e78-5a1e49bc8ab2"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("6b496128-4861-4056-a758-0384c6ed1984"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("572f8e59-f234-4717-a232-9f27437270f9"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("b7c5415d-81be-4031-9986-b6de28f855c0"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("1a69fdbc-7ddc-44c0-856d-7badf8fd0b46"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("8f721461-79c1-4f81-928e-890a5684d5cc"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("6e100521-38b3-48b5-9af9-d393fe787ff8"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("9b7f46ed-25c5-4b71-97ee-013a76d64fbe"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("b769e8de-57df-46b7-9851-3a188b5ac09e"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("99c3031c-1e8b-427f-9f74-602d699ebdfa"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("ffacc1ac-d790-4e0c-8a29-6086c9371df2"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("23459817-2a95-4dc0-8507-5607ceb91911"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("3847cd9e-68b7-4d5d-8e58-b432750bb006"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("5fa3bb6f-557f-4d4b-961d-3a28ea096f42"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("43c8abdd-677a-4273-b89e-c136efcee08d"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        });
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.TipoNegocio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeTipoNegocio")
                        .IsRequired()
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("TipoNegocio");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5ed433bb-5687-4b00-9d1b-84717101ac48"),
                            NomeTipoNegocio = "PetShop"
                        },
                        new
                        {
                            Id = new Guid("ce280415-4d18-4637-9244-7b76b69274a4"),
                            NomeTipoNegocio = "ClinicaVeterinaria"
                        },
                        new
                        {
                            Id = new Guid("ef4565e5-b230-4182-89f1-0ebfc1e26563"),
                            NomeTipoNegocio = "PetShopClinicaVeterinaria"
                        });
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Cliente", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Endereco", "Endereco")
                        .WithOne("Cliente")
                        .HasForeignKey("PetzGo.Cadastros.Dominio.Entidades.Cliente", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Empresa", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Endereco", "Endereco")
                        .WithOne("Empresa")
                        .HasForeignKey("PetzGo.Cadastros.Dominio.Entidades.Empresa", "EnderecoId");

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.TipoNegocio", "TipoNegocio")
                        .WithMany("Empresas")
                        .HasForeignKey("TipoNegocioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("TipoNegocio");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.EmpresaHorario", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.DiaSemana", "DiaSemana")
                        .WithMany("EmpresaHorarios")
                        .HasForeignKey("DiaSemanaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("EmpresaHorarios")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DiaSemana");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.EmpresaServico", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Empresa", "Empresa")
                        .WithMany("EmpresaServicos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.ServicoPetCaracteristica", "ServicoPetCaracteristica")
                        .WithMany("EmpresaServico")
                        .HasForeignKey("ServicoPetCaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("ServicoPetCaracteristica");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Pet", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Cliente", "Cliente")
                        .WithOne("Pet")
                        .HasForeignKey("PetzGo.Cadastros.Dominio.Entidades.Pet", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.PetCaracteristica", "PetCaracteristica")
                        .WithMany("Pets")
                        .HasForeignKey("PetCaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("PetCaracteristica");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.ServicoPetCaracteristica", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.PetCaracteristica", "PetCaracteristica")
                        .WithMany("ServicoPetCaracteristica")
                        .HasForeignKey("PetCaracteristicaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Servico", "Servico")
                        .WithMany("ServicoPetCaracteristica")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PetCaracteristica");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Cliente", b =>
                {
                    b.Navigation("Pet");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.DiaSemana", b =>
                {
                    b.Navigation("EmpresaHorarios");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Empresa", b =>
                {
                    b.Navigation("EmpresaHorarios");

                    b.Navigation("EmpresaServicos");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Endereco", b =>
                {
                    b.Navigation("Cliente");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.PetCaracteristica", b =>
                {
                    b.Navigation("Pets");

                    b.Navigation("ServicoPetCaracteristica");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Servico", b =>
                {
                    b.Navigation("ServicoPetCaracteristica");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.ServicoPetCaracteristica", b =>
                {
                    b.Navigation("EmpresaServico");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.TipoNegocio", b =>
                {
                    b.Navigation("Empresas");
                });
#pragma warning restore 612, 618
        }
    }
}