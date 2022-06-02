using ExoApi.Models;
using ExoApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoApi.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class ProjetoController : ControllerBase
    {
        private readonly ProjetoRepository _projetoRepository;

        public ProjetoController(ProjetoRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        /// <summary>
        /// Listar projetos cadastrados
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_projetoRepository.Listar());

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Busca um projeto por id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Projeto projeto = _projetoRepository.BuscarPorId(id);

                if (projeto == null)
                {
                    return NotFound();

                }
                return Ok(projeto);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cadastra um projeto.
        /// </summary>
        /// <param name="projeto"></param>
        /// <returns></returns>

        [HttpPost]

        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                _projetoRepository.Cadastrar(projeto);
                return StatusCode(201);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Atualiza um projeto.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projeto"></param>
        /// <returns></returns>

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Projeto projeto)
        {
            try
            {
                _projetoRepository.Atualizar(id, projeto);
                return StatusCode(204);

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Apaga um projeto.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _projetoRepository.Deletar(id);
                return StatusCode(204);

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
