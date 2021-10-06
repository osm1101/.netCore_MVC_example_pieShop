using System.Collections.Generic;

namespace BethanysPieShop.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> AllCategories { get;}
    }
}