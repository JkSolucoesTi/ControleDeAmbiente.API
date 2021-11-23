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
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();

            builder.Property(a => a.Chamado).HasMaxLength(50);
            builder.Property(a => a.Chamado).IsRequired();

            builder.Property(a => a.Descricao).HasMaxLength(50);
            builder.Property(a => a.Descricao).IsRequired();

            builder.ToTable("Ambientes");           
        }
    }
}
