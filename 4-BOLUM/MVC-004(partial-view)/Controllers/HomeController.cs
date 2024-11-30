using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_004_partial_view_.Models;

namespace MVC_004_partial_view_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        IndexViewModel model = new IndexViewModel()
        {

            ImageUrl = "https://picsum.photos/200/300",
        };
        return View(model);

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
