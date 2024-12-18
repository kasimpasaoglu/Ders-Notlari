# Fluent Validation Paketi

- [Paketi Indir](https://www.nuget.org/packages/FluentValidation.AspNetCore/)
- Program.cs dosyasina gerekli konfigrasyonlari yap;
  - `AddFluentValidationAutoValidation()` -> Otomatik model dogrulama - ModelState hatalari FluentValidation kurallarina gore otomatik olarak doldurur
  - `AddFluentValidationClientsideAdapters()` -> Istemci tarafi dogrulama - Istemci tarafinda (JS ile) dogrulama mesajlarinin calismasini saglar
  - `AddValidatorsFromAssemblyContaining<Program>()` -> Validator siniflarini kaynetme - Validatotr siniflarini otomatik olarak tarayip kaydeder, Program.cs icindeki assembly'den butun validationlari bulur.

```C#
builder.Services.AddFluentValidationAutoValidation(); 
builder.Services.AddFluentValidationClientsideAdapters(); 
builder.Services.AddValidatorsFromAssemblyContaining<Program>(); 
```

- Model Olustur

```C#
public class UserModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}
```

- Models, kalsorunde Validators klasoru acip `UserModelValidator.cs` dosyasi olustur. (klasor yapisi farketmez)
- UserModel icin validation'lar buraya yazilacak.

```C#
using FluentValidation;


public class UserModelValidator : AbstractValidator<UserModel>
{
    public UserModelValidator()
    {
        RuleFor(user => user.Name)
            .NotEmpty().WithMessage("Name cannot be empty")
            .Length(2, 50).WithMessage("Name must be between 2 and 50 characters");

        RuleFor(user => user.Email)
            .NotEmpty().WithMessage("Email cannot be empty")
            .EmailAddress().WithMessage("Invalid email format");

        RuleFor(user => user.Age)
            .InclusiveBetween(18, 99).WithMessage("Age must be between 18 and 99");
    }
}
```

> - :bulb: Kullanilabilecek hazir validationslar icin [bu sayfayi](https://docs.fluentvalidation.net/en/latest/built-in-validators.html) kontrol et.
> - :bulb: Kendi validatorunu yazmak icin [bu sayfayi](https://docs.fluentvalidation.net/en/latest/custom-validators.html) kontrol et.

---

## Kullanim Ornegi

- Controller;

```C#
public IActionResult Index()
{
    return View();
}
[HttpPost]
public IActionResult Index(UserModel model)
{
    if (!ModelState.IsValid)
    {
        return View(model);
    }
    return RedirectToAction("Privacy"); // Valid ise Privacy sayfasina yonlendirme yap.
}
```

- :warning: Program.cs te ekledigimiz `AddFluentValidationAutoValidation()` konfigrasyonu sayesinde FluentValidator model valid mi bilgisini direk ModelState'e atiyor. Bu sayede modelin valid olup olmadigini controller icinde yakalayabiliyoruz.

- View tarafinda bir form olusturup deneyelim

```HTML
@model UserModel

<form asp-action="Index" method="post" class="row g-3 ">
    <div class="col-md-6">
        <label for="Name" class="form-label">Name:</label>
        <input asp-for="Name" class="form-control" />
        <span asp-validation-for="Name" class="text-danger"></span>
    </div>
    <div class="col-md-6">
        <label for="Email" class="form-label">Email:</label>
        <input asp-for="Email" class="form-control" />
        <span asp-validation-for="Email" class="text-danger"></span>
    </div>
    <div class="col-md-6">
        <label for="Age" class="form-label">Age:</label>
        <input asp-for="Age" class="form-control" />
        <span asp-validation-for="Age" class="text-danger"></span>
    </div>
    <div class="col-12">
        <button type="submit" class="btn btn-primary">Register</button>
    </div>
</form>

@section Scripts {
    <partial name="_ValidationScriptsPartial" />
}
```

- :warning: En altta cagrilan script razordaki `asp-validation-for` ile dogrulama kullanirken backhande gelmeden Fluent Validation'un istemci tarafinda dogrulama yapmasi icin ASP.NET core tarafindan olusturulmus bir scripttir.
- Projede hazir olarak gelir. `Views/Shared/` icinde bulunur.
- Burda `@section Scripts {}` komutu bir Razor ozelligidir. `<script>` tagini otomatik olarak sayfanin dogru yerine ekleyecektir ve icine partial olarak cagirdigimiz ASP.NET Core'a ait Validation Script'i yazacaktir.
  - `@HTML.TextBoxFor()` gibi bir ozellik.
- Script eklemek tercihe bagli. Validationu backhand'de yapmak istenirse kaldirilabilir.
