using Microsoft.AspNetCore.Mvc;

namespace MVC_015_Rest_client_.Controllers;

public class HomeController : Controller
{
    public IWebApiService _webApiService;

    public HomeController(IWebApiService webApiService)
    {
        _webApiService = webApiService;
    }

    public IActionResult Index()
    {
        RickAndMortyDMO result = _webApiService.GetAll();
        return View(result);
    }
}
