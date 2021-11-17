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
        private readonly IApiRepositorio _apiRepositorio;
        private readonly IIosRepositorio _iosRepositorio;

        public DesenvolvedoresController(
            IAndroidRepositorio androidRepositorio,
            IApiRepositorio apiRepositorio,
            IIosRepositorio iosRepositorio            
            )
        {
            _androidRepositorio = androidRepositorio;
            _apiRepositorio = apiRepositorio;
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

        [HttpGet("Api")]
        public async Task<ActionResult<IEnumerable<Api>>> ObterDesenvolvedorApi()
        {
            try
            {
                return Ok(await _apiRepositorio.PegarTodos().ToListAsync());
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


    }
}
