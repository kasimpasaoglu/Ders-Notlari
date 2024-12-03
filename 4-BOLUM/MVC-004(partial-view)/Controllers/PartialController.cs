using Microsoft.AspNetCore.Mvc;

public class PartialController : Controller
{
    public IActionResult ImgPartial()
    {
        return PartialView();
    }
}