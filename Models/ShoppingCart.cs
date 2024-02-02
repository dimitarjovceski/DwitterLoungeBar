using DwitterLoungeBar.Data;
using Microsoft.EntityFrameworkCore;

namespace DwitterLoungeBar.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext context;

        private ShoppingCart(AppDbContext context)
        {
            this.context = context;
        }
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }   

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            var session = services.GetRequiredService<IHttpContextAccessor>().HttpContext!.Session;

            var context = services.GetService<AppDbContext>();  
            var  cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context!) { ShoppingCartId = cartId };
        }

        public void AddToCart(Drink drink, int amount)
        {
            var shoppingCartItem = context.ShoppingCartItems.SingleOrDefault(p => p.Drink.DrinkId == drink.DrinkId
                && p.ShoppingCartId == ShoppingCartId);

            if(shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Amount = 1,
                    Drink = drink,
                };

                context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }

            context.SaveChanges();
        }

        public int RemoveFromCart(Drink drink)
        {
            var shoppingCartItem = context.ShoppingCartItems.SingleOrDefault(p => p.Drink.DrinkId == drink.DrinkId
               && p.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if(shoppingCartItem != null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    context.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            context.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return context.ShoppingCartItems.Where(p => p.ShoppingCartId == ShoppingCartId)
                .Include(x => x.Drink)
                .ToList();
        }

        public void ClearCart()
        {
            var cartItems = context.ShoppingCartItems.Where(p => p.ShoppingCartId == ShoppingCartId);

            context.ShoppingCartItems.RemoveRange(cartItems);
            context.SaveChanges();
        }

        public decimal GetShoppingCartTotal()
        {
            var total = context.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId)
                .Select(p => p.Drink.Price * p.Amount).Sum();

            return total;
        }
    }
}
