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

        [HttpDelete("Liberar/{NumeroChamado}")]
        public async Task<ActionResult<Chamado>> LiberarAmbiente(string NumeroChamado)
        {
            try
            {
                var chamado = await _chamadoRepositorio.Detalhes(NumeroChamado);
                chamado.Numero = "";
                chamado.Descricao = "Ambiente Liberado";
                chamado.NegocioId = 1;

                foreach(var detalhe in chamado.Detalhes)
                {
                    detalhe.DesenvolvedorId = 1;
                    detalhe.Numero = "";                    
                }

                chamado.Ativo = false;

              
                await _chamadoRepositorio.Atualizar(chamado);

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

        [HttpGet("Alterar/{chamadoId}")]
        public async Task<ActionResult<Chamado>> ObterChamadoAmbienteApi(int chamadoId)
        {
            try
            {
                var alterar = await _chamadoRepositorio.PegarPorId(chamadoId);
                return Ok(alterar);
            }
            catch (Exception)
            {
                return BadRequest();                
            }
        }

        [HttpPut("Alterar/{chamadoId}")]
        public async Task<ActionResult<Chamado>> AtualizarChamado(Chamado chamado ,int chamadoId)
        {
            try
            {

                var atualizar = await _chamadoRepositorio.PegarPorId(chamadoId);

                if (atualizar.ChamadoId == chamadoId)
                {
                    atualizar.Numero = chamado.Numero;
                    atualizar.AmbienteId = chamado.AmbienteId;
                    atualizar.Descricao = chamado.Descricao;

                    atualizar.Detalhes[0].DesenvolvedorId = chamado.Detalhes[0].DesenvolvedorId;
                    atualizar.Detalhes[0].Numero = chamado.Detalhes[0].Numero;

                    atualizar.Detalhes[1].DesenvolvedorId = chamado.Detalhes[1].DesenvolvedorId;
                    atualizar.Detalhes[1].Numero = chamado.Detalhes[1].Numero;

                    atualizar.Detalhes[2].DesenvolvedorId = chamado.Detalhes[2].DesenvolvedorId;
                    atualizar.Detalhes[2].Numero = chamado.Detalhes[2].Numero;

                    atualizar.Ativo = true;

                    await _chamadoRepositorio.Atualizar(atualizar);

                    return Ok(new
                    {
                        mensagem = "Chamado atualizado com sucesso"
                    });
                }
                else
                {
                    return Ok(new
                    {
                        codigo = 2,
                        mensagem = $"Não foi possível atualizar o chamado"
                    });
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        //[HttpGet("GerarExcel")]
        //public async Task<ActionResult<Chamado>> GerarExcel()
        //{
        //    try
        //    {
        //        var chamados = await _chamadoRepositorio.PegarTodos().ToListAsync();
        //        return Ok(chamados);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
