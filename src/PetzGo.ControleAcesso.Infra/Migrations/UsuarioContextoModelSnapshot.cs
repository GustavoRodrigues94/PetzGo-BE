﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetzGo.ControleAcesso.Infra.Contexto;

namespace PetzGo.ControleAcesso.Infra.Migrations
{
    [DbContext(typeof(UsuarioContexto))]
    partial class UsuarioContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PetzGo.ControleAcesso.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EmpresaRotuloLink")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<short>("TipoUsuario")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}