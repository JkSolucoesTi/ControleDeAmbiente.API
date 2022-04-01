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
    public class ServidoresController : ControllerBase
    {
        public readonly IServidorRepositorio _servidorRepositorio;

        public ServidoresController(IServidorRepositorio servidorRepositorio)
        {
            _servidorRepositorio = servidorRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Servidor>>> ObterServidores()
        {
            try
            {
                var servidores = await _servidorRepositorio.PegarTodosTeste();
                return Ok(servidores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Servidor>>> ObterApiPorId(int Id)
        {
            try
            {
                return Ok(await _servidorRepositorio.PegarPorId(Id));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpPut("Atualizar/{Id}")]
        public async Task<ActionResult<Servidor>> AtualizarServidor(Servidor servidor, int Id)
        {
            try
            {
                if (servidor.Id == Id)
                {
                    var resultado = await _servidorRepositorio.PegarPorId(Id);
                    resultado.Nome = servidor.Nome;
                    resultado.Dominio = servidor.Dominio;

                    await _servidorRepositorio.Atualizar(resultado);

                    return Ok(new
                    {
                        mensagem = "Servidor atualizado com sucesso"
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


        [HttpPost]
        public async Task<ActionResult<Servidor>> InserirServidor(Servidor servidor)
        {
            try
            {
                await _servidorRepositorio.Inserir(servidor);
                return Ok(new
                {
                    mensagem = "Servidor adicionado com sucesso"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

       [HttpDelete("{Id}")]
       public async Task<ActionResult<Servidor>> ExcluirServidor(int Id)
       {
           try
           {
               var servidor = await _servidorRepositorio.PegarPorId(Id);

               if (servidor != null)
               {
                   await _servidorRepositorio.Excluir(servidor);
                   return Ok(new
                   {
                       mensagem = "O servidor foi excluído com sucesso"
                   });
               }
               else
               {
                   return NotFound(new
                   {
                       mensagem = "O servidor não foi encontrado"
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
