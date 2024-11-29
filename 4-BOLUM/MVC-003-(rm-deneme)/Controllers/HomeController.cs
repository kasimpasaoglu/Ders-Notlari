using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_003__rm_deneme_.Models;
using Newtonsoft.Json;
using RestSharp;


namespace MVC_003__rm_deneme_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    // Index actionunu asenkron denilen bir seye cevirmek gerekli???
    public async Task<IActionResult> Index()
    {
        // api'a giris icin temel yapilandirma
        var options = new RestClientOptions("https://rickandmortyapi.com") // api ana adresi
        {
            // giris kontrolleri varsa o tarz ayarlar burda yapilir, 
            // rickandmortye de giris kontrolu yok
            Timeout = TimeSpan.FromSeconds(5) // 5 saniye yaniti bekleme suresi
        };

        // istemciyi olusturduk(client)
        var client = new RestClient(options);

        // endpoint ? belirt. Linkin devami??
        var request = new RestRequest("/api/character");

        // istegi yolla, gelen yaniti response adinda bir degiskene yaz.
        var response = await client.GetAsync(request);

        // 5. Yanıtı kontrol edin
        if (response != null)
        {
            var stringContent = response.Content; // gelen yanit string formatinda burda,
            var jsonContent = JsonConvert.DeserializeObject<MainContentViewModel>(stringContent);
            // string formatinda gelen yaniti MainContentViewModel tipine donusturduk (Newtonsoft.json paketi nuget'ten indirlildi),


            return View(jsonContent);
        }
        else
        {
            // hata olursa null donsun
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
