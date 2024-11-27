# MVC

Terminalden  `dotnet new mvc` komutu ile mvc templateini olusturduk.

## MVC Nedir?

![Resim](https://upload.wikimedia.org/wikipedia/commons/f/fd/MVC-Process.png)

- Model View Controller
- Web tarafinda backhand ve frontend beraber calistirmak icin kullanilan bir pattern'dir.

## Klasor Yapisi

- Program.cs dosyasi sadece ayarlamalari yapacagimiz kisimlari olusturacak

- Models klasoru, bos templatelerin oldugu(classlarin) yerdir. Burda sayfalarda kullanilabilecek C# classlari yer alir.

```C#
public class Ogrenci
{
    public int Id { get; set; }
    public string Name { get; set; }
}
// /Models/Ogrenci.cs dosyasi
```

- Controller klasoru icinde ekranda gosterilecek olan veriler yazilir. Yani veri kaynagindan bir veri cekilir.
  - Hazirlanan veri, model denilen yapilarin icine yerlestirilir.
  - Burda model denilen yapilar models klasoru icindeki model ile karistirilmamali.
  - Bu modelleri olusturmak icin `Action` denen metod turleri kullanilir.
    - Bu **action** lar aslinda mantik olarak `C#` metodlari gibi olsa da, geri dondurdukleri deger olarak `IActionResult` oldugu icin `MVC` bunlari action diye tanimlar

    ```C#
    // Adi index oldugu icin bu metod view'e giderken Index isimli dosyayi arayip verileri oraya birakir
        public IActionResult Index()
    {
        // model buraya yazilir, Ornegin bir classtan ogeler newlenip GenericList icine konur
        return View(modelAdi);
        // model adi view metodu icine yazilir ve gonderilir.
        // Action'umuzun isminin bir sebepten dolayi farkli olmasini istiyorsak;
        // yani index yerine baska birsey yazsin, 
        // bunun icin View Metoduna iki parametre yazabiliriz,
        // ilk parametre string olarak, gitmesini istedigimiz View html dosyasinin adi,
        // ikinci parametre ise yine yukardaki gibi modelimizin adi yazilabilir

    }
    ```

- Views klasoru kullanaciya gosterecegimiz ekrandir. Index.cshtml adinda bir dosya mevcuttur.
  - her sayfa icin fiziken yeni bir .cshtml dosyasi olusturulur
  - burda html kodu yazilabildigi gibi C# kodu da yazilabilir
    - Bunun sebebi `Razor` denilen Microsoftun gelistirdigi bir yapidir.
    - Razor, C# + HTML kodunu view enginde'den gecirerek Pure HMTL kodu olusur ve tarayiciya bunu gonderir.

ORNEK: Olusturdugumuz Ogrenci classindan bir liste olusturup view'a gonderelim

- Controller da Index'e ait olan action'a listeyi olusturduk

```C#
    public IActionResult Index()
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>(){
            new Ogrenci {Id=1, Name="Ahmet"},
            new Ogrenci {Id=2, Name="Mehmet"}
        };
        return View(ogrenciler);
    }
```

```cshtml
@model List<Ogrenci>;

<ul>
    @foreach (var item in Model)
    {
        <li>@item.Name</li>
    }
</ul>
```

- :warning:`@model List<Ogrenci>;` kodu sayfanin basina yazilmadan controllerden gelen veriye erisemeyiz.
- `@model 'veritipi'` sekilinde veri tipi belirtilmesi gereklidir
