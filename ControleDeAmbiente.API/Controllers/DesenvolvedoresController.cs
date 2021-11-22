using ControleDeAmbiente.API.ViewModel;
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

        [HttpPost("Android/Adicionar")]
        public async Task<ActionResult<Android>> AdicionarDesenvolvedorAndroid(Android desenvolvedor)
        {
            try
            {
                await _androidRepositorio.Inserir(desenvolvedor);
                return Ok(new
                {
                    mensagem = "Desenvolvedor Web Adicionado com sucesso"
                });

            }
            catch (Exception ex)
            {
                return BadRequest("Houve algums problema com sua chamada");
            }

        }

        [HttpPut("Android/Atualizar/{Id}")]
        public async Task<ActionResult<Android>> AtualizarDesenvolvedorWeb(Android android, int Id)
        {
            try
            {
                if (android.Id == Id)
                {
                    var desenvolvedor = await _androidRepositorio.PegarPorId(Id);
                    desenvolvedor.Nome = android.Nome;
                    desenvolvedor.Usuario = android.Usuario;
                    desenvolvedor.Email = android.Email;

                    await _androidRepositorio.Atualizar(desenvolvedor);

                    return Ok(new
                    {
                        mensagem = "Desenvolvedor Android atualizado com sucesso"
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



        [HttpGet("Web")]
        public async Task<ActionResult<IEnumerable<Web>>> ObterDesenvolvedorWeb()
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
        public async Task<ActionResult<IEnumerable<Web>>> ObterDesenvolvedorWebPorId(int Id)
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

        [HttpPost("Web/Adicionar")]
        public async Task<ActionResult<Web>> AdicionarDesenvolvedorWeb(Web desenvolvedor)
        {
            try
            {
                await _webRepositorio.Inserir(desenvolvedor);
                return Ok(new
                {
                    mensagem = "Desenvolvedor Web Adicionado com sucesso"
                });

            }
            catch (Exception ex)
            {
                return BadRequest("Houve algums problema com sua chamada");
            }

        }

        [HttpPut("Web/Atualizar/{Id}")]
        public async Task<ActionResult<Android>> AtualizarDesenvolvedorWeb(Web web, int Id)
        {
            try
            {
                if (web.Id == Id)
                {
                    var desenvolvedor = await _webRepositorio.PegarPorId(Id);
                    desenvolvedor.Nome = web.Nome;
                    desenvolvedor.Usuario = web.Usuario;
                    desenvolvedor.Email = web.Email;

                    await _webRepositorio.Atualizar(desenvolvedor);

                    return Ok(new
                    {
                        mensagem = "Desenvolvedor Web atualizado com sucesso"
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

        [HttpPost("Ios/Adicionar")]
        public async Task<ActionResult<Ios>> AdicionarDesenvolvedorIos(Ios desenvolvedor)
        {
            try
            {
                await _iosRepositorio.Inserir(desenvolvedor);
                return Ok(new
                {
                    mensagem = "Desenvolvedor Ios Adicionado com sucesso"
                });

            }
            catch (Exception ex)
            {
                return BadRequest("Houve algums problema com sua chamada");
            }

        }

        [HttpPut("Ios/Atualizar/{Id}")]
        public async Task<ActionResult<Ios>> AtualizarDesenvolvedorIos(Ios ios, int Id)
        {
            try
            {
                if (ios.Id == Id)
                {
                    var desenvolvedor = await _iosRepositorio.PegarPorId(Id);
                    desenvolvedor.Nome = ios.Nome;
                    desenvolvedor.Usuario = ios.Usuario;
                    desenvolvedor.Email = ios.Email;

                    await _iosRepositorio.Atualizar(desenvolvedor);

                    return Ok(new
                    {
                        mensagem = "Desenvolvedor IOS atualizado com sucesso"
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

    }
}
