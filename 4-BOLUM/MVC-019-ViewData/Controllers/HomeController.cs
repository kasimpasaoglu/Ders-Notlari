using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_019_ViewData.Models;

namespace MVC_019_ViewData.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {

        // View Data Tanimlama
        ViewData["Message"] = "Ben ViewData icinde tasindim!!";
        // view tarafina gec
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }


}
