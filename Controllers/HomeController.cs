using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DwitterLoungeBar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            this.drinkRepository = drinkRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = drinkRepository.GetPreferredDrinks()
            };

            return View(homeViewModel);
        }
    }
}