# DLL Kod Kutuphanesi

**Dynamic Link Liblary** exe uzantili programlarin calisirken disardan ve ya kendi yazdigimiz bazi siniflari kullanmak icin bu siniflari DLL dosyasi icerisinde toplayabiliriz.

* exe ile dll arasindaki en onemli fark dll' de main metodu yoktur. bu yuzden dll dosyalari tek baslarina calistirilamazlar.
* zaten varolus amaclari baska uygulamalara yardimci olmaktir, calistirilmak degil.
* `dotnet new classlib` komutu ile bir class liblary olusturduk.

```C#
namespace dll_kutuphanesi;

public class Ogrenci
{

    public void Calis()
    {
        Console.WriteLine("Ogrenci Calisti");
    }
    public void Uyu()
    {
        Console.WriteLine("Ogrenci Uyudu");
    }
}
```

* kodlama bittikten sonra `dotnet build` komutu ile dll dosyasini olustururuz

* Olusturulan DLL dosyasi proje dosyalarindan `/bin/Debug/net8.0` dizininin icinde olacaktir.
* Bu kutuphaneyi kullanacagimiz projeyi acip, root icinde yeni bir klasor aciyoruz. orn; `libs`
* Olusturdugumuz DLL dosyasini bu klasore atiyoruz.
  * Bu dll dosyalarini import etmek icin terminale `dotnet add referance 'dizinyolu'` komutu kullanilabilir
  * ya da proje root klasorunde bulunan .csproj uzantili dosyaya bu sekilde `<ItemGroup>` etiketi ile eklenebilir

```csproj
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    .
    .
    .
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="dll_kutuphanesi">
      <HintPath>D:\GIT\Ders-Notlari\2-BOLUM\DLL-import-proje\libs\DLL-010-1.dll</HintPath>
    </Reference>
  </ItemGroup>

</Project>
  ```

* Bu islem bittikten sonra projeyi bir kez build yapmak icin `dotnet build` komutu calistirilir
* dll icindeki siniflari kullanmak icin namespace'i eklemek gerekmektedir
`using dll_kutuphanesi;`
  * using satiri eklemek istenmezse ;
  `dll_kutuphanesi.Ogrenci o = new dll_kutuphanesi.Ogrenci()`
* Artik dll icine yazdigimiz classlar kullanilabilir

```C#
Ogrenci o = new Ogrenci();
o.Calis();
```
