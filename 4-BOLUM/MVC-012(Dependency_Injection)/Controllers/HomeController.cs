using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_012_Dependency_Injection_.Models;

namespace MVC_012_Dependency_Injection_.Controllers;

public class HomeController : Controller
{
    // bu interface tipinde bir degisken belirliyoruz (onemli!)
    public IHelper _helper;
    private readonly ILogger<HomeController> _logger;

    // ctor yaz
    public HomeController(IHelper helper)
    {
        this._helper = helper;
    }
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // klasik yontem : Helper sinifinin icindeki metodu kullanalim

        Helper help = new Helper();
        help.SayHello();
        // her kullandigimiz yerde boyle newlemeye kalkarsak ortalik cok karisir. 
        // bunu yapmamak icin DI(Dependency Injection) teknolojisini kullaniriz.

        // simdi yeni yontem ctor ile nesne ornegi aldik
        _helper.SayHello();


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
