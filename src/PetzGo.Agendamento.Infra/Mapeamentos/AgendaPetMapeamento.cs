﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetzGo.Agendamento.Dominio.Entidades;

namespace PetzGo.Agendamento.Infra.Mapeamentos
{
    public class AgendaPetMapeamento : IEntityTypeConfiguration<AgendaPet>
    {
        public void Configure(EntityTypeBuilder<AgendaPet> builder)
        {
            builder.ToTable("AgendaPet");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnType("varchar(150)").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("varchar(150)").IsRequired();
        }
    }
}
