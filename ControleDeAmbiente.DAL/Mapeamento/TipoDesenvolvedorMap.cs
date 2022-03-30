using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class TipoDesenvolvedorMap : IEntityTypeConfiguration<TipoDesenvolvedor>
    {
        public void Configure(EntityTypeBuilder<TipoDesenvolvedor> builder)
        {
            builder.ToTable("TipoDesenvolvedor");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Tipo).HasMaxLength(50);
            builder.Property(a => a.Tipo).IsRequired();
        }
    }
}
