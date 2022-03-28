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
                var servidores = await _servidorRepositorio.PegarTodos().ToListAsync();
                return Ok(servidores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
