using shop.Data.Models;

namespace shop.Data.Interfaces;

public interface ICarsCategory
{
    IEnumerable<Category> AllCategories {get;}
}