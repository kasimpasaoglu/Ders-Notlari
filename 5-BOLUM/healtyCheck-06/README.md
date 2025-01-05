# HealthChecks

- HealthChecks, bir api ve ya uygulamanin bagli oldugu veritabani gibi kaynaklarin calisip calismadigini takip etmemizi saglayan bir pakettir.
- Bir API'nin bagli oldugu kaynagin (ornegin veritabani) saglikli bir sekilde calisip calismadigini kontrol ederken sorguyu ucuncu bir taraftan ornegin baska bir networke bagli bir uygulama ve ya cihazdan degil, o veritabanina bagli calisan API'den yapmaliyiz.
- Bunun sebebini bir ornekle aciklarsak; veritabanina evimizdeki bilgisayardan erisimimiz kisitli olabilir, ancak sirketin sunucularinda calisan bir apinin erisimi olabilir. Biz bu durumda veritabanina health check'i kendi bilgisayarimizdan yaparsak baglanti kurulamayacagi icin unhealty sonucunu aliriz, oysaki o veritabina bagli calisan api saglikli bir sekilde calisiyordur. Bu durum tam tersi gibi de dusunulebilir.

---

- [HealthChecks](https://www.nuget.org/packages/Microsoft.Extensions.Diagnostics.HealthChecks) paketini nuget'tan indirip projemize ekliyoruz.
- Hangi tipte bir veritabanina kontrol yapacaksak onun icin yazilan ek paketi kuruyoruz. Ornegin;
  - [REDIS](https://www.nuget.org/packages/AspNetCore.HealthChecks.Redis)
  - [SQLServer](https://www.nuget.org/packages/AspNetCore.HealthChecks.SqlServer)
- UI olarak goruntulemek ve sonuclarin varsayilan JSON formatin otomatik olarak yazdirilabilmesi icin iki adet yardimci paket indiriyoruz
  - [HealthChecks.UI](https://www.nuget.org/packages/AspNetCore.HealthChecks.UI)
  - [HealthChecks.UI.Client](https://www.nuget.org/packages/AspNetCore.HealthChecks.UI.Client)

---

- Program.cs icinde HealthCheck servisinin konfigrasyonunu yapiyoruz

```C#
builder.Services.AddHealthChecks()
    .AddSqlServer(
        connectionString: "Server=db11596.public.databaseasp.net; Database=db11596; User Id=db11596; Password=i#5G!Tc2p6J+; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;",
        healthQuery: "SELECT 1;",
        name: "Sql Server",
        tags: new[] { "db", "sql" })
    .AddRedis(
        redisConnectionString: "redis-11810.c300.eu-central-1-1.ec2.redns.redis-cloud.com:11810,password=YvGRpGrL8NjVKU8i085NR3UwsC2o9wSo,abortConnect=false",
        name: "Redis")
    .AddCheck<ApiHealthCheck>("Rick and Morty Api Check");
```

- :warning: SQL server ve REDIS icin konfigrasyonu yaptik. Son satirdaki AddCheck, custom olarak olusturuldu rickandmorty api'si icin kullanacagiz. Custom check icin yazdigimiz sinifa sonra bakacagiz.

- Bu sekilde konfigrasyonu olusturduktan sonra healthcheck ekranini UI olarak gostermek icin servise bir konfigrasyon daha ekliyoruz

```C#
builder.Services.AddHealthChecksUI(setup =>
{

    setup.AddHealthCheckEndpoint("Basic Health Check", "/healthy");
}).AddInMemoryStorage();
```

- Son olarak hem health check hem de UI'i app icinde calistiyoruyorz.

```C#
app.MapHealthChecks("/healthy", new Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});


app.UseHealthChecksUI(opt =>
{
    opt.UIPath = "/healthyUI";
});
```

- :warning; HealtCheck icin kullandigimiz ResponseWriter degiskenini **HealthChecks.UI.Client** paketinden aldigimiz **UIResponseWriter** sinifi icindeki **WriteHealthCheckUIResponse** ile aldik. Bu varsayilan yanit icin JSON formatini olusturacak.

- Bu sekilde konfigrasonu olusturduktan sonra, dogrudan json formatinda yaniti gormek icin `/healthy` endpointine get istegi yapabiliriz
- Ve ya bir web sitesi gibi UI uzerinde gormek istersek `/healthyUI` endpointine tarayici uzerinden gidebiliriz.

---

## Custom Healthy Check Yazilmasi

- HealthCheck'lere son satirda ekledigimiz `.AddCheck<ApiHealthCheck>("Rick and Morty Api Check");` kontrolu icin,  `ApiHealthCheck` adinda bir class yazalim
- :warning: Bu class `IHealthCheck` interface'inden kalitilmalidir.
- Amac restsharp ile bir apiye sorgu atip gelen yanit bossa unhealty, doluysa healty donmek.  

```C#
public class ApiHealthCheck : IHealthCheck
{
    public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        RestSharp.RestClient cli = new RestSharp.RestClient("https://rickandmortyapi.com/api/character");
        RestSharp.RestRequest req = new RestSharp.RestRequest();
        req.Method = RestSharp.Method.Get;
        var response = cli.Execute(req);

        if (!string.IsNullOrEmpty(response.Content))
        {
            return HealthCheckResult.Healthy("Healthy");
        }
        else
        {
            return HealthCheckResult.Unhealthy("Un-Healthy");
        }
    }
}
```

- CheckHealthAsync metodu Interface tarafindan olusturuldu, biz icini doldurup, iki durum icinde bir return verdik.
