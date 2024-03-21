using System.Data.Entity;
using shop.Data;
using shop.Data.Interfaces;
using shop.Data.Models;

namespace shop.Repository;

public class CarRepository: IAllCars
{
    private readonly AppDBContent _appDbContent;
    
    public CarRepository(AppDBContent _appDbContent) {
        this._appDbContent = _appDbContent;
    }

    public IEnumerable<Category> AllCategories => _appDbContent.Category;

    public IEnumerable<Car> Cars { get; }
    public IEnumerable<Car> getFavCars { get; }
    public Car getObjectCar(int carId)
    {
        throw new NotImplementedException();
    }
}