using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class DesenvolvedorMap : IEntityTypeConfiguration<Desenvolvedor>
    {
        public void Configure(EntityTypeBuilder<Desenvolvedor> builder)
        {
            builder.ToTable("Desenvolvedor");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();

            builder.Property(a => a.Usuario).HasMaxLength(50);
            builder.Property(a => a.Usuario).IsRequired();

            builder.Property(a => a.Email).HasMaxLength(50);
            builder.Property(a => a.Email).IsRequired();

        }
    }
}
