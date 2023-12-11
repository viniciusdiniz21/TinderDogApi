﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.EntityFramework.Configuration
{
    public class RacaConfiguration : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("RACA");
            builder.HasKey(f => f.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("ID")
                .HasColumnType("int")
                ;

            builder
                .Property(f => f.NomeRaca)
                .HasColumnName("NOMERACA")
                .HasColumnType("varchar(40)");

            builder
                .Property(f => f.Tamanho)
                .HasColumnName("TAMANHO")
                .HasColumnType("string");

            builder
                .Property(f => f.Porte)
                .HasColumnName("PORTE")
                .HasColumnType("char");

           

        }
    }
}
