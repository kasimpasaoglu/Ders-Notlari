using Microsoft.AspNetCore.Mvc;

public class WissenController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}