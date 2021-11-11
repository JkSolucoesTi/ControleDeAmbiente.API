using ControleDeAmbiente.BLL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleDeAmbiente.DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opcoes): base(opcoes)
        {

        }

        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<Android> Android { get; set; }
        public DbSet<Ios> Ios { get; set; }
        public DbSet<Api> Api { get; set; }
    }
}
