# Entity Framework

C# ile gelistirilmis uygulamalar iki sekilde veri tabanina erisim saglayabilir

1. ADO.Net artik demode olmus bir baglanti seklidir. Sebebi, verileri cekme zorlugu ve veri tabaniyla calisirken uzun kod bloklari yazma zorunlugudur. Ayrica yazilimin icinde sql querryleri kullanilmak zorundaydi. Bu da veritabaninda herhangi bir degisiklik yapildiginda, degisikliklerin kod tarafinda da yapilmasi gerekmekteydi.
2. Entity Framework, Tum bu zorluklar microsoftun yeni bir veritabani baglanti turu gelistirmesi ile son buldu. Modrn uygulamalarda yazilim ve veri tabani baglantilari entity framework ile yapilmakta.

## Kurulum

3 adet paketimiz var indirmemiz gereken

1. [Entity Framework Core](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)
2. [SqlServer](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer)
3. [Tools](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools)

Entity Frameworkte iki yaklasim vardir.

1. Code First: Veritabani semasini sifirdan C# ile kodlamak.
2. DB First: Mevcut bir veritabani alip C# uzerinde kullanmak.

:bulb: Bu ornekte Code First yapacagiz

## Model (DMO) Olusturma

- root dizininde Context diye bir klasor acip, icinde `BooksContext.cs` dosyasi ve `DbModel` klasorlarini olusturuyoruz. `DbModel` klasoru icinde olusturacagimiz viewlar, Database'in tablolaridir. Daha once duydugumuz 3 adet modelden biri bunlardir. **DMO (Data Model Object)**
- `BooksContext.cs` ise veritabanin kendisidir. EntityFramework ilk calistirmada sunucuda olusacak database'e verecegi ismi burdan alir.
- [Book.cs](/4-BOLUM/MVC-013-EntityFramework/Context/DbModel/Book.cs) `DMO` olarak databasedeki tablonun kolonlari tanimladik.

- BooksContext.cs Dosyasinda veritabanina tabloyu ekleme islemini, ve parametre olarak gelecek olan connection stringi almasi icin ctorunu ayarliyoruz

```C#
public class BooksDBContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options)
    {
    }
}
```

- :warning: Database Context'i kesinlikle DbContext sinifindan kalitilmalidir!!!
- BooksDBContext olusturuluacak olan database'in adidir
- Icine prop olarak ekledigimiz `Books`, Database'in icindeki Tablonun adidir
- `DbSet<>` denen generic bir kolleksiyon kullanarak, tipine `Book` DMO'sunu tasiyacak. Bu sayede olusacak olan Books tablosunun kolonlari az once yazdigimiz Book DMO'sundan gelecektir.
- Ctor'da `DbContextOptions<>` generic kolleksiyonuna tip olarak database'i veriyoruz. Buraya gelecek olan parametreler ayarlama ile ilgili olacagi icin `options` kullaniyoruz.
- :warning: bu ctoru direk base'e yonlendirimek zorundayiz. Yani bu ctor gelen parametrelri direk `DbContext` sinifinin ctoruna yonlendirme yapacak. baska bir islevi yok(simdilik).

---

## Program.cs Konfigrasyonu

- Burasi tamamlandiktan sonra Program.cs dosyasinda, gerekli parametreyi (connection string) verip calismasini saglayacagiz.
- `builder.Services` icindeki `AddDbContext<>` Generic metodunu calistiriyoruz.

```c#
builder.Services.AddDbContext<BooksDBContext>(option => option.UseSqlServer("!!Connection String Buraya Yazilacak!!"));
```

parametre olarak option kismina `UseSqlServer()` metoduna connection strigni verip gonderiyoruz.

- Connection string buraya dogrudan yazilabilecegi gibi, root dizinde olan `appsettings.json` dosyasinda da tutulabilir.

---

## Terminal Komutlari

Bu adimlar tamamlandiktan sonra terminale komutlar girilecek

- `dotnet tool install --global dotnet-ef` -> Bu komut Entity Framework'un komut satiri araclarini yukleyecek. dotnet-ef komutlarini kullanmamiz icin gerekli
- `dotnet ef migrations add <MigrationName>` -> Entity Framework'un Migration sistemini baslatir ve projedeki model degisiklerine gore bir migration dosyasi olusturur. Root dizinde `Migrations` diye bir klasor olusacaktir
  - `<MigrationName>`kismina kendimiz bir isim verebiliriz.  or: `dotnet ef migrations add InitialCreate`
