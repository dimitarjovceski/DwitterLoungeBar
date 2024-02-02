using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;
using DwitterLoungeBar.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Controllers
{
    public class OrderController : Controller
    {
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
