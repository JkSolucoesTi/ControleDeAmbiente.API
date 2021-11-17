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
    public class NegociosController : ControllerBase
    {
        private readonly INegocioRepositorio _negocioRepositorio;
        public NegociosController(INegocioRepositorio negocioRepositorio)
        {
            _negocioRepositorio = negocioRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Negocio>>> ObterAnalistaDeNegocio()
        {
            try
            {
                return Ok(await _negocioRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }
    }
}
