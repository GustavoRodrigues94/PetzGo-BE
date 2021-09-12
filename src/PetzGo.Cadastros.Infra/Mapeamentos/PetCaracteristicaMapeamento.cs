using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;
using PetzGo.Cadastros.Dominio.Enums;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class PetCaracteristicaMapeamento : IEntityTypeConfiguration<PetCaracteristica>
    {
        public void Configure(EntityTypeBuilder<PetCaracteristica> builder)
        {
            builder.ToTable("PetCaracteristica");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TipoPetCaracteristica).HasColumnType("integer").IsRequired();
            builder.HasMany(pc => pc.ServicoPetCaracteristica)
                .WithOne(spc => spc.PetCaracteristica)
                .HasForeignKey(pc => pc.PetCaracteristicaId);

            builder.HasData(
                new
                {
                    Id = new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c"),
                    TipoPetCaracteristica = TipoPetCaracteristica.PequenoComPeloCurto
                },
                new
                {
                    Id = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3"),
                    TipoPetCaracteristica = TipoPetCaracteristica.PequenoComPeloMedio
                },
                new
                {
                    Id = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051"),
                    TipoPetCaracteristica = TipoPetCaracteristica.PequenoComPeloLongo
                },
                new
                {
                    Id = new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3"),
                    TipoPetCaracteristica = TipoPetCaracteristica.MedioComPeloCurto
                },
                new
                {
                    Id = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4"),
                    TipoPetCaracteristica = TipoPetCaracteristica.MedioComPeloMedio
                },
                new
                {
                    Id = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c"),
                    TipoPetCaracteristica = TipoPetCaracteristica.MedioComPeloLongo
                },
                new
                {
                    Id = new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f"),
                    TipoPetCaracteristica = TipoPetCaracteristica.GrandeComPeloCurto
                },
                new
                {
                    Id = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7"),
                    TipoPetCaracteristica = TipoPetCaracteristica.GrandeComPeloMedio
                },
                new
                {
                    Id = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1"),
                    TipoPetCaracteristica = TipoPetCaracteristica.GrandeComPeloLongo
                }
            );
        }
    }
}
