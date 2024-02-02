using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IDrinkRepository drinkRepository;
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartController(IDrinkRepository drinkRepository, ShoppingCart shoppingCart)
        {
            this.drinkRepository = drinkRepository;
            this.shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = shoppingCart.GetShoppingCartItems(); 
            shoppingCart.ShoppingCartItems = items;

            var scvm = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal(),
            };

            return View(scvm);
        }

        public RedirectToActionResult AddToShoppingCart(int drinkId)
        {
            var selectedDrink = drinkRepository.GetDrinks().FirstOrDefault(x => x.DrinkId == drinkId);  

            if(selectedDrink != null)
            {
                shoppingCart.AddToCart(selectedDrink, 1);

            }

            return RedirectToAction ("Index");      
        }

        public RedirectToActionResult RemoveFromCart(int drinkId)
        {
            var selectedDrink = drinkRepository.GetDrinks().FirstOrDefault(x => x.DrinkId == drinkId);

            if(selectedDrink != null)
            {
                shoppingCart.RemoveFromCart(selectedDrink); 
            }

            return RedirectToAction ("Index");
        }
    }
}
