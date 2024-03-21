using shop.Data.Models;
using shop.Data.Interfaces;

public class MockCategory : ICarsCategory {
    public IEnumerable<Category> AllCategories {
        get {
            return new List<Category> {
                new Category{categoryName = "Electric cars", desc = "Modern from of transport"},
                new Category{categoryName = "Sedans", desc = "Sedan"},
                new Category{categoryName = "Super cars", desc = "Very fast cars"},
                new Category{categoryName = "Crossovers", desc = "Fast and family  cars"},
            };
        }
    }
}