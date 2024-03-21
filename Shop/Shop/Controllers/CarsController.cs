using Microsoft.AspNetCore.Mvc;
using shop.Data.Interfaces;
namespace Shop.Controllers;

public class CarsController : Controller 
{
    private readonly IAllCars _allCars;
    private readonly ICarsCategory _allCategories;

    public CarsController(IAllCars allCars, ICarsCategory carsCategory)
    {
        _allCars = allCars;
        _allCategories = carsCategory;
    }

    
    public ViewResult List()
    {
        CarsListViewModel _cars = new CarsListViewModel();
        _cars.allCars = _allCars.Cars;
        _cars.carCategory = "Cars";

        // ReSharper disable once Mvc.ViewNotResolved
        return View(_cars);
    }
}