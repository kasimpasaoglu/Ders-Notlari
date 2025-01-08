using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StrategyDesignPattern.Models;

namespace StrategyDesignPattern.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(IndexVM model)
    {
        // kullanicidan gelen yanita gore strateji secimi
        // Service katmaninda yapilmasi daha dogru??
        IShippingMethod strat = model.ShippingType switch
        {
            "Standard" => new StandardShipping(),
            "Express" => new ExpressShipping(),
            "Free" => new FreeShipping(),
        };

        model.ShippingCost = strat.CalculateShippingCost(model.OrderAmount);
        return View(model);
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
