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
    public class ApiController : ControllerBase
    {
        private readonly IApiRepositorio _apiRepositorio;
        public ApiController(IApiRepositorio apiRepositorio)
        {
            _apiRepositorio = apiRepositorio;
        }


        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Api>>> ObterApi()
        {
            try
            {
                return Ok (await _apiRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Api>>> ObterApiPorId(int Id)
        {
            try
            {
                return Ok(await _apiRepositorio.PegarPorId(Id));
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }


        [HttpPut("Atualizar/{Id}")]
        public async Task<ActionResult<Api>> AtualizarApi(Api api, int Id)
        {
            try
            {
                if(api.Id == Id)
                {
                    var resultado = await _apiRepositorio.PegarPorId(Id);
                    resultado.Nome = api.Nome;
                    resultado.Descricao = api.Descricao;

                    await _apiRepositorio.Atualizar(resultado);

                    return Ok(new
                    {
                        mensagem = "Api atualizada com sucesso"
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

        [HttpPost("Adicionar")]
        public async Task<ActionResult<Api>> AdicionarApi(Api api)
        {
            try
            {
               await _apiRepositorio.Inserir(api);

                return Ok(new
                {
                    mensagem = "Api adicionada com sucesso"
                });
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }
    }
}
