using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class PetMapeamento : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.ToTable("Pet");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(70)").IsRequired();
            builder.Property(x => x.TipoPet).HasConversion<string>().HasColumnType("varchar(15)").IsRequired();
            builder.HasOne(p => p.PetCaracteristica).WithMany(pc => pc.Pets).HasForeignKey(p => p.PetCaracteristicaId);
        }
    }
}
