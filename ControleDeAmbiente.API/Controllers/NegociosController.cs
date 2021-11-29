using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegociosController : ControllerBase
    {
        private readonly INegocioRepositorio _negocioRepositorio;
        public NegociosController(INegocioRepositorio negocioRepositorio)
        {
            _negocioRepositorio = negocioRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Negocio>>> ObterAnalistaDeNegocio()
        {
            try
            {
                return Ok(await _negocioRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Negocio>>> ObterAnalistaDeNegocioPorId(int Id)
        {
            try
            {
                return Ok(await _negocioRepositorio.PegarPorId(Id));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpPost("Adicionar")]
        public async Task<ActionResult<IEnumerable<Negocio>>> AdicionarAnalistaDeNegocio(Negocio negocio)
        {
            try
            {
                await _negocioRepositorio.Inserir(negocio);

                return Ok(new
                {
                    mensagem = "Analista de negocio adicionado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpPut("Atualizar/{Id}")]
        public async Task<ActionResult<Negocio>> AtualizarAnalistaDeNegocio(Negocio negocio, int Id)
        {
            try
            {
                if (negocio.Id == Id)
                {
                    var resultado = await _negocioRepositorio.PegarPorId(Id);

                    resultado.Nome = negocio.Nome;
                    resultado.Email = negocio.Email;

                    await _negocioRepositorio.Atualizar(resultado);

                    return Ok(new
                    {
                        mensagem = "Analista de Negocio atualizado com sucesso"
                    });

                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Negocio>> ExcluirAnalistaDeNegocio(int Id)
        {
            try
            {
                var analista = await _negocioRepositorio.PegarPorId(Id);
                if (analista != null)
                {
                    await _negocioRepositorio.Excluir(analista);
                    return Ok(new
                    {
                        mensagem = "Analista de Negocio excluído"
                    });
                }
                else
                {
                    return NotFound(new
                    {
                        mensagem = "Analista de negocio não encontrado"
                    });
                }

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
