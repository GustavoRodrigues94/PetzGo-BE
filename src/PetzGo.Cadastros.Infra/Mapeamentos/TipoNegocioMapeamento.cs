using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class TipoNegocioMapeamento : IEntityTypeConfiguration<TipoNegocio>
    {
        public void Configure(EntityTypeBuilder<TipoNegocio> builder)
        {
            builder.ToTable("TipoNegocio");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeTipoNegocio).HasConversion<string>().HasColumnType("varchar(150)").IsRequired();

            builder.HasData(
                new
                {
                    Id = new Guid("5ed433bb-5687-4b00-9d1b-84717101ac48"), 
                    NomeTipoNegocio = TipoNegocioEnum.PetShop
                },
                new
                {
                    Id = new Guid("ce280415-4d18-4637-9244-7b76b69274a4"),
                    NomeTipoNegocio = TipoNegocioEnum.ClinicaVeterinaria
                },
                new
                {
                    Id = new Guid("ef4565e5-b230-4182-89f1-0ebfc1e26563"),
                    NomeTipoNegocio = TipoNegocioEnum.PetShopClinicaVeterinaria
                }
            );
        }
    }
}
