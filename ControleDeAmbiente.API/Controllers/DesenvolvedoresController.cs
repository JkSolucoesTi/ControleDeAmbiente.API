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
        private readonly IDesenvolvedorRepositorio _desenvolvedorRepositorio;
        private readonly ITipoDesenvolvedorRepositorio _tipoDesenvolvedorRepositorio;
        public DesenvolvedoresController(
            IDesenvolvedorRepositorio desenvolvedorRepositorio,
            ITipoDesenvolvedorRepositorio tipoDesenvolvedorRepositorio
            )
        {
            _desenvolvedorRepositorio = desenvolvedorRepositorio;
            _tipoDesenvolvedorRepositorio = tipoDesenvolvedorRepositorio;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Desenvolvedor>>> ObterDesenvolvedores()
        {
            try
            {
                return Ok(await _desenvolvedorRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<IEnumerable<Desenvolvedor>>> ObterDesenvolvedorPorId(int Id)
        {
            try
            {
                return Ok(await _desenvolvedorRepositorio.PegarPorId(Id));

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<Desenvolvedor>> ExcluirDesenvolvedor(int Id)
        {
            try
            {
                var desenvolvedor = await _desenvolvedorRepositorio.PegarPorId(Id);
                await _desenvolvedorRepositorio.Excluir(desenvolvedor);

                return Ok(new
                {
                    codigo = 1,
                    mensagem = "Desenvolvedor excluído com sucesso"
                });

            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }


        [HttpPost()]
        public async Task<ActionResult<Desenvolvedor>> AdicionarDesenvolvedor(Desenvolvedor desenvolvedor)
        {
            try
            {
                await _desenvolvedorRepositorio.Inserir(desenvolvedor);
                return Ok(new
                {
                    mensagem = "Desenvolvedor inserido com sucesso"
                });
            }
            catch (Exception)
            {
                return BadRequest(new
                {
                    mensagem = "Não foi possível adicionar o desenvolvedor"
                });
            }
        }

        [HttpGet("TipoDesenvolvedores")]
        public async Task<ActionResult<IEnumerable<TipoDesenvolvedor>>> ObterTipoDesenvolvedores()
        {
            try
            {
                return Ok(await _tipoDesenvolvedorRepositorio.PegarTodos().ToListAsync());
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }
        }
        [HttpPut("Atualizar/{Id}")]
        public async Task<ActionResult<Desenvolvedor>> AtualizarDesenvolvedor(Desenvolvedor desenvolvedor, int Id)
        {
            try
            {
                if (desenvolvedor.Id == Id)
                {
                    var desenvolvedorAtualizar = await _desenvolvedorRepositorio.PegarPorId(Id);
                    desenvolvedorAtualizar.Nome = desenvolvedor.Nome;
                    desenvolvedorAtualizar.Usuario = desenvolvedor.Usuario;
                    desenvolvedorAtualizar.Email = desenvolvedor.Email;
                    desenvolvedorAtualizar.TipoDesenvolvedorId = desenvolvedor.TipoDesenvolvedorId;

                    await _desenvolvedorRepositorio.Atualizar(desenvolvedorAtualizar);

                    return Ok(new
                    {
                        mensagem = "Desenvolvedor atualizado com sucesso"
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
