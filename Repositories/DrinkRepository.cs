using DwitterLoungeBar.Data;
using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using Microsoft.EntityFrameworkCore;

namespace DwitterLoungeBar.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext context;

        public DrinkRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Drink GetDrinkById(int id)
        {
            return context.Drinks.FirstOrDefault(x => x.DrinkId == id);
        }

        public IEnumerable<Drink> GetDrinks()
        {
            return context.Drinks.Include(p => p.Category).ToList();
        }

        public IEnumerable<Drink> GetPreferredDrinks()
        {
            return context.Drinks.Include(p => p.Category).Where(x => x.IsPreferredDrink).ToList(); 
        }
    }
}
