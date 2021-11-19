using ControleDeAmbiente.API.ViewModel;
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

    public class AmbientesController : ControllerBase
    {
        private readonly IAmbienteRepositorio _ambienteRepositorio;

        public AmbientesController(IAmbienteRepositorio ambienteRepositorio)
        {
            _ambienteRepositorio = ambienteRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Ambiente>>> ObterAmbientes()
        {
            try
            {
                var ambientes = await _ambienteRepositorio.PegarTodos().ToListAsync();
                return Ok(ambientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("PegarPorId/{Id}")]
        public async Task<ActionResult<Ambiente>> PegarPorId(int Id)
        {
            try
            {
                var ambientes = await _ambienteRepositorio.PegarPorId(Id);
                return Ok(ambientes);

            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost()]
        public async Task<ActionResult<Ambiente>> Inserir(AmbienteViewModel ambiente)
        {
            try
            {
                var novoAmbiente = new Ambiente
                {
                    Nome = ambiente.Nome,
                    Descricao = ambiente.Descricao,
                    Chamado = ambiente.Chamado,
                    AndroidId = ambiente.AndroidId,
                    WebId = ambiente.ApiId,
                    IosId = ambiente.IosId,
                    NegocioId = ambiente.NegocioId
                    
                };

                await _ambienteRepositorio.Inserir(novoAmbiente);

                return Ok(new
                {
                    mensagem = "Ambiente adicionado com sucesso"
                });

            } catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<Ambiente>> Atualizar(AmbienteViewModel ambiente , int Id)
        {
            try
            {
                if(ambiente.Id == Id)
                {
                    var atualizarAmbiente = await _ambienteRepositorio.PegarPorId(Id);

                    atualizarAmbiente.Nome = ambiente.Nome;
                    atualizarAmbiente.Descricao = ambiente.Descricao;
                    atualizarAmbiente.Chamado = ambiente.Chamado;
                    atualizarAmbiente.AndroidId = ambiente.AndroidId;
                    atualizarAmbiente.IosId = ambiente.IosId;
                    atualizarAmbiente.WebId = ambiente.ApiId;
                    atualizarAmbiente.NegocioId = ambiente.NegocioId;

                    await _ambienteRepositorio.Atualizar(atualizarAmbiente);

                    return Ok(
                        new
                        {
                            mensagem = "Ambiente atualizado com sucesso"
                        });
                }else
                {
                    return NotFound(
                        new
                        {
                            mensagem = "Ambiente não encontrado"
                        });
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut("LiberarAmbiente/{Id}")]
        public async Task<ActionResult<Ambiente>> LiberarAmbiente(AmbienteViewModel ambiente, int Id)
        {
            try
            {
                if (ambiente.Id == Id)
                {
                    var atualizarAmbiente = await _ambienteRepositorio.PegarPorId(Id);
                    
                    atualizarAmbiente.Descricao = "Ambiente Disponível";
                    atualizarAmbiente.Chamado = "";
                    atualizarAmbiente.AndroidId = 1;
                    atualizarAmbiente.IosId = 1;
                    atualizarAmbiente.WebId = 1;
                    atualizarAmbiente.NegocioId = 1;

                    await _ambienteRepositorio.Atualizar(atualizarAmbiente);

                    return Ok(
                        new
                        {
                            mensagem = "Ambiente liberado com sucesso"
                        });
                }
                else
                {
                    return NotFound(
                        new
                        {
                            mensagem = "Ambiente não encontrado"
                        });
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
