using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_007_dropdown_.Models;

namespace MVC_007_dropdown_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // dropdowna yuklemek icin modeli hazirlayalim
        var cars = new List<Car>
        {
            new Car(){Id = 1, Name="Audi"},
            new Car(){Id = 2, Name="BMW"},
            new Car(){Id = 3, Name="Mercedes"},
            new Car(){Id = 4, Name="Peugeot"},
            new Car(){Id = 5, Name="Toyota"},
            new Car(){Id = 6, Name="Fiat"},
            new Car(){Id = 7, Name="Skoda"},
        };
        return View(new DropdownViewModel() { Cars = cars });
    }

    [HttpPost]
    public IActionResult Index(DropdownViewModel model)
    {
        // dropdown dan secilen deger secildikten sonra submite'e basildiginda, view model action'a gelir
        // ve icinde dropdowndan yapilan secime ait id degerini tasir.
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
