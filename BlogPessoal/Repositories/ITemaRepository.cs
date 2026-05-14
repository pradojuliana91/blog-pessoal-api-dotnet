using BlogPessoal.Models;

namespace BlogPessoal.Repositories
{
    public interface ITemaRepository
    {
        Task<IEnumerable<Tema>> BuscarTodosAsync();
        Task<Tema?> BuscarPorIdAsync(int id);
        Task AdicionarTemaAsync(Tema tema);
        Task AtualizarTemaAsync(Tema tema);
        Task DeletarTemaAsync(int id);
    }
}


