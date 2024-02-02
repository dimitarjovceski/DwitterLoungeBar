using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.Interfaces
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> GetDrinks();
        IEnumerable<Drink> GetPreferredDrinks();
        Drink GetDrinkById(int id);    
    }
}
