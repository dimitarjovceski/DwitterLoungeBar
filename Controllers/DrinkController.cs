using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Controllers
{
    public class DrinkController : Controller
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IDrinkRepository drinkRepository;

        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            this.categoryRepository = categoryRepository;
            this.drinkRepository = drinkRepository;
        }
        public IActionResult Index(string category)
        {
            string _category = category;
            IEnumerable<Drink> drinks;

            string currentCategory = string.Empty;

            if(string.IsNullOrEmpty(category))
            {
                drinks = drinkRepository.GetDrinks().OrderBy(p => p.DrinkId);
                currentCategory = "All drinks";
            }
            else
            {
                if(_category == "Alcoholic")
                {
                    drinks = drinkRepository.GetDrinks().Where(p => p.Category.CategoryName == "Alcoholic").OrderBy(p => p.DrinkId);
                }
                else
                    drinks = drinkRepository.GetDrinks().Where(p => p.Category.CategoryName == "Non-alcoholic").OrderBy(p => p.DrinkId);


                currentCategory = category;
            }

            var drinkListVM = new DrinkListViewModel
            {
                Drinks = drinks,
                CurrentCategory = currentCategory
            };

            return View(drinkListVM);
        }
    }
}
