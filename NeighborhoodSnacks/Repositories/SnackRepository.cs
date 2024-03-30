using Microsoft.EntityFrameworkCore;
using NeighborhoodSnacks.Context;
using NeighborhoodSnacks.Models;
using NeighborhoodSnacks.Repositories.Interfaces;

namespace NeighborhoodSnacks.Repositories
{
    public class SnackRepository : ISnackInterface
    { 
        private readonly AppDbContext _context;
        public SnackRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Snacks> GetSnacks => _context.Snacks.Include(c => c.Category);

        public IEnumerable<Snacks> GetFavoriteSnack => _context.Snacks.Where(p => p.IsFavoriteSnack).Include(c => c.Category);

        public Snacks GetSnackById(int snackId) => _context.Snacks.FirstOrDefault(s => s.SnacksId == snackId);
        
    }
}
