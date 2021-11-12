﻿using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL.Mapeamento
{
    public class AndroidMap : IEntityTypeConfiguration<Android>
    {
        public void Configure(EntityTypeBuilder<Android> builder)
        {
            builder.ToTable("Android");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome).HasMaxLength(50);
            builder.Property(a => a.Nome).IsRequired();

            builder.HasMany(a => a.Ambientes).WithOne(c => c.Android);

            builder.HasData(
            new Android
            {               
                Nome = "android01"
            },
            new Android
            {
                Nome = "android02"
            }
            ,
            new Android
            {
                Nome = "android03"
            }
            );
        }
    }
}
