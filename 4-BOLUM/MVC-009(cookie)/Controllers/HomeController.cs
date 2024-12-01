using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MVC_009_cookie_.Models;

namespace MVC_009_cookie_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IActionResult Login()
    {
        // sayfa ilk acildiginda cookie varsa login ekranini gecsin, direk indexe gitsin.
        // cookie'yi okuyalim
        if (Request.Cookies["Email"] != null)
        {
            var email = Request.Cookies["Email"];
            var password = Request.Cookies["Password"];
            // cookie den hashlenmis verileri cektik, bizim sabit e-mail ve pasword degerleri ile karsilsastirilacagi icin, bizim db mizdeki email ve paswordu de hashlemek lazim
            var shaUserName = CreateSHA512(LoginUser.Username);
            var shaPassword = CreateSHA512(LoginUser.Password);
            if (email == shaUserName && password == shaPassword)
            {
                return View("Index");
            }
        }

        LoginViewModel model = new();
        model.Email = "";
        model.Password = "";
        model.Remember = false;
        return View(model);
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {

        if (model.Password == LoginUser.Password && model.Email == LoginUser.Username)
        {
            if (model.Remember)
            {
                // beni hatirla butonu aktif ise cookie olusturalim
                var emailOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1), // bir gun sonra expires olsun
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict // CRFS saldirilana karsi koruma 
                };
                var passwordOptions = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(1), // bir gun sonra expires olsun
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict // CRFS saldirilana karsi koruma 
                };
                var shaEmail = CreateSHA512(model.Email);
                var shaPasword = CreateSHA512(model.Password);
                Response.Cookies.Append("Email", shaEmail, emailOptions);
                Response.Cookies.Append("Password", shaPasword, passwordOptions);
            }


            return View("Index");
        }
        else
        {
            return View();
        }
    }

    // sifre ve eposta verilerini sifreleyen metod
    public string CreateSHA512(string input)
    {
        SHA512 sha512 = SHA512.Create();
        byte[] inputByte = Encoding.UTF8.GetBytes(input);
        byte[] hashByte = sha512.ComputeHash(inputByte);
        StringBuilder builder = new StringBuilder();
        foreach (byte b in hashByte)
        {
            builder.Append(b.ToString("x2"));
        }

        return builder.ToString();
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
