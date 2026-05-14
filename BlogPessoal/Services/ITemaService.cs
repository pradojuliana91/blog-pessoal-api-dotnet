using BlogPessoal.Models;

namespace BlogPessoal.Services
{
    public interface ITemaService
    {
        Task<IEnumerable<Tema>> BuscarTodosAsync();
        Task<Tema?> BuscarPorIdAsync(int id);
        Task AdicionarTemaAsync(Tema tema);
        Task AtualizarTemaAsync(Tema tema);
        Task DeletarTemaAsync(int id);
    }
}


