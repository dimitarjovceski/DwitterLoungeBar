using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }   
    }
}
