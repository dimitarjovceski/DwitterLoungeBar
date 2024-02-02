using DwitterLoungeBar.Data;
using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext context;
        private readonly ShoppingCart shoppingCart;

        public OrderRepository(AppDbContext context, ShoppingCart shoppingCart)
        {
            this.context = context;
            this.shoppingCart = shoppingCart;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;   
            context.Orders.Add(order);  

            var shoppingCartItems = shoppingCart.ShoppingCartItems;

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    DrinkId = item.Drink.DrinkId,
                    Amount = item.Amount,
                    Price = item.Drink.Price,
                };
                context.OrderDetails.Add(orderDetail);  
            }

            context.SaveChanges();  
        }
    }
}
