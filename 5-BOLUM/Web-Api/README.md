# WEB-API

- Api'lerde MVC de oldugu gibi 3 katmanli (controller, service, repository) mimariye uygun olarak yazilabilir.
- Microsoft yeni templatelerinde her seyi program.cs icinde yazarak sadelestirmeye gecti.

- Yine de anlasilmasi kolay olmasi acisindan bu calismada, controller olusturup API'i orda yazacagiz.
- Program.cs dosyasinda asagidaki satir ile controllerlari ekliyoruz.

```C#
builder.Services.AddControllers();
```

- Ayrica `app.Run()` satirindan once asagidaki komutlari giriyoruz

```C#
app.MapControllers();
app.UseRouting();
```

- Controller klasoru olusturup icine yazilacak olan controller sinifi bu sekilde olmalidir

```C#
[ApiController]
[Route("api/[controller]")]
public class WissenController : ControllerBase
{
}
```

- Controllerin basina verilen `[ApiController]` etiketi bu sinifin bir API controller oldgunu belirtir.
- `Route` etiketi Tipki MVC'de oldugu gibi bu kontroller'a erismek icin gereken `path` i customize etmek icin kullanilir.
- Api uygulamarinda verilecek uclar bu linklerden disari acilacagi icin API icin customize pathler yazilmasi cok onemlidir.
- Yukardaki ornekte olusturulan route'un icerdigi `[controller]` ifadesi, kullanicinin buraya arismesi icin aslinda controller' adini yazmasi gerektigi anlamina gelir. (bu ornekte Wissen). Yani bu controller'a erismek icin yazilmasi gereken path `api/Wissen` olacaktir.

---

- Api'lerin gelen sorgulara verdikleri yanit, yapi olarak 2 parcadir. HEADER ve BODY. Header bir mektubun zarfi olarak dusunulebilir, body ise mektugun kendisidir
  - Header kisminda gonderici, alici gibi bilgiler yer alir
  - Body icinde sorgunun yaniti yer alir
- Api'lerin sorgulara yanit verirken beraberinde sorgunun basarili olup olmamasi, sebepleri gb bilgileri de birlikte donerler.
- Bu bilgileri evrensel olarak sayi kodlari ile belirlerler 200-202-404 gibi.
- [HTTP Status Codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes) -> Burdan status codlara bakilabilir

---

- `ApiController` HTTP protokollerini icerir.(GET-POST-PUT gibi). Bu controller ya yapilacak olan istekler bu protokollerden hangisi ise, otomatik olarak o metodu calistiracaktir.
- Yazilan metodlar Get(), Post() gibi isimlendirilmesi genel kabul gormus kuraldir. Ayrica metodlarin basina `[HttpPut]` gibi etiketler konulmalidir.
- Metodlar geri deger donerken `Ok()` gibi metodlar icinde veriyi donmelidir. Bu metodlarin her biri yukarda bahsettigimiz [HTTP Status Codes](https://en.wikipedia.org/wiki/List_of_HTTP_status_codes) bilgisini olusturur. Yani bir get metodu Ok() donuyorsa istemci aldigi yanitin status kodunun 200 geldigini ve yanitin basarili olarak alindigini anlar.

---

```C#
// Kaynaktaki veriyi tamamen degistimek ya da guncellemek icin put kullanilir
// Eger kaynak mevcut degisle olusturmak, mebcutsa tamamini guncellemek yani override icin kullanilir
// Ornek, bir ogrenci nesnesi var, ve bu ogrenci nesnesini yeni bir ogrenci nesnesi ile degistmek icin kullanilir
// ve ya direk yeni bir ogrenci nesnesi koymak icin kullanilir
    [HttpPut]
    public IActionResult Put()
    {
        return Ok(true);
    }

// veri kaynagindaki veriyi kismi guncellemek icin kullanilir
// mesela ogrenci nesnesinin sadece name propunu degistirmek icin
    [HttpPatch]
    public IActionResult Patch()
    {

        return Ok(true);
    }

// veri kaynagindaki veriyi silmek icin kullanilir
// id degerine gore ogrenci nesnesi silmek gibi
    [HttpDelete]
    public IActionResult Delete()
    {

        return Ok(true);
    }
// header bilgilerini almak icin kullanilir
// header alaninda istenilen verilerin olup olmadigini, varsa veriyi almak icin kullanilir
    [HttpHead]
    public IActionResult Head()
    {

        return Ok(true);
    }

// Api'nin hangi HTTP metodlarina izin verdigini ogrenmek icin kullanilir
    [HttpOptions]
    public IActionResult Options()
    {
        return Ok(true);
    }

    public IActionResult Get()
    {
        // geriye product döndürelim 
        var products = new[]
        {
            new { Id =1, Name = "Kalem"},

            new { Id =2, Name = "Kağıt"},

            new { Id =3, Name = "Silgi"},

            new { Id =4, Name = "Masa"},

            new { Id =5, Name = "Bilgisayar"},

            new { Id =6, Name = "Mouse"},
        };
        return Ok(products);
    }
```

- Bir API Controller ornegini yukardaki gibi yazdik.
- Burda bir urun sayfasi olusturmak istedigimiz zaman tek get metodu kullanmak zorunda olmak isi biraz zorlastirsada best practis uygulamasi bu sekilde yapilmalidir.
- Ornegin get metoduna parametre girerek birden fazla islem yapilir, gelen parametrelere gore dogru yanit verilir.
- Mesela urunlerin tamami gelmesi icin parametresiz calisir, id verilirse tek bir urun getirir gibi bir metod yazilmalidir.

## CORS Kavrami

- Cors, tarayici tarafindan web api'lere yapilan istekleri engellemek iicin web apilerde olan bir guvenlik katmanidir.
- Tarayicilar, cors acik degilken bir web sitesinden baska bir web api'a istek yapmazlar.
- Cors resharp ile yapilan isteklere takilmaz. Cunku restsharp ile tapilan istekcek tarayicidan gonderilmez, backhande sunucu tarafindan gonderilir.
- Tarayicida calisan teknolojiler Javascript tabanli teknolojilerdir. (Jquerry, React, Vue, Angular vb.)

- Cors'a takilmamak icin, eger api'ye erisimimiz yoksa (yani baskansinin yazdigi bir api kullaniyorsak) proxy sunucusu kullanabiliriz
- Ya da kendi yazdigimiz apiye baska sitelerden isten atilmasina izin vermek istiyorsak, kendi API'mize cors konfigrasyonu eklememiz gerekir.

- Program.cs dosyasina asagidaki configrasyonu ekleyebiliriz.

```C#
builder.Services.AddCors(option =>
{
    option.AddDefaultPolicy(policy =>
    {
        policy
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});
```

- Daha sonra calistirmak icin uygulamaya eklemek gerekir. Yine Program.cs dosyasina asagidaki satir eklenir.

```C#
app.UseCors();
```
