
using Microsoft.AspNetCore.Mvc;
using VM;

namespace MVC_Project1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        string jsonLogin = CookieHelper.GetCookie(Request, "LoginData");
        if (jsonLogin != null)
        {
            Login model = CookieHelper.ToModel<Login>(jsonLogin);
            return View(model);
        }
        else
        {
            return View(new Login());
        }
    }
}
