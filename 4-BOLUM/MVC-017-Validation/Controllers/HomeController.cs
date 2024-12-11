using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_017_Validation.Models;

namespace MVC_017_Validation.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(UserVM model)
    {
        bool isOk = ModelState.IsValid; // model uzerinde yaptigimiz valisayon isleminden gecip gecmedigini gormek icin
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
