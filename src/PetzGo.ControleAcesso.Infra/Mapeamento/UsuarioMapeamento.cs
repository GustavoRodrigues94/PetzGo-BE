using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.ControleAcesso.Dominio.Entidades;

namespace PetzGo.ControleAcesso.Infra.Mapeamento
{
    public class UsuarioMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Email).HasColumnType("varchar(80)").IsRequired();
            builder.Property(x => x.Senha).HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.TipoUsuario).HasColumnType("smallint").IsRequired();
            builder.Property(x => x.EmpresaId);
            builder.Property(x => x.EmpresaRotuloLink).HasColumnType("varchar(30)").IsRequired();
        }
    }
}
