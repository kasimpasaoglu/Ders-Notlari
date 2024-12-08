# 3 Katman Mimaride Web-Api ile Calisma

- Daha once `Model`ler icin, `DMO`, `DTO` ve `ViewModel` denilen 3 farkli modelden bahsetmistik.
- Sadece modeller icin degil, veri alinmasi ve gonderilmesi gibi islemler icin yani `Controller`lar icinde 3 katman yapisi olmalidir.

1. Repository
    - Web dunyasinda Repository katmani her zaman bir veriye erismek icin kullanir. Bu katmanda sadece veri getirilir.
    - Veri sadece veritabani degildir, baska uygulamalara erismek ve onlardan veri cekmek ve ya veri gondermek icin her zaman repository katmani kullanilir.
    - Repository katmani her zaman veri ile iletisimdedir
    - Bu veri baska bir web sitesinden de gelebilir, bir veritabanina baglandiktan sonra cekilen veri de olabilir, dosya sistemindeki bir dosyadan okuma/yazma islemi olabilir. Yani her sey olabilir.

2. Services
    - Gelen veriyi islemek, ayiklamak vs islemler icin `Services` kullanilir.

3. Controllers
    - Islenmis veriyi ViewModeline koyup view'a gondermek icin kullanilir.

---

## Web API Kavrami

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

- Son olarak servicesten donen veriyi (SIMDILIK STRING OLARAK) controllerda yakalayalim

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
  - Modellerin karismamasi icin farkli namespace icinde tanimlayalim
    - [DMO](/Models/DMO/RickAndMortyDMO.cs)
    - [DTO](/Models/DTO/RickAndMortyDTO.cs)
    - [ViewModel](/Models/RickAndMortyVM.cs)
- Simdi Repository kisminda string olarak aldigimiz sonucu kendi hazirladigimiz tipe donusturelim.

```C#
// Repository Katmani guncellendi
using DMO;
using Newtonsoft.Json;
using RestSharp;

public class WebApiRepository : IWebApiRepository
{
    
    public RickAndMortyDMO GetAll()
    {
        var options = new RestClientOptions("https://rickandmortyapi.com/api/");
        var client = new RestClient(options);
        var request = new RestRequest("character");
        request.Method = Method.Get;
        var result = client.Get(request);
        string jsonData = result.Content; // string tipinde json verimiz burda
        RickAndMortyDMO resultData = JsonConvert.DeserializeObject<RickAndMortyDMO>(jsonData); // newtonsoft paketi ile bu veriyi RickAndMoryDMO tipine donustuduk.
        return resultData; // ve modeli donduk.
    }
    // Sonuc olarak bu metodumuz, Api sorgusunu yapacak, aldigi sonucu json veri tipinden bizim DMO modelimize yazacak.
}

public interface IWebApiRepository
{
    public RickAndMortyDMO GetAll();
}
```

- Bu adimdan sonra artik `Service` ve `Controller` katmaninda istedgimizi yapabiliriz. Ancak biz bu modeli'de 3 katmanli mimariye uygun olmasi icin DMO,DTO ve VM olarak ayirmamik istiyoruz.

---

