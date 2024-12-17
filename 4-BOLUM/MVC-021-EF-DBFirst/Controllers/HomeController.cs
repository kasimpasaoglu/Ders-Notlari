using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_021_EF_DBFirst.DataAccessLayer;
using MVC_021_EF_DBFirst.DMO;
using MVC_021_EF_DBFirst.Models;

namespace MVC_021_EF_DBFirst.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AdventureWorksContext _context;

    public HomeController(ILogger<HomeController> logger, AdventureWorksContext context)
    {
        _context = context;
        _logger = logger;
    }

    public IActionResult Index()
    {
        // context uzerinden product tablosunu cekelim

        List<Product> products = _context.Products.ToList();


        return View(products);
    }

    public IActionResult Privacy(int id)
    {
        var binaryImg = _context.ProductPhotos.Where(x => x.ProductPhotoId == id).FirstOrDefault();
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
