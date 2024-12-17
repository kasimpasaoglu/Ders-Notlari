# ViewBag

- ViewBag'in ViewData'dan farki, ViewData'da sadece `object` tasiyabilirken, `ViewBag` `dynamic` tip tasiyabilir.
- ViewBag, arkaplanda ViewData kullanmaktadir.
- ViewBag ile bir veri tasiyalim. (Ogrenci Nesnesi)

```C#
public IActionResult Index()
{
    ViewBag.Student = new Ogrenci()
    {
        Age = 22,
        Id = 1,
        Name = "Ozgur"
    };
    return View();
}
```

- View Tarafinda ViewBag'e erisim icin action tarafinan olusturulan dynamic tip uzerinden yapilir.

```C#
<h1>@ViewBag.Student.Id</h1>
<h1>@ViewBag.Student.Name</h1>
<h1>@ViewBag.Student.Age</h1>
```

- Bu haliyle ViewBag ViewData'dan daha kullanislidir.
- Arkaplanda ViewData kullandigi icin, ViewData'da oldugu gubu, iki action arasinda veri tasimasi yapilmaz.
