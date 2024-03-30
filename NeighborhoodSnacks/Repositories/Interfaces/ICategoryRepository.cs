using NeighborhoodSnacks.Models;

namespace NeighborhoodSnacks.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories { get; }
    }
}

