using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class AmbienteChamadoMap : IEntityTypeConfiguration<AmbienteChamado>
    {
        public void Configure(EntityTypeBuilder<AmbienteChamado> builder)
        {
            builder.ToTable("AmbienteChamado");
            builder.HasKey(s => new { s.AmbienteId, s.ChamadoId });

            builder.HasOne(c => c.Ambiente)
                .WithMany(cd => cd.AmbienteChamado)
                .HasForeignKey(cd => cd.AmbienteId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Chamado)
                    .WithMany(cd => cd.AmbienteChamado)
                    .HasForeignKey(cd => cd.ChamadoId)
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
