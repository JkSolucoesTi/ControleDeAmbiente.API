using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class DetalheMap : IEntityTypeConfiguration<Detalhe>
    {
        public void Configure(EntityTypeBuilder<Detalhe> builder)
        {
            builder.HasKey(x => x.Id);           
            builder.Property(x => x.Numero).HasMaxLength(50);

            builder.HasOne(d => d.Chamado)
                   .WithMany(p => p.Detalhes)
                   .HasForeignKey(d => d.ChamadoId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasConstraintName("FK_Detalhes_Chamado");

            builder.HasOne(d => d.Desenvolvedor)
                   .WithMany(p => p.Detalhes)
                   .HasForeignKey(d => d.DesenvolvedorId)
                   .OnDelete(DeleteBehavior.NoAction)
                   .HasConstraintName("FK_Detalhes_Desenvolvedor");




        }
    }
}
