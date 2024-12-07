# 3 Katman

- Daha once bahsettigimiz `Model`ler icin, `DMO`, `DTO` ve `ViewModel` denilen 3 farkli modelden bahsetmistik.
- Sadece modeller icin degil, veri alinmasi ve gonderilmesi gibi islemler icin yani `Controller`lar icinde 3 katman yapisi olmalidir.

1. Repository
    - Web dunyasinda Repository katmani her zaman bir veriye erismek icin kullanir. Bu katmanda sadece veri getirilir.
    - Veri sadece veritabani degildir, baska uygulamalara erismek ve onlardan veri cekmek ve ya veri gondermek icin her zaman repository katmani kullanilir.
    - Repository katmani her zaman veri ile iletisimdedir
    - Bu veri baska bir web sitesinden de gelebilir, bir veritabanina baglandiktan sonra cekilen veri de olabilir, dosya sistemindeki bir dosyadan okuma/yazma islemi olabilir. Yani her sey olabilir.

2. Services
    - Gelen veriyi islemekk, ayiklamak vs islemle icin `Services` kullanilir.

3. Controllers
    - Islenmis veriyi ViewModeline koyup view'a gondermek icin kullanilir.

# Web API Kavrami

- Bazi durumlarda baska bir uygulamadan, ve ya data saglayiciladan veri cekebiliriz. Mesela Rick and Morty API.
- Bu API'lar aslinda arkaplanda kendi sunucularinda sakladiklari verileri, disariya paylasirlar.
- Bu API'lara daha once JavaScript'te yaptigimiz `Fetch()` metodu gibi sorgu atabilmek icin C#'ta Nugetten indirecegimiz [RestSharp](https://www.nuget.org/packages/RestSharp) paketini kullaniriz.
- Bu sekilde yapilan API sorgularina JSON formatinda yanitlar verilir.
- Gelen API yanitlarini JSON formatinda aldiktan sonra C#'ta kolayca kontrol edebilmek icin, bir modele cevirmemiz gerekir.
- Bunu yapmak icin ihtiyacimiz olan Nuget paketi => [NewtonSoft](https://www.nuget.org/packages/Newtonsoft.Json)

- Simdi Repository Katmaninda API'a sorgu atip verileri getirleim

```C#
// Repository Katmani
public class WebApiRepository : IWebApiRepository
{
    public string GetAll()
    {
        var options = new RestClientOptions("https://rickandmortyapi.com/api/"); // Api sorgusunun yapilacagi ana link
        var client = new RestClient(options); // istemci olusturuldu
        var request = new RestRequest("character"); // sorgulanacak kisim
        request.Method = Method.Get; // metod get olarak ayarlandi
        var result = client.Get(request); // sorgu atildi, gelen yanit result adinda degiskene atandi
        return result.Content; // bizim istedigimiz json kismi result.Content icindeydi (string olarak), metoddan geriye bunu donduk
    }
}

public interface IWebApiRepository
{
    public string GetAll();
}
```

- Services katmaninda gelen veriyi alalim

```C#
// Services katmani
public class WebApiService : IWebApiService
{
    public IWebApiRepository _webApiRepo;
    public WebApiService(IWebApiRepository webApiRepo)
    {
        _webApiRepo = webApiRepo;
    }

    public string GetAll()
    {
        return _webApiRepo.GetAll();
    }
}
public interface IWebApiService
{
    public string GetAll();
}
```

- Son olarrrak servicesten donen veriyi (SIMDILIK STRING OLARAK) controllerda yakalayalim

```C#
// Controller Katmani
public class HomeController : Controller
{
    public IWebApiService _webApiService;

    public HomeController(IWebApiService webApiService)
    {
        _webApiService = webApiService;
    }

    public IActionResult Index()
    {
        var result = _webApiService.GetAll();
        return View();
    }
}
```

- Simdi gelen veriyi JSON'dan bir Tipe donusturmek isiyoruz. Yukada bahsettigimiz [NewtonSoft](https://www.nuget.org/packages/Newtonsoft.Json) paketini kullanacagiz.
- Once bu json verisine uygun bir [MODEL](/Models/DMO/RickAndMortyDMO.cs) yazmamiz lazim.
- Daha sonra simdi Repository kisminda string olarak aldigimiz sonucu services katmaninda kendi hazirladigimiz tipe donusturelim.

```C#
// Services Katmani guncellendi
using Newtonsoft.Json;

public class WebApiService : IWebApiService
{
    public IWebApiRepository _webApiRepo;
    public WebApiService(IWebApiRepository webApiRepo)
    {
        _webApiRepo = webApiRepo;
    }

    public RickAndMortyDMO GetAll()
    {
        string jsonString = _webApiRepo.GetAll(); // string tipinde json verimiz burda
        RickAndMortyDMO resultData = JsonConvert.DeserializeObject<RickAndMortyDMO>(jsonString); // newtonsoft paketi ile bu veriyi RickAndMoryDMO tipine donustuduk.
        return resultData; // ve bunu geri dondurduk.
    }
}
public interface IWebApiService
{
    public RickAndMortyDMO GetAll();
}
```

- Bu adimdan sonra artik `Controller` icinde istedgimizi yapabiliriz.
- Buraya kadar, DMO uzerinden calistik. Simdi ayni katmanli yapiyi modeller icinde uygulayip DTO ve ViewModeli kullanalim
