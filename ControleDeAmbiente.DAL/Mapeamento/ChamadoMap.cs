using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class ChamadoMap : IEntityTypeConfiguration<Chamado>
    {
        public void Configure(EntityTypeBuilder<Chamado> builder)
        {
            builder.ToTable("Chamado");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Numero).HasMaxLength(50);
            builder.Property(a => a.Numero).IsRequired();

            builder.Property(a => a.ChamadoWeb).HasMaxLength(50);
            builder.Property(a => a.ChamadoIos).HasMaxLength(50);
            builder.Property(a => a.ChamadoAndroid).HasMaxLength(50);

        }
    }
}
