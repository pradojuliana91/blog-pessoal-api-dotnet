using BlogPessoal.Models;
using BlogPessoal.Repositories;

namespace BlogPessoal.Services
{
    public class TemaService : ITemaService
    {
        private readonly ITemaRepository _temaRepository;

        public TemaService(ITemaRepository temaRepository)
        {
            _temaRepository = temaRepository;
        }

        public async Task<IEnumerable<Tema>> BuscarTodosAsync()
        {
            return await _temaRepository.BuscarTodosAsync();
        }

        public async Task<Tema?> BuscarPorIdAsync(int id)
        {
            return await _temaRepository.BuscarPorIdAsync(id);
        }

        public async Task AdicionarTemaAsync(Tema tema)
        {
            await _temaRepository.AdicionarTemaAsync(tema);
        }

        public async Task AtualizarTemaAsync(Tema tema)
        {
            await _temaRepository.AtualizarTemaAsync(tema);
        }

        public async Task DeletarTemaAsync(int id)
        {
            await _temaRepository.DeletarTemaAsync(id);
        }
    }

}
