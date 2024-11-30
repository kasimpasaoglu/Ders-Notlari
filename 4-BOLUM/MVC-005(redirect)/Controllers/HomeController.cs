using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_005_redirect_.Models;

namespace MVC_005_redirect_.Controllers;

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
    public IActionResult Index(HomeViewModel model)
    {
        if (model.Name == "Hakan")
        {
            // bir actiondan baska bir actiona yonlendirme yapma
            // direk action name verilip bu kismin icine gelen derleyici direk RedirectAction actionuna gidecek
            // bu sekilde sadece ayni controller icindeki bir actiona yonlendirme yapilir.
            // return RedirectToAction("RedirectedAction");
            // farkli bir controllerdaki actiona yonlendirmek icin
            // return RedirectToAction("Index", "Wissen");

            //redirect to action ile parametre transferi yapilabilir
            return RedirectToAction("ParametreAlan", new { name = model.Name });
        }
        else return View();

    }
    public IActionResult ParametreAlan(string name)
    {
        return View("ParametreAlan", name);
    }

    public IActionResult RedirectedAction()
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
