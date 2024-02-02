using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.ViewModels
{
    public class DrinkListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public string CurrentCategory { get; set; } = string.Empty;
    }
}
