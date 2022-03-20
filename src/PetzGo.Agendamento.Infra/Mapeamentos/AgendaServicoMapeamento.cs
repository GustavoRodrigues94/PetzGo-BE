using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Agendamento.Dominio.Entidades;

namespace PetzGo.Agendamento.Infra.Mapeamentos
{
    public class AgendaServicoMapeamento : IEntityTypeConfiguration<AgendaServico>
    {
        public void Configure(EntityTypeBuilder<AgendaServico> builder)
        {
            builder.ToTable("AgendaServico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(300)").IsRequired();
            builder.Property(x => x.Valor).HasColumnType("decimal(6,2)").IsRequired();
            builder.Property(x => x.TempoEmMinutos).IsRequired();
        }
    }
}
