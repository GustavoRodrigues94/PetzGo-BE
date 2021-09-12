using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class ServicoMapeamento : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(60)").IsRequired();
            builder.HasMany(s => s.ServicoPetCaracteristica)
                .WithOne(spc => spc.Servico)
                .HasForeignKey(s => s.ServicoId);

            builder.HasData(
                new
                {
                    Id = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    Nome = "Banho"
                },
                new
                {
                    Id = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    Nome = "Banho & Tosa com máquina"
                },
                new
                {
                    Id = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    Nome = "Banho & Tosa com tesoura"
                },
                new
                {
                    Id = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    Nome = "Tosa com máquina"
                },
                new
                {
                    Id = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    Nome = "Tosa com tesoura"
                },
                new
                {
                    Id = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    Nome = "Tosa higiênica"
                }
            );
        }
    }
}
