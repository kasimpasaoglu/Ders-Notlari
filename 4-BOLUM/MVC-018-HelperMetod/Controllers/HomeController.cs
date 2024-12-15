using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using Helpers;
using Microsoft.AspNetCore.Mvc;
using MVC_018_HelperMetod.Models;

namespace MVC_018_HelperMetod.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;


        List<StutendVM> ogr = new List<StutendVM>();
        ogr.Add(new StutendVM() { Name = "Hamdi", Scores = [10, 50, 60] });
        ogr.Add(new StutendVM() { Name = "Ali", Scores = [10, 50, 60] });
        ogr.Add(new StutendVM() { Name = "Oğuz", Scores = [10, 50, 60] });

        Expression<Func<double, double>> doubleExpression = x => Math.Round(x);

        Func<double, double> rounder = doubleExpression.Compile();

        double result = rounder(10.0155);

        //

        Expression<Func<int, bool>> secondExpression = x => x > 100;

        Func<int, bool> isBigNumber = secondExpression.Compile();

        bool isBig = isBigNumber(110);


        Expression<Func<int, double>> thirdExpression = x => Math.Sqrt(x);

        Func<int, double> square = thirdExpression.Compile();

        double squareResult = square(48);


        Expression<Func<string, string>> reverserExpression = x => x.Reverse();

        Func<string, string> reverser = reverserExpression.Compile();

        string reverserResult = reverser("Kelime");


        Expression<Func<string, int>> counterExpression = x => x.Where(s => s == 'a').Count();

        Func<string, int> counter = counterExpression.Compile();

        int counterResult = counter("ali babanin bir ciftligi var");



        Expression<Func<StutendVM, double>> avarageExpression = x => x.Scores.Sum() / x.Scores.Length;

        Func<StutendVM, double> avg = avarageExpression.Compile();

        double avgResult = avg(new StutendVM() { Name = "Ali", Scores = [50, 75, 100] });


    }

    public IActionResult Index()
    {
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
