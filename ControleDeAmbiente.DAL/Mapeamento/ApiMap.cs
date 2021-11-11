using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class ApiMap : IEntityTypeConfiguration<Api>
    {
        public void Configure(EntityTypeBuilder<Api> builder)
        {
            builder.ToTable("Api");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();


            builder.HasMany(a => a.Ambientes).WithOne(c => c.Api);

        }
    }
}
