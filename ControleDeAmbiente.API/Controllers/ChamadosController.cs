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
                var retorno = await _chamadoRepositorio.VerificarAlocacao(chamado.AmbienteId);

                if (retorno == null)
                {
                    chamado.Ativo = true;
                    await _chamadoRepositorio.Inserir(chamado);

                    return Ok(new
                    {
                        codigo = 1,
                        mensagem = $"Chamado adicionado com sucesso"
                    });
                }
                else
                {
                    return BadRequest(new
                    {
                        codigo = 2,
                        mensagem = $"Não foi possível alocar o chamado {retorno.Numero} no ambiente {retorno.Ambiente.Nome}"
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

                var liberar = await _chamadoRepositorio.VerificarAlocacao(AmbienteId);
                liberar.Numero = "";
                liberar.Descricao = "";

                liberar.Ativo = false;


                await _chamadoRepositorio.Atualizar(liberar);

                return Ok(new
                {
                    mensagem = "Ambiente liberado com sucesso"
                });

            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("Detalhes/{NumeroChamado}")]
        public async Task<ActionResult<Chamado>> Detalhes(string NumeroChamado)
        {
            try
            {
                var detalhes = await _chamadoRepositorio.Detalhes(NumeroChamado);
                return detalhes;

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Alterar/{AmbienteId}/{ApiId}")]
        public async Task<ActionResult<Chamado>> ObterChamadoAmbienteApi(int AmbienteId, int ApiId)
        {
            try
            {
                var alterar = await _chamadoRepositorio.VerificarAlocacao(AmbienteId);
                return Ok(alterar);
            }
            catch (Exception)
            {
                return BadRequest();                
            }
        }

        [HttpPut("Alterar/{ambienteIdOld}/{apiIdOld}/{Id}")]
        public async Task<ActionResult<Chamado>> AtualizarChamado(Chamado chamado ,int ambienteIdOld, int apiIdOld ,int Id)
        {
            try
            {
              
                var retorno = await _chamadoRepositorio.VerificarAlocacao(chamado.AmbienteId);

                if (retorno == null || retorno.AmbienteId == ambienteIdOld)
                {
                    var atualizar = await _chamadoRepositorio.PegarPorId(chamado.ChamadoId);
                    if (chamado.ChamadoId == Id)
                    {

                        atualizar.ChamadoId = chamado.ChamadoId;
                        atualizar.Numero = chamado.Numero;
                        atualizar.AmbienteId = chamado.AmbienteId;                        
                        atualizar.Descricao = chamado.Descricao;

                        atualizar.Ativo = true;

                        await _chamadoRepositorio.Atualizar(atualizar);

                        return Ok(new
                        {
                            mensagem = "Chamado atualizado com sucesso"
                        });
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                else
                {
                    return Ok(new
                    {
                        codigo = 2,
                        mensagem = $"Não foi possível alocar no Ambiente {1} a API - Chamado {retorno.Numero}"
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
