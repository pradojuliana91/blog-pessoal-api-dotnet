using BlogPessoal.Models;
using BlogPessoal.Repositories;

namespace BlogPessoal.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IEnumerable<Usuario>> BuscarTodosAsync()
        {
            return await _usuarioRepository.BuscarTodosAsync();
        }

        public async Task<Usuario?> BuscarPorIdAsync(int id)
        {
            return await _usuarioRepository.BuscarPorIdAsync(id);
        }

        public async Task AdicionarUsuarioAsync(Usuario usuario)
        {
            var existeUsuario = await _usuarioRepository.BuscarPorEmailAsync(usuario.Email);

            if (existeUsuario != null)
            {
                throw new ArgumentException("Email já cadastrado.");
            }

            await _usuarioRepository.AdicionarUsuarioAsync(usuario);
        }

        public async Task AtualizarUsuarioAsync(Usuario usuario)
        {
            await _usuarioRepository.AtualizarUsuarioAsync(usuario);
        }

        public async Task DeletarUsuarioAsync(int id)
        {
            await _usuarioRepository.DeletarUsuarioAsync(id);
        }
    }
}


