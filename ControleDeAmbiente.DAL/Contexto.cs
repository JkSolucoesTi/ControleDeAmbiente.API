﻿using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Mapeamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<Android> Android { get; set; }
        public DbSet<Ios> Ios { get; set; }
        public DbSet<Web> Web { get; set; }
        public DbSet<Negocio> Negocio { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AmbienteMap());
            builder.ApplyConfiguration(new AndroidMap());
            builder.ApplyConfiguration(new IosMap());
            builder.ApplyConfiguration(new WebMap());
            builder.ApplyConfiguration(new NegocioMap());
        }
    }
}
