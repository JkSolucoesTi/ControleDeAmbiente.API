using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class AmbienteMap : IEntityTypeConfiguration<Ambiente>
    {
        public void Configure(EntityTypeBuilder<Ambiente> builder)
        {
            builder.ToTable("Ambientes");

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();

        }
    }
}
