using DwitterLoungeBar.Data;
using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Category> Categories => context.Categories.ToList();
    }
}
