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
        }
    }
}
