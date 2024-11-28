using Microsoft.AspNetCore.Mvc;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult SaveUser()
    {
        return View();
    }
    [HttpPost]
    public IActionResult SaveUser(SaveUserViewModel model)
    {
        // Parametre olarak gelen model icinde sayfadan gelen verileri alabiliriz.
        // bu verileri alip istersek veritabanina gonderebiliriz. 



        // veri geldikten sonra veri islenip, basarili bir sekilde islenirse, ekrana bunu gosterelim
        // veritabanina kayit islemi geceklestiktikten sonra, model icindeki IsOk alanini true olarak degistirelim

        SaveUserViewModel returnModel = new SaveUserViewModel();

        returnModel.IsOk = true;

        return View(returnModel);
    }


}