- `dotnet ef database update` -> Bu komut olusturulan migration'u veritabanina uygular. Yani bu ornekte books gibi tablolari olusturur.
- Yeni degisiklikler yapilirsa, ornegin Book modeline yeni bir kolon eklenirse, yeni bir migration olusturulmasi gerekir. `dotnet ef migrations add AddNewColumnToBooks`

---

## Ilk veri basma islemi

Kullanmak istedigimiz Controller'da Veritabanin tipinde bir prop tanimlayip bunu bir ctor icinde eslemesini yapiyoruz

```C#
    private BooksDBContext _context;

    public HomeController(BooksDBContext context)
    {
        _context = context;
    }
```

- Boylece bu controllera gidildiginde veritabanindan gelen veriler artik _context propu icinde erisilebilir, degistirilebilir, ekleneip silinebilir.

```C#
    public IActionResult Index()
    {
        _context.Add(new Book { Name = "Book1", Price = 150, Stock = 10 });
        _context.Add(new Book { Name = "Book2", Price = 160, Stock = 9 });
        _context.Add(new Book { Name = "Book3", Price = 110, Stock = 18 });
        _context.Add(new Book { Name = "Book4", Price = 90, Stock = 8 });
        _context.Add(new Book { Name = "Book5", Price = 125, Stock = 7 });
        _context.Add(new Book { Name = "Book6", Price = 112, Stock = 1 });
        _context.Add(new Book { Name = "Book7", Price = 118, Stock = 3 });
        _context.Add(new Book { Name = "Book8", Price = 124, Stock = 7 });
        _context.Add(new Book { Name = "Book9", Price = 138, Stock = 15 });
        _context.Add(new Book { Name = "Book10", Price = 174, Stock = 12 });

        _context.SaveChanges();
        return View();
    }
```

- :warning: `SaveChanges()` metodunu kullanmadan yaptigimiz degisiklikler database e gitmez, localde ramde tutulur.

## Veri Sorgulama Islemi

- yine `_context` kullanarak veri sorgusu yapariz

```C#
    public IActionResult GetBooksWithDatabase()
    {
        List<Book> books = _context.Books.ToList();
        return View();
    }
```

- **LINQ** ile daha karisik sorgular yapabiliriz

```C#
    public IActionResult GetBookNames()
    {
        List<BooksViewModel> books = _context.Books.Select(s => new BooksViewModel()
        {
            Id = s.Id,
            Name = s.Name,
        }).ToList();
        return View();
    }
```

- Sadece Id ve Name kolonlarini cektik.

---

## Onemli Detaylar

- Entity Framework sorgulama yaparken C# ta yazilan **LINQ** sorgularini SQL Querry'sine donusturur.

- Tablo olusturmak icin kullandigimiz Class'i(DMO) **kesinlikle** bir ViewModel olarak kullanmiyoruz
  - Uzun vadede, ve buyuk projelerde, viewmodel uzerinde degisiklik yapmak isteyebiliriz. DMO'da yapilan degisiklik veritabanina yansir, ve buyuk sorunlara yol acar.

- Her View'in bir ViewModeli olur, sayfadan gelen verileri veritabanina basmak icin, veri tabaninin modeli olan DMO' ya maplemek gerekir
  - Ancak dogrudan bir ViewModel'den DMO ya mapleme yapilmamasi da gerekir.
  - Bunu yapmak icin Bir DTO (Data Transfer Object) modeli yapariz.
  - ViewModeli once DTO'ya, ve ordan da DMO ya mapleyip o sekilde veri tabanina yazacagiz.
- Sorgulama yaparken `.ToList()` nereye gelirse oraya kadar olan kismi sorguya gonderir. Yani;

>Dogru Yontem

```C#
List<BooksViewModel> books = _context.Books.Where(s => s.Id == 1).ToList();
```

>Yanlis Yontem

```C#
List<BooksViewModel> books = _context.Books.ToList().Where(s => s.Id == 1);
```

- Sebebi; ilk ornekte EF database'e gidip id'si 1 olanlari getirecek
- Ikinci ornekte database'e gidip butun Books tablosunu getirecek, tablo geldikten sonra filtrelemeyi uygulayacak.
- Bu ozellikle tablolar buyugudu zaman veritabani tarafinda ciddi performans sorunlarina yol acar.
