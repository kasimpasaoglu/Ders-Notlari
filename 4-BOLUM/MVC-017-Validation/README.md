# Validation

Ekrandan alinan inputlarin dogru formda olmasi icin bazi kurallar kanilabilir,

- Validationlar front-end tarafinda HTML, ve ya JS ile yapilabilecegi gibi, back-end tarafinda da yapilabilir
- bir modelde valitation yapilmak istenen proplar icin asagidaki gibi ozellikler verilebilir

```C#
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

public class UserVM
{
    [MinLength(3, ErrorMessage = "Giris 2 karakterden daha uzun olmalidir")]
    [Required(ErrorMessage = "Ad Alani Bos Biraklamaz")] // name alani bos girlilememesini saglayacak
    public string Name { get; set; }

    [MaxLength(20, ErrorMessage = " E-Mail en fazla 20 karakter olabilir")]
    [Required(ErrorMessage = "E-Mail alani bos olamaz")]
    [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", ErrorMessage = "E-Mail adres uygun degil")]
    public string Email { get; set; }

    [Range(10, 70, ErrorMessage = "Yas 10-70 arasinda olmalidir")]
    public int Age { get; set; }


    [Required(ErrorMessage = "Sifre Alani bos birakilamaz")]
    public string Password { get; set; }

    [Compare("Password", ErrorMessage = "Sifreler ayni degil")]
    public string ConfirmPassword { get; set; }
}
```

- View icerisinde burda yazilan hata mesajlarini goruntulemek icin Razor elementleri kullanilabilir
- `@Html.ValidationMessageFor()` ile fieldlar meplenerek buraya yazilmaya calisilan verilerin valitationlarindaki hata mesajlarini sayfada gorunur yapariz.
- `@Html.ValidationMessageFor()` valitation icinde bir hata mesaji varsa HTML icinde bir `<span>` tagi olusturup mesaji onun icine yazar.

```HTML
@model UserVM

<form action="/Home/Index" method="post">

    @Html.TextBoxFor(s => s.Name)
    @Html.ValidationMessageFor(s => s.Name)
    <br>
    @Html.TextBoxFor(s => s.Email)
    @Html.ValidationMessageFor(s => s.Email)
    <br>
    @Html.TextBoxFor(s => s.Age)
    @Html.ValidationMessageFor(s => s.Age)
    <br>
    @Html.TextBoxFor(s => s.Password)
    @Html.ValidationMessageFor(s => s.Password)
    <br>
    @Html.TextBoxFor(s => s.ConfirmPassword)
    @Html.ValidationMessageFor(s => s.ConfirmPassword)
    <br>
    <input type="submit" value="Gonder">
</form>
```
