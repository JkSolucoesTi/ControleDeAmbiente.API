using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(x => x.UsuarioId);

            builder.Property(u => u.Login).IsRequired();            
            builder.Property(u => u.Login).HasMaxLength(10);
            
            builder.Property(u => u.Senha).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(10);

            builder.Property(u => u.Perfil).IsRequired();
            builder.Property(u => u.Perfil).HasMaxLength(20);

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);

            builder.Property(u => u.Nome).IsRequired();
            builder.Property(u => u.Nome).HasMaxLength(50);
        }
    }
}
