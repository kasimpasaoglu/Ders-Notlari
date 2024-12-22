using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Api_Calisma.Models;
using Newtonsoft.Json;
using RestSharp;

namespace MVC_Api_Calisma.Controllers;

public class HomeController : Controller
{
    private IApiRepo _repo;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IApiRepo repo)
    {
        _repo = repo;
        _logger = logger;
    }


    public IActionResult Index()
    {
        var jsonString = _repo.GetJsonString();
        List<Item> list = JsonConvert.DeserializeObject<List<Item>>(jsonString);
        var model = new IndexVM()
        {
            Items = list
        };
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
