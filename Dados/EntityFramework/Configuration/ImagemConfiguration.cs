using Dominio.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados.EntityFramework.Configuration
{
    public class ImagemConfiguration : IEntityTypeConfiguration<Imagem>
    {
        public void Configure(EntityTypeBuilder<Imagem> builder)
        {
            builder.ToTable("Imagem");
            builder.HasKey(x => x.Id);

            builder.Property(nt => nt.AnimalId)
              .HasColumnName("AnimalId")
              .HasColumnType("int");

            builder.Property(nt => nt.Url)
                   .HasColumnName("Url")
                   .HasColumnType("varchar(255)");

        }
    }
}
