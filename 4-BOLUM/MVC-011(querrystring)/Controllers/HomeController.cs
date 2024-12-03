using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_011_querrystring_.Models;

namespace MVC_011_querrystring_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    //  querry string ile gelen verileri parametre olarak alabiliriz., Key kisimlari (name ve lastname) ayni sekilde yazilmis olmali!
    // public IActionResult QuerryString(string name, string lastName)

    // model olarakta verebiliriz, modelin proplari yine ayni isimlendirme ile tanimlanmali.
    public IActionResult QuerryString(QuerryStringModel model)
    {
        return View();
    }

    public IActionResult Index()
    {
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
