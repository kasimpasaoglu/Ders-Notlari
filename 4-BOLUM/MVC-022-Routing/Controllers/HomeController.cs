using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_022_Routing.Models;

namespace MVC_022_Routing.Controllers;


[Route("Wissen")] // controller seviyesinde routing vermek, o controller icindeki tum actionlara istek yapilirken controllera verilen routing adinin kullanilmasi gerekmektedir. Ornek Wissen/[Cagirilacak action]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [Route("")]
    [Route("AnaSayfa")] // artik index sayfasini cagirken anasayfa diye cagirmak gerekecek
    public IActionResult Index()
    {
        return View();
    }

    [Route("{id}")] // bu sekilde bir routing verilirse adres cubugune action adini yazmak yerine bir id parametresi gonderilebilir. 
    // bu sekildeki routingler genelde seo icin daha iyidir
    public IActionResult Privacy(int id)
    {
        return Content(id + " degeri gonderildi");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


    [Route("blog/{year}/{month}/{title}")] // birden fazla parametre ile routing yapmak
    public IActionResult Article(int year, int month, string title)
    {
        return Content($"Year: {year} Month: {month} Title: {title}");
    }


    // default deger ile, hic bir parametre verilmezse alacagi parametre belirlenebilir
    [Route("ProductDetail/{productname=Ball}")] // default deger verildi. Eger /Wissen/ProductDetail adresine gidilirse ekranda Ball yazacaktir, eger deger gonderilirse default deger ezilir gelen degeri alir.
    public IActionResult ProductDetail(string productName)
    {
        return Content($"{productName}");
    }

    // alinacak parametreyi belli bir tipte olmaya zorlama
    [Route("Non3D/{bankId:int}")]
    public IActionResult Pay(int bankId)
    {
        return Content($"{bankId}");
    }

}
