using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleDeAmbiente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmbienteChamadoController : ControllerBase
    {
        private readonly IAmbienteChamadoRepositorio _ambienteChamadoRepositorio;
        public AmbienteChamadoController(IAmbienteChamadoRepositorio ambienteChamadoRepositorio)
        {
            _ambienteChamadoRepositorio = ambienteChamadoRepositorio;
        }
        // GET: api/<AmbienteChamadoController>
        [HttpGet]
        public IEnumerable<AmbienteChamado> Get()
        {
            try
            {
               return _ambienteChamadoRepositorio.PegarTodosTeste().ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<AmbienteChamado>> Post(AmbienteChamado ambienteChamado)
        {
            try
            {
                await _ambienteChamadoRepositorio.Inserir(ambienteChamado);

                return Ok(new
                {
                    Codigo = 1,
                    mensagem = "Teste ok"
                });
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
