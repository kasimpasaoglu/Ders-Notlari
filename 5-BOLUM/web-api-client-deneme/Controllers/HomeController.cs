using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using web_api_client_deneme.Models;

namespace web_api_client_deneme.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Yasmis oldugumuz rest api'ye headerdan veri gondererek token verisi alalaim

        var client = new RestClient("http://wissenwebapi.runasp.net");
        var request = new RestRequest("/api/Auth/Login", Method.Post);
        // body icerisinde json gondermemiz gerekli
        var body = new { Username = "root", Password = "1010" };
        request.AddJsonBody(body);

        var response = client.ExecutePost(request);
        string jwtToken = response.Content;

        return RedirectToAction("Privacy", "Home", new { token = jwtToken });
    }
    // Index controlleri ile token alindi, Tokenu kullanarak web apinin token tarafindan korunan bir kismina istek yapalim

    public IActionResult Privacy(string token)
    {
        var client = new RestClient("http://wissenwebapi.runasp.net");
        var request = new RestRequest("/api/Header?model='Fatma", Method.Post);

        // artik bu istekle Authantication ile korunan api'ye istek atacagiz.
        // Token bilgisi header ile gonderilmelidir.
        // RestSharp ile header eklemek asagidaki gibidir
        string tokenString = token.Replace("/", "").Replace('"', ' ').Trim(); // tokenin basi ve sonundaki karakterleri cikar
        request.AddHeader("Authorization", "Bearer " + tokenString); // Header kismindaki Authorization keyine value olarak "Bearer + token" koyduk
        request.AddHeader("Content-Type", "application/json");  // Header kisminda json

        // body icerisinde json gondermemiz gerekli

        var response = client.ExecutePost(request);
        string content = response.Content;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
