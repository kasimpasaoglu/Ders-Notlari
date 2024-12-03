# Return Content

Bir actionun model gondermek yerine dogrudan bir string gondermesi mumkundur. Genelde string json formatinda gonderilip view tarafinda javascriptten bilgidimiz fetch metodu ile kuallanilabilir

```C#
public IActionResult GetContent()
{

    return Content("Ben Bir Mesajim");
}
```

- Bu action geriye direk string donecek, cshtml sayfasinda bu actionu cagirdigimiz yere `/Home/GetContent` yazdigimizda bu contenti getirecektir.

```CSHTML
<a href="/Home/GetContent" target="_blank" rel="noopener noreferrer">Siteye Git</a>
```

> Mesela bu linke tiklandiginda ekranda sadece Ben Bir Mesajim metni olacaktir.

- Content bir view degildir, bu actiona gelindiginde ekranda sadece metin gorunecek
- Content ile her turlu veri gonderilir.
- `return Content("{\"message\":\"ben bir mesajim\"}");` -> bu sekilde yazilabilirse json olarak view tarafinda erisilebilir
- Ve ya bir modeli json formatinda gondermek icin `Json()` metodu icinde model yazilabilir.
- json tipine cevirdigimiz tipi Index viewda js fetch metodu ile kullaniriz.

```C#
public IActionResult GetContent()
{

    return Json(new IndexViewModel()
    {
        Description = " Piyasanin En iyisi",
        Name = "Klima",
        Id = 5
    });
}
```

> bu sekilde modelimizi json formatina cevirip string olarak view'a gondermis olduk. Simdi view tarafinda js ile fetch yapip bu veriyi alalim

```html
<script>
    window.onload = function () {
        fetch('/Home/GetContent')
            .then(res => res.json())
            .then(data => {
                // burda data uzerinden artik gelen veriye erisebilir, ve sayfada nasil gorunecegini ayarlayabiliriz.
            })
    }
</script>
```
