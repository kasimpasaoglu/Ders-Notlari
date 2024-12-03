# Get - Post Kavramlari

- Web sayfalari 2 sekilde calisiyor
  - `HttpGet` ile sayfanin talep edilmesi
  - `HttpPost` sayfayi bir parametre vererek sayfanin gonderilmesi

- Controllerda yazilan actionlar, default olarak `[HttpGet]` ozelligi tasir,
- Bir action sayfadan gelen bir degeri tasiyacaksa, actionun bir satir ustune `[HttpPost]` yazilmalidir. Sayfadan gelecek olan model, parametre olarak verilmelidir.

:bulb: Ornekte, `SaveUser` modeli yazildi ve view'dan gelen postun gidebilecegi action asagidaki sekilde yazildi

```C#
[HttpPost]
public IActionResult SaveUser(SaveUser model)
{
    return View();
}
```

- View tarafinda postun baslangic noktasi icin bir form'a `method="post"` attribute'u verildi
- Ayrica action olarakta `/Home/Saveuser/` -> HomeController'daki SaveUser, verildi

```HTML
<form method="post" action="/Home/SaveUser">
    <input type="text" name="UserName" id="input1" placeholder="User Name">
    <input type="submit" value="Kaydet">

</form>
```

- :warning: :warning:  Input alanina verilen `name` attribute'u model icindeki prop ile ayni ismi tasimalidir. Bu sayede C# inputlardan gelen verileri otomatik olarak modele mapler ve controller'a gonderir.
