using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_001.Models;

namespace MVC_001.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>(){
            new Ogrenci {Id=1, Name="Ahmet"},
            new Ogrenci {Id=2, Name="Mehmet"},
            new Ogrenci {Id=3, Name="Veli"}
        };
        return View(ogrenciler);
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
