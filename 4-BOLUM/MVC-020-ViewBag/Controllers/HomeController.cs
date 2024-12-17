using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_020_ViewBag.Models;

namespace MVC_020_ViewBag.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Student = new Ogrenci()
        {
            Age = 22,
            Id = 1,
            Name = "Ozgur"
        };
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
