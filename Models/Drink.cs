using System.ComponentModel;

namespace DwitterLoungeBar.Models
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string ImageThumbnailUrl { get; set; } = string.Empty;
        public bool IsPreferredDrink { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}
