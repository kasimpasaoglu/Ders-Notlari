# ViewData

- ViewData dictionary tipindedir.
- Gecici olarka veri transfer etmek icin kullanilan bir yapidir.
- ViewData sadece Action ve View arasinda veri transferi yapabilecegimiz bir yapidir.
- Kucuk ve gecici verileri tasimak icin kullanilabilir.
- ViewData model yazilmadigi zaman actiondan view'a veri transfer etmek icin de kullanilabilir.
- ViewData `key` & `value` degerleri tasir. `ViewData["key"]=value`
- Modelden bagimsizdir

```C#
public IActionResult Index()
{
    ViewData["Message"] = "Ben ViewData icinde tasindim!!";
    return View();
}
```

- View Tarafinda bu datayi su sekilde yakalariz

```C#
@if (ViewData.Count != 0)
{
    <h1> @ViewData["Message"]</h1>
}
```

- ViewData sadece bir actiondan bir view'a veri tasir, yazilan veri baska bir action da erisilemez.

```C#
    public IActionResult Privacy()
    {
        string Message = ViewData["Message"].ToString();
        return View();
    }
```

- `"Message"` keyi olan viewData privacy alaninda tanimlanmadigi icin null gelip hata verecektir.
