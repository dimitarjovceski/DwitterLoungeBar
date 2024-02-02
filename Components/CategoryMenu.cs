using DwitterLoungeBar.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DwitterLoungeBar.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = categoryRepository.Categories.OrderBy(p => p.CategoryName).ToList();   
            return View(categories);    
        }
    }
}
