using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using calisma.Models;

namespace calisma.Controllers;

public class HomeController : Controller
{
    private IBooksService _service;
    public HomeController(IBooksService service)
    {
        _service = service;
    }

    public IActionResult Index()
    {
        var categories = _service.GetCategories().Select(x => new TurVM
        {
            Ad = x.Ad,
            Turno = x.Turno
        }).ToList();

        IndexViewModel model = new();
        model.Turler = categories;
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(IndexViewModel model)
    {
        if (model.SecilenTurNo == 0)
        {
            return RedirectToAction("Index", "Home");
        }

        // kitap listesini secilen ture gore olustur modele koy
        model.Kitaplar = _service.GetBooksByCatId(model.SecilenTurNo).Select(x => new KitapVM
        {
            Kitapno = x.Kitapno,
            Ad = x.Ad,
            Sayfasayisi = x.Sayfasayisi,
            YazarAd = x.YazarAd,
            YazarSoyad = x.YazarSoyad,
            Tur = x.Tur
        }).ToList();

        // tur listesini olusturup modele koy
        model.Turler = _service.GetCategories().Select(x => new TurVM
        {
            Ad = x.Ad,
            Turno = x.Turno
        }).ToList();

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
