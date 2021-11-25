using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChamadosController : ControllerBase
    {
        private readonly IChamadoRepositorio _chamadoRepositorio;
        public ChamadosController(IChamadoRepositorio chamadoRepositorio)
        {
            _chamadoRepositorio = chamadoRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Chamado>>> ObterChamados()
        {
            try
            {
                var ambientes = await _chamadoRepositorio.PegarTodos().ToListAsync();
                return Ok(ambientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
        [HttpPost("Adicionar")]
        public async Task<ActionResult<Chamado>> AdicionarChamado(Chamado chamado)
        {
            try
            {
                var retorno = await _chamadoRepositorio.VerificarAlocacao(chamado.AmbienteId, chamado.ApiId);

                if (retorno == null)
                {
                    await _chamadoRepositorio.Inserir(chamado);

                    return Ok(new
                    {
                        codigo = 1,
                        mensagem = $"Ambiente adicionado com sucesso"
                    });
                }
                else
                {
                    return Ok(new
                    {
                        codigo = 2,
                        mensagem = $"Não foi possível alocar no Ambiente {retorno.Ambiente.Nome} a API {retorno.Api.Nome} - Chamado {retorno.Numero}"
                    });
                }

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

            [HttpDelete("Liberar/{AmbienteId}/{ApiId}")]
            public async Task<ActionResult<Chamado>> LiberarAmbiente(int AmbienteId, int ApiId)
            {
                try
                {

                    var liberar = await _chamadoRepositorio.VerificarAlocacao(AmbienteId, ApiId);

                    await _chamadoRepositorio.Excluir(liberar);

                    return Ok( new
                    {
                        mensagem = "Ambiente liberado com sucesso"
                    });

                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
    }    
}
