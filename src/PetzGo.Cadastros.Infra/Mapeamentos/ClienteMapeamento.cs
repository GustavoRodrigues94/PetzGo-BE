using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Cadastros.Dominio.Entidades;

namespace PetzGo.Cadastros.Infra.Mapeamentos
{
    public class ClienteMapeamento : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(70)").IsRequired();
            builder.Property(x => x.WhatsApp).HasColumnType("varchar(15)").IsRequired();
            builder.HasOne(c => c.Endereco).WithOne(en => en.Cliente).HasForeignKey<Cliente>(e => e.EnderecoId);
            builder.HasOne(c => c.Pet).WithOne(p => p.Cliente).HasForeignKey<Pet>(p => p.ClienteId);
        }
    }
}
