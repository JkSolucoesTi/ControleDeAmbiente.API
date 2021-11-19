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
    public class DesenvolvedoresController : ControllerBase
    {
        private readonly IAndroidRepositorio _androidRepositorio;
        private readonly IWebRepositorio _webRepositorio;
        private readonly IIosRepositorio _iosRepositorio;

        public DesenvolvedoresController(
            IAndroidRepositorio androidRepositorio,
            IWebRepositorio webRepositorio,
            IIosRepositorio iosRepositorio            
            )
        {
            _androidRepositorio = androidRepositorio;
            _webRepositorio = webRepositorio;
            _iosRepositorio = iosRepositorio;
        }

        [HttpGet("Android")]
        public async Task<ActionResult<IEnumerable<Android>>> ObterDesenvolvedorAndroid()
        {
            try
            {
                return Ok(await _androidRepositorio.PegarTodos().ToListAsync());

               }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("Android/{Id}")]
        public async Task<ActionResult<IEnumerable<Android>>> ObterDesenvolvedorAndroidPorId(int Id)
        {
            try
            {
                return Ok(await _androidRepositorio.PegarPorId(Id));

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("Web")]
        public async Task<ActionResult<IEnumerable<Web>>> ObterDesenvolvedorApi()
        {
            try
            {
                return Ok(await _webRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("Web/{Id}")]
        public async Task<ActionResult<IEnumerable<Web>>> ObterDesenvolvedorWevPorId(int Id)
        {
            try
            {
                return Ok(await _webRepositorio.PegarPorId(Id));

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }


        [HttpGet("Ios")]
        public async Task<ActionResult<IEnumerable<Ios>>> ObterDesenvolvedorIos()
        {
            try
            {
                return Ok(await _iosRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("Ios/{Id}")]
        public async Task<ActionResult<IEnumerable<Ios>>> ObterDesenvolvedorIosPorId(int Id)
        {
            try
            {
                return Ok(await _iosRepositorio.PegarPorId(Id));

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }


    }
}
