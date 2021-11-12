using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAmbiente.DAL.Repositorio
{
    public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
    {
        private readonly Contexto _contexto;

        public RepositorioGenerico(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IQueryable<TEntity> PegarTodos()
        {
            try
            {
                return _contexto.Set<TEntity>();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Atualizar(TEntity entity)
        {
            try
            {
                var registro = _contexto.Set<TEntity>().Update(entity);
                registro.State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<TEntity> PegarPorId(int Id)
        {
            try
            {
                var registro = await _contexto.Set<TEntity>().FindAsync(Id);
                return registro;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public async Task Inserir(TEntity entity)
        {
            try
            {
                await _contexto.Set<TEntity>().AddAsync(entity);
                await _contexto.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
