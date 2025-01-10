using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AsyncMetodlar_07.Models;

namespace AsyncMetodlar_07.Controllers;

public class HomeController : Controller
{
    public BookRepository repository;
    public HomeController()
    {
        repository = new BookRepository();
    }



    public async Task<IActionResult> Index()
    {
        var books = await repository.GetBookAsync();
        return View(books);
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
