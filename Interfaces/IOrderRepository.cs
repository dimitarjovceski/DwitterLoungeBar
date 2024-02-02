using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;

namespace DwitterLoungeBar.Interfaces
{
    public interface IOrderRepository
    {
        public void CreateOrder(Order order);
    }
}
