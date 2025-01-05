# Api Versionlama

- Api versiyonlama, bazi controllerlarin fakli sekilde yanit vermesini istedigimiz ancak eski controller'i silmek istemedigimiz zaman kullanilan bir yontemdir.
- Buyuk projelerde, bazen apimizi kullanan musteri ve ya kullanicilar farkli sekilde yanitlar isteyebilir ve ya bir guncelleme yapacagiz fakat apimizi eski haliyle kullanan kullanicilar buna entegre olmayabilir. Bu tarz durumlarda versionlama kullaniriz.

---

- Oncelikle gerekli olan [paketi](https://www.nuget.org/packages/Asp.Versioning.Mvc/) nugetten indirmemiz gerekiyor.

- Sonrasinda Program.cs'te bir konfigrasyon yazacagiz.

```C#
builder.Services.AddApiVersioning(opt =>
{
    opt.ReportApiVersions = true;
    opt.AssumeDefaultVersionWhenUnspecified = true; 
    // api surumu verilmezse default olani kullanir
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 2); 
    // yukaridaki prop ile iliskili olarak default versionu belirle
});
```

- Yine Program.cs icinde ApiVersioning'i calistiracagiz

```C#
app.UseApiVersioning();
```

- Versioning kullanimi icin controller'a `[ApiVersion("")]` tagini vermek ve ozel bir route tanimalma yapilmalidir

```C#
[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/product")]
public class ProductController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Product Api v1");
    }
}
```

- :bulb: `{version:apiVersion}` ifadesi tipki daha once kullanidigimiz`[controller]` ifadesi gibi endpointe dinamik bir isim verir, burdaki tek bir isim yerine version olarak ApiVersion'da verilen numarayi almasini saglar

- Farkli versionda bir controller daha yazalim

```C#
[ApiController]
[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/product")]
public class ProductV2Controller : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Product Api v2");
    }
}
```

- Simdi projeyi calistirip bu ornekteki endpointlere istek atmak icin `/api/v1/product` ve ya `/api/v2/product` endpointlerine get istegi yollayabiliriz.
- Birinde `"Product Api v1"` yaniti digerinde `"Product Api v2"` yanitini alacagiz.
