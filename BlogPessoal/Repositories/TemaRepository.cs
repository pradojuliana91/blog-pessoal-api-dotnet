using BlogPessoal.Data;
using BlogPessoal.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPessoal.Repositories
{
    public class TemaRepository : ITemaRepository
    {
        private readonly AppDbContext _context;

        public TemaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tema>> BuscarTodosAsync()
        {
            return await _context.Temas.ToListAsync();
        }

        public async Task<Tema?> BuscarPorIdAsync(int id)
        {
            return await _context.Temas.FindAsync(id);
        }

        public async Task AdicionarTemaAsync(Tema tema)
        {
            await _context.Temas.AddAsync(tema);
            await _context.SaveChangesAsync();
        }

        public async Task AtualizarTemaAsync(Tema tema)
        {
            _context.Temas.Update(tema);
            await _context.SaveChangesAsync();
        }

        public async Task DeletarTemaAsync(int id)
        {
            var tema = await _context.Temas.FindAsync(id);
            if (tema != null)
            {
                _context.Temas.Remove(tema);
                await _context.SaveChangesAsync();
            }
        }
    }
}


