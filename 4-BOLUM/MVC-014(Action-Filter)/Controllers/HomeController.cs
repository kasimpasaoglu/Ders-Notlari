using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_014_Action_Filter_.Models;

namespace MVC_014_Action_Filter_.Controllers;

public class HomeController : Controller
{


    public HomeController()
    {

    }

    public IActionResult Index()
    {
        IndexViewModel model = new() { IsCorrrect = true }; // ilk acilmada view'a gidecek olan modelde view tarafinda hata mesaji olmadigi icin isCorrect alani true olarak gonderildi.
        return View(model);
    }

    [HttpPost]
    [ServiceFilter(typeof(IndexActionFilter))] // Asagidaki action'un, action filter'a yonlendirmesini yaptik
    public IActionResult Index(IndexViewModel model)
    {
        // Action Filter'dan gelen mesaji burada yakalayabiliriz.
        if (HttpContext.Items["FilterExceptionMessage"] != null)
        {
            var actionFilterMessage = HttpContext.Items["FilterExceptionMessage"].ToString(); // actiondan gelen mesaji string'e cevirip degiskene atadik
            if (!string.IsNullOrWhiteSpace(actionFilterMessage)) // kontrol ettik, null ve ya bosluk varsa bir hata var demektir.
            {
                model.ActionFilterErrorrMessage = actionFilterMessage; // gelen hata mesajini modele koyduk
                model.IsCorrrect = false; // hata oldugunu viewda gormek icin modelin icindeki bool degiskenini false yaptik. 
            }
        }
        return View(model);
    }

}
