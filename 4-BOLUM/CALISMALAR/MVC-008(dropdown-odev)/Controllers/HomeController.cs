using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_008_dropdown_odev_.Models;

namespace MVC_008_dropdown_odev_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public SelectorViewModel CreateModelValues()
    {
        List<City> cities = new()
        {
            new City(){Id = 1, Name="Istanbul" },

            new City(){Id = 2, Name="Bursa" }
        };

        List<Disrict> disricts = new()
        {
            new Disrict(){Id=1, CityId=1, Name="Besiktas"},
            new Disrict(){Id=2, CityId=1, Name="Kadikoy"},

            new Disrict(){Id=3, CityId=2, Name="Nilufer"},
            new Disrict(){Id=4, CityId=2, Name="Osmangazi"},
        };

        List<Neighborhood> neighborhoods = new()
        {
            new Neighborhood(){Id=1, DisrictId=1, Name="Etiler"},
            new Neighborhood(){Id=2, DisrictId=1, Name="Gayrettepe"},

            new Neighborhood(){Id=3, DisrictId=2, Name="Acibadem"},
            new Neighborhood(){Id=4, DisrictId=2, Name="Fenerbahce"},

            new Neighborhood(){Id=5, DisrictId=3, Name="Ozluce"},
            new Neighborhood(){Id=6, DisrictId=3, Name="Odunluk"},

            new Neighborhood(){Id=7, DisrictId=4, Name="Cekirge"},
            new Neighborhood(){Id=8, DisrictId=4, Name="Doburca"}
        };


        SelectorViewModel main = new()
        {
            Cities = cities,
            Disricts = disricts,
            Neighborhoods = neighborhoods
        };

        return main;
    }

    public IActionResult Index()
    {
        var main = CreateModelValues();

        return View(main);
    }
    [HttpPost]
    public IActionResult Index(SelectorViewModel model)
    {

        var returnModel = CreateModelValues();
        if (model.SelCityId != 0)
        {
            returnModel.SelCityId = model.SelCityId;
            returnModel.Disricts = returnModel.Disricts.Where(s => s.CityId == model.SelCityId).ToList();
        }
        else if (model.SelDisrictId != 0)
        {
            // ayri input ile bu deger gelecegi icin, bu degerin geldigi inputta cityId degeri olmayacak, sadece disrictid degeri olacak
            // dogru calismasi icin city id degerine de ihtiyacimiz var.
            // bu yuzden disrictid den tersine dogru ilerleyip ciry id yi bulmaliyiz
            var selCityId = CreateModelValues().Disricts.Where(s => s.Id == model.SelDisrictId).SingleOrDefault().CityId;

            returnModel.SelCityId = selCityId;
            returnModel.SelDisrictId = model.SelDisrictId;
            returnModel.Neighborhoods = returnModel.Neighborhoods.Where(s => s.DisrictId == model.SelDisrictId).ToList();
        }

        return View(returnModel);
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
