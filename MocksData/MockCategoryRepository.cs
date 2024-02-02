using DwitterLoungeBar.Interfaces;
using DwitterLoungeBar.Models;

namespace DwitterLoungeBar.MocksData
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Alcoholic", Description = "All alcoholic drinks" },
                    new Category { CategoryName = "Non-alcoholic", Description = "All non-alcoholic drinks" }
                };
            }
        }
    }
}
