using BlogPessoal.Models;
using BlogPessoal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogPessoal.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Usuario>>> BuscarTodos()
        {
            var usuarios = await _usuarioService.BuscarTodosAsync();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {
            var usuario = await _usuarioService.BuscarPorIdAsync(id);

            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> AdicionarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                return BadRequest("O usuário não pode ser nulo.");
            }

            await _usuarioService.AdicionarUsuarioAsync(usuario);

            return CreatedAtAction(
                nameof(BuscarPorId),
                new { id = usuario.Id },
                usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> AtualizarUsuario(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }

            var existeUsuario = await _usuarioService.BuscarPorIdAsync(id);

            if (existeUsuario == null)
            {
                return NotFound();
            }

            await _usuarioService.AtualizarUsuarioAsync(usuario);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletarUsuario(int id)
        {
            var existeUsuario = await _usuarioService.BuscarPorIdAsync(id);

            if (existeUsuario == null)
            {
                return NotFound();
            }
            await _usuarioService.DeletarUsuarioAsync(id);
            return NoContent();
        }
    }
}


