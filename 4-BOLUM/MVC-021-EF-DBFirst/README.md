# DB First

Uygulamanin veri tanina baglanmasi 3 farkli sekilde yapilir demistik

- ADO.Net : Eski yontem, hantal
- Entity Framework (Code-First) : Bu yontemde veritabani yoktur, veritabani yazilan C# kodlariyla olusturulur
- Entity Framework (Db-First) : Bu yontemde veritabani vardir, ve bu veritabanina yazilim tarafindan ulasmak ve kullanmak icin bazi yontemler uygulanir
- Dopper : kolay ve basit bir pakettir, hizli sekilde veri tabanina baglanir. Ancak dopper arkaplanda ADO.net kullanmaktadir.

- Bu Projede DB-First calismasi yapacagiz
- Mevcut olan bir veritabanin icindeki butun tablolari ve kolonlari C# tarafinda DMO modele cevirecek bir komut ile bu islem yapilir.

## Baslangic

- EF icin gerekli paketleri nugetten indiriyoruz
- <https://www.nuget.org/packages/Microsoft.EntityFrameworkCore>
- <https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Tools>
- <https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer>

- Connection string gibi ilerde calismasini dusundugumuz seyleri root dizinde bulunan `appsettings.json` dosyasini kullanarak tanimlayabiliriz.
- Bu dosya hicbir zaman DLL ve EXE icine girmez. Program olusturulurken okunur ve calistiktan sonra bir daha okunmaz.

```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=db11596.public.databaseasp.net; Database=db11596; User Id=db11596; Password=i#5G!Tc2p6J+; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"
  }
}
```

- Bu duzenlemeyi yaptiktan sonra asagidaki komutu terminalde calistiyoruz.

```bash
dotnet ef dbcontext scaffold "Name=DefaultConnection" Microsoft.EntityFrameworkCore.SqlServer --output-dir DMO --context-dir DataAccessLayer --context AdventureWorksContext
```

>- `--output-dir` parametresi ile DMO'larin gelmesi istedigimiz klasoru seciyoruz, Klasor yoksa kendisi olusturuyor
>- `--context-dir` parametresi ile veritabani main classinin gelecegi klasoru veriyoruz,
>- `--context` parametresi ile Vertabani main classinin adini verebiliyoruz.

- Scaffold otomatik olarak `appsettings.json` icindeki `DefaultConnection` a gidip ordaki connection stringi kullaniyor ve DMO'lari olusturuyor.
- Sonraki adimda artik veri tabanina program icinde erisebilmek icin. `Program.cs` dosyasina da connection stringi vermemiz gerekiyor.
- `builder.Configuration.GetConnectionString("DefaultConnection")` ile `appsettings.json` dosyasi icindeki `DefaultConnection` keyine ait value'ya erisim saglayabiliyoruz.

```C#
builder.Services.AddDbContext<AdventureWorksContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
```

- Burdan sonrasi daha once gordugumuz Entity framework kullanimi ile ayni sekilde kullanilabilir.
- Veritabaninda, tablolarda vs. bir degisiklik yapildigi zaman, yukardaki `scaffold` komutunu tekrar calistirarak guncellemeleri alabiliriz.
