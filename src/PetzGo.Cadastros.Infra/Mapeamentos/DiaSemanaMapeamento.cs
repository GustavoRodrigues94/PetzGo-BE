using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class DiaSemanaMapeamento : IEntityTypeConfiguration<DiaSemana>
    {
        public void Configure(EntityTypeBuilder<DiaSemana> builder)
        {
            builder.ToTable("DiaSemana");
            builder.HasKey(x => x.Id);
            builder.HasMany(ds => ds.EmpresaHorarios)
                .WithOne(eh => eh.DiaSemana)
                .HasForeignKey(eh => eh.DiaSemanaId);

            builder.HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.SegundaFeira
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.TercaFeira
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.QuartaFeira
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.QuintaFeira
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.SextaFeira
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.Sabado
                },
                new
                {
                    Id = Guid.NewGuid(),
                    TipoDiaSemana = TipoDiaSemanaEnum.Domingo
                }
            );
        }
    }
}
