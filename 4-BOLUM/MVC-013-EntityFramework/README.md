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

 Bu ornekte Code First yapacagiz
