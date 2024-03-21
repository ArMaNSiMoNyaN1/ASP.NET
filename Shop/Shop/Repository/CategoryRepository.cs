using shop.Data;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Repository;

public class CategoryRepository : ICarsCategory
{
    private readonly AppDBContent _appDbContent;

    public CategoryRepository(AppDBContent _appDbContent)
    {
        this._appDbContent = _appDbContent;
    }


    public IEnumerable<Category> AllCategories => _appDbContent.Category;
}