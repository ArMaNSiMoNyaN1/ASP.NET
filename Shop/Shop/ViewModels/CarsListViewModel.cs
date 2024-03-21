using shop.Data.Models;

public class CarsListViewModel {
    public IEnumerable<Car> allCars { get; set; }

    public string carCategory { get; set; }
}