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

                var x = await _ambienteRepositorio.PegarTodosTeste().ToListAsync();
//                var ambientes = await _ambienteRepositorio.PegarTodos().ToListAsync();
                return Ok(x);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Ambiente>>> ObterApiPorId(int Id)
        {
            try
            {
                var ambiente = await _ambienteRepositorio.ObterPorIdTeste(Id);

                return Ok(ambiente);
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpPut("Atualizar/{Id}")]
        public async Task<ActionResult<Servidor>> AtualizarAmbiente(Ambiente ambiente, int Id)
        {
            try
            {
                if (ambiente.AmbienteId == Id)
                {
                    var resultado = await _ambienteRepositorio.PegarPorId(Id);
                    resultado.Nome = ambiente.Nome;
                    resultado.ServidorId = ambiente.ServidorId;

                    await _ambienteRepositorio.Atualizar(resultado);

                    return Ok(new
                    {
                        mensagem = "Ambiente atualizado com sucesso"
                    });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

        [HttpPost()]
        public async Task<ActionResult<Ambiente>> AdicionarAmbiente(Ambiente ambiente)
        {
            try
            {
                await _ambienteRepositorio.Inserir(ambiente);

                return Ok(new
                {
                    mensagem = "O ambiente foi inserido com sucesso"
                });
            }
            catch (Exception)
            {
                return BadRequest(new
                {
                    mensagem = "Não foi possível inserir o ambiente"
                });
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Ambiente>> ExcluirAmbiente(int id)
        {
            try
            {
                var ambiente = await _ambienteRepositorio.PegarPorId(id);
                if(ambiente != null)
                {
                    await _ambienteRepositorio.Excluir(ambiente);
                    return Ok(new
                    {
                        mensagem = "O Ambiente foi excluído com sucesso"
                    });
                }

                return NotFound(new
                {
                    mensagem = "O Ambiente não foi encontrado"
                });
            }
            catch (Exception)
            {
                return BadRequest(new
                {
                    mensagem = "Não foi possível excluir o ambiente"
                });                
            }
        }


    }
}
