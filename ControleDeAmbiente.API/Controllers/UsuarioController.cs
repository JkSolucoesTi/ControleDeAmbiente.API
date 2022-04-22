using ControleDeAmbiente.API.Services;
using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeAmbiente.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpPost("LoginUsuario")]
        public async Task<ActionResult> Logar(Usuario usuario)
        {
            try
            {

                var usuarioLogado = await _usuarioRepositorio.Login(usuario.Login, usuario.Senha);

                if (usuarioLogado != null)
                {

                    var token = TokenService.GerarToken(usuarioLogado, usuarioLogado.Perfil);

                    return Ok(new
                    {
                        email = usuarioLogado.Email,
                        perfil = usuarioLogado.Perfil,
                        usuario = usuarioLogado.Nome,
                        token = token
                    });
                }
                else
                {
                    return BadRequest( new
                    {
                        mensagem = "Usuario ou Senha inválidos",
                        code = 400
                    });
                }
            }
            catch (Exception ex)
            {

                return NotFound(ex.ToString());
            }


        }
    }
}
