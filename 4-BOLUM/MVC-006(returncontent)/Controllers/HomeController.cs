using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_006_returncontent_.Models;

namespace MVC_006_returncontent_.Controllers;

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

    public IActionResult GetContent()
    {
        // bu action geriye direk string donecek, cshtml sayfasinda bu actionu cagirdigimiz yere /Home/GetContent yazdigimizda bu contenti getirecektir.
        // content bir view degildir, bu actiona gelindiginde ekranda sadece metin gorunecek
        // content ile her turlu veri gonderilir,
        // json verisini de gonderebilir ancak Json verisini gondermek icin Json() da return yapilir.
        // return Content("{\"message\":\"ben bir mesajim\"}");

        // ve ya bir modeli json formatinda gondermek icin
        // json tipine cevirdigimiz tipi Index viewda js fetch metodu ile kullaniriz.
        return Json(new IndexViewModel()
        {
            Description = " Piyasanin En iyisi",
            Name = "Klima",
            Id = 5
        });


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
