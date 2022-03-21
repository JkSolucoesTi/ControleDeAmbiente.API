using ControleDeAmbiente.BLL.Model;
using ControleDeAmbiente.DAL.Interfaces;
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
        public async Task<ActionResult<Usuario>> Logar(Usuario usuario)
        {
            try
            {
                if (usuario == null)
                {
                    return BadRequest( new { 
                    
                        mensagem = "Não foi possível identificar o usuário"
                    });
                }

                var usuarioLogado = _usuarioRepositorio.Login(usuario.Login, usuario.Senha);

                if (usuarioLogado.Result != null)
                {
                    return Ok(new
                    {
                        mensagem = "Api adicionada com sucesso",
                        usuario = usuarioLogado
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
