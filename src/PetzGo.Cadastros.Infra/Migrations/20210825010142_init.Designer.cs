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
    [Migration("20210825010142_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                            Id = new Guid("05e8dc15-fcb2-4f21-8a7f-cbc3c88fb0b2"),
                            TipoDiaSemana = 0
                        },
                        new
                        {
                            Id = new Guid("65e69e8a-5b39-461f-aa26-f26e067add3e"),
                            TipoDiaSemana = 1
                        },
                        new
                        {
                            Id = new Guid("dcc0c95e-699a-4ad8-a63e-332dc65d9586"),
                            TipoDiaSemana = 2
                        },
                        new
                        {
                            Id = new Guid("4281d68c-926f-4a4d-b20e-9304046c8931"),
                            TipoDiaSemana = 3
                        },
                        new
                        {
                            Id = new Guid("8787b28f-ff65-46f3-939b-4822a85d4c17"),
                            TipoDiaSemana = 4
                        },
                        new
                        {
                            Id = new Guid("d4686aad-762e-4b45-9062-380286670334"),
                            TipoDiaSemana = 5
                        },
                        new
                        {
                            Id = new Guid("9cede659-10a6-40a7-abaa-dd58c07c0ff5"),
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

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("RotuloLink")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<Guid>("TipoNegocioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WhatsApp")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

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
                            Id = new Guid("e035e694-9f81-4aaf-921d-efce24f8f611"),
                            PetCaracteristicaId = new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("ed83c3de-1b83-43d0-9b60-b977ce994956"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("63fc4be2-ea8d-4340-b414-a28c6aa69db9"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("c6c738cc-226d-4796-81d0-fd9379abc97c"),
                            PetCaracteristicaId = new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("4cf2c9ef-4c65-4777-9cee-6f3b39ff7ef3"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("68bbbd91-9826-4f96-87b7-62937bc3fd13"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("a589ffac-3eb9-472e-880f-24d5ac533774"),
                            PetCaracteristicaId = new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("510d399b-7cb5-4e2a-90c1-4d42f69c7433"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("c436053d-873c-41e2-8f62-92d15ddf3533"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33")
                        },
                        new
                        {
                            Id = new Guid("02bb0c6d-3bfe-414f-bc2a-6530e94981ed"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("ca3d98c1-7a7f-4f1c-802e-b9253ce751b8"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("ec42fe77-82de-4db9-9d33-a9c8ddf36146"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("c638a23d-e1d0-4617-8475-455e5aee1a3f"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("b90dc9dc-dd36-4ab7-a797-439a6c36654f"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("d920d3c1-8aba-4566-b1e9-5fa2327e5938"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388")
                        },
                        new
                        {
                            Id = new Guid("c195358b-4466-4fd0-bf29-20b32865e22f"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("43ee50e4-9ec8-46fd-bbf7-445e18ae7264"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("ef354393-3a79-4178-bfe0-90d124dbb095"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("d48da21d-1109-4812-ade3-796a461e52f5"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("d641606f-42d6-40f0-bd9d-8652c8a4ea32"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("37dcbe71-4897-4b6b-9a58-64f1960cd7d6"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119")
                        },
                        new
                        {
                            Id = new Guid("56310574-8981-4b6b-a26d-9a9ddc7230dd"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("ea6fae01-27e4-476a-9895-6739a697307d"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("a9ec6f31-4c96-4d8f-8ecb-52d5b56d2423"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("b0a82ce1-87b7-4dc9-acd2-981d564a3868"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("b76ef529-b3ce-4347-b104-f95f7c216e0b"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("2880e969-ac07-42a9-b29b-3c21c6ee2272"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1")
                        },
                        new
                        {
                            Id = new Guid("53f28433-090a-43e3-b500-5ace494f1dbf"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("264c44e6-c7d4-4957-97a0-ac689e885413"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("14c2cfe8-8f48-4694-b2d2-7e28940a99be"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("28fd2554-f914-4063-9412-7c11bd101063"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("d1c405ac-f716-46bf-92b3-eee4f452869b"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("06d9f9b9-6e02-4679-8288-1d030a7b9150"),
                            PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                            ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5")
                        },
                        new
                        {
                            Id = new Guid("c10140a1-849f-4238-a01b-097cb11e1af4"),
                            PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("37b78279-82c9-492f-80c1-7e2698f7b725"),
                            PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("3560558d-2130-4d4a-a123-011286b9663f"),
                            PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("7acde698-d706-45f8-a9fe-dc363ce8df38"),
                            PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("615cc5c4-912c-4f3a-b9b8-b7d115198082"),
                            PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                            ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd")
                        },
                        new
                        {
                            Id = new Guid("08106577-70c8-4bf0-8cfa-8694b70b383a"),
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

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.Empresa", b =>
                {
                    b.HasOne("PetzGo.Cadastros.Dominio.Entidades.Endereco", "Endereco")
                        .WithOne("Empresa")
                        .HasForeignKey("PetzGo.Cadastros.Dominio.Entidades.Empresa", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("PetzGo.Cadastros.Dominio.Entidades.PetCaracteristica", b =>
                {
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
