using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio.Entities;
using Dominio;

namespace Dados.EntityFramework.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");
            builder.HasKey(x => x.Id);

            builder
                .Property(f => f.Id)
                .UseIdentityColumn()
                .HasColumnName("Id")
                .HasColumnType("int")
                ;

            builder
                .Property(x => x.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar(255)")
                ;
            builder
               .Property(x => x.Ativo)
               .HasColumnName("ATIVO")
               .HasColumnType("char")
               ;
            builder.HasOne(u => u.Animal)
               .WithOne()
               .HasForeignKey<Animal>(a => a.UsuarioId)
               .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
