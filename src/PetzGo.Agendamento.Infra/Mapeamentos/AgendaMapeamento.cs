using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Agendamento.Dominio.Entidades;

namespace PetzGo.Agendamento.Infra.Mapeamentos
{
    public class AgendaMapeamento : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.EmpresaId).IsRequired();
            builder.Property(x => x.ValorTotal).HasColumnType("decimal(8,2)");
            builder.Property(x => x.DataHoraInicio).HasColumnType("datetime").IsRequired();
            builder.Property(x => x.DataHoraTermino).HasColumnType("datetime").IsRequired();
            builder.HasOne(a => a.AgendaCliente).WithOne(ac => ac.Agenda).HasForeignKey<Agenda>(a => a.AgendaClienteId);
            builder.HasOne(a => a.AgendaPet).WithOne(ap => ap.Agenda).HasForeignKey<Agenda>(a => a.AgendaPetId);
            builder.HasOne(a => a.AgendaServico).WithOne(ase => ase.Agenda).HasForeignKey<Agenda>(a => a.AgendaServicoId);
        }
    }
}
