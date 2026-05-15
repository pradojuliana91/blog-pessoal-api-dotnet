using BlogPessoal.Models;

namespace BlogPessoal.Services;

public interface IUsuarioService
{
    Task<IEnumerable<Usuario>> BuscarTodosAsync();
    Task<Usuario?> BuscarPorIdAsync(int id);
    Task AdicionarUsuarioAsync(Usuario usuario);
    Task AtualizarUsuarioAsync(Usuario usuario);
    Task DeletarUsuarioAsync(int id);
}
