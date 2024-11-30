using Microsoft.AspNetCore.Mvc;

public class PartialController : Controller
{
    public IActionResult ImgPartial()
    {

        // bir actiondan geriye iki turlu sayfa donulebilir. 
        // 1. return View() -> Sayfanin tamami,
        // 2. return PartialView() -> sayfanin bir kismi

        return PartialView();
    }
}