# Session

- Session uygulamalarda siklikla kullanilir
- Session icine key&value degerleri alir
- Session icine aldigi degerleri RAM'de tutar (gecici olarak depolar)
- Bu yuzden cookie gibi kalici degildir.
- Verileri bir controllerdan ve ya uygulamadan baska bir controller ve ya uygulamaya transfer icin kullanilir

1. Program.cs icinde ust tarafta konfigrasyonu yapilir

```C#
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromMinutes(30); // session suresini belirledik. 30 dk sonra verileri silecek

});

//
//
//

app.UseSession(); // session u calistrimak
```

2. SessionModel adindaki modeli newledikten sonra, `HttpContext.Session.SetString` metodu ile, key ve value vererek sessiona veri basabiliyoruz.

```C#
    HttpContext.Session.SetString("Email", model.Email);
    HttpContext.Session.SetString("Password", model.Password);
```

## Sessiona JSON veri basmak

Bunun icin nugetten [Newtonsoft](https://www.nuget.org/packages/Newtonsoft.Json) paketini kurduk

1. Student sinifindan bir nesne newledikten sonra bu neslenyi json formatina cevirelim ve sessiona atalim

```C#
    var studentJson = JsonConvert.SerializeObject(student);

    HttpContext.Session.SetString("OgrenciJson", studentJson);
```

2. Sessiondan gelen bir json veriyi tekrar Student tipine alalim;

```C#
    string ogrenciJson = HttpContext.Session.GetString("OgrenciJson");
    // once sessiondan string olarak veriyi aldik

    Student student =  JsonConvert.DeserializeObject<Student>(ogrenciJson);
    // sonra json formatinda string olarak gelen veriyi student tipine donusturduk
```

:warning: Odev; REDIS kurup, mvc ile redis'i entegre edip session verisini redis'e basiniz.
