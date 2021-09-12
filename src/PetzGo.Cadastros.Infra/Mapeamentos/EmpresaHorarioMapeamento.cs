using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class EmpresaHorarioMapeamento : IEntityTypeConfiguration<EmpresaHorario>
    {
        public void Configure(EntityTypeBuilder<EmpresaHorario> builder)
        {
            builder.ToTable("EmpresaHorario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.HoraInicio).HasColumnType("varchar(5)").IsRequired();
            builder.Property(x => x.HoraFim).HasColumnType("varchar(5)").IsRequired();
        }
    }
}
