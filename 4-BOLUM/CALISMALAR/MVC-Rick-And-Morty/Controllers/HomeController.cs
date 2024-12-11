using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Rick_And_Morty.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MVC_Rick_And_Morty.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index(string url = null)
    {
        // eger url null ve ya empty ise, "https://rickandmortyapi.com/api/character" urlsini kullan, degilse, gelen url yi kullan
        var requestUrl = string.IsNullOrEmpty(url) ? "https://rickandmortyapi.com/api/character" : url;

        // istemci (client) newle
        var client = new RestClient();
        // sorguyu hazirla
        var request = new RestRequest(requestUrl);
        // sorguyu yap, gelen yaniti response diye bir degiskene ata
        var response = await client.GetAsync(request);

        // response.IsSuccesfull true donerse:
        if (response.IsSuccessful)
        {
            // responsu al(strting olarak geliyor)
            var stringContent = response.Content;
            // json formatinda API dan gelecek modele uygun kendi yazdiim modele maplemeyi otomatik yapiyor
            // bunu yapan Newtonsoft.json paketini nugetten indiridim
            var jsonContent = JsonConvert.DeserializeObject<MainContentViewModel>(stringContent);
            return View(jsonContent);
        }
        else
        {
            // yanit basarisiz gelirse null yolla view tarafinda hallederiz...
            return View(null);
        }
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
