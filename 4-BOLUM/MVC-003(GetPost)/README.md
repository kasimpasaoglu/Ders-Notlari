# Get & Post Kullanimi Ornegi

## 1. Model

- Models klasoru icine [model](/4-BOLUM/MVC-003(GetPost)/Models/Auth/SaveUserViewModel.cs) olusturuyoruz
  - 3 Cesit model olusturulabilir
    1. View Model
    2. DTO Model
    3. DMO (Data Model Object)
:bulb: Bu ornekteki model bir ViewModeldir.

## 2. Controller

- Controllers klasoru icinde bir [controller](/4-BOLUM/MVC-003(GetPost)/Controllers/AuthController.cs) yaziyoruz.
  - Get ve Post icin iki ayri controller yazilmasi gerekli,
  - Get actionu icin bir islem yapmaya gerek yok, sayafaya bir model gondermiyoruz
  - post actionu icini ilerde ogrenecegimiz (ornegin veritabanina yazma) islemlerden sonra ekrana sonuc basariliysa bilgiyi model icine ekleyip view'a gonderecegiz

```C#

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult SaveUser()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveUser(SaveUserViewModel model)
    {
        // gelen model ile yapilacak islemler burda yapildi ve tamamlandi
        // sayfaya gonderecegimiz modeli olusturalim
        SaveUserViewModel returnModel = new SaveUserViewModel();
        // modelin icindeki IsOk degiskenini true'ya donusturelim
        returnModel.IsOk = true;
        // ve modeli gonderelim
        return View(returnModel);
    }

}
```

## 3. View Kismi

- Views klasorunde [Saveuser.cshtml](/4-BOLUM/MVC-003(GetPost)/Views/Auth/SaveUser.cshtml) dosyasini olusturalim.

- Viewslar cshtml denen gelismis bir html yapisi ile olusturulur.
- cshtml dosyalari hem c# hem de html kodlarinin birlikte yazilabilecegi dosyalardir.
- C# v ya razor kodu yazilmak isteniyorsa basina `@` isareti konur.
- :warning: Gelen modeli tanimlamak icin sayfanin basina `@model SaveUserViewModel` komutu eklenir. burda gelecek olan modelin tipi viewa soylenmis olur.
- Ornekte input elementi olusturmak icin [Razor Elementleri](https://learn.microsoft.com/en-us/aspnet/core/blazor/components/built-in-components?view=aspnetcore-9.0) kullandik.

```C#
@Html.TextBoxFor(s => s.Name, new { @class = "mb-3 form-control", placeholder = "Enter Your Name" })
```

- Bu sekilde yazim yontemi ile, inputlardaki, `name` attribute alanlarini Razor otomatik olarak mapleyerek modelin icindeki proplarin isimlerini verecek.
