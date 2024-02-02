using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            this.shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = shoppingCart.GetShoppingCartItems();    
            shoppingCart.ShoppingCartItems = items;

            var shoppingCartVm = new ShoppingCartViewModel
            {
                ShoppingCart = shoppingCart,
                ShoppingCartTotal = shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartVm);
        }
    }
}
