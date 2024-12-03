# Redirect

Bir actiondan baska bir actiona yonlendirme yapma

- Direk action name verilip bu kismin icine gelen derleyici direk RedirectAction actionuna gidecek
- Ayni controller icindeki bir actiona yonlendirmek icin. `return RedirectToAction("RedirectedAction");`
- Farkli bir controllerdaki actiona yonlendirmek icin `return RedirectToAction("Index", "Wissen");`
- redirect to action ile parametre transferi yapilabilir

```C#
[HttpPost]
public IActionResult Index(HomeViewModel model)
{
    if (model.Name == "Hakan")
    {
        return RedirectToAction("ParametreAlan", new { name = model.Name });
    }
    else return View();
}
```
