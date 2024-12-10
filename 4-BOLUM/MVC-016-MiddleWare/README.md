# MiddleWare

- Butun uygulamada geceli olan, uygulama yasadigi surece ayakta duran yapilardir.
- Sayfanin yaptigi her islemde calisir. Ornegin; ilk yuklemede html sayfasi olustururken, icerigi getirirken, css dosyalarini yuklerken, js dosyalarini yuklerken. Yani sayfayi olusturana kadar olan butun islemlerde adim adim calisir.

## Nasil kullanilir?

- `LoggingMiddleWare.cs` adinda bir dosyada middleware'i yazalim

```C#
public class LoggingMiddleware
{
    private readonly RequestDelegate _next;
    public LoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var stopwatch = Stopwatch.StartNew();

        _next(context).Wait();
        // Yapilacak islemler buraya yazilir
        stopwatch.Stop();
    }
}
```

> `InvokeAsync()` metodu yazdigimiz middleware'in hangi islemi yapacagini belirttigimiz metottur.
> Middleware her calistiginda yapilmakta olan islem, sayfadaki veri, hangi actionda hangi islemin yapildi gibi butun verileri `context` ile yakalayabiliriz.
> :bulb: Bu metod bir asenktron metottur. Ilerde daha detayli konusacagiz ancak su an bildigimiz; asenkron metodlar islemin tamamlanmasini beklemeden bir sonraki adima gecilmesini saglayan metodlardir. Yani bir yanit beklemez verilen talimati yapar ve bir sonraki isleme devam eder.

- Bir sonraki adimda `Program.cs` dosyasinda Middleware kullanmasi icin bu satiri ekliyoruz;

```C#
app.UseMiddleware<LoggingMiddleware>();
```

- Bu ornekte middleware ile bir log tutmayi deneyelim

## MongoDb ile Log Tutma

- MongoDB icin [MongoDB.Driver](https://www.nuget.org/packages/MongoDB.Driver) paketini indirdikten sonra, konfigrasyonu yapmak icin bir class yazalim

```C#
// MongoDbClient.cs
public class MongoDbClient
{
    public void AddLog(LogModel model)
    {
        var client = new MongoClient("mongodb+srv://emrahelis:40GV5bQbIKnqCNYz@cluster0.3p4ow.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
        var database = client.GetDatabase("foo");
        var collection = database.GetCollection<BsonDocument>("cluster0");
        collection.InsertOne(model.ToBsonDocument());
    }
}
```

- Burdaki Addlog metodunu kullanarak MongoDB'mize log basacagiz
- Log'u olusturmak icin bir modele ihtiyacimiz var

```C#
// LogModel.cs
public class LogModel
{
    public string Date { get; set; }
    public string Path { get; set; }
    public string Body { get; set; }
}
```

- Simdi tekrar middleware tarafina gidip loglama icin gerekli guncellemeleri yapalim

```C#
public async Task InvokeAsync(HttpContext context)
{
    var stopwatch = Stopwatch.StartNew();
    string body = "";

    if (context.Request.Body != null)
    {
        // context icindeki Request icindeki Body direk erisilebilir degil.
        // Body byte cinsinden duran bir tip, byte cinsinden veriyi stream ile okumak gerekir.
        // StreamReader modeli ile body'i okuruz
        var reader = new StreamReader(context.Request.Body);
        // byte veri tipinde son satira kadar okuma yapmak gerekir. 
        //Yukardaki StreamReader'in okumasini yapip, icindeki Results bolumunde sayfadaki inputlarda yazilan veriyi yakaladik, ve body isimli degiskene atadik.
        body = reader.ReadToEndAsync().Result;
    }
    
    _next(context).Wait(); 

    LogModel model = new LogModel()
    {
        Date = DateTime.Now.ToLongTimeString(),
        Path = context.Request.Path,
        Body = body
    };
    new MongoDbClient().AddLog(model);

    stopwatch.Stop();
}
```
