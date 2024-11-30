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

    public IActionResult Index()
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


        return View(main);
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
