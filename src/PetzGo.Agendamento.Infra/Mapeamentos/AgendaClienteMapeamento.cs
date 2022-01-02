using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Agendamento.Dominio.Entidades;

namespace PetzGo.Agendamento.Infra.Mapeamentos
{
    public class AgendaClienteMapeamento : IEntityTypeConfiguration<AgendaCliente>
    {
        public void Configure(EntityTypeBuilder<AgendaCliente> builder)
        {
            builder.ToTable("AgendaCliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(250)").IsRequired();
        }
    }
}
