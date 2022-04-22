using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace ControleDeAmbiente.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Chamado> Chamados { get; set; }
        public DbSet<Ambiente> Ambientes { get; set; }
        public DbSet<Negocio> Negocio { get; set; }
        public DbSet<Api> Api { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servidor> Servidor { get; set; }
        public DbSet<Desenvolvedor> Desenvolvedor { get; set; }
        public DbSet<TipoDesenvolvedor> TipoDesenvolvedor { get; set; }
        public DbSet<Detalhe> Detalhe { get; set; }
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AmbienteMap());
            builder.ApplyConfiguration(new NegocioMap());
            builder.ApplyConfiguration(new ApiMap());
            builder.ApplyConfiguration(new ChamadoMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new ServidorMap());
            builder.ApplyConfiguration(new DesenvolvedorMap());
            builder.ApplyConfiguration(new TipoDesenvolvedorMap());
            builder.ApplyConfiguration(new DetalheMap());
        }
    }
}
