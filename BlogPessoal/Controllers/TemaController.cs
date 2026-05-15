using BlogPessoal.Models;
using BlogPessoal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogPessoal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TemaController : ControllerBase
    {
        private readonly ITemaService _temaService;

        public TemaController(ITemaService temaService)
        {
            _temaService = temaService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tema>>> BuscarTodos()
        {
            var temas = await _temaService.BuscarTodosAsync();
            return Ok(temas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tema>> BuscarPorId(int id)
        {
            var tema = await _temaService.BuscarPorIdAsync(id);

            if (tema == null)
            {
                return NotFound();
            }

            return Ok(tema);
        }

        [HttpPost]
        public async Task<ActionResult<Tema>> AdicionarTema(Tema tema)
        {
            if (tema == null)
            {
                return BadRequest("O tema não pode ser nulo.");
            }

            await _temaService.AdicionarTemaAsync(tema);

            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = tema.Id },
                tema);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarTema(int id, Tema tema)
        {
            if (id != tema.Id)
            {
                return BadRequest();
            }
            var temaExistente = await _temaService.BuscarPorIdAsync(id);

            if (temaExistente == null)
            {
                return NotFound();
            }
            await _temaService.AtualizarTemaAsync(tema);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarTema(int id)
        {
            var temaExistente = await _temaService.BuscarPorIdAsync(id);

            if (temaExistente == null)
            {
                return NotFound();
            }
            await _temaService.DeletarTemaAsync(id);
            return NoContent();

        }
    }
}


