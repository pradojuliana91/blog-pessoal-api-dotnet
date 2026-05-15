using BlogPessoal.Models;

namespace BlogPessoal.Repositories
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscarTodosAsync();
        Task<Usuario?> BuscarPorIdAsync(int id);
        Task<Usuario?> BuscarPorEmailAsync(string email);
        Task AdicionarUsuarioAsync(Usuario usuario);
        Task AtualizarUsuarioAsync(Usuario usuario);
        Task DeletarUsuarioAsync(int id);
    }
}


