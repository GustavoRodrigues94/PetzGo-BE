using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class EnderecoMapeamento : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Logradouro).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.CEP).HasColumnType("varchar(8)").IsRequired();
            builder.Property(x => x.Numero).HasColumnType("varchar(8)").IsRequired();
            builder.Property(x => x.Complemento).HasColumnType("varchar(40)");
            builder.Property(x => x.Cidade).HasColumnType("varchar(40)").IsRequired();
            builder.Property(x => x.Estado).HasColumnType("varchar(2)");
        }
    }
}
