# Partial

- Bir actiondan geriye iki turlu sayfa donulebilir.
    1. return View() -> Sayfanin tamami,
    2. return PartialView() -> sayfanin bir kismi

```C#
using Microsoft.AspNetCore.Mvc;

public class PartialController : Controller
{
    public IActionResult ImgPartial()
    {
        return PartialView();
    }
}
```

> PartialView donen bir controller yazdik.

```cshtml

<h2>Burasi Home/Index</h2>

@Html.Partial("ImgPartial", Model)

```

- Html.Partial sayfalari kucuk parcalara ayirmak icin kullanilir.
- ImgPartial View'i bir baska view icinde cagrilabilir,
- Bu view birden fazla sayfada kullanilmayi planlaniyorsa, Views/Shared klasorune konulabilir
- Bu view icin controller her cagirildigi sayfada yazilmali. Burda bu view cagrilirken ikinci parametre olarak ona bir model verildigi icin,
- Bu sayfanin controllerindan bu modeli bu sayfaya gonderip sonra kendisine veririz.
- Kullanmak istedigimiz butun sayfalarda ayni seyi yapmaliyiz.
- Partial iki turlu kullanilabilir.
    1. yontem partial hic bir actiona bagli olmaz, modelini kendini kapsayan viewdan alir,
    2. yontem, partial kendini kapasan viewdan model almaz, direk bir actiona bagli kalir. View Components denilen bir yontem ile yapilir ilerde bakacaz.