using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class IosMap : IEntityTypeConfiguration<Ios>
    {
        public void Configure(EntityTypeBuilder<Ios> builder)
        {
            builder.ToTable("Ios");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();

            builder.HasMany(a => a.Ambientes).WithOne(c => c.Ios);
        }
    }
}
