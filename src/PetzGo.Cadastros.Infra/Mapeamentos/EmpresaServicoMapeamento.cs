using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class EmpresaServicoMapeamento : IEntityTypeConfiguration<EmpresaServico>
    {
        public void Configure(EntityTypeBuilder<EmpresaServico> builder)
        {
            builder.ToTable("EmpresaServico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TipoPet).HasConversion<string>().HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.Valor).HasColumnType("decimal(5,2)").IsRequired();
            builder.Property(x => x.TempoEmMinutos).HasColumnType("integer").IsRequired();
            builder.HasOne(e => e.ServicoPetCaracteristica)
                .WithMany(spc => spc.EmpresaServico)
                .HasForeignKey(e => e.ServicoPetCaracteristicaId);
        }
    }
}
