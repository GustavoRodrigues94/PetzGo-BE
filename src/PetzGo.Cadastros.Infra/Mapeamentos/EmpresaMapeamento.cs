using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class EmpresaMapeamento : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomeFantasia).HasColumnType("varchar(200)").IsRequired();
            builder.Property(x => x.CNPJ).HasColumnType("varchar(14)").IsRequired();
            builder.Property(x => x.WhatsApp).HasColumnType("varchar(15)").IsRequired();
            builder.HasOne(e => e.TipoNegocio).WithMany(tn => tn.Empresas).HasForeignKey(e => e.TipoNegocioId);
            builder.HasOne(e => e.Endereco).WithOne(en => en.Empresa).HasForeignKey<Empresa>(e => e.EnderecoId);
            builder.HasMany(e => e.EmpresaServicos).WithOne(es => es.Empresa).HasForeignKey(es => es.EmpresaId);
            builder.HasMany(e => e.EmpresaHorarios).WithOne(eh => eh.Empresa).HasForeignKey(eh => eh.EmpresaId);
        }
    }
}
