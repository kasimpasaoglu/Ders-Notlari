# Dependency Injection

[Helper](/4-BOLUM/MVC-012(Dependency_Injection)/Infrastructure/Helper.cs) clasimiz icinde bircok yerde kullandigimiz bir metod (`SayHello()`) oldugunu  varsayalim.

- Bu metodu kullanalim

```C#
    public IActionResult Index()
    {
        Helper help = new Helper();
        return View();
    }
```

- Her kullandigimiz yerde newlemeye kalkarsak ortalik cok karisir.
- Bunu yapmamak icin DI(Dependency Injection) teknolojisini kullaniriz.

- Program.cs dosyasinda `var app = builder.Build();` satirinin ustunde bir metod calistiriyoruz

```C#
builder.Services.AddScoped<IHelper, Helper>();
```

- Sinifinin bir interface'i varsa (buyuk projelerde her zaman olmali) `AddScoped<>()` metoduna, interface'i ve classi veriyoruz
- Artik action icerisinde bu sinifi daha kolay kullanabiliriz.

---

- Kullanmak istedigimiz controller'a bu interface tipinde bir degisken belirliyoruz.
- Sonrasinda bir `ctor` yaziyoruz, boylece helper classina bu controller icinde ihtiyacimiz oldugunda, ctor kullanarak newlemeden cagirip kullanabilecegiz

```C#
public class HomeController : Controller
{
    // interface eklendi
    public IHelper _helper;

    // ctor yaz
    public HomeController(IHelper helper)
    {
        this._helper = helper;
    }

    // kullanalim
    public IActionResult Index()
    {
        _helper.SayHello();
        return View();
    }
}
```

:warning: Birden fazla classin icindeki metodlari DI yapmak icin, program.cs e yeni bir satirda interface ve class verilerek `AddScope` yapildiktan sonra, Controller a interface eklenip, ctor'a parametre olarak yeni interface verilebilir. Sinir yoktur

```C#
public class HomeController : Controller
{
    // interfaceler eklenir
    public IHelper _helper;
    public MakeJson _makeJson;

    // ctor yazilir
    public HomeController(IHelper helper,MakeJson makeJson)
    {
       this._helper = helper;  
       this._makeJson = makeJson;
    }

    // kullanalim
    public IActionResult Index()
    {
        _helper.SayHello();
        _makeJson.Make();

        return View();
    }
}
```
