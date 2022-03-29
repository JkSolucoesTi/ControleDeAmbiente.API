using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class ServidorMap : IEntityTypeConfiguration<Servidor>
    {
        public void Configure(EntityTypeBuilder<Servidor> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(50);

            builder.Property(x => x.Dominio).IsRequired();
            builder.Property(x => x.Dominio).HasMaxLength(50);

            builder.HasMany(b => b.Ambientes).WithOne();

        }
    }
}