- Buraya kadar, DMO uzerinden calistik. Simdi ayni katmanli yapiyi modeller icinde uygulayip DTO ve ViewModeli kullanalim.
- Simdi Service katmaninda DMO'yu DTO'ya cevirelim
- Gelen verileri, bu katmanda olusturacagimiz DTO ya tek tek elle mapleyebiliriz.
- Ancak daha iyi bir yontem olarak [AutoMapper](https://www.nuget.org/packages/AutoMapper) kullanacagiz.
- [AutoMapper dokumantasyon sayfasi](https://docs.automapper.org/en/latest/Getting-started.html)ndaki yonergeleri gozden gecirip uygulayacagiz.

## AutoMapper Konfigrasyonu

- Maplemeyi yapabilmek icin, bir profil olustumamiz lazim, bunun icin bir class yaziyoruz ve ctor'una `CreateMap<>()`, generic metodu ile modeller arasi mappingi olustuyoruz

```C#
using DMO;
using DTO;
using VM;
using AutoMapper;

public class RickAndMortyMappingProfile : Profile
{
    public RickAndMortyMappingProfile()
    {
        // Ana Siniflar Icin Eslesme Profili
        CreateMap<RickAndMortyDMO, RickAndMortyDTO>();
        CreateMap<RickAndMortyDTO, RickAndMortyVM>();
        CreateMap<RickAndMortyVM, RickAndMortyDTO>();
        CreateMap<RickAndMortyDTO, RickAndMortyDMO>();

        // Alt Siniflar icin Eslesme Profili
        CreateMap<DMO.Info, DTO.Info>();
        CreateMap<DTO.Info, VM.Info>();
        CreateMap<VM.Info, DTO.Info>();
        CreateMap<DTO.Info, DMO.Info>();

        CreateMap<DMO.Detail, DTO.Detail>();
        CreateMap<DTO.Detail, VM.Detail>();
        CreateMap<VM.Detail, DTO.Detail>();
        CreateMap<DTO.Detail, DMO.Detail>();

        CreateMap<DMO.Location, DTO.Location>();
        CreateMap<DTO.Location, VM.Location>();
        CreateMap<VM.Location, DTO.Location>();
        CreateMap<DTO.Location, DMO.Location>();
        // Alt siniflarin isimleri ayni oldugu icin baslarina namespace belirtilmeli!!!
    }
}

```

- Bizim ornegimiz modeller birebir ayni oldugu icin ve bir filtreleme yapmadigimiz icin aslinda bu mapleme islemini cift yonlu yazarak daha basit hale getirebiliriz. Bir mapleme isleminin cift yonlu calisabilmesi icin sonuna `ReverseMap()` fonksiyonu eklenebilir

```C#
public RickAndMortyMappingProfile()
    {
        CreateMap<RickAndMortyDMO, RickAndMortyDTO>().ReverseMap();
        CreateMap<RickAndMortyDTO, RickAndMortyVM>().ReverseMap();

        CreateMap<DMO.Info, DTO.Info>().ReverseMap();
        CreateMap<DTO.Info, VM.Info>().ReverseMap();

        CreateMap<DMO.Detail, DTO.Detail>().ReverseMap();
        CreateMap<DTO.Detail, VM.Detail>().ReverseMap();

        CreateMap<DMO.Location, DTO.Location>().ReverseMap();
        CreateMap<DTO.Location, VM.Location>().ReverseMap();
    }
```

- :warning: **Eger modelimizin icinde kendi yazdigimiz tipler varsa (bu ornekte, Info, Detail, Location gibi) bunlarin eslesmesini sagalamak icin profilde bu siniflari da eslestirmek gerekir.**
- Sonraki adimda Program.cs dosyasinda `DI(Dependency Injection)` ile profili bagliyoruz

```C#
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
```

- :warning: `AddAutoMapper()` fonksiyonuna gonderdigimiz `AppDomain.CurrentDomain.GetAssemblies()` parametresi, ile `Profile` classindan kalitilan butun profilleri tarar ve hepsini ekler. Daha hassas bir ekleme yapmak, yani sadece bizim belirleyecegimiz profilleri eklemek icin parametre olarak `builder.Services.AddAutoMapper(typeof(RickAndMortyMappingProfile).Assembly);` girebiliriz.
- :warning: Bu noktada artik Automapper kullanilmaya hazir. Ancak daha once yaptigimiz, Services katmanindaki json'dan modele donusturme islemini Repository katmanina tasidik. Simdi artik Repository katmaninda DMO olarak aldigimiz veriyi Service katmaninda DTO'ya cevirecegiz.

- [Service](/Service/WebAbiService.cs) katmaninda mapperi kullanmak icin daha once yaptigimiz gibi mapper'i bir prop olarak alip, ctorun icine yaziyoruz.

```C#
    public IWebApiRepository _webApiRepo;
    public IMapper _mapper;
    public WebApiService(IWebApiRepository webApiRepo, IMapper mapper)
    {
        _webApiRepo = webApiRepo;
        _mapper = mapper;
    }
```

- Artik `_mapper.Map<>()` generic metodunu burda kullanarak Repository katmanindan gelen DMO'yu DTO'ya cevirebilecegiz.

```C#
    public RickAndMortyDTO GetAll()
    {
        RickAndMortyDMO data = _webApiRepo.GetAll(); // repo katmanindan gelen DMO datasi
        var dtoData = _mapper.Map<RickAndMortyDTO>(data); // automapper ile DTO'ya cevrildi.
        return dtoData;
    }
```

- Bu ornekte bir is plani olmadan ilerledigimiz icin gelen veri icinde bir degisiklik yapmadan direk return verdik. Simdi controller (action) katmanina gidip oraya da ayni sekilde mapperi ekleyip, DTO olarak gelen veriyi, ViewModel'e cevirelim

```C#
    public IActionResult Index()
    {
        RickAndMortyDTO dtoModel = _webApiService.GetAll(); // service katmanindaki GetAll metodundan gelen veri DTO olarak burda,
        RickAndMortyVM model = _mapper.Map<RickAndMortyVM>(dtoModel); // result isimli DTO'yu al, model isimli VM'e maple.

        return View(model);
    }
```

- Boylece, bu ornekte bir WEB-Api'den RestSharp ile bir sorgu yapip json yaniti aldik.
- Json yanitini Repo katmaninda NewtonSoft paketi ile DMO modelimize donusturduk.
- 3 katmanli yaklasimina uygun olmasi icin automapper yardimi ile, modeller arasi gecisi yaptik DMO -> DTO -> VM
- Her katman icin ayri bir controller yazdik, Repo -> Service -> Action
