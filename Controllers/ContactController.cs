using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
