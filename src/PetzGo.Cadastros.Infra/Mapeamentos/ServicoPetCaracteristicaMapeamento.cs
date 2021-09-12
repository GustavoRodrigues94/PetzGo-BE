using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class ServicoPetCaracteristicaMapeamento : IEntityTypeConfiguration<ServicoPetCaracteristica>
    {
        public void Configure(EntityTypeBuilder<ServicoPetCaracteristica> builder)
        {
            builder.ToTable("ServicoPetCaracteristica");
            builder.HasKey(x => x.Id);

            builder.HasData(
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("5a4f87ea-fbda-46d0-963c-a70e9491995c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("4c3d8bff-7488-4560-bd1d-da6b38e8feb3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("2858d9ad-6f9d-46a9-b34a-7cd179730c9f")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("cf2c0c60-9398-4011-a8fb-11815c292c33"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                },



                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("acfae699-460a-43b3-8b3d-86928fe61388"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                },



                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("eb665260-cac8-4869-a03e-35770f8bf119"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                },



                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("26a8223b-fbe5-49fd-a7ba-99e6f00470c1"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                },



                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("79563a4a-5d26-4440-9afb-314453257ee5"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                },



                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("e97ce00f-62b6-4e8e-8150-500318d6b5d3")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("fdf62227-c47a-40e7-8a29-d4fb59a37051")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("088f3ab6-360c-4e9c-8841-bdf503b3ecd4")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("c1dbfa76-1415-4776-b49e-897ffa76621c")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("b7bf1e6d-ece5-486e-a966-1daadf1b30f7")
                },
                new
                {
                    Id = Guid.NewGuid(),
                    ServicoId = new Guid("7f453ac3-b51f-4281-973b-50181ec273fd"),
                    PetCaracteristicaId = new Guid("65e23e78-af21-42e6-a805-648c9eee1ef1")
                }
            );
        }
    }
}
