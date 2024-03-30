using NeighborhoodSnacks.Models;

namespace NeighborhoodSnacks.Repositories.Interfaces
{
    public interface ISnackInterface
    {
        IEnumerable<Snacks> GetSnacks { get; }
        IEnumerable<Snacks> GetFavoriteSnack { get; }
        Snacks GetSnackById(int snackId);
    }
}

