using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_010_sessions_giris_.Models;
using Newtonsoft.Json;

namespace MVC_010_sessions_giris_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SessionModel model = new();
        model.Email = "kasimpasaoglu@gmail.com";
        model.Password = "1010";

        HttpContext.Session.SetString("Email", model.Email);
        HttpContext.Session.SetString("Password", model.Password);


        Student student = new Student()
        {
            Age = 13,
            LastName = "Dinç",
            Name = "Oğuz"
        };


        var studentJson = JsonConvert.SerializeObject(student);

        HttpContext.Session.SetString("OgrenciJson", studentJson);

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
