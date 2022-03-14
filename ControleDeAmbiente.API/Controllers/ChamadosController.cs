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
                    chamado.Ativo = true;
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
                        mensagem = $"Não foi possível alocar no Ambiente {1} a API {retorno.Api.Nome} - Chamado {retorno.Numero}"
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

                liberar.Numero = "";

                liberar.NegocioId = 1;

                liberar.AndroidId = 1;
                liberar.ChamadoAndroid = "";

                liberar.IosId = 1;
                liberar.ChamadoIos = "";
                
                liberar.WebId = 1;
                liberar.ChamadoWeb = "";

                liberar.ApiId = 1;               

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

        [HttpGet("Detalhes/{NumeroChamado}/{NomeAmbiente}")]
        public async Task<ActionResult<Chamado>> Detalhes(string NumeroChamado, string NomeAmbiente)
        {
            return await _chamadoRepositorio.Detalhes(NumeroChamado, NomeAmbiente);
        }

        [HttpGet("Alterar/{AmbienteId}/{ApiId}")]
        public async Task<ActionResult<Chamado>> ObterChamadoAmbienteApi(int AmbienteId, int ApiId)
        {
            try
            {
                var alterar = await _chamadoRepositorio.VerificarAlocacao(AmbienteId, ApiId);
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
              
                var retorno = await _chamadoRepositorio.VerificarAlocacao(chamado.AmbienteId, chamado.ApiId);

                if (retorno == null || retorno.AmbienteId == ambienteIdOld && retorno.ApiId == apiIdOld)
                {
                    var atualizar = await _chamadoRepositorio.PegarPorId(chamado.ChamadoId);
                    if (chamado.ChamadoId == Id)
                    {

                        atualizar.ChamadoId = chamado.ChamadoId;
                        atualizar.Numero = chamado.Numero;
                        atualizar.AmbienteId = chamado.AmbienteId;                        


                        atualizar.WebId = chamado.WebId;
                        atualizar.ChamadoWeb = chamado.ChamadoWeb;

                        atualizar.AndroidId = chamado.AndroidId;
                        atualizar.ChamadoAndroid = chamado.ChamadoAndroid;

                        atualizar.IosId = chamado.IosId;
                        atualizar.ChamadoIos = chamado.ChamadoIos;

                        atualizar.ApiId = chamado.ApiId;
                        atualizar.NegocioId = chamado.NegocioId;

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
                        mensagem = $"Não foi possível alocar no Ambiente {1} a API {retorno.Api.Nome} - Chamado {retorno.Numero}"
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
