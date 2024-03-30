using NeighborhoodSnacks.Context;
using NeighborhoodSnacks.Models;
using NeighborhoodSnacks.Repositories.Interfaces;

namespace NeighborhoodSnacks.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories => _context.Categories;
    }
}
