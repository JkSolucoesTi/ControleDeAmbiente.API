﻿using ControleDeAmbiente.API.ViewModel;
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
                var ambientes = await _ambienteRepositorio.PegarTodosTeste();
                return Ok(ambientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
